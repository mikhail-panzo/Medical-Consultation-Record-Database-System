Imports IBM.Data.DB2

Public Class ProcSampleLab
    Public intMKey As Integer

    Dim intKey As Integer
    Dim intSKey As Integer

    Private Sub ProcSampleLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridProcSamples.ReadOnly = True
        With dgridProcSamples
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Processed Sample No."
            .Columns(0).Width = 200
            .Columns(1).HeaderCell.Value = "Sample No."
            .Columns(1).Width = 100
            .Columns(2).HeaderCell.Value = "Med Tech ID"
            .Columns(2).HeaderCell.ToolTipText = "ID of the Med Tech processing the sample"
            .Columns(2).Width = 100
            .Columns(3).HeaderCell.Value = "Lab Test Type"
            .Columns(3).Width = 250
            .Columns(4).HeaderCell.Value = "Lab Test No."
            .Columns(4).HeaderCell.ToolTipText = "The Lab test order the sample is for (null means the sample is independent of any lab test order)"
            .Columns(4).Width = 100
            .Columns(5).HeaderCell.Value = "Specimen Type"
            .Columns(5).Width = 250
            .Columns(6).HeaderCell.Value = "Patient"
            .Columns(6).Width = 250
            .Columns(7).HeaderCell.Value = "Medical Technologist"
            .Columns(7).HeaderCell.ToolTipText = "The Med Tech processing the sample for results"
            .Columns(7).Width = 250
        End With

        Clear()

    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select ProcSampleNo, SampleNo, MedTechID, ProcLabTestType, LabTestNo, SpecimenType, PName, MName from PROC_SAMPLE_FULL_DETAIL"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridProcSamples.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        intSKey = 0
        txtLabTestType.Text = ""
        txtSampleNo.Text = ""
        txtMedTechID.Text = ""
        txtLabTestNo.Text = ""
        lblSpecimenType.Text = ""
        lblSourcePatient.Text = ""
        lblMedTechName.Text = ""
        lblLabTestType.Text = ""
        lblPhysicianName.Text = ""
        lblSelectedNo.Text = "NONE"
    End Sub

    Private Sub dgridProcSamples_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridProcSamples.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridProcSamples.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                lblSelectedNo.Text = intKey
                txtSampleNo.Text = dsRow.Cells(1).Value.ToString()
                txtMedTechID.Text = dsRow.Cells(2).Value.ToString()
                txtLabTestType.Text = dsRow.Cells(3).Value.ToString()
                txtLabTestNo.Text = dsRow.Cells(4).Value.ToString()
                lblSpecimenType.Text = dsRow.Cells(5).Value.ToString()
                lblSourcePatient.Text = dsRow.Cells(6).Value.ToString()
                lblMedTechName.Text = dsRow.Cells(7).Value.ToString()

                Con.Open()

                sql = "select DName, OrderLabTestType from PROC_SAMPLE_FULL_DETAIL where SampleNo = " & intKey
                adapter = New DB2DataAdapter(sql, Con)
                builder = New DB2CommandBuilder(adapter)
                dt = New DataTable
                    adapter.Fill(dt)

                Try
                    lblPhysicianName.Text = dt.Rows(0).Item(0).ToString()
                    lblLabTestType.Text = dt.Rows(0).Item(1).ToString()
                Catch ex As Exception
                    Con.Close()
                End Try

                Con.Close()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If (
            txtLabTestType.Text = "" Or
            txtSampleNo.Text = "" Or
            txtMedTechID.Text = ""
            ) Then
            MsgBox("Input the necessary processed sample information")
        ElseIf Not IsNumeric(txtSampleNo.Text) Then
            MsgBox("Enter a valid Sample Number")
        ElseIf Not IsNumeric(txtMedTechID.Text) Then
            MsgBox("Enter a valid Med Tech ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intSampleID As Integer = CInt(txtSampleNo.Text)
            Dim intMedID As Integer = CInt(txtMedTechID.Text)
            Dim boolIncludeLabTestNo As Boolean = False
            Dim boolSkip As Boolean = False
            Dim intLabTestNo As Integer = 0

            Con.Open()

            sql = "select SampleNo from SAMPLE"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intSampleID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Sample with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If
            boolFound = False

            sql = "select MedTechID from MED_TECHNOLOGIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intMedID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Med Tech with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If

            If Not txtLabTestNo.Text = "" Then
                If Not IsNumeric(txtLabTestNo.Text) Then
                    If MsgBox("The Lab Test No. you inputted is invalid. Proceed to add entry without a Lab Test No.?", vbYesNo) = vbNo Then
                        Con.Close()
                        Exit Sub
                    Else
                        boolSkip = True
                    End If
                ElseIf Not boolSkip Then
                    intLabTestNo = CInt(txtLabTestNo.Text)
                    boolFound = False

                    sql = "select LabTestNo from LAB_TEST"
                    cmd = New DB2Command(sql, Con)
                    dt = New DataTable
                    adapter = New DB2DataAdapter(cmd)

                    adapter.Fill(dt)

                    For Each drRow As DataRow In dt.Rows
                        If intLabTestNo = drRow(0) Then
                            boolFound = True
                            Exit For
                        End If
                    Next

                    If boolFound Then
                        boolIncludeLabTestNo = True
                    Else
                        If MsgBox("The Lab Test No. you inputted does not exist. Proceed to add entry without a Lab Test No.?", vbYesNo) = vbNo Then
                            Con.Close()
                            Exit Sub
                        End If
                    End If
                End If
            End If

            sql = "insert into PROCESSED_SAMPLE(SampleNo, MedTechID, LabTestType) values (" & intSampleID & "," & intMedID & ",'" & txtLabTestType.Text & "')"

            cmd = New DB2Command(sql, Con)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As DB2Exception
                MsgBox(ex.Message)
                MsgBox("The entry contains a Sample Number of a sample that has already been processed. Input for an unprocessed sample.")
                Con.Close()
                Exit Sub
            End Try

            If boolIncludeLabTestNo Then
                sql = "update PROCESSED_SAMPLE set LabTestNo = " & intLabTestNo & " where SampleNo = " & intSampleID
                cmd = New DB2Command(sql, Con)
                cmd.ExecuteNonQuery()
            End If

            If boolIncludeLabTestNo Then
                sql = "select LabTestMRN, SampleMRN, ProcLabtestType, OrderLabTestType from PROC_SAMPLE_FULL_DETAIL where SampleNo = " & intSampleID
                cmd = New DB2Command(sql, Con)
                dt = New DataTable
                adapter = New DB2DataAdapter(cmd)
                adapter.Fill(dt)

                If Not dt.Rows(0).Item(0) = dt.Rows(0).Item(1) Then
                    sql = "delete from PROCESSED_SAMPLE where SampleNo = " & intSampleID
                    cmd = New DB2Command(sql, Con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Invalid entry: The Lab Test order and Sample does not match the patients")
                    Con.Close()
                    Exit Sub
                ElseIf Not dt.Rows(0).Item(2).ToString().ToLower = dt.Rows(0).Item(3).ToString().ToLower Then
                    sql = "delete from PROCESSED_SAMPLE where SampleNo = " & intSampleID
                    cmd = New DB2Command(sql, Con)
                    cmd.ExecuteNonQuery()
                    MsgBox("Invalid entry: The Lab Test order and Sample does not match the Lab Test Type")
                    Con.Close()
                    Exit Sub
                End If
            End If

            MsgBox("New processed sample data added")

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        If txtSampleNo.Text = "" Then
            MsgBox("Enter a Sample Number")
            lblSpecimenType.Text = ""
            lblSourcePatient.Text = ""
            intSKey = 0
        ElseIf Not IsNumeric(txtSampleNo.Text) Then
            MsgBox("Enter a valid Sample Number")
            lblSpecimenType.Text = ""
            lblSourcePatient.Text = ""
            intSKey = 0
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtSampleNo.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select SampleNo, SpecimenType, PName from SAMPLE_FULL_DETAIL"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intID = drRow(0) Then
                    boolFound = True
                    Exit For
                Else
                    intCount = intCount + 1
                End If
            Next

            If boolFound Then
                lblSpecimenType.Text = dt.Rows(intCount).Item(1).ToString()
                lblSourcePatient.Text = dt.Rows(intCount).Item(2).ToString()
                intSKey = CInt(txtSampleNo.Text)
            Else
                lblSpecimenType.Text = ""
                lblSourcePatient.Text = ""
                MsgBox("Sample with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub btnMedTechView_Click(sender As Object, e As EventArgs) Handles btnMedTechView.Click

        If txtMedTechID.Text = "" Then
            MsgBox("Enter a Med Tech ID number")
            lblMedTechName.Text = ""
        ElseIf Not IsNumeric(txtMedTechID.Text) Then
            MsgBox("Enter a valid Sample Med Tech ID number")
            lblMedTechName.Text = ""
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtMedTechID.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select MedTechID, FName, LName from MED_TECHNOLOGIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intID = drRow(0) Then
                    boolFound = True
                    Exit For
                Else
                    intCount = intCount + 1
                End If
            Next

            If boolFound Then
                lblMedTechName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
            Else
                lblMedTechName.Text = ""
                MsgBox("Med Tech with the specified ID does not exist")
            End If

            Con.Close()
        End If



    End Sub

    Private Sub btnLabTestView_Click(sender As Object, e As EventArgs) Handles btnLabTestView.Click

        If intSKey = 0 Then
            MsgBox("Please select a Sample Number before searching for Lab Test Number")
        ElseIf txtLabTestNo.Text = "" Then
            lblLabTestType.Text = ""
            lblPhysicianName.Text = ""
        ElseIf Not IsNumeric(txtLabTestNo.Text) Then
            MsgBox("Enter a valid Lab Test Number")
            lblLabTestType.Text = ""
            lblPhysicianName.Text = ""
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtLabTestNo.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select l.LabTestNo, s.SampleNo, l.DName,  l.LabTestType from LAB_TEST_DOCTOR l INNER JOIN SAMPLE s ON l.PatientMRN = s.PatientMRN"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intID = drRow(0) And intSKey = drRow(1) Then
                    boolFound = True
                    Exit For
                Else
                    intCount = intCount + 1
                End If
            Next

            If boolFound Then
                lblPhysicianName.Text = dt.Rows(intCount).Item(2).ToString()
                lblLabTestType.Text = dt.Rows(intCount).Item(3).ToString()
            Else
                lblLabTestType.Text = ""
                lblPhysicianName.Text = ""
                MsgBox("Lab Test with the specified ID and matching patient sample does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub ProcSampleLab_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If intMKey = 0 Then
            txtMedTechID.Text = ""
        Else
            Con.Open()
            sql = "select MedTechID, FName, LName from MED_TECHNOLOGIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intMKey = drRow(0) Then
                    txtMedTechID.Text = intMKey
                    lblMedTechName.Text = drRow(1).ToString() + " " + drRow(2).ToString()
                    Exit For
                End If
            Next
            Con.Close()

            intMKey = 0
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        If intKey = 0 Then
            MsgBox("Select a processed sample to process results")
        Else
            LabResult.TopMost = True
            LabResult.intProcSampleNo = intKey
            LabResult.Populate()
            LabResult.TopMost = True
            LabResult.Show()
        End If
    End Sub

End Class
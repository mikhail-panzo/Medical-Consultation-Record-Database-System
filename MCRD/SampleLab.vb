Imports IBM.Data.DB2

Public Class SampleLab
    Public intRKey As Integer

    Dim intKey As Integer

    Private Sub SampleLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtTime.Value = DateTime.Now
        Populate()
        dgridSamples.ReadOnly = True
        With dgridSamples
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Sample No."
            .Columns(0).Width = 150
            .Columns(1).HeaderCell.Value = "Receptionist No."
            .Columns(1).HeaderCell.ToolTipText = "The ID of the Receptionist collecting the sample"
            .Columns(1).Width = 150
            .Columns(2).HeaderCell.Value = "Patient MRN"
            .Columns(2).HeaderCell.ToolTipText = "Patient Medical Record Number"
            .Columns(2).Width = 150
            .Columns(3).HeaderCell.Value = "Specimen Type"
            .Columns(3).Width = 250
            .Columns(4).HeaderCell.Value = "Patient"
            .Columns(4).Width = 250
            .Columns(5).HeaderCell.Value = "Receptionist"
            .Columns(5).Width = 250
            .Columns(6).HeaderCell.Value = "Date"
            .Columns(6).HeaderCell.ToolTipText = "Date of Collection"
            .Columns(6).Width = 100
            .Columns(7).HeaderCell.Value = "Time"
            .Columns(7).HeaderCell.ToolTipText = "Time of Collection"
            .Columns(7).Width = 100
        End With

        Clear()
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select SampleNo, ReceptionistNo, PatientMRN, SpecimenType, PName, RName, DateOfCollection, stTime from SAMPLE_FULL_DETAIL"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridSamples.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtPatientMRN.Text = ""
        txtReceptionistNo.Text = ""
        lblPatientName.Text = ""
        lblReceptionistName.Text = ""
    End Sub

    Private Sub dgridSamples_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridSamples.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridSamples.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtReceptionistNo.Text = dsRow.Cells(1).Value.ToString()
                txtPatientMRN.Text = dsRow.Cells(2).Value.ToString()
                txtSpecimenType.Text = dsRow.Cells(3).Value.ToString()
                lblPatientName.Text = dsRow.Cells(4).Value.ToString()
                lblReceptionistName.Text = dsRow.Cells(5).Value.ToString()
                dtDate.Value = dsRow.Cells(6).Value
                dtTime.Value = Convert.ToDateTime(dsRow.Cells(7).Value.ToString())
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtPatientMRN.Text = "" Then
            MsgBox("Enter a Patient MRN")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf txtReceptionistNo.Text = "" Then
            MsgBox("Enter a Receptionist Number")
        ElseIf Not IsNumeric(txtReceptionistNo.Text) Then
            MsgBox("Enter a valid Receptionist Number")
        ElseIf txtSpecimenType.Text = "" Then
            MsgBox("Enter specimen type")
        Else
            Dim boolFound As Boolean = False
            Dim intRecID As Integer = CInt(txtReceptionistNo.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text

            Con.Open()

            sql = "select ReceptionistNo from LAB_RECEPTIONIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intRecID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Receptionist with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If
            boolFound = False

            sql = "select PatientMRN from PATIENT"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If stPatientMRN = drRow(0).ToString() Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Patient with the specified MRN does not exist")
                Con.Close()
                Exit Sub
            End If

            sql = "insert into SAMPLE(ReceptionistNo, PatientMRN, SpecimenType, DateOfCollection, TimeOfCollection) values ('" & intRecID & "','" & stPatientMRN & "','" & txtSpecimenType.Text & "','" & dtDate.Value.ToString("yyyy-MM-dd") & "','" & dtTime.Value.ToString("HH:mm:ss") & "')"
            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("New sample data added")

            Con.Close()
            Populate()
        End If



    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf txtReceptionistNo.Text = "" Then
            MsgBox("Enter a Receptionist Number")
        ElseIf Not IsNumeric(txtReceptionistNo.Text) Then
            MsgBox("Enter a valid Receptionist Number")
        ElseIf txtSpecimenType.Text = "" Then
            MsgBox("Enter specimen type")
        Else
            Dim boolFound As Boolean = False
            Dim intRecID As Integer = CInt(txtReceptionistNo.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text

            Con.Open()

            sql = "select ReceptionistNo from LAB_RECEPTIONIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intRecID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Receptionist with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If
            boolFound = False

            sql = "select PatientMRN from PATIENT"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If stPatientMRN = drRow(0).ToString() Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Patient with the specified MRN does not exist")
                Con.Close()
                Exit Sub
            End If

            sql = "update SAMPLE set ReceptionistNo = " & intRecID & ", PatientMRN = '" & stPatientMRN & "', SpecimenType = '" & txtSpecimenType.Text & "', DateOfCollection = '" & dtDate.Value.ToString("yyyy-MM-dd") & "', TimeOfCollection = '" & dtTime.Value.ToString("HH:mm:ss") & "' where SampleNo = " & intKey

            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Entry editted successfully")

            Con.Close()
            Call Populate()
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If intKey = 0 Then
            MessageBox.Show("Please select an entry to delete")
        Else
            Dim intProcID As Integer

            Con.Open()

            If MsgBox("Are you sure you want to delete this entry? Warning: This will delete all the processed sample data and results", vbYesNo) = vbYes Then
                sql = "delete from SAMPLE where SampleNo = " & intKey
                cmd = New DB2Command(sql, Con)
                cmd.ExecuteNonQuery()

                sql = "select ProcSampleNo from PROCESSED_SAMPLE where SampleNo = " & intKey
                cmd = New DB2Command(sql, Con)
                dt = New DataTable
                adapter = New DB2DataAdapter(cmd)

                Try
                    intProcID = dt.Rows(0).Item(0)
                Catch ex As Exception
                    MsgBox("Data deleted successfully")

                    Con.Close()
                    Call Populate()
                    Call Clear()
                    Exit Sub
                End Try

                sql = "delete from LAB_RESULT where ProcSampleNo = " & intProcID
                cmd = New DB2Command(sql, Con)
                cmd.ExecuteNonQuery()

                MsgBox("Data deleted successfully")

                Con.Close()
                Call Populate()
                Call Clear()
            Else
                Con.Close()
            End If
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnPatientView_Click(sender As Object, e As EventArgs) Handles btnPatientView.Click

        If txtPatientMRN.Text = "" Then
            MsgBox("Enter a Patient MRN")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtPatientMRN.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select PatientMRN, FName, LName from PATIENT"
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
                lblPatientName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
            Else
                lblPatientName.Text = ""
                MsgBox("Patient with the specified MRN does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub btnReceptionistView_Click(sender As Object, e As EventArgs) Handles btnReceptionistView.Click

        If txtReceptionistNo.Text = "" Then
            MsgBox("Enter a Receptionist Number")
        ElseIf Not IsNumeric(txtReceptionistNo.Text) Then
            MsgBox("Enter a valid Receptionist Number")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtReceptionistNo.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select ReceptionistNo, FName, LName from LAB_RECEPTIONIST"
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
                lblReceptionistName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
            Else
                lblReceptionistName.Text = ""
                MsgBox("Receptionist with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub SampleLab_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If intRKey = 0 Then
            txtReceptionistNo.Text = ""
        Else
            Con.Open()
            sql = "select ReceptionistNo, FName, LName from LAB_RECEPTIONIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intRKey = drRow(0) Then
                    txtReceptionistNo.Text = intRKey
                    lblReceptionistName.Text = drRow(1).ToString() + " " + drRow(2).ToString()
                    Exit For
                End If
            Next
            Con.Close()

            intRKey = 0
        End If
    End Sub

End Class
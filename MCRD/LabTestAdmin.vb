Imports IBM.Data.DB2

Public Class LabTestAdmin
    Public intDKey As Integer
    Public stMRN As String
    Public boolPatientConsTrigger As Boolean

    Dim intKey As Integer

    Private Sub LabTestAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        dgridLabTests.ReadOnly = True
        With dgridLabTests
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Lab Test No."
            .Columns(0).Width = 100
            .Columns(1).HeaderCell.Value = "Physician ID"
            .Columns(1).Width = 100
            .Columns(2).HeaderCell.Value = "Patient MRN"
            .Columns(2).Width = 100
            .Columns(3).HeaderCell.Value = "Doctor"
            .Columns(3).Width = 200
            .Columns(4).HeaderCell.Value = "Patient"
            .Columns(4).Width = 200
            .Columns(5).HeaderCell.Value = "Lab Test Type"
            .Columns(5).Width = 250
            .Columns(6).HeaderCell.Value = "Date Ordered"
            .Columns(6).Width = 100
        End With

        Clear()

    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select LabTestNo, PhysicianID, PatientMRN, DName, PName, LabTestType, ""Date"" from LAB_TEST_DOCTOR"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridLabTests.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtPatientMRN.Text = ""
        txtPhysicianID.Text = ""
        lblPatientName.Text = ""
        lblPhysicianName.Text = ""
    End Sub

    Private Sub dgridLabTests_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridLabTests.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridLabTests.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtPhysicianID.Text = dsRow.Cells(1).Value.ToString()
                txtPatientMRN.Text = dsRow.Cells(2).Value.ToString()
                lblPhysicianName.Text = dsRow.Cells(3).Value.ToString()
                lblPatientName.Text = dsRow.Cells(4).Value.ToString()
                dtDate.Value = dsRow.Cells(6).Value
                txtLabTestType.Text = dsRow.Cells(5).Value.ToString()
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
        ElseIf txtPhysicianID.Text = "" Then
            MsgBox("Enter a Physician ID number")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid Physician ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intSecID As Integer = CInt(txtPhysicianID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text

            Con.Open()

            sql = "select PhysicianID from DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intSecID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Doctor with the specified ID does not exist")
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

            sql = "insert into LAB_TEST(PhysicianID, PatientMRN, LabTestType, ""Date"") values ('" & txtPhysicianID.Text & "','" & txtPatientMRN.Text & "','" & txtLabTestType.Text & "','" & dtDate.Value.ToString("yyyy-MM-dd") & "')"
            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("New lab test data added")

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If (
            txtPatientMRN.Text = "" Or
            txtPhysicianID.Text = ""
            ) Then
            MsgBox("Data insufficient to update. Please fill in the remaining information")
        ElseIf intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
            MsgBox("Enter a Physician ID number")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid Physician ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intSecID As Integer = CInt(txtPhysicianID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text

            Con.Open()

            sql = "select PhysicianID from DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intSecID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Doctor with the specified ID does not exist")
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

            sql = "update LAB_TEST set PhysicianID = '" & txtPhysicianID.Text & "', PatientMRN = '" & txtPatientMRN.Text & "', ""Date"" = '" & dtDate.Value.ToString("yyyy-MM-dd") & "', LabTestType = '" & txtLabTestType.Text & "' where LabTestNo = " & intKey

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
            Con.Open()

            If MsgBox("Are you sure you want to delete this entry?", vbYesNo) = vbYes Then
                sql = "delete from LAB_TEST where LabTestNo = " & intKey
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

            sql = "select PatientMRN, FName, LName from Patient"
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

    Private Sub btnDoctorView_Click(sender As Object, e As EventArgs) Handles btnDoctorView.Click

        If txtPhysicianID.Text = "" Then
            MsgBox("Enter a Physician ID number")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid Physician ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtPhysicianID.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select PhysicianID, FName, LName from DOCTOR"
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
                lblPhysicianName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
            Else
                lblPhysicianName.Text = ""
                MsgBox("Doctor with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub LabTestAdmin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If boolPatientConsTrigger Then
            boolPatientConsTrigger = False
            Me.Text = "Consultation - Lab Tests"
        Else
            Clear()
            Me.Text = "Lab Tests"
        End If
        If intDKey = 0 Then
            txtPhysicianID.Text = ""
        Else
            txtPhysicianID.Text = intDKey
        End If
        txtPatientMRN.Text = stMRN
        intDKey = 0
        stMRN = ""
    End Sub

End Class
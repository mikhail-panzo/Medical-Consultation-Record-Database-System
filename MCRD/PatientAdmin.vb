Imports IBM.Data.DB2

Public Class PatientAdmin
    Dim stKey As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub PatientAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridPatients.ReadOnly = True
        With dgridPatients
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "MRN"
            .Columns(0).HeaderCell.ToolTipText = "Medical Record Number"
            .Columns(0).Width = 100
            .Columns(1).HeaderCell.Value = "First Name"
            .Columns(1).Width = 200
            .Columns(2).HeaderCell.Value = "Last Name"
            .Columns(2).Width = 150
            .Columns(3).HeaderCell.Value = "Address"
            .Columns(3).Width = 150
            .Columns(4).HeaderCell.Value = "Sex"
            .Columns(4).Width = 50
            .Columns(5).HeaderCell.Value = "Date of Birth"
            .Columns(5).Width = 150
            .Columns(6).HeaderCell.Value = "Medical History"
            .Columns(6).Width = 250
        End With

        stKey = ""
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select * from PATIENT"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridPatients.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        stKey = ""
        txtFName.Text = ""
        txtLName.Text = ""
        txtAddress.Text = ""
        txtMedHistory.Text = ""
        cbSex.Text = ""
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim intID As Integer
        Dim stID As String
        Dim stSex As String

        If txtFName.Text = "" Or txtLName.Text = "" Or txtAddress.Text = "" Or cbSex.Text = "" Then
            MsgBox("Input the necessary patient information")
            Exit Sub
        End If

        If cbSex.Text = "Male" Then
            stSex = "M"
        ElseIf cbSex.Text = "Female" Then
            stSex = "F"
        Else
            MsgBox("Invalid Sex")
            Exit Sub
        End If

        intID = 1

        Con.Open()

        sql = "select PatientMRN from PATIENT order by PatientMRN"
        cmd = New DB2Command(sql, Con)
        dt = New DataTable
        adapter = New DB2DataAdapter(cmd)

        adapter.Fill(dt)

        'Looks for a free ID
        For Each drRow As DataRow In dt.Rows
            If intID = CInt(drRow(0).ToString()) Then
                intID = intID + 1
            Else
                Exit For
            End If
        Next

        stID = String.Format("{0:000000}", intID)

        sql = "insert into PATIENT(PatientMRN, FName, LName, Address, Sex, BirthDate, MedicalHistory) values ('" & stID & "','" & txtFName.Text & "','" & txtLName.Text & "','" & txtAddress.Text & "','" & stSex & "','" & dtBirthDate.Value.ToString("yyyy-MM-dd") & "','" & txtMedHistory.Text & "')"
        cmd = New DB2Command(sql, Con)
        cmd.ExecuteNonQuery()
        MsgBox("New patient data added")

        Con.Close()
        Populate()
    End Sub

    Private Sub dgridPatients_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridPatients.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridPatients.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                stKey = dsRow.Cells(0).Value.ToString()
                txtFName.Text = dsRow.Cells(1).Value.ToString()
                txtLName.Text = dsRow.Cells(2).Value.ToString()
                txtAddress.Text = dsRow.Cells(3).Value.ToString()
                If dsRow.Cells(4).Value.ToString() = "M" Then
                    cbSex.SelectedItem = "Male"
                Else
                    cbSex.SelectedItem = "Female"
                End If
                dtBirthDate.Value = dsRow.Cells(5).Value
                txtMedHistory.Text = dsRow.Cells(6).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (
            txtFName.Text = "" Or
            txtLName.Text = "" Or
            txtAddress.Text = "" Or
            cbSex.Text = ""
            ) Then
            MsgBox("Data insufficient to update. Please fill in the remaining information")
        ElseIf stKey = "" Then
            MsgBox("No Entry selected")
        Else
            Dim stSex As String

            If cbSex.Text = "Male" Then
                stSex = "M"
            ElseIf cbSex.Text = "Female" Then
                stSex = "F"
            Else
                MsgBox("Invalid Sex")
                Exit Sub
            End If

            Con.Open()

            Dim sql As String

            sql = "update PATIENT set FName = '" & txtFName.Text & "', LName = '" & txtLName.Text & "', Address = '" & txtAddress.Text & "', Sex = '" & stSex & "', BirthDate = '" & dtBirthDate.Value.ToString("yyyy-MM-dd") & "', MedicalHistory = '" & txtMedHistory.Text & "' where PatientMRN = '" & stKey & "'"

            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Entry editted successfully")

            Con.Close()
            Call Populate()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If stKey = "" Then
            MessageBox.Show("Please select an entry to delete")
        Else
            Con.Open()

            If MsgBox("Are you sure you want to delete this entry?", vbYesNo) = vbYes Then
                sql = "delete from PATIENT where PatientMRN = '" & stKey & "'"
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

End Class
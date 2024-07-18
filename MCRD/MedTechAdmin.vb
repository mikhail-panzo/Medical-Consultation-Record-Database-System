Imports IBM.Data.DB2

Public Class MedTechAdmin
    Dim intKey As Integer

    Private Sub MedTechAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridMedTechs.ReadOnly = True
        With dgridMedTechs
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "MedTech ID"
            .Columns(0).Width = 150
            .Columns(1).HeaderCell.Value = "First Name"
            .Columns(1).Width = 250
            .Columns(2).HeaderCell.Value = "Last Name"
            .Columns(2).Width = 200
            .Columns(3).HeaderCell.Value = "License No."
            .Columns(3).Width = 150
        End With

        intKey = 0
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select * from MED_TECHNOLOGIST"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridMedTechs.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtFName.Text = ""
        txtLName.Text = ""
        txtLicenseNo.Text = ""
    End Sub

    Private Sub dgridMedTechs_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridMedTechs.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridMedTechs.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtFName.Text = dsRow.Cells(1).Value.ToString()
                txtLName.Text = dsRow.Cells(2).Value.ToString()
                txtLicenseNo.Text = dsRow.Cells(3).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtFName.Text = "" Or txtLName.Text = "" Or txtLicenseNo.Text = "" Then
            MsgBox("Input the necessary medical technologist information")
            Exit Sub
        ElseIf Not IsNumeric(txtLicenseNo.Text) Then
            MsgBox("License Number must be numeric")
            Exit Sub
        ElseIf Not (Strings.Len(txtLicenseNo.Text) = 7) Then
            MsgBox("License Number must be seven (7) digits long")
            Exit Sub
        End If

        Con.Open()

        sql = "insert into MED_TECHNOLOGIST(FName, LName, LicenseNo) values ('" & txtFName.Text & "','" & txtLName.Text & "','" & txtLicenseNo.Text & "')"
        cmd = New DB2Command(sql, Con)
        cmd.ExecuteNonQuery()
        MsgBox("New medical technologist data added")

        Con.Close()
        Populate()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If (
           txtFName.Text = "" Or
           txtLName.Text = "" Or
           txtLicenseNo.Text = ""
           ) Then
            MsgBox("Data insufficient to update. Please fill in the remaining information")
        ElseIf intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf Not IsNumeric(txtLicenseNo.Text) Then
            MsgBox("License Number must be numeric")
        ElseIf Not (Strings.Len(txtLicenseNo.Text) = 7) Then
            MsgBox("License Number must be seven (7) digits long")
        Else
            Con.Open()

            sql = "update MED_TECHNOLOGIST set FName = '" & txtFName.Text & "', LName = '" & txtLName.Text & "', LicenseNo = '" & txtLicenseNo.Text & "' where MedTechID = " & intKey

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
                sql = "delete from MED_TECHNOLOGIST where MedTechID = " & intKey
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
        Me.Hide()
    End Sub

End Class
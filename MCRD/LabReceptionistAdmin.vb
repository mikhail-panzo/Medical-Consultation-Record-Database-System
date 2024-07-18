Imports IBM.Data.DB2

Public Class LabReceptionistAdmin
    Dim intKey As Integer

    Private Sub LabReceptionistAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridLabReceptionists.ReadOnly = True
        With dgridLabReceptionists
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Receptionist No."
            .Columns(0).Width = 200
            .Columns(1).HeaderCell.Value = "First Name"
            .Columns(1).Width = 300
            .Columns(2).HeaderCell.Value = "Last Name"
            .Columns(2).Width = 200
        End With
        intKey = 0
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select * from LAB_RECEPTIONIST"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridLabReceptionists.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtFName.Text = ""
        txtLName.Text = ""
    End Sub

    Private Sub dgridLabReceptionists_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridLabReceptionists.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridLabReceptionists.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtFName.Text = dsRow.Cells(1).Value.ToString()
                txtLName.Text = dsRow.Cells(2).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtFName.Text = "" Or txtLName.Text = "" Then
            MsgBox("Input the necessary lab receptionist information")
            Exit Sub
        End If

        Con.Open()

        sql = "insert into LAB_RECEPTIONIST(FName, LName) values ('" & txtFName.Text & "','" & txtLName.Text & "')"
        cmd = New DB2Command(sql, Con)
        cmd.ExecuteNonQuery()
        MsgBox("New lab receptionist data added")

        Con.Close()
        Populate()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If (
           txtFName.Text = "" Or
           txtLName.Text = ""
           ) Then
            MsgBox("Data insufficient to update. Please fill in the remaining information")
        ElseIf intKey = 0 Then
            MsgBox("No Entry selected")
        Else
            Con.Open()

            sql = "update LAB_RECEPTIONIST set FName = '" & txtFName.Text & "', LName = '" & txtLName.Text & "' where ReceptionistNo = " & intKey

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
                sql = "delete from LAB_RECEPTIONIST where ReceptionistNo = " & intKey
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
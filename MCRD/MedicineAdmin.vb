Imports IBM.Data.DB2

Public Class MedicineAdmin
    Dim intKey As Integer

    Private Sub MedicineAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridMedicines.ReadOnly = True
        With dgridMedicines
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Medicine No."
            .Columns(0).Width = 120
            .Columns(1).HeaderCell.Value = "Brand Name"
            .Columns(1).Width = 200
            .Columns(2).HeaderCell.Value = "Generic Name"
            .Columns(2).Width = 200
            .Columns(3).HeaderCell.Value = "Manufacturer"
            .Columns(3).Width = 200
            .Columns(4).HeaderCell.Value = "Description"
            .Columns(4).Width = 250
        End With

        intKey = 0
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select * from MEDICINE"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridMedicines.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtBrandName.Text = ""
        txtGenericName.Text = ""
        txtManufacturer.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub dgridMedicines_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridMedicines.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridMedicines.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtBrandName.Text = dsRow.Cells(1).Value.ToString()
                txtGenericName.Text = dsRow.Cells(2).Value.ToString()
                txtManufacturer.Text = dsRow.Cells(3).Value.ToString()
                txtDescription.Text = dsRow.Cells(4).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtBrandName.Text = "" Or txtGenericName.Text = "" Or txtManufacturer.Text = "" Or txtDescription.Text = "" Then
            MsgBox("Input the necessary medicine information")
            Exit Sub
        End If

        Con.Open()

        sql = "insert into MEDICINE(BrandName, GenericName, Manufacturer, ""Description"") values ('" & txtBrandName.Text & "','" & txtGenericName.Text & "','" & txtManufacturer.Text & "','" & txtDescription.Text & "')"
        cmd = New DB2Command(sql, Con)
        cmd.ExecuteNonQuery()

        MsgBox("New medicine data added")

        Con.Close()
        Populate()

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If (
           txtBrandName.Text = "" Or
           txtGenericName.Text = "" Or
           txtManufacturer.Text = "" Or
           txtDescription.Text = ""
           ) Then
            MsgBox("Data insufficient to update. Please fill in the remaining information")
        ElseIf intKey = 0 Then
            MsgBox("No Entry selected")
        Else
            Con.Open()

            Dim sql As String

            sql = "update MEDICINE set BrandName = '" & txtBrandName.Text & "', GenericName = '" & txtGenericName.Text & "', Manufacturer = '" & txtManufacturer.Text & "', ""Description"" = '" & txtDescription.Text & "' where MedicineNo = " & intKey

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
                sql = "delete from MEDICINE where MedicineNo = " & intKey
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
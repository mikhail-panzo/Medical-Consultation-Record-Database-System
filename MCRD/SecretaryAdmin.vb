Imports IBM.Data.DB2

Public Class SecretaryAdmin

    Dim intKey As Integer

    Private Sub SecretaryAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridSecretaries.ReadOnly = True
        With dgridSecretaries
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Secretary ID"
            .Columns(0).Width = 150
            .Columns(1).HeaderCell.Value = "First Name"
            .Columns(1).Width = 250
            .Columns(2).HeaderCell.Value = "Last Name"
            .Columns(2).Width = 200
            .Columns(3).HeaderCell.Value = "Physician ID"
            .Columns(3).HeaderCell.ToolTipText = "The ID of the Physician the secretary assists with"
            .Columns(3).Width = 150
        End With

        intKey = 0

        lblDocFName.Text = ""
        lblDocLName.Text = ""
        lblDocLicenseNo.Text = ""
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select * from SECRETARY"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridSecretaries.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtFName.Text = ""
        txtLName.Text = ""
        txtPhysicianID.Text = ""
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        If txtPhysicianID.Text = "" Then
            MsgBox("Enter a Physician ID Number")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid ID Number")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtPhysicianID.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select * from DOCTOR"
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
                lblDocFName.Text = dt.Rows(intCount).Item(1).ToString()
                lblDocLName.Text = dt.Rows(intCount).Item(2).ToString()
                lblDocLicenseNo.Text = dt.Rows(intCount).Item(3).ToString()
            Else
                lblDocFName.Text = ""
                lblDocLName.Text = ""
                lblDocLicenseNo.Text = ""
                MsgBox("Doctor with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFName.Text = "" Or txtLName.Text = "" Then
            MsgBox("Input the necessary secretary information")
            Exit Sub
        End If

        If txtPhysicianID.Text = "" Then
            MsgBox("Enter a Physician ID Number")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid Physician ID Number")
        Else
            Dim boolFound As Boolean = False
            Dim boolNotUnique As Boolean = False
            Dim intID As Integer = CInt(txtPhysicianID.Text)

            Con.Open()

            sql = "select PhysicianID from DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            sql = "select PhysicianID from SECRETARY"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intID = drRow(0) Then
                    boolFound = False
                    boolNotUnique = True
                    Exit For
                End If
            Next


            If boolFound Then
                sql = "insert into SECRETARY(FName, LName, PhysicianID) values ('" & txtFName.Text & "','" & txtLName.Text & "','" & txtPhysicianID.Text & "')"
                cmd = New DB2Command(sql, Con)
                cmd.ExecuteNonQuery()
                MsgBox("New secretary data added")
            Else
                If boolNotUnique Then
                    MsgBox("Doctor with the specified ID is already handled by another secretary")
                Else
                    MsgBox("Doctor with the specified ID does not exist")
                End If
            End If

            Con.Close()
            Populate()
        End If

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
            Dim intID As Integer = CInt(txtPhysicianID.Text)

            Con.Open()

            sql = "update SECRETARY set FName = '" & txtFName.Text & "', LName = '" & txtLName.Text & "' where SecretaryID = " & intKey

            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Entry editted successfully" & vbCrLf & vbCrLf & "NOTE: Physician ID cannot be reassigned. Please delete appropriate entries for reassignment procedure.")

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
                sql = "delete from SECRETARY where SecretaryID = " & intKey
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

    Private Sub dgridSecretaries_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridSecretaries.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridSecretaries.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtFName.Text = dsRow.Cells(1).Value.ToString()
                txtLName.Text = dsRow.Cells(2).Value.ToString()
                txtPhysicianID.Text = dsRow.Cells(3).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

End Class
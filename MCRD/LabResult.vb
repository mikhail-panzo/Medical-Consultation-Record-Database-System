Imports IBM.Data.DB2

Public Class LabResult
    Public intProcSampleNo As Integer

    Dim intKey As Integer

    Private Sub LabResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgridLabResults.ReadOnly = True
        With dgridLabResults
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Lab Result No."
            .Columns(0).Width = 150
            .Columns(1).HeaderCell.Value = "Processed Sample No."
            .Columns(1).Width = 180
            .Columns(2).HeaderCell.Value = "Patient"
            .Columns(2).Width = 200
            .Columns(3).HeaderCell.Value = "Lab Test Type"
            .Columns(3).Width = 200
            .Columns(4).HeaderCell.Value = "Field"
            .Columns(4).Width = 200
            .Columns(5).HeaderCell.Value = "Result"
            .Columns(5).Width = 200
            .Columns(6).HeaderCell.Value = "Date"
            .Columns(6).Width = 100
        End With

        Clear()
        Populate()

    End Sub

    Public Sub Populate()
        lblProcSampleNo.Text = intProcSampleNo

        Con.Open()

        sql = "select LabResultNo, ProcSampleNo, PName, ProcLabTestType, ""Field"", ""Result"", ""Date"" from LAB_RESULT_FULL_DETAIL where ProcSampleNo = " & intProcSampleNo
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridLabResults.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtField.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub dgridLabResults_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridLabResults.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridLabResults.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtField.Text = dsRow.Cells(4).Value.ToString()
                txtResult.Text = dsRow.Cells(5).Value.ToString()
                dtDate.Value = dsRow.Cells(6).Value
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtResult.Text = "" Or txtField.Text = "" Then
            MsgBox("Enter the necessary result information")
        Else
            Con.Open()

            sql = "insert into LAB_RESULT(ProcSampleNo, ""Field"", ""Result"", ""Date"") values (" & intProcSampleNo & ",'" & txtField.Text & "','" & txtResult.Text & "','" & dtDate.Value.ToString("yyyy-MM-dd") & "')"
            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("New lab result data added")

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If txtResult.Text = "" Or txtField.Text = "" Then
            MsgBox("Enter the necessary result information")
        ElseIf intKey = 0 Then
            MsgBox("No Entry selected")
        Else
            Con.Open()

            sql = "update LAB_RESULT set ""Field"" = '" & txtField.Text & "', ""Result"" = '" & txtResult.Text & "', ""Date"" = '" & dtDate.Value.ToString("yyyy-MM-dd") & "' where LabResultNo = " & intKey

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
                sql = "delete from LAB_RESULT where LabResultNo = " & intKey
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

End Class
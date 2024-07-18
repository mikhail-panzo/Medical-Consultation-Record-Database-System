Imports IBM.Data.DB2

Public Class PaymentBusiness
    Public intCKey As Integer

    Dim intKey As Integer

    Private Sub PaymentBusiness_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridPayments.ReadOnly = True
        With dgridPayments
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Payment No."
            .Columns(0).Width = 100
            .Columns(1).HeaderCell.Value = "Lab Test No."
            .Columns(1).Width = 100
            .Columns(2).HeaderCell.Value = "Cashier No."
            .Columns(2).Width = 100
            .Columns(3).HeaderCell.Value = "Patient MRN"
            .Columns(3).Width = 100
            .Columns(4).HeaderCell.Value = "Cashier"
            .Columns(4).Width = 200
            .Columns(5).HeaderCell.Value = "Patient"
            .Columns(5).Width = 200
            .Columns(6).HeaderCell.Value = "Amount Paid (Php)"
            .Columns(6).Width = 200
        End With

        Clear()

    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select PaymentNo, LabTestNo, CashierNo, PatientMRN, CName, PName, AmountPaid from L_PAYMENT_FULL_DETAIL"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridPayments.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0

        lblPatientName.Text = ""
        lblCashierName.Text = ""

        txtLabTestNo.Text = ""
        txtAmountPaid.Text = ""
        txtPatientMRN.Text = ""
        txtCashierID.Text = ""
    End Sub

    Private Sub dgridPayments_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridPayments.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridPayments.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtLabTestNo.Text = dsRow.Cells(1).Value.ToString()
                txtCashierID.Text = dsRow.Cells(2).Value.ToString()
                txtPatientMRN.Text = dsRow.Cells(3).Value.ToString()
                lblCashierName.Text = dsRow.Cells(4).Value.ToString()
                lblPatientName.Text = dsRow.Cells(5).Value.ToString()
                txtAmountPaid.Text = dsRow.Cells(6).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If (
            txtLabTestNo.Text = "" Or
            txtAmountPaid.Text = "" Or
            txtPatientMRN.Text = "" Or
            txtCashierID.Text = ""
            ) Then
            MsgBox("Input the necessary payment information")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf Not IsNumeric(txtCashierID.Text) Then
            MsgBox("Enter a valid Cashier Number")
        ElseIf Not IsNumeric(txtLabTestNo.Text) Then
            MsgBox("Enter a valid Lab Test Number")
        ElseIf Not IsNumeric(txtAmountPaid.Text) Then
            MsgBox("Amount paid must be numeric")
        ElseIf CDec(txtAmountPaid.Text) > 99999999.99 Or CDec(txtAmountPaid.Text) < 0 Then
            MsgBox("Amount exceeds system limit")
        Else
            Dim boolFound As Boolean = False
            Dim intCID As Integer = CInt(txtCashierID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text
            Dim intLabNo As Integer = CInt(txtLabTestNo.Text)

            Con.Open()

            sql = "select LabTestNo from LAB_TEST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intLabNo = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Lab Test order with the specified ID does not exist")
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
            boolFound = False

            sql = "select CashierNo from CASHIER"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intCID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Cashier with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If


            sql = "insert into PAYMENT(LabTestNo, CashierNo, PatientMRN, AmountPaid) values (" & intLabNo & "," & intCID & ",'" & stPatientMRN & "'," & CDec(txtAmountPaid.Text) & ")"
            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("New payment data added")

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf (
            txtLabTestNo.Text = "" Or
            txtAmountPaid.Text = "" Or
            txtPatientMRN.Text = "" Or
            txtCashierID.Text = ""
            ) Then
            MsgBox("Input the necessary payment information")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf Not IsNumeric(txtCashierID.Text) Then
            MsgBox("Enter a valid Cashier Number")
        ElseIf Not IsNumeric(txtLabTestNo.Text) Then
            MsgBox("Enter a valid Lab Test Number")
        ElseIf Not IsNumeric(txtAmountPaid.Text) Then
            MsgBox("Amount paid must be numeric")
        ElseIf CDec(txtAmountPaid.Text) > 99999999.99 Or CDec(txtAmountPaid.Text) < 0 Then
            MsgBox("Amount exceeds system limit")
        Else
            Dim boolFound As Boolean = False
            Dim intCID As Integer = CInt(txtCashierID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text
            Dim intLabNo As Integer = CInt(txtLabTestNo.Text)

            Con.Open()

            sql = "select LabTestNo from LAB_TEST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intLabNo = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Lab Test order with the specified ID does not exist")
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
            boolFound = False

            sql = "select CashierNo from CASHIER"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intCID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Cashier with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If

            sql = "update PAYMENT set LabTestNo = " & intLabNo & ", PatientMRN = '" & stPatientMRN & "', CashierNo = " & intCID & ", AmountPaid = " & CDec(txtAmountPaid.Text) & " where PaymentNo = " & intKey

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
                sql = "delete from PAYMENT where PaymentNo = " & intKey
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

    Private Sub btnCashierView_Click(sender As Object, e As EventArgs) Handles btnCashierView.Click

        If txtCashierID.Text = "" Then
            MsgBox("Enter a Cashier Number")
        ElseIf Not IsNumeric(txtCashierID.Text) Then
            MsgBox("Enter a valid Cashier Number")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtCashierID.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select CashierNo, FName, LName from CASHIER"
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
                lblCashierName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
            Else
                lblCashierName.Text = ""
                MsgBox("Cashier with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub PaymentBusiness_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If intCKey = 0 Then
            txtCashierID.Text = ""
        Else
            txtCashierID.Text = intCKey
        End If
        intCKey = 0
    End Sub

End Class
Imports IBM.Data.DB2

Public Class BusinessOffice
    Dim intKey As Integer

    Private Sub BusinessOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()

        dgridConsultations.ReadOnly = True
        With dgridConsultations
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 10)
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Consultation No."
            .Columns(0).Width = 170
            .Columns(1).HeaderCell.Value = "Patient MRN"
            .Columns(1).Width = 145
            .Columns(2).HeaderCell.Value = "Physician ID"
            .Columns(2).Width = 145
            .Columns(3).HeaderCell.Value = "Patient"
            .Columns(3).Width = 250
            .Columns(4).HeaderCell.Value = "Physician"
            .Columns(4).Width = 250
            .Columns(5).HeaderCell.Value = "Date"
            .Columns(5).Width = 100
            .Columns(6).HeaderCell.Value = "Time"
            .Columns(6).Width = 100
        End With

        dgridLabTests.ReadOnly = True
        With dgridLabTests
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 10)
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Lab Test No."
            .Columns(0).Width = 150
            .Columns(1).HeaderCell.Value = "Lab Test Type"
            .Columns(1).Width = 290
            .Columns(2).HeaderCell.Value = "Lab Test For"
            .Columns(2).Width = 230
            .Columns(3).HeaderCell.Value = "Ordered By"
            .Columns(3).Width = 230
            .Columns(4).HeaderCell.Value = "Date Ordered"
            .Columns(4).Width = 145
            .Columns(5).HeaderCell.Value = "Status"
            .Columns(5).Width = 117
        End With

        intKey = 0
        txtID.Text = ""
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select ConsultationNo, PatientMRN, PhysicianID, PName, DName, ""Date"", stTime from CONSULTATION_FULL_DETAIL"

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridConsultations.DataSource = dt

        sql = "select l.LabTestNo, l.LabTestType, l.PName, l.DName, l.""Date"", (CASE WHEN ps.SampleNo IS NULL THEN 'unprocessed' ELSE 'processed' END) as status from LAB_TEST_DOCTOR l LEFT JOIN PROCESSED_SAMPLE ps ON l.LabTestNo = ps.LabTestNo"

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridLabTests.DataSource = dt


        Con.Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        If txtID.Text = "" Then
            MsgBox("Enter a Cashier Number")
        ElseIf Not IsNumeric(txtID.Text) Then
            MsgBox("Enter a valid Cashier Number")
        Else
            intKey = CInt(txtID.Text)
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Populate()
    End Sub

    Private Sub picLogOut_Click(sender As Object, e As EventArgs) Handles picLogOut.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Login.Show()
        Me.Hide()
    End Sub


    Private Sub btnLabTestPayment_Click(sender As Object, e As EventArgs) Handles btnLabTestPayment.Click
        PaymentBusiness.TopMost = True
        PaymentBusiness.intCKey = intKey
        PaymentBusiness.Show()
    End Sub

    Private Sub btnConsultationPayment_Click(sender As Object, e As EventArgs) Handles btnConsultationPayment.Click
        PaymentCons.TopMost = True
        PaymentCons.boolTitleTrigger = True
        PaymentCons.Show()
    End Sub

End Class
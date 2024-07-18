Imports IBM.Data.DB2

Public Class Administrator

    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridAppointments.ReadOnly = True
        With dgridAppointments
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 10)
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Apppointment No."
            .Columns(0).Width = 177
            .Columns(1).HeaderCell.Value = "Patient"
            .Columns(1).Width = 355
            .Columns(2).HeaderCell.Value = "Doctor"
            .Columns(2).Width = 355
            .Columns(3).HeaderCell.Value = "Date"
            .Columns(3).Width = 140
            .Columns(4).HeaderCell.Value = "Time"
            .Columns(4).Width = 140
        End With

        dgridLabTests.ReadOnly = True
        With dgridLabTests
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 10)
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Lab Test No."
            .Columns(0).Width = 150
            .Columns(1).HeaderCell.Value = "Lab Test Type"
            .Columns(1).Width = 382
            .Columns(2).HeaderCell.Value = "Lab Test For"
            .Columns(2).Width = 250
            .Columns(3).HeaderCell.Value = "Ordered By"
            .Columns(3).Width = 250
            .Columns(4).HeaderCell.Value = "Date Ordered"
            .Columns(4).Width = 135
        End With

    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select AppointmentNo, PName, DName, ""Date"", stTime from APPOINTMENT_DOCTOR"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridAppointments.DataSource = dt

        sql = "select LabTestNo, LabTestType, PName, DName, ""Date"" from LAB_TEST_DOCTOR"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridLabTests.DataSource = dt

        Con.Close()
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

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        PatientAdmin.TopMost = True
        PatientAdmin.Show()
    End Sub

    Private Sub btnDoctor_Click(sender As Object, e As EventArgs) Handles btnDoctor.Click
        DoctorAdmin.TopMost = True
        DoctorAdmin.Show()
    End Sub

    Private Sub btnSecretary_Click(sender As Object, e As EventArgs) Handles btnSecretary.Click
        SecretaryAdmin.TopMost = True
        SecretaryAdmin.Show()
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        CashierAdmin.TopMost = True
        CashierAdmin.Show()
    End Sub

    Private Sub btnLabReceptionist_Click(sender As Object, e As EventArgs) Handles btnLabReceptionist.Click
        LabReceptionistAdmin.TopMost = True
        LabReceptionistAdmin.Show()
    End Sub

    Private Sub btnMedTech_Click(sender As Object, e As EventArgs) Handles btnMedTech.Click
        MedTechAdmin.TopMost = True
        MedTechAdmin.Show()
    End Sub

    Private Sub btnMedicine_Click(sender As Object, e As EventArgs) Handles btnMedicine.Click
        MedicineAdmin.TopMost = True
        MedicineAdmin.Show()
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        AppointmentAdmin.TopMost = True
        AppointmentAdmin.Show()
    End Sub

    Private Sub btnLabTest_Click(sender As Object, e As EventArgs) Handles btnLabTest.Click
        LabTestAdmin.TopMost = True
        LabTestAdmin.Show()
    End Sub

End Class
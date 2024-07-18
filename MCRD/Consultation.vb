Imports IBM.Data.DB2

Public Class Consultation
    Dim intKey As Integer
    Dim boolSRef As Boolean

    Private Sub Consultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            .Columns(1).Width = 292
            .Columns(2).HeaderCell.Value = "Lab Test For"
            .Columns(2).Width = 230
            .Columns(3).HeaderCell.Value = "Ordered By"
            .Columns(3).Width = 230
            .Columns(4).HeaderCell.Value = "Date Ordered"
            .Columns(4).Width = 145
            .Columns(5).HeaderCell.Value = "Status"
            .Columns(5).Width = 120
        End With

        intKey = 0
        boolSRef = True
        PatientCons.intSecKey = 0
        PatientCons.intDocKey = 0
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select AppointmentNo, PName, DName, ""Date"", stTime from APPOINTMENT_DOCTOR where "

        If boolSRef Then
            sql = sql + "SecretaryID = " & intKey
        Else
            sql = sql + "PhysicianID = " & intKey
        End If

        If cboxUnfulfilled.Checked Then
            sql = sql + " and timestamp(""Date"", stTime) >= CURRENT_TIMESTAMP"
        End If

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridAppointments.DataSource = dt

        sql = "select l.LabTestNo, l.LabTestType, l.PName, l.DName, l.""Date"", (CASE WHEN ps.SampleNo IS NULL THEN 'unprocessed' ELSE 'processed' END) as status from LAB_TEST_DOCTOR l LEFT JOIN PROCESSED_SAMPLE ps ON l.LabTestNo = ps.LabTestNo"


        If cboxUnfulfilled.Checked Then
            sql = sql + " where ps.LabTestNo is null"
        End If
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable


        adapter.Fill(dt)
        dgridLabTests.DataSource = dt

        Con.Close()
    End Sub

    Private Sub cboxUnfulfilled_CheckedChanged(sender As Object, e As EventArgs) Handles cboxUnfulfilled.CheckedChanged
        Populate()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        If cbIDSelection.Text.ToString() = "Secretary ID" Then
            If txtSecID.Text = "" Then
                MsgBox("Enter a Secretary ID number")
            ElseIf Not IsNumeric(txtSecID.Text) Then
                MsgBox("Enter a valid Secretary ID number")
            Else
                intKey = CInt(txtSecID.Text)
                PatientCons.intSecKey = intKey
                PatientCons.intDocKey = 0
                boolSRef = True
                Populate()
            End If
        ElseIf cbIDSelection.Text.ToString() = "Physician ID" Then
            If txtSecID.Text = "" Then
                MsgBox("Enter a Physician ID number")
            ElseIf Not IsNumeric(txtSecID.Text) Then
                MsgBox("Enter a valid Physician ID number")
            Else
                intKey = CInt(txtSecID.Text)
                PatientCons.intSecKey = 0
                PatientCons.intDocKey = intKey
                boolSRef = False
                Populate()
            End If
        Else
            MsgBox("Selected ID must be either Secretary or Physician")
            cbIDSelection.Text = "Secretary ID"
        End If


    End Sub

    Private Sub picLogOut_Click(sender As Object, e As EventArgs) Handles picLogOut.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Populate()
    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        PatientCons.TopMost = True
        PatientCons.Show()
    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        AppointmentAdmin.TopMost = True
        If boolSRef Then
            AppointmentAdmin.intSKey = intKey
        Else
            AppointmentAdmin.intSKey = 0
        End If
        AppointmentAdmin.boolPatientConsTrigger = True
        AppointmentAdmin.Show()
    End Sub

    Private Sub btnConsultation_Click(sender As Object, e As EventArgs) Handles btnConsultation.Click
        ConsultationCons.TopMost = True
        ConsultationCons.Show()
    End Sub

    Private Sub btnPrescription_Click(sender As Object, e As EventArgs) Handles btnPrescription.Click
        PrescriptionCons.TopMost = True
        If boolSRef Then
            PrescriptionCons.intDKey = 0
        Else
            PrescriptionCons.intDKey = intKey
        End If
        PrescriptionCons.stMRN = ""
        PrescriptionCons.Show()
    End Sub

    Private Sub btnLabTest_Click(sender As Object, e As EventArgs) Handles btnLabTest.Click
        LabTestAdmin.boolPatientConsTrigger = True
        LabTestAdmin.TopMost = True
        If boolSRef Then
            LabTestAdmin.intDKey = 0
        Else
            LabTestAdmin.intDKey = intKey
        End If
        LabTestAdmin.stMRN = ""
        LabTestAdmin.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        PaymentCons.TopMost = True
        If boolSRef Then
            PaymentCons.intSKey = intKey
        Else
            PaymentCons.intSKey = 0
        End If
        PaymentCons.stMRN = ""
        PaymentCons.Show()
    End Sub
End Class
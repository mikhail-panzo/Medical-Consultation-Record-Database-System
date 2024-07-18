Imports IBM.Data.DB2

Public Class PatientCons
    Public intSecKey As Integer
    Public intDocKey As Integer

    Dim stKey As String

    Private Sub PatientCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridPatients.ReadOnly = True
        With dgridPatients
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 9, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 9)
            .DefaultCellStyle.ForeColor = Color.Black
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

        dgridAppointments.ReadOnly = True
        With dgridAppointments
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 7, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 7)
            .DefaultCellStyle.ForeColor = Color.Black
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Apppointment No."
            .Columns(0).Width = 130
            .Columns(1).HeaderCell.Value = "Patient"
            .Columns(1).Width = 200
            .Columns(2).HeaderCell.Value = "Doctor"
            .Columns(2).Width = 200
            .Columns(3).HeaderCell.Value = "Date"
            .Columns(3).Width = 100
            .Columns(4).HeaderCell.Value = "Time"
            .Columns(4).Width = 100
        End With

        dgridConsultations.ReadOnly = True
        With dgridConsultations
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 7, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 7)
            .DefaultCellStyle.ForeColor = Color.Black
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Consultation No."
            .Columns(0).Width = 120
            .Columns(1).HeaderCell.Value = "Appointment No."
            .Columns(1).Width = 120
            .Columns(2).HeaderCell.Value = "Patient MRN"
            .Columns(2).HeaderCell.ToolTipText = "Patient Medical Record Number"
            .Columns(2).Width = 100
            .Columns(3).HeaderCell.Value = "Physician ID"
            .Columns(3).Width = 100
            .Columns(4).HeaderCell.Value = "Patient"
            .Columns(4).Width = 250
            .Columns(5).HeaderCell.Value = "Doctor"
            .Columns(5).Width = 250
            .Columns(6).HeaderCell.Value = "Date"
            .Columns(6).Width = 100
            .Columns(7).HeaderCell.Value = "Time"
            .Columns(7).Width = 100
            .Columns(8).HeaderCell.Value = "Diagnosis"
            .Columns(8).Width = 250
        End With

        dGridPrescriptions.ReadOnly = True
        With dGridPrescriptions
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 7, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 7)
            .DefaultCellStyle.ForeColor = Color.Black
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Prescription No."
            .Columns(0).Width = 120
            .Columns(1).HeaderCell.Value = "Medicine No."
            .Columns(1).Width = 100
            .Columns(2).HeaderCell.Value = "Patient MRN"
            .Columns(2).Width = 100
            .Columns(3).HeaderCell.Value = "Physician ID"
            .Columns(3).Width = 100
            .Columns(4).HeaderCell.Value = "Medicine Brand Name"
            .Columns(4).Width = 200
            .Columns(5).HeaderCell.Value = "Medicine Generic Name"
            .Columns(5).Width = 200
            .Columns(6).HeaderCell.Value = "Patient"
            .Columns(6).Width = 200
            .Columns(7).HeaderCell.Value = "Doctor"
            .Columns(7).Width = 200
            .Columns(8).HeaderCell.Value = "Date of Issue"
            .Columns(8).Width = 100
            .Columns(9).HeaderCell.Value = "Quantity"
            .Columns(9).Width = 100
            .Columns(10).HeaderCell.Value = "Details"
            .Columns(10).Width = 250
        End With

        dgridLabResults.ReadOnly = True
        With dgridLabResults
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 7, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 7)
            .DefaultCellStyle.ForeColor = Color.Black
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
            .Columns(7).HeaderCell.Value = "Patient MRN"
            .Columns(7).Width = 100
        End With

        Clear()
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select * from PATIENT"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridPatients.DataSource = dt

        sql = "select AppointmentNo, PName, DName, ""Date"", stTime from APPOINTMENT_DOCTOR"

        If cboxUnfulfilled.Checked Then
            sql = sql + " where timestamp(""Date"", stTime) >= CURRENT_TIMESTAMP"
        End If

        If Not (stKey = "") Then
            If cboxUnfulfilled.Checked Then
                sql = sql + " and "
            Else
                sql = sql + " where "
            End If
            sql = sql + " PatientMRN = '" & stKey & "'"
        End If

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridAppointments.DataSource = dt

        sql = "select ConsultationNo, AppointmentNo, PatientMRN, PhysicianID, PName, DName, ""Date"", stTime, Diagnosis from CONSULTATION_FULL_DETAIL"

        If Not stKey = "" Then
            sql = sql & " where patientMRN = '" & stKey & "'"
        End If

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridConsultations.DataSource = dt

        sql = "select * from PRESCRIPTION_FULL_DETAIL"

        If Not stKey = "" Then
            sql = sql & " where patientMRN = '" & stKey & "'"
        End If

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dGridPrescriptions.DataSource = dt

        sql = "select l.LabResultNo, l.ProcSampleNo, l.PName, l.ProcLabTestType, l.""Field"", l.""Result"", l.""Date"", p.sampleMRN from LAB_RESULT_FULL_DETAIL l LEFT JOIN PROC_SAMPLE_FULL_DETAIL p ON l.ProcSampleNo = p.ProcSampleNo"

        If Not (stKey = "") Then
            sql = sql & " where p.sampleMRN = '" & stKey & "'"
        End If

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable


        adapter.Fill(dt)
        dgridLabResults.DataSource = dt


        Con.Close()

    End Sub

    Private Sub Clear()
        stKey = ""
        lblFullName.Text = ""
        lblAddress.Text = ""
        lblBirthDate.Text = ""
        lblSex.Text = ""
        txtMedHistory.Text = ""
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

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

            sql = "select * from PATIENT"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intID = drRow(0) Then
                    stKey = drRow(0).ToString()
                    boolFound = True
                    Exit For
                Else
                    intCount = intCount + 1
                End If
            Next

            If boolFound Then
                lblFullName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
                lblAddress.Text = dt.Rows(intCount).Item(3).ToString()
                If dt.Rows(intCount).Item(4).ToString() = "M" Then
                    lblSex.Text = "Male"
                Else
                    lblSex.Text = "Female"
                End If
                lblBirthDate.Text = Convert.ToDateTime(dt.Rows(intCount).Item(5).ToString()).ToString("d")
                txtMedHistory.Text = dt.Rows(intCount).Item(6).ToString()
            Else
                Clear()
                MsgBox("Patient with the specified MRN does not exist")
            End If

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim stSearchType As String
        Dim intSelectedColumn As Integer

        If cbSearchType.Text.ToString() = "First Name" Then
            stSearchType = "FName"
            intSelectedColumn = 1
        ElseIf cbSearchType.Text.ToString() = "Last Name" Then
            stSearchType = "LName"
            intSelectedColumn = 2
        Else
            MsgBox("Please select either first or last name to search")
            cbSearchType.Text = "First Name"
            Exit Sub
        End If

        If txtSearch.Text = "" Then
            MsgBox("Please enter a search key")
            Exit Sub
        End If

        Dim boolFound As Boolean = False
        Dim stSearchKey As String = txtSearch.Text.ToLower()
        Dim intCount As Integer = 0

        Con.Open()

        sql = "select " & stSearchType & ", PatientMRN from PATIENT"
        cmd = New DB2Command(sql, Con)
        dt = New DataTable
        adapter = New DB2DataAdapter(cmd)

        adapter.Fill(dt)

        For Each drRow As DataRow In dt.Rows
            If stSearchKey = drRow(0).ToString().ToLower Then
                Clear()
                txtPatientMRN.Text = drRow(1).ToString()
                boolFound = True
                Exit For
            Else
                intCount = intCount + 1
            End If
        Next

        If boolFound Then
            dgridPatients.CurrentCell = dgridPatients.Item(intSelectedColumn, intCount)
        Else
            Clear()
            MsgBox("Patient with the name does not exist")
        End If

        Con.Close()

    End Sub

    Private Sub cboxUnfulfilled_CheckedChanged(sender As Object, e As EventArgs) Handles cboxUnfulfilled.CheckedChanged
        Populate()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
    End Sub

    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click

        Dim stMRN As String = txtPatientMRN.Text
        Dim intSKey As Integer
        Dim boolFound As Boolean = False

        If Not txtPatientMRN.Text = "" Then

            Con.Open()

            sql = "select PatientMRN from PATIENT"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If stMRN = drRow(0).ToString() Then
                    stMRN = drRow(0)
                    boolFound = True
                    Exit For
                End If
            Next

            If boolFound Then
                AppointmentAdmin.stMRN = stMRN
            Else
                AppointmentAdmin.stMRN = ""
            End If



            Con.Close()
        End If

        boolFound = False
        Con.Open()
        If intSecKey = 0 Then
            sql = "select PhysicianID, SecretaryID from SECRETARY"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intDocKey = drRow(0) Then
                    intSKey = drRow(1)
                    boolFound = True
                    Exit For
                End If
            Next

            If boolFound Then
                AppointmentAdmin.intSKey = intSKey
            Else
                AppointmentAdmin.intSKey = 0
            End If
        Else
            sql = "select SecretaryID from SECRETARY"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intSecKey = drRow(0) Then
                    intSKey = drRow(0)
                    boolFound = True
                    Exit For
                End If
            Next

            If boolFound Then
                AppointmentAdmin.intSKey = intSKey
            Else
                AppointmentAdmin.intSKey = 0
            End If
        End If
        Con.Close()

        AppointmentAdmin.boolPatientConsTrigger = True
        AppointmentAdmin.Show()
        AppointmentAdmin.TopMost = True
    End Sub

    Private Sub btnConsultation_Click(sender As Object, e As EventArgs) Handles btnConsultation.Click
        ConsultationCons.TopMost = True
        ConsultationCons.Show()
    End Sub

    Private Sub btnPrescription_Click(sender As Object, e As EventArgs) Handles btnPrescription.Click
        Dim stMRN As String = txtPatientMRN.Text

        PrescriptionCons.TopMost = True

        If Not stMRN = "" Then
            Con.Open()

            sql = "select PatientMRN from PATIENT"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If stMRN = drRow(0).ToString() Then
                    PrescriptionCons.stMRN = stMRN
                    Exit For
                End If
            Next

            Con.Close()
        End If

        PrescriptionCons.intDKey = intDocKey
        PrescriptionCons.Show()
    End Sub

    Private Sub btnLabTest_Click(sender As Object, e As EventArgs) Handles btnLabTest.Click
        LabTestAdmin.TopMost = True
        LabTestAdmin.boolPatientConsTrigger = True
        Dim stMRN As String = txtPatientMRN.Text

        If Not stMRN = "" Then
            Con.Open()

            sql = "select PatientMRN from PATIENT"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If stMRN = drRow(0).ToString() Then
                    LabTestAdmin.stMRN = stMRN
                    Exit For
                End If
            Next

            Con.Close()
        End If

        LabTestAdmin.intDKey = intDocKey
        LabTestAdmin.Show()
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
                txtPatientMRN.Text = dsRow.Cells(0).Value.ToString()
                lblFullName.Text = dsRow.Cells(1).Value.ToString() & " " & dsRow.Cells(2).Value.ToString()
                lblAddress.Text = dsRow.Cells(3).Value.ToString()
                lblSex.Text = dsRow.Cells(4).Value.ToString()
                lblBirthDate.Text = Convert.ToDateTime(dsRow.Cells(5).Value.ToString()).ToString("d")
                txtMedHistory.Text = dsRow.Cells(6).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim stMRN As String = txtPatientMRN.Text

        PaymentCons.TopMost = True

        If Not stMRN = "" Then
            Con.Open()

            sql = "select PatientMRN from PATIENT"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If stMRN = drRow(0).ToString() Then
                    PaymentCons.stMRN = stMRN
                    Exit For
                End If
            Next

            Con.Close()
        End If

        PaymentCons.intSKey = intSecKey
        PaymentCons.Show()
    End Sub
End Class
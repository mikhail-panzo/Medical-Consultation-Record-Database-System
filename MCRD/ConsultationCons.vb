Imports IBM.Data.DB2

Public Class ConsultationCons

    Dim intKey As Integer

    Private Sub ConsultationCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtTime.Value = DateTime.Now
        Populate()

        dgridConsultations.ReadOnly = True
        With dgridConsultations
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Consultation No."
            .Columns(0).Width = 100
            .Columns(1).HeaderCell.Value = "Appointment No."
            .Columns(1).Width = 100
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

        intKey = 0
        lblPatientName.Text = ""
        lblPhysicianName.Text = ""

    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select ConsultationNo, AppointmentNo, PatientMRN, PhysicianID, PName, DName, ""Date"", stTime, Diagnosis from CONSULTATION_FULL_DETAIL"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridConsultations.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtAppointmentNo.Text = ""
        txtDiagnosis.Text = ""
        lblPatientName.Text = ""
        lblPhysicianName.Text = ""
    End Sub

    Private Sub dgridConsultations_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridConsultations.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridConsultations.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtAppointmentNo.Text = dsRow.Cells(1).Value.ToString()
                txtDiagnosis.Text = dsRow.Cells(8).Value.ToString()
                dtDate.Value = dsRow.Cells(6).Value
                dtTime.Value = Convert.ToDateTime(dsRow.Cells(7).Value.ToString())
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtAppointmentNo.Text = "" Then
            MsgBox("Enter an Appointment Number")
        ElseIf Not IsNumeric(txtAppointmentNo.Text) Then
            MsgBox("Enter a valid Appointment Number")
        Else
            Dim boolFound As Boolean = False
            Dim intAppID As Integer = CInt(txtAppointmentNo.Text)
            Dim intDID As Integer
            Dim stMRN As String = ""

            Con.Open()

            sql = "select AppointmentNo, PhysicianID, PatientMRN from APPOINTMENT_DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intAppID = drRow(0) Then
                    intDID = drRow(1)
                    stMRN = drRow(2).ToString()
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Appointment with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If

            sql = "insert into CONSULTATION(PhysicianID, PatientMRN, AppointmentNo, ""Date"", ""Time"", Diagnosis) values (" & intDID & ",'" & stMRN & "'," & intAppID & ",'" & dtDate.Value.ToString("yyyy-MM-dd") & "','" & dtTime.Value.ToString("HH:mm:ss")

            If txtDiagnosis.Text = "" Then
                sql = sql + "','NONE')"
            Else
                sql = sql + "','" & txtDiagnosis.Text & "')"
            End If

            cmd = New DB2Command(sql, Con)
            Try
                cmd.ExecuteNonQuery()
            Catch ex As DB2Exception
                MsgBox(ex.Message)
            End Try
            MsgBox("New consultation data added")

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf (
           txtAppointmentNo.Text = ""
           ) Then
            MsgBox("Data insufficient to update. Please fill in the remaining information")
        ElseIf intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf lblPatientName.Text = "" Then
            MsgBox("Please select the appointment number and check the date and time before editing")
        Else
            Dim boolFound As Boolean = False
            Dim intAppID As Integer = CInt(txtAppointmentNo.Text)
            Dim intDID As Integer
            Dim stMRN As String = ""

            Con.Open()

            sql = "select AppointmentNo, PhysicianID, PatientMRN from APPOINTMENT_DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)
            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intAppID = drRow(0) Then
                    intDID = drRow(1)
                    stMRN = drRow(2).ToString()
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Appointment with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If

            sql = "update CONSULTATION set PhysicianID = " & intDID & ", PatientMRN = '" & stMRN & "', AppointmentNo = " & intAppID & ", ""Date"" = '" & dtDate.Value.ToString("yyyy-MM-dd") & "', ""Time"" = '" & dtTime.Value.ToString("HH:mm:ss") & "', Diagnosis = '" & txtDiagnosis.Text & "' where AppointmentNo = " & intKey

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
                sql = "delete from CONSULTATION where ConsultationNo = " & intKey
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

    Private Sub btnPatientView_Click(sender As Object, e As EventArgs) Handles btnPatientView.Click

        If txtAppointmentNo.Text = "" Then
            MsgBox("Enter an Appointment Number")
        ElseIf Not IsNumeric(txtAppointmentNo.Text) Then
            MsgBox("Enter a valid Appointment Number")
        Else
            Dim boolFound As Boolean = False
            Dim intAppID As Integer = CInt(txtAppointmentNo.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select AppointmentNo, PName, DName, ""Date"", ""Time"" from APPOINTMENT_DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intAppID = drRow(0) Then
                    boolFound = True
                    lblPatientName.Text = drRow(1).ToString()
                    lblPhysicianName.Text = drRow(2).ToString()
                    dtDate.Value = drRow(3)
                    dtTime.Value = Convert.ToDateTime(drRow(4).ToString())
                    Exit For
                End If
            Next

            If Not boolFound Then
                lblPatientName.Text = ""
                lblPhysicianName.Text = ""
                MsgBox("Appointment with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

End Class
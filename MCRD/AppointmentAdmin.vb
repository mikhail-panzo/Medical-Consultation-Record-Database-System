Imports IBM.Data.DB2

Public Class AppointmentAdmin
    Public boolPatientConsTrigger As Boolean
    Public intSKey As Integer
    Public stMRN As String

    Dim intKey As Integer

    Private Sub AppointmentAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtTime.Value = DateTime.Now
        Populate()
        dgridAppointments.ReadOnly = True
        With dgridAppointments
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Appointment No."
            .Columns(0).Width = 150
            .Columns(1).HeaderCell.Value = "Secretary ID"
            .Columns(1).HeaderCell.ToolTipText = "The ID of the secretary handling the appointment"
            .Columns(1).Width = 150
            .Columns(2).HeaderCell.Value = "Patient MRN"
            .Columns(2).HeaderCell.ToolTipText = "Patient Medical Record Number"
            .Columns(2).Width = 150
            .Columns(3).HeaderCell.Value = "Patient"
            .Columns(3).Width = 250
            .Columns(4).HeaderCell.Value = "Doctor"
            .Columns(4).Width = 250
            .Columns(5).HeaderCell.Value = "Date"
            .Columns(5).Width = 100
            .Columns(6).HeaderCell.Value = "Time"
            .Columns(6).Width = 100
        End With

        intKey = 0

        lblPatientName.Text = ""
        lblSecretaryName.Text = ""
        lblPhysicianName.Text = ""
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select AppointmentNo, SecretaryID, PatientMRN, PName, DName, ""Date"", stTime from APPOINTMENT_DOCTOR"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridAppointments.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0
        txtPatientMRN.Text = ""
        txtSecretaryID.Text = ""
    End Sub

    Private Sub dgridAppointments_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridAppointments.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridAppointments.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtSecretaryID.Text = dsRow.Cells(1).Value.ToString()
                txtPatientMRN.Text = dsRow.Cells(2).Value.ToString()
                dtDate.Value = dsRow.Cells(5).Value
                dtTime.Value = Convert.ToDateTime(dsRow.Cells(6).Value.ToString())
            Catch ex As Exception
                Call Clear()
            End Try
        End If



    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If txtPatientMRN.Text = "" Then
            MsgBox("Enter a Patient MRN")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf txtSecretaryID.Text = "" Then
            MsgBox("Enter a Secretary ID number")
        ElseIf Not IsNumeric(txtSecretaryID.Text) Then
            MsgBox("Enter a valid Secretary ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intSecID As Integer = CInt(txtSecretaryID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text

            Con.Open()

            sql = "select SecretaryID from SECRETARY"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intSecID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Secretary with the specified ID does not exist")
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

            sql = "insert into APPOINTMENT(SecretaryID, PatientMRN, ""Date"", ""Time"") values ('" & txtSecretaryID.Text & "','" & txtPatientMRN.Text & "','" & dtDate.Value.ToString("yyyy-MM-dd") & "','" & dtTime.Value.ToString("HH:mm:ss") & "')"
            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("New appointment data added")

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If (
            txtPatientMRN.Text = "" Or
            txtSecretaryID.Text = ""
            ) Then
            MsgBox("Data insufficient to update. Please fill in the remaining information")
        ElseIf intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf Not IsNumeric(txtSecretaryID.Text) Then
            MsgBox("Enter a valid Secretary ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intSecID As Integer = CInt(txtSecretaryID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text

            Con.Open()

            sql = "select SecretaryID from SECRETARY"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intSecID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Secretary with the specified ID does not exist")
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

            sql = "update APPOINTMENT set SecretaryID = '" & txtSecretaryID.Text & "', PatientMRN = '" & txtPatientMRN.Text & "', ""Date"" = '" & dtDate.Value.ToString("yyyy-MM-dd") & "', ""Time"" = '" & dtTime.Value.ToString("HH:mm:ss") & "' where AppointmentNo = " & intKey

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
                sql = "delete from APPOINTMENT where AppointmentNo = " & intKey
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

    Private Sub btnSecretaryView_Click(sender As Object, e As EventArgs) Handles btnSecretaryView.Click

        If txtSecretaryID.Text = "" Then
            MsgBox("Enter a Secretary ID number")
        ElseIf Not IsNumeric(txtSecretaryID.Text) Then
            MsgBox("Enter a valid Secretary ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtSecretaryID.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select SecretaryID, SFName, SLName, DFName, DLName from SECRETARY_DOCTOR"
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
                lblSecretaryName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
                lblPhysicianName.Text = dt.Rows(intCount).Item(3).ToString() & " " & dt.Rows(intCount).Item(4).ToString()
            Else
                lblSecretaryName.Text = ""
                lblPhysicianName.Text = ""
                MsgBox("Secretary with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub AppointmentAdmin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If boolPatientConsTrigger Then
            If intSKey = 0 Then
                txtSecretaryID.Text = ""
            Else
                txtSecretaryID.Text = intSKey
                intSKey = 0
            End If
            boolPatientConsTrigger = False
            Me.Text = "Consultation - Appointments"
        Else
            Clear()
            Me.Text = "Appointments"
        End If
        txtPatientMRN.Text = stMRN
        stMRN = ""
    End Sub



End Class
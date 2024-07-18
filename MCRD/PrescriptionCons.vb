Imports IBM.Data.DB2

Public Class PrescriptionCons
    Public intDKey As Integer
    Public stMRN As String

    Dim intKey As Integer

    Private Sub PrescriptionCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        dgridPrescriptions.ReadOnly = True
        With dgridPrescriptions
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

        Clear()
    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select * from PRESCRIPTION_FULL_DETAIL"
        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridPrescriptions.DataSource = dt

        Con.Close()
    End Sub

    Private Sub Clear()
        intKey = 0

        lblBrandName.Text = ""
        lblGenericName.Text = ""
        lblPatientName.Text = ""
        lblPhysicianName.Text = ""

        txtDetails.Text = ""
        txtMedicineNo.Text = ""
        txtQuantity.Text = ""
        txtPatientMRN.Text = ""
        txtPhysicianID.Text = ""
    End Sub

    Private Sub dgridPrescriptions_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgridPrescriptions.CellMouseClick

        Dim dsRow As DataGridViewRow
        Dim boolLabelClicked As Boolean = False

        Try
            dsRow = dgridPrescriptions.Rows(e.RowIndex)
        Catch ex As Exception
            boolLabelClicked = True
            Call Clear()
        End Try

        If Not boolLabelClicked Then
            Try
                intKey = dsRow.Cells(0).Value.ToString()
                txtMedicineNo.Text = dsRow.Cells(1).Value.ToString()
                txtPatientMRN.Text = dsRow.Cells(2).Value.ToString()
                txtPhysicianID.Text = dsRow.Cells(3).Value.ToString()
                lblBrandName.Text = dsRow.Cells(4).Value.ToString()
                lblGenericName.Text = dsRow.Cells(5).Value.ToString()
                lblPatientName.Text = dsRow.Cells(6).Value.ToString()
                lblPhysicianName.Text = dsRow.Cells(7).Value.ToString()
                dtDate.Value = dsRow.Cells(8).Value
                txtQuantity.Text = dsRow.Cells(9).Value.ToString()
                txtDetails.Text = dsRow.Cells(10).Value.ToString()
            Catch ex As Exception
                Call Clear()
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If (
            txtMedicineNo.Text = "" Or
            txtDetails.Text = "" Or
            txtQuantity.Text = "" Or
            txtPatientMRN.Text = "" Or
            txtPhysicianID.Text = ""
            ) Then
            MsgBox("Input the necessary patient information")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid Physician ID number")
        ElseIf Not IsNumeric(txtMedicineNo.Text) Then
            MsgBox("Enter a valid Medicine Number")
        ElseIf Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Quantity must be numeric")
        Else
            Dim boolFound As Boolean = False
            Dim intDID As Integer = CInt(txtPhysicianID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text
            Dim intMedNo As Integer = CInt(txtMedicineNo.Text)

            Con.Open()

            sql = "select MedicineNo from MEDICINE"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intMedNo = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Medicine with the specified ID does not exist")
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

            sql = "select PhysicianID from DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intDID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Physician with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If


            sql = "insert into PRESCRIPTION(MedicineNo, PatientMRN, PhysicianID, DateOfIssue, Quantity, Details) values (" & intMedNo & ",'" & stPatientMRN & "'," & intDID & ",'" & dtDate.Value.ToString("yyyy-MM-dd") & "'," & CInt(txtQuantity.Text) & ",'" & txtDetails.Text & "')"
            cmd = New DB2Command(sql, Con)
            cmd.ExecuteNonQuery()
            MsgBox("New prescription data added")

            Con.Close()
            Populate()
        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If intKey = 0 Then
            MsgBox("No Entry selected")
        ElseIf (
            txtMedicineNo.Text = "" Or
            txtDetails.Text = "" Or
            txtQuantity.Text = "" Or
            txtPatientMRN.Text = "" Or
            txtPhysicianID.Text = ""
            ) Then
            MsgBox("Input the necessary patient information")
        ElseIf Not IsNumeric(txtPatientMRN.Text) Then
            MsgBox("Enter a valid Patient MRN (must be numeric)")
        ElseIf Not (Strings.Len(txtPatientMRN.Text) = 6) Then
            MsgBox("Enter a valid Patient MRN (must have six (6) digits)")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid Physician ID number")
        ElseIf Not IsNumeric(txtMedicineNo.Text) Then
            MsgBox("Enter a valid Medicine Number")
        ElseIf Not IsNumeric(txtQuantity.Text) Then
            MsgBox("Quantity must be numeric")
        Else

            Dim boolFound As Boolean = False
            Dim intDID As Integer = CInt(txtPhysicianID.Text)
            Dim stPatientMRN As String = txtPatientMRN.Text
            Dim intMedNo As Integer = CInt(txtMedicineNo.Text)

            Con.Open()

            sql = "select MedicineNo from MEDICINE"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intMedNo = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Medicine with the specified ID does not exist")
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

            sql = "select PhysicianID from DOCTOR"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intDID = drRow(0) Then
                    boolFound = True
                    Exit For
                End If
            Next

            If Not boolFound Then
                MsgBox("Physician with the specified ID does not exist")
                Con.Close()
                Exit Sub
            End If

            sql = "update PRESCRIPTION set MedicineNo = " & intMedNo & ", PatientMRN = '" & txtPatientMRN.Text & "', PhysicianID = " & intDID & ",DateOfIssue = '" & dtDate.Value.ToString("yyyy-MM-dd") & "', Quantity = " & CInt(txtQuantity.Text) & ", Details = '" & txtDetails.Text & "' where PrescriptionNo = " & intKey

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
                sql = "delete from PRESCRIPTION where PrescriptionNo = " & intKey
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

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        If txtMedicineNo.Text = "" Then
            MsgBox("Enter a Medicine Number")
        ElseIf Not IsNumeric(txtMedicineNo.Text) Then
            MsgBox("Enter a valid Medicine Number")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtMedicineNo.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select MedicineNo, BrandName, GenericName, ""Description"" from MEDICINE"
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
                lblBrandName.Text = dt.Rows(intCount).Item(1).ToString()
                lblGenericName.Text = dt.Rows(intCount).Item(2).ToString()
                txtDetails.Text = dt.Rows(intCount).Item(3).ToString()
            Else
                lblBrandName.Text = ""
                lblGenericName.Text = ""
                MsgBox("Medicine with the specified ID does not exist")
            End If

            Con.Close()
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

    Private Sub btnPhysicianView_Click(sender As Object, e As EventArgs) Handles btnPhysicianView.Click

        If txtPhysicianID.Text = "" Then
            MsgBox("Enter a Physician ID number")
        ElseIf Not IsNumeric(txtPhysicianID.Text) Then
            MsgBox("Enter a valid Physician ID number")
        Else
            Dim boolFound As Boolean = False
            Dim intID As Integer = CInt(txtPhysicianID.Text)
            Dim intCount As Integer = 0

            Con.Open()

            sql = "select PhysicianID, FName, LName from DOCTOR"
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
                lblPhysicianName.Text = dt.Rows(intCount).Item(1).ToString() & " " & dt.Rows(intCount).Item(2).ToString()
            Else
                lblPhysicianName.Text = ""
                MsgBox("Physician with the specified ID does not exist")
            End If

            Con.Close()
        End If

    End Sub

    Private Sub PrescriptionCons_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If intDKey = 0 Then
            txtPhysicianID.Text = ""
        Else
            txtPhysicianID.Text = intDKey
        End If
        txtPatientMRN.Text = stMRN
        intDKey = 0
        stMRN = ""
    End Sub

End Class
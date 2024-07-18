Imports IBM.Data.DB2

Public Class Laboratory
    Dim intRKey As Integer
    Dim intMKey As Integer
    Dim intKey As Integer
    Dim boolRRef As Boolean

    Private Sub Laboratory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Populate()
        dgridSamples.ReadOnly = True
        With dgridSamples
            .ColumnHeadersDefaultCellStyle.Font = New Font("Montserrat Semibold", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Montserrat Semibold", 10)
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Sample No."
            .Columns(0).Width = 120
            .Columns(1).HeaderCell.Value = "Specimen"
            .Columns(1).Width = 283
            .Columns(2).HeaderCell.Value = "Patient"
            .Columns(2).Width = 226
            .Columns(3).HeaderCell.Value = "Receptionist"
            .Columns(3).Width = 226
            .Columns(4).HeaderCell.Value = "Date"
            .Columns(4).HeaderCell.ToolTipText = "The date when the sample was collected"
            .Columns(4).Width = 96
            .Columns(5).HeaderCell.Value = "Time"
            .Columns(5).HeaderCell.ToolTipText = "The time when the sample was collected"
            .Columns(5).Width = 96
            .Columns(6).HeaderCell.Value = "Status"
            .Columns(6).Width = 120
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
        intRKey = 0
        intMKey = 0
        boolRRef = True

    End Sub

    Private Sub Populate()
        Con.Open()

        sql = "select s.SampleNo, s.SpecimenType, s.PName, s.RName, s.DateOfCollection, s.stTime, (CASE WHEN ps.SampleNo IS NULL THEN 'unprocessed' ELSE 'processed' END) as status from SAMPLE_FULL_DETAIL s LEFT JOIN PROCESSED_SAMPLE ps ON s.SampleNo = ps.SampleNo"

        If boolRRef Then
            sql = sql + " where ReceptionistNo = " & intKey
        End If

        If cboxUnfulfilled.Checked Then
            If boolRRef Then
                sql = sql + " and "
            Else
                sql = sql + " where "
            End If
            sql = sql + "ps.SampleNo is null"
        End If

        adapter = New DB2DataAdapter(sql, Con)
        builder = New DB2CommandBuilder(adapter)
        dt = New DataTable

        adapter.Fill(dt)
        dgridSamples.DataSource = dt

        sql = "select l.LabTestNo, l.LabTestType, l.PName, l.DName, l.""Date"", (CASE WHEN ps.LabTestNo IS NULL THEN 'unprocessed' ELSE 'processed' END) as status from LAB_TEST_DOCTOR l LEFT JOIN PROCESSED_SAMPLE ps ON l.LabTestNo = ps.LabTestNo"


        If cboxUnfulfilled.Checked Then
            sql = sql & " where ps.LabTestNo IS NULL"
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

        If cbIDSelection.Text.ToString() = "Receptionist ID" Then
            If txtSecID.Text = "" Then
                MsgBox("Enter a Receptionist Number")
            ElseIf Not IsNumeric(txtSecID.Text) Then
                MsgBox("Enter a valid Receptionist Number")
            Else
                intKey = CInt(txtSecID.Text)
                intRKey = intKey
                intMKey = 0
                boolRRef = True
                Populate()
            End If
        ElseIf cbIDSelection.Text.ToString() = "Med Tech ID" Then
            If txtSecID.Text = "" Then
                MsgBox("Enter a Med Tech ID number")
            ElseIf Not IsNumeric(txtSecID.Text) Then
                MsgBox("Enter a valid Med Tech ID number")
            Else
                intKey = CInt(txtSecID.Text)
                intRKey = 0
                intMKey = intKey
                boolRRef = False
                Populate()
            End If
        Else
            MsgBox("Selected ID must be either Receptionist or Med Tech")
            cbIDSelection.Text = "Receptionist ID"
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

    Private Sub btnSample_Click(sender As Object, e As EventArgs) Handles btnSample.Click
        SampleLab.TopMost = True
        Con.Open()
        If Not intRKey = 0 Then

            sql = "select ReceptionistNo from LAB_RECEPTIONIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intRKey = drRow(0) Then
                    SampleLab.intRKey = intRKey
                    Exit For
                End If
            Next
            intRKey = 0
        End If
        Con.Close()
        SampleLab.Show()
    End Sub

    Private Sub btnProcSample_Click(sender As Object, e As EventArgs) Handles btnProcSample.Click
        ProcSampleLab.TopMost = True
        Con.Open()
        If Not intMKey = 0 Then

            sql = "select MedTechID from MED_TECHNOLOGIST"
            cmd = New DB2Command(sql, Con)
            dt = New DataTable
            adapter = New DB2DataAdapter(cmd)

            adapter.Fill(dt)

            For Each drRow As DataRow In dt.Rows
                If intMKey = drRow(0) Then
                    ProcSampleLab.intMKey = intMKey
                    Exit For
                End If
            Next
            intMKey = 0
        End If
        Con.Close()
        ProcSampleLab.Show()
    End Sub

End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientCons
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientCons))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMedHistory = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddAppointment = New System.Windows.Forms.Button()
        Me.gboxPatientInfo = New System.Windows.Forms.GroupBox()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatientMRN = New System.Windows.Forms.TextBox()
        Me.lblNameHeader = New System.Windows.Forms.Label()
        Me.dgridAppointments = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.dgridPatients = New System.Windows.Forms.DataGridView()
        Me.cboxUnfulfilled = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dGridPrescriptions = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgridLabResults = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgridConsultations = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.cbSearchType = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConsultation = New System.Windows.Forms.Button()
        Me.btnPrescription = New System.Windows.Forms.Button()
        Me.btnLabTest = New System.Windows.Forms.Button()
        Me.btnPayment = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gboxPatientInfo.SuspendLayout()
        CType(Me.dgridAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgridPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dGridPrescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgridLabResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgridConsultations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(354, 711)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 38)
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(20, 125)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date of Birth"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(312, 125)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Sex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Home Address"
        '
        'txtMedHistory
        '
        Me.txtMedHistory.BackColor = System.Drawing.Color.Azure
        Me.txtMedHistory.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedHistory.Location = New System.Drawing.Point(9, 22)
        Me.txtMedHistory.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.txtMedHistory.MaxLength = 250
        Me.txtMedHistory.Multiline = True
        Me.txtMedHistory.Name = "txtMedHistory"
        Me.txtMedHistory.ReadOnly = True
        Me.txtMedHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMedHistory.Size = New System.Drawing.Size(432, 105)
        Me.txtMedHistory.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtMedHistory)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(13, 172)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 137)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Medical History"
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.BackColor = System.Drawing.Color.Teal
        Me.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddAppointment.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddAppointment.ForeColor = System.Drawing.Color.White
        Me.btnAddAppointment.Location = New System.Drawing.Point(13, 519)
        Me.btnAddAppointment.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Size = New System.Drawing.Size(230, 38)
        Me.btnAddAppointment.TabIndex = 27
        Me.btnAddAppointment.Text = "Add Appointment"
        Me.btnAddAppointment.UseVisualStyleBackColor = False
        '
        'gboxPatientInfo
        '
        Me.gboxPatientInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxPatientInfo.Controls.Add(Me.lblSex)
        Me.gboxPatientInfo.Controls.Add(Me.lblBirthDate)
        Me.gboxPatientInfo.Controls.Add(Me.lblAddress)
        Me.gboxPatientInfo.Controls.Add(Me.lblFullName)
        Me.gboxPatientInfo.Controls.Add(Me.btnView)
        Me.gboxPatientInfo.Controls.Add(Me.Label4)
        Me.gboxPatientInfo.Controls.Add(Me.Label2)
        Me.gboxPatientInfo.Controls.Add(Me.Label3)
        Me.gboxPatientInfo.Controls.Add(Me.Label1)
        Me.gboxPatientInfo.Controls.Add(Me.txtPatientMRN)
        Me.gboxPatientInfo.Controls.Add(Me.lblNameHeader)
        Me.gboxPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxPatientInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxPatientInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxPatientInfo.Location = New System.Drawing.Point(13, 12)
        Me.gboxPatientInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.gboxPatientInfo.Name = "gboxPatientInfo"
        Me.gboxPatientInfo.Size = New System.Drawing.Size(452, 150)
        Me.gboxPatientInfo.TabIndex = 23
        Me.gboxPatientInfo.TabStop = False
        Me.gboxPatientInfo.Text = "Patient Information"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.ForeColor = System.Drawing.Color.Black
        Me.lblSex.Location = New System.Drawing.Point(350, 125)
        Me.lblSex.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(49, 18)
        Me.lblSex.TabIndex = 40
        Me.lblSex.Text = "Name"
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.ForeColor = System.Drawing.Color.Black
        Me.lblBirthDate.Location = New System.Drawing.Point(124, 125)
        Me.lblBirthDate.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(49, 18)
        Me.lblBirthDate.TabIndex = 39
        Me.lblBirthDate.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.ForeColor = System.Drawing.Color.Black
        Me.lblAddress.Location = New System.Drawing.Point(122, 97)
        Me.lblAddress.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(49, 18)
        Me.lblAddress.TabIndex = 38
        Me.lblAddress.Text = "Name"
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.Black
        Me.lblFullName.Location = New System.Drawing.Point(122, 69)
        Me.lblFullName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Size = New System.Drawing.Size(49, 18)
        Me.lblFullName.TabIndex = 37
        Me.lblFullName.Text = "Name"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Teal
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(350, 26)
        Me.btnView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnView.Size = New System.Drawing.Size(91, 22)
        Me.btnView.TabIndex = 36
        Me.btnView.Text = "SELECT"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Patient MRN"
        '
        'txtPatientMRN
        '
        Me.txtPatientMRN.BackColor = System.Drawing.Color.Azure
        Me.txtPatientMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientMRN.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientMRN.Location = New System.Drawing.Point(122, 26)
        Me.txtPatientMRN.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPatientMRN.MaxLength = 6
        Me.txtPatientMRN.Name = "txtPatientMRN"
        Me.txtPatientMRN.Size = New System.Drawing.Size(222, 22)
        Me.txtPatientMRN.TabIndex = 8
        '
        'lblNameHeader
        '
        Me.lblNameHeader.AutoSize = True
        Me.lblNameHeader.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameHeader.ForeColor = System.Drawing.Color.Teal
        Me.lblNameHeader.Location = New System.Drawing.Point(67, 69)
        Me.lblNameHeader.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblNameHeader.Name = "lblNameHeader"
        Me.lblNameHeader.Size = New System.Drawing.Size(49, 18)
        Me.lblNameHeader.TabIndex = 7
        Me.lblNameHeader.Text = "Name"
        '
        'dgridAppointments
        '
        Me.dgridAppointments.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridAppointments.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridAppointments.Location = New System.Drawing.Point(13, 27)
        Me.dgridAppointments.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridAppointments.Name = "dgridAppointments"
        Me.dgridAppointments.RowHeadersWidth = 51
        Me.dgridAppointments.Size = New System.Drawing.Size(474, 210)
        Me.dgridAppointments.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.cboxUnfulfilled)
        Me.Panel1.Controls.Add(Me.GroupBox5)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.cbSearchType)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(478, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 761)
        Me.Panel1.TabIndex = 22
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.dgridPatients)
        Me.GroupBox6.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(10, 43)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1008, 194)
        Me.GroupBox6.TabIndex = 25
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Patients"
        '
        'dgridPatients
        '
        Me.dgridPatients.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridPatients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridPatients.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridPatients.Location = New System.Drawing.Point(13, 27)
        Me.dgridPatients.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridPatients.Name = "dgridPatients"
        Me.dgridPatients.RowHeadersWidth = 51
        Me.dgridPatients.Size = New System.Drawing.Size(982, 154)
        Me.dgridPatients.TabIndex = 0
        '
        'cboxUnfulfilled
        '
        Me.cboxUnfulfilled.AutoSize = True
        Me.cboxUnfulfilled.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxUnfulfilled.ForeColor = System.Drawing.SystemColors.Control
        Me.cboxUnfulfilled.Location = New System.Drawing.Point(901, 13)
        Me.cboxUnfulfilled.Name = "cboxUnfulfilled"
        Me.cboxUnfulfilled.Size = New System.Drawing.Size(117, 26)
        Me.cboxUnfulfilled.TabIndex = 27
        Me.cboxUnfulfilled.Text = "Unfulfilled"
        Me.ToolTip1.SetToolTip(Me.cboxUnfulfilled, "Show only unfulfilled appointments")
        Me.cboxUnfulfilled.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dGridPrescriptions)
        Me.GroupBox5.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.White
        Me.GroupBox5.Location = New System.Drawing.Point(518, 499)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(500, 250)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Prescriptions"
        '
        'dGridPrescriptions
        '
        Me.dGridPrescriptions.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dGridPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dGridPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridPrescriptions.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dGridPrescriptions.Location = New System.Drawing.Point(13, 27)
        Me.dGridPrescriptions.Margin = New System.Windows.Forms.Padding(10)
        Me.dGridPrescriptions.Name = "dGridPrescriptions"
        Me.dGridPrescriptions.RowHeadersWidth = 51
        Me.dGridPrescriptions.Size = New System.Drawing.Size(474, 210)
        Me.dGridPrescriptions.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgridLabResults)
        Me.GroupBox4.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(10, 499)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(500, 250)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lab Test Results"
        '
        'dgridLabResults
        '
        Me.dgridLabResults.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridLabResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridLabResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridLabResults.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridLabResults.Location = New System.Drawing.Point(13, 27)
        Me.dgridLabResults.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridLabResults.Name = "dgridLabResults"
        Me.dgridLabResults.RowHeadersWidth = 51
        Me.dgridLabResults.Size = New System.Drawing.Size(474, 210)
        Me.dgridLabResults.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgridConsultations)
        Me.GroupBox3.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(518, 243)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(500, 250)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Consultations"
        '
        'dgridConsultations
        '
        Me.dgridConsultations.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridConsultations.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridConsultations.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridConsultations.Location = New System.Drawing.Point(13, 27)
        Me.dgridConsultations.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridConsultations.Name = "dgridConsultations"
        Me.dgridConsultations.RowHeadersWidth = 51
        Me.dgridConsultations.Size = New System.Drawing.Size(474, 210)
        Me.dgridConsultations.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgridAppointments)
        Me.GroupBox2.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(10, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(500, 250)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Appointments"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Teal
        Me.btnSearch.Location = New System.Drawing.Point(781, 13)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(114, 24)
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'cbSearchType
        '
        Me.cbSearchType.BackColor = System.Drawing.Color.Azure
        Me.cbSearchType.Font = New System.Drawing.Font("Montserrat", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchType.FormattingEnabled = True
        Me.cbSearchType.Items.AddRange(New Object() {"First Name", "Last Name"})
        Me.cbSearchType.Location = New System.Drawing.Point(603, 13)
        Me.cbSearchType.Name = "cbSearchType"
        Me.cbSearchType.Size = New System.Drawing.Size(172, 24)
        Me.cbSearchType.TabIndex = 17
        Me.cbSearchType.Text = "First Name"
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.Azure
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(10, 12)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtSearch.MaxLength = 50
        Me.txtSearch.MinimumSize = New System.Drawing.Size(2, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(587, 24)
        Me.txtSearch.TabIndex = 16
        '
        'btnConsultation
        '
        Me.btnConsultation.BackColor = System.Drawing.Color.Teal
        Me.btnConsultation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultation.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultation.ForeColor = System.Drawing.Color.White
        Me.btnConsultation.Location = New System.Drawing.Point(14, 567)
        Me.btnConsultation.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.btnConsultation.Name = "btnConsultation"
        Me.btnConsultation.Size = New System.Drawing.Size(230, 38)
        Me.btnConsultation.TabIndex = 29
        Me.btnConsultation.Text = "Record Consultation"
        Me.btnConsultation.UseVisualStyleBackColor = False
        '
        'btnPrescription
        '
        Me.btnPrescription.BackColor = System.Drawing.Color.Teal
        Me.btnPrescription.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrescription.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrescription.ForeColor = System.Drawing.Color.White
        Me.btnPrescription.Location = New System.Drawing.Point(13, 615)
        Me.btnPrescription.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.btnPrescription.Name = "btnPrescription"
        Me.btnPrescription.Size = New System.Drawing.Size(230, 38)
        Me.btnPrescription.TabIndex = 30
        Me.btnPrescription.Text = "Record Prescription"
        Me.btnPrescription.UseVisualStyleBackColor = False
        '
        'btnLabTest
        '
        Me.btnLabTest.BackColor = System.Drawing.Color.Teal
        Me.btnLabTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLabTest.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabTest.ForeColor = System.Drawing.Color.White
        Me.btnLabTest.Location = New System.Drawing.Point(13, 663)
        Me.btnLabTest.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.btnLabTest.Name = "btnLabTest"
        Me.btnLabTest.Size = New System.Drawing.Size(230, 38)
        Me.btnLabTest.TabIndex = 31
        Me.btnLabTest.Text = "Order Lab Test"
        Me.btnLabTest.UseVisualStyleBackColor = False
        '
        'btnPayment
        '
        Me.btnPayment.BackColor = System.Drawing.Color.Teal
        Me.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPayment.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayment.ForeColor = System.Drawing.Color.White
        Me.btnPayment.Location = New System.Drawing.Point(13, 711)
        Me.btnPayment.Margin = New System.Windows.Forms.Padding(3, 0, 3, 10)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(230, 38)
        Me.btnPayment.TabIndex = 32
        Me.btnPayment.Text = "Process Payment"
        Me.btnPayment.UseVisualStyleBackColor = False
        '
        'PatientCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1508, 761)
        Me.Controls.Add(Me.btnPayment)
        Me.Controls.Add(Me.btnLabTest)
        Me.Controls.Add(Me.btnPrescription)
        Me.Controls.Add(Me.btnConsultation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddAppointment)
        Me.Controls.Add(Me.gboxPatientInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1524, 800)
        Me.Name = "PatientCons"
        Me.Text = "Consultation - Patients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboxPatientInfo.ResumeLayout(False)
        Me.gboxPatientInfo.PerformLayout()
        CType(Me.dgridAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgridPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dGridPrescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgridLabResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgridConsultations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMedHistory As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddAppointment As Button
    Friend WithEvents gboxPatientInfo As GroupBox
    Friend WithEvents lblNameHeader As Label
    Friend WithEvents dgridAppointments As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatientMRN As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnView As Button
    Friend WithEvents lblSex As Label
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dGridPrescriptions As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgridLabResults As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgridConsultations As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbSearchType As ComboBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents dgridPatients As DataGridView
    Friend WithEvents cboxUnfulfilled As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnConsultation As Button
    Friend WithEvents btnPrescription As Button
    Friend WithEvents btnLabTest As Button
    Friend WithEvents btnPayment As Button
End Class

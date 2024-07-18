<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcSampleLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcSampleLab))
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.txtMedTechID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblMedTechName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMedTechView = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgridProcSamples = New System.Windows.Forms.DataGridView()
        Me.gboxAppointmentInfo = New System.Windows.Forms.GroupBox()
        Me.lblSourcePatient = New System.Windows.Forms.Label()
        Me.lblSpecimenType = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtSampleNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLabTestType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPhysicianName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblLabTestType = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLabTestView = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtLabTestNo = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSelectedNo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgridProcSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxAppointmentInfo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.Teal
        Me.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProcess.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.ForeColor = System.Drawing.Color.White
        Me.btnProcess.Location = New System.Drawing.Point(93, 511)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(102, 38)
        Me.btnProcess.TabIndex = 55
        Me.btnProcess.Text = "Process"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'txtMedTechID
        '
        Me.txtMedTechID.BackColor = System.Drawing.Color.Azure
        Me.txtMedTechID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedTechID.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedTechID.Location = New System.Drawing.Point(106, 30)
        Me.txtMedTechID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtMedTechID.MaxLength = 4
        Me.txtMedTechID.Name = "txtMedTechID"
        Me.txtMedTechID.Size = New System.Drawing.Size(347, 22)
        Me.txtMedTechID.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblMedTechName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnMedTechView)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtMedTechID)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(12, 270)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 95)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Medical Technologist In Charge"
        '
        'lblMedTechName
        '
        Me.lblMedTechName.AutoSize = True
        Me.lblMedTechName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblMedTechName.ForeColor = System.Drawing.Color.Black
        Me.lblMedTechName.Location = New System.Drawing.Point(64, 64)
        Me.lblMedTechName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblMedTechName.Name = "lblMedTechName"
        Me.lblMedTechName.Size = New System.Drawing.Size(81, 20)
        Me.lblMedTechName.TabIndex = 29
        Me.lblMedTechName.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Name:"
        '
        'btnMedTechView
        '
        Me.btnMedTechView.BackColor = System.Drawing.Color.Teal
        Me.btnMedTechView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedTechView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMedTechView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedTechView.ForeColor = System.Drawing.Color.White
        Me.btnMedTechView.Location = New System.Drawing.Point(464, 30)
        Me.btnMedTechView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnMedTechView.Name = "btnMedTechView"
        Me.btnMedTechView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnMedTechView.Size = New System.Drawing.Size(91, 22)
        Me.btnMedTechView.TabIndex = 38
        Me.btnMedTechView.Text = "VIEW"
        Me.btnMedTechView.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(6, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Med Tech ID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgridProcSamples)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 561)
        Me.Panel1.TabIndex = 51
        '
        'dgridProcSamples
        '
        Me.dgridProcSamples.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridProcSamples.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridProcSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridProcSamples.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridProcSamples.Location = New System.Drawing.Point(10, 10)
        Me.dgridProcSamples.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridProcSamples.Name = "dgridProcSamples"
        Me.dgridProcSamples.RowHeadersWidth = 51
        Me.dgridProcSamples.Size = New System.Drawing.Size(580, 541)
        Me.dgridProcSamples.TabIndex = 0
        '
        'gboxAppointmentInfo
        '
        Me.gboxAppointmentInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxAppointmentInfo.Controls.Add(Me.lblSourcePatient)
        Me.gboxAppointmentInfo.Controls.Add(Me.lblSpecimenType)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label13)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label4)
        Me.gboxAppointmentInfo.Controls.Add(Me.btnSelect)
        Me.gboxAppointmentInfo.Controls.Add(Me.txtSampleNo)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label1)
        Me.gboxAppointmentInfo.Controls.Add(Me.txtLabTestType)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label6)
        Me.gboxAppointmentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxAppointmentInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxAppointmentInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxAppointmentInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxAppointmentInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.gboxAppointmentInfo.Name = "gboxAppointmentInfo"
        Me.gboxAppointmentInfo.Size = New System.Drawing.Size(564, 250)
        Me.gboxAppointmentInfo.TabIndex = 52
        Me.gboxAppointmentInfo.TabStop = False
        Me.gboxAppointmentInfo.Text = "Processed Sample Information"
        '
        'lblSourcePatient
        '
        Me.lblSourcePatient.AutoSize = True
        Me.lblSourcePatient.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblSourcePatient.ForeColor = System.Drawing.Color.Black
        Me.lblSourcePatient.Location = New System.Drawing.Point(114, 214)
        Me.lblSourcePatient.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblSourcePatient.Name = "lblSourcePatient"
        Me.lblSourcePatient.Size = New System.Drawing.Size(81, 20)
        Me.lblSourcePatient.TabIndex = 43
        Me.lblSourcePatient.Text = "Full Name"
        '
        'lblSpecimenType
        '
        Me.lblSpecimenType.AutoSize = True
        Me.lblSpecimenType.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblSpecimenType.ForeColor = System.Drawing.Color.Black
        Me.lblSpecimenType.Location = New System.Drawing.Point(114, 191)
        Me.lblSpecimenType.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblSpecimenType.Name = "lblSpecimenType"
        Me.lblSpecimenType.Size = New System.Drawing.Size(81, 20)
        Me.lblSpecimenType.TabIndex = 40
        Me.lblSpecimenType.Text = "Full Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 216)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 15)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Source Patient:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Specimen Type:"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Teal
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(464, 156)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size(91, 22)
        Me.btnSelect.TabIndex = 40
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'txtSampleNo
        '
        Me.txtSampleNo.BackColor = System.Drawing.Color.Azure
        Me.txtSampleNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSampleNo.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSampleNo.Location = New System.Drawing.Point(107, 156)
        Me.txtSampleNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtSampleNo.MaxLength = 6
        Me.txtSampleNo.Name = "txtSampleNo"
        Me.txtSampleNo.Size = New System.Drawing.Size(346, 22)
        Me.txtSampleNo.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(7, 157)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Sample No."
        '
        'txtLabTestType
        '
        Me.txtLabTestType.BackColor = System.Drawing.Color.Azure
        Me.txtLabTestType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabTestType.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabTestType.Location = New System.Drawing.Point(10, 50)
        Me.txtLabTestType.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtLabTestType.MaxLength = 100
        Me.txtLabTestType.Multiline = True
        Me.txtLabTestType.Name = "txtLabTestType"
        Me.txtLabTestType.Size = New System.Drawing.Size(545, 81)
        Me.txtLabTestType.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(6, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Lab Test Type"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Teal
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(12, 511)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 38)
        Me.btnAdd.TabIndex = 54
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(476, 511)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 38)
        Me.btnExit.TabIndex = 57
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblPhysicianName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblLabTestType)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnLabTestView)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtLabTestNo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(12, 375)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 119)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lab Test Order"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "(Optional Entry) The lab test ordered by a physician where the processing of samp" &
        "le is for")
        '
        'lblPhysicianName
        '
        Me.lblPhysicianName.AutoSize = True
        Me.lblPhysicianName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblPhysicianName.ForeColor = System.Drawing.Color.Black
        Me.lblPhysicianName.Location = New System.Drawing.Point(117, 90)
        Me.lblPhysicianName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblPhysicianName.Name = "lblPhysicianName"
        Me.lblPhysicianName.Size = New System.Drawing.Size(81, 20)
        Me.lblPhysicianName.TabIndex = 41
        Me.lblPhysicianName.Text = "Full Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 92)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 18)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Ordered By:"
        '
        'lblLabTestType
        '
        Me.lblLabTestType.AutoSize = True
        Me.lblLabTestType.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblLabTestType.ForeColor = System.Drawing.Color.Black
        Me.lblLabTestType.Location = New System.Drawing.Point(117, 64)
        Me.lblLabTestType.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblLabTestType.Name = "lblLabTestType"
        Me.lblLabTestType.Size = New System.Drawing.Size(81, 20)
        Me.lblLabTestType.TabIndex = 29
        Me.lblLabTestType.Text = "Full Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 66)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 18)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Lab Test Type:"
        '
        'btnLabTestView
        '
        Me.btnLabTestView.BackColor = System.Drawing.Color.Teal
        Me.btnLabTestView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLabTestView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLabTestView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabTestView.ForeColor = System.Drawing.Color.White
        Me.btnLabTestView.Location = New System.Drawing.Point(464, 30)
        Me.btnLabTestView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnLabTestView.Name = "btnLabTestView"
        Me.btnLabTestView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnLabTestView.Size = New System.Drawing.Size(91, 22)
        Me.btnLabTestView.TabIndex = 38
        Me.btnLabTestView.Text = "VIEW"
        Me.btnLabTestView.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(6, 31)
        Me.Label8.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 18)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Lab Test No."
        '
        'txtLabTestNo
        '
        Me.txtLabTestNo.BackColor = System.Drawing.Color.Azure
        Me.txtLabTestNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabTestNo.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabTestNo.Location = New System.Drawing.Point(106, 30)
        Me.txtLabTestNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtLabTestNo.MaxLength = 6
        Me.txtLabTestNo.Name = "txtLabTestNo"
        Me.txtLabTestNo.Size = New System.Drawing.Size(347, 22)
        Me.txtLabTestNo.TabIndex = 36
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel2.Controls.Add(Me.lblSelectedNo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(201, 511)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 38)
        Me.Panel2.TabIndex = 58
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(3, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(208, 20)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Selected Processed Sample No.   :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectedNo
        '
        Me.lblSelectedNo.Font = New System.Drawing.Font("Montserrat", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedNo.ForeColor = System.Drawing.Color.Teal
        Me.lblSelectedNo.Location = New System.Drawing.Point(206, 9)
        Me.lblSelectedNo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblSelectedNo.Name = "lblSelectedNo"
        Me.lblSelectedNo.Size = New System.Drawing.Size(58, 20)
        Me.lblSelectedNo.TabIndex = 43
        Me.lblSelectedNo.Text = "NONE"
        Me.lblSelectedNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProcSampleLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gboxAppointmentInfo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "ProcSampleLab"
        Me.Text = "Laboratory - Processed Samples"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgridProcSamples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxAppointmentInfo.ResumeLayout(False)
        Me.gboxAppointmentInfo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProcess As Button
    Friend WithEvents txtMedTechID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblMedTechName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMedTechView As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgridProcSamples As DataGridView
    Friend WithEvents gboxAppointmentInfo As GroupBox
    Friend WithEvents txtLabTestType As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPhysicianName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblLabTestType As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnLabTestView As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtLabTestNo As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnSelect As Button
    Friend WithEvents txtSampleNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSourcePatient As Label
    Friend WithEvents lblSpecimenType As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblSelectedNo As Label
    Friend WithEvents Label5 As Label
End Class

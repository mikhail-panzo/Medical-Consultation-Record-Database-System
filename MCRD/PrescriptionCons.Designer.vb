<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrescriptionCons
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrescriptionCons))
        Me.dgridPrescriptions = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboxAppointmentInfo = New System.Windows.Forms.GroupBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblGenericName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.txtMedicineNo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPatientView = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPatientMRN = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPhysicianName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnPhysicianView = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhysicianID = New System.Windows.Forms.TextBox()
        CType(Me.dgridPrescriptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxAppointmentInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgridPrescriptions
        '
        Me.dgridPrescriptions.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridPrescriptions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridPrescriptions.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridPrescriptions.Location = New System.Drawing.Point(10, 10)
        Me.dgridPrescriptions.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridPrescriptions.Name = "dgridPrescriptions"
        Me.dgridPrescriptions.RowHeadersWidth = 51
        Me.dgridPrescriptions.Size = New System.Drawing.Size(580, 541)
        Me.dgridPrescriptions.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Medicine Number"
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
        Me.btnExit.TabIndex = 49
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Patient MRN"
        '
        'gboxAppointmentInfo
        '
        Me.gboxAppointmentInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxAppointmentInfo.Controls.Add(Me.txtDetails)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label12)
        Me.gboxAppointmentInfo.Controls.Add(Me.lblGenericName)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label10)
        Me.gboxAppointmentInfo.Controls.Add(Me.lblBrandName)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label8)
        Me.gboxAppointmentInfo.Controls.Add(Me.btnSelect)
        Me.gboxAppointmentInfo.Controls.Add(Me.txtMedicineNo)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label5)
        Me.gboxAppointmentInfo.Controls.Add(Me.txtQuantity)
        Me.gboxAppointmentInfo.Controls.Add(Me.dtDate)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label4)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label1)
        Me.gboxAppointmentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxAppointmentInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxAppointmentInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxAppointmentInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxAppointmentInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.gboxAppointmentInfo.Name = "gboxAppointmentInfo"
        Me.gboxAppointmentInfo.Size = New System.Drawing.Size(564, 284)
        Me.gboxAppointmentInfo.TabIndex = 44
        Me.gboxAppointmentInfo.TabStop = False
        Me.gboxAppointmentInfo.Text = "Prescription Information"
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.Color.Azure
        Me.txtDetails.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Location = New System.Drawing.Point(9, 136)
        Me.txtDetails.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.txtDetails.MaxLength = 250
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDetails.Size = New System.Drawing.Size(546, 63)
        Me.txtDetails.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(8, 115)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Prescription Details"
        '
        'lblGenericName
        '
        Me.lblGenericName.AutoSize = True
        Me.lblGenericName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblGenericName.ForeColor = System.Drawing.Color.Black
        Me.lblGenericName.Location = New System.Drawing.Point(141, 85)
        Me.lblGenericName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblGenericName.Name = "lblGenericName"
        Me.lblGenericName.Size = New System.Drawing.Size(81, 20)
        Me.lblGenericName.TabIndex = 45
        Me.lblGenericName.Text = "Full Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(43, 87)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Generic Name:"
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblBrandName.ForeColor = System.Drawing.Color.Black
        Me.lblBrandName.Location = New System.Drawing.Point(141, 62)
        Me.lblBrandName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(81, 20)
        Me.lblBrandName.TabIndex = 40
        Me.lblBrandName.Text = "Full Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Brand Name:"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Teal
        Me.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.ForeColor = System.Drawing.Color.White
        Me.btnSelect.Location = New System.Drawing.Point(464, 25)
        Me.btnSelect.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSelect.Size = New System.Drawing.Size(91, 24)
        Me.btnSelect.TabIndex = 40
        Me.btnSelect.Text = "SELECT"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'txtMedicineNo
        '
        Me.txtMedicineNo.BackColor = System.Drawing.Color.Azure
        Me.txtMedicineNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedicineNo.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedicineNo.Location = New System.Drawing.Point(145, 25)
        Me.txtMedicineNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtMedicineNo.MaxLength = 6
        Me.txtMedicineNo.Name = "txtMedicineNo"
        Me.txtMedicineNo.Size = New System.Drawing.Size(308, 24)
        Me.txtMedicineNo.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Teal
        Me.Label5.Location = New System.Drawing.Point(8, 219)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.BackColor = System.Drawing.Color.Azure
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(11, 247)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtQuantity.MaxLength = 6
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(268, 24)
        Me.txtQuantity.TabIndex = 40
        '
        'dtDate
        '
        Me.dtDate.CalendarFont = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.CalendarMonthBackground = System.Drawing.Color.Azure
        Me.dtDate.CalendarTitleBackColor = System.Drawing.Color.Azure
        Me.dtDate.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(285, 247)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(270, 24)
        Me.dtDate.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(283, 219)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date of Issue"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Patient Name:"
        '
        'btnPatientView
        '
        Me.btnPatientView.BackColor = System.Drawing.Color.Teal
        Me.btnPatientView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatientView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientView.ForeColor = System.Drawing.Color.White
        Me.btnPatientView.Location = New System.Drawing.Point(464, 29)
        Me.btnPatientView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnPatientView.Name = "btnPatientView"
        Me.btnPatientView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPatientView.Size = New System.Drawing.Size(91, 22)
        Me.btnPatientView.TabIndex = 38
        Me.btnPatientView.Text = "VIEW"
        Me.btnPatientView.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgridPrescriptions)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 561)
        Me.Panel1.TabIndex = 43
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(134, 59)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(81, 20)
        Me.lblPatientName.TabIndex = 29
        Me.lblPatientName.Text = "Full Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblPatientName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnPatientView)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPatientMRN)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(12, 304)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 93)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient"
        '
        'txtPatientMRN
        '
        Me.txtPatientMRN.BackColor = System.Drawing.Color.Azure
        Me.txtPatientMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientMRN.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientMRN.Location = New System.Drawing.Point(106, 28)
        Me.txtPatientMRN.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPatientMRN.MaxLength = 6
        Me.txtPatientMRN.Name = "txtPatientMRN"
        Me.txtPatientMRN.Size = New System.Drawing.Size(347, 22)
        Me.txtPatientMRN.TabIndex = 36
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Teal
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(118, 511)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 38)
        Me.btnEdit.TabIndex = 47
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
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
        Me.btnAdd.Size = New System.Drawing.Size(100, 38)
        Me.btnAdd.TabIndex = 46
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Teal
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(226, 511)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 38)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblPhysicianName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnPhysicianView)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPhysicianID)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(12, 407)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 93)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Physician"
        '
        'lblPhysicianName
        '
        Me.lblPhysicianName.AutoSize = True
        Me.lblPhysicianName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblPhysicianName.ForeColor = System.Drawing.Color.Black
        Me.lblPhysicianName.Location = New System.Drawing.Point(134, 59)
        Me.lblPhysicianName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblPhysicianName.Name = "lblPhysicianName"
        Me.lblPhysicianName.Size = New System.Drawing.Size(81, 20)
        Me.lblPhysicianName.TabIndex = 29
        Me.lblPhysicianName.Text = "Full Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Physician Name:"
        '
        'btnPhysicianView
        '
        Me.btnPhysicianView.BackColor = System.Drawing.Color.Teal
        Me.btnPhysicianView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPhysicianView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPhysicianView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhysicianView.ForeColor = System.Drawing.Color.White
        Me.btnPhysicianView.Location = New System.Drawing.Point(464, 29)
        Me.btnPhysicianView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnPhysicianView.Name = "btnPhysicianView"
        Me.btnPhysicianView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPhysicianView.Size = New System.Drawing.Size(91, 22)
        Me.btnPhysicianView.TabIndex = 38
        Me.btnPhysicianView.Text = "VIEW"
        Me.btnPhysicianView.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(8, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Physician ID"
        '
        'txtPhysicianID
        '
        Me.txtPhysicianID.BackColor = System.Drawing.Color.Azure
        Me.txtPhysicianID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhysicianID.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysicianID.Location = New System.Drawing.Point(106, 28)
        Me.txtPhysicianID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPhysicianID.MaxLength = 6
        Me.txtPhysicianID.Name = "txtPhysicianID"
        Me.txtPhysicianID.Size = New System.Drawing.Size(347, 22)
        Me.txtPhysicianID.TabIndex = 36
        '
        'PrescriptionCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gboxAppointmentInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "PrescriptionCons"
        Me.Text = "Consultation - Prescriptions"
        CType(Me.dgridPrescriptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxAppointmentInfo.ResumeLayout(False)
        Me.gboxAppointmentInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgridPrescriptions As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents gboxAppointmentInfo As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPatientView As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPatientName As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPatientMRN As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPhysicianName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnPhysicianView As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPhysicianID As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lblGenericName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblBrandName As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents txtMedicineNo As TextBox
    Friend WithEvents txtDetails As TextBox
End Class

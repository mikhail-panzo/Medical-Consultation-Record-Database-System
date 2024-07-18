<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabTestAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabTestAdmin))
        Me.lblPhysicianName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDoctorView = New System.Windows.Forms.Button()
        Me.txtPhysicianID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgridLabTests = New System.Windows.Forms.DataGridView()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboxLabTestInfo = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLabTestType = New System.Windows.Forms.TextBox()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgridLabTests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxLabTestInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPhysicianName
        '
        Me.lblPhysicianName.AutoSize = True
        Me.lblPhysicianName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblPhysicianName.ForeColor = System.Drawing.Color.Black
        Me.lblPhysicianName.Location = New System.Drawing.Point(129, 84)
        Me.lblPhysicianName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblPhysicianName.Name = "lblPhysicianName"
        Me.lblPhysicianName.Size = New System.Drawing.Size(81, 20)
        Me.lblPhysicianName.TabIndex = 41
        Me.lblPhysicianName.Text = "Full Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Physician Name:"
        '
        'btnDoctorView
        '
        Me.btnDoctorView.BackColor = System.Drawing.Color.Teal
        Me.btnDoctorView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoctorView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDoctorView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctorView.ForeColor = System.Drawing.Color.White
        Me.btnDoctorView.Location = New System.Drawing.Point(464, 52)
        Me.btnDoctorView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnDoctorView.Name = "btnDoctorView"
        Me.btnDoctorView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnDoctorView.Size = New System.Drawing.Size(91, 22)
        Me.btnDoctorView.TabIndex = 38
        Me.btnDoctorView.Text = "VIEW"
        Me.btnDoctorView.UseVisualStyleBackColor = False
        '
        'txtPhysicianID
        '
        Me.txtPhysicianID.BackColor = System.Drawing.Color.Azure
        Me.txtPhysicianID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhysicianID.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysicianID.Location = New System.Drawing.Point(9, 52)
        Me.txtPhysicianID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPhysicianID.MaxLength = 4
        Me.txtPhysicianID.Name = "txtPhysicianID"
        Me.txtPhysicianID.Size = New System.Drawing.Size(444, 22)
        Me.txtPhysicianID.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblPhysicianName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.btnDoctorView)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtPhysicianID)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(12, 384)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 115)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Doctor Information"
        Me.ToolTip1.SetToolTip(Me.GroupBox2, "Physician ordering the Lab Test")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(6, 29)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Physician ID"
        '
        'dgridLabTests
        '
        Me.dgridLabTests.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridLabTests.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridLabTests.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridLabTests.Location = New System.Drawing.Point(10, 10)
        Me.dgridLabTests.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.dgridLabTests.Name = "dgridLabTests"
        Me.dgridLabTests.RowHeadersWidth = 51
        Me.dgridLabTests.Size = New System.Drawing.Size(580, 541)
        Me.dgridLabTests.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(476, 512)
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
        'gboxLabTestInfo
        '
        Me.gboxLabTestInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxLabTestInfo.Controls.Add(Me.Label1)
        Me.gboxLabTestInfo.Controls.Add(Me.txtLabTestType)
        Me.gboxLabTestInfo.Controls.Add(Me.dtDate)
        Me.gboxLabTestInfo.Controls.Add(Me.Label4)
        Me.gboxLabTestInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxLabTestInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxLabTestInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxLabTestInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxLabTestInfo.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.gboxLabTestInfo.Name = "gboxLabTestInfo"
        Me.gboxLabTestInfo.Size = New System.Drawing.Size(564, 236)
        Me.gboxLabTestInfo.TabIndex = 44
        Me.gboxLabTestInfo.TabStop = False
        Me.gboxLabTestInfo.Text = "Lab Test Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Lab Test Type"
        '
        'txtLabTestType
        '
        Me.txtLabTestType.BackColor = System.Drawing.Color.Azure
        Me.txtLabTestType.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabTestType.Location = New System.Drawing.Point(10, 50)
        Me.txtLabTestType.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.txtLabTestType.MaxLength = 250
        Me.txtLabTestType.Multiline = True
        Me.txtLabTestType.Name = "txtLabTestType"
        Me.txtLabTestType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLabTestType.Size = New System.Drawing.Size(546, 103)
        Me.txtLabTestType.TabIndex = 17
        '
        'dtDate
        '
        Me.dtDate.CalendarFont = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.CalendarMonthBackground = System.Drawing.Color.Azure
        Me.dtDate.CalendarTitleBackColor = System.Drawing.Color.Azure
        Me.dtDate.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(9, 201)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(547, 24)
        Me.dtDate.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(6, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date Ordered"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Name:"
        '
        'btnPatientView
        '
        Me.btnPatientView.BackColor = System.Drawing.Color.Teal
        Me.btnPatientView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatientView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientView.ForeColor = System.Drawing.Color.White
        Me.btnPatientView.Location = New System.Drawing.Point(464, 52)
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
        Me.Panel1.Controls.Add(Me.dgridLabTests)
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
        Me.lblPatientName.Location = New System.Drawing.Point(62, 84)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 119)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Information"
        '
        'txtPatientMRN
        '
        Me.txtPatientMRN.BackColor = System.Drawing.Color.Azure
        Me.txtPatientMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientMRN.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientMRN.Location = New System.Drawing.Point(9, 52)
        Me.txtPatientMRN.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPatientMRN.MaxLength = 6
        Me.txtPatientMRN.Name = "txtPatientMRN"
        Me.txtPatientMRN.Size = New System.Drawing.Size(444, 22)
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
        Me.btnDelete.Location = New System.Drawing.Point(223, 511)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 38)
        Me.btnDelete.TabIndex = 48
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'LabTestAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gboxLabTestInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "LabTestAdmin"
        Me.Text = "Lab Tests"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgridLabTests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxLabTestInfo.ResumeLayout(False)
        Me.gboxLabTestInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPhysicianName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDoctorView As Button
    Friend WithEvents txtPhysicianID As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgridLabTests As DataGridView
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents gboxLabTestInfo As GroupBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLabTestType As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class

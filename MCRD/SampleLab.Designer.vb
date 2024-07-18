<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SampleLab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SampleLab))
        Me.lblReceptionistName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnReceptionistView = New System.Windows.Forms.Button()
        Me.txtReceptionistNo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgridSamples = New System.Windows.Forms.DataGridView()
        Me.dtTime = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gboxAppointmentInfo = New System.Windows.Forms.GroupBox()
        Me.txtSpecimenType = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgridSamples, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxAppointmentInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblReceptionistName
        '
        Me.lblReceptionistName.AutoSize = True
        Me.lblReceptionistName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblReceptionistName.ForeColor = System.Drawing.Color.Black
        Me.lblReceptionistName.Location = New System.Drawing.Point(148, 64)
        Me.lblReceptionistName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblReceptionistName.Name = "lblReceptionistName"
        Me.lblReceptionistName.Size = New System.Drawing.Size(81, 20)
        Me.lblReceptionistName.TabIndex = 29
        Me.lblReceptionistName.Text = "Full Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(91, 66)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 18)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Name:"
        '
        'btnReceptionistView
        '
        Me.btnReceptionistView.BackColor = System.Drawing.Color.Teal
        Me.btnReceptionistView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReceptionistView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReceptionistView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceptionistView.ForeColor = System.Drawing.Color.White
        Me.btnReceptionistView.Location = New System.Drawing.Point(464, 30)
        Me.btnReceptionistView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnReceptionistView.Name = "btnReceptionistView"
        Me.btnReceptionistView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnReceptionistView.Size = New System.Drawing.Size(91, 22)
        Me.btnReceptionistView.TabIndex = 38
        Me.btnReceptionistView.Text = "VIEW"
        Me.btnReceptionistView.UseVisualStyleBackColor = False
        '
        'txtReceptionistNo
        '
        Me.txtReceptionistNo.BackColor = System.Drawing.Color.Azure
        Me.txtReceptionistNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceptionistNo.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceptionistNo.Location = New System.Drawing.Point(150, 29)
        Me.txtReceptionistNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtReceptionistNo.MaxLength = 4
        Me.txtReceptionistNo.Name = "txtReceptionistNo"
        Me.txtReceptionistNo.Size = New System.Drawing.Size(303, 22)
        Me.txtReceptionistNo.TabIndex = 36
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblReceptionistName)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.btnReceptionistView)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtReceptionistNo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(12, 272)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 98)
        Me.GroupBox2.TabIndex = 50
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receptionist In Charge"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Teal
        Me.Label10.Location = New System.Drawing.Point(20, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 18)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Receptionist No."
        '
        'dgridSamples
        '
        Me.dgridSamples.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridSamples.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridSamples.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridSamples.Location = New System.Drawing.Point(10, 10)
        Me.dgridSamples.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridSamples.Name = "dgridSamples"
        Me.dgridSamples.RowHeadersWidth = 51
        Me.dgridSamples.Size = New System.Drawing.Size(580, 541)
        Me.dgridSamples.TabIndex = 0
        '
        'dtTime
        '
        Me.dtTime.CalendarMonthBackground = System.Drawing.Color.Azure
        Me.dtTime.CalendarTitleBackColor = System.Drawing.Color.Azure
        Me.dtTime.CustomFormat = "  hh:mm tt"
        Me.dtTime.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTime.Location = New System.Drawing.Point(285, 108)
        Me.dtTime.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.dtTime.Name = "dtTime"
        Me.dtTime.ShowUpDown = True
        Me.dtTime.Size = New System.Drawing.Size(270, 24)
        Me.dtTime.TabIndex = 17
        Me.dtTime.Value = New Date(2022, 7, 26, 15, 18, 11, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(282, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Time of Collection"
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
        Me.Label3.Location = New System.Drawing.Point(47, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Patient MRN"
        '
        'gboxAppointmentInfo
        '
        Me.gboxAppointmentInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxAppointmentInfo.Controls.Add(Me.txtSpecimenType)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label6)
        Me.gboxAppointmentInfo.Controls.Add(Me.dtTime)
        Me.gboxAppointmentInfo.Controls.Add(Me.dtDate)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label4)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label1)
        Me.gboxAppointmentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxAppointmentInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxAppointmentInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxAppointmentInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxAppointmentInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.gboxAppointmentInfo.Name = "gboxAppointmentInfo"
        Me.gboxAppointmentInfo.Size = New System.Drawing.Size(564, 143)
        Me.gboxAppointmentInfo.TabIndex = 44
        Me.gboxAppointmentInfo.TabStop = False
        Me.gboxAppointmentInfo.Text = "Sample Information"
        '
        'txtSpecimenType
        '
        Me.txtSpecimenType.BackColor = System.Drawing.Color.Azure
        Me.txtSpecimenType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSpecimenType.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSpecimenType.Location = New System.Drawing.Point(10, 50)
        Me.txtSpecimenType.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtSpecimenType.MaxLength = 100
        Me.txtSpecimenType.Name = "txtSpecimenType"
        Me.txtSpecimenType.Size = New System.Drawing.Size(545, 22)
        Me.txtSpecimenType.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(6, 27)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Specimen Type"
        '
        'dtDate
        '
        Me.dtDate.CalendarFont = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.CalendarMonthBackground = System.Drawing.Color.Azure
        Me.dtDate.CalendarTitleBackColor = System.Drawing.Color.Azure
        Me.dtDate.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(9, 108)
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
        Me.Label4.Location = New System.Drawing.Point(7, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date of Collection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 66)
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
        Me.btnPatientView.Location = New System.Drawing.Point(464, 30)
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
        Me.Panel1.Controls.Add(Me.dgridSamples)
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
        Me.lblPatientName.Location = New System.Drawing.Point(148, 64)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 163)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 99)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient"
        '
        'txtPatientMRN
        '
        Me.txtPatientMRN.BackColor = System.Drawing.Color.Azure
        Me.txtPatientMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientMRN.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientMRN.Location = New System.Drawing.Point(150, 30)
        Me.txtPatientMRN.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPatientMRN.MaxLength = 6
        Me.txtPatientMRN.Name = "txtPatientMRN"
        Me.txtPatientMRN.Size = New System.Drawing.Size(303, 22)
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
        'SampleLab
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
        Me.Name = "SampleLab"
        Me.Text = "Laboratory - Samples"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgridSamples, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxAppointmentInfo.ResumeLayout(False)
        Me.gboxAppointmentInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblReceptionistName As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnReceptionistView As Button
    Friend WithEvents txtReceptionistNo As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dgridSamples As DataGridView
    Friend WithEvents dtTime As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents gboxAppointmentInfo As GroupBox
    Friend WithEvents txtSpecimenType As TextBox
    Friend WithEvents Label6 As Label
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
End Class

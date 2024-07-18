<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientAdmin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgridPatients = New System.Windows.Forms.DataGridView()
        Me.gboxPatientInfo = New System.Windows.Forms.GroupBox()
        Me.dtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbSex = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMedHistory = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgridPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxPatientInfo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgridPatients)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(586, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 561)
        Me.Panel1.TabIndex = 0
        '
        'dgridPatients
        '
        Me.dgridPatients.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridPatients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridPatients.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridPatients.Location = New System.Drawing.Point(10, 10)
        Me.dgridPatients.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridPatients.Name = "dgridPatients"
        Me.dgridPatients.RowHeadersWidth = 51
        Me.dgridPatients.Size = New System.Drawing.Size(580, 541)
        Me.dgridPatients.TabIndex = 0
        '
        'gboxPatientInfo
        '
        Me.gboxPatientInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxPatientInfo.Controls.Add(Me.dtBirthDate)
        Me.gboxPatientInfo.Controls.Add(Me.Label4)
        Me.gboxPatientInfo.Controls.Add(Me.cbSex)
        Me.gboxPatientInfo.Controls.Add(Me.Label2)
        Me.gboxPatientInfo.Controls.Add(Me.Label3)
        Me.gboxPatientInfo.Controls.Add(Me.txtAddress)
        Me.gboxPatientInfo.Controls.Add(Me.Label1)
        Me.gboxPatientInfo.Controls.Add(Me.txtLName)
        Me.gboxPatientInfo.Controls.Add(Me.lblFirstName)
        Me.gboxPatientInfo.Controls.Add(Me.txtFName)
        Me.gboxPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxPatientInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxPatientInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxPatientInfo.Location = New System.Drawing.Point(10, 10)
        Me.gboxPatientInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.gboxPatientInfo.Name = "gboxPatientInfo"
        Me.gboxPatientInfo.Size = New System.Drawing.Size(564, 210)
        Me.gboxPatientInfo.TabIndex = 1
        Me.gboxPatientInfo.TabStop = False
        Me.gboxPatientInfo.Text = "Patient Information"
        '
        'dtBirthDate
        '
        Me.dtBirthDate.CalendarMonthBackground = System.Drawing.Color.Azure
        Me.dtBirthDate.CalendarTitleBackColor = System.Drawing.Color.Azure
        Me.dtBirthDate.Font = New System.Drawing.Font("Gotham", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthDate.Location = New System.Drawing.Point(9, 165)
        Me.dtBirthDate.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(270, 21)
        Me.dtBirthDate.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(6, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date of Birth"
        '
        'cbSex
        '
        Me.cbSex.BackColor = System.Drawing.Color.Azure
        Me.cbSex.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSex.FormattingEnabled = True
        Me.cbSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbSex.Location = New System.Drawing.Point(285, 102)
        Me.cbSex.Name = "cbSex"
        Me.cbSex.Size = New System.Drawing.Size(270, 23)
        Me.cbSex.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(282, 79)
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
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Home Address"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.Azure
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(9, 102)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(270, 22)
        Me.txtAddress.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(282, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Last Name"
        '
        'txtLName
        '
        Me.txtLName.BackColor = System.Drawing.Color.Azure
        Me.txtLName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLName.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(285, 44)
        Me.txtLName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtLName.MaxLength = 50
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(270, 22)
        Me.txtLName.TabIndex = 8
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.ForeColor = System.Drawing.Color.Teal
        Me.lblFirstName.Location = New System.Drawing.Point(6, 21)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(84, 18)
        Me.lblFirstName.TabIndex = 7
        Me.lblFirstName.Text = "First Name"
        '
        'txtFName
        '
        Me.txtFName.BackColor = System.Drawing.Color.Azure
        Me.txtFName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFName.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(9, 44)
        Me.txtFName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtFName.MaxLength = 50
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(270, 22)
        Me.txtFName.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtMedHistory)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(10, 230)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 258)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Medical History"
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
        Me.txtMedHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMedHistory.Size = New System.Drawing.Size(546, 223)
        Me.txtMedHistory.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Teal
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(10, 511)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 38)
        Me.btnAdd.TabIndex = 18
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Teal
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(116, 511)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 38)
        Me.btnEdit.TabIndex = 19
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Teal
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(224, 511)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 38)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(474, 511)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 38)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PatientAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gboxPatientInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "PatientAdmin"
        Me.Text = "Patients"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgridPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxPatientInfo.ResumeLayout(False)
        Me.gboxPatientInfo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgridPatients As DataGridView
    Friend WithEvents gboxPatientInfo As GroupBox
    Friend WithEvents dtBirthDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cbSex As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMedHistory As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnExit As Button
End Class

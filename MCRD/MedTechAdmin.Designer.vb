<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedTechAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedTechAdmin))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gboxPatientInfo = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLicenseNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgridMedTechs = New System.Windows.Forms.DataGridView()
        Me.gboxPatientInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgridMedTechs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DimGray
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(477, 511)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 38)
        Me.btnExit.TabIndex = 34
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Teal
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(227, 511)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 38)
        Me.btnDelete.TabIndex = 33
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.Teal
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.Location = New System.Drawing.Point(119, 511)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(100, 38)
        Me.btnEdit.TabIndex = 32
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
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'gboxPatientInfo
        '
        Me.gboxPatientInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxPatientInfo.Controls.Add(Me.Label3)
        Me.gboxPatientInfo.Controls.Add(Me.txtLicenseNo)
        Me.gboxPatientInfo.Controls.Add(Me.Label1)
        Me.gboxPatientInfo.Controls.Add(Me.txtLName)
        Me.gboxPatientInfo.Controls.Add(Me.lblFirstName)
        Me.gboxPatientInfo.Controls.Add(Me.txtFName)
        Me.gboxPatientInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxPatientInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxPatientInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxPatientInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxPatientInfo.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.gboxPatientInfo.Name = "gboxPatientInfo"
        Me.gboxPatientInfo.Size = New System.Drawing.Size(564, 148)
        Me.gboxPatientInfo.TabIndex = 30
        Me.gboxPatientInfo.TabStop = False
        Me.gboxPatientInfo.Text = "Physician Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "License Number"
        '
        'txtLicenseNo
        '
        Me.txtLicenseNo.BackColor = System.Drawing.Color.Azure
        Me.txtLicenseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLicenseNo.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLicenseNo.Location = New System.Drawing.Point(9, 102)
        Me.txtLicenseNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtLicenseNo.MaxLength = 7
        Me.txtLicenseNo.Name = "txtLicenseNo"
        Me.txtLicenseNo.Size = New System.Drawing.Size(546, 22)
        Me.txtLicenseNo.TabIndex = 10
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
        Me.txtLName.MaxLength = 20
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgridMedTechs)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 561)
        Me.Panel1.TabIndex = 29
        '
        'dgridMedTechs
        '
        Me.dgridMedTechs.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridMedTechs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridMedTechs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridMedTechs.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridMedTechs.Location = New System.Drawing.Point(10, 10)
        Me.dgridMedTechs.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.dgridMedTechs.Name = "dgridMedTechs"
        Me.dgridMedTechs.RowHeadersWidth = 51
        Me.dgridMedTechs.Size = New System.Drawing.Size(580, 541)
        Me.dgridMedTechs.TabIndex = 0
        '
        'MedTechAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gboxPatientInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "MedTechAdmin"
        Me.Text = "Medical Technologists"
        Me.gboxPatientInfo.ResumeLayout(False)
        Me.gboxPatientInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgridMedTechs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents gboxPatientInfo As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLicenseNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgridMedTechs As DataGridView
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecretaryAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecretaryAdmin))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gboxSecretaryInfo = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgridSecretaries = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnView = New System.Windows.Forms.Button()
        Me.lblDocLicenseNo = New System.Windows.Forms.Label()
        Me.lblDocLName = New System.Windows.Forms.Label()
        Me.lblDocFName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPhysicianID = New System.Windows.Forms.TextBox()
        Me.gboxSecretaryInfo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgridSecretaries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnDelete.Location = New System.Drawing.Point(226, 511)
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
        Me.btnEdit.Location = New System.Drawing.Point(118, 511)
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
        'gboxSecretaryInfo
        '
        Me.gboxSecretaryInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxSecretaryInfo.Controls.Add(Me.Label1)
        Me.gboxSecretaryInfo.Controls.Add(Me.txtLName)
        Me.gboxSecretaryInfo.Controls.Add(Me.lblFirstName)
        Me.gboxSecretaryInfo.Controls.Add(Me.txtFName)
        Me.gboxSecretaryInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxSecretaryInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxSecretaryInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxSecretaryInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxSecretaryInfo.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.gboxSecretaryInfo.Name = "gboxSecretaryInfo"
        Me.gboxSecretaryInfo.Size = New System.Drawing.Size(564, 76)
        Me.gboxSecretaryInfo.TabIndex = 30
        Me.gboxSecretaryInfo.TabStop = False
        Me.gboxSecretaryInfo.Text = "Secretary Information"
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
        Me.Panel1.Controls.Add(Me.dgridSecretaries)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 561)
        Me.Panel1.TabIndex = 29
        '
        'dgridSecretaries
        '
        Me.dgridSecretaries.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridSecretaries.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridSecretaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridSecretaries.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridSecretaries.Location = New System.Drawing.Point(10, 10)
        Me.dgridSecretaries.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.dgridSecretaries.Name = "dgridSecretaries"
        Me.dgridSecretaries.RowHeadersWidth = 51
        Me.dgridSecretaries.Size = New System.Drawing.Size(580, 541)
        Me.dgridSecretaries.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnView)
        Me.GroupBox1.Controls.Add(Me.lblDocLicenseNo)
        Me.GroupBox1.Controls.Add(Me.lblDocLName)
        Me.GroupBox1.Controls.Add(Me.lblDocFName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPhysicianID)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 136)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Physician Information"
        '
        'btnView
        '
        Me.btnView.BackColor = System.Drawing.Color.Teal
        Me.btnView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.Location = New System.Drawing.Point(464, 44)
        Me.btnView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnView.Name = "btnView"
        Me.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnView.Size = New System.Drawing.Size(91, 22)
        Me.btnView.TabIndex = 35
        Me.btnView.Text = "VIEW"
        Me.btnView.UseVisualStyleBackColor = False
        '
        'lblDocLicenseNo
        '
        Me.lblDocLicenseNo.AutoSize = True
        Me.lblDocLicenseNo.Font = New System.Drawing.Font("Montserrat SemiBold", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocLicenseNo.ForeColor = System.Drawing.Color.Black
        Me.lblDocLicenseNo.Location = New System.Drawing.Point(436, 106)
        Me.lblDocLicenseNo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblDocLicenseNo.Name = "lblDocLicenseNo"
        Me.lblDocLicenseNo.Size = New System.Drawing.Size(120, 18)
        Me.lblDocLicenseNo.TabIndex = 12
        Me.lblDocLicenseNo.Text = "License Number"
        Me.lblDocLicenseNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDocLName
        '
        Me.lblDocLName.AutoSize = True
        Me.lblDocLName.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocLName.ForeColor = System.Drawing.Color.Black
        Me.lblDocLName.Location = New System.Drawing.Point(60, 106)
        Me.lblDocLName.Name = "lblDocLName"
        Me.lblDocLName.Size = New System.Drawing.Size(84, 20)
        Me.lblDocLName.TabIndex = 11
        Me.lblDocLName.Text = "Last Name"
        '
        'lblDocFName
        '
        Me.lblDocFName.AutoSize = True
        Me.lblDocFName.Font = New System.Drawing.Font("Montserrat", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocFName.ForeColor = System.Drawing.Color.Black
        Me.lblDocFName.Location = New System.Drawing.Point(60, 79)
        Me.lblDocFName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblDocFName.Name = "lblDocFName"
        Me.lblDocFName.Size = New System.Drawing.Size(87, 20)
        Me.lblDocFName.TabIndex = 10
        Me.lblDocFName.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(436, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "License Number" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(7, 79)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(6, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Physician ID"
        '
        'txtPhysicianID
        '
        Me.txtPhysicianID.BackColor = System.Drawing.Color.Azure
        Me.txtPhysicianID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhysicianID.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhysicianID.Location = New System.Drawing.Point(9, 44)
        Me.txtPhysicianID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPhysicianID.MaxLength = 4
        Me.txtPhysicianID.Name = "txtPhysicianID"
        Me.txtPhysicianID.Size = New System.Drawing.Size(444, 22)
        Me.txtPhysicianID.TabIndex = 6
        '
        'SecretaryAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.gboxSecretaryInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "SecretaryAdmin"
        Me.Text = "Secretaries"
        Me.gboxSecretaryInfo.ResumeLayout(False)
        Me.gboxSecretaryInfo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgridSecretaries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents gboxSecretaryInfo As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtLName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgridSecretaries As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPhysicianID As TextBox
    Friend WithEvents lblDocLicenseNo As Label
    Friend WithEvents lblDocLName As Label
    Friend WithEvents lblDocFName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnView As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicineAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MedicineAdmin))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGenericName = New System.Windows.Forms.TextBox()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gboxMedicineInfo = New System.Windows.Forms.GroupBox()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.dgridMedicines = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.gboxMedicineInfo.SuspendLayout()
        CType(Me.dgridMedicines, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.btnExit.TabIndex = 28
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
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
        Me.btnEdit.TabIndex = 26
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
        Me.btnAdd.TabIndex = 25
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Teal
        Me.Label3.Location = New System.Drawing.Point(6, 79)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Manufacturer"
        '
        'txtManufacturer
        '
        Me.txtManufacturer.BackColor = System.Drawing.Color.Azure
        Me.txtManufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtManufacturer.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(9, 102)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtManufacturer.MaxLength = 50
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(546, 22)
        Me.txtManufacturer.TabIndex = 10
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.Azure
        Me.txtDescription.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(9, 22)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.txtDescription.MaxLength = 250
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(546, 297)
        Me.txtDescription.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 332)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(282, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Generic Name"
        '
        'txtGenericName
        '
        Me.txtGenericName.BackColor = System.Drawing.Color.Azure
        Me.txtGenericName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGenericName.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenericName.Location = New System.Drawing.Point(285, 44)
        Me.txtGenericName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtGenericName.MaxLength = 50
        Me.txtGenericName.Name = "txtGenericName"
        Me.txtGenericName.Size = New System.Drawing.Size(270, 22)
        Me.txtGenericName.TabIndex = 8
        '
        'txtBrandName
        '
        Me.txtBrandName.BackColor = System.Drawing.Color.Azure
        Me.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrandName.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrandName.Location = New System.Drawing.Point(9, 44)
        Me.txtBrandName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtBrandName.MaxLength = 50
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(270, 22)
        Me.txtBrandName.TabIndex = 6
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
        Me.btnDelete.TabIndex = 27
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'gboxMedicineInfo
        '
        Me.gboxMedicineInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxMedicineInfo.Controls.Add(Me.Label3)
        Me.gboxMedicineInfo.Controls.Add(Me.txtManufacturer)
        Me.gboxMedicineInfo.Controls.Add(Me.Label1)
        Me.gboxMedicineInfo.Controls.Add(Me.txtGenericName)
        Me.gboxMedicineInfo.Controls.Add(Me.lblBrandName)
        Me.gboxMedicineInfo.Controls.Add(Me.txtBrandName)
        Me.gboxMedicineInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxMedicineInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxMedicineInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxMedicineInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxMedicineInfo.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.gboxMedicineInfo.Name = "gboxMedicineInfo"
        Me.gboxMedicineInfo.Size = New System.Drawing.Size(564, 137)
        Me.gboxMedicineInfo.TabIndex = 23
        Me.gboxMedicineInfo.TabStop = False
        Me.gboxMedicineInfo.Text = "Medicine Information"
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandName.ForeColor = System.Drawing.Color.Teal
        Me.lblBrandName.Location = New System.Drawing.Point(6, 21)
        Me.lblBrandName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(94, 18)
        Me.lblBrandName.TabIndex = 7
        Me.lblBrandName.Text = "Brand Name"
        '
        'dgridMedicines
        '
        Me.dgridMedicines.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridMedicines.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridMedicines.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridMedicines.Location = New System.Drawing.Point(10, 10)
        Me.dgridMedicines.Margin = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.dgridMedicines.Name = "dgridMedicines"
        Me.dgridMedicines.RowHeadersWidth = 51
        Me.dgridMedicines.Size = New System.Drawing.Size(580, 541)
        Me.dgridMedicines.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgridMedicines)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 561)
        Me.Panel1.TabIndex = 22
        '
        'MedicineAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.gboxMedicineInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "MedicineAdmin"
        Me.Text = "Medicines"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gboxMedicineInfo.ResumeLayout(False)
        Me.gboxMedicineInfo.PerformLayout()
        CType(Me.dgridMedicines, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtManufacturer As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtGenericName As TextBox
    Friend WithEvents txtBrandName As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents gboxMedicineInfo As GroupBox
    Friend WithEvents lblBrandName As Label
    Friend WithEvents dgridMedicines As DataGridView
    Friend WithEvents Panel1 As Panel
End Class

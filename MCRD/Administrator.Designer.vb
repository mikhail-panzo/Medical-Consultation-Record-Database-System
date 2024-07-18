<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Administrator))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLabTest = New System.Windows.Forms.Button()
        Me.btnAppointment = New System.Windows.Forms.Button()
        Me.btnMedicine = New System.Windows.Forms.Button()
        Me.btnMedTech = New System.Windows.Forms.Button()
        Me.btnLabReceptionist = New System.Windows.Forms.Button()
        Me.btnCashier = New System.Windows.Forms.Button()
        Me.btnPatient = New System.Windows.Forms.Button()
        Me.btnSecretary = New System.Windows.Forms.Button()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.picLogOut = New System.Windows.Forms.PictureBox()
        Me.btnDoctor = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxAppointments = New System.Windows.Forms.GroupBox()
        Me.dgridAppointments = New System.Windows.Forms.DataGridView()
        Me.gboxLabTests = New System.Windows.Forms.GroupBox()
        Me.dgridLabTests = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxAppointments.SuspendLayout()
        CType(Me.dgridAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxLabTests.SuspendLayout()
        CType(Me.dgridLabTests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.btnLabTest)
        Me.Panel1.Controls.Add(Me.btnAppointment)
        Me.Panel1.Controls.Add(Me.btnMedicine)
        Me.Panel1.Controls.Add(Me.btnMedTech)
        Me.Panel1.Controls.Add(Me.btnLabReceptionist)
        Me.Panel1.Controls.Add(Me.btnCashier)
        Me.Panel1.Controls.Add(Me.btnPatient)
        Me.Panel1.Controls.Add(Me.btnSecretary)
        Me.Panel1.Controls.Add(Me.lblLogOut)
        Me.Panel1.Controls.Add(Me.picLogOut)
        Me.Panel1.Controls.Add(Me.btnDoctor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 783)
        Me.Panel1.TabIndex = 0
        '
        'btnLabTest
        '
        Me.btnLabTest.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnLabTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLabTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLabTest.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabTest.Location = New System.Drawing.Point(12, 529)
        Me.btnLabTest.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnLabTest.Name = "btnLabTest"
        Me.btnLabTest.Size = New System.Drawing.Size(178, 40)
        Me.btnLabTest.TabIndex = 13
        Me.btnLabTest.Text = "Lab Tests"
        Me.btnLabTest.UseVisualStyleBackColor = False
        '
        'btnAppointment
        '
        Me.btnAppointment.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAppointment.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAppointment.Location = New System.Drawing.Point(12, 479)
        Me.btnAppointment.Margin = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.btnAppointment.Name = "btnAppointment"
        Me.btnAppointment.Size = New System.Drawing.Size(178, 40)
        Me.btnAppointment.TabIndex = 12
        Me.btnAppointment.Text = "Appointments"
        Me.btnAppointment.UseVisualStyleBackColor = False
        '
        'btnMedicine
        '
        Me.btnMedicine.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnMedicine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMedicine.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicine.Location = New System.Drawing.Point(12, 409)
        Me.btnMedicine.Margin = New System.Windows.Forms.Padding(10, 20, 10, 10)
        Me.btnMedicine.Name = "btnMedicine"
        Me.btnMedicine.Size = New System.Drawing.Size(178, 40)
        Me.btnMedicine.TabIndex = 11
        Me.btnMedicine.Text = "Medicines"
        Me.btnMedicine.UseVisualStyleBackColor = False
        '
        'btnMedTech
        '
        Me.btnMedTech.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnMedTech.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMedTech.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMedTech.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedTech.Location = New System.Drawing.Point(12, 339)
        Me.btnMedTech.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnMedTech.Name = "btnMedTech"
        Me.btnMedTech.Size = New System.Drawing.Size(178, 40)
        Me.btnMedTech.TabIndex = 10
        Me.btnMedTech.Text = "Medical Technologists"
        Me.btnMedTech.UseVisualStyleBackColor = False
        '
        'btnLabReceptionist
        '
        Me.btnLabReceptionist.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnLabReceptionist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLabReceptionist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLabReceptionist.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabReceptionist.Location = New System.Drawing.Point(12, 289)
        Me.btnLabReceptionist.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnLabReceptionist.Name = "btnLabReceptionist"
        Me.btnLabReceptionist.Size = New System.Drawing.Size(178, 40)
        Me.btnLabReceptionist.TabIndex = 9
        Me.btnLabReceptionist.Text = "Lab Receptionists"
        Me.btnLabReceptionist.UseVisualStyleBackColor = False
        '
        'btnCashier
        '
        Me.btnCashier.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnCashier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCashier.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashier.Location = New System.Drawing.Point(12, 239)
        Me.btnCashier.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnCashier.Name = "btnCashier"
        Me.btnCashier.Size = New System.Drawing.Size(178, 40)
        Me.btnCashier.TabIndex = 8
        Me.btnCashier.Text = "Cashiers"
        Me.btnCashier.UseVisualStyleBackColor = False
        '
        'btnPatient
        '
        Me.btnPatient.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPatient.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatient.Location = New System.Drawing.Point(12, 89)
        Me.btnPatient.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnPatient.Name = "btnPatient"
        Me.btnPatient.Size = New System.Drawing.Size(178, 40)
        Me.btnPatient.TabIndex = 7
        Me.btnPatient.Text = "Patients"
        Me.btnPatient.UseVisualStyleBackColor = False
        '
        'btnSecretary
        '
        Me.btnSecretary.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSecretary.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSecretary.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSecretary.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSecretary.Location = New System.Drawing.Point(12, 189)
        Me.btnSecretary.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnSecretary.Name = "btnSecretary"
        Me.btnSecretary.Size = New System.Drawing.Size(178, 40)
        Me.btnSecretary.TabIndex = 6
        Me.btnSecretary.Text = "Secretaries"
        Me.btnSecretary.UseVisualStyleBackColor = False
        '
        'lblLogOut
        '
        Me.lblLogOut.AutoSize = True
        Me.lblLogOut.BackColor = System.Drawing.Color.Transparent
        Me.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblLogOut.Font = New System.Drawing.Font("Montserrat Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogOut.ForeColor = System.Drawing.Color.White
        Me.lblLogOut.Location = New System.Drawing.Point(48, 24)
        Me.lblLogOut.Name = "lblLogOut"
        Me.lblLogOut.Size = New System.Drawing.Size(86, 26)
        Me.lblLogOut.TabIndex = 5
        Me.lblLogOut.Text = "Logout"
        Me.lblLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogOut
        '
        Me.picLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picLogOut.Image = CType(resources.GetObject("picLogOut.Image"), System.Drawing.Image)
        Me.picLogOut.Location = New System.Drawing.Point(12, 12)
        Me.picLogOut.Name = "picLogOut"
        Me.picLogOut.Size = New System.Drawing.Size(30, 50)
        Me.picLogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogOut.TabIndex = 1
        Me.picLogOut.TabStop = False
        '
        'btnDoctor
        '
        Me.btnDoctor.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnDoctor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDoctor.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDoctor.Location = New System.Drawing.Point(12, 139)
        Me.btnDoctor.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnDoctor.Name = "btnDoctor"
        Me.btnDoctor.Size = New System.Drawing.Size(178, 40)
        Me.btnDoctor.TabIndex = 0
        Me.btnDoctor.Text = "Doctors"
        Me.btnDoctor.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(223, 12)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(279, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "MEDICAL CONSULTATION RECORD SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gboxAppointments
        '
        Me.gboxAppointments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gboxAppointments.Controls.Add(Me.dgridAppointments)
        Me.gboxAppointments.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxAppointments.ForeColor = System.Drawing.Color.Teal
        Me.gboxAppointments.Location = New System.Drawing.Point(223, 89)
        Me.gboxAppointments.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.gboxAppointments.Name = "gboxAppointments"
        Me.gboxAppointments.Size = New System.Drawing.Size(1186, 306)
        Me.gboxAppointments.TabIndex = 3
        Me.gboxAppointments.TabStop = False
        Me.gboxAppointments.Text = "Appointments"
        '
        'dgridAppointments
        '
        Me.dgridAppointments.AllowUserToAddRows = False
        Me.dgridAppointments.AllowUserToDeleteRows = False
        Me.dgridAppointments.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgridAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgridAppointments.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgridAppointments.Location = New System.Drawing.Point(6, 26)
        Me.dgridAppointments.Name = "dgridAppointments"
        Me.dgridAppointments.ReadOnly = True
        Me.dgridAppointments.Size = New System.Drawing.Size(1172, 274)
        Me.dgridAppointments.TabIndex = 1
        '
        'gboxLabTests
        '
        Me.gboxLabTests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gboxLabTests.Controls.Add(Me.dgridLabTests)
        Me.gboxLabTests.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxLabTests.ForeColor = System.Drawing.Color.Teal
        Me.gboxLabTests.Location = New System.Drawing.Point(223, 409)
        Me.gboxLabTests.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.gboxLabTests.Name = "gboxLabTests"
        Me.gboxLabTests.Size = New System.Drawing.Size(1186, 362)
        Me.gboxLabTests.TabIndex = 4
        Me.gboxLabTests.TabStop = False
        Me.gboxLabTests.Text = "Lab Tests"
        '
        'dgridLabTests
        '
        Me.dgridLabTests.AllowUserToAddRows = False
        Me.dgridLabTests.AllowUserToDeleteRows = False
        Me.dgridLabTests.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgridLabTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgridLabTests.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgridLabTests.Location = New System.Drawing.Point(6, 26)
        Me.dgridLabTests.Name = "dgridLabTests"
        Me.dgridLabTests.ReadOnly = True
        Me.dgridLabTests.Size = New System.Drawing.Size(1172, 328)
        Me.dgridLabTests.TabIndex = 2
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Teal
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(1231, 12)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(178, 50)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "REFRESH"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Updates entries in appointments and lab tests")
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Administrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1421, 783)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.gboxLabTests)
        Me.Controls.Add(Me.gboxAppointments)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1437, 822)
        Me.Name = "Administrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxAppointments.ResumeLayout(False)
        CType(Me.dgridAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxLabTests.ResumeLayout(False)
        CType(Me.dgridLabTests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gboxAppointments As GroupBox
    Friend WithEvents gboxLabTests As GroupBox
    Friend WithEvents btnDoctor As Button
    Friend WithEvents lblLogOut As Label
    Friend WithEvents picLogOut As PictureBox
    Friend WithEvents btnSecretary As Button
    Friend WithEvents btnLabTest As Button
    Friend WithEvents btnAppointment As Button
    Friend WithEvents btnMedicine As Button
    Friend WithEvents btnMedTech As Button
    Friend WithEvents btnLabReceptionist As Button
    Friend WithEvents btnCashier As Button
    Friend WithEvents btnPatient As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgridAppointments As DataGridView
    Friend WithEvents dgridLabTests As DataGridView
End Class

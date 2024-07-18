<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BusinessOffice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BusinessOffice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.APPOINTMENTDOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLabTestPayment = New System.Windows.Forms.Button()
        Me.btnConsultationPayment = New System.Windows.Forms.Button()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.picLogOut = New System.Windows.Forms.PictureBox()
        Me.dgridConsultations = New System.Windows.Forms.DataGridView()
        Me.gboxAppointments = New System.Windows.Forms.GroupBox()
        Me.dgridLabTests = New System.Windows.Forms.DataGridView()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gboxLabTests = New System.Windows.Forms.GroupBox()
        CType(Me.APPOINTMENTDOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgridConsultations, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxAppointments.SuspendLayout()
        CType(Me.dgridLabTests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gboxLabTests.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(925, 738)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(450, 26)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "MEDICAL CONSULTATION RECORD SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1378, 738)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(20, 3, 3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.btnLabTestPayment)
        Me.Panel1.Controls.Add(Me.btnConsultationPayment)
        Me.Panel1.Controls.Add(Me.lblLogOut)
        Me.Panel1.Controls.Add(Me.picLogOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 783)
        Me.Panel1.TabIndex = 24
        '
        'btnLabTestPayment
        '
        Me.btnLabTestPayment.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnLabTestPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLabTestPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLabTestPayment.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLabTestPayment.Location = New System.Drawing.Point(12, 172)
        Me.btnLabTestPayment.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnLabTestPayment.Name = "btnLabTestPayment"
        Me.btnLabTestPayment.Size = New System.Drawing.Size(178, 73)
        Me.btnLabTestPayment.TabIndex = 8
        Me.btnLabTestPayment.Text = "Process Lab Test Payment"
        Me.btnLabTestPayment.UseVisualStyleBackColor = False
        '
        'btnConsultationPayment
        '
        Me.btnConsultationPayment.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnConsultationPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsultationPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnConsultationPayment.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultationPayment.Location = New System.Drawing.Point(12, 89)
        Me.btnConsultationPayment.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnConsultationPayment.Name = "btnConsultationPayment"
        Me.btnConsultationPayment.Size = New System.Drawing.Size(178, 73)
        Me.btnConsultationPayment.TabIndex = 7
        Me.btnConsultationPayment.Text = "Process Consultation Payment"
        Me.btnConsultationPayment.UseVisualStyleBackColor = False
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
        'dgridConsultations
        '
        Me.dgridConsultations.AllowUserToAddRows = False
        Me.dgridConsultations.AllowUserToDeleteRows = False
        Me.dgridConsultations.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgridConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgridConsultations.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgridConsultations.Location = New System.Drawing.Point(7, 26)
        Me.dgridConsultations.Name = "dgridConsultations"
        Me.dgridConsultations.ReadOnly = True
        Me.dgridConsultations.Size = New System.Drawing.Size(1167, 274)
        Me.dgridConsultations.TabIndex = 0
        '
        'gboxAppointments
        '
        Me.gboxAppointments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gboxAppointments.Controls.Add(Me.dgridConsultations)
        Me.gboxAppointments.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxAppointments.ForeColor = System.Drawing.Color.Teal
        Me.gboxAppointments.Location = New System.Drawing.Point(228, 53)
        Me.gboxAppointments.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.gboxAppointments.Name = "gboxAppointments"
        Me.gboxAppointments.Size = New System.Drawing.Size(1180, 306)
        Me.gboxAppointments.TabIndex = 27
        Me.gboxAppointments.TabStop = False
        Me.gboxAppointments.Text = "Consultations"
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
        Me.dgridLabTests.Location = New System.Drawing.Point(7, 26)
        Me.dgridLabTests.Name = "dgridLabTests"
        Me.dgridLabTests.ReadOnly = True
        Me.dgridLabTests.Size = New System.Drawing.Size(1167, 328)
        Me.dgridLabTests.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Azure
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(148, 8)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtID.MaxLength = 4
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(161, 23)
        Me.txtID.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnLoad)
        Me.Panel2.Controls.Add(Me.txtID)
        Me.Panel2.Location = New System.Drawing.Point(228, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(429, 38)
        Me.Panel2.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.Panel2, "Enter the Secretary ID to view all relevant data associated to the assigned docto" &
        "r")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 28)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Cashier No."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Teal
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Font = New System.Drawing.Font("Montserrat SemiBold", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(322, 8)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(97, 23)
        Me.btnLoad.TabIndex = 22
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Teal
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Location = New System.Drawing.Point(1237, 12)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(178, 39)
        Me.btnUpdate.TabIndex = 29
        Me.btnUpdate.Text = "REFRESH"
        Me.ToolTip1.SetToolTip(Me.btnUpdate, "Updates entries in appointments and lab tests")
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'gboxLabTests
        '
        Me.gboxLabTests.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gboxLabTests.Controls.Add(Me.dgridLabTests)
        Me.gboxLabTests.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxLabTests.ForeColor = System.Drawing.Color.Teal
        Me.gboxLabTests.Location = New System.Drawing.Point(228, 372)
        Me.gboxLabTests.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.gboxLabTests.Name = "gboxLabTests"
        Me.gboxLabTests.Size = New System.Drawing.Size(1180, 360)
        Me.gboxLabTests.TabIndex = 28
        Me.gboxLabTests.TabStop = False
        Me.gboxLabTests.Text = "Lab Tests"
        '
        'BusinessOffice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 783)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gboxAppointments)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.gboxLabTests)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1437, 822)
        Me.Name = "BusinessOffice"
        Me.Text = "Business Office"
        CType(Me.APPOINTMENTDOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgridConsultations, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxAppointments.ResumeLayout(False)
        CType(Me.dgridLabTests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.gboxLabTests.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents APPOINTMENTDOCTORBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConsultationPayment As Button
    Friend WithEvents lblLogOut As Label
    Friend WithEvents picLogOut As PictureBox
    Friend WithEvents dgridConsultations As DataGridView
    Friend WithEvents gboxAppointments As GroupBox
    Friend WithEvents dgridLabTests As DataGridView
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents txtID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents gboxLabTests As GroupBox
    Friend WithEvents btnLabTestPayment As Button
    Friend WithEvents btnLoad As Button
End Class

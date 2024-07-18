<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Laboratory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laboratory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.APPOINTMENTDOCTORBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProcSample = New System.Windows.Forms.Button()
        Me.btnSample = New System.Windows.Forms.Button()
        Me.lblLogOut = New System.Windows.Forms.Label()
        Me.picLogOut = New System.Windows.Forms.PictureBox()
        Me.dgridSamples = New System.Windows.Forms.DataGridView()
        Me.gboxAppointments = New System.Windows.Forms.GroupBox()
        Me.dgridLabTests = New System.Windows.Forms.DataGridView()
        Me.cboxUnfulfilled = New System.Windows.Forms.CheckBox()
        Me.cbIDSelection = New System.Windows.Forms.ComboBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.txtSecID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gboxLabTests = New System.Windows.Forms.GroupBox()
        CType(Me.APPOINTMENTDOCTORBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgridSamples, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.btnProcSample)
        Me.Panel1.Controls.Add(Me.btnSample)
        Me.Panel1.Controls.Add(Me.lblLogOut)
        Me.Panel1.Controls.Add(Me.picLogOut)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 783)
        Me.Panel1.TabIndex = 24
        '
        'btnProcSample
        '
        Me.btnProcSample.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnProcSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProcSample.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProcSample.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcSample.Location = New System.Drawing.Point(12, 139)
        Me.btnProcSample.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnProcSample.Name = "btnProcSample"
        Me.btnProcSample.Size = New System.Drawing.Size(178, 40)
        Me.btnProcSample.TabIndex = 8
        Me.btnProcSample.Text = "Process Sample"
        Me.btnProcSample.UseVisualStyleBackColor = False
        '
        'btnSample
        '
        Me.btnSample.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btnSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSample.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSample.Font = New System.Drawing.Font("Montserrat SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSample.Location = New System.Drawing.Point(12, 89)
        Me.btnSample.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnSample.Name = "btnSample"
        Me.btnSample.Size = New System.Drawing.Size(178, 40)
        Me.btnSample.TabIndex = 7
        Me.btnSample.Text = "Collect Sample"
        Me.btnSample.UseVisualStyleBackColor = False
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
        'dgridSamples
        '
        Me.dgridSamples.AllowUserToAddRows = False
        Me.dgridSamples.AllowUserToDeleteRows = False
        Me.dgridSamples.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgridSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgridSamples.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgridSamples.Location = New System.Drawing.Point(7, 26)
        Me.dgridSamples.Name = "dgridSamples"
        Me.dgridSamples.ReadOnly = True
        Me.dgridSamples.Size = New System.Drawing.Size(1172, 274)
        Me.dgridSamples.TabIndex = 0
        '
        'gboxAppointments
        '
        Me.gboxAppointments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.gboxAppointments.Controls.Add(Me.dgridSamples)
        Me.gboxAppointments.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxAppointments.ForeColor = System.Drawing.Color.Teal
        Me.gboxAppointments.Location = New System.Drawing.Point(228, 53)
        Me.gboxAppointments.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.gboxAppointments.Name = "gboxAppointments"
        Me.gboxAppointments.Size = New System.Drawing.Size(1186, 306)
        Me.gboxAppointments.TabIndex = 27
        Me.gboxAppointments.TabStop = False
        Me.gboxAppointments.Text = "Samples"
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
        Me.dgridLabTests.Size = New System.Drawing.Size(1172, 328)
        Me.dgridLabTests.TabIndex = 1
        '
        'cboxUnfulfilled
        '
        Me.cboxUnfulfilled.AutoSize = True
        Me.cboxUnfulfilled.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxUnfulfilled.Location = New System.Drawing.Point(228, 738)
        Me.cboxUnfulfilled.Name = "cboxUnfulfilled"
        Me.cboxUnfulfilled.Size = New System.Drawing.Size(117, 26)
        Me.cboxUnfulfilled.TabIndex = 31
        Me.cboxUnfulfilled.Text = "Unfulfilled"
        Me.ToolTip1.SetToolTip(Me.cboxUnfulfilled, "Show only the appointments and lab tests that are not fulfilled")
        Me.cboxUnfulfilled.UseVisualStyleBackColor = True
        '
        'cbIDSelection
        '
        Me.cbIDSelection.BackColor = System.Drawing.Color.Azure
        Me.cbIDSelection.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbIDSelection.FormattingEnabled = True
        Me.cbIDSelection.Items.AddRange(New Object() {"Receptionist ID", "Med Tech ID"})
        Me.cbIDSelection.Location = New System.Drawing.Point(7, 8)
        Me.cbIDSelection.Name = "cbIDSelection"
        Me.cbIDSelection.Size = New System.Drawing.Size(122, 23)
        Me.cbIDSelection.TabIndex = 24
        Me.cbIDSelection.Text = "Receptionist ID"
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.Teal
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoad.Font = New System.Drawing.Font("Montserrat SemiBold", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.White
        Me.btnLoad.Location = New System.Drawing.Point(296, 8)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(112, 23)
        Me.btnLoad.TabIndex = 22
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'txtSecID
        '
        Me.txtSecID.BackColor = System.Drawing.Color.Azure
        Me.txtSecID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSecID.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecID.Location = New System.Drawing.Point(135, 8)
        Me.txtSecID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtSecID.MaxLength = 4
        Me.txtSecID.Name = "txtSecID"
        Me.txtSecID.Size = New System.Drawing.Size(148, 23)
        Me.txtSecID.TabIndex = 23
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightGray
        Me.Panel2.Controls.Add(Me.cbIDSelection)
        Me.Panel2.Controls.Add(Me.btnLoad)
        Me.Panel2.Controls.Add(Me.txtSecID)
        Me.Panel2.Location = New System.Drawing.Point(228, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(418, 38)
        Me.Panel2.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.Panel2, "Enter the Secretary ID to view all relevant data associated to the assigned docto" &
        "r")
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
        Me.gboxLabTests.Size = New System.Drawing.Size(1186, 360)
        Me.gboxLabTests.TabIndex = 28
        Me.gboxLabTests.TabStop = False
        Me.gboxLabTests.Text = "Lab Tests"
        '
        'Laboratory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1421, 783)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gboxAppointments)
        Me.Controls.Add(Me.cboxUnfulfilled)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.gboxLabTests)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1437, 822)
        Me.Name = "Laboratory"
        Me.Text = "Laboratory"
        CType(Me.APPOINTMENTDOCTORBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgridSamples, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSample As Button
    Friend WithEvents lblLogOut As Label
    Friend WithEvents picLogOut As PictureBox
    Friend WithEvents dgridSamples As DataGridView
    Friend WithEvents gboxAppointments As GroupBox
    Friend WithEvents dgridLabTests As DataGridView
    Friend WithEvents cboxUnfulfilled As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cbIDSelection As ComboBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents txtSecID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnUpdate As Button
    Friend WithEvents gboxLabTests As GroupBox
    Friend WithEvents btnProcSample As Button
End Class

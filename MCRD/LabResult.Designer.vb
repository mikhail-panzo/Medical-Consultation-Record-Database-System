<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabResult
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LabResult))
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgridLabResults = New System.Windows.Forms.DataGridView()
        Me.gboxResultInfo = New System.Windows.Forms.GroupBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblProcSampleNo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtField = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgridLabResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxResultInfo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnEdit.TabIndex = 55
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
        Me.btnDelete.Location = New System.Drawing.Point(226, 511)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(100, 38)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgridLabResults)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 561)
        Me.Panel1.TabIndex = 51
        '
        'dgridLabResults
        '
        Me.dgridLabResults.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridLabResults.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridLabResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridLabResults.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridLabResults.Location = New System.Drawing.Point(10, 10)
        Me.dgridLabResults.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridLabResults.Name = "dgridLabResults"
        Me.dgridLabResults.RowHeadersWidth = 51
        Me.dgridLabResults.Size = New System.Drawing.Size(580, 541)
        Me.dgridLabResults.TabIndex = 0
        '
        'gboxResultInfo
        '
        Me.gboxResultInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxResultInfo.Controls.Add(Me.txtResult)
        Me.gboxResultInfo.Controls.Add(Me.Label2)
        Me.gboxResultInfo.Controls.Add(Me.Panel2)
        Me.gboxResultInfo.Controls.Add(Me.txtField)
        Me.gboxResultInfo.Controls.Add(Me.Label6)
        Me.gboxResultInfo.Controls.Add(Me.dtDate)
        Me.gboxResultInfo.Controls.Add(Me.Label4)
        Me.gboxResultInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxResultInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxResultInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxResultInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxResultInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.gboxResultInfo.Name = "gboxResultInfo"
        Me.gboxResultInfo.Size = New System.Drawing.Size(564, 353)
        Me.gboxResultInfo.TabIndex = 52
        Me.gboxResultInfo.TabStop = False
        Me.gboxResultInfo.Text = "Lab Result"
        '
        'txtResult
        '
        Me.txtResult.BackColor = System.Drawing.Color.Azure
        Me.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResult.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(6, 164)
        Me.txtResult.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtResult.MaxLength = 100
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(552, 111)
        Me.txtResult.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(7, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 18)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Result"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(6, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(552, 50)
        Me.Panel2.TabIndex = 41
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.Panel3.Controls.Add(Me.lblProcSampleNo)
        Me.Panel3.Location = New System.Drawing.Point(378, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(164, 30)
        Me.Panel3.TabIndex = 42
        '
        'lblProcSampleNo
        '
        Me.lblProcSampleNo.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcSampleNo.ForeColor = System.Drawing.Color.Teal
        Me.lblProcSampleNo.Location = New System.Drawing.Point(19, 2)
        Me.lblProcSampleNo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblProcSampleNo.Name = "lblProcSampleNo"
        Me.lblProcSampleNo.Size = New System.Drawing.Size(133, 24)
        Me.lblProcSampleNo.TabIndex = 43
        Me.lblProcSampleNo.Text = "0000"
        Me.lblProcSampleNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 22)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Processed Sample No."
        '
        'txtField
        '
        Me.txtField.BackColor = System.Drawing.Color.Azure
        Me.txtField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtField.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtField.Location = New System.Drawing.Point(6, 106)
        Me.txtField.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtField.MaxLength = 100
        Me.txtField.Name = "txtField"
        Me.txtField.Size = New System.Drawing.Size(552, 22)
        Me.txtField.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Teal
        Me.Label6.Location = New System.Drawing.Point(7, 83)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Field"
        '
        'dtDate
        '
        Me.dtDate.CalendarFont = New System.Drawing.Font("Montserrat", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.CalendarMonthBackground = System.Drawing.Color.Azure
        Me.dtDate.CalendarTitleBackColor = System.Drawing.Color.Azure
        Me.dtDate.Font = New System.Drawing.Font("Arial Narrow", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(6, 316)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(273, 24)
        Me.dtDate.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(7, 288)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Date"
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
        Me.btnAdd.TabIndex = 54
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
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
        Me.btnExit.TabIndex = 57
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'LabResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gboxResultInfo)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "LabResult"
        Me.Text = "Laboratory - Results"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgridLabResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxResultInfo.ResumeLayout(False)
        Me.gboxResultInfo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgridLabResults As DataGridView
    Friend WithEvents gboxResultInfo As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtField As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblProcSampleNo As Label
    Friend WithEvents txtResult As TextBox
    Friend WithEvents Label2 As Label
End Class

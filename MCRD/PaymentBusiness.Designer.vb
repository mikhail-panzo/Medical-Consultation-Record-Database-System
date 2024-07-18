<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentBusiness
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentBusiness))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAmountPaid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gboxAppointmentInfo = New System.Windows.Forms.GroupBox()
        Me.txtLabTestNo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgridPayments = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCashierName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCashierView = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCashierID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPatientView = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPatientMRN = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gboxAppointmentInfo.SuspendLayout()
        CType(Me.dgridPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.btnExit.TabIndex = 65
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtAmountPaid
        '
        Me.txtAmountPaid.BackColor = System.Drawing.Color.Azure
        Me.txtAmountPaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountPaid.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountPaid.Location = New System.Drawing.Point(208, 57)
        Me.txtAmountPaid.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtAmountPaid.MaxLength = 11
        Me.txtAmountPaid.Name = "txtAmountPaid"
        Me.txtAmountPaid.Size = New System.Drawing.Size(347, 22)
        Me.txtAmountPaid.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(8, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Amount Paid (Php)"
        '
        'gboxAppointmentInfo
        '
        Me.gboxAppointmentInfo.BackColor = System.Drawing.Color.Transparent
        Me.gboxAppointmentInfo.Controls.Add(Me.txtAmountPaid)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label1)
        Me.gboxAppointmentInfo.Controls.Add(Me.txtLabTestNo)
        Me.gboxAppointmentInfo.Controls.Add(Me.Label12)
        Me.gboxAppointmentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gboxAppointmentInfo.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboxAppointmentInfo.ForeColor = System.Drawing.Color.Teal
        Me.gboxAppointmentInfo.Location = New System.Drawing.Point(12, 10)
        Me.gboxAppointmentInfo.Margin = New System.Windows.Forms.Padding(10)
        Me.gboxAppointmentInfo.Name = "gboxAppointmentInfo"
        Me.gboxAppointmentInfo.Size = New System.Drawing.Size(564, 92)
        Me.gboxAppointmentInfo.TabIndex = 59
        Me.gboxAppointmentInfo.TabStop = False
        Me.gboxAppointmentInfo.Text = "Payment Information"
        '
        'txtLabTestNo
        '
        Me.txtLabTestNo.BackColor = System.Drawing.Color.Azure
        Me.txtLabTestNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabTestNo.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabTestNo.Location = New System.Drawing.Point(208, 27)
        Me.txtLabTestNo.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtLabTestNo.MaxLength = 6
        Me.txtLabTestNo.Name = "txtLabTestNo"
        Me.txtLabTestNo.Size = New System.Drawing.Size(347, 22)
        Me.txtLabTestNo.TabIndex = 47
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(8, 28)
        Me.Label12.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 18)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Lab Test Number"
        '
        'dgridPayments
        '
        Me.dgridPayments.BackgroundColor = System.Drawing.Color.DarkCyan
        Me.dgridPayments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridPayments.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dgridPayments.Location = New System.Drawing.Point(10, 10)
        Me.dgridPayments.Margin = New System.Windows.Forms.Padding(10)
        Me.dgridPayments.Name = "dgridPayments"
        Me.dgridPayments.RowHeadersWidth = 51
        Me.dgridPayments.Size = New System.Drawing.Size(580, 541)
        Me.dgridPayments.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblCashierName)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnCashierView)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCashierID)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(564, 93)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cashier"
        '
        'lblCashierName
        '
        Me.lblCashierName.AutoSize = True
        Me.lblCashierName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblCashierName.ForeColor = System.Drawing.Color.Black
        Me.lblCashierName.Location = New System.Drawing.Point(134, 59)
        Me.lblCashierName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblCashierName.Name = "lblCashierName"
        Me.lblCashierName.Size = New System.Drawing.Size(81, 20)
        Me.lblCashierName.TabIndex = 29
        Me.lblCashierName.Text = "Full Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 18)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Cashier Name:"
        '
        'btnCashierView
        '
        Me.btnCashierView.BackColor = System.Drawing.Color.Teal
        Me.btnCashierView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCashierView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCashierView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashierView.ForeColor = System.Drawing.Color.White
        Me.btnCashierView.Location = New System.Drawing.Point(464, 29)
        Me.btnCashierView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnCashierView.Name = "btnCashierView"
        Me.btnCashierView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCashierView.Size = New System.Drawing.Size(91, 22)
        Me.btnCashierView.TabIndex = 38
        Me.btnCashierView.Text = "VIEW"
        Me.btnCashierView.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(6, 30)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Cashier No."
        '
        'txtCashierID
        '
        Me.txtCashierID.BackColor = System.Drawing.Color.Azure
        Me.txtCashierID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashierID.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashierID.Location = New System.Drawing.Point(106, 28)
        Me.txtCashierID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtCashierID.MaxLength = 6
        Me.txtCashierID.Name = "txtCashierID"
        Me.txtCashierID.Size = New System.Drawing.Size(347, 22)
        Me.txtCashierID.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.dgridPayments)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(584, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 561)
        Me.Panel1.TabIndex = 58
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
        Me.btnAdd.TabIndex = 61
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
        Me.btnDelete.TabIndex = 64
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
        Me.btnEdit.TabIndex = 63
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Montserrat", 10.0!)
        Me.lblPatientName.ForeColor = System.Drawing.Color.Black
        Me.lblPatientName.Location = New System.Drawing.Point(134, 59)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(81, 20)
        Me.lblPatientName.TabIndex = 29
        Me.lblPatientName.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Patient Name:"
        '
        'btnPatientView
        '
        Me.btnPatientView.BackColor = System.Drawing.Color.Teal
        Me.btnPatientView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatientView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatientView.Font = New System.Drawing.Font("Montserrat", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPatientView.ForeColor = System.Drawing.Color.White
        Me.btnPatientView.Location = New System.Drawing.Point(464, 29)
        Me.btnPatientView.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.btnPatientView.Name = "btnPatientView"
        Me.btnPatientView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnPatientView.Size = New System.Drawing.Size(91, 22)
        Me.btnPatientView.TabIndex = 38
        Me.btnPatientView.Text = "VIEW"
        Me.btnPatientView.UseVisualStyleBackColor = False
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
        'txtPatientMRN
        '
        Me.txtPatientMRN.BackColor = System.Drawing.Color.Azure
        Me.txtPatientMRN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPatientMRN.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientMRN.Location = New System.Drawing.Point(106, 28)
        Me.txtPatientMRN.Margin = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.txtPatientMRN.MaxLength = 6
        Me.txtPatientMRN.Name = "txtPatientMRN"
        Me.txtPatientMRN.Size = New System.Drawing.Size(347, 22)
        Me.txtPatientMRN.TabIndex = 36
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 112)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(564, 93)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient"
        '
        'PaymentBusiness
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gboxAppointmentInfo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "PaymentBusiness"
        Me.Text = "Business Office - Lab Test Payments"
        Me.gboxAppointmentInfo.ResumeLayout(False)
        Me.gboxAppointmentInfo.PerformLayout()
        CType(Me.dgridPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents txtAmountPaid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gboxAppointmentInfo As GroupBox
    Friend WithEvents txtLabTestNo As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgridPayments As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblCashierName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCashierView As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCashierID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents lblPatientName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPatientView As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatientMRN As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

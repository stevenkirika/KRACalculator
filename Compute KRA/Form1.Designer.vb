<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblLname = New System.Windows.Forms.Label
        Me.lblfname = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnReset = New System.Windows.Forms.Button
        Me.Txtnetpay = New System.Windows.Forms.TextBox
        Me.btncompute = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txttotal = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Txtpaye = New System.Windows.Forms.TextBox
        Me.Txtnssf = New System.Windows.Forms.TextBox
        Me.txtnhiff = New System.Windows.Forms.TextBox
        Me.txtdeductions = New System.Windows.Forms.TextBox
        Me.txtadvances = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtbonus = New System.Windows.Forms.TextBox
        Me.txtallowances = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtgpay = New System.Windows.Forms.TextBox
        Me.txtcommission = New System.Windows.Forms.TextBox
        Me.txtsalary = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Silver
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Location = New System.Drawing.Point(-2, -5)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(530, 486)
        Me.Panel4.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblLname)
        Me.GroupBox1.Controls.Add(Me.lblfname)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 446)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'lblLname
        '
        Me.lblLname.AutoSize = True
        Me.lblLname.Location = New System.Drawing.Point(354, 18)
        Me.lblLname.Name = "lblLname"
        Me.lblLname.Size = New System.Drawing.Size(0, 13)
        Me.lblLname.TabIndex = 12
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Location = New System.Drawing.Point(303, 18)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(0, 13)
        Me.lblfname.TabIndex = 11
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.btnReset)
        Me.GroupBox4.Controls.Add(Me.Txtnetpay)
        Me.GroupBox4.Controls.Add(Me.btncompute)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Txttotal)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(240, 211)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 173)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Chocolate
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.White
        Me.btnReset.Location = New System.Drawing.Point(163, 126)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(62, 38)
        Me.btnReset.TabIndex = 29
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Txtnetpay
        '
        Me.Txtnetpay.BackColor = System.Drawing.Color.Linen
        Me.Txtnetpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnetpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtnetpay.Location = New System.Drawing.Point(147, 84)
        Me.Txtnetpay.Name = "Txtnetpay"
        Me.Txtnetpay.ReadOnly = True
        Me.Txtnetpay.Size = New System.Drawing.Size(80, 22)
        Me.Txtnetpay.TabIndex = 13
        Me.Txtnetpay.Text = "0"
        Me.Txtnetpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btncompute
        '
        Me.btncompute.BackColor = System.Drawing.Color.RoyalBlue
        Me.btncompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncompute.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncompute.ForeColor = System.Drawing.Color.White
        Me.btncompute.Location = New System.Drawing.Point(74, 126)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(83, 38)
        Me.btncompute.TabIndex = 27
        Me.btncompute.Text = "&Compute"
        Me.btncompute.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "NET PAY"
        '
        'Txttotal
        '
        Me.Txttotal.BackColor = System.Drawing.Color.Linen
        Me.Txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotal.Location = New System.Drawing.Point(147, 48)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.ReadOnly = True
        Me.Txttotal.Size = New System.Drawing.Size(81, 22)
        Me.Txttotal.TabIndex = 11
        Me.Txttotal.Text = "0"
        Me.Txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(127, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "TOTAL DEDUCTIONS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.Txtpaye)
        Me.GroupBox3.Controls.Add(Me.Txtnssf)
        Me.GroupBox3.Controls.Add(Me.txtnhiff)
        Me.GroupBox3.Controls.Add(Me.txtdeductions)
        Me.GroupBox3.Controls.Add(Me.txtadvances)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(9, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(187, 174)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Less "
        '
        'Txtpaye
        '
        Me.Txtpaye.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtpaye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtpaye.Location = New System.Drawing.Point(112, 142)
        Me.Txtpaye.Name = "Txtpaye"
        Me.Txtpaye.ReadOnly = True
        Me.Txtpaye.Size = New System.Drawing.Size(62, 22)
        Me.Txtpaye.TabIndex = 17
        Me.Txtpaye.Text = "0"
        Me.Txtpaye.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtnssf
        '
        Me.Txtnssf.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txtnssf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtnssf.Location = New System.Drawing.Point(112, 116)
        Me.Txtnssf.Name = "Txtnssf"
        Me.Txtnssf.ReadOnly = True
        Me.Txtnssf.Size = New System.Drawing.Size(62, 22)
        Me.Txtnssf.TabIndex = 16
        Me.Txtnssf.Text = "0"
        Me.Txtnssf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtnhiff
        '
        Me.txtnhiff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtnhiff.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnhiff.Location = New System.Drawing.Point(112, 88)
        Me.txtnhiff.Name = "txtnhiff"
        Me.txtnhiff.ReadOnly = True
        Me.txtnhiff.Size = New System.Drawing.Size(62, 22)
        Me.txtnhiff.TabIndex = 15
        Me.txtnhiff.Text = "0"
        Me.txtnhiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtdeductions
        '
        Me.txtdeductions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdeductions.Location = New System.Drawing.Point(112, 60)
        Me.txtdeductions.Name = "txtdeductions"
        Me.txtdeductions.Size = New System.Drawing.Size(62, 22)
        Me.txtdeductions.TabIndex = 14
        Me.txtdeductions.Text = "0"
        Me.txtdeductions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtadvances
        '
        Me.txtadvances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtadvances.Location = New System.Drawing.Point(112, 31)
        Me.txtadvances.Name = "txtadvances"
        Me.txtadvances.Size = New System.Drawing.Size(62, 22)
        Me.txtadvances.TabIndex = 13
        Me.txtadvances.Text = "0"
        Me.txtadvances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(48, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 18)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "PAYE :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(48, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 18)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "NSSF :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(49, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "NHIF :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Deductions :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Advances :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtbonus)
        Me.GroupBox2.Controls.Add(Me.txtallowances)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtgpay)
        Me.GroupBox2.Controls.Add(Me.txtcommission)
        Me.GroupBox2.Controls.Add(Me.txtsalary)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 163)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Add "
        '
        'txtbonus
        '
        Me.txtbonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbonus.Location = New System.Drawing.Point(115, 81)
        Me.txtbonus.Name = "txtbonus"
        Me.txtbonus.Size = New System.Drawing.Size(59, 22)
        Me.txtbonus.TabIndex = 18
        Me.txtbonus.Text = "0"
        Me.txtbonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtallowances
        '
        Me.txtallowances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtallowances.Location = New System.Drawing.Point(115, 53)
        Me.txtallowances.Name = "txtallowances"
        Me.txtallowances.Size = New System.Drawing.Size(59, 22)
        Me.txtallowances.TabIndex = 17
        Me.txtallowances.Text = "0"
        Me.txtallowances.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(27, 55)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 16)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Allowances :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(57, 84)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 16)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Bonus :"
        '
        'txtgpay
        '
        Me.txtgpay.BackColor = System.Drawing.Color.Linen
        Me.txtgpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtgpay.Location = New System.Drawing.Point(115, 134)
        Me.txtgpay.Name = "txtgpay"
        Me.txtgpay.Size = New System.Drawing.Size(59, 22)
        Me.txtgpay.TabIndex = 12
        Me.txtgpay.Text = "0"
        Me.txtgpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtcommission
        '
        Me.txtcommission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcommission.Location = New System.Drawing.Point(115, 107)
        Me.txtcommission.Name = "txtcommission"
        Me.txtcommission.Size = New System.Drawing.Size(59, 22)
        Me.txtcommission.TabIndex = 11
        Me.txtcommission.Text = "0"
        Me.txtcommission.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsalary
        '
        Me.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsalary.Location = New System.Drawing.Point(115, 27)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(59, 22)
        Me.txtsalary.TabIndex = 10
        Me.txtsalary.Text = "0"
        Me.txtsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "GROSS PAY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Commission : "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(57, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 16)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Salary :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Compute_KRA.My.Resources.Resources.Money_Bags_Payroll
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(314, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 186)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(527, 480)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll KRA Computation"
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblLname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Txtnetpay As System.Windows.Forms.TextBox
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txtpaye As System.Windows.Forms.TextBox
    Friend WithEvents Txtnssf As System.Windows.Forms.TextBox
    Friend WithEvents txtnhiff As System.Windows.Forms.TextBox
    Friend WithEvents txtdeductions As System.Windows.Forms.TextBox
    Friend WithEvents txtadvances As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbonus As System.Windows.Forms.TextBox
    Friend WithEvents txtallowances As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtgpay As System.Windows.Forms.TextBox
    Friend WithEvents txtcommission As System.Windows.Forms.TextBox
    Friend WithEvents txtsalary As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

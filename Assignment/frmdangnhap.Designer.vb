<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Me.grbdangnhap = New System.Windows.Forms.GroupBox()
        Me.txttaikhoan = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.lbltaikhoan = New System.Windows.Forms.Label()
        Me.lblmatkhau = New System.Windows.Forms.Label()
        Me.txtmatkhau = New System.Windows.Forms.TextBox()
        Me.lbldangnhaphethong = New System.Windows.Forms.Label()
        Me.grbdangnhap.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbdangnhap
        '
        Me.grbdangnhap.Controls.Add(Me.txttaikhoan)
        Me.grbdangnhap.Controls.Add(Me.PictureBox1)
        Me.grbdangnhap.Controls.Add(Me.btnthoat)
        Me.grbdangnhap.Controls.Add(Me.btndangnhap)
        Me.grbdangnhap.Controls.Add(Me.lbltaikhoan)
        Me.grbdangnhap.Controls.Add(Me.lblmatkhau)
        Me.grbdangnhap.Controls.Add(Me.txtmatkhau)
        Me.grbdangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbdangnhap.Location = New System.Drawing.Point(22, 67)
        Me.grbdangnhap.Name = "grbdangnhap"
        Me.grbdangnhap.Size = New System.Drawing.Size(399, 182)
        Me.grbdangnhap.TabIndex = 10
        Me.grbdangnhap.TabStop = False
        Me.grbdangnhap.Text = "Đăng Nhập"
        '
        'txttaikhoan
        '
        Me.txttaikhoan.Location = New System.Drawing.Point(165, 46)
        Me.txttaikhoan.Name = "txttaikhoan"
        Me.txttaikhoan.Size = New System.Drawing.Size(210, 26)
        Me.txttaikhoan.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.wwewewewewe
        Me.PictureBox1.Location = New System.Drawing.Point(15, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 134)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'btnthoat
        '
        Me.btnthoat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthoat.Image = Global.Assignment.My.Resources.Resources._1370891310_101
        Me.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnthoat.Location = New System.Drawing.Point(276, 140)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(99, 25)
        Me.btnthoat.TabIndex = 4
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'btndangnhap
        '
        Me.btndangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndangnhap.Image = Global.Assignment.My.Resources.Resources._1370891259_clean
        Me.btndangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btndangnhap.Location = New System.Drawing.Point(165, 140)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(99, 25)
        Me.btndangnhap.TabIndex = 3
        Me.btndangnhap.Text = "Đăng Nhập"
        Me.btndangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'lbltaikhoan
        '
        Me.lbltaikhoan.AutoSize = True
        Me.lbltaikhoan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltaikhoan.Location = New System.Drawing.Point(162, 25)
        Me.lbltaikhoan.Name = "lbltaikhoan"
        Me.lbltaikhoan.Size = New System.Drawing.Size(75, 18)
        Me.lbltaikhoan.TabIndex = 2
        Me.lbltaikhoan.Text = "Tài Khoản"
        '
        'lblmatkhau
        '
        Me.lblmatkhau.AutoSize = True
        Me.lblmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmatkhau.Location = New System.Drawing.Point(162, 75)
        Me.lblmatkhau.Name = "lblmatkhau"
        Me.lblmatkhau.Size = New System.Drawing.Size(71, 18)
        Me.lblmatkhau.TabIndex = 1
        Me.lblmatkhau.Text = "Mật Khẩu"
        '
        'txtmatkhau
        '
        Me.txtmatkhau.Location = New System.Drawing.Point(165, 96)
        Me.txtmatkhau.Name = "txtmatkhau"
        Me.txtmatkhau.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtmatkhau.Size = New System.Drawing.Size(210, 26)
        Me.txtmatkhau.TabIndex = 6
        '
        'lbldangnhaphethong
        '
        Me.lbldangnhaphethong.AutoSize = True
        Me.lbldangnhaphethong.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldangnhaphethong.ForeColor = System.Drawing.Color.Red
        Me.lbldangnhaphethong.Location = New System.Drawing.Point(92, 22)
        Me.lbldangnhaphethong.Name = "lbldangnhaphethong"
        Me.lbldangnhaphethong.Size = New System.Drawing.Size(270, 25)
        Me.lbldangnhaphethong.TabIndex = 9
        Me.lbldangnhaphethong.Text = "ĐĂNG NHẬP HỆ THỐNG"
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 275)
        Me.Controls.Add(Me.grbdangnhap)
        Me.Controls.Add(Me.lbldangnhaphethong)
        Me.Name = "frmdangnhap"
        Me.Text = "Đăng Nhập"
        Me.grbdangnhap.ResumeLayout(False)
        Me.grbdangnhap.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbdangnhap As System.Windows.Forms.GroupBox
    Friend WithEvents txttaikhoan As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents lbltaikhoan As System.Windows.Forms.Label
    Friend WithEvents lblmatkhau As System.Windows.Forms.Label
    Friend WithEvents txtmatkhau As System.Windows.Forms.TextBox
    Friend WithEvents lbldangnhaphethong As System.Windows.Forms.Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlykhachang
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
        Me.dgvketquakh = New System.Windows.Forms.DataGridView()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.grbthongtinkh = New System.Windows.Forms.GroupBox()
        Me.ptbhinhanh = New System.Windows.Forms.PictureBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.txttenkh = New System.Windows.Forms.TextBox()
        Me.txtsodienthoai = New System.Windows.Forms.TextBox()
        Me.txtdiachi = New System.Windows.Forms.TextBox()
        Me.txtmakh = New System.Windows.Forms.TextBox()
        Me.lblsodienthoai = New System.Windows.Forms.Label()
        Me.lbltenkhachang = New System.Windows.Forms.Label()
        Me.lblmakhachhang = New System.Windows.Forms.Label()
        Me.lbldaichi = New System.Windows.Forms.Label()
        Me.ofdanhanh = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvmakh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtenkh = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvsodienthoai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvdiachi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvketquakh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbthongtinkh.SuspendLayout()
        CType(Me.ptbhinhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvketquakh
        '
        Me.dgvketquakh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvketquakh.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvmakh, Me.dgvtenkh, Me.dgvsodienthoai, Me.dgvdiachi})
        Me.dgvketquakh.Location = New System.Drawing.Point(0, 217)
        Me.dgvketquakh.Name = "dgvketquakh"
        Me.dgvketquakh.Size = New System.Drawing.Size(520, 156)
        Me.dgvketquakh.TabIndex = 21
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(422, 486)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(82, 29)
        Me.btnthoat.TabIndex = 20
        Me.btnthoat.Text = "THOÁT"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'grbthongtinkh
        '
        Me.grbthongtinkh.Controls.Add(Me.dgvketquakh)
        Me.grbthongtinkh.Controls.Add(Me.ptbhinhanh)
        Me.grbthongtinkh.Controls.Add(Me.btnthem)
        Me.grbthongtinkh.Controls.Add(Me.btnxoa)
        Me.grbthongtinkh.Controls.Add(Me.btnsua)
        Me.grbthongtinkh.Controls.Add(Me.txttenkh)
        Me.grbthongtinkh.Controls.Add(Me.txtsodienthoai)
        Me.grbthongtinkh.Controls.Add(Me.txtdiachi)
        Me.grbthongtinkh.Controls.Add(Me.txtmakh)
        Me.grbthongtinkh.Controls.Add(Me.lblsodienthoai)
        Me.grbthongtinkh.Controls.Add(Me.lbltenkhachang)
        Me.grbthongtinkh.Controls.Add(Me.lblmakhachhang)
        Me.grbthongtinkh.Controls.Add(Me.lbldaichi)
        Me.grbthongtinkh.Location = New System.Drawing.Point(12, 12)
        Me.grbthongtinkh.Name = "grbthongtinkh"
        Me.grbthongtinkh.Size = New System.Drawing.Size(520, 271)
        Me.grbthongtinkh.TabIndex = 19
        Me.grbthongtinkh.TabStop = False
        Me.grbthongtinkh.Text = "Thông Tin Khách Hàng"
        '
        'ptbhinhanh
        '
        Me.ptbhinhanh.Image = Global.Assignment.My.Resources.Resources.wew
        Me.ptbhinhanh.Location = New System.Drawing.Point(324, 22)
        Me.ptbhinhanh.Name = "ptbhinhanh"
        Me.ptbhinhanh.Size = New System.Drawing.Size(174, 133)
        Me.ptbhinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbhinhanh.TabIndex = 16
        Me.ptbhinhanh.TabStop = False
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(126, 172)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(85, 29)
        Me.btnthem.TabIndex = 15
        Me.btnthem.Text = "THÊM"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(308, 172)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(85, 29)
        Me.btnxoa.TabIndex = 13
        Me.btnxoa.Text = "XÓA"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(217, 172)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(85, 29)
        Me.btnsua.TabIndex = 12
        Me.btnsua.Text = "SỮA"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'txttenkh
        '
        Me.txttenkh.Location = New System.Drawing.Point(126, 67)
        Me.txttenkh.Name = "txttenkh"
        Me.txttenkh.Size = New System.Drawing.Size(168, 20)
        Me.txttenkh.TabIndex = 11
        '
        'txtsodienthoai
        '
        Me.txtsodienthoai.Location = New System.Drawing.Point(126, 101)
        Me.txtsodienthoai.Name = "txtsodienthoai"
        Me.txtsodienthoai.Size = New System.Drawing.Size(168, 20)
        Me.txtsodienthoai.TabIndex = 9
        '
        'txtdiachi
        '
        Me.txtdiachi.Location = New System.Drawing.Point(126, 135)
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(168, 20)
        Me.txtdiachi.TabIndex = 8
        '
        'txtmakh
        '
        Me.txtmakh.Location = New System.Drawing.Point(126, 33)
        Me.txtmakh.Name = "txtmakh"
        Me.txtmakh.Size = New System.Drawing.Size(168, 20)
        Me.txtmakh.TabIndex = 7
        '
        'lblsodienthoai
        '
        Me.lblsodienthoai.AutoSize = True
        Me.lblsodienthoai.Location = New System.Drawing.Point(10, 104)
        Me.lblsodienthoai.Name = "lblsodienthoai"
        Me.lblsodienthoai.Size = New System.Drawing.Size(78, 13)
        Me.lblsodienthoai.TabIndex = 6
        Me.lblsodienthoai.Text = "Số Điện Thoại:"
        '
        'lbltenkhachang
        '
        Me.lbltenkhachang.AutoSize = True
        Me.lbltenkhachang.Location = New System.Drawing.Point(10, 70)
        Me.lbltenkhachang.Name = "lbltenkhachang"
        Me.lbltenkhachang.Size = New System.Drawing.Size(92, 13)
        Me.lbltenkhachang.TabIndex = 5
        Me.lbltenkhachang.Text = "Tên Khách Hàng:"
        '
        'lblmakhachhang
        '
        Me.lblmakhachhang.AutoSize = True
        Me.lblmakhachhang.Location = New System.Drawing.Point(10, 36)
        Me.lblmakhachhang.Name = "lblmakhachhang"
        Me.lblmakhachhang.Size = New System.Drawing.Size(88, 13)
        Me.lblmakhachhang.TabIndex = 1
        Me.lblmakhachhang.Text = "Mã Khách Hàng:"
        '
        'lbldaichi
        '
        Me.lbldaichi.AutoSize = True
        Me.lbldaichi.Location = New System.Drawing.Point(10, 138)
        Me.lbldaichi.Name = "lbldaichi"
        Me.lbldaichi.Size = New System.Drawing.Size(44, 13)
        Me.lbldaichi.TabIndex = 4
        Me.lbldaichi.Text = "Địa Chỉ:"
        '
        'ofdanhanh
        '
        Me.ofdanhanh.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(428, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 29)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "THOÁT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvmakh
        '
        Me.dgvmakh.HeaderText = "Mã KH"
        Me.dgvmakh.Name = "dgvmakh"
        '
        'dgvtenkh
        '
        Me.dgvtenkh.HeaderText = "Tên KH"
        Me.dgvtenkh.Name = "dgvtenkh"
        '
        'dgvsodienthoai
        '
        Me.dgvsodienthoai.HeaderText = "Số Điện Thoại"
        Me.dgvsodienthoai.Name = "dgvsodienthoai"
        '
        'dgvdiachi
        '
        Me.dgvdiachi.HeaderText = "Địa Chỉ"
        Me.dgvdiachi.Name = "dgvdiachi"
        '
        'frmquanlykhachang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 428)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.grbthongtinkh)
        Me.Name = "frmquanlykhachang"
        Me.Text = "Quản Lý Khách Hàng"
        CType(Me.dgvketquakh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbthongtinkh.ResumeLayout(False)
        Me.grbthongtinkh.PerformLayout()
        CType(Me.ptbhinhanh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvketquakh As System.Windows.Forms.DataGridView
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents grbthongtinkh As System.Windows.Forms.GroupBox
    Friend WithEvents ptbhinhanh As System.Windows.Forms.PictureBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents txttenkh As System.Windows.Forms.TextBox
    Friend WithEvents txtsodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents txtmakh As System.Windows.Forms.TextBox
    Friend WithEvents lblsodienthoai As System.Windows.Forms.Label
    Friend WithEvents lbltenkhachang As System.Windows.Forms.Label
    Friend WithEvents lblmakhachhang As System.Windows.Forms.Label
    Friend WithEvents lbldaichi As System.Windows.Forms.Label
    Friend WithEvents ofdanhanh As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgvmakh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtenkh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvsodienthoai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvdiachi As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

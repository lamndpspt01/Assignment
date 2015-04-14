<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanlysanpham
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
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.grbthongtinsp = New System.Windows.Forms.GroupBox()
        Me.cbbchitietsp = New System.Windows.Forms.ComboBox()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.lblduonglink = New System.Windows.Forms.Label()
        Me.ptbhinhanh = New System.Windows.Forms.PictureBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.txttensp = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.txtmasp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbldongia = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblsoluong = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Ofdhinhanh = New System.Windows.Forms.OpenFileDialog()
        Me.dgvketquasp = New System.Windows.Forms.DataGridView()
        Me.dgvmasp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvtensp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvdongia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvsoluong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvchitietsp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbthongtinsp.SuspendLayout()
        CType(Me.ptbhinhanh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvketquasp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(422, 490)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(82, 29)
        Me.btnthoat.TabIndex = 17
        Me.btnthoat.Text = "THOÁT"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'grbthongtinsp
        '
        Me.grbthongtinsp.Controls.Add(Me.cbbchitietsp)
        Me.grbthongtinsp.Controls.Add(Me.btnbrowse)
        Me.grbthongtinsp.Controls.Add(Me.lblduonglink)
        Me.grbthongtinsp.Controls.Add(Me.ptbhinhanh)
        Me.grbthongtinsp.Controls.Add(Me.btnthem)
        Me.grbthongtinsp.Controls.Add(Me.btnxoa)
        Me.grbthongtinsp.Controls.Add(Me.btnsua)
        Me.grbthongtinsp.Controls.Add(Me.txttensp)
        Me.grbthongtinsp.Controls.Add(Me.txtdongia)
        Me.grbthongtinsp.Controls.Add(Me.txtsoluong)
        Me.grbthongtinsp.Controls.Add(Me.txtmasp)
        Me.grbthongtinsp.Controls.Add(Me.Label3)
        Me.grbthongtinsp.Controls.Add(Me.lbldongia)
        Me.grbthongtinsp.Controls.Add(Me.Label6)
        Me.grbthongtinsp.Controls.Add(Me.Label2)
        Me.grbthongtinsp.Controls.Add(Me.lblsoluong)
        Me.grbthongtinsp.Controls.Add(Me.Label4)
        Me.grbthongtinsp.Location = New System.Drawing.Point(12, 16)
        Me.grbthongtinsp.Name = "grbthongtinsp"
        Me.grbthongtinsp.Size = New System.Drawing.Size(520, 271)
        Me.grbthongtinsp.TabIndex = 15
        Me.grbthongtinsp.TabStop = False
        Me.grbthongtinsp.Text = "Thông Tin Sản Phẩm"
        '
        'cbbchitietsp
        '
        Me.cbbchitietsp.FormattingEnabled = True
        Me.cbbchitietsp.Items.AddRange(New Object() {"Áo", "Quần", "Váy Đầm"})
        Me.cbbchitietsp.Location = New System.Drawing.Point(126, 169)
        Me.cbbchitietsp.Name = "cbbchitietsp"
        Me.cbbchitietsp.Size = New System.Drawing.Size(168, 21)
        Me.cbbchitietsp.TabIndex = 20
        '
        'btnbrowse
        '
        Me.btnbrowse.Location = New System.Drawing.Point(410, 199)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(82, 25)
        Me.btnbrowse.TabIndex = 19
        Me.btnbrowse.Text = "Browse.."
        Me.btnbrowse.UseVisualStyleBackColor = True
        '
        'lblduonglink
        '
        Me.lblduonglink.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblduonglink.Location = New System.Drawing.Point(126, 200)
        Me.lblduonglink.Name = "lblduonglink"
        Me.lblduonglink.Size = New System.Drawing.Size(278, 24)
        Me.lblduonglink.TabIndex = 17
        Me.lblduonglink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ptbhinhanh
        '
        Me.ptbhinhanh.Image = Global.Assignment.My.Resources.Resources.wew
        Me.ptbhinhanh.Location = New System.Drawing.Point(322, 33)
        Me.ptbhinhanh.Name = "ptbhinhanh"
        Me.ptbhinhanh.Size = New System.Drawing.Size(170, 152)
        Me.ptbhinhanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbhinhanh.TabIndex = 16
        Me.ptbhinhanh.TabStop = False
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(126, 233)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(85, 29)
        Me.btnthem.TabIndex = 15
        Me.btnthem.Text = "THÊM"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(319, 233)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(85, 29)
        Me.btnxoa.TabIndex = 13
        Me.btnxoa.Text = "XÓA"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(223, 233)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(85, 29)
        Me.btnsua.TabIndex = 12
        Me.btnsua.Text = "SỮA"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'txttensp
        '
        Me.txttensp.Location = New System.Drawing.Point(126, 67)
        Me.txttensp.Name = "txttensp"
        Me.txttensp.Size = New System.Drawing.Size(168, 20)
        Me.txttensp.TabIndex = 11
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(126, 101)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(168, 20)
        Me.txtdongia.TabIndex = 9
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(126, 135)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(168, 20)
        Me.txtsoluong.TabIndex = 8
        '
        'txtmasp
        '
        Me.txtmasp.Location = New System.Drawing.Point(126, 33)
        Me.txtmasp.Name = "txtmasp"
        Me.txtmasp.Size = New System.Drawing.Size(168, 20)
        Me.txtmasp.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Chi Tiết Sản Phẩm:"
        '
        'lbldongia
        '
        Me.lbldongia.AutoSize = True
        Me.lbldongia.Location = New System.Drawing.Point(10, 104)
        Me.lbldongia.Name = "lbldongia"
        Me.lbldongia.Size = New System.Drawing.Size(49, 13)
        Me.lbldongia.TabIndex = 6
        Me.lbldongia.Text = "Đơn Giá:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tên Sẩn Phẩm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã Sản Phẩm:"
        '
        'lblsoluong
        '
        Me.lblsoluong.AutoSize = True
        Me.lblsoluong.Location = New System.Drawing.Point(10, 138)
        Me.lblsoluong.Name = "lblsoluong"
        Me.lblsoluong.Size = New System.Drawing.Size(59, 13)
        Me.lblsoluong.TabIndex = 4
        Me.lblsoluong.Text = "Số Lượng :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hình ảnh :"
        '
        'Ofdhinhanh
        '
        Me.Ofdhinhanh.FileName = "OpenFileDialog1"
        '
        'dgvketquasp
        '
        Me.dgvketquasp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvketquasp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgvmasp, Me.dgvtensp, Me.dgvdongia, Me.dgvsoluong, Me.dgvchitietsp})
        Me.dgvketquasp.Location = New System.Drawing.Point(8, 297)
        Me.dgvketquasp.Name = "dgvketquasp"
        Me.dgvketquasp.Size = New System.Drawing.Size(520, 187)
        Me.dgvketquasp.TabIndex = 18
        '
        'dgvmasp
        '
        Me.dgvmasp.HeaderText = "Mã SP"
        Me.dgvmasp.Name = "dgvmasp"
        '
        'dgvtensp
        '
        Me.dgvtensp.HeaderText = "Tên SP"
        Me.dgvtensp.Name = "dgvtensp"
        '
        'dgvdongia
        '
        Me.dgvdongia.HeaderText = "Đơn Giá"
        Me.dgvdongia.Name = "dgvdongia"
        '
        'dgvsoluong
        '
        Me.dgvsoluong.HeaderText = "Số Lượng"
        Me.dgvsoluong.Name = "dgvsoluong"
        '
        'dgvchitietsp
        '
        Me.dgvchitietsp.HeaderText = "Chi Tiết SP"
        Me.dgvchitietsp.Name = "dgvchitietsp"
        '
        'frmquanlysanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 524)
        Me.Controls.Add(Me.dgvketquasp)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.grbthongtinsp)
        Me.Name = "frmquanlysanpham"
        Me.Text = "Quản Lý Sản Phẩm"
        Me.grbthongtinsp.ResumeLayout(False)
        Me.grbthongtinsp.PerformLayout()
        CType(Me.ptbhinhanh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvketquasp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents grbthongtinsp As System.Windows.Forms.GroupBox
    Friend WithEvents cbbchitietsp As System.Windows.Forms.ComboBox
    Friend WithEvents btnbrowse As System.Windows.Forms.Button
    Friend WithEvents lblduonglink As System.Windows.Forms.Label
    Friend WithEvents ptbhinhanh As System.Windows.Forms.PictureBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents txttensp As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtmasp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbldongia As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblsoluong As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Ofdhinhanh As System.Windows.Forms.OpenFileDialog
    Friend WithEvents dgvketquasp As System.Windows.Forms.DataGridView
    Friend WithEvents dgvmasp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvtensp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvdongia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvsoluong As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvchitietsp As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

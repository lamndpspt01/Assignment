<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmthongtinsanpham
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
        Me.grbdanhsachsp = New System.Windows.Forms.GroupBox()
        Me.lsvdanhsachsptt = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.grbsanpham = New System.Windows.Forms.GroupBox()
        Me.lblloaispnhap = New System.Windows.Forms.Label()
        Me.lblgiaspnhap = New System.Windows.Forms.Label()
        Me.lblsoluongcon = New System.Windows.Forms.Label()
        Me.lblhienso = New System.Windows.Forms.Label()
        Me.lblmasp = New System.Windows.Forms.Label()
        Me.lbltenspnhap = New System.Windows.Forms.Label()
        Me.btndongtt = New System.Windows.Forms.Button()
        Me.btntrai = New System.Windows.Forms.Button()
        Me.btnphaiphai = New System.Windows.Forms.Button()
        Me.btnphai = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btntraitrai = New System.Windows.Forms.Button()
        Me.ptbhinhanhtt = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbdanhsachsp.SuspendLayout()
        Me.grbsanpham.SuspendLayout()
        CType(Me.ptbhinhanhtt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbdanhsachsp
        '
        Me.grbdanhsachsp.Controls.Add(Me.lsvdanhsachsptt)
        Me.grbdanhsachsp.Location = New System.Drawing.Point(352, 14)
        Me.grbdanhsachsp.Name = "grbdanhsachsp"
        Me.grbdanhsachsp.Size = New System.Drawing.Size(510, 440)
        Me.grbdanhsachsp.TabIndex = 3
        Me.grbdanhsachsp.TabStop = False
        Me.grbdanhsachsp.Text = "Danh Sách Sản Phẩm"
        '
        'lsvdanhsachsptt
        '
        Me.lsvdanhsachsptt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvdanhsachsptt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsvdanhsachsptt.FullRowSelect = True
        Me.lsvdanhsachsptt.GridLines = True
        Me.lsvdanhsachsptt.Location = New System.Drawing.Point(3, 16)
        Me.lsvdanhsachsptt.Name = "lsvdanhsachsptt"
        Me.lsvdanhsachsptt.Size = New System.Drawing.Size(504, 421)
        Me.lsvdanhsachsptt.TabIndex = 0
        Me.lsvdanhsachsptt.UseCompatibleStateImageBehavior = False
        Me.lsvdanhsachsptt.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã SP"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Tên SP"
        Me.ColumnHeader2.Width = 131
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Loại SP"
        Me.ColumnHeader3.Width = 95
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Giá SP"
        Me.ColumnHeader4.Width = 81
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Số Lượng Còn"
        Me.ColumnHeader5.Width = 125
        '
        'grbsanpham
        '
        Me.grbsanpham.Controls.Add(Me.lblloaispnhap)
        Me.grbsanpham.Controls.Add(Me.lblgiaspnhap)
        Me.grbsanpham.Controls.Add(Me.lblsoluongcon)
        Me.grbsanpham.Controls.Add(Me.lblhienso)
        Me.grbsanpham.Controls.Add(Me.lblmasp)
        Me.grbsanpham.Controls.Add(Me.lbltenspnhap)
        Me.grbsanpham.Controls.Add(Me.btndongtt)
        Me.grbsanpham.Controls.Add(Me.btntrai)
        Me.grbsanpham.Controls.Add(Me.btnphaiphai)
        Me.grbsanpham.Controls.Add(Me.btnphai)
        Me.grbsanpham.Controls.Add(Me.Label6)
        Me.grbsanpham.Controls.Add(Me.btntraitrai)
        Me.grbsanpham.Controls.Add(Me.ptbhinhanhtt)
        Me.grbsanpham.Controls.Add(Me.Label5)
        Me.grbsanpham.Controls.Add(Me.Label4)
        Me.grbsanpham.Controls.Add(Me.Label3)
        Me.grbsanpham.Controls.Add(Me.Label2)
        Me.grbsanpham.Controls.Add(Me.Label1)
        Me.grbsanpham.Location = New System.Drawing.Point(16, 14)
        Me.grbsanpham.Name = "grbsanpham"
        Me.grbsanpham.Size = New System.Drawing.Size(318, 440)
        Me.grbsanpham.TabIndex = 2
        Me.grbsanpham.TabStop = False
        Me.grbsanpham.Text = "Sản Phẩm"
        '
        'lblloaispnhap
        '
        Me.lblloaispnhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblloaispnhap.Location = New System.Drawing.Point(116, 90)
        Me.lblloaispnhap.Name = "lblloaispnhap"
        Me.lblloaispnhap.Size = New System.Drawing.Size(185, 25)
        Me.lblloaispnhap.TabIndex = 33
        Me.lblloaispnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblgiaspnhap
        '
        Me.lblgiaspnhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblgiaspnhap.Location = New System.Drawing.Point(117, 121)
        Me.lblgiaspnhap.Name = "lblgiaspnhap"
        Me.lblgiaspnhap.Size = New System.Drawing.Size(185, 25)
        Me.lblgiaspnhap.TabIndex = 32
        Me.lblgiaspnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsoluongcon
        '
        Me.lblsoluongcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblsoluongcon.Location = New System.Drawing.Point(116, 153)
        Me.lblsoluongcon.Name = "lblsoluongcon"
        Me.lblsoluongcon.Size = New System.Drawing.Size(185, 25)
        Me.lblsoluongcon.TabIndex = 29
        Me.lblsoluongcon.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblhienso
        '
        Me.lblhienso.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblhienso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblhienso.Location = New System.Drawing.Point(108, 395)
        Me.lblhienso.Name = "lblhienso"
        Me.lblhienso.Size = New System.Drawing.Size(36, 28)
        Me.lblhienso.TabIndex = 28
        Me.lblhienso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblmasp
        '
        Me.lblmasp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblmasp.Location = New System.Drawing.Point(117, 28)
        Me.lblmasp.Name = "lblmasp"
        Me.lblmasp.Size = New System.Drawing.Size(184, 25)
        Me.lblmasp.TabIndex = 30
        Me.lblmasp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbltenspnhap
        '
        Me.lbltenspnhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbltenspnhap.Location = New System.Drawing.Point(117, 59)
        Me.lbltenspnhap.Name = "lbltenspnhap"
        Me.lbltenspnhap.Size = New System.Drawing.Size(185, 25)
        Me.lbltenspnhap.TabIndex = 31
        Me.lbltenspnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btndongtt
        '
        Me.btndongtt.Location = New System.Drawing.Point(235, 395)
        Me.btndongtt.Name = "btndongtt"
        Me.btndongtt.Size = New System.Drawing.Size(67, 28)
        Me.btndongtt.TabIndex = 27
        Me.btndongtt.Text = "Đóng"
        Me.btndongtt.UseVisualStyleBackColor = True
        '
        'btntrai
        '
        Me.btntrai.Location = New System.Drawing.Point(66, 395)
        Me.btntrai.Name = "btntrai"
        Me.btntrai.Size = New System.Drawing.Size(36, 28)
        Me.btntrai.TabIndex = 26
        Me.btntrai.Text = "<"
        Me.btntrai.UseVisualStyleBackColor = True
        '
        'btnphaiphai
        '
        Me.btnphaiphai.Location = New System.Drawing.Point(192, 395)
        Me.btnphaiphai.Name = "btnphaiphai"
        Me.btnphaiphai.Size = New System.Drawing.Size(36, 28)
        Me.btnphaiphai.TabIndex = 25
        Me.btnphaiphai.Text = ">>"
        Me.btnphaiphai.UseVisualStyleBackColor = True
        '
        'btnphai
        '
        Me.btnphai.Location = New System.Drawing.Point(150, 395)
        Me.btnphai.Name = "btnphai"
        Me.btnphai.Size = New System.Drawing.Size(36, 28)
        Me.btnphai.TabIndex = 24
        Me.btnphai.Text = ">"
        Me.btnphai.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Số Lượng Còn:"
        '
        'btntraitrai
        '
        Me.btntraitrai.Location = New System.Drawing.Point(24, 395)
        Me.btntraitrai.Name = "btntraitrai"
        Me.btntraitrai.Size = New System.Drawing.Size(36, 28)
        Me.btntraitrai.TabIndex = 6
        Me.btntraitrai.Text = "<<"
        Me.btntraitrai.UseVisualStyleBackColor = True
        '
        'ptbhinhanhtt
        '
        Me.ptbhinhanhtt.Location = New System.Drawing.Point(24, 210)
        Me.ptbhinhanhtt.Name = "ptbhinhanhtt"
        Me.ptbhinhanhtt.Size = New System.Drawing.Size(277, 171)
        Me.ptbhinhanhtt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptbhinhanhtt.TabIndex = 5
        Me.ptbhinhanhtt.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Hình ảnh:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Giá Sản Phẩm:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Loại Sản Phẩm:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tên Sản Phẩm:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mã Sản Phẩm:"
        '
        'frmthongtinsanpham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 466)
        Me.Controls.Add(Me.grbdanhsachsp)
        Me.Controls.Add(Me.grbsanpham)
        Me.Name = "frmthongtinsanpham"
        Me.Text = "Thông Tin Sản Phẩm"
        Me.grbdanhsachsp.ResumeLayout(False)
        Me.grbsanpham.ResumeLayout(False)
        Me.grbsanpham.PerformLayout()
        CType(Me.ptbhinhanhtt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbdanhsachsp As System.Windows.Forms.GroupBox
    Friend WithEvents lsvdanhsachsptt As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grbsanpham As System.Windows.Forms.GroupBox
    Friend WithEvents lblloaispnhap As System.Windows.Forms.Label
    Friend WithEvents lblgiaspnhap As System.Windows.Forms.Label
    Friend WithEvents lblsoluongcon As System.Windows.Forms.Label
    Friend WithEvents lblhienso As System.Windows.Forms.Label
    Friend WithEvents lblmasp As System.Windows.Forms.Label
    Friend WithEvents lbltenspnhap As System.Windows.Forms.Label
    Friend WithEvents btndongtt As System.Windows.Forms.Button
    Friend WithEvents btntrai As System.Windows.Forms.Button
    Friend WithEvents btnphaiphai As System.Windows.Forms.Button
    Friend WithEvents btnphai As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btntraitrai As System.Windows.Forms.Button
    Friend WithEvents ptbhinhanhtt As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

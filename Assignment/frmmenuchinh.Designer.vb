<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenuchinh
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnihethong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniquanlysp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThôngTinToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mniquanlykh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.mnidangxuat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnidong = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniquanlysanpham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnithongtinsanpham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mninhapsanpham = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniquanlykhachhang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnithongtinkhachhang = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnigioithieu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnitrogiup = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnihethong, Me.mniquanlysp, Me.mniquanlykh, Me.ThôngTinToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnihethong
        '
        Me.mnihethong.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnidangxuat, Me.mnidong})
        Me.mnihethong.Name = "mnihethong"
        Me.mnihethong.Size = New System.Drawing.Size(72, 20)
        Me.mnihethong.Text = "Hệ Thống"
        '
        'mniquanlysp
        '
        Me.mniquanlysp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniquanlysanpham, Me.mnithongtinsanpham, Me.mninhapsanpham})
        Me.mniquanlysp.Name = "mniquanlysp"
        Me.mniquanlysp.Size = New System.Drawing.Size(119, 20)
        Me.mniquanlysp.Text = "Quản Lý Sản Phẩm"
        '
        'ThôngTinToolStripMenuItem
        '
        Me.ThôngTinToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnigioithieu, Me.mnitrogiup})
        Me.ThôngTinToolStripMenuItem.Name = "ThôngTinToolStripMenuItem"
        Me.ThôngTinToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ThôngTinToolStripMenuItem.Text = "Thông Tin"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 402)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(730, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(156, 17)
        Me.ToolStripStatusLabel1.Text = "Nguyễn Đình Lâm - Ps02177"
        '
        'mniquanlykh
        '
        Me.mniquanlykh.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniquanlykhachhang, Me.mnithongtinkhachhang})
        Me.mniquanlykh.Name = "mniquanlykh"
        Me.mniquanlykh.Size = New System.Drawing.Size(131, 20)
        Me.mniquanlykh.Text = "Quản Lý Khách Hàng"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.Image = Global.Assignment.My.Resources.Resources.User
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(32, 20)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.aaaaa
        Me.PictureBox1.Location = New System.Drawing.Point(0, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(731, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'mnidangxuat
        '
        Me.mnidangxuat.Image = Global.Assignment.My.Resources.Resources._1370169928_logout
        Me.mnidangxuat.Name = "mnidangxuat"
        Me.mnidangxuat.Size = New System.Drawing.Size(129, 22)
        Me.mnidangxuat.Text = "Đăng Xuất"
        '
        'mnidong
        '
        Me.mnidong.Image = Global.Assignment.My.Resources.Resources._1370891310_1011
        Me.mnidong.Name = "mnidong"
        Me.mnidong.Size = New System.Drawing.Size(129, 22)
        Me.mnidong.Text = "Đóng"
        '
        'mniquanlysanpham
        '
        Me.mniquanlysanpham.Image = Global.Assignment.My.Resources.Resources.Notes
        Me.mniquanlysanpham.Name = "mniquanlysanpham"
        Me.mniquanlysanpham.Size = New System.Drawing.Size(185, 22)
        Me.mniquanlysanpham.Text = "Quản Lý Sản Phẩm"
        '
        'mnithongtinsanpham
        '
        Me.mnithongtinsanpham.Image = Global.Assignment.My.Resources.Resources.Search
        Me.mnithongtinsanpham.Name = "mnithongtinsanpham"
        Me.mnithongtinsanpham.Size = New System.Drawing.Size(185, 22)
        Me.mnithongtinsanpham.Text = "Thông Tin Sản Phẩm"
        '
        'mninhapsanpham
        '
        Me.mninhapsanpham.Image = Global.Assignment.My.Resources.Resources.Add
        Me.mninhapsanpham.Name = "mninhapsanpham"
        Me.mninhapsanpham.Size = New System.Drawing.Size(185, 22)
        Me.mninhapsanpham.Text = "Nhập Sản Phẩm"
        '
        'mniquanlykhachhang
        '
        Me.mniquanlykhachhang.Image = Global.Assignment.My.Resources.Resources.User1
        Me.mniquanlykhachhang.Name = "mniquanlykhachhang"
        Me.mniquanlykhachhang.Size = New System.Drawing.Size(197, 22)
        Me.mniquanlykhachhang.Text = "Quản Lý Khách Hàng"
        '
        'mnithongtinkhachhang
        '
        Me.mnithongtinkhachhang.Image = Global.Assignment.My.Resources.Resources.Search1
        Me.mnithongtinkhachhang.Name = "mnithongtinkhachhang"
        Me.mnithongtinkhachhang.Size = New System.Drawing.Size(197, 22)
        Me.mnithongtinkhachhang.Text = "Thông Tin Khách Hàng"
        '
        'mnigioithieu
        '
        Me.mnigioithieu.Image = Global.Assignment.My.Resources.Resources._1370168640_my_account
        Me.mnigioithieu.Name = "mnigioithieu"
        Me.mnigioithieu.Size = New System.Drawing.Size(128, 22)
        Me.mnigioithieu.Text = "Giới Thiệu"
        '
        'mnitrogiup
        '
        Me.mnitrogiup.Image = Global.Assignment.My.Resources.Resources.Telephone
        Me.mnitrogiup.Name = "mnitrogiup"
        Me.mnitrogiup.Size = New System.Drawing.Size(128, 22)
        Me.mnitrogiup.Text = "Trợ Giúp"
        '
        'frmmenuchinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 424)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmenuchinh"
        Me.Text = "Quản Lý Sản Phẩm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnihethong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniquanlysp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThôngTinToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnidangxuat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnidong As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniquanlysanpham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnithongtinsanpham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mninhapsanpham As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnigioithieu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnitrogiup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniquanlykh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mniquanlykhachhang As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnithongtinkhachhang As System.Windows.Forms.ToolStripMenuItem
End Class

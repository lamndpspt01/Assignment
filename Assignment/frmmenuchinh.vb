Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmmenuchinh

    Private Sub TrợGiúpToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub BảnQuyềnToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub NhậpHàngToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub XemSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ThêmSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub mniquanlysanpham_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub KếtThúcToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ĐăngNhậpToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub HệThốngToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub mnidangxuat_Click(sender As Object, e As EventArgs) Handles mnidangxuat.Click

        'khai bao bien dialog
        Dim dialog As DialogResult = MessageBox.Show("Bạn Muốn Kết Thúc Ứng Dụng", "Thông Báo",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'tro lai form dang nhap
        frmdangnhap.Show()
        Me.Hide() 'an form chinh
    End Sub

    Private Sub mnidong_Click(sender As Object, e As EventArgs) Handles mnidong.Click
        Me.Close()
    End Sub

    Private Sub mniquanlysanpham_Click_1(sender As Object, e As EventArgs) Handles mniquanlysanpham.Click
        frmquanlysanpham.ShowDialog()
    End Sub

    Private Sub mnithongtinsanpham_Click(sender As Object, e As EventArgs) Handles mnithongtinsanpham.Click
        frmthongtinsanpham.ShowDialog()
    End Sub

    Private Sub mninhapsanpham_Click(sender As Object, e As EventArgs) Handles mninhapsanpham.Click
        frmnhapsanpham.ShowDialog()
    End Sub

    Private Sub mnigioithieu_Click(sender As Object, e As EventArgs) Handles mnigioithieu.Click
        frmgioithieu.ShowDialog()
    End Sub

    Private Sub mnitrogiup_Click(sender As Object, e As EventArgs) Handles mnitrogiup.Click
        Help.ShowHelp(Me, "huongdan.pdf")
    End Sub

    Private Sub frmmenuchinh_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mniquanlykhachhang_Click(sender As Object, e As EventArgs) Handles mniquanlykhachhang.Click
        frmquanlykhachang.ShowDialog()
    End Sub

    Private Sub mnithongtinkhachhang_Click(sender As Object, e As EventArgs) Handles mnithongtinkhachhang.Click
        frmthongtinkhachang.ShowDialog()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmquanlykhachang

    Dim poro As String = "workstation id=lamndps021777.mssql.somee.com;packet size=4096;user id=lamndps021777_SQLLogin_1;pwd=zqqs5dy112;data source=lamndps021777.mssql.somee.com;persist security info=False;initial catalog=lamndps021777"
    Dim cs As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmquanlykhachang_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ketnoikh As SqlConnection = New SqlConnection(poro)
        Dim SQL1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", poro)

        ketnoikh.Open()
        SQL1.Fill(cs)
        dgvketquakh.DataSource = cs.DefaultView

    End Sub

    Private Sub dgvketquakh_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvketquakh.CellContentClick

        Dim index As Integer = dgvketquakh.CurrentCell.RowIndex
        txtmakh.Text = dgvketquakh.Item(0, index).Value
        txttenkh.Text = dgvketquakh.Item(1, index).Value
        txtsodienthoai.Text = dgvketquakh.Item(2, index).Value
        txtdiachi.Text = dgvketquakh.Item(3, index).Value

    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

        Dim ketnoi As SqlConnection = New SqlConnection(poro)
        Dim SQL2 As String = "insert into San_Pham values (@MaSP,@TenSP,@DonGia,@SoLuong,@ChiTietSP)"
        Dim galaxy1 As New SqlCommand(SQL2, ketnoi)

        ketnoi.Open()

        galaxy1.Parameters.AddWithValue("@Makh", txtmakh.Text)
        galaxy1.Parameters.AddWithValue("@Tenkh", txttenkh.Text)
        galaxy1.Parameters.AddWithValue("@SoDienThoai", txtsodienthoai.Text)
        galaxy1.Parameters.AddWithValue("@DiaChi", txtdiachi.Text)

        galaxy1.ExecuteNonQuery()

        MessageBox.Show("Thêm thành công!")


        Dim SQL3 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        cs.Clear()

        SQL3.Fill(cs)
        dgvketquakh.DataSource = cs.DefaultView

    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click

        Dim ketnoi As SqlConnection = New SqlConnection(poro)
        Dim SQL4 As String = "Update SanPham Set MaSP=@masp, TenSP=@tensp, DonGia=@dongia, SoLuong=@soluong, ChiTietSP=@chitietsp, LoaiSPMaLoai=@loaisp Where MaSP=@masp"

        Dim galaxy2 As New SqlCommand(SQL4, ketnoi)

        ketnoi.Open()
        galaxy2.Parameters.AddWithValue("@makh", txtmakh.Text)
        galaxy2.Parameters.AddWithValue("@tenkh", txttenkh.Text)

        galaxy2.Parameters.AddWithValue("@sodienthoai", txtsodienthoai.Text)
        galaxy2.Parameters.AddWithValue("@diachi", txtdiachi.Text)

        galaxy2.ExecuteNonQuery()
        MessageBox.Show("Sửa thành công!")



        Dim chaylaibang As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        cs.Clear()

        chaylaibang.Fill(cs)
        dgvketquakh.DataSource = cs.DefaultView

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click

        Dim ketnoi As SqlConnection = New SqlConnection(poro)
        Dim SQL As String = " delete from SanPham Where MaSP=@masp"
        Dim galaxy3 As New SqlCommand(SQL, ketnoi)

        ketnoi.Open()

        galaxy3.Parameters.AddWithValue("@masp", txtmakh.Text)
        galaxy3.ExecuteNonQuery()
        MessageBox.Show("Xóa thành công!")
        Dim chaylai As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        cs.Clear()

        chaylai.Fill(cs)
        dgvketquakh.DataSource = cs.DefaultView

    End Sub
End Class
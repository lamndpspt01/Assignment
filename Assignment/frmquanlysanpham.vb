Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmquanlysanpham

    Dim lienket As String = "workstation id=lamndps021777.mssql.somee.com;packet size=4096;user id=lamndps021777_SQLLogin_1;pwd=zqqs5dy112;data source=lamndps021777.mssql.somee.com;persist security info=False;initial catalog=lamndps021777"
    Dim csdl As New DataTable


    Private Sub SanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ketnoi As SqlConnection = New SqlConnection(lienket)
        Dim SQL1 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", lienket)

        ketnoi.Open()
        SQL1.Fill(csdl)
        dgvketquasp.DataSource = csdl.DefaultView

    End Sub


    Private Sub ptbhinhanh_Click(sender As Object, e As EventArgs) Handles ptbhinhanh.Click

    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click

        Dim ketnoi As SqlConnection = New SqlConnection(lienket)
        Dim SQL2 As String = "insert into San_Pham values (@MaSP,@TenSP,@DonGia,@SoLuong,@ChiTietSP)"
        Dim start1 As New SqlCommand(SQL2, ketnoi)

        ketnoi.Open()

        start1.Parameters.AddWithValue("@MaSP", txtmasp.Text)
        start1.Parameters.AddWithValue("@TenSP", txttensp.Text)
        start1.Parameters.AddWithValue("@DonGia", txtdongia.Text)
        start1.Parameters.AddWithValue("@SoLuong", lblsoluong.Text)
        start1.Parameters.AddWithValue("@ChiTietSP", cbbchitietsp.Text)

        start1.ExecuteNonQuery()

        MessageBox.Show("Thêm thành công!")


        Dim SQL3 As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        csdl.Clear()

        SQL3.Fill(csdl)
        dgvketquasp.DataSource = csdl.DefaultView

    End Sub


    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click

        Dim ketnoi As SqlConnection = New SqlConnection(lienket)
        Dim SQL4 As String = "Update SanPham Set MaSP=@masp, TenSP=@tensp, DonGia=@dongia, SoLuong=@soluong, ChiTietSP=@chitietsp, LoaiSPMaLoai=@loaisp Where MaSP=@masp"

        Dim start2 As New SqlCommand(SQL4, ketnoi)

        ketnoi.Open()
        start2.Parameters.AddWithValue("@masp", txtmasp.Text)
        start2.Parameters.AddWithValue("@tensp", txttensp.Text)

        start2.Parameters.AddWithValue("@dongia", txtdongia.Text)
        start2.Parameters.AddWithValue("@soluong", lblsoluong.Text)

        start2.Parameters.AddWithValue("@chitiet", cbbchitietsp.Text)


        start2.ExecuteNonQuery()
        MessageBox.Show("Sửa thành công!")



        Dim chaylaibang As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        csdl.Clear()

        chaylaibang.Fill(csdl)
        dgvketquasp.DataSource = csdl.DefaultView

    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click

        Dim ketnoi As SqlConnection = New SqlConnection(lienket)
        Dim SQL As String = " delete from SanPham Where MaSP=@masp"
        Dim start3 As New SqlCommand(SQL, ketnoi)

        ketnoi.Open()

        start3.Parameters.AddWithValue("@masp", txtmasp.Text)
        start3.ExecuteNonQuery()
        MessageBox.Show("Xóa thành công!")
        Dim chaylai As SqlDataAdapter = New SqlDataAdapter("select * from SanPham", ketnoi)
        csdl.Clear()

        chaylai.Fill(csdl)
        dgvketquasp.DataSource = csdl.DefaultView

    End Sub


    Private Sub lsvdanhsachsp_SelectedIndexChanged(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmquanlysanpham_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Ofdhinhanh_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Ofdhinhanh.FileOk

    End Sub

    Private Sub dgvketquasp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvketquasp.CellContentClick

        Dim index As Integer = dgvketquasp.CurrentCell.RowIndex
        txtmasp.Text = dgvketquasp.Item(0, index).Value
        txttensp.Text = dgvketquasp.Item(1, index).Value
        txtdongia.Text = dgvketquasp.Item(2, index).Value
        lblsoluong.Text = dgvketquasp.Item(3, index).Value
        cbbchitietsp.Text = dgvketquasp.Item(4, index).Value


    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub grbthongtinsp_Enter(sender As Object, e As EventArgs) Handles grbthongtinsp.Enter

    End Sub
End Class
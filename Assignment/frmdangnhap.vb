Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmdangnhap
  
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click

        Dim LienKet As String = "workstation id=lamndps021777.mssql.somee.com;packet size=4096;user id=lamndps021777_SQLLogin_1;pwd=zqqs5dy112;data source=lamndps021777.mssql.somee.com;persist security info=False;initial catalog=lamndps021777"

        Dim KetNoi As SqlConnection = New SqlConnection(LienKet)
        Dim SQL1 As SqlDataAdapter = New SqlDataAdapter("select * from NhanVien where MaNhanVien='" & txttaikhoan.Text & "' and Password='" & txtmatkhau.Text & "' ", KetNoi)
        Dim csdl As New DataTable

        Try
            KetNoi.Open()
            SQL1.Fill(csdl)
            If csdl.Rows.Count > 0 Then
                MessageBox.Show("Kết Nối Thành Công :)")
                frmmenuchinh.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai Tài Khoản Hoặc Mật Khẩu :(")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
End Class

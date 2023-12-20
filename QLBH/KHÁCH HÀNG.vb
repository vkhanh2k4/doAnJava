Imports System.Data.SqlClient

Public Class KHÁCH_HÀNG

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub KHÁCH_HÀNG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLBHDataSet1.KHACHHANG' table. You can move, or remove it, as needed.
        Me.KHACHHANGTableAdapter.Fill(Me.QLBHDataSet1.KHACHHANG)
        con.ConnectionString = "Data Source=VANKHANH\KHANH;Initial Catalog=QLBH;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into NHANVIEN values ('" + txtmakh.Text + "','" + txthoten.Text + "','" + txtsdt.Text + "','" + txtns.Text + "','" + txtds.Text + "','" + txtndk.Text + "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("thêm nhân viên thành công")
        showdata()
    End Sub
    Public Sub showdata()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from  KHACHHANG "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " update KHACHHANG set HOTEN='" + txthoten.Text + "',SDT='" + txtsdt.Text + "',NGAYSINH='" + txtns.Text + "',DOANHSO='" + txtds.Text + "', NGAYDK='" + txtndk.Text + "' where MANV= '" + txtmakh.Text + "' "
        cmd.ExecuteNonQuery()
        showdata()
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " delete from KHACHHANG where MAKH= '" + txtmakh.Text + "'"
        cmd.ExecuteNonQuery()
        showdata()
    End Sub



    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM KHACHHANG WHERE MAKH = '" + txtsearch.Text + "'"
        ' Thay HOTEN bằng cột bạn muốn tìm kiếm trong bảng KHACHHANG

        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

End Class
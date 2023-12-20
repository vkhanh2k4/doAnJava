Imports System.Data.SqlClient
Public Class NHANVIEN
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub NHANVIEN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'QLBHDataSet4.NHANVIEN' table. You can move, or remove it, as needed.
        Me.NHANVIENTableAdapter3.Fill(Me.QLBHDataSet4.NHANVIEN)
        'TODO: This line of code loads data into the 'QLBHDataSet3.NHANVIEN' table. You can move, or remove it, as needed.
        Me.NHANVIENTableAdapter2.Fill(Me.QLBHDataSet3.NHANVIEN)
        Me.NHANVIENTableAdapter1.Fill(Me.QLBHDataSet2.NHANVIEN)
        'TODO: This line of code loads data into the 'QLBHDataSet2.NHANVIEN' table. You can move, or remove it, as needed.
        con.ConnectionString = "Data Source=VANKHANH\KHANH;Initial Catalog=QLBH;Integrated Security=True"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into NHANVIEN values ('" + txtmanv.Text + "','" + txthoten.Text + "','" + txtsdt.Text + "','" + txtnlv.Text + "','" + txtcccd.Text + "','" + txtgt.Text + "','" + txtdc.Text + "','" + txtnlviec.Text + "','" + txtns.Text + "','" + txtnhh.Text + "')"
        cmd.ExecuteNonQuery()
        MessageBox.Show("thêm nhân viên thành công")
        showdata()
    End Sub
    Public Sub showdata()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from  NHANVIEN "
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
        cmd.CommandText = " update NHANVIEN set HOTEN='" + txthoten.Text + "',SDT='" + txtsdt.Text + "',NGAYVL='" + txtnlv.Text + "', CCCD = '" + txtcccd.Text + "',GIOITINH = '" + txtgt.Text + "',DIACHI='" + txtdc.Text + "',NGAYLV= '" + txtnlviec.Text + "',NGAYSINH ='" + txtns.Text + "',NGAYHH= '" + txtnhh.Text + "'where MANV= '" + txtmanv.Text + "' "
        cmd.ExecuteNonQuery()
        MessageBox.Show("chỉnh sửa nhân viên thành công")
        showdata()
    End Sub

    Private Sub btndlt_Click(sender As Object, e As EventArgs) Handles btndlt.Click
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " delete from NHANVIEN where MANV= '" + txtmanv.Text + "'"
        cmd.ExecuteNonQuery()
        showdata()
    End Sub




    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from NHANVIEN where MANV = @manv"
        cmd.Parameters.AddWithValue("@manv", txtmanv.Text)
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

End Class
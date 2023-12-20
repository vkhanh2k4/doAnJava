Public Class Main

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim employeeForm As New NHANVIEN()
        NHANVIEN.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim customerForm As New KHÁCH_HÀNG()
        KHÁCH_HÀNG.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
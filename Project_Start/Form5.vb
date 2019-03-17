Imports System.Data
Imports System.Data.SqlClient
Public Class Live
    Dim cnn As New SqlConnection
    Dim dap As New SqlDataAdapter
    Dim cmbd As New SqlCommandBuilder
    Dim cmd As New SqlCommand
    Dim tbl As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BkBtn.Click
        Me.Hide()
        Enquiry.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnBtn.Click
        Me.Hide()
        Project_Start.Show()
    End Sub

    Private Sub Live_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        dap = New SqlDataAdapter("SELECT * FROM Schedule where Arr LIKE '04%'", cnn)
        cmbd = New SqlCommandBuilder(dap)
        dap.Fill(tbl)
        DataGridView1.DataSource = tbl
        cnn.Close()
    End Sub
End Class
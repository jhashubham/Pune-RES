Imports System.Data
Imports System.Data.SqlClient
Public Class Information
    Dim cnn As New SqlConnection
    Dim dap As New SqlDataAdapter
    Dim cmbd As New SqlCommandBuilder
    Dim cmd As New SqlCommand
    Dim tbl As New DataTable

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BkBtn.Click
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        Scedule.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnBtn.Click
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        Me.Hide()
        Project_Start.Show()
    End Sub


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Scedule.TextBox1.Text
        Scedule.TextBox1.Text = ""
        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        dap = New SqlDataAdapter("SELECT * FROM Schedule where Train_No = '" & TextBox1.Text & "'", cnn)
        cmbd = New SqlCommandBuilder(dap)
        dap.Fill(tbl)
        DataGridView1.DataSource = tbl
        cnn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Public Class Enquiry
    Dim cnn As New SqlConnection
    Dim dap As New SqlDataAdapter
    Dim cmbd As New SqlCommandBuilder
    Dim cmd As New SqlCommand
    Dim tbl As New DataTable
    Dim tbl1 As New DataTable
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BkBtn.Click
        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        cnn.Close()
        Me.Hide()
        Project_Start.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnBtn.Click
        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        cnn.Close()
        Me.Hide()
        Project_Start.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LvBtn.Click
        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        cnn.Close()
        Me.Hide()
        Live.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ChkAvlBtn1.Click
        Dim name As String
        name = CmbBxStnList.SelectedItem
        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        If name = Nothing Then
            MsgBox("You have not selected any Destination")
            tbl.Clear()
            DataGridView1.DataSource = tbl
            DataGridView1.DataSource = Nothing
        End If
        If name = "DELHI" Then
            dap = New SqlDataAdapter("select * from Delhi", cnn)
            cmbd = New SqlCommandBuilder(dap)
            DataGridView1.DataSource = tbl
            dap.Fill(tbl)
        ElseIf name = "CHENNAI" Then
            dap = New SqlDataAdapter("select * from Chennai", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "CHANDIGARH" Then
            dap = New SqlDataAdapter("select * from Chandigard", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "DELHI" Then
            dap = New SqlDataAdapter("select * from Delhi", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "HYDERABAD-DECCAN" Then
            dap = New SqlDataAdapter("select * from Hydrabad_Decan", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "JAIPUR" Then
            dap = New SqlDataAdapter("select * from Jaipur", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "KANPUR_CENTERAL" Then
            dap = New SqlDataAdapter("select * from Kanpur_Centeral", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "KOLKATA" Then
            dap = New SqlDataAdapter("select * from Kolkata", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "LACKNOW" Then
            dap = New SqlDataAdapter("select * from Lacknow", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "NAGPUR" Then
            dap = New SqlDataAdapter("select * from Nagpur", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "PATLIPUTRA" Then
            dap = New SqlDataAdapter("select * from Patliputra", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        ElseIf name = "VARANASI" Then
            dap = New SqlDataAdapter("select * from Varanasi", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl)
            DataGridView1.DataSource = tbl
        End If
        cnn.Close()
    End Sub

    Private Sub Enquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        tbl.Clear()
        DataGridView1.DataSource = tbl
        DataGridView1.DataSource = Nothing
        cnn.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles ChkAvlBtn2.Click
        Dim day As String
        day = CmbBxDayLst.SelectedItem
        cnn.ConnectionString = "Data Source=DESKTOP-14S1VPU\SQLEXPRESS;Initial Catalog=Project1;Integrated Security=True"
        cnn.Open()
        tbl1.Clear()
        DataGridView1.DataSource = tbl1
        DataGridView1.DataSource = Nothing
        If day = Nothing Then
            MsgBox("You have not selected any day")
            tbl1.Clear()
            DataGridView1.DataSource = tbl1
            DataGridView1.DataSource = Nothing
        End If
        If day = "MONDAY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%M%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        ElseIf day = "TUESDAY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%Tu%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        ElseIf day = "WEDNESDAY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%W%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        ElseIf day = "THRUSDAY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%Th%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        ElseIf day = "FRIDAY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%F%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        ElseIf day = "SATURDAY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%Sa%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        ElseIf day = "SUNDAY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%Su%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        ElseIf day = "DAILY" Then
            dap = New SqlDataAdapter("select * from Schedule where Days like '%DAILY%'", cnn)
            cmbd = New SqlCommandBuilder(dap)
            dap.Fill(tbl1)
            DataGridView1.DataSource = tbl1
        End If
        cnn.Close()
    End Sub

End Class
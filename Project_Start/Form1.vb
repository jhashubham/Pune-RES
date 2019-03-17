Public Class Project_Start

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnqBtn.Click
        Me.Hide()
        Enquiry.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SdlBtn.Click
        Me.Hide()
        Scedule.Show()
    End Sub
  
    Private Sub ExtBtn_Click(sender As Object, e As EventArgs) Handles ExtBtn.Click
        End
    End Sub
End Class

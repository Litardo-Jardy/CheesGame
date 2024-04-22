Public Class getDates

    Dim p1 As String
    Dim p2 As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
        Dim time As Integer = cb_time.SelectedItem
        globalInstancias.startingValues(p1, p2, time)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        p1 = txt_players1.Text
        players2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        p2 = txt_players2.Text
        time.Show()
    End Sub
End Class
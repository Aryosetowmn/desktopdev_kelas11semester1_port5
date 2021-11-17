Public Class Form1
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        thasil.Text = Val(tangka1.Text) + Val(tangka2.Text)
    End Sub

    Private Sub bkurang_Click(sender As Object, e As EventArgs) Handles bkurang.Click
        thasil.Text = Val(tangka1.Text) - Val(tangka2.Text)
    End Sub

    Private Sub bkali_Click(sender As Object, e As EventArgs) Handles bkali.Click
        thasil.Text = Val(tangka1.Text) * Val(tangka2.Text)
    End Sub

    Private Sub bbagi_Click(sender As Object, e As EventArgs) Handles bbagi.Click
        thasil.Text = Val(tangka1.Text) / Val(tangka2.Text)
    End Sub

    Private Sub bkosongkan_Click(sender As Object, e As EventArgs) Handles bkosongkan.Click
        tangka1.Clear()
        tangka2.Clear()
        thasil.Clear()
        tangka1.Focus()
    End Sub

    Private Sub bkeluar_Click(sender As Object, e As EventArgs) Handles bkeluar.Click
        End
    End Sub
End Class

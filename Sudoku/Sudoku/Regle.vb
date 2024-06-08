Public Class Regle

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
    End Sub

    Private Sub Regle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Acceuil.Show()
    End Sub
End Class
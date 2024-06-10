Public Class Regle

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
    End Sub

    Private Sub Regle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Acceuil.Show()
        Me.Hide()
        e.Cancel = True
    End Sub

    Private Sub Regle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nouvelleOpacite As Double = 0.6
        LabelRegleText.BackColor = Color.Black
        LabelRegleText.BackColor = Color.FromArgb(CInt(nouvelleOpacite * 255), LabelRegleText.BackColor.R, LabelRegleText.BackColor.G, LabelRegleText.BackColor.B)

    End Sub


End Class
Public Class Pause
    Private Sub Pause_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' On charge les images (vies et son en jeu)
        Dim Id As Integer = 5
        For Each Vie As PictureBox In PanelViesRestantes.Controls
            Vie.Image = My.Resources.Vie
            Vie.Tag = Id 'On met des tag different pour chaque vie, ceux qui nous permettra ensuite de les enlever 1 par 1 en cas d'erreur
            Id -= 1
            If Vie.Tag >= Partie.getNbErreursRestantes() + 1 Then Vie.Hide()
        Next
        LabelChronometre.Text = tempstoString(Partie.getTempsRestant)

    End Sub
    Private Sub ButtonAbandonner_Click(sender As Object, e As EventArgs) Handles ButtonAbandonner.Click 'Le joueur peut abodonner depuis le form pause
        If MsgBox("Êtes-vous sûr de vouloir abandonner ?", vbYesNo) = vbYes Then
            ArretForceDeLaPartie()
        End If
    End Sub
    Private Sub ArretForceDeLaPartie() ' Losrque que le joueur est en pleine partie et qu'il quitte veut quitter
        Me.Close()
        Partie.arretForceDeLaPartie()
    End Sub
    Private Sub ButtonReprendre_Click(sender As Object, e As EventArgs) Handles ButtonReprendre.Click
        Me.Close()
    End Sub
    Private Sub Pause_FormClosed(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing ' reprendre le jeu 
        Partie.Show()
        Partie.Chronomètre.Start() 'On redemarre le chronometre
    End Sub

End Class
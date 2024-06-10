Imports System.IO.Ports
Public Class Acceuil
    Private fermetureConfirmee As Boolean = False
    Private musicActif As Boolean = True
    Private Sub Acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualiserPictureBoxSon()
        playOrStopMusic()

    End Sub

    Private Sub Partie_FormClosed(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not fermetureConfirmee Then
            If MsgBox("Voulez-vous quitter l'application ?", vbYesNo) = vbYes Then
                fermetureConfirmee = True
                My.Computer.Audio.Stop()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ButtonNouvelle_partie_Click(sender As Object, e As EventArgs) Handles ButtonNouvelle_partie.Click ' Nouvelle partie
        If ComboBoxJoueur.Text = "Entrer votre nom" OrElse ComboBoxJoueur.Text = "" Then 'Le joueur doit entrer un nom
            MsgBox("Veuillez rentrer un nom")
        Else
            getJoueur(ComboBoxJoueur.Text) ' Obtient le joueur, le creer si il n'exite pas
            Me.Hide()
            Partie.Show()
        End If
    End Sub

    Private Sub ButtonTableau_des_scores_Click(sender As Object, e As EventArgs) Handles ButtonTableau_des_scores.Click ' Tableaiu des scores
        Me.Hide()
        Recapitulatif.Show()
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click ' Quitter l'application
        Me.Close()
    End Sub


    Private Sub ComboBoxJoueur_Click(sender As Object, e As EventArgs) Handles ComboBoxJoueur.Click ' On supprime le message " Entrer votre nom " , Ce Sub ne fonctionne que la premiere fois
        ComboBoxJoueur.Text = ""
        RemoveHandler ComboBoxJoueur.Click, AddressOf ComboBoxJoueur_Click
    End Sub

    Private Sub ComboBoxJoueur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBoxJoueur.KeyPress ' Le joueur ne peut pas mettre de chiffre dans sont nom
        If e.KeyChar <> vbBack AndAlso Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBoxJoueur_TextUpdate(sender As Object, e As EventArgs) Handles ComboBoxJoueur.TextUpdate 'Met le nom du joeur en ProperCase
        sender.Text = StrConv(sender.Text, vbProperCase)
        sender.SelectionStart = sender.Text.Length
    End Sub

    Private Sub ButtonRègle_Click(sender As Object, e As EventArgs) Handles ButtonRègle.Click 'Le form des règles
        Me.Hide()
        Regle.Show()
    End Sub

    Private Sub PictureBoxMusicEnJeu_Click(sender As Object, e As EventArgs) Handles PictureBoxMusicEnJeu.Click 'Coupé ou allumer le son en jeu
        changerEtatMusic()
    End Sub


End Class

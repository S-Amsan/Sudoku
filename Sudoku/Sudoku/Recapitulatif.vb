Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Recapitulatif
    Private JoueurSelectioner As JOUEUR
    Private Sub Recapitulatif_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If getNbJoueurs() > 0 Then ' On rempli la comboxBox, et les deux liste box
            For i = 0 To (getNbJoueurs() - 1)
                ComboBoxNomJoueur.Items.Add(getJoueur(i).nom)
                ListBoxMeilleursTemps.Items.Add(getJoueur(i).meilleurTemps)
                ListBoxNoms_des_joueurs.Items.Add(getJoueur(i).nom)
            Next
            trierOrdreAlphabetique() 'On trie par nom au debut
            ComboBoxNomJoueur.Text = ComboBoxNomJoueur.GetItemText(0)
            JoueurSelectioner = getJoueur(ComboBoxNomJoueur.Text)
        End If
    End Sub

    Private Sub Recapitulatif_FormClosed(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Acceuil.Show()
    End Sub


    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        Me.Close()
        Acceuil.Show()
    End Sub

    Private Sub trierOrdreAlphabetique()
        Dim joueursTries() As JOUEUR = getJoueurs.OrderBy(Function(j) j.nom).ToArray() 'stocke dans une nouvelle liste, la liste trier par nom
        mettreAJourListes(joueursTries)
    End Sub

    Private Sub trierParMeilleurTemps()
        Dim joueursTries() As JOUEUR = getJoueurs.OrderBy(Function(j) j.meilleurTemps).ToArray() 'stocke dans une nouvelle liste, la liste trier par meilleur temps
        mettreAJourListes(joueursTries)
    End Sub

    Private Sub mettreAJourListes(joueurs As JOUEUR())
        'On vide tout
        ComboBoxNomJoueur.Items.Clear()
        ListBoxMeilleursTemps.Items.Clear()
        ListBoxNoms_des_joueurs.Items.Clear()

        For Each joueur As JOUEUR In joueurs 'Et en rerempli dans l'ordre
            ComboBoxNomJoueur.Items.Add(joueur.nom)
            ListBoxMeilleursTemps.Items.Add(If(joueur.meilleurTemps = Integer.MaxValue, "Aucune partie gagnée", tempstoString(joueur.meilleurTemps)))
            ListBoxNoms_des_joueurs.Items.Add(joueur.nom)
        Next

        If ComboBoxNomJoueur.Items.Count > 0 Then 'On selectionne le premier de la liste
            ComboBoxNomJoueur.SelectedIndex = 0
            JoueurSelectioner = getJoueur(ComboBoxNomJoueur.Text)
        End If
    End Sub

    Private Sub ButtonTrierParNom_Click(sender As Object, e As EventArgs) Handles ButtonTrierParNom.Click
        trierOrdreAlphabetique()
        'On affiche le button trier par meilleur temps, et on cache celui la        (Les button sont au meme endroit)
        sender.Visible = False
        sender.Enabled = False
        ButtonTrierParMeilleurTemps.Visible = True
        ButtonTrierParMeilleurTemps.Enabled = True
    End Sub

    Private Sub ButtonTrierParMeilleurTemps_Click(sender As Object, e As EventArgs) Handles ButtonTrierParMeilleurTemps.Click
        trierParMeilleurTemps()
        sender.Visible = False
        sender.Enabled = False
        ButtonTrierParNom.Visible = True
        ButtonTrierParNom.Enabled = True
    End Sub

    Private Sub ButtonAfficher_statistiques_Click(sender As Object, e As EventArgs) Handles ButtonAfficher_statistiques.Click
        If getNbJoueurs() > 0 Then
            afficherStats(JoueurSelectioner)
        Else
            MsgBox("Aucun joueur n'est inscrit")
        End If
    End Sub

    'La combobox et les deux liste box sont lier
    Private Sub Autre_Joueur_Selection(sender As Object, e As EventArgs) Handles ComboBoxNomJoueur.SelectedIndexChanged, ListBoxNoms_des_joueurs.SelectedIndexChanged, ListBoxMeilleursTemps.SelectedIndexChanged
        ComboBoxNomJoueur.SelectedIndex = sender.SelectedIndex
        ListBoxMeilleursTemps.SelectedIndex = sender.SelectedIndex
        ListBoxNoms_des_joueurs.SelectedIndex = sender.SelectedIndex
        JoueurSelectioner = getJoueur(ComboBoxNomJoueur.Text)
    End Sub

End Class
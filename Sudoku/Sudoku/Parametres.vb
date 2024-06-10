Public Class Parametres
    Private joueurActuelle As JOUEUR 'Joueur qui lance la partie
    Private newParametres As PARAM
    Private Sub Parametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'On attribue a nos radio button des tag qui nous permettra de mieux gerer le temps
        HScrollBarDureeMax.Minimum = 1
        HScrollBarDureeMax.Maximum = 59
        HScrollBarDureeMax.Maximum += HScrollBarDureeMax.LargeChange - 1

        RadioButtonAvecIndice.Tag = True
        RadioButtonSansIndice.Tag = False

        'On prefere limité le choix du joueur pour les chiffres a révéler, donc on a que 4 possibilité
        RadioButtonFacile.Tag = 50
        RadioButtonMoyen.Tag = 40
        RadioButtonDifficile.Tag = 35
        RadioButtonExpert.Tag = 24

        joueurActuelle = getJoueur(Acceuil.ComboBoxJoueur.Text) 'On prend le joueur de la comboxBox
        newParametres = getParametres(joueurActuelle.id) 'On prend ses parametres

        'On fait des perform click qui correspond a ses parametres
        For Each difficulté As RadioButton In PanelDifficulté.Controls
            If difficulté.Tag = newParametres.nbChiffresRevele Then
                difficulté.PerformClick()
            End If
        Next

        If newParametres.indiceActive Then
            RadioButtonAvecIndice.PerformClick()
        Else
            RadioButtonSansIndice.PerformClick()
        End If

        'la scrollbar a la meme valeur que les parametre
        HScrollBarDureeMax.Value = newParametres.dureeDeLaPartie \ 60

        If newParametres.dureeDeLaPartie \ 60 = HScrollBarDureeMax.Minimum Then 'Lorsque la valeur est égale au min (n'appelle pas le value change)
            LabelDureeMax.Text = tempstoString(newParametres.dureeDeLaPartie)
            LabelDureeMax.ForeColor = Color.Red
        End If



    End Sub


    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub

    Private Sub ButtonSauvegarder_Click(sender As Object, e As EventArgs) Handles ButtonSauvegarder.Click
        setParametres(joueurActuelle.id, newParametres)
        Partie.actualiserParametres()
        Me.Close()
    End Sub

    Private Sub Parametres_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If newParametres.Equals(getParametres(joueurActuelle.id)) Then 'Si les parametre n'ont pas ete modifie
            Partie.Show()
        ElseIf MsgBox("Voulez-vous partir sans sauvegarder les nouveaux paramètres", vbYesNo) = vbNo Then ' Si il veut partir sans sauvegarder les changement
            e.Cancel = True 'Ne ferme pas la page
        Else
            Partie.Show()
        End If

    End Sub

    'Difficulté change
    Private Sub RadioButtonDifficulte_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFacile.CheckedChanged, RadioButtonMoyen.CheckedChanged, RadioButtonDifficile.CheckedChanged, RadioButtonExpert.CheckedChanged
        newParametres.nbChiffresRevele = sender.Tag
    End Sub
    'Duree de la partie change
    Private Sub HScrollBarTempsMaximun_ValueChanged(sender As Object, e As EventArgs) Handles HScrollBarDureeMax.ValueChanged
        newParametres.dureeDeLaPartie = sender.value * 60
        LabelDureeMax.Text = tempstoString(newParametres.dureeDeLaPartie)
        'Modifie la couleur du label selon le temps 
        Select Case newParametres.dureeDeLaPartie \ 60
            Case 0 To 9 'expert
                LabelDureeMax.ForeColor = Color.Red
            Case 10 To 19 'Difficile
                LabelDureeMax.ForeColor = Color.Orange
            Case 20 To 39 'Moyen
                LabelDureeMax.ForeColor = Color.Yellow
            Case 40 To 59 'Facile
                LabelDureeMax.ForeColor = Color.Chartreuse 'Vert claire
        End Select

    End Sub

    'Indice change
    Private Sub RadioButtonIndice_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonAvecIndice.CheckedChanged, RadioButtonSansIndice.CheckedChanged
        newParametres.indiceActive = sender.Tag
    End Sub


End Class

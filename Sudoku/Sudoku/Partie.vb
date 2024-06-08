Imports System.ComponentModel
Imports System.Xml

Public Class Partie
    Private joueurActuelle As JOUEUR 'Joueur qui lance la partie
    Private textBoxSelectionner As TextBox 'Dernier textBox selectionner par le joueur

    Private partieCommence As Boolean = False 'Indique si la partie a commence
    Private messageAlerte As Boolean = True 'Permets de vérifier si un message d'alerte (MsgBox qui demande une confirmation) doit etre afficher, pour quand on ferme la page
    Private indiceActif As Boolean = False 'Variable pour indiquer si l'indice est actif
    Private musicActif As Boolean 'Indique si le son est actif


    Private tempsRestant As Integer 'Le temps restant avant la fin de la partie pour le joueur
    Private parametresPartie As PARAM 'Les parametre de la partie

    Private grille As Integer(,) ' La grille de 9x9 qui stocke le sudoku
    Private grilleChiffresTrouvee As Integer(,) ' La grille de 9x9 qui stocke les chiffres saisie par le joueur
    Private Const Dimensions As Integer = 9 'les dimensions du sudoku sont de 9x9
    Private nbErreursRestantes As Integer 'Le nombre d'erreurs qu'il lui reste
    Private Const nbErreursMax As Integer = 5 'Le nombre erreurs max qu'il peut faire
    Private listeChiffresTrouvee As String 'Liste des chiffres trouvés (quand tout les il y'a 9 "1" alors tous les "1" sont placés
    Private Const nbChiffres As Integer = 9
    Private nbChiffresTrouves(nbChiffres - 1) As Integer ' Le 0 est exclu ( -1 ), Compte le nombre de chiffre placé

    Private formatStylo As Font = New Font("Calibri", 17) 'Le stylo
    Private formatCrayon As Font = New Font("Calibri", 8) 'Le crayon

    Private Sub Partie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        joueurActuelle = getJoueur(Acceuil.ComboBoxJoueur.Text)

        Dim CouleurCase As Color
        'Ajoute les textbox dans TableLayoutPanel
        For ligne As Integer = 0 To Dimensions - 1
            For colonne As Integer = 0 To Dimensions - 1
                Dim textbox As New TextBox()
                If (ligne \ 3 + colonne \ 3) Mod 2 = 0 Then ' Permets de séparer les régions par couleur (Les régions n'ont pas la même couleur que leur voisine verticale, horizontale)
                    CouleurCase = Color.White
                Else
                    CouleurCase = Color.LightGray
                End If
                ' Defini le style : 
                textbox.BackColor = CouleurCase
                textbox.Tag = CouleurCase
                textbox.Dock = DockStyle.Fill
                textbox.BorderStyle = BorderStyle.None
                ' Defini le format du text :
                textbox.Multiline = True
                textbox.TextAlign = HorizontalAlignment.Center
                textbox.MaxLength = 1
                textbox.Font = formatStylo
                ' Ajoute la textbox dans le formulaire :
                TableLayoutPanelQuadrillage.Controls.Add(textbox, colonne, ligne)
                ' On ajoute des evenements :
                AddHandler textbox.KeyPress, AddressOf Saisie
                AddHandler textbox.MouseClick, AddressOf Click
            Next
        Next

        ' Paramètres du joueurs
        parametresPartie = getParametres(joueurActuelle.id)
        ButtonIndice.Tag = 3 ' Le joueurs possède 3 indices
        ButtonIndice.Text = "Indice x " & ButtonIndice.Tag ' On affiche 
        actualiserParametres() 'L'affichage dans la partie

        ' Action qu'on ne peut pas faire avant le lancement de la partie:
        PanelPartieEnCours.Hide()
        PanelPartieEnCours.Enabled = False

        ' On affecte nos variables, objets
        LabelNomJoueur.Text = joueurActuelle.nom
        textBoxSelectionner = getTextBox(4, 4)
        nbErreursRestantes = nbErreursMax
        listeChiffresTrouvee = "0" ' On considère qu'on a trouvé tous les 0
        LabelChronometre.Text = tempstoString(tempsRestant)
        LabelChiffresPasTrouvé.Font = New Font("Courier New", 12)

        ' On genere le Sudoku
        grille = SudokuGenerator.genererGrilleSudoku(Dimensions)
        ReDim grilleChiffresTrouvee(Dimensions - 1, Dimensions - 1)

        ' On charge les images (vies et son en jeu)
        Dim Id As Integer = 5
        For Each Vie As PictureBox In PanelViesRestantes.Controls
            Vie.Image = My.Resources.Vie
            Vie.Tag = Id 'On met des tag different pour chaque vie, ceux qui nous permettra ensuite de les enlever 1 par 1 en cas d'erreur
            Id -= 1
        Next
        actualiserPictureBoxSon() ' On affiche la bonne image
        actualiserChiffreATrouver() ' On actualise les chiffres a trouver
    End Sub

    'Fermeture du formulaire
    Private Sub Partie_FormClosed(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not partieCommence Then ' Si la partie n'a pas commencé
            Acceuil.Show() 'retour a l'acceuil
        ElseIf messageAlerte Then ' Si le joueur ferme la page manuellement (appuie sur la croix)
            If MsgBox("Si vous fermer la fenetre la partie sera terminée, voulez-vous retourner à l'accueil ?", vbYesNo) = vbYes Then
                proposerSolution()
                e.Cancel = True ' La page ne se ferme pas
            Else
                e.Cancel = True ' La page ne se ferme pas
            End If
        Else
            Acceuil.Show()
        End If
    End Sub

    Private Sub proposerSolution() 'On propose au joueur d'afficher la solution
        messageAlerte = False
        If MsgBox("Voulez-vous voir la solution ?", vbYesNo) = vbYes Then
            Me.Hide()
            Solution.Show()
        Else
            Me.Close()
        End If
    End Sub

    Public Sub arretForceDeLaPartie() ' Losrque que le joueur est en pleine partie et qu'il quitte veut quitter
        Dim TempsDeJeu As Integer = parametresPartie.dureeDeLaPartie - tempsRestant
        messageAlerte = False

        Chronomètre.Stop()
        tempsDeJeuTotalUpdate(joueurActuelle.id, TempsDeJeu)
        proposerSolution()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        If Not partieCommence Then ' Si la partie n'a pas commencé
            Me.Close()
        ElseIf MsgBox("Si vous retournez à l'accueil la partie sera terminée, voulez-vous retourner à l'accueil ?", vbYesNo) = vbYes Then
            arretForceDeLaPartie()
        End If
    End Sub
    Private Sub ButtonAbandonner_Click(sender As Object, e As EventArgs) Handles ButtonAbandonner.Click
        If MsgBox("Êtes-vous sûr de vouloir abandonner ?", vbYesNo) = vbYes Then
            arretForceDeLaPartie()
        End If
    End Sub

    Private Sub PictureBoxMusicEnJeu_Click(sender As Object, e As EventArgs) Handles PictureBoxMusicEnJeu.Click 'Coupé ou allumer le son en jeu
        changerEtatMusic()
    End Sub
    Private Function getTextBox(ligne As Integer, colonne As Integer) As TextBox ' Obtient la TextBox a la position donné
        Return TryCast(TableLayoutPanelQuadrillage.GetControlFromPosition(colonne, ligne), TextBox)
    End Function

    Private Function getPosition(texbox As TextBox) As TableLayoutPanelCellPosition ' Obtient la position de la TextBox dans le sudoku
        Return TableLayoutPanelQuadrillage.GetPositionFromControl(textBoxSelectionner)
    End Function
    Public Function getNbErreursRestantes() As Integer 'getter du nombre erreurs restant du joueur (Pour le forms Pause)
        Return nbErreursRestantes
    End Function

    Public Function getTempsRestant() As Integer 'getter du temps qu'il lui reste pour finir (Pour le forms Pause)
        Return tempsRestant
    End Function

    Public Function getGrilleChiffresTrouvee() As Integer(,)
        Return grilleChiffresTrouvee
    End Function

    Public Function getGrille() As Integer(,)
        Return grille
    End Function

    'Parametres de la Partie
    Private Sub ButtonParamètres_Click(sender As Object, e As EventArgs) Handles ButtonParamètres.Click 'Accede au form parametres
        Me.Hide()
        Parametres.Show()
    End Sub
    Public Sub actualiserParametres() ' On actualise les labels, selon les parametres du joueur
        parametresPartie = getParametres(joueurActuelle.id)
        tempsRestant = parametresPartie.dureeDeLaPartie
        LabelChronometre.Text = tempstoString(tempsRestant)
    End Sub


    'Pendant le jeu : (Les fonction principaux au début)
    Private Sub ButtonLancer_Click(sender As Object, e As EventArgs) Handles ButtonLancer.Click
        ' Affiche au joueur le sudoku
        afficherSudoku(parametresPartie.nbChiffresRevele)
        ' Affiche le timer :
        LabelChronometre.Text = tempstoString(tempsRestant)
        Chronomètre.Start()
        ' Option qu'il ne peut plus faire
        ButtonParamètres.Enabled = False
        ButtonLancer.Enabled = False
        ButtonLancer.Hide()
        partieCommence = True 'La partie a commence
        ' Option qu'il peut désormais faire
        TableLayoutPanelQuadrillage.Enabled = True 'Le sudoku est visible
        PanelPartieEnCours.Show()
        PanelPartieEnCours.Enabled = True
        If Not parametresPartie.indiceActive Then
            ButtonIndice.Hide()
            ButtonIndice.Enabled = False
        End If

        ' Simule un click sur la texbox
        Click(textBoxSelectionner, EventArgs.Empty)
        'Le joueur a le stylo en main
        RadioButtonStylo.PerformClick()
    End Sub

    Private Sub ButtonIndice_Click(sender As Object, e As EventArgs) Handles ButtonIndice.Click 'L'utilisation d'un indice
        indiceActif = Not indiceActif 'Inverse la valeur du boolean, permet au joueur d'annuler l'indice
        If indiceActif AndAlso sender.Tag > 0 Then
            sender.ForeColor = Color.Gold
            sender.BackColor = Color.Yellow
        ElseIf sender.Tag > 0 Then
            ButtonIndice.ForeColor = Color.Gray
            ButtonIndice.BackColor = Color.LightGray
        Else
            MsgBox("Vous n'avez plus d'indice")
            indiceActif = False
        End If
    End Sub
    Private Sub ButtonPause_Click(sender As Object, e As EventArgs) Handles ButtonPause.Click ' Met en pause le jeu 
        Me.Hide()
        Pause.Show()
        Chronomètre.Stop()
    End Sub

    Private Sub Click(sender As Object, e As EventArgs) ' Met en couleur la ligne, la colonne, et la région où le joueur a clicker
        decolorier()
        textBoxSelectionner = DirectCast(sender, TextBox)
        Dim position = getPosition(textBoxSelectionner)
        Dim DebutLigneRegion As Integer = (position.Row \ 3) * 3
        Dim DebutColonneRegion As Integer = (position.Column \ 3) * 3

        If textBoxSelectionner.Text = "" Then ' Si la texbox est vide alors on modifie sont format (permet au curseur de s'adapter au mode)
            If RadioButtonStylo.Checked Then
                textBoxSelectionner.Font = formatStylo
            Else
                textBoxSelectionner.Font = formatCrayon
            End If
        End If

        'Ligne et colonne
        For posxy As Integer = 0 To Dimensions - 1
            getTextBox(posxy, position.Column).BackColor = Color.LightSkyBlue
            getTextBox(position.Row, posxy).BackColor = Color.LightSkyBlue

        Next
        'Region
        For ligne As Integer = DebutLigneRegion To DebutLigneRegion + 2
            For colonne As Integer = DebutColonneRegion To DebutColonneRegion + 2
                getTextBox(ligne, colonne).BackColor = Color.LightSkyBlue
            Next
        Next

        If grilleChiffresTrouvee(position.Row, position.Column) <> 0 Then 'Si il contient un chiffre valide, évite de colorier les notes
            colorier(textBoxSelectionner.Text)
        End If

        If indiceActif AndAlso grilleChiffresTrouvee(position.Row, position.Column) = 0 Then 'Revele la case si l'indice est activé et que la case ne contient pas deja un chiffre valide
            Dim reponse As Integer = grille(position.Row, position.Column)
            grilleChiffresTrouvee(position.Row, position.Column) = reponse
            textBoxSelectionner.Text = reponse.ToString()
            textBoxSelectionner.Font = formatStylo
            textBoxSelectionner.ReadOnly = True ' La TextBox ne peut plus être modifiée
            nbChiffresTrouves(reponse - 1) += 1 ' Augmente le compteur
            actualiserChiffreATrouver()
            retirerNoteCrayon(reponse.ToString())
            colorier(reponse)
            textBoxSelectionner.BackColor = Color.Yellow
            ButtonIndice.Tag -= 1
            ButtonIndice.Text = "Indice x " & ButtonIndice.Tag
            'On remet les couleur d'avant
            ButtonIndice.ForeColor = Color.Gray
            ButtonIndice.BackColor = Color.LightGray

            If sudokuRempli() Then ' Si le joueur a complété le Sudoku
                victoire()
            End If
            indiceActif = False ' Désactive l'indice après utilisation
        End If
    End Sub
    Private Sub Saisie(sender As Object, e As KeyPressEventArgs) 'Lorsque le joueur saisie quelque chose dans une casse
        Click(sender, EventArgs.Empty) 'Simule un click ( lorsque le joueur reste sur la textbox apres une erreur)
        Dim textBox As TextBox = DirectCast(sender, TextBox)
        Dim position = getPosition(textBox)
        Dim chiffreSaisie As String = e.KeyChar.ToString()

        If chiffreSaisie <> vbBack AndAlso (Not Char.IsDigit(chiffreSaisie) OrElse listeChiffresTrouvee.Contains(chiffreSaisie)) Then ' Autres que les chiffres (0 exclu ainsi que les chiffre trouvé, 7 est trouvé quand y'en a 9 sur le sudoku)
            e.Handled = True
            Exit Sub
        End If
        If e.KeyChar = vbBack AndAlso grilleChiffresTrouvee(position.Row, position.Column) = 0 Then 'Peut supprimer seulement si il y'a des notes au crayon (grilleChiffresTrouvee = 0, veut dire qu'il a pas trouverContient un chiffre bien placé)
            Exit Sub
        End If
        ' Mode Stylo
        If RadioButtonStylo.Checked AndAlso grilleChiffresTrouvee(position.Row, position.Column) = 0 Then 'Si le joueur n'as pas trouve de chiffre
            If Not chiffreValide(e.KeyChar) Then ' Si le joueur se trompe
                e.Handled = True
                perdUneVie()
                Exit Sub
            End If
            ' Tout est correct, Permet d'écrire par-dessus les notes au crayon
            textBox.Text = chiffreSaisie
            textBox.Font = formatStylo
            textBox.MaxLength = 1
            textBox.SelectionStart = chiffreSaisie.Length
            textBox.ReadOnly = True ' La textBox ne peut plus être modifié
            grilleChiffresTrouvee(position.Row, position.Column) = grille(position.Row, position.Column)
            colorier(chiffreSaisie)
            If sudokuRempli() Then 'Vérifie si le joueur a remplie le sudoku
                victoire()
            End If
            e.Handled = True ' La saisie a déja été ajouté dans la fonction (Ajoute 2 fois sinon)
            Exit Sub
        End If
        'Mode Crayon
        If grilleChiffresTrouvee(position.Row, position.Column) = 0 AndAlso chiffrePasDejaDans(chiffreSaisie, textBox.Text) Then
            textBox.MaxLength = 7
            textBox.Font = formatCrayon
            textBox.Text = ordreCroissant(chiffreSaisie, textBox.Text)
            textBox.SelectionStart = textBox.Text.Length
            e.Handled = True ' La saisie a été ajouté dans la fonction (Ajoute 2 fois sinon)
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub Chronomètre_Tick(sender As Object, e As EventArgs) Handles Chronomètre.Tick ' Le Timer de la partie
        If tempsRestant > 0 Then
            If tempsRestant = 60 Then 'Quand il reste 1 minute le temps est affiché en rouge!!!!
                LabelChronometre.ForeColor = Color.Red
            End If
            tempsRestant -= 1
            LabelChronometre.Text = tempstoString(tempsRestant) ' Affiche le temps restant 
        Else
            Chronomètre.Stop()
            defaite("Le temps est écoulé!") 'Quand le joueur perd !!! :(
        End If
    End Sub

    Private Sub afficherSudoku(nbChiffreRevele As Integer) 'Dévoile le sudoku
        ' Masquer certaines cellules pour créer une grille partiellement remplie
        Dim grilleMasquee As Integer(,) = SudokuMasker.masquerGrille(grille, nbChiffreRevele)
        ' Afficher la grille de Sudoku dans les TextBox appropriés
        For ligne As Integer = 0 To Dimensions - 1
            For colonne As Integer = 0 To Dimensions - 1
                Dim textBox As TextBox = getTextBox(ligne, colonne)
                Dim Chiffre As String = grilleMasquee(ligne, colonne)
                If Chiffre <> 0 Then
                    textBox.Text = grilleMasquee(ligne, colonne).ToString()
                    nbChiffresTrouves(Chiffre - 1) += 1 ' Augmente le compteur

                    actualiserChiffreATrouver()
                    textBox.ReadOnly = True 'Le joueur ne peut plus ecrire mais peut toujours clicker
                End If
            Next
        Next
        grilleChiffresTrouvee = grilleMasquee
    End Sub
    Private Function chiffreValide(chiffre As String) As Boolean 'Le chiffre est a la bonne position = True , sinon colorie les erreurs
        Dim position = getPosition(textBoxSelectionner) 'On obtient la position de la textbox

        If grille(position.Row, position.Column) <> chiffre Then 'On vérifie avec la grille si le chiffre est bien placé
            colorierErreur(chiffre)
            Return False
        End If
        nbChiffresTrouves(chiffre - 1) += 1 ' Augmente le compteur
        actualiserChiffreATrouver()
        retirerNoteCrayon(chiffre) 'On retire les notes qui ne sert a rien
        Return True
    End Function

    Private Sub colorierErreur(chiffre As String) ' Met en evidence les erreurs du joueur, celle qui sont visible
        Dim position = getPosition(textBoxSelectionner)
        ' Position de la region de la Textbox
        Dim debutLigneRegion As Integer = (position.Row \ 3) * 3
        Dim debutColonneRegion As Integer = (position.Column \ 3) * 3
        Dim nbTextBoxColorie As Integer = 0
        For posxy As Integer = 0 To Dimensions - 1
            Dim textboxMemeLigne As TextBox = getTextBox(posxy, position.Column)
            Dim textboxMemeColonne As TextBox = getTextBox(position.Row, posxy)

            ' Si la grille des chiffres trouvé est differente de 0, (Ne prend pas en compte les note au crayon)
            If grilleChiffresTrouvee(posxy, position.Column) <> 0 AndAlso textboxMemeLigne.Text = chiffre Then 'Si il y'a un chiffre dans la meme ligne
                textboxMemeLigne.BackColor = Color.OrangeRed
                nbTextBoxColorie += 1
            End If
            If grilleChiffresTrouvee(position.Row, posxy) <> 0 AndAlso textboxMemeColonne.Text = chiffre Then 'Si il y'a un chiffre dans la meme colonne
                textboxMemeColonne.BackColor = Color.OrangeRed
                nbTextBoxColorie += 1
            End If
        Next
        For ligne As Integer = debutLigneRegion To debutLigneRegion + 2
            For colonne As Integer = debutColonneRegion To debutColonneRegion + 2
                Dim textboxMemeRegion As TextBox = getTextBox(ligne, colonne)

                If grilleChiffresTrouvee(ligne, colonne) <> 0 AndAlso textboxMemeRegion.Text = chiffre Then 'Si il y'a un chiffre dans la meme region
                    textboxMemeRegion.BackColor = Color.OrangeRed
                    nbTextBoxColorie += 1
                End If
            Next
        Next
        If nbTextBoxColorie = 0 Then ' Si l'erreur n'est pas visible on colorie la textbox où il se trouve
            textBoxSelectionner.BackColor = Color.OrangeRed
        End If

    End Sub

    Private Sub colorier(chiffre As String) 'Colorie à Rose dans le sudoku les chiffres qui sont égaux au chiffre en paramètre
        For ligne As Integer = 0 To Dimensions - 1
            For colonne As Integer = 0 To Dimensions - 1
                Dim textbox As TextBox = getTextBox(ligne, colonne)
                'de ne pas prendre en compte les notes au crayon
                If grilleChiffresTrouvee(ligne, colonne) <> 0 AndAlso textbox.Text = chiffre Then
                    textbox.BackColor = Color.LightPink
                End If
            Next
        Next
    End Sub
    Private Sub decolorier() 'Remet les couleurs par defaut (Inverse de colorier)
        For ligne As Integer = 0 To Dimensions - 1
            For colonne As Integer = 0 To Dimensions - 1
                Dim textbox As TextBox = getTextBox(ligne, colonne)
                textbox.BackColor = textbox.Tag
            Next
        Next
    End Sub


    Private Sub retirerNoteCrayon(Chiffre As String) ' Retire les notes au crayon qui sont égaux au chiffre saisie dans la meme ligne,colonne et région
        Dim position = getPosition(textBoxSelectionner)
        Dim DebutLigneRegion As Integer = (position.Row \ 3) * 3
        Dim DebutColonneRegion As Integer = (position.Column \ 3) * 3

        For posxy As Integer = 0 To Dimensions - 1
            Dim textboxMemeLigne As TextBox = getTextBox(posxy, position.Column)
            Dim textboxMemeColonne As TextBox = getTextBox(position.Row, posxy)

            ' On regarde dans la grille si le joueurs a trouvé un chiffre (prend que les notes au crayon)
            If grilleChiffresTrouvee(posxy, position.Column) = 0 AndAlso textboxMemeLigne.Text.Contains(Chiffre) Then 'Si il y'a un chiffre dans la meme ligne
                textboxMemeLigne.Text = textboxMemeLigne.Text.Replace(Chiffre, "") 'On l'enleve
            End If
            If grilleChiffresTrouvee(position.Row, posxy) = 0 AndAlso textboxMemeColonne.Text.Contains(Chiffre) Then 'Si il y'a un chiffre dans la meme colonne
                textboxMemeColonne.Text = textboxMemeColonne.Text.Replace(Chiffre, "")
            End If
        Next

        For ligne As Integer = DebutLigneRegion To DebutLigneRegion + 2
            For colonne As Integer = DebutColonneRegion To DebutColonneRegion + 2
                Dim textboxMemeRegion As TextBox = getTextBox(ligne, colonne)

                If grilleChiffresTrouvee(ligne, colonne) = 0 AndAlso textboxMemeRegion.Text.Contains(Chiffre) Then 'Si il y'a un chiffre dans la meme region
                    textboxMemeRegion.Text = textboxMemeRegion.Text.Replace(Chiffre, "")
                End If
            Next
        Next

    End Sub


    Private Sub actualiserChiffreATrouver() 'Actualise le Label qui permet de voir quel chiffre n'a pas été placés 9 fois, permet au joueur de voir quel chiffre il lui reste placé
        LabelChiffresPasTrouvé.Text = ""
        For i = 1 To 9
            If nbChiffresTrouves(i - 1) = 9 Then
                listeChiffresTrouvee &= i ' Ajoute si il y'en a 9
            End If

            If Not listeChiffresTrouvee.Contains(i) Then
                LabelChiffresPasTrouvé.Text &= i & Space(1)
            Else
                LabelChiffresPasTrouvé.Text &= Space(2)

            End If
            If i Mod 3 = 0 Then 'On saute a la ligne tous les 3 chiffre
                LabelChiffresPasTrouvé.Text &= vbCrLf
            End If
        Next
    End Sub

    Private Sub victoire() ' Lorsque le joueur gagne la partie
        Chronomètre.Stop()
        Dim tempsDeJeu As Integer = parametresPartie.dureeDeLaPartie - tempsRestant
        Dim tempsDeJeuToString As String = tempstoString(tempsDeJeu.ToString)
        messageAlerte = False
        tempsDeJeuTotalUpdate(joueurActuelle.id, tempsDeJeu)
        meilleurTempsUpdate(joueurActuelle.id, tempsDeJeu)
        Me.Close()
        Acceuil.Show()
    End Sub

    Private Sub defaite(MessageDeDefaite As String) ' Lorsque le joueur perd la partie
        Chronomètre.Stop()
        messageAlerte = False
        Dim tempsDeJeu As Integer = parametresPartie.dureeDeLaPartie - tempsRestant
        MsgBox(MessageDeDefaite)
        tempsDeJeuTotalUpdate(joueurActuelle.id, tempsDeJeu)
        If MsgBox("Voulez-vous voir la solution ?", vbYesNo) = vbYes Then
            Me.Hide()
            Solution.Show()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub perdUneVie() ' Enleve un vie au joueur
        For Each vie As PictureBox In PanelViesRestantes.Controls
            If vie.Tag = nbErreursRestantes Then
                vie.Hide() 'Enleve une vie de l'ecran
            End If
        Next
        nbErreursRestantes -= 1 ' Enlever une vie

        If nbErreursRestantes = 0 Then ' Si le joueur n'a plus de vie
            defaite("Vous n'avez plus de vies")
        End If
    End Sub
    Private Function sudokuRempli() As Boolean ' Fonction qui verifie si toutes les textBox sont remplie
        For ligne As Integer = 0 To Dimensions - 1
            For colonne As Integer = 0 To Dimensions - 1
                If grilleChiffresTrouvee(ligne, colonne) = 0 Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

End Class
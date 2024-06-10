Imports System.Security.Principal

Module ModuleSudoku

    'Les joueurs:
    Private tabJoueur() As JOUEUR ' Tableau de joueurs
    Private nbJoueurs As Integer = 0 ' Nombre de joueurs enregistré
    Private Const PAS As Integer = 5 ' le pas, de quelle taille on augmente le tableau de joueurs

    Public Structure JOUEUR 'Structure du joueur
        Dim id As Integer
        Dim nom As String
        Dim nbPartiesJouees As Integer
        Dim meilleurTemps As Integer ' Le plus cours temps qu'il a pris pour finir une partie
        Dim tempsDeJeuTotal As Integer ' Son temps de jeu total (pendant les parties)
        Dim parametresPerso As PARAM ' Sauvegarde ses paramètres (évite aux joueurs de toujours rentrer ses paramètres favoris)
    End Structure
    Public Function getNbJoueurs() As Integer ' Obtient le nombre de joueurs enregistré
        Return nbJoueurs
    End Function
    Public Function getJoueurs() As JOUEUR() ' Obtient le tableau des joueurs
        Return tabJoueur.Take(nbJoueurs).ToArray()
    End Function
    Public Function getJoueur(id As Integer) As JOUEUR ' Obtient le joueur correspondant a l'id
        Return tabJoueur(id)
    End Function
    Public Function getJoueur(nom As String) As JOUEUR ' Obtient le joueur correspondant au nom, le creer si il n'est pas enregistree
        For Each joueurEnregistré As JOUEUR In tabJoueur
            If joueurEnregistré.nom = nom Then
                Return joueurEnregistré
            End If
        Next
        ' Ajoute le joueur et le renvoie : 
        Dim newJoueur As JOUEUR = creerJoueur(nom)
        ajouterJoueur(newJoueur)
        Return newJoueur
    End Function

    Private Function creerJoueur(nom As String) As JOUEUR 'Return un nouveau joueur, avec le nom
        Dim NewJoueur As New JOUEUR
        NewJoueur.nom = nom
        NewJoueur.id = nbJoueurs
        NewJoueur.meilleurTemps = Integer.MaxValue
        NewJoueur.parametresPerso = New PARAM With {.nbChiffresRevele = nbChiffresReveleDefault, .dureeDeLaPartie = dureeDeLaPartieDefault, .indiceActive = indiceActiveDefault}
        Return NewJoueur
    End Function

    Public Sub ajouterJoueur(newJoueur As JOUEUR) ' Ajoute le joueur
        If nbJoueurs >= UBound(tabJoueur) Then ReDim Preserve tabJoueur(UBound(tabJoueur) + PAS) ' Augmente la taille du tableau
        tabJoueur(nbJoueurs) = newJoueur
        Acceuil.ComboBoxJoueur.Items.Add(tabJoueur(nbJoueurs).nom) ' On l'ajoute dans la comboBox de l'acceuil
        nbJoueurs += 1
    End Sub

    Public Sub tempsDeJeuTotalUpdate(id As Integer, temps As Integer) ' Ajoute au joueur (id) le temps qu'il a jouee (temps)
        tabJoueur(id).tempsDeJeuTotal += temps
        tabJoueur(id).nbPartiesJouees += 1 'augmente son nombre de partie jouee
    End Sub

    Public Sub meilleurTempsUpdate(id As Integer, temps As Integer) ' Nouveau meilleur temps? (temps) du joueur (id)
        If temps < tabJoueur(id).meilleurTemps Then 'S'il bat son record, ou qu'il en a pas
            MsgBox("Felicitation vous avez complété le sudoku en " & tempstoString(temps) & vbCrLf & "Vous avez établi un nouveau record !")
            tabJoueur(id).meilleurTemps = temps
        Else
            MsgBox("Felicitation vous avez complété le sudoku en " & tempstoString(temps))
        End If


    End Sub

    Private Function toString(joueur As JOUEUR) As String
        Dim s As String = ""

        s &= "Nom : " & joueur.nom & vbCrLf
        s &= "Nombre de parties jouées : " & joueur.nbPartiesJouees & vbCrLf
        If joueur.meilleurTemps = Integer.MaxValue Then
            s &= "Meilleur Temps : Aucune partie gagnée" & vbCrLf
        Else
            s &= "Meilleur temps : " & tempstoString(joueur.meilleurTemps) & vbCrLf
        End If

        If joueur.nbPartiesJouees = 0 Then
            s &= "Temps de jeu total : Aucune partie jouée" & vbCrLf
        Else
            s &= "Temps de jeu total : " & tempstoString(joueur.tempsDeJeuTotal) & vbCrLf
        End If

        Return s
    End Function

    Sub afficherStats(joueur As JOUEUR) ' Affiche les statistiques du joueur
        MsgBox(toString(joueur))
    End Sub

    'Les parametres du joueur (Pendant une partie de sudoku):
    ' (les paramètres par default)
    Public Const nbChiffresReveleDefault As Integer = 50 ' Difficulté facile
    Public Const dureeDeLaPartieDefault As Integer = 20 * 60 '20 minutes
    Public Const indiceActiveDefault As Boolean = True ' incice active

    Public Structure PARAM 'Structure des parametres
        Dim nbChiffresRevele As Integer ' Le nombre de chiffre dévoiler au lancement de la partie
        Dim dureeDeLaPartie As Integer ' La duree de la partie (temps pour résoudre le sudoku)
        Dim indiceActive As Boolean ' Si les indices sont activé
    End Structure

    Public Function getParametres(id As Integer) As PARAM 'Obtient les parametres perso du joueur grace a son id
        Return tabJoueur(id).parametresPerso
    End Function

    Public Sub setParametres(id As Integer, newParametres As PARAM) 'Modifie les parametres perso du joueur grace a son id et les nouveaux parametres donné
        tabJoueur(id).parametresPerso = newParametres
    End Sub


    'Pendant la partie de sudoku:
    Public Function chiffrePasDejaDans(Chiffre As String, ListeDeChiffre As String) As Boolean ' Les notes au crayon, permet d'éviter de mettre deux fois le même chiffre
        Return Not ListeDeChiffre.Contains(Chiffre)
    End Function

    Public Function ordreCroissant(Chiffre As String, ListeDeChiffre As String) As String ' Met dans l'ordre croissant les notes au crayon
        Dim s As String = ""
        ListeDeChiffre &= Chiffre

        For i = 1 To 9 ' Les chiffres de 1 à 9
            If ListeDeChiffre.Contains(i) Then
                s &= i
            End If

            If s.Length = 3 Then
                ' Insérer un retour à la ligne après le troisième chiffre
                s = s.Insert(3, vbCrLf)
            End If
        Next
        Return s
    End Function


    'L'affichage du temps:
    Public Function tempstoString(temps As Integer) As String 'Convertie les secondes donné en minutes, secondes, et dans le format '59min:59sec'
        Return String.Format("{0:00}min:{1:00}sec", (temps \ 60), (temps Mod 60))
    End Function


    'La music:
    Private musicActif As Boolean = True ' Boolean qui indique si la music est actif ou pas :

    Public Sub changerEtatMusic() ' Inverse l'état du son (coupe le son ou active le son)
        musicActif = Not musicActif
        playOrStopMusic() ' Fonction qui s'occupe du son
        actualiserPictureBoxSon() ' On actualise les images qui indique l'etat de la music
    End Sub

    Public Sub playOrStopMusic() ' Démarre le son ou le coupe selon le boolean MusicActif
        If musicActif Then 'Si la music est Actif
            My.Computer.Audio.Play(My.Resources.One_Piece_We_Are__Instrumental, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Public Sub actualiserPictureBoxSon() ' Actualise les images
        If musicActif Then 'Si la music est Actif
            Acceuil.PictureBoxMusicEnJeu.Image = My.Resources.SonActif
            Partie.PictureBoxMusicEnJeu.Image = My.Resources.SonActif
        Else
            Acceuil.PictureBoxMusicEnJeu.Image = My.Resources.SonCoupé
            Partie.PictureBoxMusicEnJeu.Image = My.Resources.SonCoupé
        End If
    End Sub

    'Permet d'avoir des panels transparents
    Public Class FormLisible '
        Inherits Form
        Protected Overrides ReadOnly Property CreateParams As CreateParams
            Get
                Dim crp As CreateParams = MyBase.CreateParams
                crp.ExStyle = crp.ExStyle Or &H20
                Return crp
            End Get
        End Property
    End Class

    'Le Main:
    Sub Main()
        ReDim tabJoueur(0)
        ModuleSauvegarde.chargerJoueurSauvegarder() 'On charge les joueurs qu'on a sauvegarder (fichier)
        Application.Run(Acceuil)
        ModuleSauvegarde.sauvegarderJoueurs() 'On sauvegarde les joueurs (fichier)
        Application.Exit()
    End Sub

End Module

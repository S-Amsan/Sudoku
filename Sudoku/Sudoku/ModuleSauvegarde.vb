Imports System.IO
Module ModuleSauvegarde
    Private filePath As String = Path.Combine(Application.StartupPath, "Joueurs.csv") 'La où est stocker les données

    Public Sub sauvegarderJoueurs() 'Sauvegarde tous les joueurs
        For Each j As JOUEUR In getJoueurs()
            sauvegarderJoueur(j)
        Next
    End Sub

    Public Sub sauvegarderJoueur(j As JOUEUR) 'Sauvegarde le joueur en parametres, son id + 1 correspond à la ligne
        ecrireValeur(j.id + 1, 1, j.id)
        ecrireValeur(j.id + 1, 2, j.nom)
        ecrireValeur(j.id + 1, 3, j.nbPartiesJouees)
        ecrireValeur(j.id + 1, 4, j.meilleurTemps)
        ecrireValeur(j.id + 1, 5, j.tempsDeJeuTotal)
        ecrireValeur(j.id + 1, 6, j.parametresPerso.nbChiffresRevele)
        ecrireValeur(j.id + 1, 7, j.parametresPerso.dureeDeLaPartie)
        ecrireValeur(j.id + 1, 8, j.parametresPerso.indiceActive)
    End Sub

    Private Function GetJoueurSauvegarde(id As Integer) As JOUEUR 'Obtient a partir de l'id la sauvegarde du joueur
        Dim JoueurSauvegarder As New JOUEUR With {
            .id = lireValeur(id, 1),
            .nom = lireValeur(id, 2),
            .nbPartiesJouees = lireValeur(id, 3),
            .meilleurTemps = lireValeur(id, 4),
            .tempsDeJeuTotal = lireValeur(id, 5),
            .parametresPerso = New PARAM With {.nbChiffresRevele = lireValeur(id, 6), .dureeDeLaPartie = lireValeur(id, 7), .indiceActive = lireValeur(id, 8)}
        }
        Return JoueurSauvegarder
    End Function

    Public Sub chargerJoueurSauvegarder() ' Charge les joueurs sauvegarder
        Dim id As Integer = 1
        While (Not lireValeur(id, 1) = "")
            ajouterJoueur(GetJoueurSauvegarde(id))
            id += 1
        End While
    End Sub



    Public Sub ecrireValeur(ligne As Integer, colonne As Integer, valeur As String) 'ecrit dans le excel
        Dim lignes As List(Of String) = File.ReadAllLines(filePath).ToList()

        ' Si la ligne n'existe pas, ajouter des lignes vides
        While lignes.Count < ligne
            lignes.Add(New String(","c, colonne - 1))
        End While

        Dim cellules As String() = lignes(ligne - 1).Split(","c)

        ' Si la colonne n'existe pas, ajouter des colonnes vides
        While cellules.Length < colonne
            ReDim Preserve cellules(colonne - 1)
        End While

        cellules(colonne - 1) = valeur
        lignes(ligne - 1) = String.Join(",", cellules)

        File.WriteAllLines(filePath, lignes)
    End Sub

    ' Lire une valeur d'une cellule spécifique
    Public Function lireValeur(ligne As Integer, colonne As Integer) As String 'Lit dans le excel
        Dim lignes As String() = File.ReadAllLines(filePath)

        If lignes.Length >= ligne Then
            Dim cellules As String() = lignes(ligne - 1).Split(","c)
            If cellules.Length >= colonne Then
                Return cellules(colonne - 1)
            End If
        End If

        Return String.Empty
    End Function


End Module

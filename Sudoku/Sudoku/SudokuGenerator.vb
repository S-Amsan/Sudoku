Module SudokuGenerator 'Ce module n'a pas été fait par nous en raison de son algorithme trop complexe.
    'On a quand même modifié certaines choses (les noms des fonctions, des variables et des nombres magiques!!!). 

    Private rand As New Random()

    Public Function genererGrilleSudoku(Dimensions As Integer) As Integer(,)
        Dim grille(Dimensions - 1, Dimensions - 1) As Integer
        remplirGrille(grille)
        Return grille
    End Function

    Private Function estBienPlacer(grille(,) As Integer, ligne As Integer, colonne As Integer, chiffre As Integer) As Boolean
        For posxy As Integer = 0 To grille.GetLength(0) - 1
            If grille(ligne, posxy) = chiffre Or grille(posxy, colonne) = chiffre Then
                Return False
            End If
        Next

        Dim debutLigne As Integer = ligne - ligne Mod 3
        Dim debutColonne As Integer = colonne - colonne Mod 3

        For i As Integer = 0 To 2
            For j As Integer = 0 To 2
                If grille(i + debutLigne, j + debutColonne) = chiffre Then
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Private Function remplirGrille(ByRef grille(,) As Integer) As Boolean
        Dim ligne As Integer = -1
        Dim colonne As Integer = -1
        Dim estVide As Boolean = True
        For x As Integer = 0 To grille.GetLength(0) - 1
            For y As Integer = 0 To grille.GetLength(1) - 1
                If grille(x, y) = 0 Then
                    ligne = x
                    colonne = y
                    estVide = False
                    Exit For
                End If
            Next
            If Not estVide Then
                Exit For
            End If
        Next

        If estVide Then
            Return True
        End If

        Dim chiffres As List(Of Integer) = Enumerable.Range(1, grille.GetLength(0)).OrderBy(Function(n) rand.Next()).ToList()

        For Each chiffre As Integer In chiffres
            If estBienPlacer(grille, ligne, colonne, chiffre) Then
                grille(ligne, colonne) = chiffre
                If remplirGrille(grille) Then
                    Return True
                End If
                grille(ligne, colonne) = 0
            End If
        Next
        Return False
    End Function

End Module
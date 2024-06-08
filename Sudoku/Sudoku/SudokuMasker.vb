Module SudokuMasker 'Ce module n'a pas été fait par nous en raison de son algorithme trop complexe.
    'On a quand même modifié certaines choses (les noms des fonctions, des variables et des nombres magiques!!!). 

    Private rand As New Random()

    Public Function masquerGrille(grille(,) As Integer, nbChiffresRevele As Integer) As Integer(,)
        Dim grilleMasquee(grille.GetLength(0) - 1, grille.GetLength(1) - 1) As Integer
        Array.Copy(grille, grilleMasquee, grille.Length)

        Dim nbChiffresMasquer As Integer = grille.Length - nbChiffresRevele

        While nbChiffresMasquer > 0
            Dim ligne As Integer = rand.Next(0, grille.GetLength(0))
            Dim colonne As Integer = rand.Next(0, grille.GetLength(1))

            If grilleMasquee(ligne, colonne) <> 0 Then
                grilleMasquee(ligne, colonne) = 0
                nbChiffresMasquer -= 1
            End If
        End While

        Return grilleMasquee
    End Function

End Module

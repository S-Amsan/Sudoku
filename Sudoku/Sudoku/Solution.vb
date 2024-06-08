Public Class Solution
    Private Const Dimensions As Integer = 9 'les dimensions du sudoku sont de 9x9
    Private formatStylo As Font = New Font("Calibri", 17) 'Le stylo

    Private Sub Solution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CouleurCase As Color

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
                textbox.Dock = DockStyle.Fill
                textbox.BorderStyle = BorderStyle.None
                textbox.Multiline = True
                textbox.TextAlign = HorizontalAlignment.Center
                textbox.MaxLength = 1
                textbox.Font = formatStylo
                ' Ajoute la textbox dans le formulaire :
                TableLayoutPanelQuadrillage.Controls.Add(textbox, colonne, ligne)
            Next
        Next

        afficherSolution()

    End Sub
    Private Function getTextBox(ligne As Integer, colonne As Integer) As TextBox ' Obtient la TextBox a la position donné
        Return TryCast(TableLayoutPanelQuadrillage.GetControlFromPosition(colonne, ligne), TextBox)
    End Function

    Private Sub afficherSolution()
        Dim grille As Integer(,) = Partie.getGrille()
        Dim grilleChiffresTrouvee As Integer(,) = Partie.getGrilleChiffresTrouvee()
        For ligne As Integer = 0 To Dimensions - 1
            For colonne As Integer = 0 To Dimensions - 1
                Dim textbox = getTextBox(ligne, colonne)
                textbox.Text = grille(ligne, colonne)
                If grilleChiffresTrouvee(ligne, colonne) = 0 Then
                    textbox.BackColor = Color.Yellow
                End If
            Next
        Next
    End Sub


    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()

    End Sub

    'Fermeture du formulaire
    Private Sub Solution_FormClosed(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Partie.Close()
        Acceuil.Show()
    End Sub


End Class
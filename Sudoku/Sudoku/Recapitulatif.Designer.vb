<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Recapitulatif
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.LabelTableau_des_scores = New System.Windows.Forms.Label()
        Me.ButtonAfficher_statistiques = New System.Windows.Forms.Button()
        Me.ComboBoxNomJoueur = New System.Windows.Forms.ComboBox()
        Me.ListBoxMeilleursTemps = New System.Windows.Forms.ListBox()
        Me.ListBoxNoms_des_joueurs = New System.Windows.Forms.ListBox()
        Me.ButtonTrierParNom = New System.Windows.Forms.Button()
        Me.ButtonTrierParMeilleurTemps = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRetour.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonRetour.Location = New System.Drawing.Point(29, 429)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(51, 23)
        Me.ButtonRetour.TabIndex = 103
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'LabelTableau_des_scores
        '
        Me.LabelTableau_des_scores.AutoSize = True
        Me.LabelTableau_des_scores.Font = New System.Drawing.Font("MV Boli", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTableau_des_scores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelTableau_des_scores.Location = New System.Drawing.Point(14, 9)
        Me.LabelTableau_des_scores.Name = "LabelTableau_des_scores"
        Me.LabelTableau_des_scores.Size = New System.Drawing.Size(456, 63)
        Me.LabelTableau_des_scores.TabIndex = 102
        Me.LabelTableau_des_scores.Text = "Tableau des scores"
        '
        'ButtonAfficher_statistiques
        '
        Me.ButtonAfficher_statistiques.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonAfficher_statistiques.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAfficher_statistiques.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonAfficher_statistiques.Location = New System.Drawing.Point(318, 429)
        Me.ButtonAfficher_statistiques.Name = "ButtonAfficher_statistiques"
        Me.ButtonAfficher_statistiques.Size = New System.Drawing.Size(131, 23)
        Me.ButtonAfficher_statistiques.TabIndex = 101
        Me.ButtonAfficher_statistiques.Text = "Afficher les statistiques"
        Me.ButtonAfficher_statistiques.UseVisualStyleBackColor = False
        '
        'ComboBoxNomJoueur
        '
        Me.ComboBoxNomJoueur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNomJoueur.FormattingEnabled = True
        Me.ComboBoxNomJoueur.Location = New System.Drawing.Point(29, 126)
        Me.ComboBoxNomJoueur.Name = "ComboBoxNomJoueur"
        Me.ComboBoxNomJoueur.Size = New System.Drawing.Size(420, 21)
        Me.ComboBoxNomJoueur.TabIndex = 100
        '
        'ListBoxMeilleursTemps
        '
        Me.ListBoxMeilleursTemps.FormattingEnabled = True
        Me.ListBoxMeilleursTemps.Location = New System.Drawing.Point(265, 153)
        Me.ListBoxMeilleursTemps.Name = "ListBoxMeilleursTemps"
        Me.ListBoxMeilleursTemps.Size = New System.Drawing.Size(184, 264)
        Me.ListBoxMeilleursTemps.TabIndex = 99
        '
        'ListBoxNoms_des_joueurs
        '
        Me.ListBoxNoms_des_joueurs.FormattingEnabled = True
        Me.ListBoxNoms_des_joueurs.Location = New System.Drawing.Point(30, 153)
        Me.ListBoxNoms_des_joueurs.Name = "ListBoxNoms_des_joueurs"
        Me.ListBoxNoms_des_joueurs.Size = New System.Drawing.Size(217, 264)
        Me.ListBoxNoms_des_joueurs.TabIndex = 98
        '
        'ButtonTrierParNom
        '
        Me.ButtonTrierParNom.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonTrierParNom.Enabled = False
        Me.ButtonTrierParNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrierParNom.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonTrierParNom.Location = New System.Drawing.Point(29, 97)
        Me.ButtonTrierParNom.Name = "ButtonTrierParNom"
        Me.ButtonTrierParNom.Size = New System.Drawing.Size(85, 23)
        Me.ButtonTrierParNom.TabIndex = 104
        Me.ButtonTrierParNom.Text = "Trier par nom"
        Me.ButtonTrierParNom.UseVisualStyleBackColor = False
        Me.ButtonTrierParNom.Visible = False
        '
        'ButtonTrierParMeilleurTemps
        '
        Me.ButtonTrierParMeilleurTemps.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonTrierParMeilleurTemps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTrierParMeilleurTemps.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ButtonTrierParMeilleurTemps.Location = New System.Drawing.Point(30, 97)
        Me.ButtonTrierParMeilleurTemps.Name = "ButtonTrierParMeilleurTemps"
        Me.ButtonTrierParMeilleurTemps.Size = New System.Drawing.Size(134, 23)
        Me.ButtonTrierParMeilleurTemps.TabIndex = 105
        Me.ButtonTrierParMeilleurTemps.Text = "Trier par meilleur temps"
        Me.ButtonTrierParMeilleurTemps.UseVisualStyleBackColor = False
        '
        'Recapitulatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.ButtonTrierParNom)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.LabelTableau_des_scores)
        Me.Controls.Add(Me.ButtonAfficher_statistiques)
        Me.Controls.Add(Me.ComboBoxNomJoueur)
        Me.Controls.Add(Me.ListBoxMeilleursTemps)
        Me.Controls.Add(Me.ListBoxNoms_des_joueurs)
        Me.Controls.Add(Me.ButtonTrierParMeilleurTemps)
        Me.Name = "Recapitulatif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recapitulatif"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRetour As Button
    Friend WithEvents LabelTableau_des_scores As Label
    Friend WithEvents ButtonAfficher_statistiques As Button
    Friend WithEvents ComboBoxNomJoueur As ComboBox
    Friend WithEvents ListBoxMeilleursTemps As ListBox
    Friend WithEvents ListBoxNoms_des_joueurs As ListBox
    Friend WithEvents ButtonTrierParNom As Button
    Friend WithEvents ButtonTrierParMeilleurTemps As Button
End Class

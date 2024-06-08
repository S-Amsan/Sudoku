<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Acceuil
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
        Me.ComboBoxJoueur = New System.Windows.Forms.ComboBox()
        Me.LabelSUDOKU = New System.Windows.Forms.Label()
        Me.ButtonTableau_des_scores = New System.Windows.Forms.Button()
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonNouvelle_partie = New System.Windows.Forms.Button()
        Me.ButtonRègle = New System.Windows.Forms.Button()
        Me.PictureBoxMusicEnJeu = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxMusicEnJeu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxJoueur
        '
        Me.ComboBoxJoueur.BackColor = System.Drawing.Color.White
        Me.ComboBoxJoueur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBoxJoueur.ForeColor = System.Drawing.Color.Black
        Me.ComboBoxJoueur.FormattingEnabled = True
        Me.ComboBoxJoueur.Location = New System.Drawing.Point(133, 250)
        Me.ComboBoxJoueur.MaxLength = 25
        Me.ComboBoxJoueur.Name = "ComboBoxJoueur"
        Me.ComboBoxJoueur.Size = New System.Drawing.Size(200, 21)
        Me.ComboBoxJoueur.TabIndex = 9
        Me.ComboBoxJoueur.Text = "Entrer votre nom"
        '
        'LabelSUDOKU
        '
        Me.LabelSUDOKU.AutoSize = True
        Me.LabelSUDOKU.BackColor = System.Drawing.Color.Transparent
        Me.LabelSUDOKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSUDOKU.Font = New System.Drawing.Font("MV Boli", 50.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSUDOKU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelSUDOKU.Location = New System.Drawing.Point(60, 86)
        Me.LabelSUDOKU.Name = "LabelSUDOKU"
        Me.LabelSUDOKU.Size = New System.Drawing.Size(348, 87)
        Me.LabelSUDOKU.TabIndex = 8
        Me.LabelSUDOKU.Text = "SUDOKU "
        '
        'ButtonTableau_des_scores
        '
        Me.ButtonTableau_des_scores.BackColor = System.Drawing.Color.Yellow
        Me.ButtonTableau_des_scores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTableau_des_scores.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonTableau_des_scores.ForeColor = System.Drawing.Color.DarkGoldenrod
        Me.ButtonTableau_des_scores.Location = New System.Drawing.Point(203, 300)
        Me.ButtonTableau_des_scores.Name = "ButtonTableau_des_scores"
        Me.ButtonTableau_des_scores.Size = New System.Drawing.Size(240, 40)
        Me.ButtonTableau_des_scores.TabIndex = 7
        Me.ButtonTableau_des_scores.Text = "Voir le tableau des scores"
        Me.ButtonTableau_des_scores.UseVisualStyleBackColor = False
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.BackColor = System.Drawing.Color.OrangeRed
        Me.ButtonQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonQuitter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonQuitter.Location = New System.Drawing.Point(12, 12)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(70, 28)
        Me.ButtonQuitter.TabIndex = 6
        Me.ButtonQuitter.Text = "Quitter"
        Me.ButtonQuitter.UseVisualStyleBackColor = False
        '
        'ButtonNouvelle_partie
        '
        Me.ButtonNouvelle_partie.BackColor = System.Drawing.Color.SpringGreen
        Me.ButtonNouvelle_partie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonNouvelle_partie.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNouvelle_partie.ForeColor = System.Drawing.Color.Green
        Me.ButtonNouvelle_partie.Location = New System.Drawing.Point(42, 300)
        Me.ButtonNouvelle_partie.Name = "ButtonNouvelle_partie"
        Me.ButtonNouvelle_partie.Size = New System.Drawing.Size(155, 40)
        Me.ButtonNouvelle_partie.TabIndex = 5
        Me.ButtonNouvelle_partie.Text = "Nouvelle partie"
        Me.ButtonNouvelle_partie.UseVisualStyleBackColor = False
        '
        'ButtonRègle
        '
        Me.ButtonRègle.BackColor = System.Drawing.Color.SandyBrown
        Me.ButtonRègle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRègle.Font = New System.Drawing.Font("Calibri", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRègle.ForeColor = System.Drawing.Color.OrangeRed
        Me.ButtonRègle.Location = New System.Drawing.Point(151, 356)
        Me.ButtonRègle.Name = "ButtonRègle"
        Me.ButtonRègle.Size = New System.Drawing.Size(148, 40)
        Me.ButtonRègle.TabIndex = 125
        Me.ButtonRègle.Text = "Règles du jeu"
        Me.ButtonRègle.UseVisualStyleBackColor = False
        '
        'PictureBoxMusicEnJeu
        '
        Me.PictureBoxMusicEnJeu.Location = New System.Drawing.Point(422, 12)
        Me.PictureBoxMusicEnJeu.Name = "PictureBoxMusicEnJeu"
        Me.PictureBoxMusicEnJeu.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxMusicEnJeu.TabIndex = 126
        Me.PictureBoxMusicEnJeu.TabStop = False
        '
        'Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.PictureBoxMusicEnJeu)
        Me.Controls.Add(Me.ButtonRègle)
        Me.Controls.Add(Me.ComboBoxJoueur)
        Me.Controls.Add(Me.LabelSUDOKU)
        Me.Controls.Add(Me.ButtonTableau_des_scores)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.ButtonNouvelle_partie)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Name = "Acceuil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceuil"
        CType(Me.PictureBoxMusicEnJeu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxJoueur As ComboBox
    Friend WithEvents LabelSUDOKU As Label
    Friend WithEvents ButtonTableau_des_scores As Button
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ButtonNouvelle_partie As Button
    Friend WithEvents ButtonRègle As Button
    Friend WithEvents PictureBoxMusicEnJeu As PictureBox
End Class

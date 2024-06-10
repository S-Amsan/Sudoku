<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Partie
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelMode = New System.Windows.Forms.Panel()
        Me.LabelMode = New System.Windows.Forms.Label()
        Me.RadioButtonStylo = New System.Windows.Forms.RadioButton()
        Me.RadioButtonCrayon = New System.Windows.Forms.RadioButton()
        Me.LabelNomJoueur = New System.Windows.Forms.Label()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.TableLayoutPanelQuadrillage = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.LabelTempsRestants = New System.Windows.Forms.Label()
        Me.LabelJoueur = New System.Windows.Forms.Label()
        Me.ButtonParamètres = New System.Windows.Forms.Button()
        Me.LabelChronometre = New System.Windows.Forms.Label()
        Me.ButtonLancer = New System.Windows.Forms.Button()
        Me.Chronomètre = New System.Windows.Forms.Timer(Me.components)
        Me.LabelViesRestantes = New System.Windows.Forms.Label()
        Me.LabelChiffresATrouver = New System.Windows.Forms.Label()
        Me.LabelChiffresPasTrouvé = New System.Windows.Forms.Label()
        Me.PanelFondQuadrillage = New System.Windows.Forms.Panel()
        Me.PanelViesRestantes = New System.Windows.Forms.Panel()
        Me.PictureBoxVie5 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVie3 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVie4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVie1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxVie2 = New System.Windows.Forms.PictureBox()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.PanelPartieEnCours = New System.Windows.Forms.Panel()
        Me.LabelIndice = New System.Windows.Forms.Label()
        Me.PictureBoxIndice = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMusicEnJeu = New System.Windows.Forms.PictureBox()
        Me.PanelMode.SuspendLayout()
        Me.PanelViesRestantes.SuspendLayout()
        CType(Me.PictureBoxVie5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVie3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVie4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVie1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxVie2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPartieEnCours.SuspendLayout()
        CType(Me.PictureBoxIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMusicEnJeu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMode
        '
        Me.PanelMode.BackColor = System.Drawing.Color.Transparent
        Me.PanelMode.Controls.Add(Me.LabelMode)
        Me.PanelMode.Controls.Add(Me.RadioButtonStylo)
        Me.PanelMode.Controls.Add(Me.RadioButtonCrayon)
        Me.PanelMode.Location = New System.Drawing.Point(11, 149)
        Me.PanelMode.Name = "PanelMode"
        Me.PanelMode.Size = New System.Drawing.Size(104, 65)
        Me.PanelMode.TabIndex = 105
        '
        'LabelMode
        '
        Me.LabelMode.AutoSize = True
        Me.LabelMode.Location = New System.Drawing.Point(3, 3)
        Me.LabelMode.Name = "LabelMode"
        Me.LabelMode.Size = New System.Drawing.Size(34, 13)
        Me.LabelMode.TabIndex = 99
        Me.LabelMode.Text = "Mode"
        '
        'RadioButtonStylo
        '
        Me.RadioButtonStylo.AutoSize = True
        Me.RadioButtonStylo.Location = New System.Drawing.Point(3, 20)
        Me.RadioButtonStylo.Name = "RadioButtonStylo"
        Me.RadioButtonStylo.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonStylo.TabIndex = 99
        Me.RadioButtonStylo.TabStop = True
        Me.RadioButtonStylo.Text = "Stylo"
        Me.RadioButtonStylo.UseVisualStyleBackColor = True
        '
        'RadioButtonCrayon
        '
        Me.RadioButtonCrayon.AutoSize = True
        Me.RadioButtonCrayon.Location = New System.Drawing.Point(3, 42)
        Me.RadioButtonCrayon.Name = "RadioButtonCrayon"
        Me.RadioButtonCrayon.Size = New System.Drawing.Size(58, 17)
        Me.RadioButtonCrayon.TabIndex = 0
        Me.RadioButtonCrayon.TabStop = True
        Me.RadioButtonCrayon.Text = "Crayon"
        Me.RadioButtonCrayon.UseVisualStyleBackColor = True
        '
        'LabelNomJoueur
        '
        Me.LabelNomJoueur.AutoSize = True
        Me.LabelNomJoueur.BackColor = System.Drawing.Color.Transparent
        Me.LabelNomJoueur.Location = New System.Drawing.Point(53, 9)
        Me.LabelNomJoueur.Name = "LabelNomJoueur"
        Me.LabelNomJoueur.Size = New System.Drawing.Size(61, 13)
        Me.LabelNomJoueur.TabIndex = 104
        Me.LabelNomJoueur.Text = "NomJoueur"
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.Color.Transparent
        Me.ButtonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRetour.ForeColor = System.Drawing.Color.Violet
        Me.ButtonRetour.Location = New System.Drawing.Point(313, 4)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(51, 23)
        Me.ButtonRetour.TabIndex = 103
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'TableLayoutPanelQuadrillage
        '
        Me.TableLayoutPanelQuadrillage.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TableLayoutPanelQuadrillage.ColumnCount = 9
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.Enabled = False
        Me.TableLayoutPanelQuadrillage.Location = New System.Drawing.Point(25, 134)
        Me.TableLayoutPanelQuadrillage.Name = "TableLayoutPanelQuadrillage"
        Me.TableLayoutPanelQuadrillage.RowCount = 9
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.Size = New System.Drawing.Size(315, 315)
        Me.TableLayoutPanelQuadrillage.TabIndex = 102
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAbandonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAbandonner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbandonner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAbandonner.Location = New System.Drawing.Point(0, 273)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(126, 35)
        Me.ButtonAbandonner.TabIndex = 101
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = False
        '
        'LabelTempsRestants
        '
        Me.LabelTempsRestants.AutoSize = True
        Me.LabelTempsRestants.BackColor = System.Drawing.Color.Transparent
        Me.LabelTempsRestants.Location = New System.Drawing.Point(7, 33)
        Me.LabelTempsRestants.Name = "LabelTempsRestants"
        Me.LabelTempsRestants.Size = New System.Drawing.Size(80, 13)
        Me.LabelTempsRestants.TabIndex = 100
        Me.LabelTempsRestants.Text = "Temps restant :"
        '
        'LabelJoueur
        '
        Me.LabelJoueur.AutoSize = True
        Me.LabelJoueur.BackColor = System.Drawing.Color.Transparent
        Me.LabelJoueur.Location = New System.Drawing.Point(7, 9)
        Me.LabelJoueur.Name = "LabelJoueur"
        Me.LabelJoueur.Size = New System.Drawing.Size(48, 13)
        Me.LabelJoueur.TabIndex = 99
        Me.LabelJoueur.Text = "Joueur : "
        '
        'ButtonParamètres
        '
        Me.ButtonParamètres.BackColor = System.Drawing.Color.Transparent
        Me.ButtonParamètres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonParamètres.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParamètres.ForeColor = System.Drawing.Color.Gold
        Me.ButtonParamètres.Location = New System.Drawing.Point(370, 4)
        Me.ButtonParamètres.Name = "ButtonParamètres"
        Me.ButtonParamètres.Size = New System.Drawing.Size(102, 23)
        Me.ButtonParamètres.TabIndex = 106
        Me.ButtonParamètres.Text = "Paramètres"
        Me.ButtonParamètres.UseVisualStyleBackColor = False
        '
        'LabelChronometre
        '
        Me.LabelChronometre.AutoSize = True
        Me.LabelChronometre.BackColor = System.Drawing.Color.Transparent
        Me.LabelChronometre.Location = New System.Drawing.Point(88, 33)
        Me.LabelChronometre.Name = "LabelChronometre"
        Me.LabelChronometre.Size = New System.Drawing.Size(43, 13)
        Me.LabelChronometre.TabIndex = 107
        Me.LabelChronometre.Text = "min:sec"
        '
        'ButtonLancer
        '
        Me.ButtonLancer.BackColor = System.Drawing.Color.Transparent
        Me.ButtonLancer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLancer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLancer.ForeColor = System.Drawing.Color.Navy
        Me.ButtonLancer.Location = New System.Drawing.Point(10, 88)
        Me.ButtonLancer.Name = "ButtonLancer"
        Me.ButtonLancer.Size = New System.Drawing.Size(126, 35)
        Me.ButtonLancer.TabIndex = 108
        Me.ButtonLancer.Text = "Lancer"
        Me.ButtonLancer.UseVisualStyleBackColor = False
        '
        'Chronomètre
        '
        Me.Chronomètre.Interval = 1000
        '
        'LabelViesRestantes
        '
        Me.LabelViesRestantes.AutoSize = True
        Me.LabelViesRestantes.BackColor = System.Drawing.Color.Transparent
        Me.LabelViesRestantes.Location = New System.Drawing.Point(7, 57)
        Me.LabelViesRestantes.Name = "LabelViesRestantes"
        Me.LabelViesRestantes.Size = New System.Drawing.Size(91, 13)
        Me.LabelViesRestantes.TabIndex = 110
        Me.LabelViesRestantes.Text = "Vie(s) restante(s) :"
        '
        'LabelChiffresATrouver
        '
        Me.LabelChiffresATrouver.AutoSize = True
        Me.LabelChiffresATrouver.Location = New System.Drawing.Point(9, 53)
        Me.LabelChiffresATrouver.Name = "LabelChiffresATrouver"
        Me.LabelChiffresATrouver.Size = New System.Drawing.Size(99, 13)
        Me.LabelChiffresATrouver.TabIndex = 112
        Me.LabelChiffresATrouver.Text = "Chiffre(s) à trouver :"
        '
        'LabelChiffresPasTrouvé
        '
        Me.LabelChiffresPasTrouvé.AutoSize = True
        Me.LabelChiffresPasTrouvé.Location = New System.Drawing.Point(32, 77)
        Me.LabelChiffresPasTrouvé.Name = "LabelChiffresPasTrouvé"
        Me.LabelChiffresPasTrouvé.Size = New System.Drawing.Size(45, 13)
        Me.LabelChiffresPasTrouvé.TabIndex = 113
        Me.LabelChiffresPasTrouvé.Text = "Chiffres "
        '
        'PanelFondQuadrillage
        '
        Me.PanelFondQuadrillage.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PanelFondQuadrillage.Location = New System.Drawing.Point(20, 129)
        Me.PanelFondQuadrillage.Name = "PanelFondQuadrillage"
        Me.PanelFondQuadrillage.Size = New System.Drawing.Size(325, 325)
        Me.PanelFondQuadrillage.TabIndex = 114
        '
        'PanelViesRestantes
        '
        Me.PanelViesRestantes.BackColor = System.Drawing.Color.Transparent
        Me.PanelViesRestantes.Controls.Add(Me.PictureBoxVie5)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBoxVie3)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBoxVie4)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBoxVie1)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBoxVie2)
        Me.PanelViesRestantes.Location = New System.Drawing.Point(101, 54)
        Me.PanelViesRestantes.Name = "PanelViesRestantes"
        Me.PanelViesRestantes.Size = New System.Drawing.Size(104, 24)
        Me.PanelViesRestantes.TabIndex = 120
        '
        'PictureBoxVie5
        '
        Me.PictureBoxVie5.Location = New System.Drawing.Point(82, 2)
        Me.PictureBoxVie5.Name = "PictureBoxVie5"
        Me.PictureBoxVie5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxVie5.TabIndex = 119
        Me.PictureBoxVie5.TabStop = False
        Me.PictureBoxVie5.Tag = ""
        '
        'PictureBoxVie3
        '
        Me.PictureBoxVie3.Location = New System.Drawing.Point(62, 2)
        Me.PictureBoxVie3.Name = "PictureBoxVie3"
        Me.PictureBoxVie3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxVie3.TabIndex = 117
        Me.PictureBoxVie3.TabStop = False
        Me.PictureBoxVie3.Tag = ""
        '
        'PictureBoxVie4
        '
        Me.PictureBoxVie4.Location = New System.Drawing.Point(42, 2)
        Me.PictureBoxVie4.Name = "PictureBoxVie4"
        Me.PictureBoxVie4.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxVie4.TabIndex = 118
        Me.PictureBoxVie4.TabStop = False
        Me.PictureBoxVie4.Tag = ""
        '
        'PictureBoxVie1
        '
        Me.PictureBoxVie1.Location = New System.Drawing.Point(22, 2)
        Me.PictureBoxVie1.Name = "PictureBoxVie1"
        Me.PictureBoxVie1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxVie1.TabIndex = 115
        Me.PictureBoxVie1.TabStop = False
        Me.PictureBoxVie1.Tag = ""
        '
        'PictureBoxVie2
        '
        Me.PictureBoxVie2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBoxVie2.Name = "PictureBoxVie2"
        Me.PictureBoxVie2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBoxVie2.TabIndex = 116
        Me.PictureBoxVie2.TabStop = False
        Me.PictureBoxVie2.Tag = ""
        '
        'ButtonPause
        '
        Me.ButtonPause.BackColor = System.Drawing.Color.Transparent
        Me.ButtonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPause.ForeColor = System.Drawing.Color.DarkGreen
        Me.ButtonPause.Location = New System.Drawing.Point(0, 232)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(126, 35)
        Me.ButtonPause.TabIndex = 123
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = False
        '
        'PanelPartieEnCours
        '
        Me.PanelPartieEnCours.BackColor = System.Drawing.Color.Transparent
        Me.PanelPartieEnCours.Controls.Add(Me.LabelIndice)
        Me.PanelPartieEnCours.Controls.Add(Me.PictureBoxIndice)
        Me.PanelPartieEnCours.Controls.Add(Me.ButtonPause)
        Me.PanelPartieEnCours.Controls.Add(Me.LabelChiffresPasTrouvé)
        Me.PanelPartieEnCours.Controls.Add(Me.LabelChiffresATrouver)
        Me.PanelPartieEnCours.Controls.Add(Me.PanelMode)
        Me.PanelPartieEnCours.Controls.Add(Me.ButtonAbandonner)
        Me.PanelPartieEnCours.Location = New System.Drawing.Point(351, 129)
        Me.PanelPartieEnCours.Name = "PanelPartieEnCours"
        Me.PanelPartieEnCours.Size = New System.Drawing.Size(128, 325)
        Me.PanelPartieEnCours.TabIndex = 128
        '
        'LabelIndice
        '
        Me.LabelIndice.AutoSize = True
        Me.LabelIndice.Location = New System.Drawing.Point(46, 19)
        Me.LabelIndice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelIndice.Name = "LabelIndice"
        Me.LabelIndice.Size = New System.Drawing.Size(83, 13)
        Me.LabelIndice.TabIndex = 125
        Me.LabelIndice.Text = "Nombre d'indice"
        '
        'PictureBoxIndice
        '
        Me.PictureBoxIndice.Location = New System.Drawing.Point(4, 6)
        Me.PictureBoxIndice.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBoxIndice.Name = "PictureBoxIndice"
        Me.PictureBoxIndice.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxIndice.TabIndex = 124
        Me.PictureBoxIndice.TabStop = False
        '
        'PictureBoxMusicEnJeu
        '
        Me.PictureBoxMusicEnJeu.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMusicEnJeu.Location = New System.Drawing.Point(424, 33)
        Me.PictureBoxMusicEnJeu.Name = "PictureBoxMusicEnJeu"
        Me.PictureBoxMusicEnJeu.Size = New System.Drawing.Size(40, 40)
        Me.PictureBoxMusicEnJeu.TabIndex = 127
        Me.PictureBoxMusicEnJeu.TabStop = False
        '
        'Partie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Sudoku.My.Resources.Resources.Marineford
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.PanelPartieEnCours)
        Me.Controls.Add(Me.PictureBoxMusicEnJeu)
        Me.Controls.Add(Me.LabelViesRestantes)
        Me.Controls.Add(Me.ButtonLancer)
        Me.Controls.Add(Me.LabelChronometre)
        Me.Controls.Add(Me.ButtonParamètres)
        Me.Controls.Add(Me.LabelNomJoueur)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.TableLayoutPanelQuadrillage)
        Me.Controls.Add(Me.LabelTempsRestants)
        Me.Controls.Add(Me.LabelJoueur)
        Me.Controls.Add(Me.PanelFondQuadrillage)
        Me.Controls.Add(Me.PanelViesRestantes)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Partie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Partie"
        Me.PanelMode.ResumeLayout(False)
        Me.PanelMode.PerformLayout()
        Me.PanelViesRestantes.ResumeLayout(False)
        CType(Me.PictureBoxVie5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVie3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVie4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVie1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxVie2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPartieEnCours.ResumeLayout(False)
        Me.PanelPartieEnCours.PerformLayout()
        CType(Me.PictureBoxIndice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMusicEnJeu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelMode As Panel
    Friend WithEvents LabelMode As Label
    Friend WithEvents RadioButtonStylo As RadioButton
    Friend WithEvents RadioButtonCrayon As RadioButton
    Friend WithEvents LabelNomJoueur As Label
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents TableLayoutPanelQuadrillage As TableLayoutPanel
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents LabelTempsRestants As Label
    Friend WithEvents LabelJoueur As Label
    Friend WithEvents ButtonParamètres As Button
    Friend WithEvents LabelChronometre As Label
    Friend WithEvents ButtonLancer As Button
    Friend WithEvents Chronomètre As Timer
    Friend WithEvents LabelViesRestantes As Label
    Friend WithEvents LabelChiffresATrouver As Label
    Friend WithEvents LabelChiffresPasTrouvé As Label
    Friend WithEvents PanelFondQuadrillage As Panel
    Friend WithEvents PictureBoxVie1 As PictureBox
    Friend WithEvents PictureBoxVie2 As PictureBox
    Friend WithEvents PictureBoxVie3 As PictureBox
    Friend WithEvents PictureBoxVie4 As PictureBox
    Friend WithEvents PictureBoxVie5 As PictureBox
    Friend WithEvents PanelViesRestantes As Panel
    Friend WithEvents ButtonPause As Button
    Friend WithEvents PictureBoxMusicEnJeu As PictureBox
    Friend WithEvents PanelPartieEnCours As Panel
    Friend WithEvents PictureBoxIndice As PictureBox
    Friend WithEvents LabelIndice As Label
End Class

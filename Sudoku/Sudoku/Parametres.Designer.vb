<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Parametres
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
        Me.LabelParametres = New System.Windows.Forms.Label()
        Me.PanelDifficulté = New System.Windows.Forms.Panel()
        Me.RadioButtonExpert = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDifficile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMoyen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.PanelIndice = New System.Windows.Forms.Panel()
        Me.RadioButtonSansIndice = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAvecIndice = New System.Windows.Forms.RadioButton()
        Me.ButtonSauvegarder = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.LabelDifficulte = New System.Windows.Forms.Label()
        Me.LabelDureeMaximun = New System.Windows.Forms.Label()
        Me.LabelIndice = New System.Windows.Forms.Label()
        Me.PanelParametre = New System.Windows.Forms.Panel()
        Me.LabelDureeMax = New System.Windows.Forms.Label()
        Me.HScrollBarDureeMax = New System.Windows.Forms.HScrollBar()
        Me.PanelDifficulté.SuspendLayout()
        Me.PanelIndice.SuspendLayout()
        Me.PanelParametre.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelParametres
        '
        Me.LabelParametres.AutoSize = True
        Me.LabelParametres.BackColor = System.Drawing.Color.Transparent
        Me.LabelParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelParametres.Font = New System.Drawing.Font("MV Boli", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParametres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelParametres.Location = New System.Drawing.Point(41, -1)
        Me.LabelParametres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelParametres.Name = "LabelParametres"
        Me.LabelParametres.Size = New System.Drawing.Size(267, 58)
        Me.LabelParametres.TabIndex = 123
        Me.LabelParametres.Text = "Paramètres"
        '
        'PanelDifficulté
        '
        Me.PanelDifficulté.BackColor = System.Drawing.Color.Transparent
        Me.PanelDifficulté.Controls.Add(Me.RadioButtonExpert)
        Me.PanelDifficulté.Controls.Add(Me.RadioButtonDifficile)
        Me.PanelDifficulté.Controls.Add(Me.RadioButtonMoyen)
        Me.PanelDifficulté.Controls.Add(Me.RadioButtonFacile)
        Me.PanelDifficulté.Location = New System.Drawing.Point(4, 25)
        Me.PanelDifficulté.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelDifficulté.Name = "PanelDifficulté"
        Me.PanelDifficulté.Size = New System.Drawing.Size(180, 84)
        Me.PanelDifficulté.TabIndex = 124
        '
        'RadioButtonExpert
        '
        Me.RadioButtonExpert.AutoSize = True
        Me.RadioButtonExpert.ForeColor = System.Drawing.Color.Red
        Me.RadioButtonExpert.Location = New System.Drawing.Point(5, 65)
        Me.RadioButtonExpert.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonExpert.Name = "RadioButtonExpert"
        Me.RadioButtonExpert.Size = New System.Drawing.Size(69, 21)
        Me.RadioButtonExpert.TabIndex = 122
        Me.RadioButtonExpert.TabStop = True
        Me.RadioButtonExpert.Tag = ""
        Me.RadioButtonExpert.Text = "Expert"
        Me.RadioButtonExpert.UseVisualStyleBackColor = True
        '
        'RadioButtonDifficile
        '
        Me.RadioButtonDifficile.AutoSize = True
        Me.RadioButtonDifficile.ForeColor = System.Drawing.Color.Orange
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(5, 44)
        Me.RadioButtonDifficile.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonDifficile.Name = "RadioButtonDifficile"
        Me.RadioButtonDifficile.Size = New System.Drawing.Size(74, 21)
        Me.RadioButtonDifficile.TabIndex = 3
        Me.RadioButtonDifficile.TabStop = True
        Me.RadioButtonDifficile.Tag = ""
        Me.RadioButtonDifficile.Text = "Difficile"
        Me.RadioButtonDifficile.UseVisualStyleBackColor = True
        '
        'RadioButtonMoyen
        '
        Me.RadioButtonMoyen.AutoSize = True
        Me.RadioButtonMoyen.ForeColor = System.Drawing.Color.Yellow
        Me.RadioButtonMoyen.Location = New System.Drawing.Point(5, 23)
        Me.RadioButtonMoyen.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonMoyen.Name = "RadioButtonMoyen"
        Me.RadioButtonMoyen.Size = New System.Drawing.Size(71, 21)
        Me.RadioButtonMoyen.TabIndex = 2
        Me.RadioButtonMoyen.TabStop = True
        Me.RadioButtonMoyen.Tag = ""
        Me.RadioButtonMoyen.Text = "Moyen"
        Me.RadioButtonMoyen.UseVisualStyleBackColor = True
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.ForeColor = System.Drawing.Color.Chartreuse
        Me.RadioButtonFacile.Location = New System.Drawing.Point(5, 1)
        Me.RadioButtonFacile.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(66, 21)
        Me.RadioButtonFacile.TabIndex = 1
        Me.RadioButtonFacile.TabStop = True
        Me.RadioButtonFacile.Tag = ""
        Me.RadioButtonFacile.Text = "Facile"
        Me.RadioButtonFacile.UseVisualStyleBackColor = True
        '
        'PanelIndice
        '
        Me.PanelIndice.BackColor = System.Drawing.Color.Transparent
        Me.PanelIndice.Controls.Add(Me.RadioButtonSansIndice)
        Me.PanelIndice.Controls.Add(Me.RadioButtonAvecIndice)
        Me.PanelIndice.Location = New System.Drawing.Point(39, 143)
        Me.PanelIndice.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelIndice.Name = "PanelIndice"
        Me.PanelIndice.Size = New System.Drawing.Size(267, 32)
        Me.PanelIndice.TabIndex = 126
        '
        'RadioButtonSansIndice
        '
        Me.RadioButtonSansIndice.AutoSize = True
        Me.RadioButtonSansIndice.ForeColor = System.Drawing.Color.Red
        Me.RadioButtonSansIndice.Location = New System.Drawing.Point(137, 7)
        Me.RadioButtonSansIndice.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonSansIndice.Name = "RadioButtonSansIndice"
        Me.RadioButtonSansIndice.Size = New System.Drawing.Size(102, 21)
        Me.RadioButtonSansIndice.TabIndex = 4
        Me.RadioButtonSansIndice.TabStop = True
        Me.RadioButtonSansIndice.Tag = ""
        Me.RadioButtonSansIndice.Text = "Sans Indice"
        Me.RadioButtonSansIndice.UseVisualStyleBackColor = True
        '
        'RadioButtonAvecIndice
        '
        Me.RadioButtonAvecIndice.AutoSize = True
        Me.RadioButtonAvecIndice.ForeColor = System.Drawing.Color.Chartreuse
        Me.RadioButtonAvecIndice.Location = New System.Drawing.Point(17, 7)
        Me.RadioButtonAvecIndice.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButtonAvecIndice.Name = "RadioButtonAvecIndice"
        Me.RadioButtonAvecIndice.Size = New System.Drawing.Size(101, 21)
        Me.RadioButtonAvecIndice.TabIndex = 3
        Me.RadioButtonAvecIndice.TabStop = True
        Me.RadioButtonAvecIndice.Tag = ""
        Me.RadioButtonAvecIndice.Text = "Avec Indice"
        Me.RadioButtonAvecIndice.UseVisualStyleBackColor = True
        '
        'ButtonSauvegarder
        '
        Me.ButtonSauvegarder.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSauvegarder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSauvegarder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSauvegarder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonSauvegarder.Location = New System.Drawing.Point(177, 266)
        Me.ButtonSauvegarder.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSauvegarder.Name = "ButtonSauvegarder"
        Me.ButtonSauvegarder.Size = New System.Drawing.Size(141, 41)
        Me.ButtonSauvegarder.TabIndex = 128
        Me.ButtonSauvegarder.Text = "Sauvegarder"
        Me.ButtonSauvegarder.UseVisualStyleBackColor = False
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnnuler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAnnuler.Location = New System.Drawing.Point(83, 276)
        Me.ButtonAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(83, 31)
        Me.ButtonAnnuler.TabIndex = 129
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = False
        '
        'LabelDifficulte
        '
        Me.LabelDifficulte.AutoSize = True
        Me.LabelDifficulte.BackColor = System.Drawing.Color.Transparent
        Me.LabelDifficulte.ForeColor = System.Drawing.Color.White
        Me.LabelDifficulte.Location = New System.Drawing.Point(41, 6)
        Me.LabelDifficulte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDifficulte.Name = "LabelDifficulte"
        Me.LabelDifficulte.Size = New System.Drawing.Size(62, 17)
        Me.LabelDifficulte.TabIndex = 130
        Me.LabelDifficulte.Text = "Difficulté"
        '
        'LabelDureeMaximun
        '
        Me.LabelDureeMaximun.AutoSize = True
        Me.LabelDureeMaximun.BackColor = System.Drawing.Color.Transparent
        Me.LabelDureeMaximun.ForeColor = System.Drawing.Color.White
        Me.LabelDureeMaximun.Location = New System.Drawing.Point(213, 7)
        Me.LabelDureeMaximun.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDureeMaximun.Name = "LabelDureeMaximun"
        Me.LabelDureeMaximun.Size = New System.Drawing.Size(114, 17)
        Me.LabelDureeMaximun.TabIndex = 131
        Me.LabelDureeMaximun.Text = "Duree maximun :"
        '
        'LabelIndice
        '
        Me.LabelIndice.AutoSize = True
        Me.LabelIndice.BackColor = System.Drawing.Color.Transparent
        Me.LabelIndice.ForeColor = System.Drawing.Color.White
        Me.LabelIndice.Location = New System.Drawing.Point(139, 123)
        Me.LabelIndice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelIndice.Name = "LabelIndice"
        Me.LabelIndice.Size = New System.Drawing.Size(45, 17)
        Me.LabelIndice.TabIndex = 132
        Me.LabelIndice.Text = "Indice"
        '
        'PanelParametre
        '
        Me.PanelParametre.BackColor = System.Drawing.Color.Transparent
        Me.PanelParametre.Controls.Add(Me.LabelDureeMax)
        Me.PanelParametre.Controls.Add(Me.HScrollBarDureeMax)
        Me.PanelParametre.Controls.Add(Me.LabelIndice)
        Me.PanelParametre.Controls.Add(Me.PanelIndice)
        Me.PanelParametre.Controls.Add(Me.LabelDifficulte)
        Me.PanelParametre.Controls.Add(Me.LabelDureeMaximun)
        Me.PanelParametre.Controls.Add(Me.PanelDifficulté)
        Me.PanelParametre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelParametre.Location = New System.Drawing.Point(13, 65)
        Me.PanelParametre.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelParametre.Name = "PanelParametre"
        Me.PanelParametre.Size = New System.Drawing.Size(351, 188)
        Me.PanelParametre.TabIndex = 133
        '
        'LabelDureeMax
        '
        Me.LabelDureeMax.AutoSize = True
        Me.LabelDureeMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDureeMax.Location = New System.Drawing.Point(192, 39)
        Me.LabelDureeMax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDureeMax.Name = "LabelDureeMax"
        Me.LabelDureeMax.Size = New System.Drawing.Size(148, 29)
        Me.LabelDureeMax.TabIndex = 134
        Me.LabelDureeMax.Text = "00min:00sec"
        '
        'HScrollBarDureeMax
        '
        Me.HScrollBarDureeMax.Location = New System.Drawing.Point(189, 84)
        Me.HScrollBarDureeMax.Name = "HScrollBarDureeMax"
        Me.HScrollBarDureeMax.Size = New System.Drawing.Size(156, 17)
        Me.HScrollBarDureeMax.TabIndex = 134
        '
        'Parametres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Sudoku.My.Resources.Resources.param
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonSauvegarder)
        Me.Controls.Add(Me.PanelParametre)
        Me.Controls.Add(Me.LabelParametres)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Parametres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramètres"
        Me.PanelDifficulté.ResumeLayout(False)
        Me.PanelDifficulté.PerformLayout()
        Me.PanelIndice.ResumeLayout(False)
        Me.PanelIndice.PerformLayout()
        Me.PanelParametre.ResumeLayout(False)
        Me.PanelParametre.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelParametres As Label
    Friend WithEvents PanelDifficulté As Panel
    Friend WithEvents PanelIndice As Panel
    Friend WithEvents RadioButtonExpert As RadioButton
    Friend WithEvents RadioButtonDifficile As RadioButton
    Friend WithEvents RadioButtonMoyen As RadioButton
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents ButtonSauvegarder As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents LabelDifficulte As Label
    Friend WithEvents LabelDureeMaximun As Label
    Friend WithEvents RadioButtonSansIndice As RadioButton
    Friend WithEvents RadioButtonAvecIndice As RadioButton
    Friend WithEvents LabelIndice As Label
    Friend WithEvents PanelParametre As Panel
    Friend WithEvents HScrollBarDureeMax As HScrollBar
    Friend WithEvents LabelDureeMax As Label
End Class

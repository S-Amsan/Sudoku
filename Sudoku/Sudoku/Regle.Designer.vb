﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regle
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Regle))
        Me.LabelSRegle = New System.Windows.Forms.Label()
        Me.LabelRegleText = New System.Windows.Forms.Label()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelSRegle
        '
        Me.LabelSRegle.AutoSize = True
        Me.LabelSRegle.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LabelSRegle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelSRegle.Font = New System.Drawing.Font("MV Boli", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSRegle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelSRegle.Location = New System.Drawing.Point(70, 30)
        Me.LabelSRegle.Name = "LabelSRegle"
        Me.LabelSRegle.Size = New System.Drawing.Size(338, 63)
        Me.LabelSRegle.TabIndex = 9
        Me.LabelSRegle.Text = "Règles du jeu"
        '
        'LabelRegleText
        '
        Me.LabelRegleText.AutoSize = True
        Me.LabelRegleText.Font = New System.Drawing.Font("Calibri", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRegleText.ForeColor = System.Drawing.Color.White
        Me.LabelRegleText.Location = New System.Drawing.Point(32, 100)
        Me.LabelRegleText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelRegleText.Name = "LabelRegleText"
        Me.LabelRegleText.Size = New System.Drawing.Size(412, 357)
        Me.LabelRegleText.TabIndex = 10
        Me.LabelRegleText.Text = resources.GetString("LabelRegleText.Text")
        '
        'ButtonRetour
        '
        Me.ButtonRetour.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ButtonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRetour.ForeColor = System.Drawing.Color.Green
        Me.ButtonRetour.Location = New System.Drawing.Point(10, 11)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(51, 23)
        Me.ButtonRetour.TabIndex = 104
        Me.ButtonRetour.Text = "Retour"
        Me.ButtonRetour.UseVisualStyleBackColor = False
        '
        'Regle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.LabelRegleText)
        Me.Controls.Add(Me.LabelSRegle)
        Me.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Regle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelSRegle As Label
    Friend WithEvents LabelRegleText As Label
    Friend WithEvents ButtonRetour As Button
End Class

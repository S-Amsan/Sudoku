<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pause
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
        Me.ButtonReprendre = New System.Windows.Forms.Button()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.LabelPause = New System.Windows.Forms.Label()
        Me.LabelChronometre = New System.Windows.Forms.Label()
        Me.PanelViesRestantes = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PanelViesRestantes.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonReprendre
        '
        Me.ButtonReprendre.BackColor = System.Drawing.Color.Transparent
        Me.ButtonReprendre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonReprendre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReprendre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonReprendre.Location = New System.Drawing.Point(103, 203)
        Me.ButtonReprendre.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonReprendre.Name = "ButtonReprendre"
        Me.ButtonReprendre.Size = New System.Drawing.Size(168, 43)
        Me.ButtonReprendre.TabIndex = 110
        Me.ButtonReprendre.Text = "Reprendre"
        Me.ButtonReprendre.UseVisualStyleBackColor = False
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.BackColor = System.Drawing.Color.Transparent
        Me.ButtonAbandonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAbandonner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAbandonner.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonAbandonner.Location = New System.Drawing.Point(103, 254)
        Me.ButtonAbandonner.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(168, 43)
        Me.ButtonAbandonner.TabIndex = 109
        Me.ButtonAbandonner.Text = "Abandonner"
        Me.ButtonAbandonner.UseVisualStyleBackColor = False
        '
        'LabelPause
        '
        Me.LabelPause.AutoSize = True
        Me.LabelPause.BackColor = System.Drawing.Color.Transparent
        Me.LabelPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelPause.Font = New System.Drawing.Font("MV Boli", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPause.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelPause.Location = New System.Drawing.Point(81, 22)
        Me.LabelPause.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPause.Name = "LabelPause"
        Me.LabelPause.Size = New System.Drawing.Size(193, 79)
        Me.LabelPause.TabIndex = 122
        Me.LabelPause.Text = "Pause"
        '
        'LabelChronometre
        '
        Me.LabelChronometre.AutoSize = True
        Me.LabelChronometre.BackColor = System.Drawing.Color.Transparent
        Me.LabelChronometre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChronometre.Location = New System.Drawing.Point(108, 133)
        Me.LabelChronometre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelChronometre.Name = "LabelChronometre"
        Me.LabelChronometre.Size = New System.Drawing.Size(96, 29)
        Me.LabelChronometre.TabIndex = 125
        Me.LabelChronometre.Text = "min:sec"
        '
        'PanelViesRestantes
        '
        Me.PanelViesRestantes.BackColor = System.Drawing.Color.Transparent
        Me.PanelViesRestantes.Controls.Add(Me.PictureBox1)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBox2)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBox3)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBox4)
        Me.PanelViesRestantes.Controls.Add(Me.PictureBox5)
        Me.PanelViesRestantes.Location = New System.Drawing.Point(119, 166)
        Me.PanelViesRestantes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelViesRestantes.Name = "PanelViesRestantes"
        Me.PanelViesRestantes.Size = New System.Drawing.Size(139, 30)
        Me.PanelViesRestantes.TabIndex = 126
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(109, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = ""
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(83, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.TabIndex = 117
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = ""
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(56, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox3.TabIndex = 118
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = ""
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(29, 2)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox4.TabIndex = 115
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = ""
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox5.TabIndex = 116
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = ""
        '
        'Pause
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.Sudoku.My.Resources.Resources.Pause
        Me.ClientSize = New System.Drawing.Size(379, 321)
        Me.Controls.Add(Me.PanelViesRestantes)
        Me.Controls.Add(Me.LabelChronometre)
        Me.Controls.Add(Me.LabelPause)
        Me.Controls.Add(Me.ButtonReprendre)
        Me.Controls.Add(Me.ButtonAbandonner)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Pause"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pause"
        Me.PanelViesRestantes.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonReprendre As Button
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents LabelPause As Label
    Friend WithEvents LabelChronometre As Label
    Friend WithEvents PanelViesRestantes As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class

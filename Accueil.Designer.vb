<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
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
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.ListeJoueurs = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NvPartieButton = New System.Windows.Forms.Button()
        Me.ArretButton = New System.Windows.Forms.Button()
        Me.TabScoreButton = New System.Windows.Forms.Button()
        Me.OptionsButton = New System.Windows.Forms.Button()
        Me.PictureAccueil = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureAccueil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.ForeColor = System.Drawing.Color.Red
        Me.LabelTitre.Location = New System.Drawing.Point(198, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(378, 43)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Memory : le jeu de mémoire"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListeJoueurs
        '
        Me.ListeJoueurs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ListeJoueurs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ListeJoueurs.FormattingEnabled = True
        Me.ListeJoueurs.Location = New System.Drawing.Point(94, 174)
        Me.ListeJoueurs.Name = "ListeJoueurs"
        Me.ListeJoueurs.Size = New System.Drawing.Size(157, 21)
        Me.ListeJoueurs.Sorted = True
        Me.ListeJoueurs.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(106, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Saississez votre nom"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NvPartieButton
        '
        Me.NvPartieButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.NvPartieButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NvPartieButton.Location = New System.Drawing.Point(61, 311)
        Me.NvPartieButton.Name = "NvPartieButton"
        Me.NvPartieButton.Size = New System.Drawing.Size(130, 68)
        Me.NvPartieButton.TabIndex = 4
        Me.NvPartieButton.Text = "Nouvelle Partie"
        Me.NvPartieButton.UseVisualStyleBackColor = False
        '
        'ArretButton
        '
        Me.ArretButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ArretButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArretButton.Location = New System.Drawing.Point(579, 311)
        Me.ArretButton.Name = "ArretButton"
        Me.ArretButton.Size = New System.Drawing.Size(130, 68)
        Me.ArretButton.TabIndex = 5
        Me.ArretButton.Text = "Arrêt"
        Me.ArretButton.UseVisualStyleBackColor = False
        '
        'TabScoreButton
        '
        Me.TabScoreButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.TabScoreButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabScoreButton.Location = New System.Drawing.Point(414, 311)
        Me.TabScoreButton.Name = "TabScoreButton"
        Me.TabScoreButton.Size = New System.Drawing.Size(130, 68)
        Me.TabScoreButton.TabIndex = 6
        Me.TabScoreButton.Text = "Tableau des scores"
        Me.TabScoreButton.UseVisualStyleBackColor = False
        '
        'OptionsButton
        '
        Me.OptionsButton.BackColor = System.Drawing.Color.RoyalBlue
        Me.OptionsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsButton.Location = New System.Drawing.Point(234, 311)
        Me.OptionsButton.Name = "OptionsButton"
        Me.OptionsButton.Size = New System.Drawing.Size(130, 68)
        Me.OptionsButton.TabIndex = 7
        Me.OptionsButton.Text = "Options"
        Me.OptionsButton.UseVisualStyleBackColor = False
        '
        'PictureAccueil
        '
        Me.PictureAccueil.Location = New System.Drawing.Point(354, 74)
        Me.PictureAccueil.Name = "PictureAccueil"
        Me.PictureAccueil.Size = New System.Drawing.Size(355, 165)
        Me.PictureAccueil.TabIndex = 8
        Me.PictureAccueil.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(202, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "© Programmé par Ibrahime Ahbib et Guillaume Merchez"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureAccueil)
        Me.Controls.Add(Me.OptionsButton)
        Me.Controls.Add(Me.TabScoreButton)
        Me.Controls.Add(Me.ArretButton)
        Me.Controls.Add(Me.NvPartieButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListeJoueurs)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        CType(Me.PictureAccueil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents ListeJoueurs As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NvPartieButton As Button
    Friend WithEvents ArretButton As Button
    Friend WithEvents TabScoreButton As Button
    Friend WithEvents OptionsButton As Button
    Friend WithEvents PictureAccueil As PictureBox
    Friend WithEvents Label1 As Label
End Class

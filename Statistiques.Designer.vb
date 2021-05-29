<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistiques
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
        Me.NomJoueurs = New System.Windows.Forms.ListBox()
        Me.CarresMaxMemorises = New System.Windows.Forms.ListBox()
        Me.TempsMinimum = New System.Windows.Forms.ListBox()
        Me.NbPartiesJouees = New System.Windows.Forms.ListBox()
        Me.NbHeuresJeu = New System.Windows.Forms.ListBox()
        Me.ComboBoxJoueurs = New System.Windows.Forms.ComboBox()
        Me.LabelRecherche = New System.Windows.Forms.Label()
        Me.AccueilButton = New System.Windows.Forms.Button()
        Me.NbHeuresJeuLabel = New System.Windows.Forms.Label()
        Me.NbPartiesJoueesLabel = New System.Windows.Forms.Label()
        Me.TempsMinimumLabel = New System.Windows.Forms.Label()
        Me.CarresMaxMemLabel = New System.Windows.Forms.Label()
        Me.NomsJoueursLabel = New System.Windows.Forms.Label()
        Me.BoutonChangementOrdre = New System.Windows.Forms.Button()
        Me.ButtonRecherche = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LabelTitre.Location = New System.Drawing.Point(224, 36)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(328, 43)
        Me.LabelTitre.TabIndex = 1
        Me.LabelTitre.Text = "Statistiques des joueurs"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NomJoueurs
        '
        Me.NomJoueurs.FormattingEnabled = True
        Me.NomJoueurs.Location = New System.Drawing.Point(42, 166)
        Me.NomJoueurs.Name = "NomJoueurs"
        Me.NomJoueurs.Size = New System.Drawing.Size(135, 134)
        Me.NomJoueurs.TabIndex = 2
        '
        'CarresMaxMemorises
        '
        Me.CarresMaxMemorises.FormattingEnabled = True
        Me.CarresMaxMemorises.Location = New System.Drawing.Point(183, 166)
        Me.CarresMaxMemorises.Name = "CarresMaxMemorises"
        Me.CarresMaxMemorises.Size = New System.Drawing.Size(135, 134)
        Me.CarresMaxMemorises.TabIndex = 3
        '
        'TempsMinimum
        '
        Me.TempsMinimum.FormattingEnabled = True
        Me.TempsMinimum.Location = New System.Drawing.Point(324, 166)
        Me.TempsMinimum.Name = "TempsMinimum"
        Me.TempsMinimum.Size = New System.Drawing.Size(135, 134)
        Me.TempsMinimum.TabIndex = 4
        '
        'NbPartiesJouees
        '
        Me.NbPartiesJouees.FormattingEnabled = True
        Me.NbPartiesJouees.Location = New System.Drawing.Point(465, 166)
        Me.NbPartiesJouees.Name = "NbPartiesJouees"
        Me.NbPartiesJouees.Size = New System.Drawing.Size(135, 134)
        Me.NbPartiesJouees.TabIndex = 5
        '
        'NbHeuresJeu
        '
        Me.NbHeuresJeu.FormattingEnabled = True
        Me.NbHeuresJeu.Location = New System.Drawing.Point(606, 166)
        Me.NbHeuresJeu.Name = "NbHeuresJeu"
        Me.NbHeuresJeu.Size = New System.Drawing.Size(135, 134)
        Me.NbHeuresJeu.TabIndex = 6
        '
        'ComboBoxJoueurs
        '
        Me.ComboBoxJoueurs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxJoueurs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxJoueurs.FormattingEnabled = True
        Me.ComboBoxJoueurs.Location = New System.Drawing.Point(42, 122)
        Me.ComboBoxJoueurs.Name = "ComboBoxJoueurs"
        Me.ComboBoxJoueurs.Size = New System.Drawing.Size(135, 21)
        Me.ComboBoxJoueurs.TabIndex = 7
        '
        'LabelRecherche
        '
        Me.LabelRecherche.AutoSize = True
        Me.LabelRecherche.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LabelRecherche.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRecherche.ForeColor = System.Drawing.Color.Black
        Me.LabelRecherche.Location = New System.Drawing.Point(47, 102)
        Me.LabelRecherche.Name = "LabelRecherche"
        Me.LabelRecherche.Size = New System.Drawing.Size(130, 17)
        Me.LabelRecherche.TabIndex = 8
        Me.LabelRecherche.Text = "Rechercher un joueur :"
        '
        'AccueilButton
        '
        Me.AccueilButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.AccueilButton.Location = New System.Drawing.Point(12, 352)
        Me.AccueilButton.Name = "AccueilButton"
        Me.AccueilButton.Size = New System.Drawing.Size(131, 63)
        Me.AccueilButton.TabIndex = 9
        Me.AccueilButton.Text = "Retourner à l'accueil"
        Me.AccueilButton.UseVisualStyleBackColor = False
        '
        'NbHeuresJeuLabel
        '
        Me.NbHeuresJeuLabel.AutoSize = True
        Me.NbHeuresJeuLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NbHeuresJeuLabel.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NbHeuresJeuLabel.ForeColor = System.Drawing.Color.Black
        Me.NbHeuresJeuLabel.Location = New System.Drawing.Point(634, 146)
        Me.NbHeuresJeuLabel.Name = "NbHeuresJeuLabel"
        Me.NbHeuresJeuLabel.Size = New System.Drawing.Size(82, 17)
        Me.NbHeuresJeuLabel.TabIndex = 11
        Me.NbHeuresJeuLabel.Text = "Heures de jeu"
        '
        'NbPartiesJoueesLabel
        '
        Me.NbPartiesJoueesLabel.AutoSize = True
        Me.NbPartiesJoueesLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NbPartiesJoueesLabel.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NbPartiesJoueesLabel.ForeColor = System.Drawing.Color.Black
        Me.NbPartiesJoueesLabel.Location = New System.Drawing.Point(491, 146)
        Me.NbPartiesJoueesLabel.Name = "NbPartiesJoueesLabel"
        Me.NbPartiesJoueesLabel.Size = New System.Drawing.Size(83, 17)
        Me.NbPartiesJoueesLabel.TabIndex = 12
        Me.NbPartiesJoueesLabel.Text = "Parties jouées"
        '
        'TempsMinimumLabel
        '
        Me.TempsMinimumLabel.AutoSize = True
        Me.TempsMinimumLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TempsMinimumLabel.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TempsMinimumLabel.ForeColor = System.Drawing.Color.Black
        Me.TempsMinimumLabel.Location = New System.Drawing.Point(345, 146)
        Me.TempsMinimumLabel.Name = "TempsMinimumLabel"
        Me.TempsMinimumLabel.Size = New System.Drawing.Size(95, 17)
        Me.TempsMinimumLabel.TabIndex = 13
        Me.TempsMinimumLabel.Text = "Temps minimum"
        '
        'CarresMaxMemLabel
        '
        Me.CarresMaxMemLabel.AutoSize = True
        Me.CarresMaxMemLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CarresMaxMemLabel.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarresMaxMemLabel.ForeColor = System.Drawing.Color.Black
        Me.CarresMaxMemLabel.Location = New System.Drawing.Point(201, 146)
        Me.CarresMaxMemLabel.Name = "CarresMaxMemLabel"
        Me.CarresMaxMemLabel.Size = New System.Drawing.Size(96, 17)
        Me.CarresMaxMemLabel.TabIndex = 14
        Me.CarresMaxMemLabel.Text = "Carrés maximum"
        '
        'NomsJoueursLabel
        '
        Me.NomsJoueursLabel.AutoSize = True
        Me.NomsJoueursLabel.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NomsJoueursLabel.Font = New System.Drawing.Font("Monotype Corsiva", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomsJoueursLabel.ForeColor = System.Drawing.Color.Black
        Me.NomsJoueursLabel.Location = New System.Drawing.Point(82, 146)
        Me.NomsJoueursLabel.Name = "NomsJoueursLabel"
        Me.NomsJoueursLabel.Size = New System.Drawing.Size(39, 17)
        Me.NomsJoueursLabel.TabIndex = 15
        Me.NomsJoueursLabel.Text = "Noms"
        '
        'BoutonChangementOrdre
        '
        Me.BoutonChangementOrdre.Location = New System.Drawing.Point(42, 306)
        Me.BoutonChangementOrdre.Name = "BoutonChangementOrdre"
        Me.BoutonChangementOrdre.Size = New System.Drawing.Size(164, 23)
        Me.BoutonChangementOrdre.TabIndex = 16
        Me.BoutonChangementOrdre.Text = "Trier dans l'ordre décroissant"
        Me.BoutonChangementOrdre.UseVisualStyleBackColor = True
        '
        'ButtonRecherche
        '
        Me.ButtonRecherche.Location = New System.Drawing.Point(183, 120)
        Me.ButtonRecherche.Name = "ButtonRecherche"
        Me.ButtonRecherche.Size = New System.Drawing.Size(80, 23)
        Me.ButtonRecherche.TabIndex = 17
        Me.ButtonRecherche.Text = "Rechercher"
        Me.ButtonRecherche.UseVisualStyleBackColor = True
        '
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 444)
        Me.Controls.Add(Me.ButtonRecherche)
        Me.Controls.Add(Me.BoutonChangementOrdre)
        Me.Controls.Add(Me.NomsJoueursLabel)
        Me.Controls.Add(Me.CarresMaxMemLabel)
        Me.Controls.Add(Me.TempsMinimumLabel)
        Me.Controls.Add(Me.NbPartiesJoueesLabel)
        Me.Controls.Add(Me.NbHeuresJeuLabel)
        Me.Controls.Add(Me.AccueilButton)
        Me.Controls.Add(Me.LabelRecherche)
        Me.Controls.Add(Me.ComboBoxJoueurs)
        Me.Controls.Add(Me.NbHeuresJeu)
        Me.Controls.Add(Me.NbPartiesJouees)
        Me.Controls.Add(Me.TempsMinimum)
        Me.Controls.Add(Me.CarresMaxMemorises)
        Me.Controls.Add(Me.NomJoueurs)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "Statistiques"
        Me.Text = "Statistique"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents NomJoueurs As ListBox
    Friend WithEvents CarresMaxMemorises As ListBox
    Friend WithEvents TempsMinimum As ListBox
    Friend WithEvents NbPartiesJouees As ListBox
    Friend WithEvents NbHeuresJeu As ListBox
    Friend WithEvents ComboBoxJoueurs As ComboBox
    Friend WithEvents LabelRecherche As Label
    Friend WithEvents AccueilButton As Button
    Friend WithEvents NbHeuresJeuLabel As Label
    Friend WithEvents NbPartiesJoueesLabel As Label
    Friend WithEvents TempsMinimumLabel As Label
    Friend WithEvents CarresMaxMemLabel As Label
    Friend WithEvents NomsJoueursLabel As Label
    Friend WithEvents BoutonChangementOrdre As Button
    Friend WithEvents ButtonRecherche As Button
End Class

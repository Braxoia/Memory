<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Options
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
        Me.TimerChooseLabel = New System.Windows.Forms.Label()
        Me.TempsImpartiLabel = New System.Windows.Forms.Label()
        Me.SelecteurTempsJeu = New System.Windows.Forms.NumericUpDown()
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.GroupBoxChoixTimer = New System.Windows.Forms.GroupBox()
        Me.ModifierTempsJeu = New System.Windows.Forms.CheckBox()
        Me.AccueilButton = New System.Windows.Forms.Button()
        Me.GroupBoxPack = New System.Windows.Forms.GroupBox()
        Me.Defaut = New System.Windows.Forms.RadioButton()
        Me.IUT = New System.Windows.Forms.RadioButton()
        Me.Noel = New System.Windows.Forms.RadioButton()
        Me.HP = New System.Windows.Forms.RadioButton()
        Me.BoutonSelectionDossier = New System.Windows.Forms.Button()
        CType(Me.SelecteurTempsJeu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxChoixTimer.SuspendLayout()
        Me.GroupBoxPack.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerChooseLabel
        '
        Me.TimerChooseLabel.AutoSize = True
        Me.TimerChooseLabel.Location = New System.Drawing.Point(4, 43)
        Me.TimerChooseLabel.Name = "TimerChooseLabel"
        Me.TimerChooseLabel.Size = New System.Drawing.Size(158, 18)
        Me.TimerChooseLabel.TabIndex = 0
        Me.TimerChooseLabel.Text = "Modifier le temps de jeu :"
        '
        'TempsImpartiLabel
        '
        Me.TempsImpartiLabel.AutoSize = True
        Me.TempsImpartiLabel.Location = New System.Drawing.Point(3, 76)
        Me.TempsImpartiLabel.Name = "TempsImpartiLabel"
        Me.TempsImpartiLabel.Size = New System.Drawing.Size(125, 18)
        Me.TempsImpartiLabel.TabIndex = 2
        Me.TempsImpartiLabel.Text = "Temps imparti (sec) :"
        '
        'SelecteurTempsJeu
        '
        Me.SelecteurTempsJeu.Enabled = False
        Me.SelecteurTempsJeu.Location = New System.Drawing.Point(128, 76)
        Me.SelecteurTempsJeu.Maximum = New Decimal(New Integer() {3600, 0, 0, 0})
        Me.SelecteurTempsJeu.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelecteurTempsJeu.Name = "SelecteurTempsJeu"
        Me.SelecteurTempsJeu.Size = New System.Drawing.Size(80, 25)
        Me.SelecteurTempsJeu.TabIndex = 3
        Me.SelecteurTempsJeu.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.ForeColor = System.Drawing.Color.Maroon
        Me.LabelTitre.Location = New System.Drawing.Point(86, 9)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(122, 43)
        Me.LabelTitre.TabIndex = 4
        Me.LabelTitre.Text = "Options"
        Me.LabelTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBoxChoixTimer
        '
        Me.GroupBoxChoixTimer.Controls.Add(Me.ModifierTempsJeu)
        Me.GroupBoxChoixTimer.Controls.Add(Me.SelecteurTempsJeu)
        Me.GroupBoxChoixTimer.Controls.Add(Me.TempsImpartiLabel)
        Me.GroupBoxChoixTimer.Controls.Add(Me.TimerChooseLabel)
        Me.GroupBoxChoixTimer.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxChoixTimer.Location = New System.Drawing.Point(51, 78)
        Me.GroupBoxChoixTimer.Name = "GroupBoxChoixTimer"
        Me.GroupBoxChoixTimer.Size = New System.Drawing.Size(208, 127)
        Me.GroupBoxChoixTimer.TabIndex = 5
        Me.GroupBoxChoixTimer.TabStop = False
        Me.GroupBoxChoixTimer.Text = "Changement du temps de jeu"
        '
        'ModifierTempsJeu
        '
        Me.ModifierTempsJeu.AutoSize = True
        Me.ModifierTempsJeu.Checked = True
        Me.ModifierTempsJeu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ModifierTempsJeu.Location = New System.Drawing.Point(168, 47)
        Me.ModifierTempsJeu.Name = "ModifierTempsJeu"
        Me.ModifierTempsJeu.Size = New System.Drawing.Size(15, 14)
        Me.ModifierTempsJeu.TabIndex = 7
        Me.ModifierTempsJeu.UseVisualStyleBackColor = True
        '
        'AccueilButton
        '
        Me.AccueilButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.AccueilButton.Location = New System.Drawing.Point(17, 424)
        Me.AccueilButton.Name = "AccueilButton"
        Me.AccueilButton.Size = New System.Drawing.Size(264, 68)
        Me.AccueilButton.TabIndex = 10
        Me.AccueilButton.Text = "Retourner à l'accueil"
        Me.AccueilButton.UseVisualStyleBackColor = False
        '
        'GroupBoxPack
        '
        Me.GroupBoxPack.Controls.Add(Me.Defaut)
        Me.GroupBoxPack.Controls.Add(Me.IUT)
        Me.GroupBoxPack.Controls.Add(Me.Noel)
        Me.GroupBoxPack.Controls.Add(Me.HP)
        Me.GroupBoxPack.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxPack.Location = New System.Drawing.Point(51, 230)
        Me.GroupBoxPack.Name = "GroupBoxPack"
        Me.GroupBoxPack.Size = New System.Drawing.Size(208, 143)
        Me.GroupBoxPack.TabIndex = 6
        Me.GroupBoxPack.TabStop = False
        Me.GroupBoxPack.Text = "Changer le thème des cartes"
        '
        'Defaut
        '
        Me.Defaut.AutoSize = True
        Me.Defaut.Checked = True
        Me.Defaut.Location = New System.Drawing.Point(20, 36)
        Me.Defaut.Name = "Defaut"
        Me.Defaut.Size = New System.Drawing.Size(67, 22)
        Me.Defaut.TabIndex = 10
        Me.Defaut.TabStop = True
        Me.Defaut.Text = "Défaut"
        Me.Defaut.UseVisualStyleBackColor = True
        '
        'IUT
        '
        Me.IUT.AutoSize = True
        Me.IUT.Location = New System.Drawing.Point(20, 115)
        Me.IUT.Name = "IUT"
        Me.IUT.Size = New System.Drawing.Size(84, 22)
        Me.IUT.TabIndex = 9
        Me.IUT.Text = "IUT Paris"
        Me.IUT.UseVisualStyleBackColor = True
        '
        'Noel
        '
        Me.Noel.AutoSize = True
        Me.Noel.Location = New System.Drawing.Point(20, 87)
        Me.Noel.Name = "Noel"
        Me.Noel.Size = New System.Drawing.Size(53, 22)
        Me.Noel.TabIndex = 8
        Me.Noel.Text = "Noël"
        Me.Noel.UseVisualStyleBackColor = True
        '
        'HP
        '
        Me.HP.AutoSize = True
        Me.HP.Location = New System.Drawing.Point(20, 59)
        Me.HP.Name = "HP"
        Me.HP.Size = New System.Drawing.Size(99, 22)
        Me.HP.TabIndex = 7
        Me.HP.Text = "Harry Potter"
        Me.HP.UseVisualStyleBackColor = True
        '
        'BoutonSelectionDossier
        '
        Me.BoutonSelectionDossier.Location = New System.Drawing.Point(17, 379)
        Me.BoutonSelectionDossier.Name = "BoutonSelectionDossier"
        Me.BoutonSelectionDossier.Size = New System.Drawing.Size(264, 30)
        Me.BoutonSelectionDossier.TabIndex = 11
        Me.BoutonSelectionDossier.Text = "Choisir le dossier des statistiques"
        Me.BoutonSelectionDossier.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 503)
        Me.Controls.Add(Me.BoutonSelectionDossier)
        Me.Controls.Add(Me.GroupBoxPack)
        Me.Controls.Add(Me.AccueilButton)
        Me.Controls.Add(Me.GroupBoxChoixTimer)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "Options"
        Me.Text = "Options"
        CType(Me.SelecteurTempsJeu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxChoixTimer.ResumeLayout(False)
        Me.GroupBoxChoixTimer.PerformLayout()
        Me.GroupBoxPack.ResumeLayout(False)
        Me.GroupBoxPack.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerChooseLabel As Label
    Friend WithEvents TempsImpartiLabel As Label
    Friend WithEvents SelecteurTempsJeu As NumericUpDown
    Friend WithEvents LabelTitre As Label
    Friend WithEvents GroupBoxChoixTimer As GroupBox
    Friend WithEvents AccueilButton As Button
    Friend WithEvents GroupBoxPack As GroupBox
    Friend WithEvents ModifierTempsJeu As CheckBox
    Friend WithEvents BoutonSelectionDossier As Button
    Friend WithEvents IUT As RadioButton
    Friend WithEvents Noel As RadioButton
    Friend WithEvents HP As RadioButton
    Friend WithEvents Defaut As RadioButton
End Class

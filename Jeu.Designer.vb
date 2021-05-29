<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
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
        Me.JoueurLabel = New System.Windows.Forms.Label()
        Me.NomJoueurLabel = New System.Windows.Forms.Label()
        Me.TempsRestantLabel = New System.Windows.Forms.Label()
        Me.TempsRestantVal = New System.Windows.Forms.Label()
        Me.AbandonButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.PictureBox18 = New System.Windows.Forms.PictureBox()
        Me.PictureBox19 = New System.Windows.Forms.PictureBox()
        Me.PictureBox20 = New System.Windows.Forms.PictureBox()
        Me.GroupBoxImage = New System.Windows.Forms.GroupBox()
        Me.TempsRestatVal = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDelais = New System.Windows.Forms.Timer(Me.components)
        Me.PauseButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxImage.SuspendLayout()
        Me.SuspendLayout()
        '
        'JoueurLabel
        '
        Me.JoueurLabel.AutoSize = True
        Me.JoueurLabel.Location = New System.Drawing.Point(14, 22)
        Me.JoueurLabel.Name = "JoueurLabel"
        Me.JoueurLabel.Size = New System.Drawing.Size(45, 13)
        Me.JoueurLabel.TabIndex = 20
        Me.JoueurLabel.Text = "Joueur :"
        '
        'NomJoueurLabel
        '
        Me.NomJoueurLabel.AutoSize = True
        Me.NomJoueurLabel.Location = New System.Drawing.Point(63, 22)
        Me.NomJoueurLabel.Name = "NomJoueurLabel"
        Me.NomJoueurLabel.Size = New System.Drawing.Size(0, 13)
        Me.NomJoueurLabel.TabIndex = 21
        '
        'TempsRestantLabel
        '
        Me.TempsRestantLabel.AutoSize = True
        Me.TempsRestantLabel.Location = New System.Drawing.Point(14, 51)
        Me.TempsRestantLabel.Name = "TempsRestantLabel"
        Me.TempsRestantLabel.Size = New System.Drawing.Size(80, 13)
        Me.TempsRestantLabel.TabIndex = 22
        Me.TempsRestantLabel.Text = "Temps restant :"
        '
        'TempsRestantVal
        '
        Me.TempsRestantVal.AutoSize = True
        Me.TempsRestantVal.Location = New System.Drawing.Point(241, 25)
        Me.TempsRestantVal.Name = "TempsRestantVal"
        Me.TempsRestantVal.Size = New System.Drawing.Size(0, 13)
        Me.TempsRestantVal.TabIndex = 23
        '
        'AbandonButton
        '
        Me.AbandonButton.Location = New System.Drawing.Point(320, 42)
        Me.AbandonButton.Name = "AbandonButton"
        Me.AbandonButton.Size = New System.Drawing.Size(82, 22)
        Me.AbandonButton.TabIndex = 24
        Me.AbandonButton.Text = "Abandon"
        Me.AbandonButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(11, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(88, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(165, 14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(242, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Location = New System.Drawing.Point(319, 14)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Location = New System.Drawing.Point(11, 111)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Location = New System.Drawing.Point(88, 111)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Location = New System.Drawing.Point(165, 111)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.Location = New System.Drawing.Point(242, 111)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox9.TabIndex = 8
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(319, 111)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox10.TabIndex = 9
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Location = New System.Drawing.Point(11, 208)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox11.TabIndex = 10
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Location = New System.Drawing.Point(88, 208)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox12.TabIndex = 11
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Location = New System.Drawing.Point(165, 208)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox13.TabIndex = 12
        Me.PictureBox13.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.Location = New System.Drawing.Point(242, 208)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox14.TabIndex = 13
        Me.PictureBox14.TabStop = False
        '
        'PictureBox15
        '
        Me.PictureBox15.Location = New System.Drawing.Point(319, 208)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox15.TabIndex = 14
        Me.PictureBox15.TabStop = False
        '
        'PictureBox16
        '
        Me.PictureBox16.Location = New System.Drawing.Point(165, 305)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox16.TabIndex = 15
        Me.PictureBox16.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.Location = New System.Drawing.Point(88, 305)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox17.TabIndex = 16
        Me.PictureBox17.TabStop = False
        '
        'PictureBox18
        '
        Me.PictureBox18.Location = New System.Drawing.Point(11, 305)
        Me.PictureBox18.Name = "PictureBox18"
        Me.PictureBox18.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox18.TabIndex = 17
        Me.PictureBox18.TabStop = False
        '
        'PictureBox19
        '
        Me.PictureBox19.Location = New System.Drawing.Point(242, 304)
        Me.PictureBox19.Name = "PictureBox19"
        Me.PictureBox19.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox19.TabIndex = 18
        Me.PictureBox19.TabStop = False
        '
        'PictureBox20
        '
        Me.PictureBox20.Location = New System.Drawing.Point(319, 304)
        Me.PictureBox20.Name = "PictureBox20"
        Me.PictureBox20.Size = New System.Drawing.Size(71, 91)
        Me.PictureBox20.TabIndex = 19
        Me.PictureBox20.TabStop = False
        '
        'GroupBoxImage
        '
        Me.GroupBoxImage.Controls.Add(Me.PictureBox20)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox19)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox18)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox17)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox16)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox15)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox14)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox9)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox13)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox1)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox12)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox2)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox11)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox3)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox10)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox4)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox5)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox8)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox6)
        Me.GroupBoxImage.Controls.Add(Me.PictureBox7)
        Me.GroupBoxImage.Location = New System.Drawing.Point(12, 67)
        Me.GroupBoxImage.Name = "GroupBoxImage"
        Me.GroupBoxImage.Size = New System.Drawing.Size(405, 410)
        Me.GroupBoxImage.TabIndex = 25
        Me.GroupBoxImage.TabStop = False
        '
        'TempsRestatVal
        '
        Me.TempsRestatVal.AutoSize = True
        Me.TempsRestatVal.Location = New System.Drawing.Point(100, 51)
        Me.TempsRestatVal.Name = "TempsRestatVal"
        Me.TempsRestatVal.Size = New System.Drawing.Size(0, 13)
        Me.TempsRestatVal.TabIndex = 26
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TimerDelais
        '
        Me.TimerDelais.Enabled = True
        Me.TimerDelais.Interval = 800
        '
        'PauseButton
        '
        Me.PauseButton.Location = New System.Drawing.Point(320, 15)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(82, 27)
        Me.PauseButton.TabIndex = 27
        Me.PauseButton.Text = "Pause"
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 489)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.TempsRestatVal)
        Me.Controls.Add(Me.GroupBoxImage)
        Me.Controls.Add(Me.AbandonButton)
        Me.Controls.Add(Me.TempsRestantVal)
        Me.Controls.Add(Me.TempsRestantLabel)
        Me.Controls.Add(Me.NomJoueurLabel)
        Me.Controls.Add(Me.JoueurLabel)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxImage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JoueurLabel As Label
    Friend WithEvents NomJoueurLabel As Label
    Friend WithEvents TempsRestantLabel As Label
    Friend WithEvents TempsRestantVal As Label
    Friend WithEvents AbandonButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents PictureBox18 As PictureBox
    Friend WithEvents PictureBox19 As PictureBox
    Friend WithEvents PictureBox20 As PictureBox
    Friend WithEvents GroupBoxImage As GroupBox
    Friend WithEvents TempsRestatVal As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimerDelais As Timer
    Friend WithEvents PauseButton As Button
End Class

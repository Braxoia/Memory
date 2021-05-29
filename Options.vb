''' <summary>
''' Correspond au formulaire affichant les options
''' </summary>
Public Class Options
    ''' <summary>
    ''' Appelé quand le timer est activé/désactivé dans les options
    ''' </summary>
    Private Sub ModifierTempsJeu_Click() Handles ModifierTempsJeu.CheckedChanged
        TimerChooseLabel.Enabled = ModifierTempsJeu.Checked
        SelecteurTempsJeu.Enabled = ModifierTempsJeu.Checked
        Parametres.TimerRequis = ModifierTempsJeu.Checked
    End Sub

    ''' <summary>
    ''' Appelé quand le formulaire est fermé
    ''' </summary>
    Private Sub Options_Closed() Handles MyBase.Closed
        Accueil.Show()
    End Sub

    ''' <summary>
    ''' Appelé quand le formulaire est fermé via le bouton pour retourner à l'accueil
    ''' </summary>
    Private Sub AccueilButton_Click() Handles AccueilButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Permet de sélectionner le dossier où lire/stocker le fichier d'enregistrements
    ''' </summary>
    Private Sub BouttonSelectionDossier_Click() Handles BoutonSelectionDossier.Click
        Using emplacement As New FolderBrowserDialog
            If emplacement.ShowDialog() = DialogResult.OK Then
                Parametres.CheminDossierSauvegarde = emplacement.SelectedPath
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Permet de mettre à jour le temps initial du compte à rebours du jeu
    ''' </summary>
    Private Sub SelecteurJeu_Changed() Handles SelecteurTempsJeu.ValueChanged
        Parametres.TempsTimer = SelecteurTempsJeu.Value
    End Sub

    ''' <summary>
    ''' Permet de changer le thème du jeu de cartes utilisé
    ''' </summary>
    ''' <param name="sender">Le radiobutton qui a été coché</param>
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Defaut.CheckedChanged, IUT.CheckedChanged, HP.CheckedChanged, Noel.CheckedChanged
        Parametres.SetCartes = CType(sender, RadioButton).Name
    End Sub
End Class

Imports System.IO

''' <summary>
''' Formulaire principal de l'application.
''' </summary>
Public Class Accueil
    Const NOM_FICHIER_CONFIG = "config.txt"

    ''' <summary>
    ''' Initialise le jeu: le fichier de configuration est lu pour y récupérer le chemin du fichier de sauvegarde.
    ''' On initialise aussi la liste de noms
    ''' </summary>
    Private Sub Accueil_Load() Handles MyBase.Load
        PictureAccueil.Image = Image.FromFile("Images/memory.png")
        PictureAccueil.SizeMode = PictureBoxSizeMode.StretchImage

        'on essaye d'ouvrir le fichier de configuration: si on n'y arrive pas, on le crée
        Dim numero = FreeFile()
        Try
            FileOpen(numero, NOM_FICHIER_CONFIG, OpenMode.Input)
        Catch ex As Exception
            FileOpen(numero, NOM_FICHIER_CONFIG, OpenMode.Append)
            PrintLine(numero, ".")
            FileClose(numero)
            Parametres.CheminDossierSauvegarde = "."
            Exit Sub
        End Try

        'on récupère l'emplacement du fichier de sauvegarde
        Dim chemin As String = LineInput(numero)
        FileClose(numero)
        Parametres.CheminDossierSauvegarde = chemin

        'on charge les noms des joueurs dans la liste
        ChargerNoms()
    End Sub

    ''' <summary>
    ''' Charge les noms de tous les joueurs pour les ajouter à la liste de joueurs
    ''' </summary>
    Private Sub ChargerNoms()
        Enregistrement.ChargerJoueurs() 'on recharge les joueurs au cas où il y a eu des changements
        ListeJoueurs.Items.Clear()
        For Each joueur In Enregistrement.GetListeJoueurs()
            ListeJoueurs.Items.Add(joueur.nom)
        Next
    End Sub

    ''' <summary>
    ''' Enregistre dans le fichier de configuration le dossier où se situe le fichier de statistiques
    ''' </summary>
    Public Sub EnregistrerCheminFichierConfig()
        'on écrase le contenu existant, et on met à jour le chemin
        File.Delete(NOM_FICHIER_CONFIG)
        Dim numero = FreeFile()
        FileOpen(numero, NOM_FICHIER_CONFIG, OpenMode.Append)
        PrintLine(numero, Parametres.CheminDossierSauvegarde())
        FileClose(numero)
    End Sub

    ''' <summary>
    ''' Nettoie l'application avant de la quitter
    ''' </summary>
    Private Sub ArretButton_Click() Handles ArretButton.Click, Me.Closed
        'on enregistre les joueurs à la fin de l'application ainsi que le chemin du fichier de sauvegarde au cas où ils auraient changé
        If MsgBox("Voulez-vous quitter l'application ?", MsgBoxStyle.YesNo, "Quitter") = vbYes Then
            Enregistrement.EnregistrerJoueurs()
            EnregistrerCheminFichierConfig()
            Application.Exit()
        End If
    End Sub

    ''' <summary>
    ''' Permet de vérifier que l'utilisateur n'entre que des caractères dans son nom
    ''' </summary>
    ''' <param name="sender">L'envoyeur de l'event</param>
    ''' <param name="e">l'Event d'appui</param>
    Private Sub ListeJoueurs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ListeJoueurs.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
            MsgBox("Veuillez n'entrer que des lettres !")
        End If
    End Sub

    ''' <summary>
    ''' Permet de lancer une partie quand le bouton correspondant est cliqué.
    ''' </summary>
    Private Sub NvPartieButton_Click() Handles NvPartieButton.Click
        If Len(ListeJoueurs.Text) < 3 Then
            ListeJoueurs.BackColor = Color.Red
            Exit Sub
        End If

        Me.Hide()
        If Not Enregistrement.GetNomJoueurs().Contains(ListeJoueurs.Text) Then
            ListeJoueurs.Items.Add(ListeJoueurs.Text)
        End If
        Jeu.Show()
    End Sub

    ''' <summary>
    ''' Affiche la liste en blanc si la liste était en rouge lors d'un clic
    ''' </summary>
    Private Sub ListeJoueurs_Click() Handles ListeJoueurs.Click
        If ListeJoueurs.BackColor = Color.Red Then
            ListeJoueurs.BackColor = Color.White
        End If
    End Sub

    ''' <summary>
    ''' Ouvre le formulaire des scores.
    ''' </summary>
    Private Sub TabScoreButton_Click() Handles TabScoreButton.Click
        Me.Hide()
        Statistiques.Show()
    End Sub

    ''' <summary>
    ''' Ouvre le formulaire des options
    ''' </summary>
    Private Sub OptionsButton_Click() Handles OptionsButton.Click
        Me.Hide()
        Options.Show()
    End Sub
End Class

Imports System.Threading
Public Class Jeu
    Private CHEMIN_CARTE As String = "Images/"

    Private timerRequis As Boolean

    Private timerLance As Boolean = False

    Private WithEvents timer As TimerCompteARebours

    Private memory As Memory

    ''' <summary>
    ''' Charge une partie de Memory: on initialise le jeu et le timer
    ''' </summary>
    Private Sub Jeu_Load() Handles MyBase.Load
        InitialisationJeu()
        timerRequis = Parametres.TimerRequis()

        If Not timerRequis Then
            PauseButton.Enabled = False
            TempsRestatVal.Text = "-"
        End If
    End Sub

    ''' <summary>
    ''' Initialise le jeu: on charge les images et on crée le timer
    ''' </summary>
    Private Sub InitialisationJeu()
        timer = New TimerCompteARebours(Parametres.TempsTimer)
        memory = New Memory()

        NomJoueurLabel.Text = Accueil.ListeJoueurs.Text
        CHEMIN_CARTE = CHEMIN_CARTE & Parametres.SetCartes & "/"

        For Each img As PictureBox In GroupBoxImage.Controls 'pour chaque image, on lui définit son handler dynamiquement (cela permet de ne pas à avoir à l'écrire 20 fois dans le code)
            AddHandler img.Click, AddressOf ClickCarte
            img.Image = Image.FromFile(CHEMIN_CARTE & "BackCard.png")
            img.SizeMode = PictureBoxSizeMode.StretchImage
        Next
    End Sub

    ''' <summary>
    ''' Permet de gérer une carte lorsqu'elle est cliquée
    ''' </summary>
    ''' <param name="sender">La carte cliquée</param>
    ''' <param name="e">Inutile</param>
    Private Sub ClickCarte(sender As Object, e As EventArgs)
        If timerRequis And Not timerLance Then 'on démarre le timer quand une première carte est cliquée
            timer.Demarrer()
            timerLance = True
        End If

        Dim numPictureBox = Int(Split(sender.Name, "x")(1)) - 1 'on récupère l'index de la picturebox grâce à son nom. exemple: PictureBox1 => 1
        Dim carte As String = "Card" & memory.ValeurCarte(numPictureBox) & ".png" 'on change l'image de la carte pour la montrer de face
        sender.Image = Image.FromFile(CHEMIN_CARTE & carte)

        If Not memory.RetournerCarte(numPictureBox, timer.TempsEcoule()) Then 'si on ne peut pas la retourner, on la remasque
            GroupBoxImage.Enabled = False
            TimerDelais.Start()

            Exit Sub
        End If

        If memory.PartieFinie() Then
            MsgBox("Bravo ! Vous avez découvert toutes les cartes.")
            FinDePartie(False)
        End If
    End Sub

    ''' <summary>
    ''' A chaque fois qu'une seconde s'écoule, on met à jour le texte correspondant au temps restant
    ''' </summary>
    Private Sub CompteAReboursActualise() Handles timer.Tick
        TempsRestatVal.Text = timer.TempsFormatte()
    End Sub

    ''' <summary>
    ''' Permet de gérer la fin de la partie si le compteur se termine
    ''' </summary>
    Private Sub CompteAReboursTermine() Handles timer.Termine
        timer.Arreter()
        Dim carresTrouves = memory.NombreCartesRetournees() / 4

        If carresTrouves = 0 Then
            MsgBox("Vous n'avez pas trouvé de carré.", , "Partie Terminée")
        Else
            MsgBox("Vous avez trouvé " & carresTrouves & " carrés en " & memory.TempsDeMemorisation() & " secondes !", , "Partie Terminée")
        End If

        FinDePartie(False)
    End Sub

    ''' <summary>
    ''' Gère la fin de partie: ajoute un joueur dans les enregistrements
    ''' </summary>
    ''' <param name="abandon">si le joueur a abandonné ou non</param>
    Private Sub FinDePartie(abandon As Boolean)

        Dim joueur As New Joueur
        'Si le joueur a abandonné la partie, on ne retient ni les carrés qu'il a trouvé ni le temps de mémorisation de ces carrés
        With joueur
            .nom = NomJoueurLabel.Text
            .tempsJoue = timer.TempsEcoule()

            If abandon = False Then
                .tempsMemorisation = memory.TempsDeMemorisation()
                .nombreCarresMemorises = memory.NombreCartesRetournees() / 4
            Else
                .tempsMemorisation = 0
                .nombreCarresMemorises = 0
            End If
        End With

        joueur.nombrePartiesJouees = 1
        Enregistrement.AjouterJoueur(joueur)

        For Each img As PictureBox In GroupBoxImage.Controls
            img.Enabled = False
        Next

        timerLance = False
        timer.Arreter()
        Me.Close()
    End Sub

    ''' <summary>
    ''' Utilisé pour retourner une carte quand on clique dessus sans pauser le timer principal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TimerDelais_Tick(sender As Object, e As EventArgs) Handles TimerDelais.Tick
        TimerDelais.Stop()
        GroupBoxImage.Enabled = True

        For Each img As PictureBox In GroupBoxImage.Controls
            If Not memory.CarteRetournee(Int(Split(img.Name, "x")(1)) - 1) Then
                img.Image = Image.FromFile(CHEMIN_CARTE & "BackCard.png")
                img.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        Next
    End Sub

    ''' <summary>
    ''' Permet de gérer l'abandon d'un joueur
    ''' </summary>
    Private Sub AbandonButton_Click() Handles AbandonButton.Click
        If timerRequis Then Timer1.Stop()
        Dim reponse = MsgBox("Voulez-vous vraiment arrêter votre partie ?", vbYesNo, "Arrêt de la partie")
        If reponse = vbNo Then
            If timerRequis Then Timer1.Start()
            Exit Sub
        End If

        FinDePartie(True)
    End Sub

    ''' <summary>
    ''' Est appelé si le timer est mis en pause ou est réactivé.
    ''' </summary>
    Private Sub PauseButton_Click() Handles PauseButton.Click
        If Not timerRequis Then Exit Sub
        timer.Switcher()
        GroupBoxImage.Enabled = timer.EstActif()
        PauseButton.Text = If(timer.EstActif(), "Pause", "Reprendre")
    End Sub
    ''' <summary>
    ''' Lorsque le formulaire de jeu est fermé
    ''' </summary>
    Private Sub OnClose() Handles MyBase.Closed
        Accueil.Show()
    End Sub
End Class
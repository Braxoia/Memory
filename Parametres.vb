''' <summary>
''' Stocke les différentes options du jeu
''' </summary>
Module Parametres

    Private cheminDossierSauvegarde_ As String 'Le chemin du dossier où l'on sauvegarde
    Private timerRequis_ As Boolean = True 'Si on doit faire un compte à rebours pour le jeu
    Private tempsTimer_ As Integer = 60 'Le temps du timer (de base à 60 secondes)
    Private nomCartes_ As String = "Defaut" 'Le dossier où sont stockées les cartes par défaut
    Const nomFichierSauvegarde = "stats.txt" 'Le fichier de sauvegarde

    ''' <summary>
    ''' Chemin du dossier dans lequel le fichier de sauvegarde va être enregistré
    ''' </summary>
    ''' <returns></returns>
    Public Property CheminDossierSauvegarde() As String
        Get
            Return cheminDossierSauvegarde_
        End Get
        Set(value As String)
            cheminDossierSauvegarde_ = value
        End Set
    End Property

    ''' <summary>
    ''' True si le jeu doit utiliser un timer, False sinon
    ''' </summary>
    ''' <returns></returns>
    Public Property TimerRequis As Boolean
        Get
            Return timerRequis_
        End Get
        Set(value As Boolean)
            timerRequis_ = value
        End Set
    End Property

    ''' <summary>
    ''' Le temps initial du compte à rebours pour une partie de memory
    ''' </summary>
    ''' <returns></returns>
    Public Property TempsTimer As Integer
        Get
            Return tempsTimer_
        End Get
        Set(value As Integer)
            tempsTimer_ = value
        End Set
    End Property

    ''' <summary>
    ''' Le nom du set de cartes utilisé pour l'affichage
    ''' </summary>
    ''' <returns></returns>
    Public Property SetCartes As String
        Get
            Return nomCartes_
        End Get
        Set(value As String)
            If value = vbNullString Then
                Exit Property
            End If
            nomCartes_ = value
        End Set
    End Property

    ''' <summary>
    ''' Chemin du fichier de sauvegarde
    ''' </summary>
    ''' <returns>Retourne le chemin de sauvegarde</returns>
    Public Function CheminFichierSauvegarde() As String
        Return cheminDossierSauvegarde_ & "\" & nomFichierSauvegarde
    End Function

End Module

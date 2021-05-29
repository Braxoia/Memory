''' <summary>
''' Représente une grille de Memory
''' </summary>
Public Class Memory
    Private Const NOMBRE_CARTES = 20
    Private Const TAILLE_NUPLET_CARTES = 4
    Private Const NOMBRE_NUPLETS = NOMBRE_CARTES / TAILLE_NUPLET_CARTES

    Private cartes(NOMBRE_CARTES - 1) As Integer
    Private carteMemorisee As Integer 'la valeur de la dernière carte retournée
    Private numeroCarteMemorisee As Integer 'l'index de la dernière carte retournée
    Private cartesRetourneesTmp As ArrayList
    Private cartesRetourneesDef As ArrayList
    Private tempsMemorisation As Integer

    ''' <summary>
    ''' Crée un memory: on initialise les cartes avec leurs valeurs correspondantes (0, 1, 2, 3, 4) puis on les mélange
    ''' </summary>
    Public Sub New()
        cartesRetourneesTmp = New ArrayList()
        cartesRetourneesDef = New ArrayList()

        carteMemorisee = -1
        numeroCarteMemorisee = -1
        tempsMemorisation = 0
        'on génère les valeurs des cartes dans l'ordre (par exemple 0 0 0 0 1 1 1 1 2 2 2 2 3 3 3 3 4 4 4 4)
        For i = 0 To NOMBRE_NUPLETS - 1
            For j = 0 To TAILLE_NUPLET_CARTES - 1
                cartes(TAILLE_NUPLET_CARTES * i + j) = i
            Next
        Next

        MelangerCartes() 'puis on les mélange
    End Sub

    ''' <summary>
    ''' Permet de mélanger les cartes
    ''' </summary>
    Private Sub MelangerCartes()
        Randomize()
        For i = 0 To NOMBRE_CARTES - 1
            Dim iRandom As Integer = Int(Rnd() * (NOMBRE_CARTES - 1))
            Intervertir(i, iRandom)
        Next
    End Sub

    ''' <summary>
    ''' Permet d'intervertir deux cartes
    ''' </summary>
    ''' <param name="i">L'index de la première carte à intervertir</param>
    ''' <param name="iRandom">L'index de la seconde carte à intervertir</param>
    Private Sub Intervertir(i As Integer, iRandom As Integer)
        Dim cartetmp As Integer = cartes(i)
        cartes(i) = cartes(iRandom)
        cartes(iRandom) = cartetmp
    End Sub

    ''' <summary>
    ''' Effectue une tentative de retournement d'une carte
    ''' </summary>
    ''' <param name="numCarte">le numéro de la carte retournée</param>
    ''' <param name="tempsAMemoriser">le temps pris pour trouver un nouveau carré, si c'est le cas</param>
    ''' <returns>True si la carte peut être retournée (ex: c'est la même que celles qui le sont déjà), False sinon</returns>
    Public Function RetournerCarte(numCarte As Integer, tempsAMemoriser As Integer) As Boolean
        If cartesRetourneesDef.Contains(numCarte) Then Return True 'si la carte retournée a déjà été trouvée, on quitte
        If numeroCarteMemorisee = numCarte Then Return True 'si la carte retournée est la même que la précédente, on quitte

        If carteMemorisee <> cartes(numCarte) And carteMemorisee <> -1 Then 'si la carte ne correspond pas aux cartes déjà retournées
            NettoyerCartesRetournees() 'on retourne toutes les cartes
            Return False
        End If

        'la carte retournée est valide, on l'ajoute à la liste des cartes retournées
        carteMemorisee = cartes(numCarte)
        numeroCarteMemorisee = numCarte

        cartesRetourneesTmp.Add(numCarte)

        AjouterCarre(tempsAMemoriser)

        Return True
    End Function

    ''' <summary>
    ''' Ajoute un carré dans les cartes définitivement retournées (une fois qu'un carré est trouvé, on le laisse face visible)
    ''' </summary>
    ''' <param name="tempsAMemoriser">le temps pris pour trouver un nouveau carré, si c'est le cas</param>
    Private Sub AjouterCarre(tempsAMemoriser As Integer)
        If cartesRetourneesTmp.Count = TAILLE_NUPLET_CARTES Then 'si on a trouvé un carré, on l'ajoute dans les cartes trouvées définitivement
            cartesRetourneesDef.AddRange(cartesRetourneesTmp)
            NettoyerCartesRetournees()
            tempsMemorisation = tempsAMemoriser 'on met à jour le temps de mémorisation quand on trouve un carré
        End If
    End Sub

    ''' <summary>
    ''' Permet de masquer toutes les cartes retournées temporairement (c'est-à-dire celles qui ne sont pas des carrés)
    ''' </summary>
    Private Sub NettoyerCartesRetournees()
        cartesRetourneesTmp.Clear()
        carteMemorisee = -1
    End Sub

    ''' <summary>
    ''' Vérifie si la partie est finie
    ''' </summary>
    ''' <returns>True si tous les carrés ont été retournés, False sinon</returns>
    Public Function PartieFinie() As Boolean
        Return cartesRetourneesDef.Count = NOMBRE_CARTES
    End Function

    ''' <summary>
    ''' Renvoie la valeur d'une carte, c'est-à-dire le numéro de son carré
    ''' </summary>
    ''' <param name="indexCarte">l'index de la carte dont on souhaite connaitre la valeur</param>
    ''' <returns>la valeur de la carte</returns>
    Public Function ValeurCarte(indexCarte As Integer) As Integer
        Return cartes(indexCarte)
    End Function

    ''' <summary>
    ''' Renvoie le nombre de cartes retournées (tous les carrés)
    ''' </summary>
    ''' <returns></returns>
    Public Function NombreCartesRetournees() As Integer
        Return cartesRetourneesDef.Count
    End Function

    ''' <summary>
    ''' Vérifie qu'une carte soit retournée ou non
    ''' </summary>
    ''' <param name="numCarte">le numéro de la carte à tester</param>
    ''' <returns></returns>
    Public Function CarteRetournee(numCarte As Integer) As Boolean
        Return cartesRetourneesDef.Contains(numCarte)
    End Function

    ''' <summary>
    ''' Renvoie le temps de mémorisation, c'est-à-dire le temps que le joueur a pris pour retourner un maximum de carrés
    ''' </summary>
    ''' <returns>le temps de mémorisation</returns>
    Public Function TempsDeMemorisation() As Integer
        Return tempsMemorisation
    End Function

End Class

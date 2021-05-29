''' <summary>
''' Représente un joueur, avec
''' - son nom
''' - le nombre maximal de carrés qu'il a mémorisé en une partie
''' - le temps qu'il a mis pour trouver les carrés
''' - le total de temps qu'il a joué
''' </summary>
Public Structure Joueur : Implements IEquatable(Of Joueur), IComparable(Of Joueur)
    Dim nom As String
    Dim nombreCarresMemorises As Integer
    Dim tempsMemorisation As Integer
    Dim nombrePartiesJouees
    Dim tempsJoue

    ''' <summary>
    ''' Constructeur du Joueur créé
    ''' </summary>
    ''' <param name="nom">Le nom du joueur</param>
    ''' <param name="nombreCarresMemorises">Le nombre de carrés que le joueur a mémorisé durant la partie</param>
    ''' <param name="tempsMemorisation">Le temps pris pour les mémoriser</param>
    ''' <param name="nombrePartiesJouees">Le nombre de parties jouées du joueur</param>
    ''' <param name="tempsJoue">Le temps durant lequel le joueur a joué</param>
    Public Sub New(nom As String, nombreCarresMemorises As String, tempsMemorisation As String, nombrePartiesJouees As String, tempsJoue As String)
        Me.nom = nom
        Me.nombreCarresMemorises = Me.nombreCarresMemorises
        Me.tempsMemorisation = tempsMemorisation
        Me.nombrePartiesJouees = nombrePartiesJouees
        Me.tempsJoue = tempsJoue
    End Sub

    ''' <summary>
    ''' Crée un nouveau joueur à partir de sa représentation sous forme de chaîne (notamment depuis un fichier)
    ''' </summary>
    ''' <param name="representation">La représentation</param>
    Public Sub New(representation As String)
        Dim informations = representation.Split(" ")

        nom = informations(0)
        nombreCarresMemorises = informations(1)
        tempsMemorisation = informations(2)
        nombrePartiesJouees = informations(3)
        tempsJoue = informations(4)
    End Sub

    ''' <summary>
    ''' Renvoie les informations du joueur sous forme de chaîne afin de pouvoir l'écrire dans un fichier
    ''' </summary>
    ''' <returns>les informations du joueur sous forme de chaîne</returns>
    Public Function Converti() As String
        Return nom & " " & nombreCarresMemorises & " " & tempsMemorisation & " " & nombrePartiesJouees & " " & tempsJoue
    End Function

    ''' <summary>
    ''' Teste l'égalité de deux joueurs via leurs noms, utilisé pour Contains
    ''' </summary>
    ''' <param name="other">le joueur avec lequel on compare</param>
    ''' <returns>True si les joueurs ont le même nom, False sinon</returns>
    Public Function Equals(other As Joueur) As Boolean Implements IEquatable(Of Joueur).Equals
        'On implémente IEquatable pour redéfinir comment est-ce que l'on considère que deux joueurs sont égaux.
        Return other.nom = nom
    End Function

    ''' <summary>
    ''' Permet de comparer deux joueurs entre eux. Utilisé pour trier une liste de joueurs
    ''' en fonction du nombre de carrés qu'ils ont trouvé. Si ce nombre est identique
    ''' </summary>
    ''' <param name="other">le joueur avec lequel on compare</param>
    ''' <returns>1 si other a un meilleur score que Me, 0 s'ils ont le même score, -1 sinon</returns>
    Public Function CompareTo(other As Joueur) As Integer Implements IComparable(Of Joueur).CompareTo
        If other.nombreCarresMemorises > Me.nombreCarresMemorises Then Return 1 'si un joueur à un nombre de carrés plus grand, alors il a un meilleur score
        If other.nombreCarresMemorises < Me.nombreCarresMemorises Then Return -1

        'si le nombre de carrés est identique, on départage grâce au temps pris pour les trouver: le plus petit est le meilleur
        If other.tempsMemorisation < Me.tempsMemorisation Then Return 1
        If other.tempsMemorisation > Me.tempsMemorisation Then Return -1

        'les joueurs ont un score égal
        Return 0
    End Function
End Structure

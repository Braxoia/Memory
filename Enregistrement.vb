Imports System.IO

''' <summary>
''' Permet de gérer, de charger et de sauvegarder les informations sur les joueurs.
''' </summary>
Public Module Enregistrement
    ''' <summary>
    ''' Ordre de tri pour l'affichage des joueurs.
    ''' </summary>
    Public Enum OrdreTri
        Croissant
        Decroissant
    End Enum

    Private listeJoueurs As New List(Of Joueur) 'La liste des joueurs ayant joué au moins une fois au jeu

    ''' <summary>
    ''' Charge les scores depuis le fichier de sauvegarde.
    ''' </summary>
    Public Sub ChargerJoueurs()
        listeJoueurs.Clear()
        Dim numero = FreeFile()
        FileOpen(numero, Parametres.CheminFichierSauvegarde(), OpenAccess.Read)

        Dim buffer As String

        While Not EOF(numero)
            buffer = LineInput(numero)
            listeJoueurs.Add(New Joueur(buffer)) 'on transforme la chaîne en joueur grâce au constructeur
        End While

        FileClose(numero)
    End Sub

    ''' <summary>
    ''' Ajoute un joueur dans la liste s'il n'existe pas, sinon on le met à jour
    ''' </summary>
    ''' <param name="joueur"></param>
    Public Sub AjouterJoueur(joueur As Joueur)
        If listeJoueurs.Contains(joueur) Then 'si le joueur existe, on le met à jour
            MajJoueur(joueur)
        Else 'sinon, on l'ajoute
            listeJoueurs.Add(joueur)
        End If
        EnregistrerJoueurs()
    End Sub

    ''' <summary>
    ''' Met à jour un joueur dans une liste
    ''' </summary>
    ''' <param name="joueur">Le joueur à mettre à jour</param>
    Private Sub MajJoueur(joueur As Joueur)
        Dim indice As Integer = listeJoueurs.IndexOf(joueur)
        Dim joueurTemp As Joueur = listeJoueurs(indice)
        joueurTemp.nombrePartiesJouees += 1 'on ajoute au joueur une partie jouée
        joueurTemp.tempsJoue += joueur.tempsJoue 'on cumule le temps joué

        If joueur.nombreCarresMemorises > joueurTemp.nombreCarresMemorises Then 'on met à jour le nombre de carrés s'il est meilleur que son score précédent
            joueurTemp.nombreCarresMemorises = joueur.nombreCarresMemorises
            joueurTemp.tempsMemorisation = joueur.tempsMemorisation
        End If

        listeJoueurs.RemoveAt(indice) 'on supprime l'ancien enregistrement
        listeJoueurs.Insert(indice, joueurTemp) 'et on ajoute le nouveau
    End Sub

    ''' <summary>
    ''' Enregistre les scores dans le fichier de configuration
    ''' </summary>
    Public Sub EnregistrerJoueurs()
        File.Delete(Parametres.CheminFichierSauvegarde()) 'on écrase le contenu du fichier pour le remplacer
        Dim numero = FreeFile()
        FileOpen(numero, Parametres.CheminFichierSauvegarde(), OpenMode.Append)

        For Each joueur As Joueur In listeJoueurs
            PrintLine(numero, joueur.Converti())
        Next

        FileClose(numero)
    End Sub

    ''' <summary>
    ''' Trie la liste des scores en fonction du nombre de carrés trouvés et du temps requis pour le faire
    ''' </summary>
    ''' <param name="ordre"></param>
    Public Sub Trier(ordre As OrdreTri)
        If ordre = OrdreTri.Croissant Then
            listeJoueurs.Sort()
        Else
            listeJoueurs.Sort(New ComparateurJoueurInverse())
        End If
    End Sub

    ''' <summary>
    ''' Retourne la liste des joueurs
    ''' </summary>
    ''' <returns>La liste de joueurs</returns>
    Public Function GetListeJoueurs() As List(Of Joueur)
        Return listeJoueurs
    End Function

    ''' <summary>
    ''' Récupère le nom des joueurs seulement
    ''' </summary>
    ''' <returns>La liste contenant le nom des joueurs</returns>
    Public Function GetNomJoueurs() As ArrayList
        ChargerJoueurs()
        Dim noms As New ArrayList
        For Each joueur As Joueur In listeJoueurs
            noms.Add(joueur.nom)
        Next
        Return noms
    End Function
End Module

''' <summary>
''' Permet de comparer les joueurs dans l'ordre décroissant
''' </summary>
Public Class ComparateurJoueurInverse : Implements IComparer(Of Joueur)
    ''' <summary>
    ''' Fonction requise pour List.Sort: compare deux joueurs
    ''' </summary>
    ''' <param name="x">Le premier joueur à comparer</param>
    ''' <param name="y">Le deuxième joueur à comparer</param>
    ''' <returns>1 si le premier joueur a un meilleur score, -1 si c'est le contraire, 0 si ils ont les mêmes scores</returns>
    Public Function Compare(x As Joueur, y As Joueur) As Integer Implements IComparer(Of Joueur).Compare
        Return y.CompareTo(x)
    End Function
End Class

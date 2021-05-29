''' <summary>
''' Formulaire permettant d'afficher les scores des joueurs
''' </summary>
Public Class Statistiques
    Private triCroissant As Boolean 'Si le tri doit être croissant ou non
    ''' <summary>
    ''' Appelé quand le formulaire est chargé: on charge et on affiche les enregistrements par ordre croissant
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Statistique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Enregistrement.ChargerJoueurs()
        Enregistrement.Trier(OrdreTri.Croissant)
        ChargerStatistiques()
        triCroissant = True
    End Sub

    ''' <summary>
    ''' Permet de (re)charger les enregistrements et de les afficher
    ''' </summary>
    Public Sub ChargerStatistiques()
        ClearListes() 'on supprime les enregistrements existants dans les listes

        'et on les recharge pour les ajouter
        For Each joueur As Joueur In Enregistrement.GetListeJoueurs()
            NomJoueurs.Items.Add(joueur.nom)
            CarresMaxMemorises.Items.Add(joueur.nombreCarresMemorises)
            TempsMinimum.Items.Add(joueur.tempsMemorisation & "sec")
            NbPartiesJouees.Items.Add(joueur.nombrePartiesJouees)
            NbHeuresJeu.Items.Add(joueur.tempsJoue \ 3600 & "h:" & joueur.tempsJoue \ 60 & "min:" & joueur.tempsJoue Mod 60 & "sec")
            ComboBoxJoueurs.Items.Add(joueur.nom)
        Next
    End Sub

    ''' <summary>
    ''' Supprime le contenu des listes
    ''' </summary>
    Private Sub ClearListes()
        NomJoueurs.Items.Clear()
        CarresMaxMemorises.Items.Clear()
        TempsMinimum.Items.Clear()
        NbPartiesJouees.Items.Clear()
        NbHeuresJeu.Items.Clear()
        ComboBoxJoueurs.Items.Clear()
    End Sub

    ''' <summary>
    ''' Appelé quand le formulaire est fermé
    ''' </summary>
    Private Sub Statistiques_Close() Handles MyBase.Closed
        Accueil.Show()
    End Sub

    ''' <summary>
    ''' Appelé quand le formulaire est fermé via le bouton pour retourner à l'accueil
    ''' </summary>
    Private Sub AccueilButton_Click() Handles AccueilButton.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Appelé quand on sélectionne un item d'une liste pour sélectionner les éléments correspondants dans toutes les listes
    ''' </summary>
    Private Sub Liste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TempsMinimum.SelectedIndexChanged, NomJoueurs.SelectedIndexChanged, NbHeuresJeu.SelectedIndexChanged,
                                                                                     NbPartiesJouees.SelectedIndexChanged, CarresMaxMemorises.SelectedIndexChanged
        'on met à jour toutes les listes grâce à l'index de l'élément sélectionné dans la liste à l'origine de l'évènement
        'l'element de la liste selectionnée est mis en TopIndex avec les élements en rapport avec celui-ci si l'information est trouvée
        'lorsque l'on scroll

        Dim i As Integer = sender.SelectedIndex
        With TempsMinimum
            .SelectedIndex = i
            .TopIndex = i
        End With

        With NomJoueurs
            .SelectedIndex = i
            .TopIndex = i
        End With

        With NbHeuresJeu
            .SelectedIndex = i
            .TopIndex = i
        End With

        With NbPartiesJouees
            .SelectedIndex = i
            .TopIndex = i
        End With

        With CarresMaxMemorises
            .SelectedIndex = i
            .TopIndex = i
        End With

        ComboBoxJoueurs.Text = NomJoueurs.SelectedItem

    End Sub

    ''' <summary>
    ''' Appelé quand l'utilisateur souhaite afficher les enregistrements dans l'ordre croissant/décroissant
    ''' </summary>
    Private Sub BoutonChangementOrdre_Click(sender As Object, e As EventArgs) Handles BoutonChangementOrdre.Click
        triCroissant = Not triCroissant
        Enregistrement.Trier(If(triCroissant, Enregistrement.OrdreTri.Croissant, Enregistrement.OrdreTri.Decroissant))
        ChargerStatistiques()
        BoutonChangementOrdre.Text = If(triCroissant, "Trier dans l'ordre décroissant", "Trier dans l'ordre croissant")
    End Sub

    ''' <summary>
    ''' Appelé quand l'utilisateur souhaite afficher les détails du joueur entré
    ''' </summary>
    Private Sub ButtonRecherche_Click(sender As Object, e As EventArgs) Handles ButtonRecherche.Click
        If Not ComboBoxJoueurs.Text = vbNullString Then
            For i As Integer = 0 To NomJoueurs.Items.Count - 1
                If ComboBoxJoueurs.Text = NomJoueurs.Items(i) Then
                    MsgBox("Le joueur " & NomJoueurs.Items(i) & " a mémorisé " & CarresMaxMemorises.Items(i) & " carré(s) en " & TempsMinimum.Items(i)(0) & " seconde(s)." & vbNewLine &
                    "Il a joué " & NbPartiesJouees.Items(i) & " partie(s) et a joué " & NbHeuresJeu.Items(i) & ".")
                    NomJoueurs.SelectedIndex = i
                    Exit Sub
                End If
            Next
        End If
    End Sub
End Class
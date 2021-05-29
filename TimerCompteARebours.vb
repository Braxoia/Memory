''' <summary>
''' Un Timer spécialisé pour gérer un compte à rebours
''' </summary>
Public Class TimerCompteARebours

    Private tempsRestantInitial As Integer 'Le temps du timer avant le début du compte à rebours
    Private tempsRestantActuel As Integer 'Le temps dans lequel on se trouve durant la partie

    Private WithEvents timer As Timer 'Le timer rattaché à ses events

    Public Event Termine() 'quand le compte à rebours se termine
    Public Event Tick() 'appelé dès qu'une seconde s'écoule

    ''' <summary>
    ''' Crée le timer
    ''' </summary>
    ''' <param name="tempsDepart">Le temps initial du compte à rebours</param>
    Public Sub New(tempsDepart As Integer)
        timer = New Timer()
        timer.Interval = 1000 '1 seconde d'intervalle (1000ms)
        tempsRestantInitial = tempsDepart
        tempsRestantActuel = tempsRestantInitial
    End Sub

    ''' <summary>
    ''' Démarre le timer
    ''' </summary>
    Public Sub Demarrer()
        timer.Start()
    End Sub

    ''' <summary>
    ''' Arrête le timer
    ''' </summary>
    Public Sub Arreter()
        timer.Stop()
    End Sub

    ''' <summary>
    ''' Active le timer s'il ne l'est pas, le désactive s'il l'est
    ''' </summary>
    Public Sub Switcher()
        timer.Enabled = Not timer.Enabled
    End Sub

    ''' <summary>
    ''' Renvoie l'état du timer
    ''' </summary>
    ''' <returns>True s'il est actif, False s'il est en pause</returns>
    Public Function EstActif() As Boolean
        Return timer.Enabled
    End Function

    ''' <summary>
    ''' Renvoie une chaîne de caractères correspondant au temps restant du timer
    ''' </summary>
    ''' <returns></returns>
    Public Function TempsFormatte() As String
        Return String.Format("{0}:{1:00}", tempsRestantActuel \ 60, tempsRestantActuel Mod 60)
    End Function

    ''' <summary>
    ''' Renvoie le temps écoulé depuis le lancement du timer
    ''' </summary>
    ''' <returns>le temps écoulé depuis le lancement du timer</returns>
    Public Function TempsEcoule() As Integer
        Return tempsRestantInitial - tempsRestantActuel
    End Function

    ''' <summary>
    ''' Est appelé quand une seconde s'écoule
    ''' </summary>
    Private Sub OnTimerTick() Handles timer.Tick
        tempsRestantActuel -= 1 'on décrémente le temps écoulé d'une seconde
        If tempsRestantActuel <= 0 Then 'si le temps est totalement écoulé, on raise l'évènement Termine
            RaiseEvent Termine()
            Exit Sub
        End If

        RaiseEvent Tick()
    End Sub
End Class

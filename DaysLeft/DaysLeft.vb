Public Class DaysLeft
    Public Const DOUBLE_CRLF = vbCrLf & vbCrLf

    Private Sub DaysLeft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Today
        UpdateSettings(False)

        UpdateDisplay()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Display1.TargetDate.Date <= Today Then Display1.FlashColour() Else Display1.SetBlack()
        If Display2.TargetDate.Date <= Today Then Display2.FlashColour() Else Display2.SetBlack()
        If Display3.TargetDate.Date <= Today Then Display3.FlashColour() Else Display3.SetBlack()
        If Display4.TargetDate.Date <= Today Then Display4.FlashColour() Else Display4.SetBlack()
        If Display5.TargetDate.Date <= Today Then Display5.FlashColour() Else Display5.SetBlack()
        If Display6.TargetDate.Date <= Today Then Display6.FlashColour() Else Display6.SetBlack()

        If Display1.TargetDate = Nothing Or Display1.TargetDate > Today Then Display1.SetBlack()
        If Display2.TargetDate = Nothing Or Display2.TargetDate > Today Then Display2.SetBlack()
        If Display3.TargetDate = Nothing Or Display3.TargetDate > Today Then Display3.SetBlack()
        If Display4.TargetDate = Nothing Or Display4.TargetDate > Today Then Display4.SetBlack()
        If Display5.TargetDate = Nothing Or Display5.TargetDate > Today Then Display5.SetBlack()
        If Display6.TargetDate = Nothing Or Display6.TargetDate > Today Then Display6.SetBlack()

        UpdateDisplay()
    End Sub

    Private Sub UpdateDisplay()
        SortTimers()

        Display1.UpdateDisplay()
        Display2.UpdateDisplay()
        Display3.UpdateDisplay()
        Display4.UpdateDisplay()
        Display5.UpdateDisplay()
        Display6.UpdateDisplay()

    End Sub

    Private Sub SortTimers()
        If Display1.TargetDate = Nothing And Display2.TargetDate = Nothing And Display3.TargetDate = Nothing And Display4.TargetDate = Nothing And Display5.TargetDate = Nothing And Display6.TargetDate = Nothing Then Exit Sub
        If Display6.TargetDate <> Nothing And (Display6.TargetDate < Display5.TargetDate Or Display5.TargetDate = Nothing) Then Sort56()
        If Display5.TargetDate <> Nothing And (Display5.TargetDate < Display4.TargetDate Or Display4.TargetDate = Nothing) Then Sort45()
        If Display4.TargetDate <> Nothing And (Display4.TargetDate < Display3.TargetDate Or Display3.TargetDate = Nothing) Then Sort34()
        If Display3.TargetDate <> Nothing And (Display3.TargetDate < Display2.TargetDate Or Display2.TargetDate = Nothing) Then Sort23()
        If Display2.TargetDate <> Nothing And (Display2.TargetDate < Display1.TargetDate Or Display1.TargetDate = Nothing) Then Sort12()
    End Sub

    Private Sub Sort56()
        Dim TempDate As Date = Display6.TargetDate
        Dim TempName As String = Display6.EventName
        Display6.TargetDate = Display5.TargetDate
        Display6.EventName = Display5.EventName
        Display5.TargetDate = TempDate
        Display5.EventName = TempName
    End Sub

    Private Sub Sort45()
        Dim TempDate As Date = Display5.TargetDate
        Dim TempName As String = Display5.EventName
        Display5.TargetDate = Display4.TargetDate
        Display5.EventName = Display4.EventName
        Display4.TargetDate = TempDate
        Display4.EventName = TempName
    End Sub

    Private Sub Sort34()
        Dim TempDate As Date = Display4.TargetDate
        Dim TempName As String = Display4.EventName
        Display4.TargetDate = Display3.TargetDate
        Display4.EventName = Display3.EventName
        Display3.TargetDate = TempDate
        Display3.EventName = TempName
    End Sub

    Private Sub Sort23()
        Dim TempDate As Date = Display3.TargetDate
        Dim TempName As String = Display3.EventName
        Display3.TargetDate = Display2.TargetDate
        Display3.EventName = Display2.EventName
        Display2.TargetDate = TempDate
        Display2.EventName = TempName
    End Sub

    Private Sub Sort12()
        Dim TempDate As Date = Display2.TargetDate
        Dim TempName As String = Display2.EventName
        Display2.TargetDate = Display1.TargetDate
        Display2.EventName = Display1.EventName
        Display1.TargetDate = TempDate
        Display1.EventName = TempName
    End Sub

    Private Sub ButtonToday_Click(sender As Object, e As EventArgs) Handles ButtonToday.Click
        DateTimePicker1.Value = Today
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxTarget.Clear()
    End Sub

    Private Sub ButtonSet_Click(sender As Object, e As EventArgs) Handles ButtonSet.Click
        Display6.EventName = TextBoxTarget.Text
        Display6.TargetDate = DateTimePicker1.Value

        UpdateDisplay()
        UpdateSettings(True)
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub DaysLeft_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        UpdateSettings(True)
    End Sub

    Private Sub UpdateSettings(Flag As Boolean)
        If Flag Then
            My.Settings.Location = Me.Location
            My.Settings.TargetDate1 = Display1.TargetDate
            My.Settings.TargetDate2 = Display2.TargetDate
            My.Settings.TargetDate3 = Display3.TargetDate
            My.Settings.TargetDate4 = Display4.TargetDate
            My.Settings.TargetDate5 = Display5.TargetDate
            My.Settings.TargetDate6 = Display6.TargetDate
            My.Settings.EventName1 = Display1.EventName
            My.Settings.EventName2 = Display2.EventName
            My.Settings.EventName3 = Display3.EventName
            My.Settings.EventName4 = Display4.EventName
            My.Settings.EventName5 = Display5.EventName
            My.Settings.EventName6 = Display6.EventName
            My.Settings.Save()
        Else
            Me.Location = My.Settings.Location
            Display1.TargetDate = My.Settings.TargetDate1
            Display2.TargetDate = My.Settings.TargetDate2
            Display3.TargetDate = My.Settings.TargetDate3
            Display4.TargetDate = My.Settings.TargetDate4
            Display5.TargetDate = My.Settings.TargetDate5
            Display6.TargetDate = My.Settings.TargetDate6
            Display1.EventName = My.Settings.EventName1
            Display2.EventName = My.Settings.EventName2
            Display3.EventName = My.Settings.EventName3
            Display4.EventName = My.Settings.EventName4
            Display5.EventName = My.Settings.EventName5
            Display6.EventName = My.Settings.EventName6
        End If
    End Sub
End Class
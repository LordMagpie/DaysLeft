Public Class Display
    ' Private variables
    Private _eventName As String, _targetDate As Date
    Private ReadOnly _targetText As String = "The target is: "
    Private _duration As TimeSpan = Nothing

    ' Public Properties
    Public Property EventName As String
        Get
            Return _eventName
        End Get
        Set(value As String)
            _eventName = value
        End Set
    End Property

    Public Property TargetDate As Date
        Get
            Return _targetDate
        End Get
        Set(value As Date)
            _targetDate = value
        End Set
    End Property

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        LabelTarget.Text = _targetText & _eventName & vbCrLf & Format(_targetDate, "Long Date")
        LabelDays.Text = "0"

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Public Sub UpdateDisplay()
        If _targetDate = Nothing Then
            LabelTarget.Visible = False
            LabelDays.Visible = False
        Else
            LabelTarget.Visible = True
            LabelDays.Visible = True
            _duration = _targetDate - Today
            LabelTarget.Text = _targetText & _eventName & vbCrLf & Format(_targetDate, "Long Date")
            'if -targetDate = Today Then
            LabelDays.Text = _duration.Days.ToString
            'Else
            'LabelDays.Text = -duration.Days.ToString
            'End If
        End If
    End Sub

    Public Sub FlashColour()
        If LabelTarget.ForeColor = Color.Red Then
            LabelTarget.ForeColor = Color.Teal
            LabelDays.ForeColor = Color.Teal
            LabelHead.ForeColor = Color.Teal
        Else
            LabelTarget.ForeColor = Color.Red
            LabelDays.ForeColor = Color.Red
            LabelHead.ForeColor = Color.Red
        End If
    End Sub

    Public Sub SetBlack()
        LabelTarget.ForeColor = Color.Black
        LabelDays.ForeColor = Color.Black
        LabelHead.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Result As DialogResult

        Result = MessageBox.Show("Do you really want to delete?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If Result = DialogResult.Yes Then
            _targetDate = Nothing
            _eventName = Nothing
            _duration = Nothing
            LabelTarget.ForeColor = Color.Black
            LabelDays.ForeColor = Color.Black
            LabelHead.ForeColor = Color.Black
            UpdateDisplay()
        End If
    End Sub
End Class

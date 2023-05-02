<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DaysLeft
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DaysLeft))
        Display1 = New Display.Display()
        Display2 = New Display.Display()
        Display3 = New Display.Display()
        Display4 = New Display.Display()
        Label1 = New Label()
        Label2 = New Label()
        ButtonClear = New Button()
        TextBoxTarget = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        ButtonSet = New Button()
        ButtonToday = New Button()
        ButtonExit = New Button()
        Timer1 = New Timer(components)
        Display5 = New Display.Display()
        Display6 = New Display.Display()
        SuspendLayout()
        ' 
        ' Display1
        ' 
        Display1.BackColor = Color.Teal
        Display1.BorderStyle = BorderStyle.FixedSingle
        Display1.EventName = Nothing
        Display1.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Display1.Location = New Point(13, 13)
        Display1.Margin = New Padding(4)
        Display1.Name = "Display1"
        Display1.Size = New Size(658, 78)
        Display1.TabIndex = 0
        Display1.TargetDate = New DateTime(0L)
        ' 
        ' Display2
        ' 
        Display2.BackColor = Color.Teal
        Display2.BorderStyle = BorderStyle.FixedSingle
        Display2.EventName = Nothing
        Display2.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Display2.Location = New Point(13, 99)
        Display2.Margin = New Padding(4)
        Display2.Name = "Display2"
        Display2.Size = New Size(658, 78)
        Display2.TabIndex = 1
        Display2.TargetDate = New DateTime(0L)
        ' 
        ' Display3
        ' 
        Display3.BackColor = Color.Teal
        Display3.BorderStyle = BorderStyle.FixedSingle
        Display3.EventName = Nothing
        Display3.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Display3.Location = New Point(13, 185)
        Display3.Margin = New Padding(4)
        Display3.Name = "Display3"
        Display3.Size = New Size(658, 78)
        Display3.TabIndex = 2
        Display3.TargetDate = New DateTime(0L)
        ' 
        ' Display4
        ' 
        Display4.BackColor = Color.Teal
        Display4.BorderStyle = BorderStyle.FixedSingle
        Display4.EventName = Nothing
        Display4.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Display4.Location = New Point(13, 271)
        Display4.Margin = New Padding(4)
        Display4.Name = "Display4"
        Display4.Size = New Size(658, 78)
        Display4.TabIndex = 3
        Display4.TargetDate = New DateTime(0L)
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(678, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 25)
        Label1.TabIndex = 4
        Label1.Text = "Target Text"
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(794, 13)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 25)
        Label2.TabIndex = 5
        Label2.Text = "(24 chars max)"
        ' 
        ' ButtonClear
        ' 
        ButtonClear.Location = New Point(964, 0)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(31, 35)
        ButtonClear.TabIndex = 6
        ButtonClear.Text = "X"
        ButtonClear.UseVisualStyleBackColor = True
        ' 
        ' TextBoxTarget
        ' 
        TextBoxTarget.Location = New Point(678, 41)
        TextBoxTarget.MaxLength = 24
        TextBoxTarget.Name = "TextBoxTarget"
        TextBoxTarget.Size = New Size(317, 33)
        TextBoxTarget.TabIndex = 7
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(678, 135)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(317, 33)
        DateTimePicker1.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(678, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 25)
        Label3.TabIndex = 9
        Label3.Text = "Target Date"
        ' 
        ' ButtonSet
        ' 
        ButtonSet.Location = New Point(678, 174)
        ButtonSet.Name = "ButtonSet"
        ButtonSet.Size = New Size(317, 35)
        ButtonSet.TabIndex = 10
        ButtonSet.Text = "Set Timer"
        ButtonSet.UseVisualStyleBackColor = True
        ' 
        ' ButtonToday
        ' 
        ButtonToday.Location = New Point(884, 97)
        ButtonToday.Name = "ButtonToday"
        ButtonToday.Size = New Size(111, 35)
        ButtonToday.TabIndex = 11
        ButtonToday.Text = "Today"
        ButtonToday.UseVisualStyleBackColor = True
        ' 
        ' ButtonExit
        ' 
        ButtonExit.Location = New Point(678, 443)
        ButtonExit.Name = "ButtonExit"
        ButtonExit.Size = New Size(317, 78)
        ButtonExit.TabIndex = 12
        ButtonExit.Text = "E&xit"
        ButtonExit.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 500
        ' 
        ' Display5
        ' 
        Display5.BackColor = Color.Teal
        Display5.BorderStyle = BorderStyle.FixedSingle
        Display5.EventName = Nothing
        Display5.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Display5.Location = New Point(13, 357)
        Display5.Margin = New Padding(4)
        Display5.Name = "Display5"
        Display5.Size = New Size(658, 78)
        Display5.TabIndex = 13
        Display5.TargetDate = New DateTime(0L)
        ' 
        ' Display6
        ' 
        Display6.BackColor = Color.Teal
        Display6.BorderStyle = BorderStyle.FixedSingle
        Display6.EventName = Nothing
        Display6.Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Display6.Location = New Point(13, 443)
        Display6.Margin = New Padding(4)
        Display6.Name = "Display6"
        Display6.Size = New Size(658, 78)
        Display6.TabIndex = 14
        Display6.TargetDate = New DateTime(0L)
        ' 
        ' DaysLeft
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(1003, 528)
        Controls.Add(Display6)
        Controls.Add(Display5)
        Controls.Add(ButtonExit)
        Controls.Add(ButtonToday)
        Controls.Add(ButtonSet)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBoxTarget)
        Controls.Add(ButtonClear)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Display4)
        Controls.Add(Display3)
        Controls.Add(Display2)
        Controls.Add(Display1)
        Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "DaysLeft"
        Text = "DaysLeft"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Display1 As Display.Display
    Friend WithEvents Display2 As Display.Display
    Friend WithEvents Display3 As Display.Display
    Friend WithEvents Display4 As Display.Display
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents TextBoxTarget As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonSet As Button
    Friend WithEvents ButtonToday As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Display5 As Display.Display
    Friend WithEvents Display6 As Display.Display
End Class

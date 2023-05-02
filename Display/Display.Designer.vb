<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Display
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Button1 = New Button()
        Button2 = New Button()
        LabelHead = New Label()
        LabelDays = New Label()
        LabelTarget = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Blue
        Button1.FlatAppearance.MouseOverBackColor = Color.Red
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Image = My.Resources.Resources.delete_icon_transparent_background_28
        Button1.Location = New Point(581, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 74)
        Button1.TabIndex = 0
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseDownBackColor = Color.Blue
        Button2.FlatAppearance.MouseOverBackColor = Color.Red
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Image = My.Resources.Resources._1749722
        Button2.Location = New Point(501, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(74, 74)
        Button2.TabIndex = 1
        Button2.UseVisualStyleBackColor = True
        ' 
        ' LabelHead
        ' 
        LabelHead.AutoSize = True
        LabelHead.Location = New Point(435, 3)
        LabelHead.Name = "LabelHead"
        LabelHead.Size = New Size(47, 21)
        LabelHead.TabIndex = 2
        LabelHead.Text = "Days"
        LabelHead.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelDays
        ' 
        LabelDays.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LabelDays.Location = New Point(411, 30)
        LabelDays.Name = "LabelDays"
        LabelDays.Size = New Size(86, 47)
        LabelDays.TabIndex = 3
        LabelDays.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LabelTarget
        ' 
        LabelTarget.Font = New Font("Segoe UI", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        LabelTarget.Location = New Point(3, 3)
        LabelTarget.Name = "LabelTarget"
        LabelTarget.Size = New Size(402, 77)
        LabelTarget.TabIndex = 4
        LabelTarget.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Display
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        BorderStyle = BorderStyle.FixedSingle
        Controls.Add(LabelTarget)
        Controls.Add(LabelDays)
        Controls.Add(LabelHead)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Display"
        Size = New Size(658, 78)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents LabelHead As Label
    Friend WithEvents LabelDays As Label
    Friend WithEvents LabelTarget As Label
End Class

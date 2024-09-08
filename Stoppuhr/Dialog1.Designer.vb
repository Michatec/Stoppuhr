<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.LBY = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(359, 133)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(4)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(89, 28)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'LBY
        '
        Me.LBY.AutoSize = True
        Me.LBY.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBY.Location = New System.Drawing.Point(38, 32)
        Me.LBY.Name = "LBY"
        Me.LBY.Size = New System.Drawing.Size(195, 32)
        Me.LBY.TabIndex = 1
        Me.LBY.Text = "By Michail Ch."
        '
        'Info
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 174)
        Me.Controls.Add(Me.LBY)
        Me.Controls.Add(Me.OK_Button)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Info"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents LBY As Label
End Class

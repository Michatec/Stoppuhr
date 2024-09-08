<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BReset = New System.Windows.Forms.Button()
        Me.BStart = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BLap = New System.Windows.Forms.Button()
        Me.LTime = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'BReset
        '
        Me.BReset.Location = New System.Drawing.Point(125, 124)
        Me.BReset.Name = "BReset"
        Me.BReset.Size = New System.Drawing.Size(108, 29)
        Me.BReset.TabIndex = 0
        Me.BReset.Text = "Zurücksetzen"
        Me.BReset.UseVisualStyleBackColor = True
        '
        'BStart
        '
        Me.BStart.Location = New System.Drawing.Point(21, 124)
        Me.BStart.Name = "BStart"
        Me.BStart.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BStart.Size = New System.Drawing.Size(75, 29)
        Me.BStart.TabIndex = 1
        Me.BStart.Text = "Start"
        Me.BStart.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Info"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BLap
        '
        Me.BLap.Enabled = False
        Me.BLap.Location = New System.Drawing.Point(270, 124)
        Me.BLap.Name = "BLap"
        Me.BLap.Size = New System.Drawing.Size(75, 29)
        Me.BLap.TabIndex = 3
        Me.BLap.Text = "Lap"
        Me.BLap.UseVisualStyleBackColor = True
        '
        'LTime
        '
        Me.LTime.AutoSize = True
        Me.LTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTime.Location = New System.Drawing.Point(12, 39)
        Me.LTime.Name = "LTime"
        Me.LTime.Size = New System.Drawing.Size(308, 54)
        Me.LTime.TabIndex = 4
        Me.LTime.Text = "00:00:00:000"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(16, 176)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(329, 148)
        Me.ListBox1.TabIndex = 5
        '
        'T1
        '
        Me.T1.Interval = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 375)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.LTime)
        Me.Controls.Add(Me.BLap)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BStart)
        Me.Controls.Add(Me.BReset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Stoppuhr"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BReset As Button
    Friend WithEvents BStart As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BLap As Button
    Friend WithEvents LTime As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents T1 As Timer
End Class

Public Class Form1
    Private stopwatch As New Stopwatch

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Info.ShowDialog()
    End Sub

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        If LTime.Text = "99:99:99:999" Then
            LTime.Text = "00:00:00:000"
        End If
        Dim elapsed As TimeSpan = stopwatch.Elapsed
        LTime.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub

    Private Sub BStart_Click(sender As Object, e As EventArgs) Handles BStart.Click
        If BStart.Text = "Start" Then
            T1.Start()
            stopwatch.Start()
            BStart.Text = "Stopp"
            BLap.Enabled = True
        Else
            T1.Stop()
            stopwatch.Stop()
            BStart.Text = "Start"
            BLap.Enabled = False
        End If
    End Sub

    Private Sub BLap_Click(sender As Object, e As EventArgs) Handles BLap.Click
        ListBox1.Items.Add(ListBox1.Items.Count + 1 & ".  " & LTime.Text)
    End Sub

    Private Sub BReset_Click(sender As Object, e As EventArgs) Handles BReset.Click
        stopwatch.Reset()
        LTime.Text = "00:00:00:000"
        ListBox1.Items.Clear()
        BStart.Text = "Start"
    End Sub
End Class

Public Class Form1
    Private Sub DateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem1.Click
        Label1.Text = DateString
    End Sub

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString
    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeDateToolStripMenuItem.Click
        Label1.Text = Now.ToString()
    End Sub

    Private Sub HourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourToolStripMenuItem.Click
        Label1.Text = Hour(Now).ToString()
    End Sub

    Private Sub MinuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinuteToolStripMenuItem.Click
        Label1.Text = Minute(Now).ToString()
    End Sub

    Private Sub SecondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecondToolStripMenuItem.Click
        Label1.Text = Second(Now).ToString()
    End Sub

    Private Sub MonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthToolStripMenuItem.Click
        Label1.Text = Month(Now).ToString()
    End Sub

    Private Sub YearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem.Click
        Label1.Text = Year(Now).ToString()
    End Sub

    Private Sub WeekdayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeekdayToolStripMenuItem.Click
        Label1.Text = Weekday(Now).ToString()
    End Sub
End Class

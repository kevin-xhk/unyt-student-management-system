Public Class LandingPage
    Private Sub StudentInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentInformationToolStripMenuItem.Click
        StudentInfo.Show()
        Me.Hide()
    End Sub

    Private Sub CourseDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CourseDetailsToolStripMenuItem.Click
        CourseDetails.Show()
        Me.Hide()
    End Sub

    Private Sub EmployeeInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeInformationToolStripMenuItem.Click

    End Sub

    Private Sub OpenWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenWindowToolStripMenuItem.Click
        UserManagement.Show()
        Me.Hide()
    End Sub
End Class
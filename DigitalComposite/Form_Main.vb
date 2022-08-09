Public Class Form_Main

    Private Sub lbl_301_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_301.MouseClick
        Dim currentPosition As Point
        currentPosition.X = e.X
        currentPosition.Y = e.Y

        Me.Hide()

        My.Forms.Form_brotherInfo.broName = "Chris Addis"
        My.Forms.Form_brotherInfo.broBond = "301"
        My.Forms.Form_brotherInfo.broMajor = "Computer Science and Computer Infromation Systems"
        My.Forms.Form_brotherInfo.broGrade = "Senior"

        My.Forms.Form_brotherInfo.Location = currentPosition
        My.Forms.Form_brotherInfo.Show()
    End Sub

End Class

Public Class broInfo
    Public Name, Bond, Major As String
End Class
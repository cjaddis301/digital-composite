Public Class Form_brotherInfo

    Public broName, broBond, broMajor, broGrade As String

    Private Sub From_brotherInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lbl_Name.Text += broName
        Me.lbl_bond.Text += broBond
        Me.lbl_Major.Text += broMajor
        Me.lbl_grade.Text += broGrade
    End Sub

    Private Sub btn_done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_done.Click
        Me.Hide()
        My.Forms.Form_Main.Show()
    End Sub
End Class
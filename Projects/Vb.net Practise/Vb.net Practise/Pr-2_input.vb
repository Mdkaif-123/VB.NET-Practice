Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim firstName As String
        Dim lastName As String
        Dim gender As String
        Dim occupation As String


        firstName = TextBox1.Text
        lastName = TextBox2.Text
        gender = TextBox3.Text
        occupation = ListBox1.SelectedItem

        MsgBox("Hey , " & firstName & " " & lastName & ". You are a " & occupation)

    End Sub
End Class
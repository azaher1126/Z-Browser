Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.homepage
        If My.Settings.hpopen = True Then
            RadioButton1.Select()
        Else
            RadioButton2.Select()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            My.Settings.hpopen = True
        ElseIf RadioButton2.Checked = True Then
            My.Settings.hpopen = False
        End If
        My.Settings.homepage = TextBox1.Text
    End Sub
End Class
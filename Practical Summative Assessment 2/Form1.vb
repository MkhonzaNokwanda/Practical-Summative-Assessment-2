Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ''Declaration of variables
        Dim word As String
        word = txtWord.Text
        ''check if the word entered does not exist already in the listbox
        If ListBox1.Items.Contains(word) = True Then
            MessageBox.Show("This is already in the list")
        Else
            ListBox1.Items.Add(word)
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ''Displays on the label and changing the background color
        lblDisplay.BackColor = Color.White
        lblDisplay.Text = ListBox1.SelectedItem
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub rbtnUpper_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnUpper.CheckedChanged
        lblDisplay.Text = lblDisplay.Text.ToUpper()
    End Sub

    Private Sub rbtnLower_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLower.CheckedChanged
        lblDisplay.Text = lblDisplay.Text.ToLower()
    End Sub

    Private Sub rbtnPurple_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPurple.CheckedChanged
        lblDisplay.ForeColor = Color.Purple
    End Sub

    Private Sub rbtnBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnBlue.CheckedChanged
        lblDisplay.ForeColor = Color.Blue
    End Sub
End Class

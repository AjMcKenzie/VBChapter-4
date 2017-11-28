Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String

        If listColor.SelectedIndex = -1 Then
            MessageBox.Show("Select a color.")
        ElseIf listEst.SelectedIndex = -1 Then
            MessageBox.Show("No word ending in EST was selected.")
        ElseIf listAnimal.SelectedIndex = -1 Then
            MessageBox.Show("Select a Animal")
        ElseIf listBodyPartPlural.SelectedIndex = -1 Then
            MessageBox.Show("nothing was selected for Body Parts")
        ElseIf listNumber.SelectedIndex = -1 Then
            MessageBox.Show("Select a number")
        ElseIf listPluralNoun.SelectedIndex = -1 Then
            MessageBox.Show("Select a PluralNoun")
        ElseIf listNoun.SelectedIndex = -1 Then
            MessageBox.Show("Select a Noun")
        End If

        strInput = listColor.SelectedItem.ToString() & " Dragon is the " &
            listEst.SelectedItem.ToString() & " Dragon of all. It has " & listNumber.SelectedItem.ToString() &
            " " & listBodyPartPlural.SelectedItem.ToString() & ", and a " &
            listAnimal.SelectedItem.ToString() & " shaped like a " &
             listNoun.SelectedItem.ToString() & " . It loves to eat " & listPluralNoun.SelectedItem.ToString()

        MessageBox.Show("The " & strInput & ", although it will feast on nearly anything")

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        listColor.SelectedIndex = -1
        listAnimal.SelectedIndex = -1
        listBodyPartPlural.SelectedIndex = -1
        listEst.SelectedIndex = -1
        listNoun.SelectedIndex = -1
        listNumber.SelectedIndex = -1
        listPluralNoun.SelectedIndex = -1
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

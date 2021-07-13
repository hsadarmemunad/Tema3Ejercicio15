Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles LabelLarge.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxNumbers.TextChanged
        Dim vectoraux() As String
        vectoraux = TextBoxNumbers.Text.Split({","}, StringSplitOptions.None)
        Dim large As Integer = 0

        For i As Integer = 0 To vectoraux.Count() - 1 Step 1
            Dim Number As Integer = 0

            If Integer.TryParse(vectoraux(i), Number) Then
                If large < Number Then
                    large = vectoraux(i)
                End If
            End If

        Next

        LabelLarge.Text = large

    End Sub
End Class

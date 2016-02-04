Class MainWindow 

    Private Sub AddValue_Click(sender As Object, e As RoutedEventArgs) Handles AddValue.Click
        Dim newValue As String = InputBox.Text
        Output(newValue)
        InputBox.Clear()
    End Sub

    Private Sub OnKeyDownHandler(ByVal sender As Object, ByVal e As KeyEventArgs)
        If (e.Key = Key.Return) Then
            Dim newValue As String = InputBox.Text
            Output(newValue)
            InputBox.Clear()
        End If
    End Sub

    Sub Output(Value As String)
        TextOutput.Text += Value + vbCrLf
    End Sub

End Class

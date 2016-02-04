Class MainWindow 

    Private Sub AddValue_Click(sender As Object, e As RoutedEventArgs) Handles AddValue.Click
        Dim newValue As String = InputBox.Text
        Output(newValue)
    End Sub

    Sub Output(Value As String)
        TextOutput.Text += Value + vbCrLf
    End Sub

End Class

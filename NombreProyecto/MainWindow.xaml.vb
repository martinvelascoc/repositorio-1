Class MainWindow
    Private Sub ButtonAddName_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
        If Not String.IsNullOrWhiteSpace(txtName.Text) AndAlso Not lstNames.Items.Contains(txtName.Text) Then
            lstNames.Items.Add(txtName.Text)
            txtName.Clear()
        End If
    End Sub
End Class

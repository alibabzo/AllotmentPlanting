Public Class AllotmentPlanting

    Private Sub AllotmentPlanning_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.HelpButtonClicked
        HelpBox.Show()
    End Sub

    Private Sub Go_Click(sender As Object, e As System.EventArgs) Handles Go.Click
        PermBedContent.Text = "Rhubarb, currants, fruit trees, strawberries."
        If NumericUpDown1.Value Mod 3 = 0 Then
            Bed1Content.Text = "Peas, broad beans, french beans, runner beans," & vbNewLine & "lettuce."
            Bed2Content.Text = "Garlic, onions, leeks, carrots, parsnips, celeriac," & vbNewLine & "beetroot, cabbage, kale, sprouts, radish," & vbNewLine & "rocket, broccoli."
            Bed3Content.Text = "Potatoes, tomatoes, peppers, chillies, courgettes," & vbNewLine & "pumpkins, squash, cucumbers, aubergines."
        End If

        If NumericUpDown1.Value Mod 3 = 1 Then
            Bed1Content.Text = "Garlic, onions, leeks, carrots, parsnips, celeriac," & vbNewLine & "beetroot, cabbage, kale, sprouts, radish," & vbNewLine & "rocket, broccoli."
            Bed2Content.Text = "Potatoes, tomatoes, peppers, chillies, courgettes," & vbNewLine & "pumpkins, squash, cucumbers, aubergines."
            Bed3Content.Text = "Peas, broad beans, french beans, runner beans," & vbNewLine & "lettuce."
        End If

        If NumericUpDown1.Value Mod 3 = 2 Then
            Bed1Content.Text = "Potatoes, tomatoes, peppers, chillies, courgettes," & vbNewLine & "pumpkins, squash, cucumbers, aubergines."
            Bed2Content.Text = "Peas, broad beans, french beans, runner beans," & vbNewLine & "lettuce."
            Bed3Content.Text = "Garlic, onions, leeks, carrots, parsnips, celeriac," & vbNewLine & "beetroot, cabbage, kale, sprouts, radish," & vbNewLine & "rocket, broccoli."
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub AllotmentPlanting_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

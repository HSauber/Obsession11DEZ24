Public Class Form1
    Private objDome As ASCOM.DriverAccess.Dome
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As New ASCOM.Utilities.Chooser
        obj.DeviceType = "Dome"
        TextBox1.Text = obj.Choose(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        objDome = New ASCOM.DriverAccess.Dome(TextBox1.Text)
        objDome.Connected = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'objSwitch.SetSwitch(1, True)
        tbR1.BackColor = Color.Green
    End Sub
End Class

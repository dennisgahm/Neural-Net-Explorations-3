Public Class Form1

    'Size of game is 10x10
    Dim ballLocation() As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ballLocation = {0, 0} 'Top-left; first 0 => horizontal position
        Randomize()
        Dim value As Integer = CInt(Int((9 * Rnd())))

        ballLocation = {value, 0}

        'set direction
        '
        Dim value2 As Integer = CInt(Int((5) * Rnd())))

    End Sub
End Class

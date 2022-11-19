Public Class Form1

    'Size of game is 10x10
    Dim ballLocation() As Integer
    Dim ballDirection As Integer
    Dim ballDown As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ballLocation = {0, 0} 'Top-left; first 0 => horizontal position
        Randomize()
        Dim value As Integer = CInt(Int((10 * Rnd()))) 'random number 0 to 9

        ballLocation = {value, 0}

        'set direction
        '-2 -1 0 1 2
        'very left, left, down, ...
        ballDirection = CInt(Int(5 * Rnd())) '0 to 4

        'Ball is going down
        ballDown = True

        'Experiment: generates the number from 0 to 4
        'For i As Integer = 0 To 100
        '    RichTextBox1.AppendText(" " & CInt(Int(5 * Rnd())))
        'Next



    End Sub

    Private Sub GenerateNextFrame()
        'Move ballLocation in the direction of direction

        'Eventually got to check for ball collision with pong-bar
        'Got to also check for: hitting sides

    End Sub
End Class

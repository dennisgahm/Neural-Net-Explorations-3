Public Class Form1

    'Size of game is 10x10
    Dim ballLocation() As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ballLocation = {0, 0} 'Top-left; first 0 => horizontal position
        Randomize()
        Dim value As Integer = CInt(Int((10 * Rnd()))) 'random number 0 to 9

        ballLocation = {value, 0}

        'set direction
        '-2 -1 0 1 2
        'very left, left, down, ...
        Dim value2 As Integer = CInt(Int(5 * Rnd())) '0 to 4

        'Experiment: generates the number from 0 to 4
        'For i As Integer = 0 To 100
        '    RichTextBox1.AppendText(" " & CInt(Int(5 * Rnd())))
        'Next

    End Sub
End Class

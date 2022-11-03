Public Class PerceptronNode
    'percentages?
    Dim IfStatements As ArrayList

    Public Sub AddIfStatement(ByVal situation As IfStatement)
        IfStatements.Add(situation)
    End Sub

    Public Function FireOrNot(ByVal IfStatement1 As IfStatement) As Boolean
        If IfStatements.Count = 0 Then
            Return False
        Else
            'NOTE: assume there is only one IfStatement in IfStatements (ArrayList)
            Dim checkingAgainst As IfStatement = IfStatements.Item(0)
            'if the input ifstatement is same as the one checking against it -> Fire

            Dim keys() As String = checkingAgainst.HashTable1.Keys
            For i As Integer = 0 To keys.Length
                If IfStatement1.HashTable1.ContainsKey(keys(i)) = False Then
                    Return False
                End If

                Dim IfStatementOriginal As IfStatement = IfStatements(0)

                'NOTE: must be completely correct - all conditions in the IfStatement must be the same/satisfied
                If IfStatement1.HashTable1(keys(i)) = Not IfStatementOriginal.HashTable1(keys(i)) Then
                    Return False
                End If
            Next

            Return True
        End If
    End Function
End Class

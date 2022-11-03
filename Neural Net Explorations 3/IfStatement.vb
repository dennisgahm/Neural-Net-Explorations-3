Public Class IfStatement
    Public HashTable1 As Hashtable
    'A list of keys of situations and their resulting true or falsity
    'For example, "ballHitsStick" -> true
    'sky is blue -> true
    'There is a confoundation - how to maintain a list of variable key names
    'we need to give the computer understanding of language
    ' synonyms for variable names map to the same true or falsity

    Public Sub AddKeyValue(ByVal key As String, ByVal value As Boolean)
        HashTable1.Add(key, value)
    End Sub
End Class

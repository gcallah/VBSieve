Public Class MathAlgorithms

    Public Shared Sub mark_sieve(ByRef marks As Boolean(), ByVal start As Integer, ByVal factor As Integer)
        Dim i As Integer = start
        Do While i < marks.Length
            marks(i) = False
            i = i + factor
        Loop
    End Sub

    Public Shared Function sift(ByVal n As Integer)
        Dim marks(0 To n) As Boolean
        Dim i As Integer = 0
        Do While i < marks.Length
            marks(i) = True
            i = i + 1
        Loop
        i = 0
        Dim index_square As Integer = 3
        Dim factor As Integer = 3
        Do While index_square < n
            If marks(i) = True Then
                mark_sieve(marks, index_square, factor)
                i = i + 1
                index_square = index_square + factor
                factor = factor + 2
                index_square = index_square + factor
            End If
        Loop
        i = 0
        Dim num_primes As Integer = 0
        Dim primes() As Integer
        Do While i < marks.Length
            If marks(i) = True Then
                ReDim Preserve primes(num_primes + 1)
                primes(num_primes) = 2 * i + 3
                num_primes = num_primes + 1
            End If
            i = i + 1
        Loop
        Return primes
    End Function

End Class

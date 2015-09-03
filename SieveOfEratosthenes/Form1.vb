Imports MathFuncs = SieveOfEratosthenes.MathAlgorithms

Public Class Sieve
    Private Sub Sieve_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UpToTextBox_TextChanged(sender As Object, e As EventArgs) Handles UpToTextBox.TextChanged
        If Not IsNumeric(UpToTextBox.Text) Then
            MsgBox.Text = "Please enter numbers only!"
        End If
    End Sub

    Private Sub FindPrimesButton_Click(sender As Object, e As EventArgs) Handles FindPrimesButton.Click
        PrimesListBox.Items.Clear()
        Dim upTo = (CInt(UpToTextBox.Text) - 1) / 2
        Dim primes() As Integer
        primes = MathFuncs.sift(upTo)
        Dim i As Integer = 0
        Do While i < primes.Length
            PrimesListBox.Items.Add(CStr(primes(i)))
            i = i + 1
        Loop
    End Sub
End Class

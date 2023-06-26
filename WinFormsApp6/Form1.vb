Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Text = "Массивы"
    End Sub
    Private Sub Massiv() Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Введите количество элементов массива!")
        Else
            Dim mass = Rand(TextBox1.Text)
            For i = 0 To CInt(TextBox1.Text) - 1
                ListBox1.Items.Add(mass(i))
                If mass(i) Mod 2 Then
                    mass(i) = -1
                Else
                    mass(i) = 1
                End If
                ListBox2.Items.Add(mass(i))
            Next
        End If


    End Sub

    Private Function Rand(ind As Integer) As Integer()
        Dim mass(ind - 1) As Integer
        For i = 0 To ind - 2
            Randomize()
            Dim randomValue = CInt(-200 * Rnd() + 100)
            mass(i) = randomValue
        Next
        Return mass
    End Function
End Class

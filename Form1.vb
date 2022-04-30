Public Class Form1
    Dim i, c, redon, j As Integer

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim x(50), y(50), z(50), ex(50), ey(50), ez(50), ec, a(3, 3), b(3) As Single

    Private Sub Coeficientes_Click(sender As Object, e As EventArgs) Handles Coeficientes.Click
        For i = 1 To 3
            For j = 1 To 3
                a(i, j) = InputBox("a(" & i & "," & j & ")=")
            Next
        Next
        For i = 1 To 3
            b(i) = InputBox("b(" & i & ")=")
        Next
        a11.Text = a(1, 1)
        a12.Text = a(1, 2)
        a13.Text = a(1, 3)
        a21.Text = a(2, 1)
        a22.Text = a(2, 2)
        a23.Text = a(2, 3)
        a31.Text = a(3, 1)
        a32.Text = a(3, 2)
        a33.Text = a(3, 3)

        b1.Text = b(1)
        b2.Text = b(2)
        b3.Text = b(3)

    End Sub
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        c = tc.Text
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)
        i = 0
        x(i) = 0
        y(i) = 0
        z(i) = 0
        ex(i) = 1
        ey(i) = 1
        ez(i) = 1

        Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon),
                               "-----", "-----", "-----")


        Do While ex(i) > ec Or ey(i) > ec Or ez(i) > ec
            i = i + 1
            x(i) = (b(1) - a(1, 2) * y(i - 1) - a(1, 3) * z(i - 1)) / a(1, 1)
            y(i) = (b(2) - a(2, 1) * x(i - 1) - a(2, 3) * z(i - 1)) / a(2, 2)
            z(i) = (b(3) - a(3, 1) * x(i - 1) - a(3, 2) * y(i - 1)) / a(3, 3)

            ex(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            ey(i) = Math.Abs((y(i) - y(i - 1)) / y(i))
            ez(i) = Math.Abs((z(i) - z(i - 1)) / z(i))


            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon), Math.Round(z(i), redon),
                               Math.Round(ex(i), redon), Math.Round(ey(i), redon), Math.Round(ez(i), redon))




        Loop
        TextBox1.Text = Math.Round(x(i), redon)
        TextBox2.Text = Math.Round(y(i), redon)
        TextBox3.Text = Math.Round(z(i), redon)

    End Sub




End Class

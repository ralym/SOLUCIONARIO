Public Class Form1




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim ordena As Integer

        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox3.Text)

        For i = 1 To 3
            If a > b Then GoTo amayorb Else GoTo bmayorc

amayorb:
            ordena = a
            a = b
            b = ordena
            GoTo bmayorc

bmayorc:
            If b > c Then GoTo ordenafinal Else GoTo salir
ordenafinal:
            ordena = b
            b = c
            c = ordena
salir:
        Next i
        GoTo pantalla
pantalla:
        TextBox4.Text = a.ToString + "," + b.ToString + "," + c.ToString












    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "

    End Sub
End Class

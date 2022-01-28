Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Nombre_Cliente As String
        Dim Arroz As Integer
        Dim Frijoles As Integer
        Dim Azucar As Integer
        Dim COSTO As Double
        Dim IVA As Double
        Dim PagoIVA As Double
        Dim Descuento As Double
        Dim PagoTotal As Double

        Const Parroz = 2.0
        Const Pfrijoles = 1.75
        Const Pazucar = 2.5

        'instrucciones de lectura 

        Nombre_Cliente = TextBox4.Text
        Arroz = Val(TextBox1.Text)
        Frijoles = Val(TextBox2.Text)
        Azucar = Val(TextBox3.Text)


        'calculo pago parcial 
        COSTO = (Arroz * Parroz) + (Frijoles * Pfrijoles) + (Azucar * Pazucar)


        'Calculo IVA
        IVA = COSTO * 0.12

        'Calculo pago mas IVA

        PagoIVA = IVA + COSTO

        'Calculo descuento 

        Descuento = PagoIVA * 0.025

        'Calculo pago final 

        PagoTotal = PagoIVA - Descuento

        'asignar calculo a cada recuadro 

        TextBox5.Text = Nombre_Cliente
        TextBox6.Text = COSTO
        TextBox7.Text = IVA
        TextBox8.Text = PagoIVA
        TextBox9.Text = Descuento
        TextBox10.Text = PagoTotal

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()

        TextBox1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class

Public Class Form1
    Dim A, B, C, D, E As Boolean

    Private time As Byte

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click

    End Sub

    Private binary As Byte


    Private Sub Form1_Load(sender As Object, ev As EventArgs) Handles MyBase.Load
        Timer1.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, ev As EventArgs) Handles Timer1.Tick
        binary = time

        A = CBool(binary >= 8)
        If A Then
            binary -= 8
        End If

        B = CBool(binary >= 4)
        If B Then
            binary -= 4
        End If

        C = CBool(binary >= 2)
        If C Then
            binary -= 2
        End If

        D = CBool(binary >= 1)
        If D Then
            binary -= 1
        End If

        IsOn(CBool((C And (Not B Or D)) Or (B And Not C)), Button1)

        IsOn(CBool(C Or A Or Not (B Xor D)), Button2)

        IsOn(CBool(Not B Or D Or C), Button3)

        IsOn(CBool(C Or A Or Not (B Xor D)), Button4)

        IsOn(B, Button5)

        IsOn(CBool(A Or (Not C And Not D) Or (B And (Not C Or Not D))), Button6)

        IsOn(CBool(Not A And Not B And Not C And D), Button7)

        IsOn(CBool(Not A And Not B And Not C And D), Button8)

        IsOn(CBool(Not A And Not B And Not C And Not D), Button9)

        IsOn(CBool(A Or (Not B And Not D) Or Not (C Xor D)), Button10)

        IsOn(CBool((Not A And Not B And Not C And Not D) Or (B And (C Xor D))), Button11)

        IsOn(CBool(A Or (C And Not D) Or (B And Not C)), Button12)

        IsOn(CBool(Not B Or Not C Or Not D), Button13)

        IsOn(CBool(A Or B Or C), Button14)

        IsOn(CBool((Not A And Not C And Not D) Or (A And D)), Button15)

        IsOn(CBool(Not D And (Not B Or C)), Button16)

        IsOn(CBool(Not A And Not B And Not C And Not D), Button17)

        IsOn(CBool(Not A And Not B And Not C And D), Button18)

        IsOn(CBool(D And B And C), Button19)

        IsOn(CBool(A Or (Not C And Not D) Or (Not B And C And D) Or (B And (Not C Or Not D))), Button20)

        IsOn(CBool((Not B And C) Or (B And Not C And D)), Button21)

        IsOn(CBool((Not D And (Not B Or C)) Or (Not A And (Not B Or (Not C And D)))), Button22)

        IsOn(CBool(Not B Or (C Xor D)), Button23)

        IsOn(CBool(Not B Or C Or D), Button24)

        IsOn(CBool(Not D And (B Xor C)), Button25)


        If time = 9 Then
            time = 0
        Else
            time += 1
        End If
    End Sub

    Private Sub IsOn(x As Boolean, Button As Button)
        Console.WriteLine(x)
        Console.WriteLine(Button)

        If x Then
            Button.BackColor = Color.Red
        Else
            Button.BackColor = Color.Gray
        End If
    End Sub
End Class

Public Class frmjogodavelha

    Private ox As Boolean
    Private oxvar As String
    Private resuV As Boolean
    Private resuH As Boolean
    Private resuD As Boolean
    Private term As Boolean
    Private IOsingle As Boolean
    Private numbtn As Integer
    Private numjogada As Integer
    Private btnjogada As Integer
    Private numbtnfinal As Integer
    Private imp As Boolean

    Private Sub frmjogodavelha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ox = True
        btn2.Text = Nothing
        btn1.Text = Nothing
        btn3.Text = Nothing
        btn4.Text = Nothing
        btn5.Text = Nothing
        btn6.Text = Nothing
        btn7.Text = Nothing
        btn8.Text = Nothing
        btn9.Text = Nothing
        term = True
        IOsingle = False
    End Sub

    Private Sub limpar()
        btn2.Text = Nothing
        btn1.Text = Nothing
        btn3.Text = Nothing
        btn4.Text = Nothing
        btn5.Text = Nothing
        btn6.Text = Nothing
        btn7.Text = Nothing
        btn8.Text = Nothing
        btn9.Text = Nothing
        lblresu.Text = ".     "
        ln1.Visible = False
        ln2.Visible = False
        ln3.Visible = False
        ln4.Visible = False
        ln5.Visible = False
        ln6.Visible = False
        ln7.Visible = False
        ln8.Visible = False
        term = True
        numjogada = 0
    End Sub

    Private Sub oxsub()
        If term = True Then
            If oxvar = Nothing Then
                If ox = False Then
                    oxvar = "0"
                    ox = True
                ElseIf ox = True Then
                    oxvar = "X"
                    ox = False
                End If
            End If
            If ox = True Then
                lblvez.Text = "Vez do X"
            ElseIf ox = False Then
                lblvez.Text = "Vez do O"
            End If
        End If
        numjogada = numjogada + 1
        'singleplayer()


        '    'Verifica as Horizontais:
        '    IIf((btn1.Text = btn2.Text And btn2.Text = btn3.Text), ln1.Visible = True, ln1.Visible = False)
        '    IIf((btn4.Text = btn5.Text And btn5.Text = btn6.Text), ln2.Visible = True, ln2.Visible = False)
        '    IIf((btn7.Text = btn8.Text And btn8.Text = btn9.Text), ln3.Visible = True, ln3.Visible = False)

        '    'Verifica as Verticais:
        '    IIf((btn1.Text = btn4.Text And btn4.Text = btn7.Text), ln4.Visible = True, ln4.Visible = False)
        '    IIf((btn2.Text = btn5.Text And btn5.Text = btn8.Text), ln4.Visible = True, ln4.Visible = False)
        '    IIf((btn3.Text = btn6.Text And btn6.Text = btn9.Text), ln4.Visible = True, ln4.Visible = False)

        '    'Verifica as Diagonais:
        '    IIf((btn1.Text = btn5.Text And btn5.Text = btn9.Text), ln7.Visible = True, ln7.Visible = False)
        '    IIf((btn3.Text = btn5.Text And btn5.Text = btn7.Text), ln8.Visible = True, ln8.Visible = False)

        '    IIf((ln1.Visible = True Or ln2.Visible = True Or ln3.Visible = True), resuH = True, resuH = False)
        '    IIf((ln4.Visible = True Or ln5.Visible = True Or ln6.Visible = True), resuV = True, resuV = False)
        '    IIf((ln7.Visible = True Or ln8.Visible = True), resuD = True, resuD = False)
    End Sub

    Private Sub singleplayer()
        If IOsingle = True Then
            If ox = False Then
                oxvar = "0"
                ox = True
            ElseIf ox = True Then
                oxvar = "X"
                ox = False
            End If
            Randomize()
            numbtnfinal = Int((4 - 1 + 1) * Rnd() + 1)
            'timersingle.Enabled = True


            ' --- imp ---
            If imp = True Then
                btn5.Text = oxvar
                '  -- para idiotas (imp) --
                If numjogada = 1 And (numbtn = 2 Or numbtn = 4 Or numbtn = 6 Or numbtn = 8) Then


                End If
            End If








        End If
    End Sub

    Private Sub termsub()
        lblresu.Text = "__ " + oxvar + " vence __."
        MsgBox("       __ " + oxvar + " vence. __       ")
        term = False
        lblvez.Text = Nothing
    End Sub

    Private Sub btnlimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlimpar.Click
        limpar()
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        oxvar = btn1.Text
        oxsub()
        btn1.Text = oxvar
        If term = True Then
            If (btn3.Text = btn1.Text And btn3.Text = btn2.Text) Then 'H
                ln1.Visible = True
                termsub()
            ElseIf (btn1.Text = btn4.Text And btn1.Text = btn7.Text) Then 'V
                ln4.Visible = True
                termsub()
            ElseIf (btn1.Text = btn5.Text And btn1.Text = btn9.Text) Then 'D
                ln7.Visible = True
                termsub()
            End If
        End If
        numbtn = 1
        singleplayer()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        oxvar = btn2.Text
        oxsub()
        btn2.Text = oxvar
        If (btn3.Text = btn1.Text And btn3.Text = btn2.Text) Then
            ln1.Visible = True

            termsub()
        ElseIf (btn2.Text = btn5.Text And btn2.Text = btn8.Text) Then
            ln5.Visible = True
            termsub()
        End If
        numbtn = 2
        singleplayer()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        oxvar = btn3.Text
        oxsub()
        btn3.Text = oxvar
        If (btn3.Text = btn1.Text And btn3.Text = btn2.Text) Then   '  'H
            ln1.Visible = True
            termsub()
        ElseIf (btn3.Text = btn6.Text And btn3.Text = btn9.Text) Then  'V
            ln6.Visible = True
            termsub()
        ElseIf (btn3.Text = btn5.Text And btn3.Text = btn7.Text) Then  'D
            ln8.Visible = True
            termsub()
        End If
        numbtn = 3
        singleplayer()
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        oxvar = btn4.Text
        oxsub()
        btn4.Text = oxvar
        If (btn4.Text = btn5.Text And btn4.Text = btn6.Text) Then 'H
            ln2.Visible = True
            termsub()
        ElseIf (btn1.Text = btn4.Text And btn1.Text = btn7.Text) Then 'V
            ln4.Visible = True
            termsub()
        End If
        numbtn = 4
        singleplayer()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        oxvar = btn5.Text
        oxsub()
        btn5.Text = oxvar
        If (btn5.Text = btn4.Text And btn5.Text = btn6.Text) Then      'H
            ln2.Visible = True
            termsub()
        ElseIf (btn5.Text = btn2.Text And btn5.Text = btn8.Text) Then  'V
            ln6.Visible = True
            termsub()
        ElseIf (btn3.Text = btn5.Text And btn3.Text = btn7.Text) Then  'D1
            ln8.Visible = True
            termsub()
        ElseIf (btn1.Text = btn5.Text And btn5.Text = btn9.Text) Then  'D2
            ln7.Visible = True
            termsub()
        End If
        numbtn = 5
        singleplayer()
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        oxvar = btn6.Text
        oxsub()
        btn6.Text = oxvar
        If (btn4.Text = btn5.Text And btn4.Text = btn6.Text) Then 'H
            ln2.Visible = True
            termsub()
        ElseIf (btn3.Text = btn6.Text And btn3.Text = btn9.Text) Then  'V
            ln6.Visible = True
            termsub()
        End If
        numbtn = 6
        singleplayer()
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        oxvar = btn7.Text
        oxsub()
        btn7.Text = oxvar
        If (btn7.Text = btn8.Text And btn7.Text = btn9.Text) Then 'H
            ln3.Visible = True
            termsub()
        ElseIf (btn1.Text = btn4.Text And btn1.Text = btn7.Text) Then
            ln4.Visible = True
            termsub()
        ElseIf (btn3.Text = btn5.Text And btn3.Text = btn7.Text) Then  'D
            ln8.Visible = True
            termsub()
        End If
        numbtn = 7
        singleplayer()
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        oxvar = btn8.Text
        oxsub()
        btn8.Text = oxvar
        If (btn7.Text = btn8.Text And btn7.Text = btn9.Text) Then 'H
            ln3.Visible = True
            termsub()
        ElseIf (btn2.Text = btn5.Text And btn2.Text = btn8.Text) Then
            ln5.Visible = True
            termsub()
        End If
        numbtn = 8
        singleplayer()
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        oxvar = btn9.Text
        oxsub()
        btn9.Text = oxvar
        If (btn7.Text = btn8.Text And btn7.Text = btn9.Text) Then 'H
            ln3.Visible = True
            termsub()
        ElseIf (btn3.Text = btn6.Text And btn3.Text = btn9.Text) Then  'V
            ln6.Visible = True
            termsub()
        ElseIf (btn1.Text = btn5.Text And btn1.Text = btn9.Text) Then 'D
            ln7.Visible = True
            termsub()
        End If
        numbtn = 9
        singleplayer()
    End Sub

    Private Sub btnsingleeimp()
        If IOsingle = False Then
            IOsingle = True
            limpar()
            btnsingle.Text = "Desativar Single player"
        ElseIf IOsingle = True Then
            IOsingle = False
            limpar()
            btnsingle.Text = "Ativar Single player"
        End If
        imp = False
    End Sub

    Private Sub btnsingle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsingle.Click
        btnsingleeimp()
    End Sub

    Private Sub btnimp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimp.Click
        btnsingleeimp()
        imp = True
    End Sub
End Class
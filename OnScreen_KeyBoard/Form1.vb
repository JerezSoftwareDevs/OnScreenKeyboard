Public Class OnScreenKey
    Public Property ShiftKeyPressed As Object
    Public Property CapsKeyPressed As Object
    Public Property NumKeyPressed As Object
    Public Property ScrollKeyPressed As Object

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Process.Start("Notepad")
    End Sub

    Private Sub btn_Key_CurlyDash_Click(sender As Object, e As EventArgs) Handles btn_Key_CurlyDash.Click
        'txtTextBox.Text += "`"
        'SendKeys.Send("`")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("~")
        Else
            txtTextBox.AppendText("`")
        End If
    End Sub

    Private Sub btn_Key1_Click(sender As Object, e As EventArgs) Handles btn_Key1.Click
        'txtTextBox.Text += "1"
        'SendKeys.Send("1")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("!")
        Else
            txtTextBox.AppendText("1")
        End If
    End Sub

    Private Sub btn_Key2_Click(sender As Object, e As EventArgs) Handles btn_Key2.Click
        'txtTextBox.Text += "2"
        'SendKeys.Send("2")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("@")
        Else
            txtTextBox.AppendText("2")
        End If
    End Sub

    Private Sub btn_Key3_Click(sender As Object, e As EventArgs) Handles btn_Key3.Click
        'txtTextBox.Text += "3"
        'SendKeys.Send("3")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("#")
        Else
            txtTextBox.AppendText("3")
        End If
    End Sub

    Private Sub btn_Key4_Click(sender As Object, e As EventArgs) Handles btn_Key4.Click
        'txtTextBox.Text += "4"
        'SendKeys.Send("4")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("$")
        Else
            txtTextBox.AppendText("4")
        End If
    End Sub

    Private Sub btn_Key5_Click(sender As Object, e As EventArgs) Handles btn_Key5.Click
        'txtTextBox.Text += "5"
        'SendKeys.Send("5")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("%")
        Else
            txtTextBox.AppendText("5")
        End If
    End Sub

    Private Sub btn_Key6_Click(sender As Object, e As EventArgs) Handles btn_Key6.Click
        'txtTextBox.Text += "6"
        'SendKeys.Send("6")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("^")
        Else
            txtTextBox.AppendText("6")
        End If
    End Sub

    Private Sub btn_Key7_Click(sender As Object, e As EventArgs) Handles btn_Key7.Click
        'txtTextBox.Text += "7"
        'SendKeys.Send("7")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("&")
        Else
            txtTextBox.AppendText("7")
        End If
    End Sub

    Private Sub btn_Key8_Click(sender As Object, e As EventArgs) Handles btn_Key8.Click
        'txtTextBox.Text += "8"
        'SendKeys.Send("8")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("*")
        Else
            txtTextBox.AppendText("8")
        End If
    End Sub

    Private Sub btn_Key9_Click(sender As Object, e As EventArgs) Handles btn_Key9.Click
        'txtTextBox.Text += "9"
        'SendKeys.Send("9")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("(")
        Else
            txtTextBox.AppendText("9")
        End If
    End Sub

    Private Sub btn_Key0_Click(sender As Object, e As EventArgs) Handles btn_Key0.Click
        'txtTextBox.Text += "0"
        'SendKeys.Send("0")
        If ShiftKeyPressed Then
            txtTextBox.AppendText(")")
        Else
            txtTextBox.AppendText("0")
        End If
    End Sub

    Private Sub btn_Key_Dash_Click(sender As Object, e As EventArgs) Handles btn_Key_Dash.Click
        'txtTextBox.Text += "-"
        'SendKeys.Send("-")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("_")
        Else
            txtTextBox.AppendText("-")
        End If
    End Sub

    Private Sub Guna2GradientButton20_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton20.Click
        'txtTextBox.Text += "="
        'SendKeys.Send("=")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("+")
        Else
            txtTextBox.AppendText("=")
        End If
    End Sub

    Private Sub btn_Key_Q_Click(sender As Object, e As EventArgs) Handles btn_Key_Q.Click
        'txtTextBox.Text += "q"
        'SendKeys.Send("q")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("Q")
        Else
            txtTextBox.AppendText("q")
        End If
    End Sub

    Private Sub btn_Key_W_Click(sender As Object, e As EventArgs) Handles btn_Key_W.Click
        'txtTextBox.Text += "w"
        'SendKeys.Send("w")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("W")
        Else
            txtTextBox.AppendText("w")
        End If
    End Sub

    Private Sub btn_Key_E_Click(sender As Object, e As EventArgs) Handles btn_Key_E.Click
        'txtTextBox.Text += "e"
        'SendKeys.Send("e")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("E")
        Else
            txtTextBox.AppendText("e")
        End If
    End Sub

    Private Sub btn_Key_R_Click(sender As Object, e As EventArgs) Handles btn_Key_R.Click
        'txtTextBox.Text += "r"
        'SendKeys.Send("r")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("R")
        Else
            txtTextBox.AppendText("r")
        End If
    End Sub

    Private Sub btn_Key_T_Click(sender As Object, e As EventArgs) Handles btn_Key_T.Click
        'txtTextBox.Text += "t"
        'SendKeys.Send("t")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("T")
        Else
            txtTextBox.AppendText("t")
        End If
    End Sub

    Private Sub btn_Key_Y_Click(sender As Object, e As EventArgs) Handles btn_Key_Y.Click
        'txtTextBox.Text += "y"
        'SendKeys.Send("y")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("Y")
        Else
            txtTextBox.AppendText("y")
        End If
    End Sub

    Private Sub btn_Key_U_Click(sender As Object, e As EventArgs) Handles btn_Key_U.Click
        'txtTextBox.Text += "u"
        'SendKeys.Send("u")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("U")
        Else
            txtTextBox.AppendText("u")
        End If
    End Sub

    Private Sub btn_Key_I_Click(sender As Object, e As EventArgs) Handles btn_Key_I.Click
        'txtTextBox.Text += "i"
        'SendKeys.Send("i")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("I")
        Else
            txtTextBox.AppendText("i")
        End If
    End Sub

    Private Sub btn_Key_O_Click(sender As Object, e As EventArgs) Handles btn_Key_O.Click
        'txtTextBox.Text += "o"
        'SendKeys.Send("o")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("O")
        Else
            txtTextBox.AppendText("o")
        End If
    End Sub

    Private Sub btn_Key_P_Click(sender As Object, e As EventArgs) Handles btn_Key_P.Click
        'txtTextBox.Text += "p"
        'SendKeys.Send("p")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("P")
        Else
            txtTextBox.AppendText("p")
        End If
    End Sub

    Private Sub btn_Key_OpenBracket_Click(sender As Object, e As EventArgs) Handles btn_Key_OpenBracket.Click
        'txtTextBox.Text += "["
        'SendKeys.Send("[")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("{")
        Else
            txtTextBox.AppendText("[")
        End If
    End Sub

    Private Sub btn_Key_CloseBracket_Click(sender As Object, e As EventArgs) Handles btn_Key_CloseBracket.Click
        'txtTextBox.Text += "]"
        'SendKeys.Send("]")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("}")
        Else
            txtTextBox.AppendText("]")
        End If
    End Sub

    Private Sub btn_Key_A_Click(sender As Object, e As EventArgs) Handles btn_Key_A.Click
        'txtTextBox.Text += "a"
        'SendKeys.Send("a")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("A")
        Else
            txtTextBox.AppendText("a")
        End If
    End Sub

    Private Sub btn_Key_S_Click(sender As Object, e As EventArgs) Handles btn_Key_S.Click
        'txtTextBox.Text += "s"
        'SendKeys.Send("s")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("S")
        Else
            txtTextBox.AppendText("s")
        End If
    End Sub

    Private Sub btn_Key_D_Click(sender As Object, e As EventArgs) Handles btn_Key_D.Click
        'txtTextBox.Text += "d"
        'SendKeys.Send("d")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("D")
        Else
            txtTextBox.AppendText("d")
        End If
    End Sub

    Private Sub btn_Key_F_Click(sender As Object, e As EventArgs) Handles btn_Key_F.Click
        'txtTextBox.Text += "f"
        'SendKeys.Send("f")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("F")
        Else
            txtTextBox.AppendText("f")
        End If
    End Sub

    Private Sub btn_Key_G_Click(sender As Object, e As EventArgs) Handles btn_Key_G.Click
        'txtTextBox.Text += "g"
        'SendKeys.Send("g")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("G")
        Else
            txtTextBox.AppendText("g")
        End If
    End Sub

    Private Sub btn_Key_H_Click(sender As Object, e As EventArgs) Handles btn_Key_H.Click
        'txtTextBox.Text += "h"
        'SendKeys.Send("h")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("H")
        Else
            txtTextBox.AppendText("h")
        End If
    End Sub

    Private Sub btn_Key_J_Click(sender As Object, e As EventArgs) Handles btn_Key_J.Click
        'txtTextBox.Text += "j"
        'SendKeys.Send("j")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("J")
        Else
            txtTextBox.AppendText("j")
        End If
    End Sub

    Private Sub btn_Key_K_Click(sender As Object, e As EventArgs) Handles btn_Key_K.Click
        'txtTextBox.Text += "k"
        'SendKeys.Send("k")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("K")
        Else
            txtTextBox.AppendText("k")
        End If
    End Sub

    Private Sub btn_Key_L_Click(sender As Object, e As EventArgs) Handles btn_Key_L.Click
        'txtTextBox.Text += "l"
        'SendKeys.Send("l")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("L")
        Else
            txtTextBox.AppendText("l")
        End If
    End Sub

    Private Sub btn_Key_Colon_Click(sender As Object, e As EventArgs) Handles btn_Key_Colon.Click
        'txtTextBox.Text += ";"
        'SendKeys.Send(";")
        If ShiftKeyPressed Then
            txtTextBox.AppendText(":")
        Else
            txtTextBox.AppendText(";")
        End If
    End Sub

    Private Sub btn_Key_Quotation_Click(sender As Object, e As EventArgs) Handles btn_Key_Quotation.Click
        'txtTextBox.Text += "'"
        'SendKeys.Send("'")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("""")
        Else
            txtTextBox.AppendText("'")
        End If
    End Sub

    Private Sub btn_Key_BackSlash_Click(sender As Object, e As EventArgs) Handles btn_Key_BackSlash.Click
        'txtTextBox.Text += "\"
        'SendKeys.Send("\")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("|")
        Else
            txtTextBox.AppendText("\")
        End If
    End Sub

    Private Sub btn_Key_Z_Click(sender As Object, e As EventArgs) Handles btn_Key_Z.Click
        'txtTextBox.Text += "z"
        'SendKeys.Send("z")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("Z")
        Else
            txtTextBox.AppendText("z")
        End If
    End Sub

    Private Sub btn_Key_X_Click(sender As Object, e As EventArgs) Handles btn_Key_X.Click
        'txtTextBox.Text += "x"
        'SendKeys.Send("x")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("X")
        Else
            txtTextBox.AppendText("x")
        End If
    End Sub

    Private Sub btn_Key_C_Click(sender As Object, e As EventArgs) Handles btn_Key_C.Click
        'txtTextBox.Text += "c"
        'SendKeys.Send("c")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("C")
        Else
            txtTextBox.AppendText("c")
        End If
    End Sub

    Private Sub btn_Key_V_Click(sender As Object, e As EventArgs) Handles btn_Key_V.Click
        'txtTextBox.Text += "v"
        'SendKeys.Send("v")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("V")
        Else
            txtTextBox.AppendText("v")
        End If
    End Sub

    Private Sub btn_Key_B_Click(sender As Object, e As EventArgs) Handles btn_Key_B.Click
        'txtTextBox.Text += "b"
        'SendKeys.Send("b")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("B")
        Else
            txtTextBox.AppendText("b")
        End If
    End Sub

    Private Sub btn_Key_N_Click(sender As Object, e As EventArgs) Handles btn_Key_N.Click
        'txtTextBox.Text += "n"
        'SendKeys.Send("n")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("N")
        Else
            txtTextBox.AppendText("n")
        End If
    End Sub

    Private Sub btn_Key_M_Click(sender As Object, e As EventArgs) Handles btn_Key_M.Click
        'txtTextBox.Text += "m"
        'SendKeys.Send("m")
        If ShiftKeyPressed Or CapsKeyPressed Then
            txtTextBox.AppendText("M")
        Else
            txtTextBox.AppendText("m")
        End If
    End Sub

    Private Sub btn_Key_Comma_Click(sender As Object, e As EventArgs) Handles btn_Key_Comma.Click
        'txtTextBox.Text += ","
        'SendKeys.Send(",")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("<")
        Else
            txtTextBox.AppendText(",")
        End If
    End Sub

    Private Sub btn_Key_Period_Click(sender As Object, e As EventArgs) Handles btn_Key_Period.Click
        'txtTextBox.Text += "."
        'SendKeys.Send(".")
        If ShiftKeyPressed Then
            txtTextBox.AppendText(">")
        Else
            txtTextBox.AppendText(".")
        End If
    End Sub

    Private Sub btn_Key_ForwardSlash_Click(sender As Object, e As EventArgs) Handles btn_Key_ForwardSlash.Click
        'txtTextBox.Text += "/"
        'SendKeys.Send("/")
        If ShiftKeyPressed Then
            txtTextBox.AppendText("?")
        Else
            txtTextBox.AppendText("/")
        End If
    End Sub

    Private Sub btn_Key_Space_Click(sender As Object, e As EventArgs) Handles btn_Key_Space.Click
        If txtTextBox.Text.Length > 0 AndAlso txtTextBox.Text.Last() <> " " Then
            ' If not, add a space to the output and send the keystroke to the active window
            txtTextBox.Text += " "
            SendKeys.Send(" ")
        Else
            ' Otherwise, do nothing
        End If
    End Sub

    Private Sub btn_Key_Backspace_Click(sender As Object, e As EventArgs) Handles btn_Key_Backspace.Click
        Dim text As String = txtTextBox.Text

        ' Check if the text is not empty
        If text.Length > 0 Then
            ' Remove the last character from the text
            text = text.Substring(0, text.Length - 1)

            ' Update the output textbox with the new text
            txtTextBox.Text = text

            ' Move the cursor to the end of the output textbox
            txtTextBox.SelectionStart = txtTextBox.Text.Length
            txtTextBox.SelectionLength = 0
        End If
    End Sub

    Private Sub btn_Key_Enter_Click(sender As Object, e As EventArgs) Handles btn_Key_Enter.Click
        txtTextBox.AppendText(vbNewLine)
    End Sub

    Private Sub btn_Key_Shift1_Click(sender As Object, e As EventArgs) Handles btn_Key_Shift1.Click
        'Toggle the shift state of the keyboard
        ShiftKeyPressed = Not ShiftKeyPressed

        'Change the text on the shift button to reflect the shift state
        If ShiftKeyPressed Then
            btn_Key_Shift1.Text = "Shift On"
        Else
            btn_Key_Shift1.Text = "Shift"
        End If
    End Sub

    Private Sub btn_Key_Shift2_Click(sender As Object, e As EventArgs) Handles btn_Key_Shift2.Click
        'Toggle the shift state of the keyboard
        ShiftKeyPressed = Not ShiftKeyPressed

        'Change the text on the shift button to reflect the shift state
        If ShiftKeyPressed Then
            btn_Key_Shift2.Text = "Shift On"
        Else
            btn_Key_Shift2.Text = "Shift"
        End If
    End Sub

    Private Sub btn_Key_CapsLock_Click(sender As Object, e As EventArgs) Handles btn_Key_CapsLock.Click
        'For uppercase Character
        CapsKeyPressed = Not CapsKeyPressed

        If CapsKeyPressed Then
            btn_Key_CapsLock.Text = "Caps Lock On"
            Indicator_CapsLock_On.Show()
            Indicator_CapsLock_Off.Hide()
        Else
            btn_Key_CapsLock.Text = "Caps Lock"
            Indicator_CapsLock_Off.Show()
            Indicator_CapsLock_On.Hide()
        End If
    End Sub

    Private Sub btn_Key_Tab_Click(sender As Object, e As EventArgs) Handles btn_Key_Tab.Click

    End Sub

    Private Sub btn_NumLock_Click(sender As Object, e As EventArgs) Handles btn_NumLock.Click
        NumKeyPressed = Not NumKeyPressed

        If NumKeyPressed Then
            btn_NumLock.Text = " Num Lock On"
            Indicator_NumLock_On.Show()
            Indicator_NumLock_Off.Hide()
        Else
            btn_NumLock.Text = "Num Lock"
            Indicator_NumLock_Off.Show()
            Indicator_NumLock_On.Hide()
        End If
    End Sub

    Private Sub btn_ScroLck_Click(sender As Object, e As EventArgs) Handles btn_ScroLck.Click
        ScrollKeyPressed = Not ScrollKeyPressed

        If ScrollKeyPressed Then
            btn_ScroLck.Text = "Scroll Lock On"
            Indicator_ScrollLock_On.Show()
            Indicator_ScrollLock_Off.Hide()
        Else
            btn_ScroLck.Text = "Scroll Lock"
            Indicator_ScrollLock_Off.Show()
            Indicator_ScrollLock_On.Hide()
        End If

    End Sub

End Class

Module Funciones

    'Validar_Nombre -----------------------------------------------------------------------------------------------
    Function Validar_Nombre2(ByVal e As KeyPressEventArgs, Caja As TextBox) As KeyPressEventArgs
        Static Espacio As Boolean = False
        Static Mayus As Boolean = False
        Static Punto As Boolean = False

        If Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Or e.KeyChar = Chr(46) Then
            If Punto = True And Not e.KeyChar = Chr(32) And Not e.KeyChar = Chr(8) Then
                e.Handled = True
            ElseIf e.KeyChar = Chr(32) And Espacio = False And Caja.TextLength > 2 Then
                Espacio = True
                Punto = False
            ElseIf e.KeyChar = Chr(32) Then
                e.Handled = True
            ElseIf e.KeyChar = Chr(8) And Espacio = True Then
                Espacio = False
            ElseIf e.KeyChar = Chr(8) And Punto = True Then
                Punto = False
            ElseIf e.KeyChar = Chr(8) And Mayus = True Then
                Mayus = False
            ElseIf Caja.TextLength = 0 And Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            ElseIf Char.IsLetter(e.KeyChar) And Caja.TextLength > 3 And Espacio = True Then
                Espacio = False
                e.KeyChar = Char.ToUpper(e.KeyChar)
                Mayus = True
                Punto = False
            ElseIf Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToLower(e.KeyChar)
                Mayus = False
                Punto = False
            ElseIf e.KeyChar = Chr(46) And Mayus = True And Punto = False And Caja.TextLength > 3 Then
                Punto = True
            ElseIf e.KeyChar = Chr(46) Then
                e.Handled = True
            End If
        Else
            e.Handled = True
        End If

        Return e
    End Function
    Function Validar_Nombre(ByVal e As KeyPressEventArgs, ByVal Caja As TextBox) As KeyPressEventArgs


        Return e
    End Function
End Module

Module Funciones

    'Validar_Nombre --------------------------------------------------------------------------------
    Function Validar_Nombre(ByVal e As KeyPressEventArgs, ByVal Cadena As String) As KeyPressEventArgs

        If Char.IsLetter(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Or e.KeyChar = Chr(46) Then
            If Cadena.Length = 0 And Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            ElseIf Cadena.Length < 3 And e.KeyChar = Chr(32) Then
                e.Handled = True
            ElseIf Cadena.Length < 3 And e.KeyChar = Chr(46) Then
                e.Handled = True
            Else
                If Cadena.Length > 0 Then
                    If Cadena(Cadena.Length - 1) = " " And e.KeyChar = Chr(32) Then
                        e.Handled = True
                    ElseIf (Cadena(Cadena.Length - 1) = "." Or Char.IsLower(Cadena(Cadena.Length - 1)) Or Cadena(Cadena.Length - 1) = " ") And e.KeyChar = Chr(46) Then
                        e.Handled = True
                    ElseIf Char.IsLetter(e.KeyChar) And Cadena(Cadena.Length - 1) = " " Then
                        e.KeyChar = Char.ToUpper(e.KeyChar)
                    ElseIf Char.IsLetter(e.KeyChar) And Cadena(Cadena.Length - 1) = "." Then
                        e.Handled = True
                    ElseIf Char.IsLetter(e.KeyChar) Then
                        e.KeyChar = Char.ToLower(e.KeyChar)
                    End If
                End If
            End If
        Else
            e.Handled = True
        End If

        Return e
    End Function

    'Validar_Numero
    Function Validar_Numero(ByVal e As KeyPressEventArgs) As KeyPressEventArgs
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(8) Then
            e.Handled = True
        End If
        Return e
    End Function
End Module

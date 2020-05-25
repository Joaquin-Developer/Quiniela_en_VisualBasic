Public Class Form1
    Private arrayApostados() As Integer
    Dim indice_ArrayApostados As Integer = 0
    Private arraySorteados(20) As Integer

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If indice_ArrayApostados = 0 Then
                If lboxApostados.Items.Count < 20 Then
                    lboxApostados.Items.Add(nudNumero.Value)
                    lboxApostados.SelectedIndex = 0 ' para que se quede seleccionado el primer item de la lista.
                    ReDim Preserve arrayApostados(indice_ArrayApostados + 1)
                    arrayApostados(indice_ArrayApostados) = nudNumero.Value
                    indice_ArrayApostados += 1
                Else
                    MsgBox("No puede apostar mas de 20 numeros", vbExclamation, "Error")
                End If
            Else
                ' indiceArray distinto de cero
                If lboxApostados.Items.Count < 20 Then
                    If busquedaApostados(nudNumero.Value) Then
                        MsgBox("Numero ya apostado", vbExclamation, "Aviso")
                    Else
                        lboxApostados.Items.Add(nudNumero.Value)
                        lboxApostados.SelectedIndex = 0 ' para que se quede seleccionado el primer item de la lista.
                        ReDim Preserve arrayApostados(indice_ArrayApostados + 1)
                        arrayApostados(indice_ArrayApostados) = nudNumero.Value
                        indice_ArrayApostados += 1
                        ' Nota: Length será un valor superior al último index del Array
                    End If
                Else
                    MsgBox("No puede apostar mas de 20 numeros", vbExclamation, "Error")
                End If

            End If
        Catch ex As Exception
            MsgBox("Error fué: " & ex.Message, vbCritical, "Se produjo un error al intentar realizar la acción")
        End Try

    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Try
            ' eliminar elemento del Array de apostados (Logica):
            Dim arrayAuxiliar(arrayApostados.Length - 1) As Integer
            Dim elem_borrar As Integer = CInt(lboxApostados.SelectedItem)
            Dim indexNuevoArray As Integer = 0

            For Each elem As Integer In arrayApostados
                If elem <> elem_borrar Then ' elemento que se preservará en el array de apostados.
                    arrayAuxiliar(indexNuevoArray) = elem
                    indexNuevoArray += 1
                End If
            Next
            Erase arrayApostados
            arrayApostados = arrayAuxiliar
            indice_ArrayApostados -= 1 ' se le resta 1 ya que en este procedimiento se da de baja a un solo elemento
            Erase arrayAuxiliar ' vaciamos arrayAuiliar para su posterior uso.

            ' eliminar elemento del ListBox (GUI):
            lboxApostados.Items.Remove(lboxApostados.SelectedItem)
            If lboxApostados.Items.Count <> 0 Then
                lboxApostados.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Error fué: " & ex.Message, vbCritical, "Se produjo un error al intentar realizar la acción")
        End Try

    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        lboxApostados.Items.Clear()
        Erase arrayApostados ' vaciar Array

    End Sub

    Private Sub btnSortear_Click(sender As Object, e As EventArgs) Handles btnSortear.Click
        Try     '<>
            lbxSorteados.Items.Clear()
            ReDim arraySorteados(20) ' con esto vacio los elementos del array (para evitar problemas)
            ' nota: el ReDim es utilizado para cambiar tamaño de array sin preservar sus elementos.
            Dim numero As New Random
            Dim x As Integer
            Dim cont As Integer = 0 'contador
            Do
                x = Math.Truncate(numero.NextDouble * 999)
                If busquedaSorteados(x) = False Then
                    arraySorteados(cont) = x
                    cont += 1
                End If
            Loop While cont < 20
            Dim i As Integer = 0
            For i = 0 To 19 Step 1 ' mostrar los elementos sorteados en el ListBox 
                lbxSorteados.Items.Add(arraySorteados(i))
            Next

            verAciertos()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Function busquedaSorteados(ByRef x As Integer) As Boolean
        ' metodo que busca si el numero sorteado pertenece al array
        ' caso que pertenezca retorna true, caso contrario false
        Dim pertenece As Boolean = False
        Dim i As Integer = 0
        For i = 0 To 19 Step 1
            If arraySorteados(i) = x Then
                pertenece = True
                Exit For ' en caso que sea afirmativo salimos, no es necesario seguir comprobando.
            End If
        Next
        Return pertenece
    End Function

    Private Function busquedaApostados(ByRef x As Integer) As Boolean
        ' metodo que busca si el numero sorteado pertenece al arrayApostados
        ' caso que pertenezca retorna true, caso contrario false
        Dim pertenece As Boolean = False
        For i As Integer = 0 To indice_ArrayApostados Step 1
            If arrayApostados(i) = x Then
                pertenece = True
                Exit For
            End If
        Next
        Return pertenece
    End Function

    Private Sub verAciertos()

        'mostramos en MsgBox'es los numeros acertados.:
        Try
            For i As Integer = 0 To 19 Step 1
                For j As Integer = 0 To (indice_ArrayApostados) Step 1
                    If arraySorteados(i) = arrayApostados(j) Then
                        MsgBox("Número: " & arraySorteados(i), vbInformation, "Número acertado")
                    End If
                Next
            Next
        Catch ex As Exception
            MsgBox("Se produjo el siguiente error: " & ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim i As Integer = MsgBox("¿Estás seguro que deseas cerrar el programa?", vbQuestion + vbYesNo, "Confirmar salida")
        If i = 6 Then
            Me.Close()
        End If
    End Sub

End Class

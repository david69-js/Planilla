Imports System.IO

Public Class Form2
    Private liquido As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GuardarTrabajador()
    End Sub

    Private Sub GuardarTrabajador()
        ' Asignar variables
        Dim codigo As String = TextBox1.Text.Trim()
        Dim nombres As String = TextBox2.Text.Trim()
        Dim apellidos As String = TextBox3.Text.Trim()
        Dim sueldo As Decimal
        Dim descuentos As Decimal

        ' Validar que los campos no estén vacíos y sean valores numéricos
        If String.IsNullOrEmpty(codigo) Then
            MessageBox.Show("El campo 'código' no puede estar vacío.")
            Return
        End If

        If String.IsNullOrEmpty(nombres) Then
            MessageBox.Show("El campo 'nombres' no puede estar vacío.")
            Return
        End If

        If String.IsNullOrEmpty(apellidos) Then
            MessageBox.Show("El campo 'apellidos' no puede estar vacío.")
            Return
        End If

        If Not Decimal.TryParse(TextBox4.Text.Trim(), sueldo) Then
            MessageBox.Show("El campo 'sueldo' debe ser un valor numérico válido.")
            Return
        End If

        If Not Decimal.TryParse(TextBox6.Text.Trim(), descuentos) Then
            MessageBox.Show("El campo 'descuentos' debe ser un valor numérico válido.")
            Return
        End If

        Dim igss As Decimal = sueldo * 0.0483 ' Calcula el IGSS como un porcentaje del sueldo
        Dim sueldoLiquido As Decimal = sueldo - igss - descuentos

        TextBox5.Text = igss.ToString() ' Muestra el valor del IGSS en TextBox5
        TextBox7.Text = sueldoLiquido.ToString() ' Muestra el sueldo líquido en TextBox7
        liquido = sueldoLiquido ' Asigna el sueldo líquido a la variable miembro `liquido`

        ' Controlador de estados
        Dim encontrado As Boolean = False

        ' Leer archivo
        Using arch As New StreamReader("employe.txt")
            Do While arch.Peek() >= 0
                ' Leer líneas y verificar el código
                Dim cod = arch.ReadLine()
                Dim nom = arch.ReadLine()
                Dim ape = arch.ReadLine()
                Dim suel = arch.ReadLine()
                Dim ig = arch.ReadLine()
                Dim desc = arch.ReadLine()
                Dim liq = arch.ReadLine()

                ' Cambio de estado
                If codigo = cod Then
                    encontrado = True
                    Exit Do
                End If
            Loop
            arch.Close()
        End Using

        If encontrado Then
            MessageBox.Show("No se pudo guardar la información. Ya existe un empleado con el mismo código.")
        Else
            ' Crear nuevo trabajador
            Using openFile As New StreamWriter("employe.txt", True)
                ' Abrir y escribir líneas
                openFile.WriteLine(codigo)
                openFile.WriteLine(nombres)
                openFile.WriteLine(apellidos)
                openFile.WriteLine(sueldo)
                openFile.WriteLine(igss)
                openFile.WriteLine(descuentos)
                openFile.WriteLine(liquido)
            End Using
            MessageBox.Show("La información se ha guardado correctamente.")

            Dim form4 As New Form4
            form4.Show()
            Me.Hide()
        End If
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        CalcularSueldoLiquido()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        CalcularSueldoLiquido()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        CalcularSueldoLiquido()
    End Sub

    Private Sub CalcularSueldoLiquido()
        Dim sueldo As Decimal
        Dim igss As Decimal
        Dim descuentos As Decimal

        ' Validar y obtener los valores de sueldo, IGSS y descuentos desde los TextBox
        If Decimal.TryParse(TextBox4.Text.Trim(), sueldo) AndAlso Decimal.TryParse(TextBox5.Text.Trim(), igss) AndAlso Decimal.TryParse(TextBox6.Text.Trim(), descuentos) Then
            ' Calcular el sueldo líquido
            Dim sueldoLiquido As Decimal = sueldo - igss - descuentos

            ' Mostrar el sueldo líquido en TextBox7 y deshabilitarlo
            TextBox7.Text = sueldoLiquido.ToString()
            TextBox7.Enabled = False

            liquido = sueldoLiquido ' Actualizar la variable miembro `liquido` con el nuevo valor
        Else
            ' Si hay algún error en los datos, limpiar el TextBox7 y habilitarlo
            TextBox7.Text = ""
            TextBox7.Enabled = True

            liquido = 0 ' Asignar un valor por defecto a la variable miembro `liquido`
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form4 As New Form4
        form4.Show()
        Me.Hide()
    End Sub
End Class

Imports System.IO

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim arch As New StreamReader("employe.txt")
        Dim buscarNombre As String = TextBox2.Text
        Dim buscarApellido As String = TextBox3.Text
        Dim buscarCodigo As String = TextBox1.Text

        Dim encontrado As Boolean = False ' Variable para indicar si se encontró una coincidencia

        Do While arch.Peek() >= 0 ' Mientras haya líneas por leer
            Dim codigo = arch.ReadLine()
            Dim nombres = arch.ReadLine()
            Dim apellidos = arch.ReadLine()
            Dim sueldo = arch.ReadLine()
            Dim igss = arch.ReadLine()
            Dim descuentos = arch.ReadLine()
            Dim liquido = arch.ReadLine()

            If codigo.Trim() = buscarCodigo AndAlso nombres.Trim() = buscarNombre AndAlso apellidos.Trim() = buscarApellido Then
                ' Coincidencia encontrada, hacer algo con los datos del empleado
                encontrado = True
                Exit Do ' Salir del bucle
            End If

        Loop

        arch.Close()

        If encontrado Then ' Concidencia de codigo
            MessageBox.Show("Trabajador encontrado: " & buscarNombre & " " & buscarApellido & ", " & buscarCodigo)
            Panel4.Visible = False ' esconder panel
            Panel5.Visible = True ' mostrar panel
            TextBox8.Text = buscarCodigo
            TextBox5.Text = buscarNombre & " " & buscarApellido
            TextBox6.Text = DateTime.Now.ToString("dd/MM/yyyy")
            TextBox8.Enabled = False ' Deshabilitar 
            TextBox5.Enabled = False ' Deshabilitar
        Else
            MessageBox.Show("Trabajador no encontrado : " & buscarNombre & " " & buscarApellido & ", " & buscarCodigo)
            Panel4.Visible = True
        End If
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs)
        Panel5.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' funcion guardar cheque
        GenerarCheque()
    End Sub

    Private Sub GenerarCheque()
        'asignar valores
        Dim id As String = Guid.NewGuid().ToString()
        Dim nombre As String = TextBox5.Text.Trim()
        Dim fecha As String = TextBox6.Text.Trim()
        Dim monto As String = TextBox4.Text.Trim()
        Dim firma As String = TextBox7.Text.Trim()
        Dim Nreferencia As String = TextBox10.Text.Trim()
        Dim NotaPago As String = TextBox11.Text.Trim()
        Dim codEmpleado As String = TextBox8.Text.Trim()

        'Crear cheque y guardar
        Using openFile As New StreamWriter("cheques.txt", True)
            'abrir y escribir lineas
            openFile.WriteLine(id)
            openFile.WriteLine(nombre)
            openFile.WriteLine(fecha)
            openFile.WriteLine(monto)
            openFile.WriteLine(firma)
            openFile.WriteLine(Nreferencia)
            openFile.WriteLine(NotaPago)
            openFile.WriteLine(codEmpleado)
        End Using

        Dim form5 As New Form5
        form5.Show()
        Me.Hide()


    End Sub

End Class
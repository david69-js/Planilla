Imports System.IO

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

        If encontrado Then
            MessageBox.Show("Coincidencia encontrada: " & buscarNombre & " " & buscarApellido & ", " & buscarCodigo)
            Panel4.Visible = False
            Panel5.Visible = True
            TextBox8.Text = buscarCodigo
            TextBox5.Text = buscarNombre & " " & buscarApellido
            TextBox6.Text = DateTime.Now.ToString("dd/MM/yyyy")
            TextBox8.Enabled = False
            TextBox5.Enabled = False
        Else
            MessageBox.Show("No se encontró coincidencia: " & buscarNombre & " " & buscarApellido & ", " & buscarCodigo)
            Panel4.Visible = True
        End If
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel5.Visible = False
        Panel4.Visible = True
    End Sub
End Class
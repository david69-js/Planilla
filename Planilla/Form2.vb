Imports System.IO

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        saveData()
    End Sub

    Private Sub saveData()
        Dim codigo As String = TextBox1.Text.Trim()
        Dim nombres As String = TextBox2.Text.Trim()
        Dim apellidos As String = TextBox3.Text.Trim()
        Dim encontrado As Boolean = False

        Using arch As New StreamReader("employe.txt")
            Do While arch.Peek() >= 0
                Dim cod = arch.ReadLine()
                Dim nom = arch.ReadLine()
                Dim ape = arch.ReadLine()
                Dim sueldo = arch.ReadLine()
                Dim igss = arch.ReadLine()
                Dim descuentos = arch.ReadLine()
                Dim liquido = arch.ReadLine()

                If codigo = cod Then
                    encontrado = True
                    Exit Do
                End If
            Loop
            arch.Close()
        End Using

        If encontrado Then
            MessageBox.Show("No se pudo guardar la información. Ya existe un empleado con el mismo código")
        Else
            Using openFile As New StreamWriter("employe.txt", True)
                openFile.WriteLine(codigo)
                openFile.WriteLine(nombres)
                openFile.WriteLine(apellidos)
                openFile.WriteLine(TextBox4.Text)
                openFile.WriteLine(TextBox5.Text)
                openFile.WriteLine(TextBox6.Text)
                openFile.WriteLine(TextBox7.Text)
            End Using
            MessageBox.Show("La información se ha guardado correctamente.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim form4 As New Form4
        form4.Show()
        Me.Hide()
    End Sub
End Class
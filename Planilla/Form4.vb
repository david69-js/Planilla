Imports System.IO

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs)
        If Not File.Exists("employe.txt") Then
            Dim arch As New StreamWriter("employe.txt")
            arch.Close()
        Else
            Dim arch As New StreamReader("employe.txt")
            While Not arch.EndOfStream
                Dim codigo = arch.ReadLine()
                Dim nombres = arch.ReadLine()
                Dim apellidos = arch.ReadLine()
                Dim sueldo = arch.ReadLine()
                Dim igss = arch.ReadLine()
                Dim descuentos = arch.ReadLine()
                Dim liquido = arch.ReadLine()
                DataGridView1.Rows.Add(codigo, nombres, apellidos, sueldo, igss, descuentos, liquido)
            End While
            arch.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub
End Class
Imports System.IO

Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GeneratePanels()
    End Sub

    Private Sub GeneratePanels()
        Dim rowHeight As Integer = 280 ' Height of each row
        Dim verticalSpacing As Integer = 10 ' Spacing between rows
        Dim columnsPerRow As Integer = 2 ' Number of columns in each row
        Dim panelWidth As Integer = (Me.ClientSize.Width - 60) \ columnsPerRow ' Width of each panel
        Dim panelIndex As Integer = 0
        Dim currentRow As Integer = 0 ' Track the current row index
        Dim currentColumn As Integer = 0 ' Track the current column index

        If Not File.Exists("cheques.txt") Then
            Dim arch As New StreamWriter("cheques.txt")
            arch.Close()
        Else
            Dim arch As New StreamReader("cheques.txt")
            While Not arch.EndOfStream
                Dim id As String = arch.ReadLine()
                Dim nombre As String = arch.ReadLine()
                Dim fecha As String = arch.ReadLine()
                Dim monto As String = arch.ReadLine()
                Dim firma As String = arch.ReadLine()
                Dim Nreferencia As String = arch.ReadLine()
                Dim NotaPago As String = arch.ReadLine()
                Dim codEmpleado As String = arch.ReadLine()

                ' Create a new panel for each set of data
                Dim panel As New Panel()
                panel.Location = New Point(10 + (panelWidth + verticalSpacing) * currentColumn, (rowHeight + verticalSpacing) * currentRow)
                panel.Size = New Size(panelWidth, rowHeight)
                panel.BackColor = Color.LightGray

                ' Create nested panels for grid cells
                ' Create nested panels for grid cells
                Dim labelX As Integer = 10
                Dim labelY As Integer = 10
                Dim labelSpacingY As Integer = 25

                AddLabelToPanel(panel, "ID: ", id, New Point(labelX, labelY))
                labelY += labelSpacingY

                AddLabelToPanel(panel, "Dirigido a: ", nombre, New Point(labelX, labelY))
                labelY += labelSpacingY

                AddLabelToPanel(panel, "Fecha de emision: ", fecha, New Point(labelX, labelY))
                labelY += labelSpacingY

                AddLabelToPanel(panel, "Monto: ", monto, New Point(labelX, labelY))
                labelY += labelSpacingY

                AddLabelToPanel(panel, "Firma del remitente: ", firma, New Point(labelX, labelY))
                labelY += labelSpacingY

                AddLabelToPanel(panel, "Numero de Referencia: ", Nreferencia, New Point(labelX, labelY))
                labelY += labelSpacingY

                AddLabelToPanel(panel, "Nota de Pago: ", NotaPago, New Point(labelX + 5, labelY))
                labelY += labelSpacingY

                AddLabelToPanel(panel, "Codido Empleado: ", codEmpleado, New Point(labelX, labelY))
                labelY += labelSpacingY

                Dim button As New Button()
                button.Text = "Imprimir cheque"
                button.Location = New Point(labelX, labelY)
                button.Size = New Size(160, 40)

                ' Store the information as custom data in the Tag property
                button.Tag = $"ID: {id}{Environment.NewLine} Dirigido a: {nombre}{Environment.NewLine}Fecha de emision:  {fecha}{Environment.NewLine}Monto: {monto}"

                ' Assign the button click event handler
                AddHandler button.Click, AddressOf Button_Click

                ' Add the button to the panel
                panel.Controls.Add(button)


                ' Add the panel to the MainPanel
                MainPanel.Controls.Add(panel)

                panelIndex += 1
                currentColumn += 1

                ' Move to the next row if all columns in the current row are filled
                If currentColumn >= columnsPerRow Then
                    currentColumn = 0
                    currentRow += 1
                End If
            End While
            arch.Close()
        End If
    End Sub

    Private Sub AddLabelToPanel(panel As Panel, labelText As String, valueText As String, location As Point)
        Dim label As New Label()
        label.Text = labelText
        label.Font = New Font(label.Font, FontStyle.Bold)
        label.Dock = DockStyle.Top
        label.AutoSize = False
        label.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        label.Location = location

        Dim valueLabel As New Label()
        valueLabel.Text = valueText
        valueLabel.Location = New Point(location.X + label.Width, location.Y)

        panel.Controls.Add(label)
        panel.Controls.Add(valueLabel)
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        ' Handle the button click event here
        Dim clickedButton As Button = DirectCast(sender, Button)

        ' Retrieve the information from the Tag property
        Dim buttonInfo As String = clickedButton.Tag.ToString()

        ' Display the information in a message box or any other desired way
        MessageBox.Show(buttonInfo)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1
        form1.Show()
        Me.Hide()
    End Sub
End Class

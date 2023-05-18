<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox4 = New TextBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        TextBox6 = New TextBox()
        Label8 = New Label()
        TextBox7 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Britannic Bold", 26.25F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(158, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 38)
        Label1.TabIndex = 0
        Label1.Text = "INGRESE UN NUEVO EMPLEADO"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(224, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 21)
        Label2.TabIndex = 2
        Label2.Text = "Codigo"' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(227, 133)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(224, 171)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 21)
        Label3.TabIndex = 4
        Label3.Text = "Nombres"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(224, 226)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 21)
        Label4.TabIndex = 5
        Label4.Text = "Apellidos"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(224, 189)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(227, 244)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(465, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 21)
        Label5.TabIndex = 8
        Label5.Text = "Sueldo"' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(465, 133)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(465, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(60, 21)
        Label6.TabIndex = 10
        Label6.Text = "IGSS"' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(465, 189)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(465, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 21)
        Label7.TabIndex = 12
        Label7.Text = "Descuentos"' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(465, 244)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 13
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(627, 113)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 21)
        Label8.TabIndex = 14
        Label8.Text = "Liquido"' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(627, 133)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 15
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(627, 194)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 73)
        Button1.TabIndex = 16
        Button1.Text = "Agregar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RoyalBlue
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(592, 331)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 52)
        Button2.TabIndex = 17
        Button2.Text = "Regresa al menu"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RoyalBlue
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Elephant", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(227, 331)
        Button3.Name = "Button3"
        Button3.Size = New Size(225, 52)
        Button3.TabIndex = 18
        Button3.Text = "Ver planilla de trabajadores"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(9, 124)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(185, 178)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox7)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REGISTRO"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

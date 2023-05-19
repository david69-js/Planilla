<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 26.25F, FontStyle.Underline, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(226, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 39)
        Label1.TabIndex = 0
        Label1.Text = "PLANILLA DE TRABAJO"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.RoyalBlue
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(198, 128)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 68)
        Button1.TabIndex = 1
        Button1.Text = "Ver planilla"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.RoyalBlue
        Button2.Cursor = Cursors.Hand
        Button2.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(304, 128)
        Button2.Name = "Button2"
        Button2.Size = New Size(247, 68)
        Button2.TabIndex = 2
        Button2.Text = "Ingresar nuevos empleados"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.RoyalBlue
        Button3.Cursor = Cursors.Hand
        Button3.Font = New Font("Microsoft Sans Serif", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Location = New Point(557, 128)
        Button3.Name = "Button3"
        Button3.Size = New Size(162, 68)
        Button3.TabIndex = 3
        Button3.Text = "Generar cheque"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 92)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(186, 152)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.RoyalBlue
        Button4.Cursor = Cursors.Hand
        Button4.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Location = New Point(557, 311)
        Button4.Name = "Button4"
        Button4.Size = New Size(162, 38)
        Button4.TabIndex = 4
        Button4.Text = "VER HISTORICO"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(784, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PROYECTO FINAL"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

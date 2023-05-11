<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Codigo = New DataGridViewTextBoxColumn()
        Nombres = New DataGridViewTextBoxColumn()
        Apellidos = New DataGridViewTextBoxColumn()
        Sueldo = New DataGridViewTextBoxColumn()
        IGSS = New DataGridViewTextBoxColumn()
        Descuentos = New DataGridViewTextBoxColumn()
        Liquido = New DataGridViewTextBoxColumn()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(315, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 0
        Label1.Text = "Planilla de trabajadores"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Codigo, Nombres, Apellidos, Sueldo, IGSS, Descuentos, Liquido})
        DataGridView1.Location = New Point(26, 37)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(745, 373)
        DataGridView1.TabIndex = 2
        ' 
        ' Codigo
        ' 
        Codigo.HeaderText = "Codigo"
        Codigo.Name = "Codigo"
        Codigo.ReadOnly = True
        ' 
        ' Nombres
        ' 
        Nombres.HeaderText = "Nombres"
        Nombres.Name = "Nombres"
        Nombres.ReadOnly = True
        ' 
        ' Apellidos
        ' 
        Apellidos.HeaderText = "Apellidos"
        Apellidos.Name = "Apellidos"
        Apellidos.ReadOnly = True
        ' 
        ' Sueldo
        ' 
        Sueldo.HeaderText = "Sueldo"
        Sueldo.Name = "Sueldo"
        Sueldo.ReadOnly = True
        ' 
        ' IGSS
        ' 
        IGSS.HeaderText = "IGSS"
        IGSS.Name = "IGSS"
        IGSS.ReadOnly = True
        ' 
        ' Descuentos
        ' 
        Descuentos.HeaderText = "Descuentos"
        Descuentos.Name = "Descuentos"
        Descuentos.ReadOnly = True
        ' 
        ' Liquido
        ' 
        Liquido.HeaderText = "Liquido"
        Liquido.Name = "Liquido"
        Liquido.ReadOnly = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(659, 416)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 23)
        Button3.TabIndex = 10
        Button3.Text = "Regresar al menu"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
    Friend WithEvents IGSS As DataGridViewTextBoxColumn
    Friend WithEvents Descuentos As DataGridViewTextBoxColumn
    Friend WithEvents Liquido As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Button1 = New Button()
        MainPanel = New Panel()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(420, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(54, 15)
        Label1.TabIndex = 0
        Label1.Text = " Historial"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(795, 415)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 23)
        Button1.TabIndex = 1
        Button1.Text = "Regresar al menu"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MainPanel
        ' 
        MainPanel.AutoScroll = True
        MainPanel.Location = New Point(12, 29)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(923, 380)
        MainPanel.TabIndex = 2
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(947, 450)
        Controls.Add(MainPanel)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MainPanel As Panel
End Class

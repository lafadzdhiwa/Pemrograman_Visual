﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.hitung = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtjari = New System.Windows.Forms.TextBox()
        Me.txttinggi = New System.Windows.Forms.TextBox()
        Me.txtvolume = New System.Windows.Forms.TextBox()
        Me.txtluas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(114, 142)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(81, 30)
        Me.hitung.TabIndex = 0
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Jari-Jari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tinggi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Volume"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(185, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Luas Permukaan"
        '
        'txtjari
        '
        Me.txtjari.Location = New System.Drawing.Point(26, 80)
        Me.txtjari.Name = "txtjari"
        Me.txtjari.Size = New System.Drawing.Size(100, 22)
        Me.txtjari.TabIndex = 5
        '
        'txttinggi
        '
        Me.txttinggi.Location = New System.Drawing.Point(192, 80)
        Me.txttinggi.Name = "txttinggi"
        Me.txttinggi.Size = New System.Drawing.Size(100, 22)
        Me.txttinggi.TabIndex = 6
        '
        'txtvolume
        '
        Me.txtvolume.Location = New System.Drawing.Point(26, 226)
        Me.txtvolume.Name = "txtvolume"
        Me.txtvolume.Size = New System.Drawing.Size(100, 22)
        Me.txtvolume.TabIndex = 7
        '
        'txtluas
        '
        Me.txtluas.Location = New System.Drawing.Point(192, 226)
        Me.txtluas.Name = "txtluas"
        Me.txtluas.Size = New System.Drawing.Size(100, 22)
        Me.txtluas.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 290)
        Me.Controls.Add(Me.txtluas)
        Me.Controls.Add(Me.txtvolume)
        Me.Controls.Add(Me.txttinggi)
        Me.Controls.Add(Me.txtjari)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hitung)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hitung As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtjari As TextBox
    Friend WithEvents txttinggi As TextBox
    Friend WithEvents txtvolume As TextBox
    Friend WithEvents txtluas As TextBox
End Class

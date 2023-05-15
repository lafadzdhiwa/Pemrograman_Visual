<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtpanjang = New System.Windows.Forms.TextBox()
        Me.txtlebar = New System.Windows.Forms.TextBox()
        Me.txtluas = New System.Windows.Forms.TextBox()
        Me.txtkeliling = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(98, 116)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(83, 31)
        Me.hitung.TabIndex = 0
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Panjang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lebar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Luas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(193, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Keliling"
        '
        'txtpanjang
        '
        Me.txtpanjang.Location = New System.Drawing.Point(15, 68)
        Me.txtpanjang.Name = "txtpanjang"
        Me.txtpanjang.Size = New System.Drawing.Size(100, 22)
        Me.txtpanjang.TabIndex = 5
        '
        'txtlebar
        '
        Me.txtlebar.Location = New System.Drawing.Point(169, 68)
        Me.txtlebar.Name = "txtlebar"
        Me.txtlebar.Size = New System.Drawing.Size(100, 22)
        Me.txtlebar.TabIndex = 7
        '
        'txtluas
        '
        Me.txtluas.Location = New System.Drawing.Point(15, 187)
        Me.txtluas.Name = "txtluas"
        Me.txtluas.Size = New System.Drawing.Size(100, 22)
        Me.txtluas.TabIndex = 8
        '
        'txtkeliling
        '
        Me.txtkeliling.Location = New System.Drawing.Point(169, 187)
        Me.txtkeliling.Name = "txtkeliling"
        Me.txtkeliling.Size = New System.Drawing.Size(100, 22)
        Me.txtkeliling.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.txtkeliling)
        Me.Controls.Add(Me.txtluas)
        Me.Controls.Add(Me.txtlebar)
        Me.Controls.Add(Me.txtpanjang)
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
    Friend WithEvents txtpanjang As TextBox
    Friend WithEvents txtlebar As TextBox
    Friend WithEvents txtluas As TextBox
    Friend WithEvents txtkeliling As TextBox
End Class

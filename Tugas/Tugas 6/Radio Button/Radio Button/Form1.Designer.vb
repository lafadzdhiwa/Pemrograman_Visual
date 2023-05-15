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
        Me.txtharga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbanak = New System.Windows.Forms.RadioButton()
        Me.rblansia = New System.Windows.Forms.RadioButton()
        Me.rbdewasa = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(161, 130)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(85, 26)
        Me.hitung.TabIndex = 0
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'txtharga
        '
        Me.txtharga.Location = New System.Drawing.Point(30, 134)
        Me.txtharga.Name = "txtharga"
        Me.txtharga.Size = New System.Drawing.Size(100, 22)
        Me.txtharga.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lafadz Dhiwa Singgih (200511045)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Harga Ticket"
        '
        'rbanak
        '
        Me.rbanak.AutoSize = True
        Me.rbanak.Location = New System.Drawing.Point(161, 49)
        Me.rbanak.Name = "rbanak"
        Me.rbanak.Size = New System.Drawing.Size(96, 21)
        Me.rbanak.TabIndex = 7
        Me.rbanak.TabStop = True
        Me.rbanak.Text = "Anak anak"
        Me.rbanak.UseVisualStyleBackColor = True
        '
        'rblansia
        '
        Me.rblansia.AutoSize = True
        Me.rblansia.Location = New System.Drawing.Point(161, 103)
        Me.rblansia.Name = "rblansia"
        Me.rblansia.Size = New System.Drawing.Size(71, 21)
        Me.rblansia.TabIndex = 8
        Me.rblansia.TabStop = True
        Me.rblansia.Text = "Lansia"
        Me.rblansia.UseVisualStyleBackColor = True
        '
        'rbdewasa
        '
        Me.rbdewasa.AutoSize = True
        Me.rbdewasa.Location = New System.Drawing.Point(161, 76)
        Me.rbdewasa.Name = "rbdewasa"
        Me.rbdewasa.Size = New System.Drawing.Size(79, 21)
        Me.rbdewasa.TabIndex = 9
        Me.rbdewasa.TabStop = True
        Me.rbdewasa.Text = "Dewasa"
        Me.rbdewasa.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 189)
        Me.Controls.Add(Me.rbdewasa)
        Me.Controls.Add(Me.rblansia)
        Me.Controls.Add(Me.rbanak)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtharga)
        Me.Controls.Add(Me.hitung)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents hitung As Button
    Friend WithEvents txtharga As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbanak As RadioButton
    Friend WithEvents rblansia As RadioButton
    Friend WithEvents rbdewasa As RadioButton
End Class

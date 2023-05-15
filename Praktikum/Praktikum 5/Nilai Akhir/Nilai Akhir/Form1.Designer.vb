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
        Me.submit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnilai = New System.Windows.Forms.TextBox()
        Me.xtketerangan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(395, 115)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(80, 39)
        Me.submit.TabIndex = 0
        Me.submit.Text = "SUBMIT"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nilai Akhir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Keterangan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(134, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(230, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lafadz Dhiwa Singgih (200511045)"
        '
        'txtnilai
        '
        Me.txtnilai.Location = New System.Drawing.Point(137, 85)
        Me.txtnilai.Name = "txtnilai"
        Me.txtnilai.Size = New System.Drawing.Size(227, 22)
        Me.txtnilai.TabIndex = 4
        '
        'xtketerangan
        '
        Me.xtketerangan.Location = New System.Drawing.Point(137, 161)
        Me.xtketerangan.Name = "xtketerangan"
        Me.xtketerangan.Size = New System.Drawing.Size(227, 22)
        Me.xtketerangan.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 253)
        Me.Controls.Add(Me.xtketerangan)
        Me.Controls.Add(Me.txtnilai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.submit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents submit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnilai As TextBox
    Friend WithEvents xtketerangan As TextBox
End Class

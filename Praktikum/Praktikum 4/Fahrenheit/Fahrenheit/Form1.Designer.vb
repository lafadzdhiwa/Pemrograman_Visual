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
        Me.convert = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfahrenheit = New System.Windows.Forms.TextBox()
        Me.txtcelcius = New System.Windows.Forms.TextBox()
        Me.txtreamur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtkelvin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'convert
        '
        Me.convert.Location = New System.Drawing.Point(124, 105)
        Me.convert.Name = "convert"
        Me.convert.Size = New System.Drawing.Size(80, 30)
        Me.convert.TabIndex = 0
        Me.convert.Text = "Convert"
        Me.convert.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 1
        '
        'txtfahrenheit
        '
        Me.txtfahrenheit.Location = New System.Drawing.Point(124, 51)
        Me.txtfahrenheit.Name = "txtfahrenheit"
        Me.txtfahrenheit.Size = New System.Drawing.Size(100, 22)
        Me.txtfahrenheit.TabIndex = 3
        '
        'txtcelcius
        '
        Me.txtcelcius.Location = New System.Drawing.Point(124, 160)
        Me.txtcelcius.Name = "txtcelcius"
        Me.txtcelcius.Size = New System.Drawing.Size(100, 22)
        Me.txtcelcius.TabIndex = 5
        '
        'txtreamur
        '
        Me.txtreamur.Location = New System.Drawing.Point(124, 205)
        Me.txtreamur.Name = "txtreamur"
        Me.txtreamur.Size = New System.Drawing.Size(100, 22)
        Me.txtreamur.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Celcius"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Reamur"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fahrenheit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Kelvin"
        '
        'txtkelvin
        '
        Me.txtkelvin.Location = New System.Drawing.Point(124, 247)
        Me.txtkelvin.Name = "txtkelvin"
        Me.txtkelvin.Size = New System.Drawing.Size(100, 22)
        Me.txtkelvin.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 288)
        Me.Controls.Add(Me.txtkelvin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtreamur)
        Me.Controls.Add(Me.txtcelcius)
        Me.Controls.Add(Me.txtfahrenheit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.convert)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents convert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfahrenheit As TextBox
    Friend WithEvents txtcelcius As TextBox
    Friend WithEvents txtreamur As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtkelvin As TextBox
End Class

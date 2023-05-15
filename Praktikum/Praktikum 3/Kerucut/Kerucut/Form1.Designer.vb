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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.hitung = New System.Windows.Forms.Button()
        Me.txtjari = New System.Windows.Forms.TextBox()
        Me.txtgaris = New System.Windows.Forms.TextBox()
        Me.txttinggi = New System.Windows.Forms.TextBox()
        Me.txtvolume = New System.Windows.Forms.TextBox()
        Me.txtluas = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jari-Jari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Garis Pelukis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Volume"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Luas Permukaan"
        '
        'hitung
        '
        Me.hitung.Location = New System.Drawing.Point(148, 174)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(86, 39)
        Me.hitung.TabIndex = 5
        Me.hitung.Text = "Hitung"
        Me.hitung.UseVisualStyleBackColor = True
        '
        'txtjari
        '
        Me.txtjari.Location = New System.Drawing.Point(148, 38)
        Me.txtjari.Name = "txtjari"
        Me.txtjari.Size = New System.Drawing.Size(100, 22)
        Me.txtjari.TabIndex = 6
        '
        'txtgaris
        '
        Me.txtgaris.Location = New System.Drawing.Point(148, 79)
        Me.txtgaris.Name = "txtgaris"
        Me.txtgaris.Size = New System.Drawing.Size(100, 22)
        Me.txtgaris.TabIndex = 7
        '
        'txttinggi
        '
        Me.txttinggi.Location = New System.Drawing.Point(148, 120)
        Me.txttinggi.Name = "txttinggi"
        Me.txttinggi.Size = New System.Drawing.Size(100, 22)
        Me.txttinggi.TabIndex = 8
        '
        'txtvolume
        '
        Me.txtvolume.Location = New System.Drawing.Point(48, 253)
        Me.txtvolume.Name = "txtvolume"
        Me.txtvolume.Size = New System.Drawing.Size(100, 22)
        Me.txtvolume.TabIndex = 9
        '
        'txtluas
        '
        Me.txtluas.Location = New System.Drawing.Point(234, 253)
        Me.txtluas.Name = "txtluas"
        Me.txtluas.Size = New System.Drawing.Size(100, 22)
        Me.txtluas.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 344)
        Me.Controls.Add(Me.txtluas)
        Me.Controls.Add(Me.txtvolume)
        Me.Controls.Add(Me.txttinggi)
        Me.Controls.Add(Me.txtgaris)
        Me.Controls.Add(Me.txtjari)
        Me.Controls.Add(Me.hitung)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents hitung As Button
    Friend WithEvents txtjari As TextBox
    Friend WithEvents txtgaris As TextBox
    Friend WithEvents txttinggi As TextBox
    Friend WithEvents txtvolume As TextBox
    Friend WithEvents txtluas As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnBacaFile = New System.Windows.Forms.Button()
        Me.btnCariKata = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 87)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Name"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(132, 87)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Text"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnBacaFile
        '
        Me.btnBacaFile.Location = New System.Drawing.Point(218, 212)
        Me.btnBacaFile.Name = "btnBacaFile"
        Me.btnBacaFile.Size = New System.Drawing.Size(148, 55)
        Me.btnBacaFile.TabIndex = 2
        Me.btnBacaFile.Text = "Baca File"
        Me.btnBacaFile.UseVisualStyleBackColor = True
        '
        'btnCariKata
        '
        Me.btnCariKata.Location = New System.Drawing.Point(477, 212)
        Me.btnCariKata.Name = "btnCariKata"
        Me.btnCariKata.Size = New System.Drawing.Size(132, 55)
        Me.btnCariKata.TabIndex = 3
        Me.btnCariKata.Text = "Cari Kata"
        Me.btnCariKata.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(218, 301)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 26)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(477, 301)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 26)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "Properties"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(218, 365)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(148, 26)
        Me.txtOutput.TabIndex = 6
        Me.txtOutput.Text = "Output"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(477, 365)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(132, 26)
        Me.txtCari.TabIndex = 7
        Me.txtCari.Text = "Masukkan Kata"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 534)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnCariKata)
        Me.Controls.Add(Me.btnBacaFile)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnBacaFile As Button
    Friend WithEvents btnCariKata As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtCari As TextBox
End Class

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
        Me.tangka1 = New System.Windows.Forms.TextBox()
        Me.tangka2 = New System.Windows.Forms.TextBox()
        Me.thasil = New System.Windows.Forms.TextBox()
        Me.btambah = New System.Windows.Forms.Button()
        Me.bkurang = New System.Windows.Forms.Button()
        Me.bkali = New System.Windows.Forms.Button()
        Me.bbagi = New System.Windows.Forms.Button()
        Me.bkosongkan = New System.Windows.Forms.Button()
        Me.bkeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasil"
        '
        'tangka1
        '
        Me.tangka1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tangka1.Location = New System.Drawing.Point(16, 46)
        Me.tangka1.Margin = New System.Windows.Forms.Padding(4)
        Me.tangka1.Name = "tangka1"
        Me.tangka1.Size = New System.Drawing.Size(400, 29)
        Me.tangka1.TabIndex = 3
        '
        'tangka2
        '
        Me.tangka2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tangka2.Location = New System.Drawing.Point(16, 156)
        Me.tangka2.Margin = New System.Windows.Forms.Padding(4)
        Me.tangka2.Name = "tangka2"
        Me.tangka2.Size = New System.Drawing.Size(400, 29)
        Me.tangka2.TabIndex = 6
        '
        'thasil
        '
        Me.thasil.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thasil.Location = New System.Drawing.Point(16, 266)
        Me.thasil.Margin = New System.Windows.Forms.Padding(4)
        Me.thasil.Multiline = True
        Me.thasil.Name = "thasil"
        Me.thasil.Size = New System.Drawing.Size(400, 78)
        Me.thasil.TabIndex = 7
        '
        'btambah
        '
        Me.btambah.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btambah.Location = New System.Drawing.Point(16, 352)
        Me.btambah.Margin = New System.Windows.Forms.Padding(4)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(98, 43)
        Me.btambah.TabIndex = 8
        Me.btambah.Text = "+"
        Me.btambah.UseVisualStyleBackColor = True
        '
        'bkurang
        '
        Me.bkurang.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkurang.Location = New System.Drawing.Point(117, 352)
        Me.bkurang.Margin = New System.Windows.Forms.Padding(4)
        Me.bkurang.Name = "bkurang"
        Me.bkurang.Size = New System.Drawing.Size(98, 43)
        Me.bkurang.TabIndex = 10
        Me.bkurang.Text = "-"
        Me.bkurang.UseVisualStyleBackColor = True
        '
        'bkali
        '
        Me.bkali.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkali.Location = New System.Drawing.Point(217, 352)
        Me.bkali.Margin = New System.Windows.Forms.Padding(4)
        Me.bkali.Name = "bkali"
        Me.bkali.Size = New System.Drawing.Size(98, 43)
        Me.bkali.TabIndex = 11
        Me.bkali.Text = "x"
        Me.bkali.UseVisualStyleBackColor = True
        '
        'bbagi
        '
        Me.bbagi.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbagi.Location = New System.Drawing.Point(318, 352)
        Me.bbagi.Margin = New System.Windows.Forms.Padding(4)
        Me.bbagi.Name = "bbagi"
        Me.bbagi.Size = New System.Drawing.Size(98, 43)
        Me.bbagi.TabIndex = 12
        Me.bbagi.Text = "/"
        Me.bbagi.UseVisualStyleBackColor = True
        '
        'bkosongkan
        '
        Me.bkosongkan.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkosongkan.Location = New System.Drawing.Point(16, 402)
        Me.bkosongkan.Margin = New System.Windows.Forms.Padding(4)
        Me.bkosongkan.Name = "bkosongkan"
        Me.bkosongkan.Size = New System.Drawing.Size(400, 43)
        Me.bkosongkan.TabIndex = 13
        Me.bkosongkan.Text = "Kosongkan"
        Me.bkosongkan.UseVisualStyleBackColor = True
        '
        'bkeluar
        '
        Me.bkeluar.Font = New System.Drawing.Font("Hug Me Tight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bkeluar.Location = New System.Drawing.Point(16, 453)
        Me.bkeluar.Margin = New System.Windows.Forms.Padding(4)
        Me.bkeluar.Name = "bkeluar"
        Me.bkeluar.Size = New System.Drawing.Size(400, 43)
        Me.bkeluar.TabIndex = 14
        Me.bkeluar.Text = "Keluar"
        Me.bkeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 506)
        Me.Controls.Add(Me.bkeluar)
        Me.Controls.Add(Me.bkosongkan)
        Me.Controls.Add(Me.bbagi)
        Me.Controls.Add(Me.bkali)
        Me.Controls.Add(Me.bkurang)
        Me.Controls.Add(Me.btambah)
        Me.Controls.Add(Me.thasil)
        Me.Controls.Add(Me.tangka2)
        Me.Controls.Add(Me.tangka1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents tangka1 As TextBox
    Private WithEvents tangka2 As TextBox
    Private WithEvents thasil As TextBox
    Private WithEvents btambah As Button
    Private WithEvents bkurang As Button
    Private WithEvents bkali As Button
    Private WithEvents bbagi As Button
    Private WithEvents bkosongkan As Button
    Private WithEvents bkeluar As Button
End Class

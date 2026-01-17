<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahBarang
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxStock = New System.Windows.Forms.TextBox()
        Me.TextBoxBarang = New System.Windows.Forms.TextBox()
        Me.ComboBoxIdJenisBarang = New System.Windows.Forms.ComboBox()
        Me.ButtonTambahBarang = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(1, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jenis Barang"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock"
        '
        'TextBoxStock
        '
        Me.TextBoxStock.Location = New System.Drawing.Point(133, 110)
        Me.TextBoxStock.Name = "TextBoxStock"
        Me.TextBoxStock.Size = New System.Drawing.Size(157, 27)
        Me.TextBoxStock.TabIndex = 5
        '
        'TextBoxBarang
        '
        Me.TextBoxBarang.Location = New System.Drawing.Point(133, 77)
        Me.TextBoxBarang.Name = "TextBoxBarang"
        Me.TextBoxBarang.Size = New System.Drawing.Size(157, 27)
        Me.TextBoxBarang.TabIndex = 6
        '
        'ComboBoxIdJenisBarang
        '
        Me.ComboBoxIdJenisBarang.FormattingEnabled = True
        Me.ComboBoxIdJenisBarang.Location = New System.Drawing.Point(133, 43)
        Me.ComboBoxIdJenisBarang.Name = "ComboBoxIdJenisBarang"
        Me.ComboBoxIdJenisBarang.Size = New System.Drawing.Size(157, 28)
        Me.ComboBoxIdJenisBarang.TabIndex = 8
        '
        'ButtonTambahBarang
        '
        Me.ButtonTambahBarang.Location = New System.Drawing.Point(133, 155)
        Me.ButtonTambahBarang.Name = "ButtonTambahBarang"
        Me.ButtonTambahBarang.Size = New System.Drawing.Size(157, 32)
        Me.ButtonTambahBarang.TabIndex = 9
        Me.ButtonTambahBarang.Text = "Tambah Barang"
        Me.ButtonTambahBarang.UseVisualStyleBackColor = True
        '
        'FormTambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 204)
        Me.Controls.Add(Me.ButtonTambahBarang)
        Me.Controls.Add(Me.ComboBoxIdJenisBarang)
        Me.Controls.Add(Me.TextBoxBarang)
        Me.Controls.Add(Me.TextBoxStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTambahBarang"
        Me.Text = "FormTambahBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxStock As TextBox
    Friend WithEvents TextBoxBarang As TextBox
    Friend WithEvents ComboBoxIdJenisBarang As ComboBox
    Friend WithEvents ButtonTambahBarang As Button
End Class

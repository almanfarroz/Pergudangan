<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahJenisBarang
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
        Me.TextBoxJenisBarang = New System.Windows.Forms.TextBox()
        Me.LabelJenisBarang = New System.Windows.Forms.Label()
        Me.LabelSatuan = New System.Windows.Forms.Label()
        Me.ComboBoxSatuan = New System.Windows.Forms.ComboBox()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxJenisBarang
        '
        Me.TextBoxJenisBarang.Location = New System.Drawing.Point(269, 140)
        Me.TextBoxJenisBarang.Name = "TextBoxJenisBarang"
        Me.TextBoxJenisBarang.Size = New System.Drawing.Size(211, 31)
        Me.TextBoxJenisBarang.TabIndex = 0
        '
        'LabelJenisBarang
        '
        Me.LabelJenisBarang.AutoSize = True
        Me.LabelJenisBarang.Location = New System.Drawing.Point(141, 140)
        Me.LabelJenisBarang.Name = "LabelJenisBarang"
        Me.LabelJenisBarang.Size = New System.Drawing.Size(109, 25)
        Me.LabelJenisBarang.TabIndex = 2
        Me.LabelJenisBarang.Text = "Jenis Barang"
        '
        'LabelSatuan
        '
        Me.LabelSatuan.AutoSize = True
        Me.LabelSatuan.Location = New System.Drawing.Point(141, 189)
        Me.LabelSatuan.Name = "LabelSatuan"
        Me.LabelSatuan.Size = New System.Drawing.Size(66, 25)
        Me.LabelSatuan.TabIndex = 3
        Me.LabelSatuan.Text = "Satuan"
        '
        'ComboBoxSatuan
        '
        Me.ComboBoxSatuan.FormattingEnabled = True
        Me.ComboBoxSatuan.Location = New System.Drawing.Point(269, 189)
        Me.ComboBoxSatuan.Name = "ComboBoxSatuan"
        Me.ComboBoxSatuan.Size = New System.Drawing.Size(211, 33)
        Me.ComboBoxSatuan.TabIndex = 4
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(269, 247)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(211, 36)
        Me.ButtonTambah.TabIndex = 5
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'FormTambahJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ComboBoxSatuan)
        Me.Controls.Add(Me.LabelSatuan)
        Me.Controls.Add(Me.LabelJenisBarang)
        Me.Controls.Add(Me.TextBoxJenisBarang)
        Me.Name = "FormTambahJenisBarang"
        Me.Text = "FormTambahJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxJenisBarang As TextBox
    Friend WithEvents LabelJenisBarang As Label
    Friend WithEvents LabelSatuan As Label
    Friend WithEvents ComboBoxSatuan As ComboBox
    Friend WithEvents ButtonTambah As Button
End Class

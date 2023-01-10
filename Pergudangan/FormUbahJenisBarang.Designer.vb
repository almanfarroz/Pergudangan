<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUbahJenisBarang
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
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ComboBoxSatuan = New System.Windows.Forms.ComboBox()
        Me.LabelSatuan = New System.Windows.Forms.Label()
        Me.LabelJenisBarang = New System.Windows.Forms.Label()
        Me.TextBoxJenisBarang = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(359, 261)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(211, 36)
        Me.ButtonUbah.TabIndex = 10
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ComboBoxSatuan
        '
        Me.ComboBoxSatuan.FormattingEnabled = True
        Me.ComboBoxSatuan.Location = New System.Drawing.Point(359, 203)
        Me.ComboBoxSatuan.Name = "ComboBoxSatuan"
        Me.ComboBoxSatuan.Size = New System.Drawing.Size(211, 33)
        Me.ComboBoxSatuan.TabIndex = 9
        '
        'LabelSatuan
        '
        Me.LabelSatuan.AutoSize = True
        Me.LabelSatuan.Location = New System.Drawing.Point(231, 203)
        Me.LabelSatuan.Name = "LabelSatuan"
        Me.LabelSatuan.Size = New System.Drawing.Size(66, 25)
        Me.LabelSatuan.TabIndex = 8
        Me.LabelSatuan.Text = "Satuan"
        '
        'LabelJenisBarang
        '
        Me.LabelJenisBarang.AutoSize = True
        Me.LabelJenisBarang.Location = New System.Drawing.Point(231, 154)
        Me.LabelJenisBarang.Name = "LabelJenisBarang"
        Me.LabelJenisBarang.Size = New System.Drawing.Size(109, 25)
        Me.LabelJenisBarang.TabIndex = 7
        Me.LabelJenisBarang.Text = "Jenis Barang"
        '
        'TextBoxJenisBarang
        '
        Me.TextBoxJenisBarang.Location = New System.Drawing.Point(359, 154)
        Me.TextBoxJenisBarang.Name = "TextBoxJenisBarang"
        Me.TextBoxJenisBarang.Size = New System.Drawing.Size(211, 31)
        Me.TextBoxJenisBarang.TabIndex = 6
        '
        'FormUbahJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.ComboBoxSatuan)
        Me.Controls.Add(Me.LabelSatuan)
        Me.Controls.Add(Me.LabelJenisBarang)
        Me.Controls.Add(Me.TextBoxJenisBarang)
        Me.Name = "FormUbahJenisBarang"
        Me.Text = "FormUbahJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonUbah As Button
    Friend WithEvents ComboBoxSatuan As ComboBox
    Friend WithEvents LabelSatuan As Label
    Friend WithEvents LabelJenisBarang As Label
    Friend WithEvents TextBoxJenisBarang As TextBox
End Class

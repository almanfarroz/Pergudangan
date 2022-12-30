<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJenisBarang
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
        Me.DataGridViewJenisBarang = New System.Windows.Forms.DataGridView()
        Me.ButtonUbah = New System.Windows.Forms.Button()
        Me.ButtonTambah = New System.Windows.Forms.Button()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        CType(Me.DataGridViewJenisBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewJenisBarang
        '
        Me.DataGridViewJenisBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewJenisBarang.Location = New System.Drawing.Point(138, 160)
        Me.DataGridViewJenisBarang.Name = "DataGridViewJenisBarang"
        Me.DataGridViewJenisBarang.RowHeadersWidth = 62
        Me.DataGridViewJenisBarang.RowTemplate.Height = 33
        Me.DataGridViewJenisBarang.Size = New System.Drawing.Size(673, 225)
        Me.DataGridViewJenisBarang.TabIndex = 0
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(653, 569)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(112, 34)
        Me.ButtonUbah.TabIndex = 1
        Me.ButtonUbah.Text = "Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(535, 569)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(112, 34)
        Me.ButtonTambah.TabIndex = 2
        Me.ButtonTambah.Text = "Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(771, 569)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(112, 34)
        Me.ButtonHapus.TabIndex = 3
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'FormJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 730)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.ButtonTambah)
        Me.Controls.Add(Me.ButtonUbah)
        Me.Controls.Add(Me.DataGridViewJenisBarang)
        Me.Name = "FormJenisBarang"
        Me.Text = "FormJenisBarang"
        CType(Me.DataGridViewJenisBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewJenisBarang As DataGridView
    Friend WithEvents ButtonUbah As Button
    Friend WithEvents ButtonTambah As Button
    Friend WithEvents ButtonHapus As Button
End Class

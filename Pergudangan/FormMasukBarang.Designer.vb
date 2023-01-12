<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMasukBarang
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
        Me.DataGridViewBarangMasuk = New System.Windows.Forms.DataGridView()
        Me.ButtonTambahBarang = New System.Windows.Forms.Button()
        Me.ButtonHapusBarang = New System.Windows.Forms.Button()
        CType(Me.DataGridViewBarangMasuk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBarangMasuk
        '
        Me.DataGridViewBarangMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarangMasuk.Location = New System.Drawing.Point(44, 30)
        Me.DataGridViewBarangMasuk.Name = "DataGridViewBarangMasuk"
        Me.DataGridViewBarangMasuk.RowHeadersWidth = 51
        Me.DataGridViewBarangMasuk.RowTemplate.Height = 29
        Me.DataGridViewBarangMasuk.Size = New System.Drawing.Size(905, 304)
        Me.DataGridViewBarangMasuk.TabIndex = 0
        '
        'ButtonTambahBarang
        '
        Me.ButtonTambahBarang.Location = New System.Drawing.Point(283, 369)
        Me.ButtonTambahBarang.Name = "ButtonTambahBarang"
        Me.ButtonTambahBarang.Size = New System.Drawing.Size(171, 39)
        Me.ButtonTambahBarang.TabIndex = 1
        Me.ButtonTambahBarang.Text = "Tambah Barang"
        Me.ButtonTambahBarang.UseVisualStyleBackColor = True
        '
        'ButtonHapusBarang
        '
        Me.ButtonHapusBarang.Location = New System.Drawing.Point(513, 369)
        Me.ButtonHapusBarang.Name = "ButtonHapusBarang"
        Me.ButtonHapusBarang.Size = New System.Drawing.Size(171, 39)
        Me.ButtonHapusBarang.TabIndex = 2
        Me.ButtonHapusBarang.Text = "Hapus Barang"
        Me.ButtonHapusBarang.UseVisualStyleBackColor = True
        '
        'FormMasukBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 462)
        Me.Controls.Add(Me.ButtonHapusBarang)
        Me.Controls.Add(Me.ButtonTambahBarang)
        Me.Controls.Add(Me.DataGridViewBarangMasuk)
        Me.Name = "FormMasukBarang"
        Me.Text = "FormMasukBarang"
        CType(Me.DataGridViewBarangMasuk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewBarangMasuk As DataGridView
    Friend WithEvents ButtonTambahBarang As Button
    Friend WithEvents ButtonHapusBarang As Button
End Class

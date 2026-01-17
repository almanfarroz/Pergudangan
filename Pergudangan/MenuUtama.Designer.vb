<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuUtama
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
        Me.ButtonJenisBarang = New System.Windows.Forms.Button()
        Me.ButtonBarang = New System.Windows.Forms.Button()
        Me.ButtonOrderBarang = New System.Windows.Forms.Button()
        Me.ButtonBarangMasuk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonJenisBarang
        '
        Me.ButtonJenisBarang.Location = New System.Drawing.Point(251, 94)
        Me.ButtonJenisBarang.Name = "ButtonJenisBarang"
        Me.ButtonJenisBarang.Size = New System.Drawing.Size(324, 112)
        Me.ButtonJenisBarang.TabIndex = 0
        Me.ButtonJenisBarang.Text = "FORM JENIS BARANG"
        Me.ButtonJenisBarang.UseVisualStyleBackColor = True
        '
        'ButtonBarang
        '
        Me.ButtonBarang.Location = New System.Drawing.Point(251, 212)
        Me.ButtonBarang.Name = "ButtonBarang"
        Me.ButtonBarang.Size = New System.Drawing.Size(325, 112)
        Me.ButtonBarang.TabIndex = 1
        Me.ButtonBarang.Text = "FORM BARANG"
        Me.ButtonBarang.UseVisualStyleBackColor = True
        '
        'ButtonOrderBarang
        '
        Me.ButtonOrderBarang.Location = New System.Drawing.Point(251, 330)
        Me.ButtonOrderBarang.Name = "ButtonOrderBarang"
        Me.ButtonOrderBarang.Size = New System.Drawing.Size(325, 112)
        Me.ButtonOrderBarang.TabIndex = 2
        Me.ButtonOrderBarang.Text = "FORM ORDER BARANG"
        Me.ButtonOrderBarang.UseVisualStyleBackColor = True
        '
        'ButtonBarangMasuk
        '
        Me.ButtonBarangMasuk.Location = New System.Drawing.Point(250, 448)
        Me.ButtonBarangMasuk.Name = "ButtonBarangMasuk"
        Me.ButtonBarangMasuk.Size = New System.Drawing.Size(325, 112)
        Me.ButtonBarangMasuk.TabIndex = 3
        Me.ButtonBarangMasuk.Text = "FORM BARANG MASUK"
        Me.ButtonBarangMasuk.UseVisualStyleBackColor = True
        '
        'MenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 608)
        Me.Controls.Add(Me.ButtonBarangMasuk)
        Me.Controls.Add(Me.ButtonOrderBarang)
        Me.Controls.Add(Me.ButtonBarang)
        Me.Controls.Add(Me.ButtonJenisBarang)
        Me.Name = "MenuUtama"
        Me.Text = "MenuUtama"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonJenisBarang As Button
    Friend WithEvents ButtonBarang As Button
    Friend WithEvents ButtonOrderBarang As Button
    Friend WithEvents ButtonBarangMasuk As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusJenisBarang
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
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNama = New System.Windows.Forms.Label()
        Me.ButtonTutup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(226, 333)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(112, 34)
        Me.ButtonHapus.TabIndex = 0
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(21, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(777, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Apakah Ingin Menghapus Jenis Barang"
        '
        'LabelNama
        '
        Me.LabelNama.AutoSize = True
        Me.LabelNama.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelNama.Location = New System.Drawing.Point(248, 198)
        Me.LabelNama.Name = "LabelNama"
        Me.LabelNama.Size = New System.Drawing.Size(247, 96)
        Me.LabelNama.TabIndex = 2
        Me.LabelNama.Text = "Label2"
        '
        'ButtonTutup
        '
        Me.ButtonTutup.Location = New System.Drawing.Point(403, 333)
        Me.ButtonTutup.Name = "ButtonTutup"
        Me.ButtonTutup.Size = New System.Drawing.Size(112, 34)
        Me.ButtonTutup.TabIndex = 3
        Me.ButtonTutup.Text = "Tutup"
        Me.ButtonTutup.UseVisualStyleBackColor = True
        '
        'FormHapusJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonTutup)
        Me.Controls.Add(Me.LabelNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Name = "FormHapusJenisBarang"
        Me.Text = "FormHapusJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonHapus As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents ButtonTutup As Button
End Class

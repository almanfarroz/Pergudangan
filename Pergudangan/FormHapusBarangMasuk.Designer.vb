<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusBarangMasuk
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
        Me.LabelHapus = New System.Windows.Forms.Label()
        Me.ButtonHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(95, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Anda Ingin Menghapus"
        '
        'LabelHapus
        '
        Me.LabelHapus.AutoSize = True
        Me.LabelHapus.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelHapus.Location = New System.Drawing.Point(274, 156)
        Me.LabelHapus.Name = "LabelHapus"
        Me.LabelHapus.Size = New System.Drawing.Size(104, 41)
        Me.LabelHapus.TabIndex = 1
        Me.LabelHapus.Text = "Label2"
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(245, 232)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(157, 35)
        Me.ButtonHapus.TabIndex = 2
        Me.ButtonHapus.Text = "Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'FormHapusBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 325)
        Me.Controls.Add(Me.ButtonHapus)
        Me.Controls.Add(Me.LabelHapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHapusBarangMasuk"
        Me.Text = "FormHapusBarangMasuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelHapus As Label
    Friend WithEvents ButtonHapus As Button
End Class

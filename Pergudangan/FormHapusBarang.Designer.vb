<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHapusBarang
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
        Me.ButtonFormHapus = New System.Windows.Forms.Button()
        Me.LabelHapus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah Anda Yakin Ingin Menghapus:"
        '
        'ButtonFormHapus
        '
        Me.ButtonFormHapus.Location = New System.Drawing.Point(168, 124)
        Me.ButtonFormHapus.Name = "ButtonFormHapus"
        Me.ButtonFormHapus.Size = New System.Drawing.Size(99, 33)
        Me.ButtonFormHapus.TabIndex = 1
        Me.ButtonFormHapus.Text = "Hapus"
        Me.ButtonFormHapus.UseVisualStyleBackColor = True
        '
        'LabelHapus
        '
        Me.LabelHapus.AutoSize = True
        Me.LabelHapus.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelHapus.Location = New System.Drawing.Point(168, 65)
        Me.LabelHapus.Name = "LabelHapus"
        Me.LabelHapus.Size = New System.Drawing.Size(69, 28)
        Me.LabelHapus.TabIndex = 2
        Me.LabelHapus.Text = "Label2"
        Me.LabelHapus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormHapusBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 169)
        Me.Controls.Add(Me.LabelHapus)
        Me.Controls.Add(Me.ButtonFormHapus)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormHapusBarang"
        Me.Text = "FormHapusBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonFormHapus As Button
    Friend WithEvents LabelHapus As Label
End Class

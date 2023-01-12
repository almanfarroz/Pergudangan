<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDeleteOrder
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
        Me.LabelOrder = New System.Windows.Forms.Label()
        Me.ButtonHapusOrder = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(50, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(566, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah anda yakin ingin menghapus Order Tanggal"
        '
        'LabelOrder
        '
        Me.LabelOrder.AutoSize = True
        Me.LabelOrder.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LabelOrder.Location = New System.Drawing.Point(278, 135)
        Me.LabelOrder.Name = "LabelOrder"
        Me.LabelOrder.Size = New System.Drawing.Size(136, 32)
        Me.LabelOrder.TabIndex = 1
        Me.LabelOrder.Text = "2022/12/12"
        '
        'ButtonHapusOrder
        '
        Me.ButtonHapusOrder.Location = New System.Drawing.Point(227, 186)
        Me.ButtonHapusOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonHapusOrder.Name = "ButtonHapusOrder"
        Me.ButtonHapusOrder.Size = New System.Drawing.Size(82, 22)
        Me.ButtonHapusOrder.TabIndex = 2
        Me.ButtonHapusOrder.Text = "Hapus"
        Me.ButtonHapusOrder.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(381, 186)
        Me.ButtonClose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(82, 22)
        Me.ButtonClose.TabIndex = 3
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'FormDeleteOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonHapusOrder)
        Me.Controls.Add(Me.LabelOrder)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormDeleteOrder"
        Me.Text = "FormDeleteOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelOrder As Label
    Friend WithEvents ButtonHapusOrder As Button
    Friend WithEvents ButtonClose As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridViewBarang = New System.Windows.Forms.DataGridView()
        Me.ButtonTambahBarang = New System.Windows.Forms.Button()
        Me.ButtonEditBarang = New System.Windows.Forms.Button()
        Me.ButtonHapusBarang = New System.Windows.Forms.Button()
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewBarang
        '
        Me.DataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBarang.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewBarang.Name = "DataGridViewBarang"
        Me.DataGridViewBarang.RowHeadersWidth = 51
        Me.DataGridViewBarang.RowTemplate.Height = 29
        Me.DataGridViewBarang.Size = New System.Drawing.Size(553, 243)
        Me.DataGridViewBarang.TabIndex = 0
        '
        'ButtonTambahBarang
        '
        Me.ButtonTambahBarang.Location = New System.Drawing.Point(12, 271)
        Me.ButtonTambahBarang.Name = "ButtonTambahBarang"
        Me.ButtonTambahBarang.Size = New System.Drawing.Size(85, 31)
        Me.ButtonTambahBarang.TabIndex = 1
        Me.ButtonTambahBarang.Text = "Tambah"
        Me.ButtonTambahBarang.UseVisualStyleBackColor = True
        '
        'ButtonEditBarang
        '
        Me.ButtonEditBarang.Location = New System.Drawing.Point(116, 271)
        Me.ButtonEditBarang.Name = "ButtonEditBarang"
        Me.ButtonEditBarang.Size = New System.Drawing.Size(85, 31)
        Me.ButtonEditBarang.TabIndex = 2
        Me.ButtonEditBarang.Text = "Edit"
        Me.ButtonEditBarang.UseVisualStyleBackColor = True
        '
        'ButtonHapusBarang
        '
        Me.ButtonHapusBarang.Location = New System.Drawing.Point(220, 271)
        Me.ButtonHapusBarang.Name = "ButtonHapusBarang"
        Me.ButtonHapusBarang.Size = New System.Drawing.Size(85, 31)
        Me.ButtonHapusBarang.TabIndex = 3
        Me.ButtonHapusBarang.Text = "Hapus"
        Me.ButtonHapusBarang.UseVisualStyleBackColor = True
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 320)
        Me.Controls.Add(Me.ButtonHapusBarang)
        Me.Controls.Add(Me.ButtonEditBarang)
        Me.Controls.Add(Me.ButtonTambahBarang)
        Me.Controls.Add(Me.DataGridViewBarang)
        Me.Name = "FormBarang"
        Me.Text = "FormBarang"
        CType(Me.DataGridViewBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewBarang As DataGridView
    Friend WithEvents ButtonTambahBarang As Button
    Friend WithEvents ButtonEditBarang As Button
    Friend WithEvents ButtonHapusBarang As Button
End Class

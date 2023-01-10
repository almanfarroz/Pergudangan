<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahBarangMasuk
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
        Me.ComboBoxIdOrder = New System.Windows.Forms.ComboBox()
        Me.TextBoxJumlahMasuk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBoxIdOrder
        '
        Me.ComboBoxIdOrder.FormattingEnabled = True
        Me.ComboBoxIdOrder.Location = New System.Drawing.Point(205, 111)
        Me.ComboBoxIdOrder.Name = "ComboBoxIdOrder"
        Me.ComboBoxIdOrder.Size = New System.Drawing.Size(185, 28)
        Me.ComboBoxIdOrder.TabIndex = 11
        '
        'TextBoxJumlahMasuk
        '
        Me.TextBoxJumlahMasuk.Location = New System.Drawing.Point(205, 167)
        Me.TextBoxJumlahMasuk.Name = "TextBoxJumlahMasuk"
        Me.TextBoxJumlahMasuk.Size = New System.Drawing.Size(185, 27)
        Me.TextBoxJumlahMasuk.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(25, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 35)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Barang Masuk"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(25, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 28)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Jumlah Masuk"
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Location = New System.Drawing.Point(296, 242)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(94, 29)
        Me.ButtonEnter.TabIndex = 7
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(25, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 28)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Jumlah Order"
        '
        'FormTambahBarangMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 312)
        Me.Controls.Add(Me.ComboBoxIdOrder)
        Me.Controls.Add(Me.TextBoxJumlahMasuk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonEnter)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTambahBarangMasuk"
        Me.Text = "FormTambahBarangMasuk"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxIdOrder As ComboBox
    Friend WithEvents TextBoxJumlahMasuk As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label1 As Label
End Class

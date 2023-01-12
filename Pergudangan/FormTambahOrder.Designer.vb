<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTambahOrder
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
        Me.DateTimePickerTanggalOrder = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxBarang = New System.Windows.Forms.ComboBox()
        Me.TextBoxJumlahOrder = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonTambahOrder = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DateTimePickerTanggalOrder
        '
        Me.DateTimePickerTanggalOrder.Location = New System.Drawing.Point(279, 62)
        Me.DateTimePickerTanggalOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePickerTanggalOrder.Name = "DateTimePickerTanggalOrder"
        Me.DateTimePickerTanggalOrder.Size = New System.Drawing.Size(219, 23)
        Me.DateTimePickerTanggalOrder.TabIndex = 22
        '
        'ComboBoxBarang
        '
        Me.ComboBoxBarang.FormattingEnabled = True
        Me.ComboBoxBarang.Location = New System.Drawing.Point(279, 28)
        Me.ComboBoxBarang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxBarang.Name = "ComboBoxBarang"
        Me.ComboBoxBarang.Size = New System.Drawing.Size(219, 23)
        Me.ComboBoxBarang.TabIndex = 21
        '
        'TextBoxJumlahOrder
        '
        Me.TextBoxJumlahOrder.Location = New System.Drawing.Point(279, 95)
        Me.TextBoxJumlahOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxJumlahOrder.Name = "TextBoxJumlahOrder"
        Me.TextBoxJumlahOrder.Size = New System.Drawing.Size(219, 23)
        Me.TextBoxJumlahOrder.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Jumlah Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tanggal Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Barang"
        '
        'ButtonTambahOrder
        '
        Me.ButtonTambahOrder.Location = New System.Drawing.Point(379, 135)
        Me.ButtonTambahOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonTambahOrder.Name = "ButtonTambahOrder"
        Me.ButtonTambahOrder.Size = New System.Drawing.Size(119, 28)
        Me.ButtonTambahOrder.TabIndex = 16
        Me.ButtonTambahOrder.Text = "Tambah"
        Me.ButtonTambahOrder.UseVisualStyleBackColor = True
        '
        'FormTambahOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 189)
        Me.Controls.Add(Me.DateTimePickerTanggalOrder)
        Me.Controls.Add(Me.ComboBoxBarang)
        Me.Controls.Add(Me.TextBoxJumlahOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonTambahOrder)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormTambahOrder"
        Me.Text = "FormTambahOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerTanggalOrder As DateTimePicker
    Friend WithEvents ComboBoxBarang As ComboBox
    Friend WithEvents TextBoxJumlahOrder As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonTambahOrder As Button
End Class

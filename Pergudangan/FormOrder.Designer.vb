<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOrder
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
        Me.DataGridViewOrder = New System.Windows.Forms.DataGridView()
        Me.ButtonAddOrder = New System.Windows.Forms.Button()
        Me.ButtonDeleteOrder = New System.Windows.Forms.Button()
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewOrder
        '
        Me.DataGridViewOrder.AllowUserToAddRows = False
        Me.DataGridViewOrder.AllowUserToDeleteRows = False
        Me.DataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrder.Location = New System.Drawing.Point(10, 26)
        Me.DataGridViewOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewOrder.Name = "DataGridViewOrder"
        Me.DataGridViewOrder.ReadOnly = True
        Me.DataGridViewOrder.RowHeadersWidth = 51
        Me.DataGridViewOrder.RowTemplate.Height = 29
        Me.DataGridViewOrder.Size = New System.Drawing.Size(679, 141)
        Me.DataGridViewOrder.TabIndex = 0
        '
        'ButtonAddOrder
        '
        Me.ButtonAddOrder.Location = New System.Drawing.Point(10, 172)
        Me.ButtonAddOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonAddOrder.Name = "ButtonAddOrder"
        Me.ButtonAddOrder.Size = New System.Drawing.Size(82, 22)
        Me.ButtonAddOrder.TabIndex = 1
        Me.ButtonAddOrder.Text = "Add"
        Me.ButtonAddOrder.UseVisualStyleBackColor = True
        '
        'ButtonDeleteOrder
        '
        Me.ButtonDeleteOrder.Location = New System.Drawing.Point(98, 172)
        Me.ButtonDeleteOrder.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDeleteOrder.Name = "ButtonDeleteOrder"
        Me.ButtonDeleteOrder.Size = New System.Drawing.Size(82, 22)
        Me.ButtonDeleteOrder.TabIndex = 2
        Me.ButtonDeleteOrder.Text = "Delete"
        Me.ButtonDeleteOrder.UseVisualStyleBackColor = True
        '
        'FormOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 208)
        Me.Controls.Add(Me.ButtonDeleteOrder)
        Me.Controls.Add(Me.ButtonAddOrder)
        Me.Controls.Add(Me.DataGridViewOrder)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormOrder"
        Me.Text = "FormOrder"
        CType(Me.DataGridViewOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridViewOrder As DataGridView
    Friend WithEvents ButtonAddOrder As Button
    Friend WithEvents ButtonDeleteOrder As Button
End Class

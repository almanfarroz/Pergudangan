<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(293, 128)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(239, 31)
        Me.TextBoxUsername.TabIndex = 0
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(293, 199)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(239, 31)
        Me.TextBoxEmail.TabIndex = 1
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(293, 271)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(239, 31)
        Me.TextBoxPassword.TabIndex = 2
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(293, 344)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(239, 31)
        Me.TextBoxConfirmPassword.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(293, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(293, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm Password"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(293, 401)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(130, 37)
        Me.ButtonRegister.TabIndex = 8
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 513)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "FormRegister"
        Me.Text = "FormRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonRegister As Button
End Class

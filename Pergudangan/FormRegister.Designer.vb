<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRegister
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
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelConfirmPassword = New System.Windows.Forms.Label()
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
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(293, 100)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(91, 25)
        Me.LabelUsername.TabIndex = 4
        Me.LabelUsername.Text = "Username"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(293, 171)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(54, 25)
        Me.LabelEmail.TabIndex = 5
        Me.LabelEmail.Text = "Email"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(293, 243)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(87, 25)
        Me.LabelPassword.TabIndex = 6
        Me.LabelPassword.Text = "Password"
        '
        'LabelConfirmPassword
        '
        Me.LabelConfirmPassword.AutoSize = True
        Me.LabelConfirmPassword.Location = New System.Drawing.Point(293, 316)
        Me.LabelConfirmPassword.Name = "LabelConfirmPassword"
        Me.LabelConfirmPassword.Size = New System.Drawing.Size(156, 25)
        Me.LabelConfirmPassword.TabIndex = 7
        Me.LabelConfirmPassword.Text = "Confirm Password"
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
        Me.Controls.Add(Me.LabelConfirmPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelUsername)
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
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents LabelConfirmPassword As Label
    Friend WithEvents ButtonRegister As Button
End Class

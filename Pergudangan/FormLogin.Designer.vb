<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(377, 307)
        Me.ButtonRegister.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(107, 38)
        Me.ButtonRegister.TabIndex = 17
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(261, 307)
        Me.ButtonLogin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(107, 38)
        Me.ButtonLogin.TabIndex = 16
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(261, 205)
        Me.LabelPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(87, 25)
        Me.LabelPassword.TabIndex = 15
        Me.LabelPassword.Text = "Password"
        Me.LabelPassword.UseWaitCursor = True
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(261, 235)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(278, 31)
        Me.TextBoxPassword.TabIndex = 14
        Me.TextBoxPassword.UseWaitCursor = True
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(261, 105)
        Me.LabelUsername.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(91, 25)
        Me.LabelUsername.TabIndex = 13
        Me.LabelUsername.Text = "Username"
        Me.LabelUsername.UseWaitCursor = True
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(261, 135)
        Me.TextBoxUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(278, 31)
        Me.TextBoxUsername.TabIndex = 12
        Me.TextBoxUsername.UseWaitCursor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Name = "FormLogin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxUsername As TextBox
End Class

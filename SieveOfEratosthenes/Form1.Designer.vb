<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sieve
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
        Me.UpToTextBox = New System.Windows.Forms.TextBox()
        Me.FindPrimesButton = New System.Windows.Forms.Button()
        Me.MsgBox = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'UpToTextBox
        '
        Me.UpToTextBox.Location = New System.Drawing.Point(57, 38)
        Me.UpToTextBox.Name = "UpToTextBox"
        Me.UpToTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UpToTextBox.TabIndex = 0
        '
        'FindPrimesButton
        '
        Me.FindPrimesButton.Location = New System.Drawing.Point(82, 97)
        Me.FindPrimesButton.Name = "FindPrimesButton"
        Me.FindPrimesButton.Size = New System.Drawing.Size(75, 23)
        Me.FindPrimesButton.TabIndex = 1
        Me.FindPrimesButton.Text = "Find Primes"
        Me.FindPrimesButton.UseVisualStyleBackColor = True
        '
        'MsgBox
        '
        Me.MsgBox.Location = New System.Drawing.Point(57, 268)
        Me.MsgBox.Name = "MsgBox"
        Me.MsgBox.ReadOnly = True
        Me.MsgBox.Size = New System.Drawing.Size(100, 20)
        Me.MsgBox.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(57, 143)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 4
        '
        'Sieve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 346)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MsgBox)
        Me.Controls.Add(Me.FindPrimesButton)
        Me.Controls.Add(Me.UpToTextBox)
        Me.Name = "Sieve"
        Me.Text = "Find Prime Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpToTextBox As TextBox
    Friend WithEvents FindPrimesButton As Button
    Friend WithEvents MsgBox As TextBox
    Friend WithEvents ListBox1 As ListBox
End Class

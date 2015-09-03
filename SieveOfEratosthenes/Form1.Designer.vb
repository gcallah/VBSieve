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
        Me.PrimesListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'UpToTextBox
        '
        Me.UpToTextBox.ForeColor = System.Drawing.SystemColors.WindowText
        Me.UpToTextBox.Location = New System.Drawing.Point(57, 38)
        Me.UpToTextBox.Name = "UpToTextBox"
        Me.UpToTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UpToTextBox.TabIndex = 0
        '
        'FindPrimesButton
        '
        Me.FindPrimesButton.BackColor = System.Drawing.Color.PaleGreen
        Me.FindPrimesButton.Location = New System.Drawing.Point(82, 88)
        Me.FindPrimesButton.Name = "FindPrimesButton"
        Me.FindPrimesButton.Size = New System.Drawing.Size(75, 23)
        Me.FindPrimesButton.TabIndex = 1
        Me.FindPrimesButton.Text = "Find Primes"
        Me.FindPrimesButton.UseVisualStyleBackColor = False
        '
        'MsgBox
        '
        Me.MsgBox.ForeColor = System.Drawing.Color.Maroon
        Me.MsgBox.Location = New System.Drawing.Point(57, 268)
        Me.MsgBox.Name = "MsgBox"
        Me.MsgBox.ReadOnly = True
        Me.MsgBox.Size = New System.Drawing.Size(333, 20)
        Me.MsgBox.TabIndex = 3
        '
        'PrimesListBox
        '
        Me.PrimesListBox.FormattingEnabled = True
        Me.PrimesListBox.Location = New System.Drawing.Point(57, 143)
        Me.PrimesListBox.Name = "PrimesListBox"
        Me.PrimesListBox.Size = New System.Drawing.Size(128, 82)
        Me.PrimesListBox.TabIndex = 4
        '
        'Sieve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(402, 346)
        Me.Controls.Add(Me.PrimesListBox)
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
    Friend WithEvents PrimesListBox As ListBox
End Class

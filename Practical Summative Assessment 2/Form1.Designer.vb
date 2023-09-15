<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblWord = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.rbtnUpper = New System.Windows.Forms.RadioButton()
        Me.grpCase = New System.Windows.Forms.GroupBox()
        Me.grpColor = New System.Windows.Forms.GroupBox()
        Me.rbtnPurple = New System.Windows.Forms.RadioButton()
        Me.rbtnLower = New System.Windows.Forms.RadioButton()
        Me.rbtnBlue = New System.Windows.Forms.RadioButton()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.grpCase.SuspendLayout()
        Me.grpColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(319, 88)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(133, 37)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(177, 9)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(103, 20)
        Me.lblWord.TabIndex = 1
        Me.lblWord.Text = "Enter a word:"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(354, 241)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 20)
        Me.lblDisplay.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(181, 142)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(433, 84)
        Me.ListBox1.TabIndex = 3
        '
        'rbtnUpper
        '
        Me.rbtnUpper.AutoSize = True
        Me.rbtnUpper.Location = New System.Drawing.Point(6, 25)
        Me.rbtnUpper.Name = "rbtnUpper"
        Me.rbtnUpper.Size = New System.Drawing.Size(100, 24)
        Me.rbtnUpper.TabIndex = 4
        Me.rbtnUpper.TabStop = True
        Me.rbtnUpper.Text = "To Upper"
        Me.rbtnUpper.UseVisualStyleBackColor = True
        '
        'grpCase
        '
        Me.grpCase.Controls.Add(Me.rbtnLower)
        Me.grpCase.Controls.Add(Me.rbtnUpper)
        Me.grpCase.Location = New System.Drawing.Point(181, 308)
        Me.grpCase.Name = "grpCase"
        Me.grpCase.Size = New System.Drawing.Size(200, 100)
        Me.grpCase.TabIndex = 5
        Me.grpCase.TabStop = False
        Me.grpCase.Text = "Case"
        '
        'grpColor
        '
        Me.grpColor.Controls.Add(Me.rbtnPurple)
        Me.grpColor.Controls.Add(Me.rbtnBlue)
        Me.grpColor.Location = New System.Drawing.Point(414, 308)
        Me.grpColor.Name = "grpColor"
        Me.grpColor.Size = New System.Drawing.Size(200, 100)
        Me.grpColor.TabIndex = 6
        Me.grpColor.TabStop = False
        Me.grpColor.Text = "Color"
        '
        'rbtnPurple
        '
        Me.rbtnPurple.AutoSize = True
        Me.rbtnPurple.Location = New System.Drawing.Point(6, 25)
        Me.rbtnPurple.Name = "rbtnPurple"
        Me.rbtnPurple.Size = New System.Drawing.Size(79, 24)
        Me.rbtnPurple.TabIndex = 7
        Me.rbtnPurple.TabStop = True
        Me.rbtnPurple.Text = "Purple"
        Me.rbtnPurple.UseVisualStyleBackColor = True
        '
        'rbtnLower
        '
        Me.rbtnLower.AutoSize = True
        Me.rbtnLower.Location = New System.Drawing.Point(6, 70)
        Me.rbtnLower.Name = "rbtnLower"
        Me.rbtnLower.Size = New System.Drawing.Size(99, 24)
        Me.rbtnLower.TabIndex = 8
        Me.rbtnLower.TabStop = True
        Me.rbtnLower.Text = "To Lower"
        Me.rbtnLower.UseVisualStyleBackColor = True
        '
        'rbtnBlue
        '
        Me.rbtnBlue.AutoSize = True
        Me.rbtnBlue.Location = New System.Drawing.Point(6, 70)
        Me.rbtnBlue.Name = "rbtnBlue"
        Me.rbtnBlue.Size = New System.Drawing.Size(66, 24)
        Me.rbtnBlue.TabIndex = 9
        Me.rbtnBlue.TabStop = True
        Me.rbtnBlue.Text = "Blue"
        Me.rbtnBlue.UseVisualStyleBackColor = True
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(181, 43)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(433, 26)
        Me.txtWord.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.grpColor)
        Me.Controls.Add(Me.grpCase)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblWord)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpCase.ResumeLayout(False)
        Me.grpCase.PerformLayout()
        Me.grpColor.ResumeLayout(False)
        Me.grpColor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblWord As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents rbtnUpper As RadioButton
    Friend WithEvents grpCase As GroupBox
    Friend WithEvents rbtnLower As RadioButton
    Friend WithEvents grpColor As GroupBox
    Friend WithEvents rbtnPurple As RadioButton
    Friend WithEvents rbtnBlue As RadioButton
    Friend WithEvents txtWord As TextBox
End Class

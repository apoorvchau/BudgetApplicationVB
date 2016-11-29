<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeleteForm
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
        Me.button2 = New System.Windows.Forms.Button()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(161, 59)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 64
        Me.button2.Text = "Close"
        Me.button2.UseVisualStyleBackColor = True
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 106)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.statusStrip1.TabIndex = 63
        Me.statusStrip1.Text = "statusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(52, 59)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 62
        Me.button1.Text = "Delete"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(136, 21)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(100, 20)
        Me.textBox5.TabIndex = 61
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(49, 24)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 13)
        Me.label5.TabIndex = 60
        Me.label5.Text = "Expense Name:"
        '
        'DeleteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 128)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.label5)
        Me.Name = "DeleteForm"
        Me.Text = "DeleteForm"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button2 As Button
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents lblStatus As ToolStripStatusLabel
    Private WithEvents button1 As Button
    Private WithEvents textBox5 As TextBox
    Private WithEvents label5 As Label
End Class

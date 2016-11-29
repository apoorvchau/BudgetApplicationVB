<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Me.button3 = New System.Windows.Forms.Button()
        Me.button2 = New System.Windows.Forms.Button()
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.button1 = New System.Windows.Forms.Button()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.statusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(159, 218)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(75, 23)
        Me.button3.TabIndex = 71
        Me.button3.Text = "Exit"
        Me.button3.UseVisualStyleBackColor = True
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(50, 218)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(75, 23)
        Me.button2.TabIndex = 70
        Me.button2.Text = "Update"
        Me.button2.UseVisualStyleBackColor = True
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 276)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(284, 22)
        Me.statusStrip1.TabIndex = 69
        Me.statusStrip1.Text = "statusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(112, 56)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 68
        Me.button1.Text = "Search"
        Me.button1.UseVisualStyleBackColor = True
        '
        'textBox5
        '
        Me.textBox5.Location = New System.Drawing.Point(134, 21)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(100, 20)
        Me.textBox5.TabIndex = 67
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(47, 24)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(82, 13)
        Me.label5.TabIndex = 66
        Me.label5.Text = "Expense Name:"
        '
        'textBox4
        '
        Me.textBox4.Location = New System.Drawing.Point(134, 188)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(100, 20)
        Me.textBox4.TabIndex = 65
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(47, 191)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(34, 13)
        Me.label1.TabIndex = 64
        Me.label1.Text = "Price:"
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(134, 162)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(100, 20)
        Me.textBox3.TabIndex = 63
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(134, 136)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 62
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(134, 110)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 61
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(47, 165)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 13)
        Me.label4.TabIndex = 60
        Me.label4.Text = "Expense Name:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(47, 139)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 13)
        Me.label3.TabIndex = 59
        Me.label3.Text = "Week #:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(47, 113)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 13)
        Me.label2.TabIndex = 58
        Me.label2.Text = "Year:"
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 298)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Name = "UpdateForm"
        Me.Text = "UpdateForm"
        Me.statusStrip1.ResumeLayout(False)
        Me.statusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button3 As Button
    Private WithEvents button2 As Button
    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents lblStatus As ToolStripStatusLabel
    Private WithEvents button1 As Button
    Private WithEvents textBox5 As TextBox
    Private WithEvents label5 As Label
    Private WithEvents textBox4 As TextBox
    Private WithEvents label1 As Label
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
End Class

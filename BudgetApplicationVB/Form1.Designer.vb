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
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.menuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.fileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.estimatedBudgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.actualBudgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.menuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusStrip1
        '
        Me.statusStrip1.Location = New System.Drawing.Point(0, 237)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.Size = New System.Drawing.Size(362, 22)
        Me.statusStrip1.TabIndex = 12
        Me.statusStrip1.Text = "statusStrip1"
        '
        'menuStrip1
        '
        Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileToolStripMenuItem})
        Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.menuStrip1.Name = "menuStrip1"
        Me.menuStrip1.Size = New System.Drawing.Size(362, 24)
        Me.menuStrip1.TabIndex = 13
        Me.menuStrip1.Text = "menuStrip1"
        '
        'fileToolStripMenuItem
        '
        Me.fileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.estimatedBudgetToolStripMenuItem, Me.actualBudgetToolStripMenuItem, Me.exitToolStripMenuItem})
        Me.fileToolStripMenuItem.Name = "fileToolStripMenuItem"
        Me.fileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.fileToolStripMenuItem.Text = "File"
        '
        'estimatedBudgetToolStripMenuItem
        '
        Me.estimatedBudgetToolStripMenuItem.Name = "estimatedBudgetToolStripMenuItem"
        Me.estimatedBudgetToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.estimatedBudgetToolStripMenuItem.Text = "Estimated Budget"
        '
        'actualBudgetToolStripMenuItem
        '
        Me.actualBudgetToolStripMenuItem.Name = "actualBudgetToolStripMenuItem"
        Me.actualBudgetToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.actualBudgetToolStripMenuItem.Text = "Actual Budget"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.exitToolStripMenuItem.Text = "Exit"
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.button2.Location = New System.Drawing.Point(213, 145)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(92, 49)
        Me.button2.TabIndex = 11
        Me.button2.Text = "Actual Budget"
        Me.button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(213, 43)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(92, 49)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Estimated Budget"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("French Script MT", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(8, 145)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(160, 49)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Application"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("French Script MT", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(8, 94)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(114, 49)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Budget"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("French Script MT", 32.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(8, 43)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(127, 49)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Personal"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 259)
        Me.Controls.Add(Me.statusStrip1)
        Me.Controls.Add(Me.menuStrip1)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.menuStrip1.ResumeLayout(False)
        Me.menuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents statusStrip1 As StatusStrip
    Private WithEvents menuStrip1 As MenuStrip
    Private WithEvents fileToolStripMenuItem As ToolStripMenuItem
    Private WithEvents estimatedBudgetToolStripMenuItem As ToolStripMenuItem
    Private WithEvents actualBudgetToolStripMenuItem As ToolStripMenuItem
    Private WithEvents exitToolStripMenuItem As ToolStripMenuItem
    Private WithEvents button2 As Button
    Private WithEvents button1 As Button
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class

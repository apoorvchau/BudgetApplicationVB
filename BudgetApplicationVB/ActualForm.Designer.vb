<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualForm))
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ActualExpenseDataSet = New BudgetApplicationVB.ActualExpenseDataSet()
        Me.ExpActualBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpActualTableAdapter = New BudgetApplicationVB.ActualExpenseDataSetTableAdapters.ExpActualTableAdapter()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WeekNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExpenseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ActualExpenseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpActualBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolStrip1
        '
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripButton1, Me.toolStripSeparator2, Me.toolStripButton5, Me.toolStripSeparator4, Me.toolStripButton4, Me.toolStripSeparator3, Me.toolStripButton3, Me.toolStripSeparator5, Me.toolStripButton2, Me.toolStripSeparator1})
        Me.toolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Size = New System.Drawing.Size(755, 25)
        Me.toolStrip1.TabIndex = 44
        Me.toolStrip1.Text = "toolStrip1"
        '
        'toolStripButton1
        '
        Me.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton1.Image = CType(resources.GetObject("toolStripButton1.Image"), System.Drawing.Image)
        Me.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton1.Name = "toolStripButton1"
        Me.toolStripButton1.Size = New System.Drawing.Size(57, 22)
        Me.toolStripButton1.Text = "Show All"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton5
        '
        Me.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton5.Image = CType(resources.GetObject("toolStripButton5.Image"), System.Drawing.Image)
        Me.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton5.Name = "toolStripButton5"
        Me.toolStripButton5.Size = New System.Drawing.Size(33, 22)
        Me.toolStripButton5.Text = "Add"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton4
        '
        Me.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton4.Image = CType(resources.GetObject("toolStripButton4.Image"), System.Drawing.Image)
        Me.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton4.Name = "toolStripButton4"
        Me.toolStripButton4.Size = New System.Drawing.Size(49, 22)
        Me.toolStripButton4.Text = "Update"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton3
        '
        Me.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton3.Image = CType(resources.GetObject("toolStripButton3.Image"), System.Drawing.Image)
        Me.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton3.Name = "toolStripButton3"
        Me.toolStripButton3.Size = New System.Drawing.Size(44, 22)
        Me.toolStripButton3.Text = "Delete"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'toolStripButton2
        '
        Me.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolStripButton2.Image = CType(resources.GetObject("toolStripButton2.Image"), System.Drawing.Image)
        Me.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolStripButton2.Name = "toolStripButton2"
        Me.toolStripButton2.Size = New System.Drawing.Size(40, 22)
        Me.toolStripButton2.Text = "Close"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(643, 150)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(100, 20)
        Me.textBox3.TabIndex = 51
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(643, 119)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(100, 20)
        Me.textBox2.TabIndex = 50
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(643, 88)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(100, 20)
        Me.textBox1.TabIndex = 49
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(592, 191)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 23)
        Me.button1.TabIndex = 48
        Me.button1.Text = "Search"
        Me.button1.UseVisualStyleBackColor = True
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(556, 153)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(82, 13)
        Me.label4.TabIndex = 47
        Me.label4.Text = "Expense Name:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(556, 122)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(49, 13)
        Me.label3.TabIndex = 46
        Me.label3.Text = "Week #:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(556, 91)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(32, 13)
        Me.label2.TabIndex = 45
        Me.label2.Text = "Year:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 286)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(755, 22)
        Me.StatusStrip1.TabIndex = 52
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.YearDataGridViewTextBoxColumn, Me.WeekNumberDataGridViewTextBoxColumn, Me.ExpenseNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ExpActualBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(527, 255)
        Me.DataGridView1.TabIndex = 53
        '
        'ActualExpenseDataSet
        '
        Me.ActualExpenseDataSet.DataSetName = "ActualExpenseDataSet"
        Me.ActualExpenseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpActualBindingSource
        '
        Me.ExpActualBindingSource.DataMember = "ExpActual"
        Me.ExpActualBindingSource.DataSource = Me.ActualExpenseDataSet
        '
        'ExpActualTableAdapter
        '
        Me.ExpActualTableAdapter.ClearBeforeFill = True
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'WeekNumberDataGridViewTextBoxColumn
        '
        Me.WeekNumberDataGridViewTextBoxColumn.DataPropertyName = "Week Number"
        Me.WeekNumberDataGridViewTextBoxColumn.HeaderText = "Week Number"
        Me.WeekNumberDataGridViewTextBoxColumn.Name = "WeekNumberDataGridViewTextBoxColumn"
        '
        'ExpenseNameDataGridViewTextBoxColumn
        '
        Me.ExpenseNameDataGridViewTextBoxColumn.DataPropertyName = "Expense Name"
        Me.ExpenseNameDataGridViewTextBoxColumn.HeaderText = "Expense Name"
        Me.ExpenseNameDataGridViewTextBoxColumn.Name = "ExpenseNameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'ActualForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 308)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.toolStrip1)
        Me.Name = "ActualForm"
        Me.Text = "ActualForm"
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ActualExpenseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpActualBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents toolStripButton1 As ToolStripButton
    Private WithEvents toolStripSeparator2 As ToolStripSeparator
    Private WithEvents toolStripButton5 As ToolStripButton
    Private WithEvents toolStripSeparator4 As ToolStripSeparator
    Private WithEvents toolStripButton4 As ToolStripButton
    Private WithEvents toolStripSeparator3 As ToolStripSeparator
    Private WithEvents toolStripButton3 As ToolStripButton
    Private WithEvents toolStripSeparator5 As ToolStripSeparator
    Private WithEvents toolStripButton2 As ToolStripButton
    Private WithEvents toolStripSeparator1 As ToolStripSeparator
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents button1 As Button
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ActualExpenseDataSet As ActualExpenseDataSet
    Friend WithEvents ExpActualBindingSource As BindingSource
    Friend WithEvents ExpActualTableAdapter As ActualExpenseDataSetTableAdapters.ExpActualTableAdapter
    Friend WithEvents YearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WeekNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExpenseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

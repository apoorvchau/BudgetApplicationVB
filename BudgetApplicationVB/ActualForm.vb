Public Class ActualForm
    Private Sub ActualForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ActualExpenseDataSet.ExpActual' table. You can move, or remove it, as needed.
        Me.ExpActualTableAdapter.Fill(Me.ActualExpenseDataSet.ExpActual)

    End Sub
End Class
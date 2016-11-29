Public Class ExpectedForm
    Private Sub ExpectedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ExpectedExpenseDataSet.ExpExpected' table. You can move, or remove it, as needed.
        Me.ExpExpectedTableAdapter.Fill(Me.ExpectedExpenseDataSet.ExpExpected)

    End Sub
End Class
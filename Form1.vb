Public Class Form1
    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click
        Dim frmMembers As New Form2
        frmMembers.ShowDialog()
        'navigate to the Members form'


    End Sub

    Private Sub btnPayments_Click(sender As Object, e As EventArgs) Handles btnPayments.Click
        Dim frmPayments As New Form3
        frmPayments.ShowDialog()
        'navigate to the Payments form'
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        'close the form'
    End Sub
End Class

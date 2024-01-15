Public Class Form3
    Dim Total As Decimal
    Dim Total2 As Decimal
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet1.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateDataSet1.Payments)

    End Sub

    Private Sub All_RecordsToolStripButton_Click(sender As Object, e As EventArgs) Handles All_RecordsToolStripButton.Click
        Try
            Me.PaymentsTableAdapter.All_Records(Me.KarateDataSet1.Payments)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Over50ToolStripButton_Click(sender As Object, e As EventArgs) Handles Over50ToolStripButton.Click
        Try
            Me.PaymentsTableAdapter.Over50(Me.KarateDataSet1.Payments)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form'
        Me.Close()
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim row As KarateDataSet1.PaymentsRow
        For Each row In Me.KarateDataSet1.Payments.Rows
            Total += row.Amount
        Next
        MessageBox.Show("Total payments are equal to :" & Total.ToString("c"), "Total")
    End Sub

    Private Sub btnTotal2_Click(sender As Object, e As EventArgs) Handles btnTotal2.Click
        Dim row As KarateDataSet1.PaymentsRow
        For Each row In Me.KarateDataSet1.Payments.Rows
            If row.Amount > 50 Then
                Total2 += row.Amount
            End If
        Next
        MessageBox.Show("Total payments are equal to :" & Total2.ToString("c"), "Total")

    End Sub
End Class
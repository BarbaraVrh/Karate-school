Public Class Form2


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KarateDataSet1.Payments' table. You can move, or remove it, as needed.
        Me.PaymentsTableAdapter.Fill(Me.KarateDataSet1.Payments)
        ' Get the current date from the system.
        Dim dtmSystemDate = Today

        ' Display the date.
        txtDate.Text = dtmSystemDate.ToString("d")
        'TODO: This line of code loads data into the 'KarateDataSet1.Members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter1.Fill(Me.KarateDataSet1.Members)



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the form'
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Me.MembersTableAdapter1.Insert(CShort(txtID.Text),
               (txtLast.Text), (txtFirst.Text), txtPhone.Text, CDate(txtDate.Text))
            Me.MembersTableAdapter1.Fill(KarateDataSet1.Members)
        Catch ex As Exception
            MessageBox.Show(ex.Message, “Data Input Error”)
        End Try
    End Sub
End Class
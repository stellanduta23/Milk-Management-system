Public Class Accounts


    Private Sub Accounts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Accounts)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        homepage.Show()
        Me.Hide()

    End Sub

    Private Sub SumOfTotal1Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
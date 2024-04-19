Public Class homepage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncustomers.Click
        Customer_Details.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnmilkinventory.Click
        Milk_Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Saless.Show()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Suppliers.Show()
        Me.Hide()

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Deliverymen.Show()
        Me.hide
    End Sub

    Private Sub homepage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnaccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaccounts.Click
        Accounts_Login.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Deliveries.Show()
        Me.Hide()

    End Sub
End Class
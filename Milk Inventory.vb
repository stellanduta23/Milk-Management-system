Public Class Milk_Inventory


    Private Sub Milk_Inventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Milk_Inventory' table. You can move, or remove it, as needed.
        '  Me.Milk_InventoryTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Milk_Inventory)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Inventory)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Inventory)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Milk_Inventory' table. You can move, or remove it, as needed.
        'Me.Milk_InventoryTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Milk_Inventory)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Inventory)

    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        homepage.Show()
        Me.Hide()
    End Sub
End Class
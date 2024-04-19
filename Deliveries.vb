Public Class Deliveries

    Private Sub DeliveriesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DeliveriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub Deliveries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Deliveries' table. You can move, or remove it, as needed.
        Me.DeliveriesTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Deliveries)

    End Sub

    Private Sub btncustomerdetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncustomerdetails.Click
        Customer_details.Show()
        Me.Hide()

    End Sub

    Private Sub Delivery_DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_DateDateTimePicker.ValueChanged

        Delivery_DateDateTimePicker.MinDate = DateTime.Today

    End Sub
End Class





















Public Class Deliverymen

    Private Sub Delivery_MenBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Delivery_MenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub Deliverymen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Delivery_Men' table. You can move, or remove it, as needed.
        Me.Delivery_MenTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Delivery_Men)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet1.Delivery_Men' table. You can move, or remove it, as needed.
        Me.Delivery_MenTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Delivery_Men)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        homepage.Show()

    End Sub

    Private Sub Entry_DateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Delivery_MenBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delivery_MenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Delivery_MenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)
        MsgBox(" Record Saved Succefully")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        homepage.Show()
        Me.Hide()

    End Sub
End Class
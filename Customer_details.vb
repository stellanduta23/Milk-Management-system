Public Class Customer_details

    Private Sub CustomersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TotalTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Customer_IDTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LitresTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("deleted succefully")
    End Sub

    Private Sub TotalTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub DeliveredCheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Payment_MethodComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TotalTextBox_TextChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(KshperlitreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(Litres_deliveredTextBox.Text, Litres_delivered) Then
            ' Calculate total
            Total = Kshperlitre * Litres_delivered

            ' Display total in TotalTextBox
            TotalTextBox.Text = Total.ToString()
        Else
            ' Display error message if input is invalid
            MessageBox.Show("Please enter valid numeric values for Ksh per litre and litres delivered.")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        homepage.Show()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Customer_s_NameTextBox.Clear()
        Customer_IDTextBox.Clear()
        AddressComboBox.SelectedIndex = -1
        Payment_MethodComboBox.SelectedIndex = -1
        Contact_NumberTextBox.Clear()
        Litres_deliveredTextBox.Clear()
        KshperlitreTextBox.Clear()
        TotalTextBox.Clear()
        Delivery_Man_idComboBox.SelectedIndex = -1
        DeliveredCheckBox.Checked = False

        Customer_s_NameTextBox.Focus()

    End Sub

    Private Sub DeliveredCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub


    Private Sub CustomersBindingNavigatorSaveItem_Click_5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        ' Me.TableAdapterManager1.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub Customer_details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Customers)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Delivery_Men' table. You can move, or remove it, as needed.
        ' Me.Delivery_MenTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Delivery_Men)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Customers)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Customers)

        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Customers)

    End Sub

    Private Sub TotalTextBox_TextChanged_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

       
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        homepage.Show()

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub CustomersBindingNavigatorSaveItem_Click_7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)
        MsgBox(" Customer Saved Succefully")
    End Sub

    Private Sub DeliveredCheckBox_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If DeliveredCheckBox.Checked Then

            Deliveries.Show()
            Me.Hide()
            Deliveries.DeliveryMan_IDTextBox.Text = Delivery_Man_idComboBox.Text
            Deliveries.Payment_MethodTextBox.Text = Payment_MethodComboBox.Text
            Deliveries.Customer_nameTextBox.Text = Customer_s_NameTextBox.Text
            Deliveries.Litres_deliveredTextBox.Text = Litres_deliveredTextBox.Text
            Deliveries.Customer_idTextBox.Text = Customer_IDTextBox.Text
        End If

    End Sub

    Private Sub TotalTextBox_TextChanged_4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim delivery_fee As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(KshperlitreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(Litres_deliveredTextBox.Text, Litres_delivered) AndAlso Double.TryParse(txtdeliveryfee.Text, delivery_fee) Then
            ' Calculate total
            Total = (Kshperlitre * Litres_delivered) + delivery_fee

            ' Display total in TotalTextBox
            TotalTextBox.Text = Total.ToString()

        End If
    End Sub

    Private Sub Customer_s_NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AddressComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (
            AddressComboBox.Text = "Santon") Then
            Delivery_Man_idComboBox.Text = "John Kamau 4567"
            txtdeliveryfee.Text = "30"
        ElseIf (
         AddressComboBox.Text = "Zimmerman") Then
            Delivery_Man_idComboBox.Text = "Peter muli 9876"
            txtdeliveryfee.Text = "50"
        ElseIf (
   AddressComboBox.Text = "Hunters") Then
            Delivery_Man_idComboBox.Text = "Daniel Njoroge 5566"
            txtdeliveryfee.Text = "40"
        ElseIf (
   AddressComboBox.Text = "Mwiki") Then
            Delivery_Man_idComboBox.Text = "Stanley Kamau 78976"
            txtdeliveryfee.Text = "30"
        ElseIf (
               AddressComboBox.Text = "Seosons") Then
            Delivery_Man_idComboBox.Text = "Brian Maina 10102"
            txtdeliveryfee.Text = "40"


        End If
    End Sub

    Private Sub btndeliveries_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndeliveries.Click
        Deliveries.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtdeliveryfee_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox(" Record Deleted Succefully")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorAddNewItem.Click
        CustomersBindingSource.AddNew()


    End Sub

    Private Sub BindingNavigator1_RefreshItems(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub DeliveredCheckBox_CheckedChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveredCheckBox.CheckedChanged
        If DeliveredCheckBox.Checked Then

            Deliveries.Show()
            Me.Hide()
            Deliveries.DeliveryMan_IDTextBox.Text = Delivery_Man_idComboBox.Text
            Deliveries.Payment_MethodTextBox.Text = Payment_MethodComboBox.Text
            Deliveries.Customer_nameTextBox.Text = Customer_s_NameTextBox.Text
            Deliveries.Litres_deliveredTextBox.Text = Litres_deliveredTextBox.Text
            Deliveries.Customer_idTextBox.Text = Customer_IDTextBox.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CustomersBindingSource.AddNew()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CustomersBindingSource.RemoveCurrent()
    End Sub

    Private Sub txtdeliveryfee_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtdeliveryfee.TextChanged
        If (
         AddressComboBox.Text = "Santon") Then
            Delivery_Man_idComboBox.Text = "John Kamau 4567"
            txtdeliveryfee.Text = "30"
        ElseIf (
         AddressComboBox.Text = "Zimmerman") Then
            Delivery_Man_idComboBox.Text = "Peter muli 9876"
            txtdeliveryfee.Text = "50"
        ElseIf (
   AddressComboBox.Text = "Hunters") Then
            Delivery_Man_idComboBox.Text = "Daniel Njoroge 5566"
            txtdeliveryfee.Text = "40"
        ElseIf (
   AddressComboBox.Text = "Mwiki") Then
            Delivery_Man_idComboBox.Text = "Stanley Kamau 78976"
            txtdeliveryfee.Text = "30"
        ElseIf (
               AddressComboBox.Text = "Seosons") Then
            Delivery_Man_idComboBox.Text = "Brian Maina 10102"
            txtdeliveryfee.Text = "40"
        End If

    End Sub

    Private Sub KshperlitreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KshperlitreTextBox.TextChanged
        If (
          AddressComboBox.Text = "Santon") Then
            Delivery_Man_idComboBox.Text = "John Kamau 4567"
            txtdeliveryfee.Text = "30"
        ElseIf (
         AddressComboBox.Text = "Zimmerman") Then
            Delivery_Man_idComboBox.Text = "Peter muli 9876"
            txtdeliveryfee.Text = "50"
        ElseIf (
   AddressComboBox.Text = "Hunters") Then
            Delivery_Man_idComboBox.Text = "Daniel Njoroge 5566"
            txtdeliveryfee.Text = "40"
        ElseIf (
   AddressComboBox.Text = "Mwiki") Then
            Delivery_Man_idComboBox.Text = "Stanley Kamau 78976"
            txtdeliveryfee.Text = "30"
        ElseIf (
               AddressComboBox.Text = "Seosons") Then
            Delivery_Man_idComboBox.Text = "Brian Maina 10102"
            txtdeliveryfee.Text = "40"


        End If
        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim delivery_fee As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(KshperlitreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(Litres_deliveredTextBox.Text, Litres_delivered) AndAlso Double.TryParse(txtdeliveryfee.Text, delivery_fee) Then
            ' Calculate total
            Total = (Kshperlitre * Litres_delivered) + delivery_fee

            ' Display total in TotalTextBox
            TotalTextBox.Text = Total.ToString()

        End If
    End Sub

    Private Sub TotalTextBox_TextChanged_5(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalTextBox.TextChanged
        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim delivery_fee As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(KshperlitreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(Litres_deliveredTextBox.Text, Litres_delivered) AndAlso Double.TryParse(txtdeliveryfee.Text, delivery_fee) Then
            ' Calculate total
            Total = (Kshperlitre * Litres_delivered) + delivery_fee

            ' Display total in TotalTextBox
            TotalTextBox.Text = Total.ToString()

        End If
    End Sub

    Private Sub AddressComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressComboBox.SelectedIndexChanged
        If (
          AddressComboBox.Text = "Santon") Then
            Delivery_Man_idComboBox.Text = "John Kamau 4567"
            txtdeliveryfee.Text = "30"
        ElseIf (
         AddressComboBox.Text = "Zimmerman") Then
            Delivery_Man_idComboBox.Text = "Peter muli 9876"
            txtdeliveryfee.Text = "50"
        ElseIf (
   AddressComboBox.Text = "Hunters") Then
            Delivery_Man_idComboBox.Text = "Daniel Njoroge 5566"
            txtdeliveryfee.Text = "40"
        ElseIf (
   AddressComboBox.Text = "Mwiki") Then
            Delivery_Man_idComboBox.Text = "Stanley Kamau 78976"
            txtdeliveryfee.Text = "30"
        ElseIf (
               AddressComboBox.Text = "Seosons") Then
            Delivery_Man_idComboBox.Text = "Brian Maina 10102"
            txtdeliveryfee.Text = "40"


        End If
    End Sub
End Class
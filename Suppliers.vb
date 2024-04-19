Public Class Suppliers

    Private Sub SuppliersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub Suppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Suppliers)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Suppliers)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Suppliers)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Suppliers)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet1.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Suppliers)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        homepage.Show()

    End Sub

    Private Sub SuppliersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub SuppliersBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub Date_SuppliedDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Date_SuppliedDateTimePicker.Value < DateTime.Today Then
            MessageBox.Show("Please select a date equal to or later than today.")
            Date_SuppliedDateTimePicker.Value = DateTime.Today
        End If
    End Sub

    Private Sub SuppliersBindingNavigatorSaveItem_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub SuppliersBindingNavigatorSaveItem_Click_4(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub KSh_litreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KSh_litreTextBox.TextChanged
        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(KSh_litreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(Amount_SuppliedTextBox.Text, Litres_delivered) Then
            ' Calculate total
            Total = Kshperlitre * Litres_delivered

            ' Display total in TotalTextBox
            TotalTextBox.Text = Total.ToString()
        End If
    End Sub
End Class
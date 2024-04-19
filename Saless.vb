
Imports System.Data.OleDb
Public Class Saless

    Private Sub SalesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)
        ' Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)
    End Sub
    Private Sub Saless_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Shop_sales' table. You can move, or remove it, as needed.
        Me.Shop_salesTableAdapter.Fill(Me.PROJECT_Amani_milk_management_systemDataSet.Shop_sales)
        'TODO: This line of code loads data into the 'PROJECT_Amani_milk_management_systemDataSet.Sales' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Ksh_per_litreTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Shop_salesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Shop_salesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shop_salesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Shop_salesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PROJECT_Amani_milk_management_systemDataSet)

    End Sub

    Private Sub Total_salesTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(Ksh_per_LitreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(LitresTextBox.Text, Litres_delivered) Then
            ' Calculate total
            Total = Kshperlitre * Litres_delivered

            ' Display total in TotalTextBox
            Total_amountTextBox.Text = Total.ToString()
        End If
    End Sub

    Private Sub Total_amountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Total_amountTextBox.TextChanged
        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(Ksh_per_LitreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(LitresTextBox.Text, Litres_delivered) Then
            ' Calculate total
            Total = Kshperlitre * Litres_delivered

            ' Display total in TotalTextBox
            Total_amountTextBox.Text = Total.ToString()
        End If
    End Sub

    Private Sub Ksh_per_LitreTextBox_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ksh_per_LitreTextBox.TextChanged
        Dim Kshperlitre As Double
        Dim Litres_delivered As Double
        Dim Total As Double

        ' Convert input from textboxes to double
        If Double.TryParse(Ksh_per_LitreTextBox.Text, Kshperlitre) AndAlso Double.TryParse(LitresTextBox.Text, Litres_delivered) Then
            ' Calculate total
            Total = Kshperlitre * Litres_delivered

            ' Display total in TotalTextBox
            Total_amountTextBox.Text = Total.ToString()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        homepage.Show()
        Me.Hide()

    End Sub

    Private Sub Sales_dateDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sales_dateDateTimePicker.ValueChanged
        
        Sales_dateDateTimePicker.MinDate = DateTime.Today

    End Sub

End Class
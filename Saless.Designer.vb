<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Saless
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Sales_IDLabel As System.Windows.Forms.Label
        Dim Sales_dateLabel As System.Windows.Forms.Label
        Dim Payment_MethodLabel As System.Windows.Forms.Label
        Dim LitresLabel As System.Windows.Forms.Label
        Dim Ksh_per_LitreLabel As System.Windows.Forms.Label
        Dim Total_amountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Saless))
        Me.PROJECT_Amani_milk_management_systemDataSet = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet()
        Me.Shop_salesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Shop_salesTableAdapter = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.Shop_salesTableAdapter()
        Me.TableAdapterManager = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Shop_salesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Shop_salesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Sales_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Sales_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Payment_MethodComboBox = New System.Windows.Forms.ComboBox()
        Me.LitresTextBox = New System.Windows.Forms.TextBox()
        Me.Ksh_per_LitreTextBox = New System.Windows.Forms.TextBox()
        Me.Total_amountTextBox = New System.Windows.Forms.TextBox()
        Me.Shop_salesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Sales_IDLabel = New System.Windows.Forms.Label()
        Sales_dateLabel = New System.Windows.Forms.Label()
        Payment_MethodLabel = New System.Windows.Forms.Label()
        LitresLabel = New System.Windows.Forms.Label()
        Ksh_per_LitreLabel = New System.Windows.Forms.Label()
        Total_amountLabel = New System.Windows.Forms.Label()
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shop_salesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shop_salesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Shop_salesBindingNavigator.SuspendLayout()
        CType(Me.Shop_salesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sales_IDLabel
        '
        Sales_IDLabel.AutoSize = True
        Sales_IDLabel.Location = New System.Drawing.Point(12, 63)
        Sales_IDLabel.Name = "Sales_IDLabel"
        Sales_IDLabel.Size = New System.Drawing.Size(50, 13)
        Sales_IDLabel.TabIndex = 1
        Sales_IDLabel.Text = "Sales ID:"
        '
        'Sales_dateLabel
        '
        Sales_dateLabel.AutoSize = True
        Sales_dateLabel.Location = New System.Drawing.Point(12, 90)
        Sales_dateLabel.Name = "Sales_dateLabel"
        Sales_dateLabel.Size = New System.Drawing.Size(60, 13)
        Sales_dateLabel.TabIndex = 3
        Sales_dateLabel.Text = "Sales date:"
        '
        'Payment_MethodLabel
        '
        Payment_MethodLabel.AutoSize = True
        Payment_MethodLabel.Location = New System.Drawing.Point(12, 115)
        Payment_MethodLabel.Name = "Payment_MethodLabel"
        Payment_MethodLabel.Size = New System.Drawing.Size(90, 13)
        Payment_MethodLabel.TabIndex = 5
        Payment_MethodLabel.Text = "Payment Method:"
        '
        'LitresLabel
        '
        LitresLabel.AutoSize = True
        LitresLabel.Location = New System.Drawing.Point(12, 142)
        LitresLabel.Name = "LitresLabel"
        LitresLabel.Size = New System.Drawing.Size(35, 13)
        LitresLabel.TabIndex = 7
        LitresLabel.Text = "Litres:"
        '
        'Ksh_per_LitreLabel
        '
        Ksh_per_LitreLabel.AutoSize = True
        Ksh_per_LitreLabel.Location = New System.Drawing.Point(12, 168)
        Ksh_per_LitreLabel.Name = "Ksh_per_LitreLabel"
        Ksh_per_LitreLabel.Size = New System.Drawing.Size(69, 13)
        Ksh_per_LitreLabel.TabIndex = 9
        Ksh_per_LitreLabel.Text = "Ksh per Litre:"
        '
        'Total_amountLabel
        '
        Total_amountLabel.AutoSize = True
        Total_amountLabel.Location = New System.Drawing.Point(12, 194)
        Total_amountLabel.Name = "Total_amountLabel"
        Total_amountLabel.Size = New System.Drawing.Size(72, 13)
        Total_amountLabel.TabIndex = 11
        Total_amountLabel.Text = "Total amount:"
        '
        'PROJECT_Amani_milk_management_systemDataSet
        '
        Me.PROJECT_Amani_milk_management_systemDataSet.DataSetName = "PROJECT_Amani_milk_management_systemDataSet"
        Me.PROJECT_Amani_milk_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Shop_salesBindingSource
        '
        Me.Shop_salesBindingSource.DataMember = "Shop sales"
        Me.Shop_salesBindingSource.DataSource = Me.PROJECT_Amani_milk_management_systemDataSet
        '
        'Shop_salesTableAdapter
        '
        Me.Shop_salesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.DeliveriesTableAdapter = Nothing
        Me.TableAdapterManager.Delivery_MenTableAdapter = Nothing
        Me.TableAdapterManager.Milk_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Shop_salesTableAdapter = Me.Shop_salesTableAdapter
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Shop_salesBindingNavigator
        '
        Me.Shop_salesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Shop_salesBindingNavigator.BackColor = System.Drawing.Color.Azure
        Me.Shop_salesBindingNavigator.BindingSource = Me.Shop_salesBindingSource
        Me.Shop_salesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Shop_salesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Shop_salesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Shop_salesBindingNavigatorSaveItem})
        Me.Shop_salesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Shop_salesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Shop_salesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Shop_salesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Shop_salesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Shop_salesBindingNavigator.Name = "Shop_salesBindingNavigator"
        Me.Shop_salesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Shop_salesBindingNavigator.Size = New System.Drawing.Size(1085, 25)
        Me.Shop_salesBindingNavigator.TabIndex = 0
        Me.Shop_salesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Shop_salesBindingNavigatorSaveItem
        '
        Me.Shop_salesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Shop_salesBindingNavigatorSaveItem.Image = CType(resources.GetObject("Shop_salesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Shop_salesBindingNavigatorSaveItem.Name = "Shop_salesBindingNavigatorSaveItem"
        Me.Shop_salesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Shop_salesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Sales_IDTextBox
        '
        Me.Sales_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shop_salesBindingSource, "Sales ID", True))
        Me.Sales_IDTextBox.Location = New System.Drawing.Point(108, 60)
        Me.Sales_IDTextBox.Name = "Sales_IDTextBox"
        Me.Sales_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Sales_IDTextBox.TabIndex = 2
        '
        'Sales_dateDateTimePicker
        '
        Me.Sales_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Shop_salesBindingSource, "Sales date", True))
        Me.Sales_dateDateTimePicker.Location = New System.Drawing.Point(108, 86)
        Me.Sales_dateDateTimePicker.Name = "Sales_dateDateTimePicker"
        Me.Sales_dateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Sales_dateDateTimePicker.TabIndex = 4
        '
        'Payment_MethodComboBox
        '
        Me.Payment_MethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shop_salesBindingSource, "Payment Method", True))
        Me.Payment_MethodComboBox.FormattingEnabled = True
        Me.Payment_MethodComboBox.Items.AddRange(New Object() {"M-pesa", "Cash"})
        Me.Payment_MethodComboBox.Location = New System.Drawing.Point(108, 112)
        Me.Payment_MethodComboBox.Name = "Payment_MethodComboBox"
        Me.Payment_MethodComboBox.Size = New System.Drawing.Size(200, 21)
        Me.Payment_MethodComboBox.TabIndex = 6
        '
        'LitresTextBox
        '
        Me.LitresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shop_salesBindingSource, "Litres", True))
        Me.LitresTextBox.Location = New System.Drawing.Point(108, 139)
        Me.LitresTextBox.Name = "LitresTextBox"
        Me.LitresTextBox.Size = New System.Drawing.Size(200, 20)
        Me.LitresTextBox.TabIndex = 8
        '
        'Ksh_per_LitreTextBox
        '
        Me.Ksh_per_LitreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shop_salesBindingSource, "Ksh per Litre", True))
        Me.Ksh_per_LitreTextBox.Location = New System.Drawing.Point(108, 165)
        Me.Ksh_per_LitreTextBox.Name = "Ksh_per_LitreTextBox"
        Me.Ksh_per_LitreTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ksh_per_LitreTextBox.TabIndex = 10
        '
        'Total_amountTextBox
        '
        Me.Total_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Shop_salesBindingSource, "Total amount", True))
        Me.Total_amountTextBox.Location = New System.Drawing.Point(108, 191)
        Me.Total_amountTextBox.Name = "Total_amountTextBox"
        Me.Total_amountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_amountTextBox.TabIndex = 12
        '
        'Shop_salesDataGridView
        '
        Me.Shop_salesDataGridView.AutoGenerateColumns = False
        Me.Shop_salesDataGridView.BackgroundColor = System.Drawing.Color.Azure
        Me.Shop_salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Shop_salesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Shop_salesDataGridView.DataSource = Me.Shop_salesBindingSource
        Me.Shop_salesDataGridView.Location = New System.Drawing.Point(350, 60)
        Me.Shop_salesDataGridView.Name = "Shop_salesDataGridView"
        Me.Shop_salesDataGridView.Size = New System.Drawing.Size(723, 177)
        Me.Shop_salesDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Sales ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Sales ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Sales date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sales date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Payment Method"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Payment Method"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Litres"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Litres"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ksh per Litre"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ksh per Litre"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total amount"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total amount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(466, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Saless
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1085, 615)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Shop_salesDataGridView)
        Me.Controls.Add(Sales_IDLabel)
        Me.Controls.Add(Me.Sales_IDTextBox)
        Me.Controls.Add(Sales_dateLabel)
        Me.Controls.Add(Me.Sales_dateDateTimePicker)
        Me.Controls.Add(Payment_MethodLabel)
        Me.Controls.Add(Me.Payment_MethodComboBox)
        Me.Controls.Add(LitresLabel)
        Me.Controls.Add(Me.LitresTextBox)
        Me.Controls.Add(Ksh_per_LitreLabel)
        Me.Controls.Add(Me.Ksh_per_LitreTextBox)
        Me.Controls.Add(Total_amountLabel)
        Me.Controls.Add(Me.Total_amountTextBox)
        Me.Controls.Add(Me.Shop_salesBindingNavigator)
        Me.Name = "Saless"
        Me.Text = "Saless"
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shop_salesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shop_salesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Shop_salesBindingNavigator.ResumeLayout(False)
        Me.Shop_salesBindingNavigator.PerformLayout()
        CType(Me.Shop_salesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PROJECT_Amani_milk_management_systemDataSet As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet
    Friend WithEvents Shop_salesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Shop_salesTableAdapter As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.Shop_salesTableAdapter
    Friend WithEvents TableAdapterManager As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Shop_salesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Shop_salesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Sales_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sales_dateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Payment_MethodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LitresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ksh_per_LitreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_amountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Shop_salesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

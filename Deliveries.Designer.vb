<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deliveries
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
        Dim DeliveryMan_IDLabel As System.Windows.Forms.Label
        Dim Payment_MethodLabel As System.Windows.Forms.Label
        Dim Delivery_DateLabel As System.Windows.Forms.Label
        Dim Customer_nameLabel As System.Windows.Forms.Label
        Dim Litres_deliveredLabel As System.Windows.Forms.Label
        Dim Customer_idLabel As System.Windows.Forms.Label
        Dim Total_deliveriesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deliveries))
        Me.PROJECT_Amani_milk_management_systemDataSet = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet()
        Me.DeliveriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DeliveriesTableAdapter = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.DeliveriesTableAdapter()
        Me.TableAdapterManager = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.DeliveriesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DeliveriesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DeliveryMan_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_MethodTextBox = New System.Windows.Forms.TextBox()
        Me.Delivery_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Customer_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Litres_deliveredTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_idTextBox = New System.Windows.Forms.TextBox()
        Me.Total_deliveriesTextBox = New System.Windows.Forms.TextBox()
        Me.DeliveriesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btncustomerdetails = New System.Windows.Forms.Button()
        DeliveryMan_IDLabel = New System.Windows.Forms.Label()
        Payment_MethodLabel = New System.Windows.Forms.Label()
        Delivery_DateLabel = New System.Windows.Forms.Label()
        Customer_nameLabel = New System.Windows.Forms.Label()
        Litres_deliveredLabel = New System.Windows.Forms.Label()
        Customer_idLabel = New System.Windows.Forms.Label()
        Total_deliveriesLabel = New System.Windows.Forms.Label()
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DeliveriesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeliveriesBindingNavigator.SuspendLayout()
        CType(Me.DeliveriesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeliveryMan_IDLabel
        '
        DeliveryMan_IDLabel.AutoSize = True
        DeliveryMan_IDLabel.Location = New System.Drawing.Point(8, 71)
        DeliveryMan_IDLabel.Name = "DeliveryMan_IDLabel"
        DeliveryMan_IDLabel.Size = New System.Drawing.Size(86, 13)
        DeliveryMan_IDLabel.TabIndex = 1
        DeliveryMan_IDLabel.Text = "Delivery Man ID:"
        '
        'Payment_MethodLabel
        '
        Payment_MethodLabel.AutoSize = True
        Payment_MethodLabel.Location = New System.Drawing.Point(8, 97)
        Payment_MethodLabel.Name = "Payment_MethodLabel"
        Payment_MethodLabel.Size = New System.Drawing.Size(90, 13)
        Payment_MethodLabel.TabIndex = 3
        Payment_MethodLabel.Text = "Payment Method:"
        '
        'Delivery_DateLabel
        '
        Delivery_DateLabel.AutoSize = True
        Delivery_DateLabel.Location = New System.Drawing.Point(8, 124)
        Delivery_DateLabel.Name = "Delivery_DateLabel"
        Delivery_DateLabel.Size = New System.Drawing.Size(74, 13)
        Delivery_DateLabel.TabIndex = 5
        Delivery_DateLabel.Text = "Delivery Date:"
        '
        'Customer_nameLabel
        '
        Customer_nameLabel.AutoSize = True
        Customer_nameLabel.Location = New System.Drawing.Point(8, 149)
        Customer_nameLabel.Name = "Customer_nameLabel"
        Customer_nameLabel.Size = New System.Drawing.Size(83, 13)
        Customer_nameLabel.TabIndex = 7
        Customer_nameLabel.Text = "Customer name:"
        '
        'Litres_deliveredLabel
        '
        Litres_deliveredLabel.AutoSize = True
        Litres_deliveredLabel.Location = New System.Drawing.Point(8, 175)
        Litres_deliveredLabel.Name = "Litres_deliveredLabel"
        Litres_deliveredLabel.Size = New System.Drawing.Size(81, 13)
        Litres_deliveredLabel.TabIndex = 9
        Litres_deliveredLabel.Text = "Litres delivered:"
        '
        'Customer_idLabel
        '
        Customer_idLabel.AutoSize = True
        Customer_idLabel.Location = New System.Drawing.Point(8, 201)
        Customer_idLabel.Name = "Customer_idLabel"
        Customer_idLabel.Size = New System.Drawing.Size(65, 13)
        Customer_idLabel.TabIndex = 11
        Customer_idLabel.Text = "Customer id:"
        '
        'Total_deliveriesLabel
        '
        Total_deliveriesLabel.AutoSize = True
        Total_deliveriesLabel.Location = New System.Drawing.Point(8, 227)
        Total_deliveriesLabel.Name = "Total_deliveriesLabel"
        Total_deliveriesLabel.Size = New System.Drawing.Size(81, 13)
        Total_deliveriesLabel.TabIndex = 13
        Total_deliveriesLabel.Text = "Total deliveries:"
        '
        'PROJECT_Amani_milk_management_systemDataSet
        '
        Me.PROJECT_Amani_milk_management_systemDataSet.DataSetName = "PROJECT_Amani_milk_management_systemDataSet"
        Me.PROJECT_Amani_milk_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DeliveriesBindingSource
        '
        Me.DeliveriesBindingSource.DataMember = "Deliveries"
        Me.DeliveriesBindingSource.DataSource = Me.PROJECT_Amani_milk_management_systemDataSet
        '
        'DeliveriesTableAdapter
        '
        Me.DeliveriesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.DeliveriesTableAdapter = Me.DeliveriesTableAdapter
        Me.TableAdapterManager.Delivery_MenTableAdapter = Nothing
        Me.TableAdapterManager.Milk_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Shop_salesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DeliveriesBindingNavigator
        '
        Me.DeliveriesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DeliveriesBindingNavigator.BindingSource = Me.DeliveriesBindingSource
        Me.DeliveriesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DeliveriesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DeliveriesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DeliveriesBindingNavigatorSaveItem})
        Me.DeliveriesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DeliveriesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DeliveriesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DeliveriesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DeliveriesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DeliveriesBindingNavigator.Name = "DeliveriesBindingNavigator"
        Me.DeliveriesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DeliveriesBindingNavigator.Size = New System.Drawing.Size(886, 25)
        Me.DeliveriesBindingNavigator.TabIndex = 0
        Me.DeliveriesBindingNavigator.Text = "BindingNavigator1"
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
        'DeliveriesBindingNavigatorSaveItem
        '
        Me.DeliveriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeliveriesBindingNavigatorSaveItem.Image = CType(resources.GetObject("DeliveriesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DeliveriesBindingNavigatorSaveItem.Name = "DeliveriesBindingNavigatorSaveItem"
        Me.DeliveriesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DeliveriesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DeliveryMan_IDTextBox
        '
        Me.DeliveryMan_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveriesBindingSource, "DeliveryMan ID", True))
        Me.DeliveryMan_IDTextBox.Location = New System.Drawing.Point(104, 68)
        Me.DeliveryMan_IDTextBox.Name = "DeliveryMan_IDTextBox"
        Me.DeliveryMan_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DeliveryMan_IDTextBox.TabIndex = 2
        '
        'Payment_MethodTextBox
        '
        Me.Payment_MethodTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveriesBindingSource, "Payment Method", True))
        Me.Payment_MethodTextBox.Location = New System.Drawing.Point(104, 94)
        Me.Payment_MethodTextBox.Name = "Payment_MethodTextBox"
        Me.Payment_MethodTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Payment_MethodTextBox.TabIndex = 4
        '
        'Delivery_DateDateTimePicker
        '
        Me.Delivery_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DeliveriesBindingSource, "Delivery Date", True))
        Me.Delivery_DateDateTimePicker.Location = New System.Drawing.Point(104, 120)
        Me.Delivery_DateDateTimePicker.Name = "Delivery_DateDateTimePicker"
        Me.Delivery_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Delivery_DateDateTimePicker.TabIndex = 6
        '
        'Customer_nameTextBox
        '
        Me.Customer_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveriesBindingSource, "Customer name", True))
        Me.Customer_nameTextBox.Location = New System.Drawing.Point(104, 146)
        Me.Customer_nameTextBox.Name = "Customer_nameTextBox"
        Me.Customer_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Customer_nameTextBox.TabIndex = 8
        '
        'Litres_deliveredTextBox
        '
        Me.Litres_deliveredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveriesBindingSource, "Litres delivered", True))
        Me.Litres_deliveredTextBox.Location = New System.Drawing.Point(104, 172)
        Me.Litres_deliveredTextBox.Name = "Litres_deliveredTextBox"
        Me.Litres_deliveredTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Litres_deliveredTextBox.TabIndex = 10
        '
        'Customer_idTextBox
        '
        Me.Customer_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveriesBindingSource, "Customer id", True))
        Me.Customer_idTextBox.Location = New System.Drawing.Point(104, 198)
        Me.Customer_idTextBox.Name = "Customer_idTextBox"
        Me.Customer_idTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Customer_idTextBox.TabIndex = 12
        '
        'Total_deliveriesTextBox
        '
        Me.Total_deliveriesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DeliveriesBindingSource, "Total deliveries", True))
        Me.Total_deliveriesTextBox.Location = New System.Drawing.Point(104, 224)
        Me.Total_deliveriesTextBox.Name = "Total_deliveriesTextBox"
        Me.Total_deliveriesTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Total_deliveriesTextBox.TabIndex = 14
        '
        'DeliveriesDataGridView
        '
        Me.DeliveriesDataGridView.AutoGenerateColumns = False
        Me.DeliveriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DeliveriesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DeliveriesDataGridView.DataSource = Me.DeliveriesBindingSource
        Me.DeliveriesDataGridView.Location = New System.Drawing.Point(351, 68)
        Me.DeliveriesDataGridView.Name = "DeliveriesDataGridView"
        Me.DeliveriesDataGridView.Size = New System.Drawing.Size(635, 176)
        Me.DeliveriesDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DeliveryMan ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DeliveryMan ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Payment Method"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Payment Method"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Delivery Date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Delivery Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Customer name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Customer name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Litres delivered"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Litres delivered"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Customer id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Customer id"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Total deliveries"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total deliveries"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'btncustomerdetails
        '
        Me.btncustomerdetails.Location = New System.Drawing.Point(528, 285)
        Me.btncustomerdetails.Name = "btncustomerdetails"
        Me.btncustomerdetails.Size = New System.Drawing.Size(75, 37)
        Me.btncustomerdetails.TabIndex = 16
        Me.btncustomerdetails.Text = "Customer Details"
        Me.btncustomerdetails.UseVisualStyleBackColor = True
        '
        'Deliveries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 397)
        Me.Controls.Add(Me.btncustomerdetails)
        Me.Controls.Add(Me.DeliveriesDataGridView)
        Me.Controls.Add(DeliveryMan_IDLabel)
        Me.Controls.Add(Me.DeliveryMan_IDTextBox)
        Me.Controls.Add(Payment_MethodLabel)
        Me.Controls.Add(Me.Payment_MethodTextBox)
        Me.Controls.Add(Delivery_DateLabel)
        Me.Controls.Add(Me.Delivery_DateDateTimePicker)
        Me.Controls.Add(Customer_nameLabel)
        Me.Controls.Add(Me.Customer_nameTextBox)
        Me.Controls.Add(Litres_deliveredLabel)
        Me.Controls.Add(Me.Litres_deliveredTextBox)
        Me.Controls.Add(Customer_idLabel)
        Me.Controls.Add(Me.Customer_idTextBox)
        Me.Controls.Add(Total_deliveriesLabel)
        Me.Controls.Add(Me.Total_deliveriesTextBox)
        Me.Controls.Add(Me.DeliveriesBindingNavigator)
        Me.Name = "Deliveries"
        Me.Text = "Deliveries"
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DeliveriesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeliveriesBindingNavigator.ResumeLayout(False)
        Me.DeliveriesBindingNavigator.PerformLayout()
        CType(Me.DeliveriesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PROJECT_Amani_milk_management_systemDataSet As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet
    Friend WithEvents DeliveriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DeliveriesTableAdapter As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.DeliveriesTableAdapter
    Friend WithEvents TableAdapterManager As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DeliveriesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents DeliveriesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeliveryMan_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Payment_MethodTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Delivery_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Customer_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Litres_deliveredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Total_deliveriesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveriesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btncustomerdetails As System.Windows.Forms.Button
End Class

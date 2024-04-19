<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Deliverymen
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
        Dim DeliveryMan_NameLabel As System.Windows.Forms.Label
        Dim Entry_DateLabel As System.Windows.Forms.Label
        Dim Delivery_addressLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Deliverymen))
        Me.PROJECT_Amani_milk_management_systemDataSet = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet()
        Me.Delivery_MenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Delivery_MenTableAdapter = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.Delivery_MenTableAdapter()
        Me.TableAdapterManager = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Delivery_MenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Delivery_MenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DeliveryMan_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DeliveryMan_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Entry_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Delivery_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Delivery_MenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        DeliveryMan_IDLabel = New System.Windows.Forms.Label()
        DeliveryMan_NameLabel = New System.Windows.Forms.Label()
        Entry_DateLabel = New System.Windows.Forms.Label()
        Delivery_addressLabel = New System.Windows.Forms.Label()
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delivery_MenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Delivery_MenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Delivery_MenBindingNavigator.SuspendLayout()
        CType(Me.Delivery_MenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DeliveryMan_IDLabel
        '
        DeliveryMan_IDLabel.AutoSize = True
        DeliveryMan_IDLabel.Location = New System.Drawing.Point(12, 78)
        DeliveryMan_IDLabel.Name = "DeliveryMan_IDLabel"
        DeliveryMan_IDLabel.Size = New System.Drawing.Size(86, 13)
        DeliveryMan_IDLabel.TabIndex = 1
        DeliveryMan_IDLabel.Text = "Delivery Man ID:"
        '
        'DeliveryMan_NameLabel
        '
        DeliveryMan_NameLabel.AutoSize = True
        DeliveryMan_NameLabel.Location = New System.Drawing.Point(12, 104)
        DeliveryMan_NameLabel.Name = "DeliveryMan_NameLabel"
        DeliveryMan_NameLabel.Size = New System.Drawing.Size(103, 13)
        DeliveryMan_NameLabel.TabIndex = 3
        DeliveryMan_NameLabel.Text = "Delivery Man Name:"
        '
        'Entry_DateLabel
        '
        Entry_DateLabel.AutoSize = True
        Entry_DateLabel.Location = New System.Drawing.Point(12, 131)
        Entry_DateLabel.Name = "Entry_DateLabel"
        Entry_DateLabel.Size = New System.Drawing.Size(60, 13)
        Entry_DateLabel.TabIndex = 5
        Entry_DateLabel.Text = "Entry Date:"
        '
        'Delivery_addressLabel
        '
        Delivery_addressLabel.AutoSize = True
        Delivery_addressLabel.Location = New System.Drawing.Point(12, 156)
        Delivery_addressLabel.Name = "Delivery_addressLabel"
        Delivery_addressLabel.Size = New System.Drawing.Size(88, 13)
        Delivery_addressLabel.TabIndex = 7
        Delivery_addressLabel.Text = "Delivery address:"
        '
        'PROJECT_Amani_milk_management_systemDataSet
        '
        Me.PROJECT_Amani_milk_management_systemDataSet.DataSetName = "PROJECT_Amani_milk_management_systemDataSet"
        Me.PROJECT_Amani_milk_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Delivery_MenBindingSource
        '
        Me.Delivery_MenBindingSource.DataMember = "Delivery Men"
        Me.Delivery_MenBindingSource.DataSource = Me.PROJECT_Amani_milk_management_systemDataSet
        '
        'Delivery_MenTableAdapter
        '
        Me.Delivery_MenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.DeliveriesTableAdapter = Nothing
        Me.TableAdapterManager.Delivery_MenTableAdapter = Me.Delivery_MenTableAdapter
        Me.TableAdapterManager.Milk_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Shop_salesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Delivery_MenBindingNavigator
        '
        Me.Delivery_MenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Delivery_MenBindingNavigator.BindingSource = Me.Delivery_MenBindingSource
        Me.Delivery_MenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Delivery_MenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Delivery_MenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Delivery_MenBindingNavigatorSaveItem})
        Me.Delivery_MenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Delivery_MenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Delivery_MenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Delivery_MenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Delivery_MenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Delivery_MenBindingNavigator.Name = "Delivery_MenBindingNavigator"
        Me.Delivery_MenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Delivery_MenBindingNavigator.Size = New System.Drawing.Size(862, 25)
        Me.Delivery_MenBindingNavigator.TabIndex = 0
        Me.Delivery_MenBindingNavigator.Text = "BindingNavigator1"
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
        'Delivery_MenBindingNavigatorSaveItem
        '
        Me.Delivery_MenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Delivery_MenBindingNavigatorSaveItem.Image = CType(resources.GetObject("Delivery_MenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Delivery_MenBindingNavigatorSaveItem.Name = "Delivery_MenBindingNavigatorSaveItem"
        Me.Delivery_MenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Delivery_MenBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DeliveryMan_IDTextBox
        '
        Me.DeliveryMan_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Delivery_MenBindingSource, "DeliveryMan ID", True))
        Me.DeliveryMan_IDTextBox.Location = New System.Drawing.Point(121, 75)
        Me.DeliveryMan_IDTextBox.Name = "DeliveryMan_IDTextBox"
        Me.DeliveryMan_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DeliveryMan_IDTextBox.TabIndex = 2
        '
        'DeliveryMan_NameTextBox
        '
        Me.DeliveryMan_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Delivery_MenBindingSource, "DeliveryMan Name", True))
        Me.DeliveryMan_NameTextBox.Location = New System.Drawing.Point(121, 101)
        Me.DeliveryMan_NameTextBox.Name = "DeliveryMan_NameTextBox"
        Me.DeliveryMan_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DeliveryMan_NameTextBox.TabIndex = 4
        '
        'Entry_DateDateTimePicker
        '
        Me.Entry_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Delivery_MenBindingSource, "Entry Date", True))
        Me.Entry_DateDateTimePicker.Location = New System.Drawing.Point(121, 127)
        Me.Entry_DateDateTimePicker.Name = "Entry_DateDateTimePicker"
        Me.Entry_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Entry_DateDateTimePicker.TabIndex = 6
        '
        'Delivery_addressTextBox
        '
        Me.Delivery_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Delivery_MenBindingSource, "Delivery address", True))
        Me.Delivery_addressTextBox.Location = New System.Drawing.Point(121, 153)
        Me.Delivery_addressTextBox.Name = "Delivery_addressTextBox"
        Me.Delivery_addressTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Delivery_addressTextBox.TabIndex = 8
        '
        'Delivery_MenDataGridView
        '
        Me.Delivery_MenDataGridView.AutoGenerateColumns = False
        Me.Delivery_MenDataGridView.BackgroundColor = System.Drawing.Color.Azure
        Me.Delivery_MenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Delivery_MenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Delivery_MenDataGridView.DataSource = Me.Delivery_MenBindingSource
        Me.Delivery_MenDataGridView.Location = New System.Drawing.Point(352, 71)
        Me.Delivery_MenDataGridView.Name = "Delivery_MenDataGridView"
        Me.Delivery_MenDataGridView.Size = New System.Drawing.Size(440, 98)
        Me.Delivery_MenDataGridView.TabIndex = 9
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DeliveryMan ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DeliveryMan ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DeliveryMan Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DeliveryMan Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Entry Date"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Entry Date"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Delivery address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Delivery address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.Location = New System.Drawing.Point(476, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Deliverymen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(862, 348)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Delivery_MenDataGridView)
        Me.Controls.Add(DeliveryMan_IDLabel)
        Me.Controls.Add(Me.DeliveryMan_IDTextBox)
        Me.Controls.Add(DeliveryMan_NameLabel)
        Me.Controls.Add(Me.DeliveryMan_NameTextBox)
        Me.Controls.Add(Entry_DateLabel)
        Me.Controls.Add(Me.Entry_DateDateTimePicker)
        Me.Controls.Add(Delivery_addressLabel)
        Me.Controls.Add(Me.Delivery_addressTextBox)
        Me.Controls.Add(Me.Delivery_MenBindingNavigator)
        Me.Name = "Deliverymen"
        Me.Text = "Deliverymen"
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delivery_MenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Delivery_MenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Delivery_MenBindingNavigator.ResumeLayout(False)
        Me.Delivery_MenBindingNavigator.PerformLayout()
        CType(Me.Delivery_MenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROJECT_Amani_milk_management_systemDataSet As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet
    Friend WithEvents Delivery_MenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Delivery_MenTableAdapter As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.Delivery_MenTableAdapter
    Friend WithEvents TableAdapterManager As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Delivery_MenBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Delivery_MenBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeliveryMan_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DeliveryMan_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Entry_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Delivery_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Delivery_MenDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

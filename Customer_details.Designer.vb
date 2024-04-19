<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer_details
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
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim Customer_s_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Contact_NumberLabel As System.Windows.Forms.Label
        Dim Litres_deliveredLabel As System.Windows.Forms.Label
        Dim KshperlitreLabel As System.Windows.Forms.Label
        Dim Payment_MethodLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim Delivery_Man_idLabel As System.Windows.Forms.Label
        Dim DeliveredLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer_details))
        Dim Label1 As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btndeliveries = New System.Windows.Forms.Button()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PROJECT_Amani_milk_management_systemDataSet = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Customer_s_NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressComboBox = New System.Windows.Forms.ComboBox()
        Me.Contact_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Litres_deliveredTextBox = New System.Windows.Forms.TextBox()
        Me.KshperlitreTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_MethodComboBox = New System.Windows.Forms.ComboBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Delivery_Man_idComboBox = New System.Windows.Forms.ComboBox()
        Me.DeliveredCheckBox = New System.Windows.Forms.CheckBox()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.txtdeliveryfee = New System.Windows.Forms.TextBox()
        Me.CustomersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Customer_IDLabel = New System.Windows.Forms.Label()
        Customer_s_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Contact_NumberLabel = New System.Windows.Forms.Label()
        Litres_deliveredLabel = New System.Windows.Forms.Label()
        KshperlitreLabel = New System.Windows.Forms.Label()
        Payment_MethodLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        Delivery_Man_idLabel = New System.Windows.Forms.Label()
        DeliveredLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.Location = New System.Drawing.Point(268, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btndeliveries
        '
        Me.btndeliveries.BackColor = System.Drawing.Color.MistyRose
        Me.btndeliveries.Location = New System.Drawing.Point(434, 352)
        Me.btndeliveries.Name = "btndeliveries"
        Me.btndeliveries.Size = New System.Drawing.Size(75, 23)
        Me.btndeliveries.TabIndex = 43
        Me.btndeliveries.Text = "Deliveries"
        Me.btndeliveries.UseVisualStyleBackColor = False
        '
        'PROJECT_Amani_milk_management_systemDataSet
        '
        Me.PROJECT_Amani_milk_management_systemDataSet.DataSetName = "PROJECT_Amani_milk_management_systemDataSet"
        Me.PROJECT_Amani_milk_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.PROJECT_Amani_milk_management_systemDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.DeliveriesTableAdapter = Nothing
        Me.TableAdapterManager.Delivery_MenTableAdapter = Nothing
        Me.TableAdapterManager.Milk_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Shop_salesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Location = New System.Drawing.Point(12, 34)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(68, 13)
        Customer_IDLabel.TabIndex = 43
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Customer ID", True))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(110, 31)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Customer_IDTextBox.TabIndex = 44
        '
        'Customer_s_NameLabel
        '
        Customer_s_NameLabel.AutoSize = True
        Customer_s_NameLabel.Location = New System.Drawing.Point(12, 60)
        Customer_s_NameLabel.Name = "Customer_s_NameLabel"
        Customer_s_NameLabel.Size = New System.Drawing.Size(92, 13)
        Customer_s_NameLabel.TabIndex = 45
        Customer_s_NameLabel.Text = "Customer's Name:"
        '
        'Customer_s_NameTextBox
        '
        Me.Customer_s_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Customer's Name", True))
        Me.Customer_s_NameTextBox.Location = New System.Drawing.Point(110, 57)
        Me.Customer_s_NameTextBox.Name = "Customer_s_NameTextBox"
        Me.Customer_s_NameTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Customer_s_NameTextBox.TabIndex = 46
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 86)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 47
        AddressLabel.Text = "Address:"
        '
        'AddressComboBox
        '
        Me.AddressComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressComboBox.FormattingEnabled = True
        Me.AddressComboBox.Items.AddRange(New Object() {"Santon", "Zimmerman", "Hunters", "Mwiki", "Seosons"})
        Me.AddressComboBox.Location = New System.Drawing.Point(110, 83)
        Me.AddressComboBox.Name = "AddressComboBox"
        Me.AddressComboBox.Size = New System.Drawing.Size(121, 21)
        Me.AddressComboBox.TabIndex = 48
        '
        'Contact_NumberLabel
        '
        Contact_NumberLabel.AutoSize = True
        Contact_NumberLabel.Location = New System.Drawing.Point(12, 113)
        Contact_NumberLabel.Name = "Contact_NumberLabel"
        Contact_NumberLabel.Size = New System.Drawing.Size(87, 13)
        Contact_NumberLabel.TabIndex = 49
        Contact_NumberLabel.Text = "Contact Number:"
        '
        'Contact_NumberTextBox
        '
        Me.Contact_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Contact Number", True))
        Me.Contact_NumberTextBox.Location = New System.Drawing.Point(110, 110)
        Me.Contact_NumberTextBox.Name = "Contact_NumberTextBox"
        Me.Contact_NumberTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Contact_NumberTextBox.TabIndex = 50
        '
        'Litres_deliveredLabel
        '
        Litres_deliveredLabel.AutoSize = True
        Litres_deliveredLabel.Location = New System.Drawing.Point(12, 139)
        Litres_deliveredLabel.Name = "Litres_deliveredLabel"
        Litres_deliveredLabel.Size = New System.Drawing.Size(81, 13)
        Litres_deliveredLabel.TabIndex = 51
        Litres_deliveredLabel.Text = "Litres delivered:"
        '
        'Litres_deliveredTextBox
        '
        Me.Litres_deliveredTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Litres delivered", True))
        Me.Litres_deliveredTextBox.Location = New System.Drawing.Point(110, 136)
        Me.Litres_deliveredTextBox.Name = "Litres_deliveredTextBox"
        Me.Litres_deliveredTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Litres_deliveredTextBox.TabIndex = 52
        '
        'KshperlitreLabel
        '
        KshperlitreLabel.AutoSize = True
        KshperlitreLabel.Location = New System.Drawing.Point(12, 165)
        KshperlitreLabel.Name = "KshperlitreLabel"
        KshperlitreLabel.Size = New System.Drawing.Size(59, 13)
        KshperlitreLabel.TabIndex = 53
        KshperlitreLabel.Text = "Kshperlitre:"
        '
        'KshperlitreTextBox
        '
        Me.KshperlitreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Kshperlitre", True))
        Me.KshperlitreTextBox.Location = New System.Drawing.Point(110, 162)
        Me.KshperlitreTextBox.Name = "KshperlitreTextBox"
        Me.KshperlitreTextBox.Size = New System.Drawing.Size(121, 20)
        Me.KshperlitreTextBox.TabIndex = 54
        '
        'Payment_MethodLabel
        '
        Payment_MethodLabel.AutoSize = True
        Payment_MethodLabel.Location = New System.Drawing.Point(12, 191)
        Payment_MethodLabel.Name = "Payment_MethodLabel"
        Payment_MethodLabel.Size = New System.Drawing.Size(90, 13)
        Payment_MethodLabel.TabIndex = 55
        Payment_MethodLabel.Text = "Payment Method:"
        '
        'Payment_MethodComboBox
        '
        Me.Payment_MethodComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Payment Method", True))
        Me.Payment_MethodComboBox.FormattingEnabled = True
        Me.Payment_MethodComboBox.Items.AddRange(New Object() {"M-pesa", "Cash"})
        Me.Payment_MethodComboBox.Location = New System.Drawing.Point(110, 188)
        Me.Payment_MethodComboBox.Name = "Payment_MethodComboBox"
        Me.Payment_MethodComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Payment_MethodComboBox.TabIndex = 56
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(12, 218)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(34, 13)
        TotalLabel.TabIndex = 57
        TotalLabel.Text = "Total:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(110, 215)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(121, 20)
        Me.TotalTextBox.TabIndex = 58
        '
        'Delivery_Man_idLabel
        '
        Delivery_Man_idLabel.AutoSize = True
        Delivery_Man_idLabel.Location = New System.Drawing.Point(12, 244)
        Delivery_Man_idLabel.Name = "Delivery_Man_idLabel"
        Delivery_Man_idLabel.Size = New System.Drawing.Size(83, 13)
        Delivery_Man_idLabel.TabIndex = 59
        Delivery_Man_idLabel.Text = "Delivery Man id:"
        '
        'Delivery_Man_idComboBox
        '
        Me.Delivery_Man_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Delivery Man id", True))
        Me.Delivery_Man_idComboBox.FormattingEnabled = True
        Me.Delivery_Man_idComboBox.Items.AddRange(New Object() {"John Kamau 4567", "Peter muli 9876", "Daniel Njoroge 5566", "Stanley Kamau 78976", "Brian Maina 10102"})
        Me.Delivery_Man_idComboBox.Location = New System.Drawing.Point(110, 241)
        Me.Delivery_Man_idComboBox.Name = "Delivery_Man_idComboBox"
        Me.Delivery_Man_idComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Delivery_Man_idComboBox.TabIndex = 60
        '
        'DeliveredLabel
        '
        DeliveredLabel.AutoSize = True
        DeliveredLabel.Location = New System.Drawing.Point(12, 300)
        DeliveredLabel.Name = "DeliveredLabel"
        DeliveredLabel.Size = New System.Drawing.Size(55, 13)
        DeliveredLabel.TabIndex = 61
        DeliveredLabel.Text = "Delivered:"
        '
        'DeliveredCheckBox
        '
        Me.DeliveredCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.CustomersBindingSource, "Delivered", True))
        Me.DeliveredCheckBox.Location = New System.Drawing.Point(110, 295)
        Me.DeliveredCheckBox.Name = "DeliveredCheckBox"
        Me.DeliveredCheckBox.Size = New System.Drawing.Size(121, 24)
        Me.DeliveredCheckBox.TabIndex = 62
        Me.DeliveredCheckBox.Text = "CheckBox1"
        Me.DeliveredCheckBox.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(826, 25)
        Me.BindingNavigator1.TabIndex = 63
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 272)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(63, 13)
        Label1.TabIndex = 64
        Label1.Text = "Delivery fee"
        '
        'txtdeliveryfee
        '
        Me.txtdeliveryfee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Total", True))
        Me.txtdeliveryfee.Location = New System.Drawing.Point(110, 269)
        Me.txtdeliveryfee.Name = "txtdeliveryfee"
        Me.txtdeliveryfee.Size = New System.Drawing.Size(121, 20)
        Me.txtdeliveryfee.TabIndex = 65
        '
        'CustomersDataGridView
        '
        Me.CustomersDataGridView.AutoGenerateColumns = False
        Me.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewCheckBoxColumn2})
        Me.CustomersDataGridView.DataSource = Me.CustomersBindingSource
        Me.CustomersDataGridView.Location = New System.Drawing.Point(268, 31)
        Me.CustomersDataGridView.Name = "CustomersDataGridView"
        Me.CustomersDataGridView.Size = New System.Drawing.Size(433, 316)
        Me.CustomersDataGridView.TabIndex = 65
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Customer ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Customer's Name"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Customer's Name"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Contact Number"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Contact Number"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Litres delivered"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Litres delivered"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Kshperlitre"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Kshperlitre"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Payment Method"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Payment Method"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Delivery Man id"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Delivery Man id"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Delivered"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Delivered"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.MistyRose
        Me.btnsave.Location = New System.Drawing.Point(268, 385)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 66
        Me.btnsave.Text = "save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MistyRose
        Me.Button2.Location = New System.Drawing.Point(434, 385)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "Add new"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MistyRose
        Me.Button3.Location = New System.Drawing.Point(548, 385)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 68
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Customer_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(826, 749)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.CustomersDataGridView)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtdeliveryfee)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Me.Customer_IDTextBox)
        Me.Controls.Add(Customer_s_NameLabel)
        Me.Controls.Add(Me.Customer_s_NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressComboBox)
        Me.Controls.Add(Contact_NumberLabel)
        Me.Controls.Add(Me.Contact_NumberTextBox)
        Me.Controls.Add(Litres_deliveredLabel)
        Me.Controls.Add(Me.Litres_deliveredTextBox)
        Me.Controls.Add(KshperlitreLabel)
        Me.Controls.Add(Me.KshperlitreTextBox)
        Me.Controls.Add(Payment_MethodLabel)
        Me.Controls.Add(Me.Payment_MethodComboBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Delivery_Man_idLabel)
        Me.Controls.Add(Me.Delivery_Man_idComboBox)
        Me.Controls.Add(DeliveredLabel)
        Me.Controls.Add(Me.DeliveredCheckBox)
        Me.Controls.Add(Me.btndeliveries)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Customer_details"
        Me.Text = "Customer_details"
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.CustomersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btndeliveries As System.Windows.Forms.Button
    Friend WithEvents CustomersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PROJECT_Amani_milk_management_systemDataSet As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Customer_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Customer_s_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Contact_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Litres_deliveredTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KshperlitreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Payment_MethodComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Delivery_Man_idComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DeliveredCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents txtdeliveryfee As System.Windows.Forms.TextBox
    Friend WithEvents CustomersDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Milk_Inventory
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
        Dim Litres_AvailableLabel As System.Windows.Forms.Label
        Dim SumOfAmount_SuppliedLabel As System.Windows.Forms.Label
        Dim SumOfLitresLabel As System.Windows.Forms.Label
        Dim SumOfLitres_deliveredLabel As System.Windows.Forms.Label
        Me.btnback = New System.Windows.Forms.Button()
        Me.PROJECT_Amani_milk_management_systemDataSet = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Litres_AvailableLabel1 = New System.Windows.Forms.Label()
        Me.SumOfAmount_SuppliedLabel1 = New System.Windows.Forms.Label()
        Me.SumOfLitresLabel1 = New System.Windows.Forms.Label()
        Me.SumOfLitres_deliveredLabel1 = New System.Windows.Forms.Label()
        Litres_AvailableLabel = New System.Windows.Forms.Label()
        SumOfAmount_SuppliedLabel = New System.Windows.Forms.Label()
        SumOfLitresLabel = New System.Windows.Forms.Label()
        SumOfLitres_deliveredLabel = New System.Windows.Forms.Label()
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(188, 209)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(75, 23)
        Me.btnback.TabIndex = 9
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'PROJECT_Amani_milk_management_systemDataSet
        '
        Me.PROJECT_Amani_milk_management_systemDataSet.DataSetName = "PROJECT_Amani_milk_management_systemDataSet"
        Me.PROJECT_Amani_milk_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.PROJECT_Amani_milk_management_systemDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.DeliveriesTableAdapter = Nothing
        Me.TableAdapterManager.Delivery_MenTableAdapter = Nothing
        Me.TableAdapterManager.Milk_InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Shop_salesTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Litres_AvailableLabel1
        '
        Me.Litres_AvailableLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Litres Available", True))
        Me.Litres_AvailableLabel1.Location = New System.Drawing.Point(157, 144)
        Me.Litres_AvailableLabel1.Name = "Litres_AvailableLabel1"
        Me.Litres_AvailableLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Litres_AvailableLabel1.TabIndex = 17
        Me.Litres_AvailableLabel1.Text = "Label1"
        '
        'Litres_AvailableLabel
        '
        Litres_AvailableLabel.AutoSize = True
        Litres_AvailableLabel.Location = New System.Drawing.Point(23, 144)
        Litres_AvailableLabel.Name = "Litres_AvailableLabel"
        Litres_AvailableLabel.Size = New System.Drawing.Size(81, 13)
        Litres_AvailableLabel.TabIndex = 16
        Litres_AvailableLabel.Text = "Litres Available:"
        '
        'SumOfAmount_SuppliedLabel1
        '
        Me.SumOfAmount_SuppliedLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "SumOfAmount Supplied", True))
        Me.SumOfAmount_SuppliedLabel1.Location = New System.Drawing.Point(157, 121)
        Me.SumOfAmount_SuppliedLabel1.Name = "SumOfAmount_SuppliedLabel1"
        Me.SumOfAmount_SuppliedLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SumOfAmount_SuppliedLabel1.TabIndex = 15
        Me.SumOfAmount_SuppliedLabel1.Text = "Label1"
        '
        'SumOfAmount_SuppliedLabel
        '
        SumOfAmount_SuppliedLabel.AutoSize = True
        SumOfAmount_SuppliedLabel.Location = New System.Drawing.Point(23, 121)
        SumOfAmount_SuppliedLabel.Name = "SumOfAmount_SuppliedLabel"
        SumOfAmount_SuppliedLabel.Size = New System.Drawing.Size(128, 13)
        SumOfAmount_SuppliedLabel.TabIndex = 14
        SumOfAmount_SuppliedLabel.Text = "Sum Of Amount Supplied:"
        '
        'SumOfLitresLabel1
        '
        Me.SumOfLitresLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "SumOfLitres", True))
        Me.SumOfLitresLabel1.Location = New System.Drawing.Point(157, 98)
        Me.SumOfLitresLabel1.Name = "SumOfLitresLabel1"
        Me.SumOfLitresLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SumOfLitresLabel1.TabIndex = 13
        Me.SumOfLitresLabel1.Text = "Label1"
        '
        'SumOfLitresLabel
        '
        SumOfLitresLabel.AutoSize = True
        SumOfLitresLabel.Location = New System.Drawing.Point(23, 98)
        SumOfLitresLabel.Name = "SumOfLitresLabel"
        SumOfLitresLabel.Size = New System.Drawing.Size(73, 13)
        SumOfLitresLabel.TabIndex = 12
        SumOfLitresLabel.Text = "Sum Of Litres:"
        '
        'SumOfLitres_deliveredLabel1
        '
        Me.SumOfLitres_deliveredLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "SumOfLitres delivered", True))
        Me.SumOfLitres_deliveredLabel1.Location = New System.Drawing.Point(157, 75)
        Me.SumOfLitres_deliveredLabel1.Name = "SumOfLitres_deliveredLabel1"
        Me.SumOfLitres_deliveredLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SumOfLitres_deliveredLabel1.TabIndex = 11
        Me.SumOfLitres_deliveredLabel1.Text = "Label1"
        '
        'SumOfLitres_deliveredLabel
        '
        SumOfLitres_deliveredLabel.AutoSize = True
        SumOfLitres_deliveredLabel.Location = New System.Drawing.Point(23, 75)
        SumOfLitres_deliveredLabel.Name = "SumOfLitres_deliveredLabel"
        SumOfLitres_deliveredLabel.Size = New System.Drawing.Size(119, 13)
        SumOfLitres_deliveredLabel.TabIndex = 10
        SumOfLitres_deliveredLabel.Text = "Sum Of Litres delivered:"
        '
        'Milk_Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(526, 259)
        Me.Controls.Add(SumOfLitres_deliveredLabel)
        Me.Controls.Add(Me.SumOfLitres_deliveredLabel1)
        Me.Controls.Add(SumOfLitresLabel)
        Me.Controls.Add(Me.SumOfLitresLabel1)
        Me.Controls.Add(SumOfAmount_SuppliedLabel)
        Me.Controls.Add(Me.SumOfAmount_SuppliedLabel1)
        Me.Controls.Add(Litres_AvailableLabel)
        Me.Controls.Add(Me.Litres_AvailableLabel1)
        Me.Controls.Add(Me.btnback)
        Me.Name = "Milk_Inventory"
        Me.Text = "Milk_Inventory"
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents PROJECT_Amani_milk_management_systemDataSet As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet
    Friend WithEvents InventoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InventoryTableAdapter As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Litres_AvailableLabel1 As System.Windows.Forms.Label
    Friend WithEvents SumOfAmount_SuppliedLabel1 As System.Windows.Forms.Label
    Friend WithEvents SumOfLitresLabel1 As System.Windows.Forms.Label
    Friend WithEvents SumOfLitres_deliveredLabel1 As System.Windows.Forms.Label
End Class

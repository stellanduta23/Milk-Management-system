<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accounts
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
        Dim SumOfTotal1Label As System.Windows.Forms.Label
        Dim CashLabel As System.Windows.Forms.Label
        Dim SumOfTotal_amountLabel As System.Windows.Forms.Label
        Dim SumOfTotalLabel As System.Windows.Forms.Label
        Me.PROJECT_Amani_milk_management_systemDataSet = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsTableAdapter = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.AccountsTableAdapter()
        Me.TableAdapterManager = New PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.SumOfTotal1Label1 = New System.Windows.Forms.Label()
        Me.CashLabel1 = New System.Windows.Forms.Label()
        Me.SumOfTotal_amountLabel1 = New System.Windows.Forms.Label()
        Me.SumOfTotalLabel1 = New System.Windows.Forms.Label()
        SumOfTotal1Label = New System.Windows.Forms.Label()
        CashLabel = New System.Windows.Forms.Label()
        SumOfTotal_amountLabel = New System.Windows.Forms.Label()
        SumOfTotalLabel = New System.Windows.Forms.Label()
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PROJECT_Amani_milk_management_systemDataSet
        '
        Me.PROJECT_Amani_milk_management_systemDataSet.DataSetName = "PROJECT_Amani_milk_management_systemDataSet"
        Me.PROJECT_Amani_milk_management_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.PROJECT_Amani_milk_management_systemDataSet
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.Location = New System.Drawing.Point(312, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 31)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(495, 295)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(106, 29)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(251, 154)
        '
        'SumOfTotal1Label1
        '
        Me.SumOfTotal1Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "SumOfTotal1", True))
        Me.SumOfTotal1Label1.Location = New System.Drawing.Point(237, 125)
        Me.SumOfTotal1Label1.Name = "SumOfTotal1Label1"
        Me.SumOfTotal1Label1.Size = New System.Drawing.Size(69, 23)
        Me.SumOfTotal1Label1.TabIndex = 8
        Me.SumOfTotal1Label1.Text = "Label1"
        '
        'SumOfTotal1Label
        '
        SumOfTotal1Label.AutoSize = True
        SumOfTotal1Label.Location = New System.Drawing.Point(131, 125)
        SumOfTotal1Label.Name = "SumOfTotal1Label"
        SumOfTotal1Label.Size = New System.Drawing.Size(89, 13)
        SumOfTotal1Label.TabIndex = 7
        SumOfTotal1Label.Text = "Paid to Suppliers:"
        AddHandler SumOfTotal1Label.Click, AddressOf Me.SumOfTotal1Label_Click
        '
        'CashLabel1
        '
        Me.CashLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "cash", True))
        Me.CashLabel1.Location = New System.Drawing.Point(247, 94)
        Me.CashLabel1.Name = "CashLabel1"
        Me.CashLabel1.Size = New System.Drawing.Size(100, 23)
        Me.CashLabel1.TabIndex = 6
        Me.CashLabel1.Text = "Label1"
        '
        'CashLabel
        '
        CashLabel.AutoSize = True
        CashLabel.Location = New System.Drawing.Point(131, 94)
        CashLabel.Name = "CashLabel"
        CashLabel.Size = New System.Drawing.Size(34, 13)
        CashLabel.TabIndex = 5
        CashLabel.Text = "Total:"
        '
        'SumOfTotal_amountLabel1
        '
        Me.SumOfTotal_amountLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "SumOfTotal amount", True))
        Me.SumOfTotal_amountLabel1.Location = New System.Drawing.Point(247, 71)
        Me.SumOfTotal_amountLabel1.Name = "SumOfTotal_amountLabel1"
        Me.SumOfTotal_amountLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SumOfTotal_amountLabel1.TabIndex = 4
        Me.SumOfTotal_amountLabel1.Text = "Label1"
        '
        'SumOfTotal_amountLabel
        '
        SumOfTotal_amountLabel.AutoSize = True
        SumOfTotal_amountLabel.Location = New System.Drawing.Point(131, 71)
        SumOfTotal_amountLabel.Name = "SumOfTotal_amountLabel"
        SumOfTotal_amountLabel.Size = New System.Drawing.Size(107, 13)
        SumOfTotal_amountLabel.TabIndex = 3
        SumOfTotal_amountLabel.Text = "Shop Sales Account:"
        '
        'SumOfTotalLabel1
        '
        Me.SumOfTotalLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "SumOfTotal", True))
        Me.SumOfTotalLabel1.Location = New System.Drawing.Point(247, 48)
        Me.SumOfTotalLabel1.Name = "SumOfTotalLabel1"
        Me.SumOfTotalLabel1.Size = New System.Drawing.Size(100, 23)
        Me.SumOfTotalLabel1.TabIndex = 2
        Me.SumOfTotalLabel1.Text = "Label1"
        '
        'SumOfTotalLabel
        '
        SumOfTotalLabel.AutoSize = True
        SumOfTotalLabel.Location = New System.Drawing.Point(131, 48)
        SumOfTotalLabel.Name = "SumOfTotalLabel"
        SumOfTotalLabel.Size = New System.Drawing.Size(91, 13)
        SumOfTotalLabel.TabIndex = 1
        SumOfTotalLabel.Text = "Delivery Account:"
        '
        'Accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(495, 295)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(SumOfTotalLabel)
        Me.Controls.Add(Me.SumOfTotalLabel1)
        Me.Controls.Add(SumOfTotal_amountLabel)
        Me.Controls.Add(Me.SumOfTotal_amountLabel1)
        Me.Controls.Add(CashLabel)
        Me.Controls.Add(Me.CashLabel1)
        Me.Controls.Add(SumOfTotal1Label)
        Me.Controls.Add(Me.SumOfTotal1Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Accounts"
        Me.Text = "Accounts"
        CType(Me.PROJECT_Amani_milk_management_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PROJECT_Amani_milk_management_systemDataSet As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSet
    Friend WithEvents AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountsTableAdapter As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.AccountsTableAdapter
    Friend WithEvents TableAdapterManager As PROJECT_Amani_Milk_Mangement_System.PROJECT_Amani_milk_management_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents SumOfTotal1Label1 As System.Windows.Forms.Label
    Friend WithEvents CashLabel1 As System.Windows.Forms.Label
    Friend WithEvents SumOfTotal_amountLabel1 As System.Windows.Forms.Label
    Friend WithEvents SumOfTotalLabel1 As System.Windows.Forms.Label
End Class

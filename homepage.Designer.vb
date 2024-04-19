<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.Btncustomers = New System.Windows.Forms.Button()
        Me.Btnmilkinventory = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnaccounts = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btncustomers
        '
        Me.Btncustomers.BackColor = System.Drawing.Color.LightCyan
        Me.Btncustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btncustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncustomers.Location = New System.Drawing.Point(88, 96)
        Me.Btncustomers.Margin = New System.Windows.Forms.Padding(5)
        Me.Btncustomers.Name = "Btncustomers"
        Me.Btncustomers.Size = New System.Drawing.Size(127, 62)
        Me.Btncustomers.TabIndex = 0
        Me.Btncustomers.Text = "Customers"
        Me.Btncustomers.UseVisualStyleBackColor = False
        '
        'Btnmilkinventory
        '
        Me.Btnmilkinventory.BackColor = System.Drawing.Color.LightCyan
        Me.Btnmilkinventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnmilkinventory.Location = New System.Drawing.Point(88, 283)
        Me.Btnmilkinventory.Margin = New System.Windows.Forms.Padding(5)
        Me.Btnmilkinventory.Name = "Btnmilkinventory"
        Me.Btnmilkinventory.Size = New System.Drawing.Size(127, 62)
        Me.Btnmilkinventory.TabIndex = 1
        Me.Btnmilkinventory.Text = "Milk Inventory"
        Me.Btnmilkinventory.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightCyan
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(304, 96)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 63)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Sales"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightCyan
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(304, 190)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 62)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Suppliers"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightCyan
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(88, 195)
        Me.Button6.Margin = New System.Windows.Forms.Padding(5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 57)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Delivery Men"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(139, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome to Amani milk supply management system"
        '
        'btnaccounts
        '
        Me.btnaccounts.BackColor = System.Drawing.Color.LightCyan
        Me.btnaccounts.Location = New System.Drawing.Point(304, 283)
        Me.btnaccounts.Name = "btnaccounts"
        Me.btnaccounts.Size = New System.Drawing.Size(137, 62)
        Me.btnaccounts.TabIndex = 7
        Me.btnaccounts.Text = "Accounts"
        Me.btnaccounts.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.Location = New System.Drawing.Point(516, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 62)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Deliveries"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'homepage
        '
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 740)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnaccounts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Btnmilkinventory)
        Me.Controls.Add(Me.Btncustomers)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "homepage"
        Me.Text = "homepage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btncustomers As System.Windows.Forms.Button
    Friend WithEvents Btnmilkinventory As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnaccounts As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

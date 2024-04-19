<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delivery_Men
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtnames = New System.Windows.Forms.TextBox()
        Me.Txtdeliverymenid = New System.Windows.Forms.TextBox()
        Me.Txtentrydate = New System.Windows.Forms.TextBox()
        Me.Txtdeliveryaddress = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Delivery Men"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Names"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Deliverymen ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Entry Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Delivery Address"
        '
        'Txtnames
        '
        Me.Txtnames.Location = New System.Drawing.Point(139, 73)
        Me.Txtnames.Name = "Txtnames"
        Me.Txtnames.Size = New System.Drawing.Size(100, 20)
        Me.Txtnames.TabIndex = 5
        '
        'Txtdeliverymenid
        '
        Me.Txtdeliverymenid.Location = New System.Drawing.Point(139, 113)
        Me.Txtdeliverymenid.Name = "Txtdeliverymenid"
        Me.Txtdeliverymenid.Size = New System.Drawing.Size(100, 20)
        Me.Txtdeliverymenid.TabIndex = 6
        '
        'Txtentrydate
        '
        Me.Txtentrydate.Location = New System.Drawing.Point(139, 166)
        Me.Txtentrydate.Name = "Txtentrydate"
        Me.Txtentrydate.Size = New System.Drawing.Size(100, 20)
        Me.Txtentrydate.TabIndex = 7
        '
        'Txtdeliveryaddress
        '
        Me.Txtdeliveryaddress.Location = New System.Drawing.Point(139, 211)
        Me.Txtdeliveryaddress.Name = "Txtdeliveryaddress"
        Me.Txtdeliveryaddress.Size = New System.Drawing.Size(100, 20)
        Me.Txtdeliveryaddress.TabIndex = 8
        '
        'Delivery_Men
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 504)
        Me.Controls.Add(Me.Txtdeliveryaddress)
        Me.Controls.Add(Me.Txtentrydate)
        Me.Controls.Add(Me.Txtdeliverymenid)
        Me.Controls.Add(Me.Txtnames)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Delivery_Men"
        Me.Text = "Delivery_Men"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtnames As System.Windows.Forms.TextBox
    Friend WithEvents Txtdeliverymenid As System.Windows.Forms.TextBox
    Friend WithEvents Txtentrydate As System.Windows.Forms.TextBox
    Friend WithEvents Txtdeliveryaddress As System.Windows.Forms.TextBox
End Class

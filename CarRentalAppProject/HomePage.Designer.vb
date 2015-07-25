<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateRentalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustumersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(197, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Maverick Car Rental Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(247, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "We get you there fast"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RentalToolStripMenuItem, Me.CustumersToolStripMenuItem, Me.InventoryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(730, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'RentalToolStripMenuItem
        '
        Me.RentalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewRentalToolStripMenuItem, Me.UpdateRentalToolStripMenuItem})
        Me.RentalToolStripMenuItem.Name = "RentalToolStripMenuItem"
        Me.RentalToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.RentalToolStripMenuItem.Text = "Rental"
        '
        'NewRentalToolStripMenuItem
        '
        Me.NewRentalToolStripMenuItem.Name = "NewRentalToolStripMenuItem"
        Me.NewRentalToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NewRentalToolStripMenuItem.Text = "New Rental"
        '
        'UpdateRentalToolStripMenuItem
        '
        Me.UpdateRentalToolStripMenuItem.Name = "UpdateRentalToolStripMenuItem"
        Me.UpdateRentalToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.UpdateRentalToolStripMenuItem.Text = "Search Rental"
        '
        'CustumersToolStripMenuItem
        '
        Me.CustumersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateCustomerToolStripMenuItem})
        Me.CustumersToolStripMenuItem.Name = "CustumersToolStripMenuItem"
        Me.CustumersToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.CustumersToolStripMenuItem.Text = "Customers"
        '
        'UpdateCustomerToolStripMenuItem
        '
        Me.UpdateCustomerToolStripMenuItem.Name = "UpdateCustomerToolStripMenuItem"
        Me.UpdateCustomerToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.UpdateCustomerToolStripMenuItem.Text = "Update Customer"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateInventoryToolStripMenuItem, Me.SearchInventoryToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'UpdateInventoryToolStripMenuItem
        '
        Me.UpdateInventoryToolStripMenuItem.Name = "UpdateInventoryToolStripMenuItem"
        Me.UpdateInventoryToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.UpdateInventoryToolStripMenuItem.Text = "Update Inventory"
        '
        'SearchInventoryToolStripMenuItem
        '
        Me.SearchInventoryToolStripMenuItem.Name = "SearchInventoryToolStripMenuItem"
        Me.SearchInventoryToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SearchInventoryToolStripMenuItem.Text = "Search Inventory"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CarRentalAppProject.My.Resources.Resources.Car
        Me.PictureBox1.Location = New System.Drawing.Point(185, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 306)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 509)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateRentalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustumersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

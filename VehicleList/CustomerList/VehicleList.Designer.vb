<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleList
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbxModel = New System.Windows.Forms.TextBox()
        Me.tbxYear = New System.Windows.Forms.TextBox()
        Me.cmbMakes = New System.Windows.Forms.ComboBox()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwVehicles = New System.Windows.Forms.ListView()
        Me.clhNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clhPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.VehicleToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.tbxPrice = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(127, 519)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.VehicleToolTip.SetToolTip(Me.btnEnter, "Click to add a customer.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(235, 519)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.VehicleToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(343, 519)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.VehicleToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbxModel
        '
        Me.tbxModel.Location = New System.Drawing.Point(112, 42)
        Me.tbxModel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxModel.Name = "tbxModel"
        Me.tbxModel.Size = New System.Drawing.Size(160, 22)
        Me.tbxModel.TabIndex = 3
        Me.VehicleToolTip.SetToolTip(Me.tbxModel, "Type the customer's first name here.")
        '
        'tbxYear
        '
        Me.tbxYear.Location = New System.Drawing.Point(112, 74)
        Me.tbxYear.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxYear.Name = "tbxYear"
        Me.tbxYear.Size = New System.Drawing.Size(160, 22)
        Me.tbxYear.TabIndex = 5
        Me.VehicleToolTip.SetToolTip(Me.tbxYear, "Type the customer's last name here.")
        '
        'cmbMakes
        '
        Me.cmbMakes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMakes.FormattingEnabled = True
        Me.cmbMakes.Items.AddRange(New Object() {"Chevy", "Ford", "Kia", "Honda", "Hyundai", "Mercedes", "Toyota", "Volkswagen", "Other"})
        Me.cmbMakes.Location = New System.Drawing.Point(112, 9)
        Me.cmbMakes.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMakes.Name = "cmbMakes"
        Me.cmbMakes.Size = New System.Drawing.Size(160, 24)
        Me.cmbMakes.TabIndex = 1
        Me.VehicleToolTip.SetToolTip(Me.cmbMakes, "Select the customer's title.")
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(16, 9)
        Me.lblMake.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(88, 16)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make: "
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(16, 42)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(88, 16)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel: "
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblModel.UseWaitCursor = True
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(16, 78)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(88, 16)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year: "
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(280, 72)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(61, 30)
        Me.chkNew.TabIndex = 6
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.VehicleToolTip.SetToolTip(Me.chkNew, "Check to make the customer a VIP.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwVehicles
        '
        Me.lvwVehicles.CheckBoxes = True
        Me.lvwVehicles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clhNew, Me.clhID, Me.clhMake, Me.clhModel, Me.clhYear, Me.clhPrice})
        Me.lvwVehicles.FullRowSelect = True
        Me.lvwVehicles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwVehicles.Location = New System.Drawing.Point(3, 133)
        Me.lvwVehicles.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwVehicles.MultiSelect = False
        Me.lvwVehicles.Name = "lvwVehicles"
        Me.lvwVehicles.Size = New System.Drawing.Size(439, 302)
        Me.lvwVehicles.TabIndex = 9
        Me.VehicleToolTip.SetToolTip(Me.lvwVehicles, "Select a customer to modify.")
        Me.lvwVehicles.UseCompatibleStateImageBehavior = False
        Me.lvwVehicles.View = System.Windows.Forms.View.Details
        '
        'clhNew
        '
        Me.clhNew.Text = "New"
        Me.clhNew.Width = 40
        '
        'clhID
        '
        Me.clhID.Text = "ID"
        '
        'clhMake
        '
        Me.clhMake.Text = "Make"
        Me.clhMake.Width = 100
        '
        'clhModel
        '
        Me.clhModel.Text = "Model"
        Me.clhModel.Width = 100
        '
        'clhYear
        '
        Me.clhYear.Text = "Year"
        '
        'clhPrice
        '
        Me.clhPrice.Text = "Price"
        Me.clhPrice.Width = 70
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(3, 439)
        Me.lbResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(440, 74)
        Me.lbResult.TabIndex = 10
        Me.VehicleToolTip.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(16, 108)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(88, 16)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "&Price: "
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbxPrice
        '
        Me.tbxPrice.Location = New System.Drawing.Point(112, 104)
        Me.tbxPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxPrice.Name = "tbxPrice"
        Me.tbxPrice.Size = New System.Drawing.Size(160, 22)
        Me.tbxPrice.TabIndex = 8
        Me.VehicleToolTip.SetToolTip(Me.tbxPrice, "Type the customer's last name here.")
        '
        'frmVehicleList
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(445, 556)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.tbxPrice)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwVehicles)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.cmbMakes)
        Me.Controls.Add(Me.tbxYear)
        Me.Controls.Add(Me.tbxModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVehicleList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehcile List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbxModel As TextBox
    Friend WithEvents tbxYear As TextBox
    Friend WithEvents cmbMakes As ComboBox
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwVehicles As ListView
    Friend WithEvents VehicleToolTip As ToolTip
    Friend WithEvents lbResult As Label
    Friend WithEvents clhNew As ColumnHeader
    Friend WithEvents clhID As ColumnHeader
    Friend WithEvents clhMake As ColumnHeader
    Friend WithEvents clhModel As ColumnHeader
    Friend WithEvents clhYear As ColumnHeader
    Friend WithEvents clhPrice As ColumnHeader
    Friend WithEvents lblPrice As Label
    Friend WithEvents tbxPrice As TextBox
End Class

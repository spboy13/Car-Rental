<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fillupForm
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim License_IDLabel As System.Windows.Forms.Label
        Dim Contact__Label As System.Windows.Forms.Label
        Dim Vehicle_modelLabel As System.Windows.Forms.Label
        Dim Vehicle_Reg___Label As System.Windows.Forms.Label
        Dim Rental_Fee_per_DayLabel As System.Windows.Forms.Label
        Dim Collect_DateLabel As System.Windows.Forms.Label
        Dim Return_DateLabel As System.Windows.Forms.Label
        Dim No__of_DaysLabel As System.Windows.Forms.Label
        Dim Rental_AmountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fillupForm))
        Me.Database1DataSet1 = New practice_4.Database1DataSet1()
        Me.Fill_Up_FormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Fill_Up_FormTableAdapter = New practice_4.Database1DataSet1TableAdapters.Fill_Up_FormTableAdapter()
        Me.TableAdapterManager = New practice_4.Database1DataSet1TableAdapters.TableAdapterManager()
        Me.Fill_Up_FormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Fill_Up_FormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.License_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Contact__TextBox = New System.Windows.Forms.TextBox()
        Me.Vehicle_modelTextBox = New System.Windows.Forms.TextBox()
        Me.Vehicle_Reg___TextBox = New System.Windows.Forms.TextBox()
        Me.Rental_Fee_per_DayTextBox = New System.Windows.Forms.TextBox()
        Me.Collect_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Return_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.No__of_DaysTextBox = New System.Windows.Forms.TextBox()
        Me.Rental_AmountTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        License_IDLabel = New System.Windows.Forms.Label()
        Contact__Label = New System.Windows.Forms.Label()
        Vehicle_modelLabel = New System.Windows.Forms.Label()
        Vehicle_Reg___Label = New System.Windows.Forms.Label()
        Rental_Fee_per_DayLabel = New System.Windows.Forms.Label()
        Collect_DateLabel = New System.Windows.Forms.Label()
        Return_DateLabel = New System.Windows.Forms.Label()
        No__of_DaysLabel = New System.Windows.Forms.Label()
        Rental_AmountLabel = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fill_Up_FormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Fill_Up_FormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Fill_Up_FormBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        NameLabel.Location = New System.Drawing.Point(5, 59)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 1
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        AddressLabel.Location = New System.Drawing.Point(5, 85)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 3
        AddressLabel.Text = "Address:"
        '
        'License_IDLabel
        '
        License_IDLabel.AutoSize = True
        License_IDLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        License_IDLabel.Location = New System.Drawing.Point(5, 152)
        License_IDLabel.Name = "License_IDLabel"
        License_IDLabel.Size = New System.Drawing.Size(61, 13)
        License_IDLabel.TabIndex = 5
        License_IDLabel.Text = "License ID:"
        '
        'Contact__Label
        '
        Contact__Label.AutoSize = True
        Contact__Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        Contact__Label.Location = New System.Drawing.Point(5, 178)
        Contact__Label.Name = "Contact__Label"
        Contact__Label.Size = New System.Drawing.Size(57, 13)
        Contact__Label.TabIndex = 7
        Contact__Label.Text = "Contact #:"
        '
        'Vehicle_modelLabel
        '
        Vehicle_modelLabel.AutoSize = True
        Vehicle_modelLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        Vehicle_modelLabel.Location = New System.Drawing.Point(5, 204)
        Vehicle_modelLabel.Name = "Vehicle_modelLabel"
        Vehicle_modelLabel.Size = New System.Drawing.Size(76, 13)
        Vehicle_modelLabel.TabIndex = 9
        Vehicle_modelLabel.Text = "Vehicle model:"
        '
        'Vehicle_Reg___Label
        '
        Vehicle_Reg___Label.AutoSize = True
        Vehicle_Reg___Label.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        Vehicle_Reg___Label.Location = New System.Drawing.Point(5, 230)
        Vehicle_Reg___Label.Name = "Vehicle_Reg___Label"
        Vehicle_Reg___Label.Size = New System.Drawing.Size(81, 13)
        Vehicle_Reg___Label.TabIndex = 11
        Vehicle_Reg___Label.Text = "Vehicle Reg  #:"
        '
        'Rental_Fee_per_DayLabel
        '
        Rental_Fee_per_DayLabel.AutoSize = True
        Rental_Fee_per_DayLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        Rental_Fee_per_DayLabel.Location = New System.Drawing.Point(5, 256)
        Rental_Fee_per_DayLabel.Name = "Rental_Fee_per_DayLabel"
        Rental_Fee_per_DayLabel.Size = New System.Drawing.Size(102, 13)
        Rental_Fee_per_DayLabel.TabIndex = 13
        Rental_Fee_per_DayLabel.Text = "Rental Fee per Day:"
        '
        'Collect_DateLabel
        '
        Collect_DateLabel.AutoSize = True
        Collect_DateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        Collect_DateLabel.Location = New System.Drawing.Point(5, 283)
        Collect_DateLabel.Name = "Collect_DateLabel"
        Collect_DateLabel.Size = New System.Drawing.Size(68, 13)
        Collect_DateLabel.TabIndex = 15
        Collect_DateLabel.Text = "Collect Date:"
        '
        'Return_DateLabel
        '
        Return_DateLabel.AutoSize = True
        Return_DateLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        Return_DateLabel.Location = New System.Drawing.Point(5, 309)
        Return_DateLabel.Name = "Return_DateLabel"
        Return_DateLabel.Size = New System.Drawing.Size(68, 13)
        Return_DateLabel.TabIndex = 17
        Return_DateLabel.Text = "Return Date:"
        '
        'No__of_DaysLabel
        '
        No__of_DaysLabel.AutoSize = True
        No__of_DaysLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        No__of_DaysLabel.Location = New System.Drawing.Point(5, 334)
        No__of_DaysLabel.Name = "No__of_DaysLabel"
        No__of_DaysLabel.Size = New System.Drawing.Size(66, 13)
        No__of_DaysLabel.TabIndex = 19
        No__of_DaysLabel.Text = "No  of Days:"
        '
        'Rental_AmountLabel
        '
        Rental_AmountLabel.AutoSize = True
        Rental_AmountLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(227, Byte), Integer))
        Rental_AmountLabel.Location = New System.Drawing.Point(5, 360)
        Rental_AmountLabel.Name = "Rental_AmountLabel"
        Rental_AmountLabel.Size = New System.Drawing.Size(80, 13)
        Rental_AmountLabel.TabIndex = 21
        Rental_AmountLabel.Text = "Rental Amount:"
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Fill_Up_FormBindingSource
        '
        Me.Fill_Up_FormBindingSource.DataMember = "Fill Up Form"
        Me.Fill_Up_FormBindingSource.DataSource = Me.Database1DataSet1
        '
        'Fill_Up_FormTableAdapter
        '
        Me.Fill_Up_FormTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Fill_Up_FormTableAdapter = Me.Fill_Up_FormTableAdapter
        Me.TableAdapterManager.UpdateOrder = practice_4.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Fill_Up_FormBindingNavigator
        '
        Me.Fill_Up_FormBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Fill_Up_FormBindingNavigator.BindingSource = Me.Fill_Up_FormBindingSource
        Me.Fill_Up_FormBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Fill_Up_FormBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Fill_Up_FormBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Fill_Up_FormBindingNavigatorSaveItem})
        Me.Fill_Up_FormBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Fill_Up_FormBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Fill_Up_FormBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Fill_Up_FormBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Fill_Up_FormBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Fill_Up_FormBindingNavigator.Name = "Fill_Up_FormBindingNavigator"
        Me.Fill_Up_FormBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Fill_Up_FormBindingNavigator.Size = New System.Drawing.Size(657, 25)
        Me.Fill_Up_FormBindingNavigator.TabIndex = 0
        Me.Fill_Up_FormBindingNavigator.Text = "BindingNavigator1"
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
        'Fill_Up_FormBindingNavigatorSaveItem
        '
        Me.Fill_Up_FormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Fill_Up_FormBindingNavigatorSaveItem.Image = CType(resources.GetObject("Fill_Up_FormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Fill_Up_FormBindingNavigatorSaveItem.Name = "Fill_Up_FormBindingNavigatorSaveItem"
        Me.Fill_Up_FormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Fill_Up_FormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(113, 56)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(164, 20)
        Me.NameTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(113, 82)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(164, 61)
        Me.AddressTextBox.TabIndex = 4
        '
        'License_IDTextBox
        '
        Me.License_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "License ID", True))
        Me.License_IDTextBox.Location = New System.Drawing.Point(113, 149)
        Me.License_IDTextBox.Name = "License_IDTextBox"
        Me.License_IDTextBox.Size = New System.Drawing.Size(164, 20)
        Me.License_IDTextBox.TabIndex = 6
        '
        'Contact__TextBox
        '
        Me.Contact__TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "Contact #", True))
        Me.Contact__TextBox.Location = New System.Drawing.Point(113, 175)
        Me.Contact__TextBox.Name = "Contact__TextBox"
        Me.Contact__TextBox.Size = New System.Drawing.Size(164, 20)
        Me.Contact__TextBox.TabIndex = 8
        '
        'Vehicle_modelTextBox
        '
        Me.Vehicle_modelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "Vehicle model", True))
        Me.Vehicle_modelTextBox.Enabled = False
        Me.Vehicle_modelTextBox.Location = New System.Drawing.Point(113, 201)
        Me.Vehicle_modelTextBox.Name = "Vehicle_modelTextBox"
        Me.Vehicle_modelTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Vehicle_modelTextBox.TabIndex = 10
        '
        'Vehicle_Reg___TextBox
        '
        Me.Vehicle_Reg___TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "Vehicle Reg_ #", True))
        Me.Vehicle_Reg___TextBox.Location = New System.Drawing.Point(113, 227)
        Me.Vehicle_Reg___TextBox.Name = "Vehicle_Reg___TextBox"
        Me.Vehicle_Reg___TextBox.Size = New System.Drawing.Size(164, 20)
        Me.Vehicle_Reg___TextBox.TabIndex = 12
        '
        'Rental_Fee_per_DayTextBox
        '
        Me.Rental_Fee_per_DayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "Rental Fee per Day", True))
        Me.Rental_Fee_per_DayTextBox.Enabled = False
        Me.Rental_Fee_per_DayTextBox.Location = New System.Drawing.Point(113, 253)
        Me.Rental_Fee_per_DayTextBox.Name = "Rental_Fee_per_DayTextBox"
        Me.Rental_Fee_per_DayTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Rental_Fee_per_DayTextBox.TabIndex = 14
        '
        'Collect_DateDateTimePicker
        '
        Me.Collect_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Fill_Up_FormBindingSource, "Collect Date", True))
        Me.Collect_DateDateTimePicker.Location = New System.Drawing.Point(113, 279)
        Me.Collect_DateDateTimePicker.Name = "Collect_DateDateTimePicker"
        Me.Collect_DateDateTimePicker.Size = New System.Drawing.Size(164, 20)
        Me.Collect_DateDateTimePicker.TabIndex = 16
        '
        'Return_DateDateTimePicker
        '
        Me.Return_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Fill_Up_FormBindingSource, "Return Date", True))
        Me.Return_DateDateTimePicker.Location = New System.Drawing.Point(113, 305)
        Me.Return_DateDateTimePicker.Name = "Return_DateDateTimePicker"
        Me.Return_DateDateTimePicker.Size = New System.Drawing.Size(164, 20)
        Me.Return_DateDateTimePicker.TabIndex = 18
        '
        'No__of_DaysTextBox
        '
        Me.No__of_DaysTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "No_ of Days", True))
        Me.No__of_DaysTextBox.Enabled = False
        Me.No__of_DaysTextBox.Location = New System.Drawing.Point(113, 331)
        Me.No__of_DaysTextBox.Name = "No__of_DaysTextBox"
        Me.No__of_DaysTextBox.Size = New System.Drawing.Size(164, 20)
        Me.No__of_DaysTextBox.TabIndex = 20
        '
        'Rental_AmountTextBox
        '
        Me.Rental_AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Fill_Up_FormBindingSource, "Rental Amount", True))
        Me.Rental_AmountTextBox.Enabled = False
        Me.Rental_AmountTextBox.Location = New System.Drawing.Point(113, 357)
        Me.Rental_AmountTextBox.Name = "Rental_AmountTextBox"
        Me.Rental_AmountTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Rental_AmountTextBox.TabIndex = 22
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Mitsubishi Mirage", "Toyota Vios", "Toyota Innova"})
        Me.ComboBox1.Location = New System.Drawing.Point(113, 200)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(164, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Get Price"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(202, 393)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Get Receipt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fillupForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(657, 476)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(License_IDLabel)
        Me.Controls.Add(Me.License_IDTextBox)
        Me.Controls.Add(Contact__Label)
        Me.Controls.Add(Me.Contact__TextBox)
        Me.Controls.Add(Vehicle_modelLabel)
        Me.Controls.Add(Me.Vehicle_modelTextBox)
        Me.Controls.Add(Vehicle_Reg___Label)
        Me.Controls.Add(Me.Vehicle_Reg___TextBox)
        Me.Controls.Add(Rental_Fee_per_DayLabel)
        Me.Controls.Add(Me.Rental_Fee_per_DayTextBox)
        Me.Controls.Add(Collect_DateLabel)
        Me.Controls.Add(Me.Collect_DateDateTimePicker)
        Me.Controls.Add(Return_DateLabel)
        Me.Controls.Add(Me.Return_DateDateTimePicker)
        Me.Controls.Add(No__of_DaysLabel)
        Me.Controls.Add(Me.No__of_DaysTextBox)
        Me.Controls.Add(Rental_AmountLabel)
        Me.Controls.Add(Me.Rental_AmountTextBox)
        Me.Controls.Add(Me.Fill_Up_FormBindingNavigator)
        Me.Name = "fillupForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "fillupForm"
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fill_Up_FormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Fill_Up_FormBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Fill_Up_FormBindingNavigator.ResumeLayout(False)
        Me.Fill_Up_FormBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Database1DataSet1 As practice_4.Database1DataSet1
    Friend WithEvents Fill_Up_FormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Fill_Up_FormTableAdapter As practice_4.Database1DataSet1TableAdapters.Fill_Up_FormTableAdapter
    Friend WithEvents TableAdapterManager As practice_4.Database1DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents Fill_Up_FormBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents Fill_Up_FormBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents License_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Contact__TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vehicle_modelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vehicle_Reg___TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rental_Fee_per_DayTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Collect_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Return_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents No__of_DaysTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rental_AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

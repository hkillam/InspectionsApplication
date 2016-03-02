<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpaceDetails
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
        Me.components = New System.ComponentModel.Container
        Dim SpaceTypeNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpaceDetails))
        Me.InspectionsDataSet1 = New Inspections.InspectionsDataSet1
        Me.SpaceTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaceTypesTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SpaceTypesTableAdapter
        Me.TableAdapterManager = New Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager
        Me.SpacesTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SpacesTableAdapter
        Me.SpaceTypeNameComboBox = New System.Windows.Forms.ComboBox
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.NameLabel = New System.Windows.Forms.Label
        Me.SpaceTypesSpacesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveButton = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.DeleteButton = New System.Windows.Forms.Button
        Me.SpaceAssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaceAssessmentsTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SpaceAssessmentsTableAdapter
        Me.SpaceAssessmentsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.NewAssGroup = New System.Windows.Forms.GroupBox
        Me.AirGB = New System.Windows.Forms.GroupBox
        Me.Air1RB = New System.Windows.Forms.RadioButton
        Me.Air2RB = New System.Windows.Forms.RadioButton
        Me.Air3RB = New System.Windows.Forms.RadioButton
        Me.LightGB = New System.Windows.Forms.GroupBox
        Me.AirLabel = New System.Windows.Forms.Label
        Me.LowLabel = New System.Windows.Forms.Label
        Me.Air4RB = New System.Windows.Forms.RadioButton
        Me.Air5RB = New System.Windows.Forms.RadioButton
        Me.Light5RB = New System.Windows.Forms.RadioButton
        Me.Light4RB = New System.Windows.Forms.RadioButton
        Me.LightLabel = New System.Windows.Forms.Label
        Me.Light3RB = New System.Windows.Forms.RadioButton
        Me.Light2RB = New System.Windows.Forms.RadioButton
        Me.Light1RB = New System.Windows.Forms.RadioButton
        Me.TempGB = New System.Windows.Forms.GroupBox
        Me.Temp5RB = New System.Windows.Forms.RadioButton
        Me.Temp4RB = New System.Windows.Forms.RadioButton
        Me.TempLabel = New System.Windows.Forms.Label
        Me.Temp3RB = New System.Windows.Forms.RadioButton
        Me.Temp2RB = New System.Windows.Forms.RadioButton
        Me.Temp1RB = New System.Windows.Forms.RadioButton
        Me.HighLabel = New System.Windows.Forms.Label
        Me.SoundGB = New System.Windows.Forms.GroupBox
        Me.Sound5RB = New System.Windows.Forms.RadioButton
        Me.Sound4RB = New System.Windows.Forms.RadioButton
        Me.SoundLabel = New System.Windows.Forms.Label
        Me.Sound3RB = New System.Windows.Forms.RadioButton
        Me.Sound2RB = New System.Windows.Forms.RadioButton
        Me.Sound1RB = New System.Windows.Forms.RadioButton
        Me.WaterGB = New System.Windows.Forms.GroupBox
        Me.Water5RB = New System.Windows.Forms.RadioButton
        Me.Water4RB = New System.Windows.Forms.RadioButton
        Me.WaterLabel = New System.Windows.Forms.Label
        Me.Water3RB = New System.Windows.Forms.RadioButton
        Me.Water2RB = New System.Windows.Forms.RadioButton
        Me.Water1RB = New System.Windows.Forms.RadioButton
        Me.AssessNowButton = New System.Windows.Forms.PictureBox
        SpaceTypeNameLabel = New System.Windows.Forms.Label
        CType(Me.InspectionsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceTypesSpacesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceAssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceAssessmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewAssGroup.SuspendLayout()
        Me.AirGB.SuspendLayout()
        Me.LightGB.SuspendLayout()
        Me.TempGB.SuspendLayout()
        Me.SoundGB.SuspendLayout()
        Me.WaterGB.SuspendLayout()
        CType(Me.AssessNowButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SpaceTypeNameLabel
        '
        SpaceTypeNameLabel.AutoSize = True
        SpaceTypeNameLabel.Location = New System.Drawing.Point(21, 65)
        SpaceTypeNameLabel.Name = "SpaceTypeNameLabel"
        SpaceTypeNameLabel.Size = New System.Drawing.Size(68, 13)
        SpaceTypeNameLabel.TabIndex = 2
        SpaceTypeNameLabel.Text = "Space Type:"
        '
        'InspectionsDataSet1
        '
        Me.InspectionsDataSet1.DataSetName = "InspectionsDataSet1"
        Me.InspectionsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpaceTypesBindingSource
        '
        Me.SpaceTypesBindingSource.DataMember = "SpaceTypes"
        Me.SpaceTypesBindingSource.DataSource = Me.InspectionsDataSet1
        '
        'SpaceTypesTableAdapter
        '
        Me.SpaceTypesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuildingsTableAdapter = Nothing
        Me.TableAdapterManager.FloorsTableAdapter = Nothing
        Me.TableAdapterManager.SchoolsTableAdapter = Nothing
        Me.TableAdapterManager.SpacesTableAdapter = Me.SpacesTableAdapter
        Me.TableAdapterManager.SpaceTypesTableAdapter = Me.SpaceTypesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SpacesTableAdapter
        '
        Me.SpacesTableAdapter.ClearBeforeFill = True
        '
        'SpaceTypeNameComboBox
        '
        Me.SpaceTypeNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SpaceTypesBindingSource, "SpaceTypeName", True))
        Me.SpaceTypeNameComboBox.DataSource = Me.SpaceTypesBindingSource
        Me.SpaceTypeNameComboBox.DisplayMember = "SpaceTypeName"
        Me.SpaceTypeNameComboBox.FormattingEnabled = True
        Me.SpaceTypeNameComboBox.Location = New System.Drawing.Point(126, 62)
        Me.SpaceTypeNameComboBox.Name = "SpaceTypeNameComboBox"
        Me.SpaceTypeNameComboBox.Size = New System.Drawing.Size(121, 21)
        Me.SpaceTypeNameComboBox.TabIndex = 3
        Me.SpaceTypeNameComboBox.ValueMember = "ID"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(126, 36)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(172, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(50, 39)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 5
        Me.NameLabel.Text = "Name"
        '
        'SpaceTypesSpacesBindingSource
        '
        Me.SpaceTypesSpacesBindingSource.DataMember = "SpaceTypesSpaces"
        Me.SpaceTypesSpacesBindingSource.DataSource = Me.SpaceTypesBindingSource
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(601, 413)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Cancel_Button
        '
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(520, 413)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 7
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(393, 413)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 8
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SpaceAssessmentsBindingSource
        '
        Me.SpaceAssessmentsBindingSource.DataMember = "SpaceAssessments"
        Me.SpaceAssessmentsBindingSource.DataSource = Me.InspectionsDataSet1
        '
        'SpaceAssessmentsTableAdapter
        '
        Me.SpaceAssessmentsTableAdapter.ClearBeforeFill = True
        '
        'SpaceAssessmentsDataGridView
        '
        Me.SpaceAssessmentsDataGridView.AllowUserToAddRows = False
        Me.SpaceAssessmentsDataGridView.AutoGenerateColumns = False
        Me.SpaceAssessmentsDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.SpaceAssessmentsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.SpaceAssessmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SpaceAssessmentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.SpaceAssessmentsDataGridView.DataSource = Me.SpaceAssessmentsBindingSource
        Me.SpaceAssessmentsDataGridView.Location = New System.Drawing.Point(12, 227)
        Me.SpaceAssessmentsDataGridView.Name = "SpaceAssessmentsDataGridView"
        Me.SpaceAssessmentsDataGridView.Size = New System.Drawing.Size(652, 172)
        Me.SpaceAssessmentsDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AssessmentDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "AssessmentDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Air"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Air"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Light"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Light"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Temperature"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Temperature"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Sound"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Sound"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Water"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Water"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 199)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Previous Assessments"
        '
        'NewAssGroup
        '
        Me.NewAssGroup.Controls.Add(Me.WaterGB)
        Me.NewAssGroup.Controls.Add(Me.SoundGB)
        Me.NewAssGroup.Controls.Add(Me.HighLabel)
        Me.NewAssGroup.Controls.Add(Me.TempGB)
        Me.NewAssGroup.Controls.Add(Me.LowLabel)
        Me.NewAssGroup.Controls.Add(Me.LightGB)
        Me.NewAssGroup.Controls.Add(Me.AirGB)
        Me.NewAssGroup.Location = New System.Drawing.Point(342, 13)
        Me.NewAssGroup.Name = "NewAssGroup"
        Me.NewAssGroup.Size = New System.Drawing.Size(322, 199)
        Me.NewAssGroup.TabIndex = 10
        Me.NewAssGroup.TabStop = False
        Me.NewAssGroup.Text = "Today's Assessment"
        '
        'AirGB
        '
        Me.AirGB.Controls.Add(Me.Air5RB)
        Me.AirGB.Controls.Add(Me.Air4RB)
        Me.AirGB.Controls.Add(Me.AirLabel)
        Me.AirGB.Controls.Add(Me.Air3RB)
        Me.AirGB.Controls.Add(Me.Air2RB)
        Me.AirGB.Controls.Add(Me.Air1RB)
        Me.AirGB.Location = New System.Drawing.Point(27, 40)
        Me.AirGB.Name = "AirGB"
        Me.AirGB.Size = New System.Drawing.Size(289, 35)
        Me.AirGB.TabIndex = 0
        Me.AirGB.TabStop = False
        '
        'Air1RB
        '
        Me.Air1RB.AutoSize = True
        Me.Air1RB.Location = New System.Drawing.Point(55, 14)
        Me.Air1RB.Name = "Air1RB"
        Me.Air1RB.Size = New System.Drawing.Size(14, 13)
        Me.Air1RB.TabIndex = 0
        Me.Air1RB.TabStop = True
        Me.Air1RB.UseVisualStyleBackColor = True
        '
        'Air2RB
        '
        Me.Air2RB.AutoSize = True
        Me.Air2RB.Location = New System.Drawing.Point(95, 14)
        Me.Air2RB.Name = "Air2RB"
        Me.Air2RB.Size = New System.Drawing.Size(14, 13)
        Me.Air2RB.TabIndex = 1
        Me.Air2RB.TabStop = True
        Me.Air2RB.UseVisualStyleBackColor = True
        '
        'Air3RB
        '
        Me.Air3RB.AutoSize = True
        Me.Air3RB.Location = New System.Drawing.Point(135, 14)
        Me.Air3RB.Name = "Air3RB"
        Me.Air3RB.Size = New System.Drawing.Size(14, 13)
        Me.Air3RB.TabIndex = 2
        Me.Air3RB.TabStop = True
        Me.Air3RB.UseVisualStyleBackColor = True
        '
        'LightGB
        '
        Me.LightGB.Controls.Add(Me.Light5RB)
        Me.LightGB.Controls.Add(Me.Light4RB)
        Me.LightGB.Controls.Add(Me.LightLabel)
        Me.LightGB.Controls.Add(Me.Light3RB)
        Me.LightGB.Controls.Add(Me.Light2RB)
        Me.LightGB.Controls.Add(Me.Light1RB)
        Me.LightGB.Location = New System.Drawing.Point(27, 70)
        Me.LightGB.Name = "LightGB"
        Me.LightGB.Size = New System.Drawing.Size(289, 35)
        Me.LightGB.TabIndex = 1
        Me.LightGB.TabStop = False
        '
        'AirLabel
        '
        Me.AirLabel.AutoSize = True
        Me.AirLabel.Location = New System.Drawing.Point(6, 14)
        Me.AirLabel.Name = "AirLabel"
        Me.AirLabel.Size = New System.Drawing.Size(19, 13)
        Me.AirLabel.TabIndex = 3
        Me.AirLabel.Text = "Air"
        '
        'LowLabel
        '
        Me.LowLabel.AutoSize = True
        Me.LowLabel.Location = New System.Drawing.Point(79, 26)
        Me.LowLabel.Name = "LowLabel"
        Me.LowLabel.Size = New System.Drawing.Size(27, 13)
        Me.LowLabel.TabIndex = 2
        Me.LowLabel.Text = "Low"
        '
        'Air4RB
        '
        Me.Air4RB.AutoSize = True
        Me.Air4RB.Location = New System.Drawing.Point(175, 14)
        Me.Air4RB.Name = "Air4RB"
        Me.Air4RB.Size = New System.Drawing.Size(14, 13)
        Me.Air4RB.TabIndex = 4
        Me.Air4RB.TabStop = True
        Me.Air4RB.UseVisualStyleBackColor = True
        '
        'Air5RB
        '
        Me.Air5RB.AutoSize = True
        Me.Air5RB.Location = New System.Drawing.Point(215, 14)
        Me.Air5RB.Name = "Air5RB"
        Me.Air5RB.Size = New System.Drawing.Size(14, 13)
        Me.Air5RB.TabIndex = 5
        Me.Air5RB.TabStop = True
        Me.Air5RB.UseVisualStyleBackColor = True
        '
        'Light5RB
        '
        Me.Light5RB.AutoSize = True
        Me.Light5RB.Location = New System.Drawing.Point(215, 16)
        Me.Light5RB.Name = "Light5RB"
        Me.Light5RB.Size = New System.Drawing.Size(14, 13)
        Me.Light5RB.TabIndex = 11
        Me.Light5RB.TabStop = True
        Me.Light5RB.UseVisualStyleBackColor = True
        '
        'Light4RB
        '
        Me.Light4RB.AutoSize = True
        Me.Light4RB.Location = New System.Drawing.Point(175, 16)
        Me.Light4RB.Name = "Light4RB"
        Me.Light4RB.Size = New System.Drawing.Size(14, 13)
        Me.Light4RB.TabIndex = 10
        Me.Light4RB.TabStop = True
        Me.Light4RB.UseVisualStyleBackColor = True
        '
        'LightLabel
        '
        Me.LightLabel.AutoSize = True
        Me.LightLabel.Location = New System.Drawing.Point(6, 16)
        Me.LightLabel.Name = "LightLabel"
        Me.LightLabel.Size = New System.Drawing.Size(30, 13)
        Me.LightLabel.TabIndex = 9
        Me.LightLabel.Text = "Light"
        '
        'Light3RB
        '
        Me.Light3RB.AutoSize = True
        Me.Light3RB.Location = New System.Drawing.Point(135, 16)
        Me.Light3RB.Name = "Light3RB"
        Me.Light3RB.Size = New System.Drawing.Size(14, 13)
        Me.Light3RB.TabIndex = 8
        Me.Light3RB.TabStop = True
        Me.Light3RB.UseVisualStyleBackColor = True
        '
        'Light2RB
        '
        Me.Light2RB.AutoSize = True
        Me.Light2RB.Location = New System.Drawing.Point(95, 16)
        Me.Light2RB.Name = "Light2RB"
        Me.Light2RB.Size = New System.Drawing.Size(14, 13)
        Me.Light2RB.TabIndex = 7
        Me.Light2RB.TabStop = True
        Me.Light2RB.UseVisualStyleBackColor = True
        '
        'Light1RB
        '
        Me.Light1RB.AutoSize = True
        Me.Light1RB.Location = New System.Drawing.Point(55, 16)
        Me.Light1RB.Name = "Light1RB"
        Me.Light1RB.Size = New System.Drawing.Size(14, 13)
        Me.Light1RB.TabIndex = 6
        Me.Light1RB.TabStop = True
        Me.Light1RB.UseVisualStyleBackColor = True
        '
        'TempGB
        '
        Me.TempGB.Controls.Add(Me.Temp5RB)
        Me.TempGB.Controls.Add(Me.Temp4RB)
        Me.TempGB.Controls.Add(Me.TempLabel)
        Me.TempGB.Controls.Add(Me.Temp3RB)
        Me.TempGB.Controls.Add(Me.Temp2RB)
        Me.TempGB.Controls.Add(Me.Temp1RB)
        Me.TempGB.Location = New System.Drawing.Point(27, 100)
        Me.TempGB.Name = "TempGB"
        Me.TempGB.Size = New System.Drawing.Size(289, 35)
        Me.TempGB.TabIndex = 12
        Me.TempGB.TabStop = False
        '
        'Temp5RB
        '
        Me.Temp5RB.AutoSize = True
        Me.Temp5RB.Location = New System.Drawing.Point(215, 16)
        Me.Temp5RB.Name = "Temp5RB"
        Me.Temp5RB.Size = New System.Drawing.Size(14, 13)
        Me.Temp5RB.TabIndex = 11
        Me.Temp5RB.TabStop = True
        Me.Temp5RB.UseVisualStyleBackColor = True
        '
        'Temp4RB
        '
        Me.Temp4RB.AutoSize = True
        Me.Temp4RB.Location = New System.Drawing.Point(175, 16)
        Me.Temp4RB.Name = "Temp4RB"
        Me.Temp4RB.Size = New System.Drawing.Size(14, 13)
        Me.Temp4RB.TabIndex = 10
        Me.Temp4RB.TabStop = True
        Me.Temp4RB.UseVisualStyleBackColor = True
        '
        'TempLabel
        '
        Me.TempLabel.AutoSize = True
        Me.TempLabel.Location = New System.Drawing.Point(6, 16)
        Me.TempLabel.Name = "TempLabel"
        Me.TempLabel.Size = New System.Drawing.Size(34, 13)
        Me.TempLabel.TabIndex = 9
        Me.TempLabel.Text = "Temp"
        '
        'Temp3RB
        '
        Me.Temp3RB.AutoSize = True
        Me.Temp3RB.Location = New System.Drawing.Point(135, 16)
        Me.Temp3RB.Name = "Temp3RB"
        Me.Temp3RB.Size = New System.Drawing.Size(14, 13)
        Me.Temp3RB.TabIndex = 8
        Me.Temp3RB.TabStop = True
        Me.Temp3RB.UseVisualStyleBackColor = True
        '
        'Temp2RB
        '
        Me.Temp2RB.AutoSize = True
        Me.Temp2RB.Location = New System.Drawing.Point(95, 16)
        Me.Temp2RB.Name = "Temp2RB"
        Me.Temp2RB.Size = New System.Drawing.Size(14, 13)
        Me.Temp2RB.TabIndex = 7
        Me.Temp2RB.TabStop = True
        Me.Temp2RB.UseVisualStyleBackColor = True
        '
        'Temp1RB
        '
        Me.Temp1RB.AutoSize = True
        Me.Temp1RB.Location = New System.Drawing.Point(55, 16)
        Me.Temp1RB.Name = "Temp1RB"
        Me.Temp1RB.Size = New System.Drawing.Size(14, 13)
        Me.Temp1RB.TabIndex = 6
        Me.Temp1RB.TabStop = True
        Me.Temp1RB.UseVisualStyleBackColor = True
        '
        'HighLabel
        '
        Me.HighLabel.AutoSize = True
        Me.HighLabel.Location = New System.Drawing.Point(227, 26)
        Me.HighLabel.Name = "HighLabel"
        Me.HighLabel.Size = New System.Drawing.Size(29, 13)
        Me.HighLabel.TabIndex = 13
        Me.HighLabel.Text = "High"
        '
        'SoundGB
        '
        Me.SoundGB.Controls.Add(Me.Sound5RB)
        Me.SoundGB.Controls.Add(Me.Sound4RB)
        Me.SoundGB.Controls.Add(Me.SoundLabel)
        Me.SoundGB.Controls.Add(Me.Sound3RB)
        Me.SoundGB.Controls.Add(Me.Sound2RB)
        Me.SoundGB.Controls.Add(Me.Sound1RB)
        Me.SoundGB.Location = New System.Drawing.Point(27, 130)
        Me.SoundGB.Name = "SoundGB"
        Me.SoundGB.Size = New System.Drawing.Size(289, 35)
        Me.SoundGB.TabIndex = 13
        Me.SoundGB.TabStop = False
        '
        'Sound5RB
        '
        Me.Sound5RB.AutoSize = True
        Me.Sound5RB.Location = New System.Drawing.Point(215, 16)
        Me.Sound5RB.Name = "Sound5RB"
        Me.Sound5RB.Size = New System.Drawing.Size(14, 13)
        Me.Sound5RB.TabIndex = 11
        Me.Sound5RB.TabStop = True
        Me.Sound5RB.UseVisualStyleBackColor = True
        '
        'Sound4RB
        '
        Me.Sound4RB.AutoSize = True
        Me.Sound4RB.Location = New System.Drawing.Point(175, 16)
        Me.Sound4RB.Name = "Sound4RB"
        Me.Sound4RB.Size = New System.Drawing.Size(14, 13)
        Me.Sound4RB.TabIndex = 10
        Me.Sound4RB.TabStop = True
        Me.Sound4RB.UseVisualStyleBackColor = True
        '
        'SoundLabel
        '
        Me.SoundLabel.AutoSize = True
        Me.SoundLabel.Location = New System.Drawing.Point(6, 16)
        Me.SoundLabel.Name = "SoundLabel"
        Me.SoundLabel.Size = New System.Drawing.Size(38, 13)
        Me.SoundLabel.TabIndex = 9
        Me.SoundLabel.Text = "Sound"
        '
        'Sound3RB
        '
        Me.Sound3RB.AutoSize = True
        Me.Sound3RB.Location = New System.Drawing.Point(135, 16)
        Me.Sound3RB.Name = "Sound3RB"
        Me.Sound3RB.Size = New System.Drawing.Size(14, 13)
        Me.Sound3RB.TabIndex = 8
        Me.Sound3RB.TabStop = True
        Me.Sound3RB.UseVisualStyleBackColor = True
        '
        'Sound2RB
        '
        Me.Sound2RB.AutoSize = True
        Me.Sound2RB.Location = New System.Drawing.Point(95, 16)
        Me.Sound2RB.Name = "Sound2RB"
        Me.Sound2RB.Size = New System.Drawing.Size(14, 13)
        Me.Sound2RB.TabIndex = 7
        Me.Sound2RB.TabStop = True
        Me.Sound2RB.UseVisualStyleBackColor = True
        '
        'Sound1RB
        '
        Me.Sound1RB.AutoSize = True
        Me.Sound1RB.Location = New System.Drawing.Point(55, 16)
        Me.Sound1RB.Name = "Sound1RB"
        Me.Sound1RB.Size = New System.Drawing.Size(14, 13)
        Me.Sound1RB.TabIndex = 6
        Me.Sound1RB.TabStop = True
        Me.Sound1RB.UseVisualStyleBackColor = True
        '
        'WaterGB
        '
        Me.WaterGB.Controls.Add(Me.Water5RB)
        Me.WaterGB.Controls.Add(Me.Water4RB)
        Me.WaterGB.Controls.Add(Me.WaterLabel)
        Me.WaterGB.Controls.Add(Me.Water3RB)
        Me.WaterGB.Controls.Add(Me.Water2RB)
        Me.WaterGB.Controls.Add(Me.Water1RB)
        Me.WaterGB.Location = New System.Drawing.Point(27, 160)
        Me.WaterGB.Name = "WaterGB"
        Me.WaterGB.Size = New System.Drawing.Size(289, 35)
        Me.WaterGB.TabIndex = 14
        Me.WaterGB.TabStop = False
        '
        'Water5RB
        '
        Me.Water5RB.AutoSize = True
        Me.Water5RB.Location = New System.Drawing.Point(215, 16)
        Me.Water5RB.Name = "Water5RB"
        Me.Water5RB.Size = New System.Drawing.Size(14, 13)
        Me.Water5RB.TabIndex = 11
        Me.Water5RB.TabStop = True
        Me.Water5RB.UseVisualStyleBackColor = True
        '
        'Water4RB
        '
        Me.Water4RB.AutoSize = True
        Me.Water4RB.Location = New System.Drawing.Point(175, 16)
        Me.Water4RB.Name = "Water4RB"
        Me.Water4RB.Size = New System.Drawing.Size(14, 13)
        Me.Water4RB.TabIndex = 10
        Me.Water4RB.TabStop = True
        Me.Water4RB.UseVisualStyleBackColor = True
        '
        'WaterLabel
        '
        Me.WaterLabel.AutoSize = True
        Me.WaterLabel.Location = New System.Drawing.Point(6, 16)
        Me.WaterLabel.Name = "WaterLabel"
        Me.WaterLabel.Size = New System.Drawing.Size(36, 13)
        Me.WaterLabel.TabIndex = 9
        Me.WaterLabel.Text = "Water"
        '
        'Water3RB
        '
        Me.Water3RB.AutoSize = True
        Me.Water3RB.Location = New System.Drawing.Point(135, 16)
        Me.Water3RB.Name = "Water3RB"
        Me.Water3RB.Size = New System.Drawing.Size(14, 13)
        Me.Water3RB.TabIndex = 8
        Me.Water3RB.TabStop = True
        Me.Water3RB.UseVisualStyleBackColor = True
        '
        'Water2RB
        '
        Me.Water2RB.AutoSize = True
        Me.Water2RB.Location = New System.Drawing.Point(95, 16)
        Me.Water2RB.Name = "Water2RB"
        Me.Water2RB.Size = New System.Drawing.Size(14, 13)
        Me.Water2RB.TabIndex = 7
        Me.Water2RB.TabStop = True
        Me.Water2RB.UseVisualStyleBackColor = True
        '
        'Water1RB
        '
        Me.Water1RB.AutoSize = True
        Me.Water1RB.Location = New System.Drawing.Point(55, 16)
        Me.Water1RB.Name = "Water1RB"
        Me.Water1RB.Size = New System.Drawing.Size(14, 13)
        Me.Water1RB.TabIndex = 6
        Me.Water1RB.TabStop = True
        Me.Water1RB.UseVisualStyleBackColor = True
        '
        'AssessNowButton
        '
        Me.AssessNowButton.Image = CType(resources.GetObject("AssessNowButton.Image"), System.Drawing.Image)
        Me.AssessNowButton.Location = New System.Drawing.Point(126, 112)
        Me.AssessNowButton.Name = "AssessNowButton"
        Me.AssessNowButton.Size = New System.Drawing.Size(152, 66)
        Me.AssessNowButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AssessNowButton.TabIndex = 11
        Me.AssessNowButton.TabStop = False
        '
        'SpaceDetails
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(688, 448)
        Me.Controls.Add(Me.AssessNowButton)
        Me.Controls.Add(Me.NewAssGroup)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SpaceAssessmentsDataGridView)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(SpaceTypeNameLabel)
        Me.Controls.Add(Me.SpaceTypeNameComboBox)
        Me.Name = "SpaceDetails"
        Me.Text = "SpaceDetails"
        CType(Me.InspectionsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceTypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceTypesSpacesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceAssessmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpaceAssessmentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NewAssGroup.ResumeLayout(False)
        Me.NewAssGroup.PerformLayout()
        Me.AirGB.ResumeLayout(False)
        Me.AirGB.PerformLayout()
        Me.LightGB.ResumeLayout(False)
        Me.LightGB.PerformLayout()
        Me.TempGB.ResumeLayout(False)
        Me.TempGB.PerformLayout()
        Me.SoundGB.ResumeLayout(False)
        Me.SoundGB.PerformLayout()
        Me.WaterGB.ResumeLayout(False)
        Me.WaterGB.PerformLayout()
        CType(Me.AssessNowButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InspectionsDataSet1 As Inspections.InspectionsDataSet1
    Friend WithEvents SpaceTypesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpaceTypesTableAdapter As Inspections.InspectionsDataSet1TableAdapters.SpaceTypesTableAdapter
    Friend WithEvents TableAdapterManager As Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SpaceTypeNameComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents SpacesTableAdapter As Inspections.InspectionsDataSet1TableAdapters.SpacesTableAdapter
    Friend WithEvents SpaceTypesSpacesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents SpaceAssessmentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpaceAssessmentsTableAdapter As Inspections.InspectionsDataSet1TableAdapters.SpaceAssessmentsTableAdapter
    Friend WithEvents SpaceAssessmentsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NewAssGroup As System.Windows.Forms.GroupBox
    Friend WithEvents AirGB As System.Windows.Forms.GroupBox
    Friend WithEvents Air3RB As System.Windows.Forms.RadioButton
    Friend WithEvents Air2RB As System.Windows.Forms.RadioButton
    Friend WithEvents Air1RB As System.Windows.Forms.RadioButton
    Friend WithEvents LightGB As System.Windows.Forms.GroupBox
    Friend WithEvents AirLabel As System.Windows.Forms.Label
    Friend WithEvents LowLabel As System.Windows.Forms.Label
    Friend WithEvents Air5RB As System.Windows.Forms.RadioButton
    Friend WithEvents Air4RB As System.Windows.Forms.RadioButton
    Friend WithEvents TempGB As System.Windows.Forms.GroupBox
    Friend WithEvents Temp5RB As System.Windows.Forms.RadioButton
    Friend WithEvents Temp4RB As System.Windows.Forms.RadioButton
    Friend WithEvents TempLabel As System.Windows.Forms.Label
    Friend WithEvents Temp3RB As System.Windows.Forms.RadioButton
    Friend WithEvents Temp2RB As System.Windows.Forms.RadioButton
    Friend WithEvents Temp1RB As System.Windows.Forms.RadioButton
    Friend WithEvents Light5RB As System.Windows.Forms.RadioButton
    Friend WithEvents Light4RB As System.Windows.Forms.RadioButton
    Friend WithEvents LightLabel As System.Windows.Forms.Label
    Friend WithEvents Light3RB As System.Windows.Forms.RadioButton
    Friend WithEvents Light2RB As System.Windows.Forms.RadioButton
    Friend WithEvents Light1RB As System.Windows.Forms.RadioButton
    Friend WithEvents SoundGB As System.Windows.Forms.GroupBox
    Friend WithEvents Sound5RB As System.Windows.Forms.RadioButton
    Friend WithEvents Sound4RB As System.Windows.Forms.RadioButton
    Friend WithEvents SoundLabel As System.Windows.Forms.Label
    Friend WithEvents Sound3RB As System.Windows.Forms.RadioButton
    Friend WithEvents Sound2RB As System.Windows.Forms.RadioButton
    Friend WithEvents Sound1RB As System.Windows.Forms.RadioButton
    Friend WithEvents HighLabel As System.Windows.Forms.Label
    Friend WithEvents WaterGB As System.Windows.Forms.GroupBox
    Friend WithEvents Water5RB As System.Windows.Forms.RadioButton
    Friend WithEvents Water4RB As System.Windows.Forms.RadioButton
    Friend WithEvents WaterLabel As System.Windows.Forms.Label
    Friend WithEvents Water3RB As System.Windows.Forms.RadioButton
    Friend WithEvents Water2RB As System.Windows.Forms.RadioButton
    Friend WithEvents Water1RB As System.Windows.Forms.RadioButton
    Friend WithEvents AssessNowButton As System.Windows.Forms.PictureBox
End Class

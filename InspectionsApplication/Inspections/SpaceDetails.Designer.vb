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
        Me.components = New System.ComponentModel.Container()
        Dim SpaceTypeNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SpaceDetails))
        Me.InspectionsDataSet1 = New Inspections.InspectionsDataSet1()
        Me.SpaceTypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaceTypesTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SpaceTypesTableAdapter()
        Me.TableAdapterManager = New Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager()
        Me.SpacesTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SpacesTableAdapter()
        Me.SpaceTypeNameComboBox = New System.Windows.Forms.ComboBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SpaceTypesSpacesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SpaceAssessmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpaceAssessmentsTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SpaceAssessmentsTableAdapter()
        Me.SpaceAssessmentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NewAssGroup = New System.Windows.Forms.GroupBox()
        Me.WaterTB = New System.Windows.Forms.TrackBar()
        Me.SoundTB = New System.Windows.Forms.TrackBar()
        Me.TempTB = New System.Windows.Forms.TrackBar()
        Me.WaterLabel = New System.Windows.Forms.Label()
        Me.LightTB = New System.Windows.Forms.TrackBar()
        Me.SoundLabel = New System.Windows.Forms.Label()
        Me.AirTB = New System.Windows.Forms.TrackBar()
        Me.TempLabel = New System.Windows.Forms.Label()
        Me.AirLabel = New System.Windows.Forms.Label()
        Me.LightLabel = New System.Windows.Forms.Label()
        Me.HighLabel = New System.Windows.Forms.Label()
        Me.LowLabel = New System.Windows.Forms.Label()
        Me.AssessNowButton = New System.Windows.Forms.PictureBox()
        Me.DataTab = New System.Windows.Forms.TabControl()
        Me.ChartTab = New System.Windows.Forms.TabPage()
        Me.TabData = New System.Windows.Forms.TabPage()

        SpaceTypeNameLabel = New System.Windows.Forms.Label()
        CType(Me.InspectionsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceTypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceTypesSpacesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceAssessmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpaceAssessmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NewAssGroup.SuspendLayout()
        CType(Me.WaterTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoundTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TempTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LightTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AirTB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssessNowButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataTab.SuspendLayout()
        Me.ChartTab.SuspendLayout()
        Me.TabData.SuspendLayout()

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
        Me.SpaceAssessmentsDataGridView.Location = New System.Drawing.Point(0, 0)
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
        Me.NewAssGroup.Controls.Add(Me.WaterTB)
        Me.NewAssGroup.Controls.Add(Me.SoundTB)
        Me.NewAssGroup.Controls.Add(Me.TempTB)
        Me.NewAssGroup.Controls.Add(Me.WaterLabel)
        Me.NewAssGroup.Controls.Add(Me.LightTB)
        Me.NewAssGroup.Controls.Add(Me.SoundLabel)
        Me.NewAssGroup.Controls.Add(Me.AirTB)
        Me.NewAssGroup.Controls.Add(Me.TempLabel)
        Me.NewAssGroup.Controls.Add(Me.AirLabel)
        Me.NewAssGroup.Controls.Add(Me.LightLabel)
        Me.NewAssGroup.Controls.Add(Me.HighLabel)
        Me.NewAssGroup.Controls.Add(Me.LowLabel)
        Me.NewAssGroup.Location = New System.Drawing.Point(342, 13)
        Me.NewAssGroup.Name = "NewAssGroup"
        Me.NewAssGroup.Size = New System.Drawing.Size(322, 209)
        Me.NewAssGroup.TabIndex = 10
        Me.NewAssGroup.TabStop = False
        Me.NewAssGroup.Text = "Today's Assessment"
        '
        'WaterTB
        '
        Me.WaterTB.Location = New System.Drawing.Point(82, 175)
        Me.WaterTB.Maximum = 5
        Me.WaterTB.Minimum = 1
        Me.WaterTB.Name = "WaterTB"
        Me.WaterTB.Size = New System.Drawing.Size(181, 45)
        Me.WaterTB.TabIndex = 18
        Me.WaterTB.TickStyle = System.Windows.Forms.TickStyle.None
        Me.WaterTB.Value = 1
        '
        'SoundTB
        '
        Me.SoundTB.Location = New System.Drawing.Point(82, 143)
        Me.SoundTB.Maximum = 5
        Me.SoundTB.Minimum = 1
        Me.SoundTB.Name = "SoundTB"
        Me.SoundTB.Size = New System.Drawing.Size(181, 45)
        Me.SoundTB.TabIndex = 17
        Me.SoundTB.TickStyle = System.Windows.Forms.TickStyle.None
        Me.SoundTB.Value = 1
        '
        'TempTB
        '
        Me.TempTB.Location = New System.Drawing.Point(82, 109)
        Me.TempTB.Maximum = 5
        Me.TempTB.Minimum = 1
        Me.TempTB.Name = "TempTB"
        Me.TempTB.Size = New System.Drawing.Size(181, 45)
        Me.TempTB.TabIndex = 16
        Me.TempTB.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TempTB.Value = 1
        '
        'WaterLabel
        '
        Me.WaterLabel.AutoSize = True
        Me.WaterLabel.Location = New System.Drawing.Point(16, 175)
        Me.WaterLabel.Name = "WaterLabel"
        Me.WaterLabel.Size = New System.Drawing.Size(36, 13)
        Me.WaterLabel.TabIndex = 9
        Me.WaterLabel.Text = "Water"
        '
        'LightTB
        '
        Me.LightTB.Location = New System.Drawing.Point(82, 79)
        Me.LightTB.Maximum = 5
        Me.LightTB.Minimum = 1
        Me.LightTB.Name = "LightTB"
        Me.LightTB.Size = New System.Drawing.Size(181, 45)
        Me.LightTB.TabIndex = 15
        Me.LightTB.TickStyle = System.Windows.Forms.TickStyle.None
        Me.LightTB.Value = 1
        '
        'SoundLabel
        '
        Me.SoundLabel.AutoSize = True
        Me.SoundLabel.Location = New System.Drawing.Point(14, 143)
        Me.SoundLabel.Name = "SoundLabel"
        Me.SoundLabel.Size = New System.Drawing.Size(38, 13)
        Me.SoundLabel.TabIndex = 9
        Me.SoundLabel.Text = "Sound"
        '
        'AirTB
        '
        Me.AirTB.Location = New System.Drawing.Point(82, 49)
        Me.AirTB.Maximum = 5
        Me.AirTB.Minimum = 1
        Me.AirTB.Name = "AirTB"
        Me.AirTB.Size = New System.Drawing.Size(181, 45)
        Me.AirTB.TabIndex = 13
        Me.AirTB.TickStyle = System.Windows.Forms.TickStyle.None
        Me.AirTB.Value = 1
        '
        'TempLabel
        '
        Me.TempLabel.AutoSize = True
        Me.TempLabel.Location = New System.Drawing.Point(18, 111)
        Me.TempLabel.Name = "TempLabel"
        Me.TempLabel.Size = New System.Drawing.Size(34, 13)
        Me.TempLabel.TabIndex = 9
        Me.TempLabel.Text = "Temp"
        '
        'AirLabel
        '
        Me.AirLabel.AutoSize = True
        Me.AirLabel.Location = New System.Drawing.Point(33, 49)
        Me.AirLabel.Name = "AirLabel"
        Me.AirLabel.Size = New System.Drawing.Size(19, 13)
        Me.AirLabel.TabIndex = 3
        Me.AirLabel.Text = "Air"
        '
        'LightLabel
        '
        Me.LightLabel.AutoSize = True
        Me.LightLabel.Location = New System.Drawing.Point(22, 81)
        Me.LightLabel.Name = "LightLabel"
        Me.LightLabel.Size = New System.Drawing.Size(30, 13)
        Me.LightLabel.TabIndex = 9
        Me.LightLabel.Text = "Light"
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
        'LowLabel
        '
        Me.LowLabel.AutoSize = True
        Me.LowLabel.Location = New System.Drawing.Point(79, 26)
        Me.LowLabel.Name = "LowLabel"
        Me.LowLabel.Size = New System.Drawing.Size(27, 13)
        Me.LowLabel.TabIndex = 2
        Me.LowLabel.Text = "Low"
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
        'DataTab
        '
        Me.DataTab.Controls.Add(Me.ChartTab)
        Me.DataTab.Controls.Add(Me.TabData)
        Me.DataTab.Location = New System.Drawing.Point(11, 218)
        Me.DataTab.Name = "DataTab"
        Me.DataTab.SelectedIndex = 0
        Me.DataTab.Size = New System.Drawing.Size(665, 189)
        Me.DataTab.TabIndex = 12
        '
        'ChartTab
        '

        Me.ChartTab.Location = New System.Drawing.Point(4, 22)
        Me.ChartTab.Name = "ChartTab"
        Me.ChartTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ChartTab.Size = New System.Drawing.Size(657, 163)
        Me.ChartTab.TabIndex = 0
        Me.ChartTab.Text = "Chart"
        Me.ChartTab.UseVisualStyleBackColor = True
        '
        'TabData
        '
        Me.TabData.Controls.Add(Me.SpaceAssessmentsDataGridView)
        Me.TabData.Location = New System.Drawing.Point(4, 22)
        Me.TabData.Name = "TabData"
        Me.TabData.Padding = New System.Windows.Forms.Padding(3)
        Me.TabData.Size = New System.Drawing.Size(657, 163)
        Me.TabData.TabIndex = 1
        Me.TabData.Text = "Data"
        Me.TabData.UseVisualStyleBackColor = True
        '
        'SpaceDetails
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(688, 448)
        Me.Controls.Add(Me.DataTab)
        Me.Controls.Add(Me.AssessNowButton)
        Me.Controls.Add(Me.NewAssGroup)
        Me.Controls.Add(Me.Label1)
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
        CType(Me.WaterTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoundTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TempTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LightTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AirTB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssessNowButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataTab.ResumeLayout(False)
        Me.ChartTab.ResumeLayout(False)
        Me.TabData.ResumeLayout(False)

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
    Friend WithEvents AirLabel As System.Windows.Forms.Label
    Friend WithEvents LowLabel As System.Windows.Forms.Label
    Friend WithEvents TempLabel As System.Windows.Forms.Label
    Friend WithEvents LightLabel As System.Windows.Forms.Label
    Friend WithEvents SoundLabel As System.Windows.Forms.Label
    Friend WithEvents HighLabel As System.Windows.Forms.Label
    Friend WithEvents WaterLabel As System.Windows.Forms.Label
    Friend WithEvents AssessNowButton As System.Windows.Forms.PictureBox
    Friend WithEvents DataTab As System.Windows.Forms.TabControl
    Friend WithEvents ChartTab As System.Windows.Forms.TabPage
    Friend WithEvents TabData As System.Windows.Forms.TabPage
    ' Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents AssessmentChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents AirTB As System.Windows.Forms.TrackBar
    ' Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents LightTB As System.Windows.Forms.TrackBar
    Friend WithEvents WaterTB As System.Windows.Forms.TrackBar
    Friend WithEvents SoundTB As System.Windows.Forms.TrackBar
    Friend WithEvents TempTB As System.Windows.Forms.TrackBar


    ' Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class

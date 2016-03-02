<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloorPlan
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
        Me.FloorsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InspectionsDataSet1 = New Inspections.InspectionsDataSet1
        Me.FloorsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuildingsComboBox = New System.Windows.Forms.ComboBox
        Me.SchoolsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolsTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SchoolsTableAdapter
        Me.TableAdapterManager = New Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager
        Me.BuildingsTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.BuildingsTableAdapter
        Me.FloorsTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.FloorsTableAdapter
        Me.FloorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SchoolsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolsComboBox = New System.Windows.Forms.ComboBox
        Me.FloorsComboBox = New System.Windows.Forms.ComboBox
        CType(Me.FloorsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InspectionsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloorsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuildingsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FloorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FloorsBindingSource1
        '
        Me.FloorsBindingSource1.DataMember = "BuildingsFloors"
        Me.FloorsBindingSource1.DataSource = Me.BuildingsBindingSource
        '
        'BuildingsBindingSource
        '
        Me.BuildingsBindingSource.DataMember = "Buildings"
        Me.BuildingsBindingSource.DataSource = Me.InspectionsDataSet1
        '
        'InspectionsDataSet1
        '
        Me.InspectionsDataSet1.DataSetName = "InspectionsDataSet1"
        Me.InspectionsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FloorsBindingSource2
        '
        Me.FloorsBindingSource2.DataMember = "Floors"
        Me.FloorsBindingSource2.DataSource = Me.InspectionsDataSet1
        '
        'BuildingsBindingSource1
        '
        Me.BuildingsBindingSource1.DataMember = "SchoolsBuildings"
        Me.BuildingsBindingSource1.DataSource = Me.SchoolsBindingSource
        '
        'SchoolsBindingSource
        '
        Me.SchoolsBindingSource.DataMember = "Schools"
        Me.SchoolsBindingSource.DataSource = Me.InspectionsDataSet1
        '
        'BuildingsComboBox
        '
        Me.BuildingsComboBox.DataSource = Me.BuildingsBindingSource1
        Me.BuildingsComboBox.DisplayMember = "BuildingName"
        Me.BuildingsComboBox.FormattingEnabled = True
        Me.BuildingsComboBox.Location = New System.Drawing.Point(159, 28)
        Me.BuildingsComboBox.Name = "BuildingsComboBox"
        Me.BuildingsComboBox.Size = New System.Drawing.Size(187, 21)
        Me.BuildingsComboBox.TabIndex = 2
        Me.BuildingsComboBox.ValueMember = "ID"
        '
        'SchoolsBindingSource1
        '
        Me.SchoolsBindingSource1.DataMember = "Schools"
        Me.SchoolsBindingSource1.DataSource = Me.InspectionsDataSet1
        '
        'SchoolsTableAdapter
        '
        Me.SchoolsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuildingsTableAdapter = Me.BuildingsTableAdapter
        Me.TableAdapterManager.FloorsTableAdapter = Me.FloorsTableAdapter
        Me.TableAdapterManager.SchoolsTableAdapter = Me.SchoolsTableAdapter
        Me.TableAdapterManager.SpacesTableAdapter = Nothing
        Me.TableAdapterManager.SpaceTypesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuildingsTableAdapter
        '
        Me.BuildingsTableAdapter.ClearBeforeFill = True
        '
        'FloorsTableAdapter
        '
        Me.FloorsTableAdapter.ClearBeforeFill = True
        '
        'FloorsBindingSource
        '
        Me.FloorsBindingSource.DataMember = "Floors"
        Me.FloorsBindingSource.DataSource = Me.InspectionsDataSet1
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox1.Location = New System.Drawing.Point(126, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(855, 476)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'SchoolsBindingSource2
        '
        Me.SchoolsBindingSource2.DataMember = "Schools"
        Me.SchoolsBindingSource2.DataSource = Me.InspectionsDataSet1
        '
        'SchoolsComboBox
        '
        Me.SchoolsComboBox.DataSource = Me.SchoolsBindingSource2
        Me.SchoolsComboBox.DisplayMember = "SchoolName"
        Me.SchoolsComboBox.FormattingEnabled = True
        Me.SchoolsComboBox.Location = New System.Drawing.Point(18, 28)
        Me.SchoolsComboBox.Name = "SchoolsComboBox"
        Me.SchoolsComboBox.Size = New System.Drawing.Size(135, 21)
        Me.SchoolsComboBox.TabIndex = 3
        Me.SchoolsComboBox.ValueMember = "ID"
        '
        'FloorsComboBox
        '
        Me.FloorsComboBox.FormattingEnabled = True
        Me.FloorsComboBox.Location = New System.Drawing.Point(352, 28)
        Me.FloorsComboBox.Name = "FloorsComboBox"
        Me.FloorsComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FloorsComboBox.TabIndex = 4
        '
        'FloorPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 583)
        Me.Controls.Add(Me.FloorsComboBox)
        Me.Controls.Add(Me.SchoolsComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BuildingsComboBox)
        Me.Name = "FloorPlan"
        Me.Text = "Floor Plan"
        CType(Me.FloorsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InspectionsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloorsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuildingsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FloorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InspectionsDataSet1 As Inspections.InspectionsDataSet1
    Friend WithEvents SchoolsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SchoolsTableAdapter As Inspections.InspectionsDataSet1TableAdapters.SchoolsTableAdapter
    Friend WithEvents TableAdapterManager As Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents BuildingsTableAdapter As Inspections.InspectionsDataSet1TableAdapters.BuildingsTableAdapter
    Friend WithEvents BuildingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FloorsTableAdapter As Inspections.InspectionsDataSet1TableAdapters.FloorsTableAdapter
    Friend WithEvents FloorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FloorsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BuildingsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BuildingsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SchoolsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SchoolsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents SchoolsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FloorsBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents FloorsComboBox As System.Windows.Forms.ComboBox

End Class

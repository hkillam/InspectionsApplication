<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectSystem
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
        Me.InspectionsDataSet1 = New Inspections.InspectionsDataSet1()
        Me.SystemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SystemsTableAdapter = New Inspections.InspectionsDataSet1TableAdapters.SystemsTableAdapter()
        Me.TableAdapterManager = New Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager()
        Me.SystemsComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SubSystemCB = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComponentCB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ItemCB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        CType(Me.InspectionsDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SystemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InspectionsDataSet1
        '
        Me.InspectionsDataSet1.DataSetName = "InspectionsDataSet1"
        Me.InspectionsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SystemsBindingSource
        '
        Me.SystemsBindingSource.DataMember = "Systems"
        Me.SystemsBindingSource.DataSource = Me.InspectionsDataSet1
        '
        'SystemsTableAdapter
        '
        Me.SystemsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuildingsTableAdapter = Nothing
        Me.TableAdapterManager.FloorsTableAdapter = Nothing
        Me.TableAdapterManager.SchoolsTableAdapter = Nothing
        Me.TableAdapterManager.SpacesTableAdapter = Nothing
        Me.TableAdapterManager.SpaceTypesTableAdapter = Nothing
        Me.TableAdapterManager.SystemsTableAdapter = Me.SystemsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SystemsComboBox
        '
        Me.SystemsComboBox.DataSource = Me.SystemsBindingSource
        Me.SystemsComboBox.DisplayMember = "Name"
        Me.SystemsComboBox.FormattingEnabled = True
        Me.SystemsComboBox.Location = New System.Drawing.Point(92, 12)
        Me.SystemsComboBox.Name = "SystemsComboBox"
        Me.SystemsComboBox.Size = New System.Drawing.Size(188, 21)
        Me.SystemsComboBox.TabIndex = 1
        Me.SystemsComboBox.ValueMember = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "System"
        '
        'SubSystemCB
        '
        Me.SubSystemCB.Enabled = False
        Me.SubSystemCB.FormattingEnabled = True
        Me.SubSystemCB.Location = New System.Drawing.Point(92, 40)
        Me.SubSystemCB.Name = "SubSystemCB"
        Me.SubSystemCB.Size = New System.Drawing.Size(188, 21)
        Me.SubSystemCB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "SubSystem"
        '
        'ComponentCB
        '
        Me.ComponentCB.Enabled = False
        Me.ComponentCB.FormattingEnabled = True
        Me.ComponentCB.Location = New System.Drawing.Point(92, 68)
        Me.ComponentCB.Name = "ComponentCB"
        Me.ComponentCB.Size = New System.Drawing.Size(188, 21)
        Me.ComponentCB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Component"
        '
        'ItemCB
        '
        Me.ItemCB.Enabled = False
        Me.ItemCB.FormattingEnabled = True
        Me.ItemCB.Location = New System.Drawing.Point(92, 96)
        Me.ItemCB.Name = "ItemCB"
        Me.ItemCB.Size = New System.Drawing.Size(188, 21)
        Me.ItemCB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Item"
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(173, 151)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(107, 23)
        Me.OKButton.TabIndex = 9
        Me.OKButton.Text = "Inspect this system"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Location = New System.Drawing.Point(92, 151)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 23)
        Me.Cancel.TabIndex = 10
        Me.Cancel.Text = "Cancel"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'SelectSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 186)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ItemCB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComponentCB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SubSystemCB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SystemsComboBox)
        Me.Name = "SelectSystem"
        Me.Text = "Select a System"
        CType(Me.InspectionsDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SystemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InspectionsDataSet1 As Inspections.InspectionsDataSet1
    Friend WithEvents SystemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SystemsTableAdapter As Inspections.InspectionsDataSet1TableAdapters.SystemsTableAdapter
    Friend WithEvents TableAdapterManager As Inspections.InspectionsDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents SystemsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubSystemCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComponentCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ItemCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button
End Class

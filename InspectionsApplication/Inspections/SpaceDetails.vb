Public Class SpaceDetails


    Private AssessingToday As Boolean


    Private Sub SpaceTypesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SpaceTypesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InspectionsDataSet1)

    End Sub

    Private Sub SpaceDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InspectionsDataSet1.SpaceAssessments' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'InspectionsDataSet1.Spaces' table. You can move, or remove it, as needed.
        Me.SpacesTableAdapter.Fill(Me.InspectionsDataSet1.Spaces)
        'TODO: This line of code loads data into the 'InspectionsDataSet1.SpaceTypes' table. You can move, or remove it, as needed.
        Me.SpaceTypesTableAdapter.Fill(Me.InspectionsDataSet1.SpaceTypes)
        Me.SpaceAssessmentsTableAdapter.FillBySpaceID(Me.InspectionsDataSet1.SpaceAssessments, FloorPlan.currentspace.ID)
        NameTextBox.Text = FloorPlan.currentspace.SpaceName

        If FloorPlan.currentspace.SpaceTypeID <> Nothing Then
            SpaceTypeNameComboBox.SelectedValue = FloorPlan.currentspace.SpaceTypeID
        End If

        NewAssGroup.Visible = False
        AssessingToday = False


    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sound5RB.CheckedChanged

    End Sub

    Private Sub AssessNowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssessNowButton.Click
        NewAssGroup.Visible = True
        AssessingToday = True
        AssessNowButton.Visible = False


    End Sub
End Class
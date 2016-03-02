Public Class SpaceDetails


    Private AssessingToday As Boolean
    Private spaceid As Integer


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




        DrawChart()
        NewAssGroup.Visible = False
        AssessingToday = False
        spaceid = FloorPlan.currentspace.ID



    End Sub


    Private Sub AssessNowButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssessNowButton.Click
        NewAssGroup.Visible = True
        AssessingToday = True
        AssessNowButton.Visible = False


    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ' update name and type
        Dim myspaceTA As New InspectionsDataSet1TableAdapters.SpacesTableAdapter
        myspaceTA.UpdateSpaceName(NameTextBox.Text, SpaceTypeNameComboBox.SelectedValue, spaceid)

        ' add new assessment
        If AssessingToday Then
            Dim thedate As String = Today.ToString()
            Dim myspaceAssTA As New InspectionsDataSet1TableAdapters.SpaceAssessmentsTableAdapter
            myspaceAssTA.NewSpaceAssessment(spaceid, AirTB.Value, LightTB.Value, SoundTB.Value, TempTB.Value, WaterTB.Value, thedate)
            AssessingToday = False
        End If
        Close()

    End Sub


    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If MsgBox("Do you want to delete space" & NameTextBox.Text, MsgBoxStyle.YesNo, "Confirm Delete") = Windows.Forms.DialogResult.Yes Then
            Dim myspaceAssTA As New InspectionsDataSet1TableAdapters.SpaceAssessmentsTableAdapter
            myspaceAssTA.DeleteQuery(spaceid)
            Dim myspaceTA As New InspectionsDataSet1TableAdapters.SpacesTableAdapter
            myspaceTA.DeleteSpace(spaceid)
            Close()
        End If
    End Sub

    Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
    Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
    Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
    Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()

    Private Sub DrawChart()

        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()


        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.SpaceAssessmentsBindingSource
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Air"
        Series1.XValueMember = "AssessmentDate"
        Series1.YValueMembers = "Air"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Water"
        Series2.XValueMember = "AssessmentDate"
        Series2.YValueMembers = "Water"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Light"
        Series3.XValueMember = "AssessmentDate"
        Series3.YValueMembers = "Light"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Sound"
        Series4.XValueMember = "AssessmentDate"
        Series4.YValueMembers = "Sound"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Temperature"
        Series5.ShadowColor = System.Drawing.Color.Gray
        Series5.XValueMember = "AssessmentDate"
        Series5.YValueMembers = "Temperature"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Size = New System.Drawing.Size(657, 159)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Assessments"

        With Chart1.ChartAreas(0)
            .AxisX.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
            .AxisY2.MajorGrid.LineDashStyle = DataVisualization.Charting.ChartDashStyle.Dot
            .AxisX.MajorGrid.LineColor = Color.LightGray
            .AxisY.MajorGrid.LineColor = Color.LightGray
        End With

        For Each series In Chart1.Series
            series.ChartType = DataVisualization.Charting.SeriesChartType.Line
        Next

        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChartTab.Controls.Add(Me.Chart1)
    End Sub
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart

End Class
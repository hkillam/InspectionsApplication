

Public Class FloorPlan



    Dim currentzoom As Double
    Public currentspace As InspectionsDataSet1.SpacesRow

    Dim mousy As New MouseActivity


    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Inspections\Inspections.accdb"


    Private currentimage As Image


    Private Sub FloorPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BuildingsTableAdapter.Fill(Me.InspectionsDataSet1.Buildings)
        Me.SchoolsTableAdapter.Fill(Me.InspectionsDataSet1.Schools)
        Me.SchoolsTableAdapter.Fill(Me.InspectionsDataSet1.Schools)
        Me.FloorsTableAdapter.Fill(Me.InspectionsDataSet1.Floors)
        ' Me.FloorsTableAdapter.GetFloorsByBuildingID(SchoolsComboBox.SelectedValue)

        UpdateFloorsCombo()

        Show()
        'Picture Box Settings
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize

        ' set the two shared variables
        Dim thefloor As InspectionsDataSet1.FloorsRow
        'thefloor = CType(CType(Me.FloorsComboBox.SelectedItem, DataRowView).Row, InspectionsDataSet1.FloorsRow)
        thefloor = GetCurrentFloor()
        currentimage = Image.FromFile(thefloor.FileName)
        currentzoom = ZoomToFit()



        DrawFloorplan()
        DrawSpaces()
        drawtoolbars()

    End Sub




    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        mousy.Click(sender, e, currentzoom)
    End Sub
    Public WithEvents newButton As Button

    Public Sub LookupItems(ByVal thepoint As Point)
        ' pull up list of spaces for current floor
        ' check (scaled) mouse position to see if it is in a space
        Dim myspacesTA As New InspectionsDataSet1TableAdapters.SpacesTableAdapter
        Dim currentfloorID = GetCurrentFloor().ID
        If FloorsComboBox.SelectedItem = Nothing Then
            Return
        End If
        Dim myx As Double = thepoint.X / currentzoom
        Dim myy As Double = thepoint.Y / currentzoom

        Dim myspaces = From Spaces In myspacesTA.GetSpacesByFloorID(currentfloorID) Select Spaces
        For Each thespace In myspaces
            If (thespace.Top <= myy And thespace.Top + thespace.Height >= myy _
               And thespace.Left <= myx And thespace.Left + thespace.Width >= myx) Then
                ' MsgBox(thespace.SpaceName)
                currentspace = thespace
                SpaceDetails.ShowDialog()
            End If

        Next


    End Sub

    Public Sub drawtoolbars()
        Dim myBrush As New System.Drawing.Pen(Color.White)
        Dim semiTransBrush As New SolidBrush(Color.FromArgb(128, 100, 255, 255))
        Dim formGraphics As System.Drawing.Graphics
        Dim myrect As Rectangle

        formGraphics = Me.CreateGraphics()
        myrect = New Rectangle(0, 0, Me.Width, 200)
        'formGraphics.FillRectangle(semiTransBrush, myrect)
        myBrush.Dispose()
        semiTransBrush.Dispose()
        formGraphics.Dispose()
    End Sub

    Public Sub DrawSpaces()
        Dim myBrush As New System.Drawing.Pen(Color.Red)
        Dim myredbrush As New SolidBrush(Color.Red)
        Dim semiTransBrush As New SolidBrush(Color.FromArgb(30, 255, 255, 50))
        Dim myfont As New System.Drawing.Font("calibri", 16, FontStyle.Regular)

        Dim formGraphics As System.Drawing.Graphics
        Dim myrect As Rectangle

        formGraphics = PictureBox1.CreateGraphics()

        Dim myspacesTA As New InspectionsDataSet1TableAdapters.SpacesTableAdapter
        Dim currentfloorID = GetCurrentFloor().ID
        If FloorsComboBox.SelectedItem = Nothing Then
            Return
        End If

        Dim myspaces = From Spaces In myspacesTA.GetSpacesByFloorID(currentfloorID) Select Spaces
        For Each thespace In myspaces
            'MsgBox(thespace.SpaceName)
            myrect = New Rectangle(thespace.Left * currentzoom, thespace.Top * currentzoom, thespace.Width * currentzoom, thespace.Height * currentzoom)
            formGraphics.DrawRectangle(myBrush, myrect)
            formGraphics.FillRectangle(semiTransBrush, myrect)
            Dim myleft As Single = Int(thespace.Left * currentzoom)
            Dim mytop As Single = Int(thespace.Top * currentzoom)
            Dim spacename As String = thespace.SpaceName

            formGraphics.DrawString(spacename, myfont, myredbrush, myleft, mytop)


            ' ControlPaint.FillReversibleRectangle(myrect, Color.FromArgb(30, 255, 255, 50))


            ' Dim mybutton As Button
            ' mybutton = New Button()

            'newButton = New Button
            'newButton.Name = "btnButton" & thespace.ID
            'newButton.Text = thespace.SpaceName
            'newButton.Top = thespace.Top * currentzoom
            'newButton.Left = thespace.Left * currentzoom
            'newButton.Width = thespace.Width * currentzoom
            'newButton.Height = thespace.Height * currentzoom
            'newButton.BackColor = Color.Transparent
            ' newButton.BackColor = Color.FromArgb(32, 255, 255, 0)
            'AddHandler newButton.Click, AddressOf SpaceClicked
            'PictureBox1.Controls.Add(newButton)


        Next

        myBrush.Dispose()
        semiTransBrush.Dispose()
        formGraphics.Dispose()

    End Sub

    Private Sub SpaceClicked(ByVal sender As Object, ByVal e As EventArgs)
        MsgBox("You clicked: " & sender.name & "Button name: " & sender.Text)
    End Sub

    Public Sub Zoom(ByRef zoomchange As Double)
        ' 1.10 is zoom in, .90 is zoom out

        Dim original As Image
        Dim newzoom As Double = currentzoom + zoomchange
        'Get our original image
        original = Image.FromFile("C:\Users\...Libelula\Documents\Work\Tarek InspectionDatabase\Old Inspection Application\Schools\School 1\First Floor.JPG")
        currentzoom = newzoom

        'Create a new image based on the zoom parameters we require
        Dim zoomImage As New Bitmap(original, (Convert.ToInt32(original.Width * newzoom)), (Convert.ToInt32(original.Height * newzoom)))


        DrawFloorplan()

        DrawSpaces()

    End Sub



    Private Function ZoomToFit() As Double
        Dim imgwidth, imgheight, wndwidth, wndheight As Integer
        Dim widthscale, heightscale, zoomvalue As Double

        imgwidth = currentimage.Width
        imgheight = currentimage.Height
        wndwidth = PictureBox1.Width
        wndheight = PictureBox1.Height

        ' make entire image fit in window
        ' 1.10 is zoom in, .90 is zoom out
        ' image is wider than window, zoom out to fit
        widthscale = wndwidth / imgwidth
        heightscale = wndheight / imgheight
        If (heightscale < widthscale) Then
            zoomvalue = heightscale
        Else
            zoomvalue = widthscale
        End If
        currentzoom = zoomvalue

        Return (currentzoom)

    End Function

    Private Sub FloorsComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FloorsComboBox.SelectedIndexChanged
        Dim thefloor As InspectionsDataSet1.FloorsRow

        If (Me.FloorsComboBox.SelectedItem Is Nothing) Then
            Return
        End If


        thefloor = GetCurrentFloor()
        'thefloor = CType(CType(Me.FloorsComboBox.SelectedItem, DataRowView).Row, InspectionsDataSet1.FloorsRow)

        ' set the two shared variables
        currentimage = Image.FromFile(thefloor.FileName)
        currentzoom = ZoomToFit()

        DrawFloorplan()
        DrawSpaces()



    End Sub
    Public Function GetCurrentFloor() As InspectionsDataSet1.FloorsRow
        Dim floorsQuery = From currentFloor In InspectionsDataSet1.Floors _
                Where currentFloor.FloorName Like FloorsComboBox.SelectedItem _
                Select currentFloor

        For Each floorrecord In floorsQuery
            Return floorrecord
        Next
        Return Nothing
    End Function
    Private Sub DrawFloorplan()
        Dim imgwidth, imgheight As Integer
        imgwidth = currentimage.Width
        imgheight = currentimage.Height

        Dim zoomImage As New Bitmap(currentimage, (Convert.ToInt32(imgwidth * currentzoom)), (Convert.ToInt32(imgheight * currentzoom)))

        Dim pbgraphics = PictureBox1.CreateGraphics
        Dim eraser As New SolidBrush(Color.FromArgb(255, 240, 240, 240))
        pbgraphics.FillRectangle(eraser, 0, 0, PictureBox1.Width, PictureBox1.Height)

        pbgraphics.DrawImage(zoomImage, 0, 0)

        pbgraphics.Dispose()
        eraser.Dispose()

    End Sub

    Private Sub SchoolsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SchoolsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InspectionsDataSet1)

    End Sub

    Private Sub SchoolsBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.SchoolsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InspectionsDataSet1)

    End Sub


    Private Sub PictureBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        'DrawFloorplan()
        'DrawSpaces()


    End Sub

    Private Sub BuildingsComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuildingsComboBox.SelectedIndexChanged

        If (BuildingsComboBox.SelectedValue = Nothing) Then
            Return
        End If

        ' clear the current combobox for floors
        While (FloorsComboBox.Items.Count() > 0)
            FloorsComboBox.Items.RemoveAt(0)
        End While

        UpdateFloorsCombo()

    End Sub

    Private Sub UpdateFloorsCombo()
        ' update combobox with floors for current building
        Dim floorsQuery = From currentFloor In InspectionsDataSet1.Floors _
        Where currentFloor.BuildingID = BuildingsComboBox.SelectedValue _
        Select currentFloor
        For Each floorrecord In floorsQuery
            FloorsComboBox.Items.Add(floorrecord.FloorName)
        Next
        FloorsComboBox.SelectedIndex = 0
    End Sub

    Private Sub FloorPlan_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        DrawFloorplan()
        DrawSpaces()
    End Sub

    Private Sub AddRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRegion.Click
        mousy.AddRegion()

        AddRegion.BackColor = Color.Orange
    End Sub

    Private Sub ZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomIn.Click
        Zoom(0.1)

    End Sub

    Private Sub Button_zoomout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_zoomout.Click
        Zoom(-0.1)
    End Sub


    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        mousy.StartDrag(sender, e)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        mousy.DragOn(sender, e)
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        mousy.DragDone(sender, e, currentzoom)
    End Sub

    Private Sub FloorPlan_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PictureBox1.Width = Me.Width - 162
        PictureBox1.Height = Me.Height - 146
    End Sub

    Private Sub InspectSystemButton_Click(sender As Object, e As EventArgs) Handles InspectSystemButton.Click
        SelectSystem.ShowDialog()
    End Sub
End Class

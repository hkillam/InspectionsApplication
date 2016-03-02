Public Class MouseActivity

    Public Enum MouseMode
        Scroll
        AddingRegion

        AddImage
        AddNote
        AddRegionIrregular
    End Enum
    Dim currentmousemode As MouseMode
    Dim firstclick = Nothing, mostrecent As Point

    Public Sub AddRegion()
        If currentmousemode <> MouseMode.AddingRegion Then
            currentmousemode = MouseMode.AddingRegion
        Else
            currentmousemode = MouseMode.Scroll
            FloorPlan.AddRegion.BackColor = Color.White
        End If

    End Sub

    Public Sub StartDrag(sender As Object, e As MouseEventArgs)
        Dim click As MouseEventArgs
        click = e

        If currentmousemode = MouseMode.AddingRegion Then

            firstclick = click.Location
            mostrecent = click.Location
            DrawBandyBox(firstclick, mostrecent)
        End If
    End Sub

    Public Sub DragOn(sender As Object, e As MouseEventArgs)
        If currentmousemode = MouseMode.AddingRegion And firstclick <> Nothing Then
            DrawBandyBox(firstclick, mostrecent)
            mostrecent = e.Location
            DrawBandyBox(firstclick, mostrecent)
        End If
    End Sub

    Public Sub DragDone(sender As Object, e As MouseEventArgs, currentzoom As Double)
        Dim click As MouseEventArgs
        click = e
        If currentmousemode = MouseMode.AddingRegion And firstclick <> Nothing Then

            If e = firstclick Then
                firstclick = Nothing
                Return
            End If
            DrawBandyBox(firstclick, mostrecent)
            currentmousemode = MouseMode.Scroll
            FloorPlan.AddRegion.BackColor = Color.White
            SketchRectangle(firstclick, click.Location)
            ' note - scale clicks, calculate width height
            'InspectionsDataSet1.Spaces.AddSpacesRow(Nothing, Nothing, GetCurrentFloor(), Nothing, firstclick.Y, firstclick.X, 300, 300)
            Dim myspacesTA As New InspectionsDataSet1TableAdapters.SpacesTableAdapter
            Dim top As Integer = firstclick.X / currentzoom
            Dim left As Integer = firstclick.Y / currentzoom
            Dim width As Integer = (click.Location.X - firstclick.X) / currentzoom
            Dim height As Integer = (click.Location.Y - firstclick.Y) / currentzoom
            myspacesTA.NewSpace("New Space", FloorPlan.GetCurrentFloor().ID, left, top, width, height)
            FloorPlan.PictureBox1.Refresh()
            firstclick = Nothing
            mostrecent = Nothing
        End If
    End Sub


    Public Sub Click(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal currentzoom As Double)
        Dim click As MouseEventArgs
        click = e

        Select Case currentmousemode
            Case MouseMode.AddingRegion
                Return

            Case Else
                FloorPlan.LookupItems(click.Location)

        End Select


    End Sub
    Private Sub SketchRectangle(ByVal first As Point, ByVal second As Point)
        Dim myBrush As New System.Drawing.Pen(Color.Red)
        Dim semiTransBrush As New SolidBrush(Color.FromArgb(128, 255, 255, 0))
        Dim formGraphics As System.Drawing.Graphics
        Dim myrect As Rectangle
        myrect = New Rectangle(first.X, first.Y, second.X - first.X, second.Y - first.Y)
        formGraphics = FloorPlan.PictureBox1.CreateGraphics()
        formGraphics.DrawRectangle(myBrush, myrect)
        formGraphics.FillRectangle(semiTransBrush, myrect)
        myBrush.Dispose()
        formGraphics.Dispose()

        ' MyDrawReversibleRectangle(PictureBox1.PointToScreen(first), PictureBox1.PointToScreen(second))

        ' MyDrawReversibleRectangle(PictureBox1.PointToScreen(first), PictureBox1.PointToScreen(second))
    End Sub
    Private Sub SketchPoint(ByVal first As Point, ByVal clr As Color)
        Dim myBrush As New System.Drawing.SolidBrush(System.Drawing.Color.Red)
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = FloorPlan.PictureBox1.CreateGraphics()
        formGraphics.FillEllipse(myBrush, New Rectangle(first.X - 1, first.Y - 1, 3, 3))
        myBrush.Dispose()
        formGraphics.Dispose()

    End Sub

    Private Sub DrawBandyBox(ByVal p1 As Point, ByVal p2 As Point)
        ' draw it a second time to erase it
        Dim rc As Rectangle
        ' Convert the points to screen coordinates.
        p1 = FloorPlan.PictureBox1.PointToScreen(p1)
        p2 = FloorPlan.PictureBox1.PointToScreen(p2)
        ' Normalize the rectangle.
        If (p1.X < p2.X) Then
            rc.X = p1.X
            rc.Width = p2.X - p1.X
        Else
            rc.X = p2.X
            rc.Width = p1.X - p2.X
        End If
        If (p1.Y < p2.Y) Then
            rc.Y = p1.Y
            rc.Height = p2.Y - p1.Y
        Else
            rc.Y = p2.Y
            rc.Height = p1.Y - p2.Y
        End If
        ' Draw the reversible frame.
        ControlPaint.DrawReversibleFrame(rc, Color.Cyan, FrameStyle.Dashed)
    End Sub


End Class

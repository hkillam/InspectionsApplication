Imports System.Windows.Forms

Public Class InspectionTools


    Private Sub AddRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRegion.Click
        FloorPlan.currentmousemode = FloorPlan.MouseMode.AddingRegion
        AddRegion.BackColor = Color.Gray
    End Sub

    Private Sub ZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomIn.Click
        FloorPlan.Zoom(0.1)

    End Sub

    Private Sub Button_zoomout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_zoomout.Click
        FloorPlan.Zoom(-0.1)
    End Sub
End Class

Public Class SelectSystem

    Private Sub SystemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SystemsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.InspectionsDataSet1)

    End Sub

    Private Sub SelectSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.SystemsTableAdapter.FillByParentID(Me.InspectionsDataSet1.Systems, 0)
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Close()

    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        MsgBox("The next dialog has not been created yet.")
        Close()

    End Sub

    Private Sub SystemsComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SystemsComboBox.SelectedIndexChanged
        SubSystemCB.Enabled = True
        ClearComboBox(SubSystemCB)
        FillComboBox(SubSystemCB, SystemsComboBox.SelectedValue)
    End Sub

    Private Sub ClearComboBox(cb As ComboBox)
        While cb.Items.Count > 0
            cb.Items.RemoveAt(0)
        End While
    End Sub

    Private Sub FillComboBox(cb As ComboBox, parentid As Integer)
        MsgBox(parentid)

        ' update combobox with floors for current building
        Dim systemQuery = From currsys In InspectionsDataSet1.Systems _
        Where currsys.ParentCode = parentid _
        Select currsys


        For Each systemrow In systemQuery
            cb.Items.Add(systemrow.Name)
            MsgBox(systemrow.Name)
            'cb.itemdata(cb.newindex) = systemrow.ID
            'SetItemData(cb, cb.Items.Count() - 1, systemrow.ID)

        Next

    End Sub
End Class
﻿Public Class ucrSelectorByDataFrameAddRemove
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub btnDataOptions_Click(sender As Object, e As EventArgs) Handles btnDataOptions.Click
        ShowDataOptionsDialog()
    End Sub

    Public Sub ShowColumnSelector(bShow As Boolean)
        btnAdd.Visible = bShow
        btnDataOptions.Visible = bShow
        lstAvailableVariable.Visible = bShow
    End Sub

    Public Overrides Sub SetVariablesEnabled(bEnable As Boolean)
        MyBase.SetVariablesEnabled(bEnable)
        btnAdd.Enabled = bEnable
    End Sub
End Class

﻿' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgLockUnlock
    Private Sub dlgLockUnlock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        defaultSettings()
    End Sub
    Private Sub defaultSettings()
        rdoLock.Checked = True
        ucrReceiverLockUnlock.lstSelectedVariables.Items.Clear()
        chkReservefree.Checked = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        defaultSettings()
    End Sub
End Class
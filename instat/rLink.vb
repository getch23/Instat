﻿' CLIMSOFT - Climate Database Management System
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

Imports RDotNet
Imports System.IO
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks


Public Class RInterface
    ' R interface class. Each instance of the class has its own REngine instance
    Dim clsEngine As REngine
    Dim txtOutput As TextBox
    Dim txtLog As TextBox

    Public Sub New()

        Me.clsEngine = REngine.GetInstance()
        Me.clsEngine.Initialize()

    End Sub

    Public Sub SetOutput(tempOutput As TextBox)

        txtOutput = tempOutput

    End Sub

    Public Sub SetLog(tempLog As TextBox)

        txtLog = tempLog

    End Sub

    Public Sub LoadData()

        Dim dlgOpen As New OpenFileDialog
        Dim strExtension As String
        Dim dfDataset As DataFrame
        Dim strHolder As String

        'For importing files into the instat'
        'start the open file dialog
        dlgOpen.Filter = "Comma Separated (*.csv)|*.csv|Excel 2-5/95/97 (*.xls)|*.xls|All Files (*.*)|*.*"
        dlgOpen.Title = "Import"
        If dlgOpen.ShowDialog() = DialogResult.OK Then
            'checks if the file name is not blank'
            If dlgOpen.FileName <> "" Then
                strExtension = Path.GetExtension(dlgOpen.FileName)
                strHolder = Replace(dlgOpen.FileName, "\", "/")
                Select Case strExtension
                    Case ".csv"
                        dfDataset = clsEngine.Evaluate("data<-as.data.frame(read.table('" & strHolder & "', header = T, sep = ','))").AsDataFrame
                    Case ".xlsx" 'TODO use odbc link
                        dfDataset = clsEngine.Evaluate("require(xlsx);data<-as.data.frame(read.xlsx('" & strHolder & "', sheetName=1))").AsDataFrame
                    Case ".xls" 'TODO use odbc link
                        dfDataset = clsEngine.Evaluate("require(readxl);data<-as.data.frame(read_excel('" & strHolder & "', sheet=1))").AsDataFrame
                End Select
            Else
                MsgBox("Must have a file name!", vbInformation, "Message from Instat")
            End If
        Else
            MsgBox("No File was selected!", vbInformation, "Message From Instat")
        End If

    End Sub

    Public Sub RunScript(strScript As String)

        txtLog.Text = txtLog.Text & strScript & vbCr
        txtOutput.Text = txtOutput.Text & "> " & strScript & vbCr & Me.clsEngine.Evaluate(strScript).ToString() & vbCr

    End Sub

    Public Function GetData(strLabel As String) As DataFrame

        Return Me.clsEngine.Evaluate(strLabel).AsDataFrame()

    End Function
End Class
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDescriptiveStatistics
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
        Me.UcrDataSelection1 = New instat.ucrDataSelection()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpgraphics = New System.Windows.Forms.GroupBox()
        Me.CheckBox17 = New System.Windows.Forms.CheckBox()
        Me.CheckBox16 = New System.Windows.Forms.CheckBox()
        Me.CheckBox15 = New System.Windows.Forms.CheckBox()
        Me.CheckBox14 = New System.Windows.Forms.CheckBox()
        Me.UcrButtons1 = New instat.ucrButtons()
        Me.grpgraphics.SuspendLayout()
        Me.SuspendLayout()
        '
        'UcrDataSelection1
        '
        Me.UcrDataSelection1.Location = New System.Drawing.Point(2, 3)
        Me.UcrDataSelection1.Name = "UcrDataSelection1"
        Me.UcrDataSelection1.Size = New System.Drawing.Size(366, 122)
        Me.UcrDataSelection1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 23)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "Choose Statistics "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpgraphics
        '
        Me.grpgraphics.Controls.Add(Me.CheckBox17)
        Me.grpgraphics.Controls.Add(Me.CheckBox16)
        Me.grpgraphics.Controls.Add(Me.CheckBox15)
        Me.grpgraphics.Location = New System.Drawing.Point(76, 164)
        Me.grpgraphics.Name = "grpgraphics"
        Me.grpgraphics.Size = New System.Drawing.Size(292, 28)
        Me.grpgraphics.TabIndex = 89
        Me.grpgraphics.TabStop = False
        '
        'CheckBox17
        '
        Me.CheckBox17.AutoSize = True
        Me.CheckBox17.Location = New System.Drawing.Point(157, 5)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox17.TabIndex = 61
        Me.CheckBox17.Text = "Cumulative frequency"
        Me.CheckBox17.UseVisualStyleBackColor = True
        '
        'CheckBox16
        '
        Me.CheckBox16.AutoSize = True
        Me.CheckBox16.Location = New System.Drawing.Point(96, 6)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox16.TabIndex = 60
        Me.CheckBox16.Text = "Box Plot"
        Me.CheckBox16.UseVisualStyleBackColor = True
        '
        'CheckBox15
        '
        Me.CheckBox15.AutoSize = True
        Me.CheckBox15.Location = New System.Drawing.Point(7, 5)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox15.TabIndex = 1
        Me.CheckBox15.Text = "Stem and leaf"
        Me.CheckBox15.UseVisualStyleBackColor = True
        '
        'CheckBox14
        '
        Me.CheckBox14.AutoSize = True
        Me.CheckBox14.Location = New System.Drawing.Point(7, 170)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox14.TabIndex = 88
        Me.CheckBox14.Text = "Graphics "
        Me.CheckBox14.UseVisualStyleBackColor = True
        '
        'UcrButtons1
        '
        Me.UcrButtons1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.UcrButtons1.Location = New System.Drawing.Point(0, 218)
        Me.UcrButtons1.Name = "UcrButtons1"
        Me.UcrButtons1.Size = New System.Drawing.Size(372, 30)
        Me.UcrButtons1.TabIndex = 91
        '
        'dlgDescriptiveStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 248)
        Me.Controls.Add(Me.UcrButtons1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.grpgraphics)
        Me.Controls.Add(Me.CheckBox14)
        Me.Controls.Add(Me.UcrDataSelection1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgDescriptiveStatistics"
        Me.Text = "dlgDescriptiveStatistics"
        Me.grpgraphics.ResumeLayout(False)
        Me.grpgraphics.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrDataSelection1 As ucrDataSelection
    Friend WithEvents Button1 As Button
    Friend WithEvents grpgraphics As GroupBox
    Friend WithEvents CheckBox17 As CheckBox
    Friend WithEvents CheckBox16 As CheckBox
    Friend WithEvents CheckBox15 As CheckBox
    Friend WithEvents CheckBox14 As CheckBox
    Friend WithEvents UcrButtons1 As ucrButtons
End Class
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        btnNew = New Button()
        panelList = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' btnNew
        ' 
        btnNew.ForeColor = SystemColors.ControlText
        btnNew.Location = New Point(356, 80)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(109, 36)
        btnNew.TabIndex = 0
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = True
        ' 
        ' panelList
        ' 
        panelList.AutoScroll = True
        panelList.Location = New Point(101, 155)
        panelList.Name = "panelList"
        panelList.Size = New Size(601, 253)
        panelList.TabIndex = 2
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(panelList)
        Controls.Add(btnNew)
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnNew As Button
    Friend WithEvents panelList As FlowLayoutPanel
End Class

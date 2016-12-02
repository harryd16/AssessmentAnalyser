<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class winMarkEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(winMarkEntry))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabManual = New System.Windows.Forms.TabPage
        Me.txtClassSize = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnRemoveMark = New System.Windows.Forms.Button
        Me.lblCount2 = New System.Windows.Forms.Label
        Me.lblMark2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblCount1 = New System.Windows.Forms.Label
        Me.txtMark1 = New System.Windows.Forms.TextBox
        Me.lblMarkCap = New System.Windows.Forms.Label
        Me.btnAddMark = New System.Windows.Forms.Button
        Me.txtManualFileMarkOutOf = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ShapeContainer3 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape5 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.rctClassMarksFrame = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.tabOpenFile = New System.Windows.Forms.TabPage
        Me.lblPath = New System.Windows.Forms.Label
        Me.btnOpenFile = New System.Windows.Forms.Button
        Me.lblOpenFileDescription = New System.Windows.Forms.Label
        Me.txtFilePath = New System.Windows.Forms.TextBox
        Me.txtFileMarkOutOf = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ShapeContainer4 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.TabControl1.SuspendLayout()
        Me.tabManual.SuspendLayout()
        Me.tabOpenFile.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabOpenFile)
        Me.TabControl1.Controls.Add(Me.tabManual)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(402, 523)
        Me.TabControl1.TabIndex = 1
        '
        'tabManual
        '
        Me.tabManual.Controls.Add(Me.txtClassSize)
        Me.tabManual.Controls.Add(Me.Label6)
        Me.tabManual.Controls.Add(Me.btnRemoveMark)
        Me.tabManual.Controls.Add(Me.lblCount2)
        Me.tabManual.Controls.Add(Me.lblMark2)
        Me.tabManual.Controls.Add(Me.Label7)
        Me.tabManual.Controls.Add(Me.Label5)
        Me.tabManual.Controls.Add(Me.lblCount1)
        Me.tabManual.Controls.Add(Me.txtMark1)
        Me.tabManual.Controls.Add(Me.lblMarkCap)
        Me.tabManual.Controls.Add(Me.btnAddMark)
        Me.tabManual.Controls.Add(Me.txtManualFileMarkOutOf)
        Me.tabManual.Controls.Add(Me.Label3)
        Me.tabManual.Controls.Add(Me.Label4)
        Me.tabManual.Controls.Add(Me.ShapeContainer3)
        Me.tabManual.Location = New System.Drawing.Point(4, 22)
        Me.tabManual.Name = "tabManual"
        Me.tabManual.Padding = New System.Windows.Forms.Padding(3)
        Me.tabManual.Size = New System.Drawing.Size(394, 497)
        Me.tabManual.TabIndex = 0
        Me.tabManual.Text = "Manual Entry"
        Me.tabManual.UseVisualStyleBackColor = True
        '
        'txtClassSize
        '
        Me.txtClassSize.Location = New System.Drawing.Point(148, 136)
        Me.txtClassSize.Name = "txtClassSize"
        Me.txtClassSize.Size = New System.Drawing.Size(88, 20)
        Me.txtClassSize.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(143, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Class Size (optional)"
        '
        'btnRemoveMark
        '
        Me.btnRemoveMark.Location = New System.Drawing.Point(205, 310)
        Me.btnRemoveMark.Name = "btnRemoveMark"
        Me.btnRemoveMark.Size = New System.Drawing.Size(86, 23)
        Me.btnRemoveMark.TabIndex = 19
        Me.btnRemoveMark.Text = "Remove Mark"
        Me.btnRemoveMark.UseVisualStyleBackColor = True
        '
        'lblCount2
        '
        Me.lblCount2.AutoSize = True
        Me.lblCount2.Location = New System.Drawing.Point(121, 266)
        Me.lblCount2.Name = "lblCount2"
        Me.lblCount2.Size = New System.Drawing.Size(16, 13)
        Me.lblCount2.TabIndex = 18
        Me.lblCount2.Text = "2."
        '
        'lblMark2
        '
        Me.lblMark2.Location = New System.Drawing.Point(143, 263)
        Me.lblMark2.Name = "lblMark2"
        Me.lblMark2.Size = New System.Drawing.Size(100, 20)
        Me.lblMark2.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "/ _"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(159, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Class Marks"
        '
        'lblCount1
        '
        Me.lblCount1.AutoSize = True
        Me.lblCount1.Location = New System.Drawing.Point(121, 236)
        Me.lblCount1.Name = "lblCount1"
        Me.lblCount1.Size = New System.Drawing.Size(16, 13)
        Me.lblCount1.TabIndex = 14
        Me.lblCount1.Text = "1."
        '
        'txtMark1
        '
        Me.txtMark1.Location = New System.Drawing.Point(143, 233)
        Me.txtMark1.Name = "txtMark1"
        Me.txtMark1.Size = New System.Drawing.Size(100, 20)
        Me.txtMark1.TabIndex = 13
        '
        'lblMarkCap
        '
        Me.lblMarkCap.AutoSize = True
        Me.lblMarkCap.Location = New System.Drawing.Point(249, 236)
        Me.lblMarkCap.Name = "lblMarkCap"
        Me.lblMarkCap.Size = New System.Drawing.Size(21, 13)
        Me.lblMarkCap.TabIndex = 12
        Me.lblMarkCap.Text = "/ _"
        '
        'btnAddMark
        '
        Me.btnAddMark.Location = New System.Drawing.Point(103, 310)
        Me.btnAddMark.Name = "btnAddMark"
        Me.btnAddMark.Size = New System.Drawing.Size(86, 23)
        Me.btnAddMark.TabIndex = 11
        Me.btnAddMark.Text = "Add Mark"
        Me.btnAddMark.UseVisualStyleBackColor = True
        '
        'txtManualFileMarkOutOf
        '
        Me.txtManualFileMarkOutOf.Location = New System.Drawing.Point(195, 47)
        Me.txtManualFileMarkOutOf.Name = "txtManualFileMarkOutOf"
        Me.txtManualFileMarkOutOf.Size = New System.Drawing.Size(53, 20)
        Me.txtManualFileMarkOutOf.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(110, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "What mark is the assessment out of?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "MARK /"
        '
        'ShapeContainer3
        '
        Me.ShapeContainer3.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer3.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer3.Name = "ShapeContainer3"
        Me.ShapeContainer3.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape5, Me.rctClassMarksFrame, Me.RectangleShape3})
        Me.ShapeContainer3.Size = New System.Drawing.Size(388, 491)
        Me.ShapeContainer3.TabIndex = 10
        Me.ShapeContainer3.TabStop = False
        '
        'RectangleShape5
        '
        Me.RectangleShape5.Location = New System.Drawing.Point(26, 114)
        Me.RectangleShape5.Name = "RectangleShape5"
        Me.RectangleShape5.Size = New System.Drawing.Size(334, 54)
        '
        'rctClassMarksFrame
        '
        Me.rctClassMarksFrame.Location = New System.Drawing.Point(26, 207)
        Me.rctClassMarksFrame.Name = "rctClassMarksFrame"
        Me.rctClassMarksFrame.Size = New System.Drawing.Size(334, 135)
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(26, 27)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(334, 54)
        '
        'tabOpenFile
        '
        Me.tabOpenFile.Controls.Add(Me.lblPath)
        Me.tabOpenFile.Controls.Add(Me.btnOpenFile)
        Me.tabOpenFile.Controls.Add(Me.lblOpenFileDescription)
        Me.tabOpenFile.Controls.Add(Me.txtFilePath)
        Me.tabOpenFile.Controls.Add(Me.txtFileMarkOutOf)
        Me.tabOpenFile.Controls.Add(Me.Label1)
        Me.tabOpenFile.Controls.Add(Me.Label2)
        Me.tabOpenFile.Controls.Add(Me.ShapeContainer4)
        Me.tabOpenFile.Location = New System.Drawing.Point(4, 22)
        Me.tabOpenFile.Name = "tabOpenFile"
        Me.tabOpenFile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOpenFile.Size = New System.Drawing.Size(394, 497)
        Me.tabOpenFile.TabIndex = 1
        Me.tabOpenFile.Text = "Open File"
        Me.tabOpenFile.UseVisualStyleBackColor = True
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(159, 126)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(47, 13)
        Me.lblPath.TabIndex = 4
        Me.lblPath.Text = "File path"
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(274, 152)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(75, 23)
        Me.btnOpenFile.TabIndex = 0
        Me.btnOpenFile.Text = "Open"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'lblOpenFileDescription
        '
        Me.lblOpenFileDescription.AutoSize = True
        Me.lblOpenFileDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenFileDescription.Location = New System.Drawing.Point(81, 186)
        Me.lblOpenFileDescription.Name = "lblOpenFileDescription"
        Me.lblOpenFileDescription.Size = New System.Drawing.Size(212, 13)
        Me.lblOpenFileDescription.TabIndex = 1
        Me.lblOpenFileDescription.Text = "Each mark must be on a new line in the file."
        '
        'txtFilePath
        '
        Me.txtFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilePath.Location = New System.Drawing.Point(45, 154)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(223, 20)
        Me.txtFilePath.TabIndex = 2
        Me.txtFilePath.Tag = ""
        Me.txtFilePath.WordWrap = False
        '
        'txtFileMarkOutOf
        '
        Me.txtFileMarkOutOf.Location = New System.Drawing.Point(195, 47)
        Me.txtFileMarkOutOf.Name = "txtFileMarkOutOf"
        Me.txtFileMarkOutOf.Size = New System.Drawing.Size(53, 20)
        Me.txtFileMarkOutOf.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "What mark is the assessment out of?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "MARK /"
        '
        'ShapeContainer4
        '
        Me.ShapeContainer4.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer4.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer4.Name = "ShapeContainer4"
        Me.ShapeContainer4.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer4.Size = New System.Drawing.Size(388, 491)
        Me.ShapeContainer4.TabIndex = 8
        Me.ShapeContainer4.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(26, 27)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(334, 54)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(26, 132)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(334, 72)
        '
        'winMarkEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(402, 523)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "winMarkEntry"
        Me.Text = "Data Entry"
        Me.TabControl1.ResumeLayout(False)
        Me.tabManual.ResumeLayout(False)
        Me.tabManual.PerformLayout()
        Me.tabOpenFile.ResumeLayout(False)
        Me.tabOpenFile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabManual As System.Windows.Forms.TabPage
    Friend WithEvents tabOpenFile As System.Windows.Forms.TabPage
    Friend WithEvents btnOpenFile As System.Windows.Forms.Button
    Friend WithEvents txtFilePath As System.Windows.Forms.TextBox
    Friend WithEvents lblOpenFileDescription As System.Windows.Forms.Label
    Friend WithEvents txtFileMarkOutOf As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPath As System.Windows.Forms.Label
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtManualFileMarkOutOf As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer3 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents rctClassMarksFrame As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblCount1 As System.Windows.Forms.Label
    Friend WithEvents txtMark1 As System.Windows.Forms.TextBox
    Friend WithEvents lblMarkCap As System.Windows.Forms.Label
    Friend WithEvents btnAddMark As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer4 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lblCount2 As System.Windows.Forms.Label
    Friend WithEvents lblMark2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnRemoveMark As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RectangleShape5 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtClassSize As System.Windows.Forms.TextBox
End Class

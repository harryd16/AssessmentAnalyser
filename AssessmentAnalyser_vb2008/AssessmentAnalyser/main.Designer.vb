<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.barChart = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtStatStandardDeviation = New System.Windows.Forms.TextBox
        Me.lblStandardDeviation = New System.Windows.Forms.Label
        Me.lblStatLowest = New System.Windows.Forms.Label
        Me.txtStatLowest = New System.Windows.Forms.TextBox
        Me.lblStatHighest = New System.Windows.Forms.Label
        Me.txtStatHighest = New System.Windows.Forms.TextBox
        Me.lblStatMedian = New System.Windows.Forms.Label
        Me.txtStatMode = New System.Windows.Forms.TextBox
        Me.lblStatMode = New System.Windows.Forms.Label
        Me.lblStatMean = New System.Windows.Forms.Label
        Me.txtStatMedian = New System.Windows.Forms.TextBox
        Me.txtStatMean = New System.Windows.Forms.TextBox
        CType(Me.barChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'barChart
        '
        Me.barChart.BackColor = System.Drawing.Color.CornflowerBlue
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Name = "ChartArea1"
        Me.barChart.ChartAreas.Add(ChartArea1)
        Me.barChart.Cursor = System.Windows.Forms.Cursors.Cross
        Me.barChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Enabled = False
        Legend1.Name = "Legend1"
        Me.barChart.Legends.Add(Legend1)
        Me.barChart.Location = New System.Drawing.Point(0, 0)
        Me.barChart.Margin = New System.Windows.Forms.Padding(25, 3, 25, 3)
        Me.barChart.Name = "barChart"
        Me.barChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series1.BackSecondaryColor = System.Drawing.Color.Transparent
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "chartOne"
        Series1.YValuesPerPoint = 2
        Me.barChart.Series.Add(Series1)
        Me.barChart.Size = New System.Drawing.Size(1041, 681)
        Me.barChart.TabIndex = 0
        Me.barChart.Text = "chart"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Title1.Name = "Band"
        Title1.Text = "Band"
        Title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Title2.Name = "NumberOfStudents"
        Title2.Text = "Number of Students"
        Me.barChart.Titles.Add(Title1)
        Me.barChart.Titles.Add(Title2)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.barChart)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtStatStandardDeviation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStandardDeviation)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatLowest)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtStatLowest)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatHighest)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtStatHighest)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatMedian)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtStatMode)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatMode)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblStatMean)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtStatMedian)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtStatMean)
        Me.SplitContainer1.Size = New System.Drawing.Size(1264, 681)
        Me.SplitContainer1.SplitterDistance = 1041
        Me.SplitContainer1.TabIndex = 1
        '
        'txtStatStandardDeviation
        '
        Me.txtStatStandardDeviation.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatStandardDeviation.Location = New System.Drawing.Point(60, 528)
        Me.txtStatStandardDeviation.Name = "txtStatStandardDeviation"
        Me.txtStatStandardDeviation.Size = New System.Drawing.Size(100, 20)
        Me.txtStatStandardDeviation.TabIndex = 16
        Me.txtStatStandardDeviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStandardDeviation
        '
        Me.lblStandardDeviation.AutoSize = True
        Me.lblStandardDeviation.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStandardDeviation.Location = New System.Drawing.Point(62, 512)
        Me.lblStandardDeviation.Name = "lblStandardDeviation"
        Me.lblStandardDeviation.Size = New System.Drawing.Size(98, 13)
        Me.lblStandardDeviation.TabIndex = 15
        Me.lblStandardDeviation.Text = "Standard Deviation"
        '
        'lblStatLowest
        '
        Me.lblStatLowest.AutoSize = True
        Me.lblStatLowest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatLowest.Location = New System.Drawing.Point(88, 421)
        Me.lblStatLowest.Name = "lblStatLowest"
        Me.lblStatLowest.Size = New System.Drawing.Size(41, 13)
        Me.lblStatLowest.TabIndex = 14
        Me.lblStatLowest.Text = "Lowest"
        '
        'txtStatLowest
        '
        Me.txtStatLowest.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatLowest.Location = New System.Drawing.Point(60, 440)
        Me.txtStatLowest.Name = "txtStatLowest"
        Me.txtStatLowest.Size = New System.Drawing.Size(100, 20)
        Me.txtStatLowest.TabIndex = 13
        Me.txtStatLowest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStatHighest
        '
        Me.lblStatHighest.AutoSize = True
        Me.lblStatHighest.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatHighest.Location = New System.Drawing.Point(88, 333)
        Me.lblStatHighest.Name = "lblStatHighest"
        Me.lblStatHighest.Size = New System.Drawing.Size(43, 13)
        Me.lblStatHighest.TabIndex = 12
        Me.lblStatHighest.Text = "Highest"
        '
        'txtStatHighest
        '
        Me.txtStatHighest.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatHighest.Location = New System.Drawing.Point(60, 352)
        Me.txtStatHighest.Name = "txtStatHighest"
        Me.txtStatHighest.Size = New System.Drawing.Size(100, 20)
        Me.txtStatHighest.TabIndex = 11
        Me.txtStatHighest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStatMedian
        '
        Me.lblStatMedian.AutoSize = True
        Me.lblStatMedian.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatMedian.Location = New System.Drawing.Point(87, 160)
        Me.lblStatMedian.Name = "lblStatMedian"
        Me.lblStatMedian.Size = New System.Drawing.Size(42, 13)
        Me.lblStatMedian.TabIndex = 10
        Me.lblStatMedian.Text = "Median"
        '
        'txtStatMode
        '
        Me.txtStatMode.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatMode.Location = New System.Drawing.Point(60, 264)
        Me.txtStatMode.Name = "txtStatMode"
        Me.txtStatMode.Size = New System.Drawing.Size(100, 20)
        Me.txtStatMode.TabIndex = 9
        Me.txtStatMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblStatMode
        '
        Me.lblStatMode.AutoSize = True
        Me.lblStatMode.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatMode.Location = New System.Drawing.Point(88, 248)
        Me.lblStatMode.Name = "lblStatMode"
        Me.lblStatMode.Size = New System.Drawing.Size(45, 13)
        Me.lblStatMode.TabIndex = 8
        Me.lblStatMode.Text = "Mode(s)"
        '
        'lblStatMean
        '
        Me.lblStatMean.AutoSize = True
        Me.lblStatMean.ForeColor = System.Drawing.SystemColors.Control
        Me.lblStatMean.Location = New System.Drawing.Point(88, 72)
        Me.lblStatMean.Name = "lblStatMean"
        Me.lblStatMean.Size = New System.Drawing.Size(34, 13)
        Me.lblStatMean.TabIndex = 7
        Me.lblStatMean.Text = "Mean"
        '
        'txtStatMedian
        '
        Me.txtStatMedian.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatMedian.Location = New System.Drawing.Point(60, 176)
        Me.txtStatMedian.Name = "txtStatMedian"
        Me.txtStatMedian.Size = New System.Drawing.Size(100, 20)
        Me.txtStatMedian.TabIndex = 1
        Me.txtStatMedian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtStatMean
        '
        Me.txtStatMean.BackColor = System.Drawing.SystemColors.Control
        Me.txtStatMean.Location = New System.Drawing.Point(60, 88)
        Me.txtStatMean.Name = "txtStatMean"
        Me.txtStatMean.Size = New System.Drawing.Size(100, 20)
        Me.txtStatMean.TabIndex = 0
        Me.txtStatMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Assessment Analyser"
        CType(Me.barChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents barChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblStatMedian As System.Windows.Forms.Label
    Friend WithEvents txtStatMode As System.Windows.Forms.TextBox
    Friend WithEvents lblStatMode As System.Windows.Forms.Label
    Friend WithEvents lblStatMean As System.Windows.Forms.Label
    Friend WithEvents txtStatMedian As System.Windows.Forms.TextBox
    Friend WithEvents txtStatMean As System.Windows.Forms.TextBox
    Friend WithEvents lblStatLowest As System.Windows.Forms.Label
    Friend WithEvents txtStatLowest As System.Windows.Forms.TextBox
    Friend WithEvents lblStatHighest As System.Windows.Forms.Label
    Friend WithEvents txtStatHighest As System.Windows.Forms.TextBox
    Friend WithEvents txtStatStandardDeviation As System.Windows.Forms.TextBox
    Friend WithEvents lblStandardDeviation As System.Windows.Forms.Label
End Class

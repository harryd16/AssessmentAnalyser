' Assessment Analyser - Spin your boring marking results into a spectacularly ordered graph
' Harrison Doran
' 31 November 2016

Imports Microsoft.VisualBasic.FileIO


Public Class main

    Public Sub sortNumbers()
        ' Bubble sorting procedure

        Dim i As Integer = 0 ' Start of array
        Dim last As Integer = globalClassSize ' End of array
        Dim j, num1 As Integer

        While last > i ' Loop until all sorted
            j = i
            While j < last - 1
                If globalMarkArray(j) > globalMarkArray(j + 1) Then
                    num1 = globalMarkArray(j)
                    globalMarkArray(j) = globalMarkArray(j + 1)
                    globalMarkArray(j + 1) = num1
                End If
                j = j + 1
            End While
            last = last - 1
        End While

    End Sub

    Public Sub graphMarks()
        ' Graph all marking results as bar chart

        ' Prepare BandArray for 
        globalBandArray(0) = 0
        globalBandArray(1) = 0
        globalBandArray(2) = 0
        globalBandArray(3) = 0
        globalBandArray(4) = 0
        globalBandArray(5) = 0
        Dim bandOne As Integer = globalBandArray(0)
        Dim bandTwo As Integer = globalBandArray(1)
        Dim bandThree As Integer = globalBandArray(2)
        Dim bandFour As Integer = globalBandArray(3)
        Dim bandFive As Integer = globalBandArray(4)
        Dim bandSix As Integer = globalBandArray(5)


        Dim lowBandSix, lowBandFive, lowBandFour, lowBandThree, lowBandTwo As Integer

        ' Calculate band ranges
        lowBandSix = Math.Ceiling((90 / 100) * globalMaxMark)
        lowBandFive = Math.Ceiling((80 / 100) * globalMaxMark)
        lowBandFour = Math.Ceiling((70 / 100) * globalMaxMark)
        lowBandThree = Math.Ceiling((60 / 100) * globalMaxMark)
        lowBandTwo = Math.Ceiling((50 / 100) * globalMaxMark)

        Dim highestMark As Integer = globalMarkArray(0)
        Dim lowestMark As Integer = globalMarkArray(0)
        Dim totalMarks As Integer = 0

        For Each mark In globalMarkArray ' Grouping marks into bands 1-6
            Select Case mark
                Case lowBandSix To globalMaxMark
                    bandSix += 1
                Case lowBandFive To lowBandSix - 1
                    bandFive += 1
                Case lowBandFour To lowBandFive - 1
                    bandFour += 1
                Case lowBandThree To lowBandFour - 1
                    bandThree += 1
                Case lowBandTwo To lowBandThree - 1
                    bandTwo += 1
                Case Else
                    bandOne += 1
            End Select

            totalMarks += mark ' Grab total 

            If mark > highestMark Then ' Grab highest and lowest
                highestMark = mark
            End If
            If mark < lowestMark Then
                lowestMark = mark
            End If

        Next

        ' Clear chart
        barChart.Series("chartOne").Points.Clear()
        ' Update chart with band scores
        barChart.Series("chartOne").Points.AddY(bandOne)
        barChart.Series("chartOne").Points.AddY(bandTwo)
        barChart.Series("chartOne").Points.AddY(bandThree)
        barChart.Series("chartOne").Points.AddY(bandFour)
        barChart.Series("chartOne").Points.AddY(bandFive)
        barChart.Series("chartOne").Points.AddY(bandSix)

        ' Tooltip
        toolTipCaption = "Band Six: " & bandSix & vbNewLine & "Band Five: " & bandFive & vbNewLine & "Band Four: " & bandFour & vbNewLine & "Band Three: " & bandThree & vbNewLine & "Band Two: " & bandTwo & vbNewLine & "Band One: " & bandOne

        ' STATISTICS

        ' Highest & lowest (calculated above)
        txtStatHighest.Text = highestMark
        txtStatLowest.Text = lowestMark

        ' Mean
        Dim mean As Double = totalMarks / globalClassSize
        txtStatMean.Text = Math.Round(mean, 5)

        ' Median
        If (globalClassSize Mod 2) = 1 Then
            txtStatMedian.Text = globalMarkArray((globalClassSize / 2) + 1)
        Else
            txtStatMedian.Text = (globalMarkArray(globalClassSize / 2) + globalMarkArray((globalClassSize / 2) + 1) / 2)
        End If

        ' Mode - By .paul. 16/9/2009, http://www.vbforums.com/showthread.php?584182-RESOLVED-Mean-Median-Mode&p=3609014&viewfull=1#post3609014
        Dim d As New Dictionary(Of Integer, Integer)

        For x As Integer = 0 To globalMarkArray.GetUpperBound(0)
            If d.ContainsKey(globalMarkArray(x)) Then
                d.Item(globalMarkArray(x)) += 1
            Else
                d.Add(globalMarkArray(x), 1)
            End If
        Next

        Dim items = From k In d.Keys _
                  Order By d(k) Descending _
                  Select k

        Dim highest As Integer = 0
        Dim values As String = ""

        For Each k As String In items
            If d(k) > highest Then
                highest = d(k) : values &= k & ", "
            ElseIf d(k) = highest Then
                values &= k & ", "
            End If
        Next
        txtStatMode.Text = values.Remove(values.Length - 2, 2)


        ' Standard deviation - By käµfm³d 6/10/2012, https://www.experts-exchange.com/questions/27891130/Find-Standard-Deviation-from-VB-net-List-of-Double.html#a38470753
        Dim squares As New List(Of Double)
        Dim squareAvg As Double

        For Each value As Double In globalMarkArray
            squares.Add(Math.Pow(value - mean, 2))
        Next

        squareAvg = squares.Average()

        txtStatStandardDeviation.Text = Math.Round(Math.Sqrt(squareAvg), 5)

    End Sub

    Private Sub barChart_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles barChart.MouseHover
        ' Shows graph data as mouse tooltip

        Dim toolTipValues As New ToolTip()

        ' Set up the delays for the ToolTip
        toolTipValues.InitialDelay = 500
        toolTipValues.ReshowDelay = 500

        toolTipValues.ShowAlways = True

        toolTipValues.SetToolTip(Me.barChart, toolTipCaption)
    End Sub
End Class
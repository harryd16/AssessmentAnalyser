' Assessment Analyser - Spin your boring marking results into a spectacularly ordered graph
' Harrison Doran
' 31 November 2016

Imports System.IO
Imports System.IO.FileStream
Imports System.IO.StreamReader

Public Module globalVariable
    Public globalMaxMark As Integer
    Public globalMarkArray() As Integer
    Public globalBandArray(5) As Integer
    Public globalClassSize As Integer
    Public toolTipCaption As String = Nothing
End Module
Public Class winMarkEntry





    Private Sub txtManualFileMarkOutOf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtManualFileMarkOutOf.TextChanged

        'Textbox restriction function by Vectris on http://www.vbforums.com/showthread.php?570438-Restrict-TextBox-to-only-certain-characters-numeric-or-symbolic
        Dim charactersAllowed As String = "1234567890"

        Dim theText As String = txtManualFileMarkOutOf.Text
        Dim letter As String
        Dim SelectionIndex As Integer = txtManualFileMarkOutOf.SelectionStart
        Dim change As Integer

        For x As Integer = 0 To txtManualFileMarkOutOf.Text.Length - 1
            letter = txtManualFileMarkOutOf.Text.Substring(x, 1)
            If charactersAllowed.Contains(letter) = False Then
                theText = theText.Replace(letter, String.Empty)
                change = 1
            End If
        Next

        txtManualFileMarkOutOf.Text = theText
        txtManualFileMarkOutOf.Select(SelectionIndex - change, 0)

        txtFileMarkOutOf.Text = theText

        If theText <> Nothing Then
            globalMaxMark = Convert.ToInt32(theText)
            lblMarkCap.Text = "/ " + theText
        End If
        
    End Sub


    Private Sub RemoveMarkEntry()
        ' Remove last mark entry field from manual entry list
    End Sub

    Private Sub txtFileMarkOutOf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFileMarkOutOf.TextChanged
        If (txtFileMarkOutOf.Text.Length > 6) Or (txtManualFileMarkOutOf.Text.Length > 6) Then
            txtFileMarkOutOf.Text.Replace(txtFileMarkOutOf.Text, String.Empty)
            MessageBox.Show("6 Digit Maxium.", "Overflow")
        End If

        'Textbox restriction function by Vectris on http://www.vbforums.com/showthread.php?570438-Restrict-TextBox-to-only-certain-characters-numeric-or-symbolic
        Dim charactersAllowed As String = "1234567890"

        Dim theText As String = txtFileMarkOutOf.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtFileMarkOutOf.SelectionStart
        Dim change As Integer

        For x As Integer = 0 To txtFileMarkOutOf.Text.Length - 1
            Letter = txtFileMarkOutOf.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then

                theText = theText.Replace(Letter, String.Empty)
                change = 1
            End If
        Next

        txtFileMarkOutOf.Text = theText
        txtFileMarkOutOf.Select(SelectionIndex - change, 0)

        txtManualFileMarkOutOf.Text = theText
        If theText <> Nothing Then
            globalMaxMark = Convert.ToInt32(txtFileMarkOutOf.Text) ' Set as global maxMark variable
        End If


    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        If txtFileMarkOutOf.Text = Nothing Then
            MessageBox.Show("You must enter the maximum assessment mark.", "Data Missing", MessageBoxButtons.OK)
        Else
            ' Load marks from file to array
            Dim path As String = txtFilePath.Text

            Dim count As Integer = 0

            If File.Exists(path) Then
                Dim lines() As String = IO.File.ReadAllLines(path)
                For Each line As Integer In lines
                    ReDim Preserve globalMarkArray(count)
                    globalMarkArray(count) = line
                    count += 1
                Next
                globalClassSize = count


                main.sortNumbers()

                main.graphMarks()
            Else
                MessageBox.Show("The file or file path is incorrect.", "ERROR")
            End If


        End If

       

    End Sub

    Private Sub btnAddMark_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMark.Click
        ' Add new mark entry field trigger

        Dim addStudents As Integer
        If (globalClassSize <= 1) Or (globalClassSize = Nothing) Then
            addStudents = 1
        Else
            addStudents = globalClassSize
        End If




        ' Add N more mark entry fields

        Dim moveDistance As Integer = 31 * addStudents
        'Dim rect As New Rectangle(26, 207, 334, 135 + moveDistance)

        'Dim blackPen As New Pen(Color.Black, 1)
        'System.Windows.Forms.PaintEventArgs.DrawRectangle(blackPen, rect)

        Dim myGraphics As Graphics
        Dim myRectangle As Rectangle
        Dim myPen As New Pen(Color.Black)

        myGraphics = Graphics.FromHwnd(ActiveForm().Handle)

        myRectangle = New Rectangle(x:=26, y:=207, Width:=334, Height:=135 + moveDistance)

        myGraphics.DrawRectangle(pen:=myPen, rect:=myRectangle)



    End Sub

    Private Sub txtClassSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClassSize.TextChanged
        'Textbox restriction function by Vectris on http://www.vbforums.com/showthread.php?570438-Restrict-TextBox-to-only-certain-characters-numeric-or-symbolic
        Dim charactersAllowed As String = "1234567890"

        Dim theText As String = txtClassSize.Text
        Dim Letter As String
        Dim SelectionIndex As Integer = txtClassSize.SelectionStart
        Dim change As Integer

        For x As Integer = 0 To txtClassSize.Text.Length - 1
            Letter = txtClassSize.Text.Substring(x, 1)
            If charactersAllowed.Contains(Letter) = False Then
                theText = theText.Replace(Letter, String.Empty)
                change = 1
            End If
        Next

        txtClassSize.Text = theText
        txtClassSize.Select(SelectionIndex - change, 0)


        globalClassSize = Convert.ToInt32(theText)

        ReDim globalMarkArray(globalClassSize - 1)

    End Sub

    Private Sub txtMark1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMark1.TextChanged

        globalMarkArray(0) = txtMark1.Text
    End Sub

    Private Sub TabControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        MessageBox.Show("'Manual Entry' will be added in a later update. Please input marks via a file, refer to documentation on startup for help.", "Unavailable feature", MessageBoxButtons.OK)
    End Sub
End Class
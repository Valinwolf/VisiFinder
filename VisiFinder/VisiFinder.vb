Imports System.IO
Imports EyeOpen.Imaging.Processing

Public Class VisiFinder
    Public ImageList As New List(Of SimilarityImages)
    Public OperationStart As Date
    Public CurrentImage As Integer = 0

    Private Sub VisiFinder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        folderTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
        SetStatus("Application Loaded.")
    End Sub

    Private Sub SetStatus(ByVal Status As String)
        StatusLabel.Text = "Status: " & Status
    End Sub

    Private Sub SetProgress(ByVal Progress As Integer, ByVal Total As Integer)
        If Not workingProgressBar.Maximum = Total Then workingProgressBar.Value = 0
        workingProgressBar.Maximum = Total
        workingProgressBar.Value = Progress
        Dim Percentage = Math.Round((workingProgressBar.Value / workingProgressBar.Maximum), 3)
        ProgressLabel.Text = String.Format("Progress: {0} of {1} ({2})", workingProgressBar.Value, workingProgressBar.Maximum, Percentage.ToString("P"))
    End Sub

    Private Sub SetDups()
        If ImageList.Count = 1 Then
            StageLabel.Text = "1 Duplicate"
            ShowSelectedImage()
        ElseIf ImageList.Count > 1 Then
            StageLabel.Text = ImageList.Count & " Duplicates"
            ShowSelectedImage()
        Else
            StageLabel.Text = "No Duplicates"
        End If
    End Sub

    Private Sub ProcessImages(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles imageComparer.DoWork
#Region "Args"
        Dim MinSim As Integer = e.Argument.MinSim
        Dim Files As FileInfo() = e.Argument.Files
        If Files.Count < 2 Then
            e.Result = New List(Of SimilarityImages)
            Exit Sub
        End If
#End Region

#Region "Special Vars"
        Dim Progress As ProgressWrapper
        Dim ComparableImages As New List(Of ComparableImage)
        Dim SortedSimilarityImages As New List(Of SimilarityImages)
#End Region

        Dim index

#Region "Image Loading"
        index = 0
        Progress = New ProgressWrapper(Files.Count, index, "Processing")
        For Each File As FileInfo In Files
            If e.Cancel Then
                Exit For
            End If
            Dim CImage As ComparableImage = New ComparableImage(File)
            ComparableImages.Add(CImage)
            index += 1
            Progress.Current = index
            imageComparer.ReportProgress(33, Progress)
        Next
#End Region

#Region "Image Comparing"
        index = 0
        Progress = New ProgressWrapper((ComparableImages.Count * (ComparableImages.Count - 1)) / 2, index, "Comparing")
        For i As Integer = 0 To ComparableImages.Count - 1
            For j As Integer = i + 1 To ComparableImages.Count - 1
                If e.Cancel Then
                    Exit For
                End If
                Dim source = ComparableImages(i)
                Dim destination = ComparableImages(j)
                Dim similarity = source.CalculateSimilarity(destination)
                Dim sim = New SimilarityImages(source, destination, similarity)
                If similarity * 100 >= MinSim Then SortedSimilarityImages.Add(sim)
                index += 1
                Progress.Current = index
                imageComparer.ReportProgress(66, Progress)
            Next
        Next
#End Region

#Region "Sort & Exit"
        Progress = New ProgressWrapper(2, 0, "Sorting")
        imageComparer.ReportProgress(99, Progress)
        SortedSimilarityImages.Sort()
        Progress.Current = 1
        imageComparer.ReportProgress(99, Progress)
        SortedSimilarityImages.Reverse()
        Progress.Current = 2
        imageComparer.ReportProgress(100, Progress)
        e.Result = SortedSimilarityImages
#End Region
    End Sub

    Private Sub ProgressUpdated(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles imageComparer.ProgressChanged
        Dim Progress As ProgressWrapper = e.UserState
        If e.ProgressPercentage = 33 Then
            StageLabel.Text = "Stage 1 of 3"
        ElseIf e.ProgressPercentage = 66 Then
            StageLabel.Text = "Stage 2 of 3"
        ElseIf e.ProgressPercentage = 99 Then
            StageLabel.Text = "Stage 3 of 3"
        Else
            StageLabel.Text = ""
        End If
        SetStatus(Progress.Status & "...")
        SetProgress(Progress.Current, Progress.Total)
    End Sub

    Private Sub ImagesProcessed(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles imageComparer.RunWorkerCompleted
        SetProgress(0, 100)
        ProgressLabel.Text = ""
        If Not e.Cancelled Then
            SetStatus("Scan Complete.")
            ImageList = e.Result
            SetDups()
        Else
            If e.Error IsNot Nothing Then
                SetStatus("ERROR")
                Debug.WriteLine(e.Error.Message)
            Else
                SetStatus("Cancelled.")
            End If
        End If
        findButton.Enabled = True
        CancelBtn.Enabled = Not findButton.Enabled
    End Sub

    Private Sub ListFiles(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles fileLister.DoWork
        Dim folder As String = folderTextBox.Text
        Dim Files As List(Of FileInfo) = FileList.GetFiles(folder, {"*.jpg", "*.png", "*.gif"})
        e.Result = Files.ToArray()
    End Sub

    Private Sub FilesListed(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles fileLister.RunWorkerCompleted
        Dim Args As ArgumentWrapper = New ArgumentWrapper(e.Result, MinMatch.Value)
        imageComparer.RunWorkerAsync(Args)
    End Sub

    Private Sub BrowseFolder(sender As Object, e As EventArgs) Handles showFoldersLinkLabel.Click
        If Directory.Exists(folderTextBox.Text) Then
            folderBrowserDialog.SelectedPath = folderTextBox.Text
        End If
        If folderBrowserDialog.ShowDialog = DialogResult.OK Then folderTextBox.Text = folderBrowserDialog.SelectedPath
    End Sub

    Private Sub BeginSearch(sender As Object, e As EventArgs) Handles findButton.Click
        OperationStart = Now
        findButton.Enabled = False
        CancelBtn.Enabled = Not findButton.Enabled
        SetStatus("Searching for images...")
        fileLister.RunWorkerAsync()
    End Sub

    Private Sub CancelSearch(sender As Object, e As EventArgs) Handles CancelBtn.Click
        If imageComparer.IsBusy Then
            imageComparer.CancelAsync()
        End If
        If fileLister.IsBusy Then
            StageLabel.Text = "Cannot Cancel Yet"
            Dim t As Timers.Timer = New Timers.Timer(5000)
            t.AutoReset = False
            AddHandler t.Elapsed, AddressOf ClearStage
            t.Start()
        End If
    End Sub

    Private Sub ExitApplication(sender As Object, e As EventArgs) Handles ExitButton.Click
        CancelSearch(sender, e)
        Dim t As Timers.Timer = New Timers.Timer(500)
        t.AutoReset = False
        AddHandler t.Elapsed, AddressOf EndApplication
        t.Start()
    End Sub

    Private Sub ClearStage()
        StageLabel.Text = ""
    End Sub

    Private Sub EndApplication()
        If Not imageComparer.IsBusy Then Application.Exit()
    End Sub

    Private Sub ShowSelectedImage()
        If ImageList.Count = 0 Then Exit Sub
        Dim sim = ImageList.Item(CurrentImage)

        Dim streamSource = New System.IO.FileStream(sim.Source.File.FullName, FileMode.Open, FileAccess.Read)
        Dim streamDestination = New System.IO.FileStream(sim.Destination.File.FullName, FileMode.Open, FileAccess.Read)
        Dim source = Image.FromStream(streamSource)
        Dim destination = Image.FromStream(streamDestination)
        streamSource.Close()
        streamDestination.Close()

        Const InfoFormat As String = "Resolution: {0}x{1}" & vbNewLine & "Size: {2}kb" & vbNewLine & "Full path: {3}"
        Const ResolutionFormat As String = "{0}: {1}" & vbNewLine & "({2}x{3})"

        sourcePictureBox.Image = source
        mainToolTip.SetToolTip(sourcePictureBox, String.Format(InfoFormat, source.Width, source.Height, Math.Round((sim.Source.File.Length / 1024), 1), sim.Source.File.FullName))
        sourceLabel.Text = String.Format(ResolutionFormat, "Source", sim.Source.File.FullName.Replace(folderTextBox.Text & "\", ""), source.Width, source.Height)

        destinationPictureBox.Image = destination
        mainToolTip.SetToolTip(destinationPictureBox, String.Format(InfoFormat, destination.Width, destination.Height, Math.Round((sim.Destination.File.Length / 1024), 1), sim.Destination.File.FullName))
        destinationLabel.Text = String.Format(ResolutionFormat, "Destination", sim.Destination.File.FullName.Replace(folderTextBox.Text & "\", ""), destination.Width, destination.Height)

        simLabel.Text = sim.Similarity & "% Match"
    End Sub

    Private Sub NextImage(sender As Object, e As EventArgs) Handles nextButton.Click
        If Not ImageList.Count = 1 And CurrentImage = ImageList.Count - 1 Then
            CurrentImage = 0
        ElseIf CurrentImage + 1 < ImageList.Count Then
            CurrentImage += 1
        End If
        ShowSelectedImage()
    End Sub

    Private Sub PreviousImage(sender As Object, e As EventArgs) Handles previousButton.Click
        If Not ImageList.Count = 1 And CurrentImage = 0 Then
            CurrentImage = ImageList.Count - 1
        ElseIf CurrentImage - 1 >= 0 Then
            CurrentImage -= 1
        End If
        ShowSelectedImage()
    End Sub

    Private Sub DeleteSource(sender As Object, e As EventArgs) Handles deleteSourceLinkLabel.Click
        imageDeleter.RunWorkerAsync(New Object() {ImageList.Item(CurrentImage).Source.File, ImageList})
    End Sub

    Private Sub DeleteDestination(sender As Object, e As EventArgs) Handles deleteDestinationLinkLabel.Click
        imageDeleter.RunWorkerAsync(New Object() {ImageList.Item(CurrentImage).Destination.File, ImageList})
    End Sub

    Private Sub OpenSource(sender As Object, e As EventArgs) Handles openSourceLinkLabel.Click

    End Sub

    Private Sub OpenDestination(sender As Object, e As EventArgs) Handles openDestinationLinkLabel.Click

    End Sub

    Private Sub DeleteImage(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles imageDeleter.DoWork
        Dim Args As Object() = e.Argument
        Dim fi As FileInfo = Args(0)
        Dim il As List(Of SimilarityImages) = Args(1)
        Dim il_del As New List(Of SimilarityImages)
        For Each i As SimilarityImages In il.ToArray()
            If i.Destination.File.Equals(fi) Or i.Source.File.Equals(fi) Then il_del.Add(i)
        Next
        Try
            For Each i As SimilarityImages In il_del
                il.Remove(i)
            Next
            fi.Delete()
            e.Result = il
        Catch ex As Exception
            For Each i As SimilarityImages In il_del
                il.Add(i)
            Next
            e.Result = Nothing
        End Try
    End Sub

    Private Sub DeletionComplete(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles imageDeleter.RunWorkerCompleted
        If ImageList.Count > 0 Then
            If CurrentImage >= ImageList.Count Then CurrentImage = ImageList.Count
            SetDups()
            ShowSelectedImage()
        Else
            SetDups()
            sourcePictureBox.Image = Nothing
            destinationPictureBox.Image = Nothing
            sourceLabel.Text = "Source"
            destinationLabel.Text = "Destination"
        End If
    End Sub
End Class

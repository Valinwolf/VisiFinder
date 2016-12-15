<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisiFinder
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisiFinder))
        Me.showFoldersLinkLabel = New System.Windows.Forms.Button()
        Me.folderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.workingProgressBar = New System.Windows.Forms.ProgressBar()
        Me.mainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.folderTextBox = New System.Windows.Forms.TextBox()
        Me.LaPLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.LabelLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.StageLabel = New System.Windows.Forms.Label()
        Me.ProgressLabel = New System.Windows.Forms.Label()
        Me.ElapsedLabel = New System.Windows.Forms.Label()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.findButton = New System.Windows.Forms.Button()
        Me.MinMatch = New System.Windows.Forms.NumericUpDown()
        Me.label1 = New System.Windows.Forms.Label()
        Me.BottomLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.ImageOpLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.previousButton = New System.Windows.Forms.Button()
        Me.sourceLabel = New System.Windows.Forms.Label()
        Me.destinationPictureBox = New System.Windows.Forms.PictureBox()
        Me.sourcePictureBox = New System.Windows.Forms.PictureBox()
        Me.destinationLabel = New System.Windows.Forms.Label()
        Me.openSourceLinkLabel = New System.Windows.Forms.Button()
        Me.deleteSourceLinkLabel = New System.Windows.Forms.Button()
        Me.openDestinationLinkLabel = New System.Windows.Forms.Button()
        Me.deleteDestinationLinkLabel = New System.Windows.Forms.Button()
        Me.nextButton = New System.Windows.Forms.Button()
        Me.simLabel = New System.Windows.Forms.Label()
        Me.imageComparer = New System.ComponentModel.BackgroundWorker()
        Me.fileLister = New System.ComponentModel.BackgroundWorker()
        Me.imageDeleter = New System.ComponentModel.BackgroundWorker()
        Me.LaPLayout.SuspendLayout()
        Me.LabelLayout.SuspendLayout()
        CType(Me.MinMatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BottomLayout.SuspendLayout()
        Me.ImageOpLayout.SuspendLayout()
        CType(Me.destinationPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourcePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'showFoldersLinkLabel
        '
        Me.showFoldersLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.showFoldersLinkLabel.Location = New System.Drawing.Point(640, 6)
        Me.showFoldersLinkLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.showFoldersLinkLabel.Name = "showFoldersLinkLabel"
        Me.showFoldersLinkLabel.Size = New System.Drawing.Size(38, 23)
        Me.showFoldersLinkLabel.TabIndex = 20
        Me.showFoldersLinkLabel.Text = "..."
        Me.showFoldersLinkLabel.UseVisualStyleBackColor = True
        '
        'workingProgressBar
        '
        Me.LaPLayout.SetColumnSpan(Me.workingProgressBar, 2)
        Me.workingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.workingProgressBar.Location = New System.Drawing.Point(6, 41)
        Me.workingProgressBar.Margin = New System.Windows.Forms.Padding(6)
        Me.workingProgressBar.Name = "workingProgressBar"
        Me.workingProgressBar.Size = New System.Drawing.Size(672, 23)
        Me.workingProgressBar.TabIndex = 14
        '
        'folderTextBox
        '
        Me.folderTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.folderTextBox.Font = New System.Drawing.Font("Liberation Mono", 9.75!)
        Me.folderTextBox.Location = New System.Drawing.Point(6, 6)
        Me.folderTextBox.Margin = New System.Windows.Forms.Padding(6)
        Me.folderTextBox.Name = "folderTextBox"
        Me.folderTextBox.Size = New System.Drawing.Size(622, 22)
        Me.folderTextBox.TabIndex = 1
        Me.folderTextBox.Text = "Loading..."
        '
        'LaPLayout
        '
        Me.LaPLayout.ColumnCount = 2
        Me.LaPLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LaPLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.LaPLayout.Controls.Add(Me.showFoldersLinkLabel, 1, 0)
        Me.LaPLayout.Controls.Add(Me.folderTextBox, 0, 0)
        Me.LaPLayout.Controls.Add(Me.workingProgressBar, 0, 1)
        Me.LaPLayout.Controls.Add(Me.LabelLayout, 0, 2)
        Me.LaPLayout.Dock = System.Windows.Forms.DockStyle.Top
        Me.LaPLayout.Location = New System.Drawing.Point(0, 0)
        Me.LaPLayout.Margin = New System.Windows.Forms.Padding(6)
        Me.LaPLayout.MaximumSize = New System.Drawing.Size(0, 128)
        Me.LaPLayout.MinimumSize = New System.Drawing.Size(0, 128)
        Me.LaPLayout.Name = "LaPLayout"
        Me.LaPLayout.RowCount = 3
        Me.LaPLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.LaPLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.LaPLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.LaPLayout.Size = New System.Drawing.Size(684, 128)
        Me.LaPLayout.TabIndex = 28
        '
        'LabelLayout
        '
        Me.LabelLayout.ColumnCount = 2
        Me.LaPLayout.SetColumnSpan(Me.LabelLayout, 2)
        Me.LabelLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LabelLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LabelLayout.Controls.Add(Me.StageLabel, 1, 1)
        Me.LabelLayout.Controls.Add(Me.ProgressLabel, 1, 0)
        Me.LabelLayout.Controls.Add(Me.ElapsedLabel, 0, 1)
        Me.LabelLayout.Controls.Add(Me.StatusLabel, 0, 0)
        Me.LabelLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelLayout.Location = New System.Drawing.Point(3, 73)
        Me.LabelLayout.Name = "LabelLayout"
        Me.LabelLayout.RowCount = 2
        Me.LabelLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LabelLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.LabelLayout.Size = New System.Drawing.Size(678, 52)
        Me.LabelLayout.TabIndex = 21
        '
        'StageLabel
        '
        Me.StageLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StageLabel.Font = New System.Drawing.Font("Liberation Mono", 9.75!)
        Me.StageLabel.Location = New System.Drawing.Point(342, 26)
        Me.StageLabel.Name = "StageLabel"
        Me.StageLabel.Size = New System.Drawing.Size(333, 26)
        Me.StageLabel.TabIndex = 4
        Me.StageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressLabel
        '
        Me.ProgressLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressLabel.Font = New System.Drawing.Font("Liberation Mono", 9.75!)
        Me.ProgressLabel.Location = New System.Drawing.Point(342, 0)
        Me.ProgressLabel.Name = "ProgressLabel"
        Me.ProgressLabel.Size = New System.Drawing.Size(333, 26)
        Me.ProgressLabel.TabIndex = 2
        Me.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ElapsedLabel
        '
        Me.ElapsedLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElapsedLabel.Font = New System.Drawing.Font("Liberation Mono", 9.75!)
        Me.ElapsedLabel.Location = New System.Drawing.Point(3, 26)
        Me.ElapsedLabel.Name = "ElapsedLabel"
        Me.ElapsedLabel.Size = New System.Drawing.Size(333, 26)
        Me.ElapsedLabel.TabIndex = 1
        Me.ElapsedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusLabel
        '
        Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLabel.Font = New System.Drawing.Font("Liberation Mono", 9.75!)
        Me.StatusLabel.Location = New System.Drawing.Point(3, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(333, 26)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Status: Loading Application..."
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ExitButton
        '
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitButton.Location = New System.Drawing.Point(610, 6)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(6)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(68, 44)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CancelBtn.Enabled = False
        Me.CancelBtn.Location = New System.Drawing.Point(530, 6)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(68, 44)
        Me.CancelBtn.TabIndex = 18
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'findButton
        '
        Me.findButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.findButton.Location = New System.Drawing.Point(430, 6)
        Me.findButton.Margin = New System.Windows.Forms.Padding(6)
        Me.findButton.Name = "findButton"
        Me.findButton.Size = New System.Drawing.Size(88, 44)
        Me.findButton.TabIndex = 0
        Me.findButton.Text = "Search"
        Me.findButton.UseVisualStyleBackColor = True
        '
        'MinMatch
        '
        Me.MinMatch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MinMatch.Location = New System.Drawing.Point(141, 6)
        Me.MinMatch.Margin = New System.Windows.Forms.Padding(6)
        Me.MinMatch.Name = "MinMatch"
        Me.MinMatch.Size = New System.Drawing.Size(58, 26)
        Me.MinMatch.TabIndex = 21
        Me.MinMatch.Value = New Decimal(New Integer() {95, 0, 0, 0})
        '
        'label1
        '
        Me.label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label1.Location = New System.Drawing.Point(6, 0)
        Me.label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.label1.MaximumSize = New System.Drawing.Size(0, 35)
        Me.label1.MinimumSize = New System.Drawing.Size(0, 35)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(123, 35)
        Me.label1.TabIndex = 20
        Me.label1.Text = "Minimum Match"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BottomLayout
        '
        Me.BottomLayout.ColumnCount = 6
        Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.BottomLayout.Controls.Add(Me.label1, 0, 0)
        Me.BottomLayout.Controls.Add(Me.MinMatch, 1, 0)
        Me.BottomLayout.Controls.Add(Me.findButton, 3, 0)
        Me.BottomLayout.Controls.Add(Me.CancelBtn, 4, 0)
        Me.BottomLayout.Controls.Add(Me.ExitButton, 5, 0)
        Me.BottomLayout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomLayout.Location = New System.Drawing.Point(0, 555)
        Me.BottomLayout.Margin = New System.Windows.Forms.Padding(6)
        Me.BottomLayout.Name = "BottomLayout"
        Me.BottomLayout.RowCount = 1
        Me.BottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.BottomLayout.Size = New System.Drawing.Size(684, 56)
        Me.BottomLayout.TabIndex = 30
        '
        'ImageOpLayout
        '
        Me.ImageOpLayout.ColumnCount = 4
        Me.ImageOpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ImageOpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ImageOpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ImageOpLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.ImageOpLayout.Controls.Add(Me.previousButton, 2, 3)
        Me.ImageOpLayout.Controls.Add(Me.sourceLabel, 0, 0)
        Me.ImageOpLayout.Controls.Add(Me.destinationPictureBox, 2, 1)
        Me.ImageOpLayout.Controls.Add(Me.sourcePictureBox, 0, 1)
        Me.ImageOpLayout.Controls.Add(Me.destinationLabel, 2, 0)
        Me.ImageOpLayout.Controls.Add(Me.openSourceLinkLabel, 0, 2)
        Me.ImageOpLayout.Controls.Add(Me.deleteSourceLinkLabel, 1, 2)
        Me.ImageOpLayout.Controls.Add(Me.openDestinationLinkLabel, 2, 2)
        Me.ImageOpLayout.Controls.Add(Me.deleteDestinationLinkLabel, 3, 2)
        Me.ImageOpLayout.Controls.Add(Me.nextButton, 3, 3)
        Me.ImageOpLayout.Controls.Add(Me.simLabel, 0, 3)
        Me.ImageOpLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageOpLayout.Location = New System.Drawing.Point(0, 128)
        Me.ImageOpLayout.Margin = New System.Windows.Forms.Padding(6)
        Me.ImageOpLayout.Name = "ImageOpLayout"
        Me.ImageOpLayout.RowCount = 4
        Me.ImageOpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.ImageOpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.ImageOpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.ImageOpLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.ImageOpLayout.Size = New System.Drawing.Size(684, 427)
        Me.ImageOpLayout.TabIndex = 31
        '
        'previousButton
        '
        Me.previousButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previousButton.Location = New System.Drawing.Point(348, 383)
        Me.previousButton.Margin = New System.Windows.Forms.Padding(6)
        Me.previousButton.Name = "previousButton"
        Me.previousButton.Size = New System.Drawing.Size(159, 38)
        Me.previousButton.TabIndex = 32
        Me.previousButton.Text = "Previous"
        Me.previousButton.UseVisualStyleBackColor = True
        '
        'sourceLabel
        '
        Me.ImageOpLayout.SetColumnSpan(Me.sourceLabel, 2)
        Me.sourceLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sourceLabel.Location = New System.Drawing.Point(6, 0)
        Me.sourceLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.sourceLabel.Name = "sourceLabel"
        Me.sourceLabel.Size = New System.Drawing.Size(330, 45)
        Me.sourceLabel.TabIndex = 13
        Me.sourceLabel.Text = "Source"
        Me.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'destinationPictureBox
        '
        Me.destinationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageOpLayout.SetColumnSpan(Me.destinationPictureBox, 2)
        Me.destinationPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.destinationPictureBox.Location = New System.Drawing.Point(348, 51)
        Me.destinationPictureBox.Margin = New System.Windows.Forms.Padding(6)
        Me.destinationPictureBox.Name = "destinationPictureBox"
        Me.destinationPictureBox.Size = New System.Drawing.Size(330, 270)
        Me.destinationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.destinationPictureBox.TabIndex = 14
        Me.destinationPictureBox.TabStop = False
        '
        'sourcePictureBox
        '
        Me.sourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ImageOpLayout.SetColumnSpan(Me.sourcePictureBox, 2)
        Me.sourcePictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sourcePictureBox.Location = New System.Drawing.Point(6, 51)
        Me.sourcePictureBox.Margin = New System.Windows.Forms.Padding(6)
        Me.sourcePictureBox.Name = "sourcePictureBox"
        Me.sourcePictureBox.Size = New System.Drawing.Size(330, 270)
        Me.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sourcePictureBox.TabIndex = 12
        Me.sourcePictureBox.TabStop = False
        '
        'destinationLabel
        '
        Me.ImageOpLayout.SetColumnSpan(Me.destinationLabel, 2)
        Me.destinationLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.destinationLabel.Location = New System.Drawing.Point(348, 0)
        Me.destinationLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.destinationLabel.Name = "destinationLabel"
        Me.destinationLabel.Size = New System.Drawing.Size(330, 45)
        Me.destinationLabel.TabIndex = 15
        Me.destinationLabel.Text = "Destination"
        Me.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'openSourceLinkLabel
        '
        Me.openSourceLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.openSourceLinkLabel.Location = New System.Drawing.Point(6, 333)
        Me.openSourceLinkLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.openSourceLinkLabel.Name = "openSourceLinkLabel"
        Me.openSourceLinkLabel.Size = New System.Drawing.Size(159, 38)
        Me.openSourceLinkLabel.TabIndex = 25
        Me.openSourceLinkLabel.Text = "Open"
        Me.openSourceLinkLabel.UseVisualStyleBackColor = True
        '
        'deleteSourceLinkLabel
        '
        Me.deleteSourceLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteSourceLinkLabel.Location = New System.Drawing.Point(177, 333)
        Me.deleteSourceLinkLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.deleteSourceLinkLabel.Name = "deleteSourceLinkLabel"
        Me.deleteSourceLinkLabel.Size = New System.Drawing.Size(159, 38)
        Me.deleteSourceLinkLabel.TabIndex = 26
        Me.deleteSourceLinkLabel.Text = "Delete"
        Me.deleteSourceLinkLabel.UseVisualStyleBackColor = True
        '
        'openDestinationLinkLabel
        '
        Me.openDestinationLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.openDestinationLinkLabel.Location = New System.Drawing.Point(348, 333)
        Me.openDestinationLinkLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.openDestinationLinkLabel.Name = "openDestinationLinkLabel"
        Me.openDestinationLinkLabel.Size = New System.Drawing.Size(159, 38)
        Me.openDestinationLinkLabel.TabIndex = 27
        Me.openDestinationLinkLabel.Text = "Open"
        Me.openDestinationLinkLabel.UseVisualStyleBackColor = True
        '
        'deleteDestinationLinkLabel
        '
        Me.deleteDestinationLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.deleteDestinationLinkLabel.Location = New System.Drawing.Point(519, 333)
        Me.deleteDestinationLinkLabel.Margin = New System.Windows.Forms.Padding(6)
        Me.deleteDestinationLinkLabel.Name = "deleteDestinationLinkLabel"
        Me.deleteDestinationLinkLabel.Size = New System.Drawing.Size(159, 38)
        Me.deleteDestinationLinkLabel.TabIndex = 28
        Me.deleteDestinationLinkLabel.Text = "Delete"
        Me.deleteDestinationLinkLabel.UseVisualStyleBackColor = True
        '
        'nextButton
        '
        Me.nextButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nextButton.Location = New System.Drawing.Point(519, 383)
        Me.nextButton.Margin = New System.Windows.Forms.Padding(6)
        Me.nextButton.Name = "nextButton"
        Me.nextButton.Size = New System.Drawing.Size(159, 38)
        Me.nextButton.TabIndex = 31
        Me.nextButton.Text = "Next"
        Me.nextButton.UseVisualStyleBackColor = True
        '
        'simLabel
        '
        Me.simLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.simLabel.Location = New System.Drawing.Point(4, 377)
        Me.simLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.simLabel.Name = "simLabel"
        Me.simLabel.Size = New System.Drawing.Size(163, 50)
        Me.simLabel.TabIndex = 33
        Me.simLabel.Text = "0% Match"
        Me.simLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imageComparer
        '
        Me.imageComparer.WorkerReportsProgress = True
        Me.imageComparer.WorkerSupportsCancellation = True
        '
        'fileLister
        '
        '
        'imageDeleter
        '
        '
        'VisiFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.ImageOpLayout)
        Me.Controls.Add(Me.BottomLayout)
        Me.Controls.Add(Me.LaPLayout)
        Me.Font = New System.Drawing.Font("Linux Biolinum G", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(700, 650)
        Me.Name = "VisiFinder"
        Me.Text = "VisiFinder"
        Me.LaPLayout.ResumeLayout(False)
        Me.LaPLayout.PerformLayout()
        Me.LabelLayout.ResumeLayout(False)
        CType(Me.MinMatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BottomLayout.ResumeLayout(False)
        Me.ImageOpLayout.ResumeLayout(False)
        CType(Me.destinationPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourcePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents showFoldersLinkLabel As Button
    Private WithEvents folderBrowserDialog As FolderBrowserDialog
    Private WithEvents LaPLayout As TableLayoutPanel
    Private WithEvents folderTextBox As TextBox
    Private WithEvents workingProgressBar As ProgressBar
    Private WithEvents mainToolTip As ToolTip
    Private WithEvents ExitButton As Button
    Private WithEvents CancelBtn As Button
    Private WithEvents findButton As Button
    Private WithEvents MinMatch As NumericUpDown
    Private WithEvents label1 As Label
    Private WithEvents BottomLayout As TableLayoutPanel
    Private WithEvents ImageOpLayout As TableLayoutPanel
    Private WithEvents previousButton As Button
    Private WithEvents sourceLabel As Label
    Private WithEvents destinationPictureBox As PictureBox
    Private WithEvents sourcePictureBox As PictureBox
    Private WithEvents destinationLabel As Label
    Private WithEvents openSourceLinkLabel As Button
    Private WithEvents deleteSourceLinkLabel As Button
    Private WithEvents openDestinationLinkLabel As Button
    Private WithEvents deleteDestinationLinkLabel As Button
    Private WithEvents nextButton As Button
    Friend WithEvents simLabel As Label
    Friend WithEvents imageComparer As System.ComponentModel.BackgroundWorker
    Friend WithEvents fileLister As System.ComponentModel.BackgroundWorker
    Friend WithEvents LabelLayout As TableLayoutPanel
    Friend WithEvents ElapsedLabel As Label
    Friend WithEvents StatusLabel As Label
    Friend WithEvents ProgressLabel As Label
    Friend WithEvents StageLabel As Label
    Friend WithEvents imageDeleter As System.ComponentModel.BackgroundWorker
End Class

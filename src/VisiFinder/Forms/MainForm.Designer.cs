namespace VisiFinder.Forms
{
    internal partial class MainForm
    {
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.ToolTip mainToolTip;
        private System.Windows.Forms.DataGridView imagesDataGridView;
        private System.Windows.Forms.Label imagesLabel;
        private System.Windows.Forms.ProgressBar workingProgressBar;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.PictureBox destinationPictureBox;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.PictureBox sourcePictureBox;
        private System.Windows.Forms.Label workingLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button cancelButton;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.findButton = new System.Windows.Forms.Button();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.mainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.imagesDataGridView = new System.Windows.Forms.DataGridView();
            this.imagesLabel = new System.Windows.Forms.Label();
            this.workingProgressBar = new System.Windows.Forms.ProgressBar();
            this.ImageOpLayout = new System.Windows.Forms.TableLayoutPanel();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.destinationPictureBox = new System.Windows.Forms.PictureBox();
            this.sourcePictureBox = new System.Windows.Forms.PictureBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.openSourceLinkLabel = new System.Windows.Forms.Button();
            this.deleteSourceLinkLabel = new System.Windows.Forms.Button();
            this.openDestinationLinkLabel = new System.Windows.Forms.Button();
            this.deleteDestinationLinkLabel = new System.Windows.Forms.Button();
            this.workingLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.cancelButton = new System.Windows.Forms.Button();
            this.showFoldersLinkLabel = new System.Windows.Forms.Button();
            this.LaPLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ImageListLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BottomLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinMatch = new System.Windows.Forms.NumericUpDown();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).BeginInit();
            this.ImageOpLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destinationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).BeginInit();
            this.LaPLayout.SuspendLayout();
            this.ImageListLayout.SuspendLayout();
            this.BottomLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // findButton
            // 
            this.findButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findButton.Location = new System.Drawing.Point(496, 166);
            this.findButton.Margin = new System.Windows.Forms.Padding(4);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(92, 41);
            this.findButton.TabIndex = 0;
            this.findButton.Text = "Search";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.FindButtonClick);
            // 
            // folderTextBox
            // 
            this.folderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.folderTextBox.Location = new System.Drawing.Point(4, 4);
            this.folderTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(699, 26);
            this.folderTextBox.TabIndex = 1;
            this.folderTextBox.Text = "Loading...";
            // 
            // imagesDataGridView
            // 
            this.imagesDataGridView.AllowUserToAddRows = false;
            this.imagesDataGridView.AllowUserToDeleteRows = false;
            this.imagesDataGridView.AllowUserToResizeRows = false;
            this.imagesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.imagesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.imagesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.imagesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesDataGridView.Location = new System.Drawing.Point(4, 45);
            this.imagesDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.imagesDataGridView.MultiSelect = false;
            this.imagesDataGridView.Name = "imagesDataGridView";
            this.imagesDataGridView.ReadOnly = true;
            this.imagesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.imagesDataGridView.Size = new System.Drawing.Size(736, 105);
            this.imagesDataGridView.TabIndex = 12;
            this.imagesDataGridView.DataSourceChanged += new System.EventHandler(this.RedrawDataGrid);
            this.imagesDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.imagesDataGridView_DataBindingComplete);
            this.imagesDataGridView.SelectionChanged += new System.EventHandler(this.DataGridViewSelectionChanged);
            this.imagesDataGridView.Validated += new System.EventHandler(this.RedrawDataGrid);
            // 
            // imagesLabel
            // 
            this.imagesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagesLabel.Location = new System.Drawing.Point(4, 0);
            this.imagesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imagesLabel.Name = "imagesLabel";
            this.imagesLabel.Size = new System.Drawing.Size(736, 41);
            this.imagesLabel.TabIndex = 13;
            this.imagesLabel.Text = "Image List";
            this.imagesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // workingProgressBar
            // 
            this.LaPLayout.SetColumnSpan(this.workingProgressBar, 2);
            this.workingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workingProgressBar.Location = new System.Drawing.Point(4, 39);
            this.workingProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.workingProgressBar.Name = "workingProgressBar";
            this.workingProgressBar.Size = new System.Drawing.Size(744, 33);
            this.workingProgressBar.TabIndex = 14;
            // 
            // ImageOpLayout
            // 
            this.ImageOpLayout.ColumnCount = 4;
            this.ImageOpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageOpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageOpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageOpLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ImageOpLayout.Controls.Add(this.sourceLabel, 0, 0);
            this.ImageOpLayout.Controls.Add(this.destinationPictureBox, 2, 1);
            this.ImageOpLayout.Controls.Add(this.sourcePictureBox, 0, 1);
            this.ImageOpLayout.Controls.Add(this.destinationLabel, 2, 0);
            this.ImageOpLayout.Controls.Add(this.openSourceLinkLabel, 0, 2);
            this.ImageOpLayout.Controls.Add(this.deleteSourceLinkLabel, 1, 2);
            this.ImageOpLayout.Controls.Add(this.openDestinationLinkLabel, 2, 2);
            this.ImageOpLayout.Controls.Add(this.deleteDestinationLinkLabel, 3, 2);
            this.ImageOpLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImageOpLayout.Location = new System.Drawing.Point(0, 117);
            this.ImageOpLayout.Margin = new System.Windows.Forms.Padding(4);
            this.ImageOpLayout.Name = "ImageOpLayout";
            this.ImageOpLayout.RowCount = 3;
            this.ImageOpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.ImageOpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImageOpLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.ImageOpLayout.Size = new System.Drawing.Size(752, 333);
            this.ImageOpLayout.TabIndex = 25;
            // 
            // sourceLabel
            // 
            this.ImageOpLayout.SetColumnSpan(this.sourceLabel, 2);
            this.sourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceLabel.Location = new System.Drawing.Point(4, 0);
            this.sourceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(368, 41);
            this.sourceLabel.TabIndex = 13;
            this.sourceLabel.Text = "Source";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // destinationPictureBox
            // 
            this.destinationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageOpLayout.SetColumnSpan(this.destinationPictureBox, 2);
            this.destinationPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationPictureBox.Location = new System.Drawing.Point(380, 45);
            this.destinationPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.destinationPictureBox.Name = "destinationPictureBox";
            this.destinationPictureBox.Size = new System.Drawing.Size(368, 243);
            this.destinationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.destinationPictureBox.TabIndex = 14;
            this.destinationPictureBox.TabStop = false;
            // 
            // sourcePictureBox
            // 
            this.sourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageOpLayout.SetColumnSpan(this.sourcePictureBox, 2);
            this.sourcePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourcePictureBox.Location = new System.Drawing.Point(4, 45);
            this.sourcePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.sourcePictureBox.Name = "sourcePictureBox";
            this.sourcePictureBox.Size = new System.Drawing.Size(368, 243);
            this.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sourcePictureBox.TabIndex = 12;
            this.sourcePictureBox.TabStop = false;
            // 
            // destinationLabel
            // 
            this.ImageOpLayout.SetColumnSpan(this.destinationLabel, 2);
            this.destinationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.destinationLabel.Location = new System.Drawing.Point(380, 0);
            this.destinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(368, 41);
            this.destinationLabel.TabIndex = 15;
            this.destinationLabel.Text = "Destination";
            this.destinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openSourceLinkLabel
            // 
            this.openSourceLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openSourceLinkLabel.Location = new System.Drawing.Point(4, 296);
            this.openSourceLinkLabel.Margin = new System.Windows.Forms.Padding(4);
            this.openSourceLinkLabel.Name = "openSourceLinkLabel";
            this.openSourceLinkLabel.Size = new System.Drawing.Size(180, 33);
            this.openSourceLinkLabel.TabIndex = 25;
            this.openSourceLinkLabel.Text = "Open";
            this.openSourceLinkLabel.UseVisualStyleBackColor = true;
            this.openSourceLinkLabel.Click += new System.EventHandler(this.OpenSourceLinkLabelLinkClicked);
            // 
            // deleteSourceLinkLabel
            // 
            this.deleteSourceLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteSourceLinkLabel.Location = new System.Drawing.Point(192, 296);
            this.deleteSourceLinkLabel.Margin = new System.Windows.Forms.Padding(4);
            this.deleteSourceLinkLabel.Name = "deleteSourceLinkLabel";
            this.deleteSourceLinkLabel.Size = new System.Drawing.Size(180, 33);
            this.deleteSourceLinkLabel.TabIndex = 26;
            this.deleteSourceLinkLabel.Text = "Delete";
            this.deleteSourceLinkLabel.UseVisualStyleBackColor = true;
            this.deleteSourceLinkLabel.Click += new System.EventHandler(this.DeleteSourceLinkLabelLinkClicked);
            // 
            // openDestinationLinkLabel
            // 
            this.openDestinationLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openDestinationLinkLabel.Location = new System.Drawing.Point(380, 296);
            this.openDestinationLinkLabel.Margin = new System.Windows.Forms.Padding(4);
            this.openDestinationLinkLabel.Name = "openDestinationLinkLabel";
            this.openDestinationLinkLabel.Size = new System.Drawing.Size(180, 33);
            this.openDestinationLinkLabel.TabIndex = 27;
            this.openDestinationLinkLabel.Text = "Open";
            this.openDestinationLinkLabel.UseVisualStyleBackColor = true;
            this.openDestinationLinkLabel.Click += new System.EventHandler(this.OpenDestinationLinkLabelLinkClicked);
            // 
            // deleteDestinationLinkLabel
            // 
            this.deleteDestinationLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteDestinationLinkLabel.Location = new System.Drawing.Point(568, 296);
            this.deleteDestinationLinkLabel.Margin = new System.Windows.Forms.Padding(4);
            this.deleteDestinationLinkLabel.Name = "deleteDestinationLinkLabel";
            this.deleteDestinationLinkLabel.Size = new System.Drawing.Size(180, 33);
            this.deleteDestinationLinkLabel.TabIndex = 28;
            this.deleteDestinationLinkLabel.Text = "Delete";
            this.deleteDestinationLinkLabel.UseVisualStyleBackColor = true;
            this.deleteDestinationLinkLabel.Click += new System.EventHandler(this.DeleteSourceLinkLabelLinkClicked);
            // 
            // workingLabel
            // 
            this.LaPLayout.SetColumnSpan(this.workingLabel, 2);
            this.workingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workingLabel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workingLabel.Location = new System.Drawing.Point(4, 76);
            this.workingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.workingLabel.Name = "workingLabel";
            this.workingLabel.Size = new System.Drawing.Size(744, 41);
            this.workingLabel.TabIndex = 16;
            this.workingLabel.Text = "Waiting...";
            this.workingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cancelButton
            // 
            this.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(596, 166);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(72, 41);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // showFoldersLinkLabel
            // 
            this.showFoldersLinkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showFoldersLinkLabel.Location = new System.Drawing.Point(711, 4);
            this.showFoldersLinkLabel.Margin = new System.Windows.Forms.Padding(4);
            this.showFoldersLinkLabel.Name = "showFoldersLinkLabel";
            this.showFoldersLinkLabel.Size = new System.Drawing.Size(37, 27);
            this.showFoldersLinkLabel.TabIndex = 20;
            this.showFoldersLinkLabel.Text = "...";
            this.showFoldersLinkLabel.UseVisualStyleBackColor = true;
            this.showFoldersLinkLabel.Click += new System.EventHandler(this.LinkLabelLinkClicked);
            // 
            // LaPLayout
            // 
            this.LaPLayout.ColumnCount = 2;
            this.LaPLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LaPLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.LaPLayout.Controls.Add(this.showFoldersLinkLabel, 1, 0);
            this.LaPLayout.Controls.Add(this.folderTextBox, 0, 0);
            this.LaPLayout.Controls.Add(this.workingLabel, 0, 2);
            this.LaPLayout.Controls.Add(this.workingProgressBar, 0, 1);
            this.LaPLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.LaPLayout.Location = new System.Drawing.Point(0, 0);
            this.LaPLayout.Margin = new System.Windows.Forms.Padding(4);
            this.LaPLayout.MaximumSize = new System.Drawing.Size(0, 117);
            this.LaPLayout.MinimumSize = new System.Drawing.Size(0, 117);
            this.LaPLayout.Name = "LaPLayout";
            this.LaPLayout.RowCount = 3;
            this.LaPLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.LaPLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.LaPLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.LaPLayout.Size = new System.Drawing.Size(752, 117);
            this.LaPLayout.TabIndex = 21;
            // 
            // ImageListLayout
            // 
            this.ImageListLayout.ColumnCount = 1;
            this.BottomLayout.SetColumnSpan(this.ImageListLayout, 6);
            this.ImageListLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImageListLayout.Controls.Add(this.imagesLabel, 0, 0);
            this.ImageListLayout.Controls.Add(this.imagesDataGridView, 0, 1);
            this.ImageListLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageListLayout.Location = new System.Drawing.Point(4, 4);
            this.ImageListLayout.Margin = new System.Windows.Forms.Padding(4);
            this.ImageListLayout.Name = "ImageListLayout";
            this.ImageListLayout.RowCount = 2;
            this.ImageListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.ImageListLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ImageListLayout.Size = new System.Drawing.Size(744, 154);
            this.ImageListLayout.TabIndex = 26;
            // 
            // BottomLayout
            // 
            this.BottomLayout.ColumnCount = 6;
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.BottomLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.BottomLayout.Controls.Add(this.label1, 0, 1);
            this.BottomLayout.Controls.Add(this.ImageListLayout, 0, 0);
            this.BottomLayout.Controls.Add(this.MinMatch, 1, 1);
            this.BottomLayout.Controls.Add(this.findButton, 3, 1);
            this.BottomLayout.Controls.Add(this.cancelButton, 4, 1);
            this.BottomLayout.Controls.Add(this.ExitButton, 5, 1);
            this.BottomLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomLayout.Location = new System.Drawing.Point(0, 450);
            this.BottomLayout.Margin = new System.Windows.Forms.Padding(4);
            this.BottomLayout.Name = "BottomLayout";
            this.BottomLayout.RowCount = 2;
            this.BottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.BottomLayout.Size = new System.Drawing.Size(752, 211);
            this.BottomLayout.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(0, 27);
            this.label1.MinimumSize = new System.Drawing.Size(0, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 20;
            this.label1.Text = "Minimum Match";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MinMatch
            // 
            this.MinMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinMatch.Location = new System.Drawing.Point(154, 166);
            this.MinMatch.Margin = new System.Windows.Forms.Padding(4);
            this.MinMatch.Name = "MinMatch";
            this.MinMatch.Size = new System.Drawing.Size(52, 26);
            this.MinMatch.TabIndex = 21;
            this.MinMatch.Value = new decimal(new int[] {
            95,
            0,
            0,
            0});
            // 
            // ExitButton
            // 
            this.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitButton.Location = new System.Drawing.Point(676, 166);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(72, 41);
            this.ExitButton.TabIndex = 19;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 661);
            this.Controls.Add(this.BottomLayout);
            this.Controls.Add(this.ImageOpLayout);
            this.Controls.Add(this.LaPLayout);
            this.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(768, 700);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisiFinder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGridView)).EndInit();
            this.ImageOpLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.destinationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePictureBox)).EndInit();
            this.LaPLayout.ResumeLayout(false);
            this.LaPLayout.PerformLayout();
            this.ImageListLayout.ResumeLayout(false);
            this.BottomLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinMatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ImageOpLayout;
        private System.Windows.Forms.Button openSourceLinkLabel;
        private System.Windows.Forms.Button deleteSourceLinkLabel;
        private System.Windows.Forms.Button openDestinationLinkLabel;
        private System.Windows.Forms.Button deleteDestinationLinkLabel;
        private System.Windows.Forms.Button showFoldersLinkLabel;
        private System.Windows.Forms.TableLayoutPanel LaPLayout;
        private System.Windows.Forms.TableLayoutPanel ImageListLayout;
        private System.Windows.Forms.TableLayoutPanel BottomLayout;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinMatch;
    }
}

namespace AWSBucketsTestsGUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.POptions = new System.Windows.Forms.Panel();
            this.BtnNewFolder = new System.Windows.Forms.Button();
            this.BtnNewBucket = new System.Windows.Forms.Button();
            this.BtnDeleteFile = new System.Windows.Forms.Button();
            this.BtnUploadFile = new System.Windows.Forms.Button();
            this.BtnDownloadFile = new System.Windows.Forms.Button();
            this.PBuckets = new System.Windows.Forms.Panel();
            this.LvBuckets = new System.Windows.Forms.ListView();
            this.Fbd_BasePath = new System.Windows.Forms.FolderBrowserDialog();
            this.TbPath = new System.Windows.Forms.TextBox();
            this.LblPath = new System.Windows.Forms.Label();
            this.BtnSelectPath = new System.Windows.Forms.Button();
            this.PFilesBucket = new System.Windows.Forms.Panel();
            this.LvItemsBucket = new System.Windows.Forms.ListView();
            this.BtnSelectFile = new System.Windows.Forms.Button();
            this.OfdUploadFile = new System.Windows.Forms.OpenFileDialog();
            this.TbFile = new System.Windows.Forms.TextBox();
            this.LblFile = new System.Windows.Forms.Label();
            this.LblBuckets = new System.Windows.Forms.Label();
            this.LblContent = new System.Windows.Forms.Label();
            this.POptions.SuspendLayout();
            this.PBuckets.SuspendLayout();
            this.PFilesBucket.SuspendLayout();
            this.SuspendLayout();
            // 
            // POptions
            // 
            this.POptions.Controls.Add(this.BtnNewFolder);
            this.POptions.Controls.Add(this.BtnNewBucket);
            this.POptions.Controls.Add(this.BtnDeleteFile);
            this.POptions.Controls.Add(this.BtnUploadFile);
            this.POptions.Controls.Add(this.BtnDownloadFile);
            this.POptions.Location = new System.Drawing.Point(12, 12);
            this.POptions.Name = "POptions";
            this.POptions.Size = new System.Drawing.Size(161, 320);
            this.POptions.TabIndex = 0;
            // 
            // BtnNewFolder
            // 
            this.BtnNewFolder.Location = new System.Drawing.Point(0, 40);
            this.BtnNewFolder.Name = "BtnNewFolder";
            this.BtnNewFolder.Size = new System.Drawing.Size(161, 40);
            this.BtnNewFolder.TabIndex = 5;
            this.BtnNewFolder.Text = "New Folder";
            this.BtnNewFolder.UseVisualStyleBackColor = true;
            this.BtnNewFolder.Click += new System.EventHandler(this.BtnNewFolder_Click);
            // 
            // BtnNewBucket
            // 
            this.BtnNewBucket.Location = new System.Drawing.Point(0, 0);
            this.BtnNewBucket.Name = "BtnNewBucket";
            this.BtnNewBucket.Size = new System.Drawing.Size(161, 40);
            this.BtnNewBucket.TabIndex = 4;
            this.BtnNewBucket.Text = "New Bucket";
            this.BtnNewBucket.UseVisualStyleBackColor = true;
            this.BtnNewBucket.Click += new System.EventHandler(this.BtnNewBucket_Click);
            // 
            // BtnDeleteFile
            // 
            this.BtnDeleteFile.Location = new System.Drawing.Point(0, 280);
            this.BtnDeleteFile.Name = "BtnDeleteFile";
            this.BtnDeleteFile.Size = new System.Drawing.Size(161, 40);
            this.BtnDeleteFile.TabIndex = 3;
            this.BtnDeleteFile.Text = "Delete";
            this.BtnDeleteFile.UseVisualStyleBackColor = true;
            this.BtnDeleteFile.Click += new System.EventHandler(this.BtnDeleteFile_Click);
            // 
            // BtnUploadFile
            // 
            this.BtnUploadFile.Location = new System.Drawing.Point(0, 240);
            this.BtnUploadFile.Name = "BtnUploadFile";
            this.BtnUploadFile.Size = new System.Drawing.Size(161, 40);
            this.BtnUploadFile.TabIndex = 2;
            this.BtnUploadFile.Text = "Upload";
            this.BtnUploadFile.UseVisualStyleBackColor = true;
            this.BtnUploadFile.Click += new System.EventHandler(this.BtnUploadFile_Click);
            // 
            // BtnDownloadFile
            // 
            this.BtnDownloadFile.Location = new System.Drawing.Point(0, 200);
            this.BtnDownloadFile.Name = "BtnDownloadFile";
            this.BtnDownloadFile.Size = new System.Drawing.Size(161, 40);
            this.BtnDownloadFile.TabIndex = 1;
            this.BtnDownloadFile.Text = "Download";
            this.BtnDownloadFile.UseVisualStyleBackColor = true;
            this.BtnDownloadFile.Click += new System.EventHandler(this.BtnDownloadFile_Click);
            // 
            // PBuckets
            // 
            this.PBuckets.Controls.Add(this.LvBuckets);
            this.PBuckets.Location = new System.Drawing.Point(179, 30);
            this.PBuckets.Name = "PBuckets";
            this.PBuckets.Size = new System.Drawing.Size(197, 302);
            this.PBuckets.TabIndex = 1;
            // 
            // LvBuckets
            // 
            this.LvBuckets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvBuckets.FullRowSelect = true;
            this.LvBuckets.GridLines = true;
            this.LvBuckets.Location = new System.Drawing.Point(0, 0);
            this.LvBuckets.MultiSelect = false;
            this.LvBuckets.Name = "LvBuckets";
            this.LvBuckets.Size = new System.Drawing.Size(197, 302);
            this.LvBuckets.TabIndex = 0;
            this.LvBuckets.UseCompatibleStateImageBehavior = false;
            this.LvBuckets.View = System.Windows.Forms.View.Tile;
            this.LvBuckets.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lv_buckets_ItemSelectionChanged);
            // 
            // TbPath
            // 
            this.TbPath.Enabled = false;
            this.TbPath.Location = new System.Drawing.Point(216, 338);
            this.TbPath.Name = "TbPath";
            this.TbPath.ReadOnly = true;
            this.TbPath.Size = new System.Drawing.Size(373, 23);
            this.TbPath.TabIndex = 2;
            // 
            // LblPath
            // 
            this.LblPath.AutoSize = true;
            this.LblPath.Location = new System.Drawing.Point(179, 341);
            this.LblPath.Name = "LblPath";
            this.LblPath.Size = new System.Drawing.Size(31, 15);
            this.LblPath.TabIndex = 3;
            this.LblPath.Text = "Path";
            // 
            // BtnSelectPath
            // 
            this.BtnSelectPath.Location = new System.Drawing.Point(12, 338);
            this.BtnSelectPath.Name = "BtnSelectPath";
            this.BtnSelectPath.Size = new System.Drawing.Size(161, 23);
            this.BtnSelectPath.TabIndex = 4;
            this.BtnSelectPath.Text = "Path";
            this.BtnSelectPath.UseVisualStyleBackColor = true;
            this.BtnSelectPath.Click += new System.EventHandler(this.BtnSelectPath_Click);
            // 
            // PFilesBucket
            // 
            this.PFilesBucket.Controls.Add(this.LvItemsBucket);
            this.PFilesBucket.Location = new System.Drawing.Point(392, 30);
            this.PFilesBucket.Name = "PFilesBucket";
            this.PFilesBucket.Size = new System.Drawing.Size(197, 302);
            this.PFilesBucket.TabIndex = 2;
            // 
            // LvItemsBucket
            // 
            this.LvItemsBucket.BackgroundImageTiled = true;
            this.LvItemsBucket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LvItemsBucket.FullRowSelect = true;
            this.LvItemsBucket.GridLines = true;
            this.LvItemsBucket.Location = new System.Drawing.Point(0, 0);
            this.LvItemsBucket.MultiSelect = false;
            this.LvItemsBucket.Name = "LvItemsBucket";
            this.LvItemsBucket.Size = new System.Drawing.Size(197, 302);
            this.LvItemsBucket.TabIndex = 0;
            this.LvItemsBucket.UseCompatibleStateImageBehavior = false;
            this.LvItemsBucket.View = System.Windows.Forms.View.Tile;
            this.LvItemsBucket.SelectedIndexChanged += new System.EventHandler(this.LvItemsBucket_SelectedIndexChanged);
            // 
            // BtnSelectFile
            // 
            this.BtnSelectFile.Location = new System.Drawing.Point(12, 367);
            this.BtnSelectFile.Name = "BtnSelectFile";
            this.BtnSelectFile.Size = new System.Drawing.Size(161, 23);
            this.BtnSelectFile.TabIndex = 5;
            this.BtnSelectFile.Text = "File";
            this.BtnSelectFile.UseVisualStyleBackColor = true;
            this.BtnSelectFile.Click += new System.EventHandler(this.BtnSelectFile_Click);
            // 
            // OfdUploadFile
            // 
            this.OfdUploadFile.FileName = "OfdUploadFile";
            // 
            // TbFile
            // 
            this.TbFile.Enabled = false;
            this.TbFile.Location = new System.Drawing.Point(216, 367);
            this.TbFile.Name = "TbFile";
            this.TbFile.ReadOnly = true;
            this.TbFile.Size = new System.Drawing.Size(373, 23);
            this.TbFile.TabIndex = 6;
            // 
            // LblFile
            // 
            this.LblFile.AutoSize = true;
            this.LblFile.Location = new System.Drawing.Point(179, 370);
            this.LblFile.Name = "LblFile";
            this.LblFile.Size = new System.Drawing.Size(25, 15);
            this.LblFile.TabIndex = 7;
            this.LblFile.Text = "File";
            // 
            // LblBuckets
            // 
            this.LblBuckets.AutoSize = true;
            this.LblBuckets.Location = new System.Drawing.Point(179, 12);
            this.LblBuckets.Name = "LblBuckets";
            this.LblBuckets.Size = new System.Drawing.Size(48, 15);
            this.LblBuckets.TabIndex = 8;
            this.LblBuckets.Text = "Buckets";
            // 
            // LblContent
            // 
            this.LblContent.AutoSize = true;
            this.LblContent.Location = new System.Drawing.Point(392, 12);
            this.LblContent.Name = "LblContent";
            this.LblContent.Size = new System.Drawing.Size(50, 15);
            this.LblContent.TabIndex = 9;
            this.LblContent.Text = "Content";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 396);
            this.Controls.Add(this.LblContent);
            this.Controls.Add(this.LblBuckets);
            this.Controls.Add(this.LblFile);
            this.Controls.Add(this.TbFile);
            this.Controls.Add(this.BtnSelectFile);
            this.Controls.Add(this.PFilesBucket);
            this.Controls.Add(this.BtnSelectPath);
            this.Controls.Add(this.LblPath);
            this.Controls.Add(this.TbPath);
            this.Controls.Add(this.PBuckets);
            this.Controls.Add(this.POptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.POptions.ResumeLayout(false);
            this.PBuckets.ResumeLayout(false);
            this.PFilesBucket.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel POptions;
        private Panel PBuckets;
        private FolderBrowserDialog Fbd_BasePath;
        private TextBox TbPath;
        private Label LblPath;
        private Button BtnSelectPath;
        private Button BtnUploadFile;
        private Button BtnDownloadFile;
        private ListView LvBuckets;
        private Panel PFilesBucket;
        private ListView LvItemsBucket;
        private Button BtnSelectFile;
        private OpenFileDialog OfdUploadFile;
        private TextBox TbFile;
        private Label LblFile;
        private Button BtnDeleteFile;
        private Label LblBuckets;
        private Label LblContent;
        private Button BtnNewFolder;
        private Button BtnNewBucket;
    }
}
namespace AdbGui
{
    partial class Form1
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connect_button = new System.Windows.Forms.Button();
            this.install_button = new System.Windows.Forms.Button();
            this.txtLogBox = new System.Windows.Forms.TextBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.readme_button = new System.Windows.Forms.Button();
            this.twitterLabel = new System.Windows.Forms.LinkLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.versionLabel = new System.Windows.Forms.Label();
            this.imagenOculus = new System.Windows.Forms.PictureBox();
            this.appsList_button = new System.Windows.Forms.Button();
            this.appsList = new System.Windows.Forms.ComboBox();
            this.uninstall_button = new System.Windows.Forms.Button();
            this.installedAppsLabel = new System.Windows.Forms.Label();
            this.resolution1024_button = new System.Windows.Forms.Button();
            this.resolution1536_button = new System.Windows.Forms.Button();
            this.resolution2048_button = new System.Windows.Forms.Button();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.resolution2560_button = new System.Windows.Forms.Button();
            this.resolution2048Plus_button = new System.Windows.Forms.Button();
            this.resolutionPlusGroupBox = new System.Windows.Forms.GroupBox();
            this.resolution3072Plus_button = new System.Windows.Forms.Button();
            this.chromaticFixOn_button = new System.Windows.Forms.Button();
            this.chromaticFixOff_button = new System.Windows.Forms.Button();
            this.chromaticLabel = new System.Windows.Forms.Label();
            this.savesList_button = new System.Windows.Forms.Button();
            this.saveBackup_button = new System.Windows.Forms.Button();
            this.saveDataList = new System.Windows.Forms.ComboBox();
            this.saveDataListLabel = new System.Windows.Forms.Label();
            this.saveRestore_button = new System.Windows.Forms.Button();
            this.saveOptionsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenOculus)).BeginInit();
            this.resolutionPlusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(30, 89);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(117, 45);
            this.connect_button.TabIndex = 0;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.Connect_button_Click);
            // 
            // install_button
            // 
            this.install_button.Location = new System.Drawing.Point(30, 140);
            this.install_button.Name = "install_button";
            this.install_button.Size = new System.Drawing.Size(117, 45);
            this.install_button.TabIndex = 1;
            this.install_button.Text = "Install Apk";
            this.install_button.UseVisualStyleBackColor = true;
            this.install_button.Click += new System.EventHandler(this.Install_button_Click);
            // 
            // txtLogBox
            // 
            this.txtLogBox.Location = new System.Drawing.Point(30, 668);
            this.txtLogBox.Multiline = true;
            this.txtLogBox.Name = "txtLogBox";
            this.txtLogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogBox.Size = new System.Drawing.Size(602, 217);
            this.txtLogBox.TabIndex = 2;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(27, 648);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(32, 17);
            this.logLabel.TabIndex = 3;
            this.logLabel.Text = "Log";
            // 
            // readme_button
            // 
            this.readme_button.Location = new System.Drawing.Point(30, 560);
            this.readme_button.Name = "readme_button";
            this.readme_button.Size = new System.Drawing.Size(117, 45);
            this.readme_button.TabIndex = 4;
            this.readme_button.Text = "README";
            this.readme_button.UseVisualStyleBackColor = true;
            this.readme_button.Click += new System.EventHandler(this.Readme_button_Click);
            // 
            // twitterLabel
            // 
            this.twitterLabel.AutoSize = true;
            this.twitterLabel.Location = new System.Drawing.Point(498, 888);
            this.twitterLabel.Name = "twitterLabel";
            this.twitterLabel.Size = new System.Drawing.Size(132, 17);
            this.twitterLabel.TabIndex = 5;
            this.twitterLabel.TabStop = true;
            this.twitterLabel.Text = "Twitter: @javigracia";
            this.twitterLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TwitterLabel_LinkClicked);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(30, 18);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(579, 45);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Oculus Go Apps Installer";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(27, 888);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(85, 17);
            this.versionLabel.TabIndex = 7;
            this.versionLabel.Text = "V.0.0.8 beta";
            // 
            // imagenOculus
            // 
            this.imagenOculus.ImageLocation = "images/oculusgo.jpg";
            this.imagenOculus.Location = new System.Drawing.Point(231, 89);
            this.imagenOculus.Name = "imagenOculus";
            this.imagenOculus.Size = new System.Drawing.Size(215, 134);
            this.imagenOculus.TabIndex = 8;
            this.imagenOculus.TabStop = false;
            // 
            // appsList_button
            // 
            this.appsList_button.Location = new System.Drawing.Point(30, 246);
            this.appsList_button.Name = "appsList_button";
            this.appsList_button.Size = new System.Drawing.Size(117, 45);
            this.appsList_button.TabIndex = 9;
            this.appsList_button.Text = "List Apps";
            this.appsList_button.UseVisualStyleBackColor = true;
            this.appsList_button.Click += new System.EventHandler(this.AppsList_button_Click);
            // 
            // appsList
            // 
            this.appsList.FormattingEnabled = true;
            this.appsList.Location = new System.Drawing.Point(231, 266);
            this.appsList.Name = "appsList";
            this.appsList.Size = new System.Drawing.Size(215, 24);
            this.appsList.TabIndex = 10;
            this.appsList.SelectedIndexChanged += new System.EventHandler(this.AppsList_SelectedIndexChanged);
            // 
            // uninstall_button
            // 
            this.uninstall_button.Location = new System.Drawing.Point(30, 297);
            this.uninstall_button.Name = "uninstall_button";
            this.uninstall_button.Size = new System.Drawing.Size(117, 45);
            this.uninstall_button.TabIndex = 11;
            this.uninstall_button.Text = "Uninstall App";
            this.uninstall_button.UseVisualStyleBackColor = true;
            this.uninstall_button.Click += new System.EventHandler(this.Uninstall_button_Click);
            // 
            // installedAppsLabel
            // 
            this.installedAppsLabel.AutoSize = true;
            this.installedAppsLabel.Location = new System.Drawing.Point(228, 246);
            this.installedAppsLabel.Name = "installedAppsLabel";
            this.installedAppsLabel.Size = new System.Drawing.Size(151, 17);
            this.installedAppsLabel.TabIndex = 12;
            this.installedAppsLabel.Text = "Filtered Installed Apps:";
            // 
            // resolution1024_button
            // 
            this.resolution1024_button.Location = new System.Drawing.Point(515, 89);
            this.resolution1024_button.Name = "resolution1024_button";
            this.resolution1024_button.Size = new System.Drawing.Size(117, 45);
            this.resolution1024_button.TabIndex = 13;
            this.resolution1024_button.Text = "Normal 1024";
            this.resolution1024_button.UseVisualStyleBackColor = true;
            this.resolution1024_button.Click += new System.EventHandler(this.Resolution1024_button_Click);
            // 
            // resolution1536_button
            // 
            this.resolution1536_button.Location = new System.Drawing.Point(515, 140);
            this.resolution1536_button.Name = "resolution1536_button";
            this.resolution1536_button.Size = new System.Drawing.Size(117, 45);
            this.resolution1536_button.TabIndex = 14;
            this.resolution1536_button.Text = "High 1536";
            this.resolution1536_button.UseVisualStyleBackColor = true;
            this.resolution1536_button.Click += new System.EventHandler(this.Resolution1536_button_Click);
            // 
            // resolution2048_button
            // 
            this.resolution2048_button.Location = new System.Drawing.Point(515, 191);
            this.resolution2048_button.Name = "resolution2048_button";
            this.resolution2048_button.Size = new System.Drawing.Size(117, 45);
            this.resolution2048_button.TabIndex = 15;
            this.resolution2048_button.Text = "Very high 2048";
            this.resolution2048_button.UseVisualStyleBackColor = true;
            this.resolution2048_button.Click += new System.EventHandler(this.Resolution2048_button_Click);
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Location = new System.Drawing.Point(516, 69);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(79, 17);
            this.resolutionLabel.TabIndex = 16;
            this.resolutionLabel.Text = "Resolution:";
            // 
            // resolution2560_button
            // 
            this.resolution2560_button.Location = new System.Drawing.Point(15, 74);
            this.resolution2560_button.Name = "resolution2560_button";
            this.resolution2560_button.Size = new System.Drawing.Size(117, 45);
            this.resolution2560_button.TabIndex = 18;
            this.resolution2560_button.Text = "Extra high 2560";
            this.resolution2560_button.UseVisualStyleBackColor = true;
            this.resolution2560_button.Click += new System.EventHandler(this.Resolution2560_button_Click);
            // 
            // resolution2048Plus_button
            // 
            this.resolution2048Plus_button.Location = new System.Drawing.Point(15, 23);
            this.resolution2048Plus_button.Name = "resolution2048Plus_button";
            this.resolution2048Plus_button.Size = new System.Drawing.Size(117, 45);
            this.resolution2048Plus_button.TabIndex = 19;
            this.resolution2048Plus_button.Text = "Very high 2048";
            this.resolution2048Plus_button.UseVisualStyleBackColor = true;
            this.resolution2048Plus_button.Click += new System.EventHandler(this.Resolution2048Plus_button_Click);
            // 
            // resolutionPlusGroupBox
            // 
            this.resolutionPlusGroupBox.Controls.Add(this.resolution3072Plus_button);
            this.resolutionPlusGroupBox.Controls.Add(this.resolution2048Plus_button);
            this.resolutionPlusGroupBox.Controls.Add(this.resolution2560_button);
            this.resolutionPlusGroupBox.ForeColor = System.Drawing.Color.DarkRed;
            this.resolutionPlusGroupBox.Location = new System.Drawing.Point(498, 274);
            this.resolutionPlusGroupBox.Name = "resolutionPlusGroupBox";
            this.resolutionPlusGroupBox.Size = new System.Drawing.Size(147, 187);
            this.resolutionPlusGroupBox.TabIndex = 20;
            this.resolutionPlusGroupBox.TabStop = false;
            this.resolutionPlusGroupBox.Text = "Cpu+gpu hack";
            // 
            // resolution3072Plus_button
            // 
            this.resolution3072Plus_button.Location = new System.Drawing.Point(17, 125);
            this.resolution3072Plus_button.Name = "resolution3072Plus_button";
            this.resolution3072Plus_button.Size = new System.Drawing.Size(117, 45);
            this.resolution3072Plus_button.TabIndex = 21;
            this.resolution3072Plus_button.Text = "Ultra high 3072";
            this.resolution3072Plus_button.UseVisualStyleBackColor = true;
            this.resolution3072Plus_button.Click += new System.EventHandler(this.Resolution3072Plus_button_Click);
            // 
            // chromaticFixOn_button
            // 
            this.chromaticFixOn_button.Location = new System.Drawing.Point(515, 509);
            this.chromaticFixOn_button.Name = "chromaticFixOn_button";
            this.chromaticFixOn_button.Size = new System.Drawing.Size(117, 45);
            this.chromaticFixOn_button.TabIndex = 21;
            this.chromaticFixOn_button.Text = "Fix On";
            this.chromaticFixOn_button.UseVisualStyleBackColor = true;
            this.chromaticFixOn_button.Click += new System.EventHandler(this.ChromaticFixOn_button_Click);
            // 
            // chromaticFixOff_button
            // 
            this.chromaticFixOff_button.Location = new System.Drawing.Point(515, 560);
            this.chromaticFixOff_button.Name = "chromaticFixOff_button";
            this.chromaticFixOff_button.Size = new System.Drawing.Size(117, 45);
            this.chromaticFixOff_button.TabIndex = 22;
            this.chromaticFixOff_button.Text = "Fix Off";
            this.chromaticFixOff_button.UseVisualStyleBackColor = true;
            this.chromaticFixOff_button.Click += new System.EventHandler(this.ChromaticFixOff_button_Click);
            // 
            // chromaticLabel
            // 
            this.chromaticLabel.AutoSize = true;
            this.chromaticLabel.Location = new System.Drawing.Point(487, 489);
            this.chromaticLabel.Name = "chromaticLabel";
            this.chromaticLabel.Size = new System.Drawing.Size(145, 17);
            this.chromaticLabel.TabIndex = 23;
            this.chromaticLabel.Text = "Chromatic Aberration:";
            // 
            // savesList_button
            // 
            this.savesList_button.Location = new System.Drawing.Point(30, 399);
            this.savesList_button.Name = "savesList_button";
            this.savesList_button.Size = new System.Drawing.Size(117, 45);
            this.savesList_button.TabIndex = 24;
            this.savesList_button.Text = "List Saves";
            this.savesList_button.UseVisualStyleBackColor = true;
            this.savesList_button.Click += new System.EventHandler(this.SavesList_button_Click);
            // 
            // saveBackup_button
            // 
            this.saveBackup_button.Location = new System.Drawing.Point(30, 450);
            this.saveBackup_button.Name = "saveBackup_button";
            this.saveBackup_button.Size = new System.Drawing.Size(117, 45);
            this.saveBackup_button.TabIndex = 25;
            this.saveBackup_button.Text = "Backup Save";
            this.saveBackup_button.UseVisualStyleBackColor = true;
            this.saveBackup_button.Click += new System.EventHandler(this.SaveBackup_button_Click);
            // 
            // saveDataList
            // 
            this.saveDataList.FormattingEnabled = true;
            this.saveDataList.Location = new System.Drawing.Point(231, 420);
            this.saveDataList.Name = "saveDataList";
            this.saveDataList.Size = new System.Drawing.Size(215, 24);
            this.saveDataList.TabIndex = 26;
            this.saveDataList.SelectedIndexChanged += new System.EventHandler(this.SaveDataList_SelectedIndexChanged_1);
            // 
            // saveDataListLabel
            // 
            this.saveDataListLabel.AutoSize = true;
            this.saveDataListLabel.Location = new System.Drawing.Point(228, 399);
            this.saveDataListLabel.Name = "saveDataListLabel";
            this.saveDataListLabel.Size = new System.Drawing.Size(136, 17);
            this.saveDataListLabel.TabIndex = 27;
            this.saveDataListLabel.Text = "Data Directory Files:";
            // 
            // saveRestore_button
            // 
            this.saveRestore_button.Location = new System.Drawing.Point(30, 501);
            this.saveRestore_button.Name = "saveRestore_button";
            this.saveRestore_button.Size = new System.Drawing.Size(117, 45);
            this.saveRestore_button.TabIndex = 28;
            this.saveRestore_button.Text = "Restore Save";
            this.saveRestore_button.UseVisualStyleBackColor = true;
            this.saveRestore_button.Click += new System.EventHandler(this.SaveRestore_button_Click);
            // 
            // saveOptionsLabel
            // 
            this.saveOptionsLabel.AutoSize = true;
            this.saveOptionsLabel.Location = new System.Drawing.Point(27, 376);
            this.saveOptionsLabel.Name = "saveOptionsLabel";
            this.saveOptionsLabel.Size = new System.Drawing.Size(97, 17);
            this.saveOptionsLabel.TabIndex = 29;
            this.saveOptionsLabel.Text = "Save Options:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 923);
            this.Controls.Add(this.saveOptionsLabel);
            this.Controls.Add(this.saveRestore_button);
            this.Controls.Add(this.saveDataListLabel);
            this.Controls.Add(this.saveDataList);
            this.Controls.Add(this.saveBackup_button);
            this.Controls.Add(this.savesList_button);
            this.Controls.Add(this.chromaticLabel);
            this.Controls.Add(this.chromaticFixOff_button);
            this.Controls.Add(this.chromaticFixOn_button);
            this.Controls.Add(this.resolutionPlusGroupBox);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.resolution2048_button);
            this.Controls.Add(this.resolution1536_button);
            this.Controls.Add(this.resolution1024_button);
            this.Controls.Add(this.installedAppsLabel);
            this.Controls.Add(this.uninstall_button);
            this.Controls.Add(this.appsList);
            this.Controls.Add(this.appsList_button);
            this.Controls.Add(this.imagenOculus);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.twitterLabel);
            this.Controls.Add(this.readme_button);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.txtLogBox);
            this.Controls.Add(this.install_button);
            this.Controls.Add(this.connect_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(676, 970);
            this.MinimumSize = new System.Drawing.Size(676, 970);
            this.Name = "Form1";
            this.Text = "Oculus Go Application Tools";
            ((System.ComponentModel.ISupportInitialize)(this.imagenOculus)).EndInit();
            this.resolutionPlusGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button install_button;
        private System.Windows.Forms.TextBox txtLogBox;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Button readme_button;
        private System.Windows.Forms.LinkLabel twitterLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.PictureBox imagenOculus;
        private System.Windows.Forms.Button appsList_button;
        private System.Windows.Forms.ComboBox appsList;
        private System.Windows.Forms.Button uninstall_button;
        private System.Windows.Forms.Label installedAppsLabel;
        private System.Windows.Forms.Button resolution1024_button;
        private System.Windows.Forms.Button resolution1536_button;
        private System.Windows.Forms.Button resolution2048_button;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Button resolution2560_button;
        private System.Windows.Forms.Button resolution2048Plus_button;
        private System.Windows.Forms.GroupBox resolutionPlusGroupBox;
        private System.Windows.Forms.Button resolution3072Plus_button;
        private System.Windows.Forms.Button chromaticFixOn_button;
        private System.Windows.Forms.Button chromaticFixOff_button;
        private System.Windows.Forms.Label chromaticLabel;
        private System.Windows.Forms.Button savesList_button;
        private System.Windows.Forms.Button saveBackup_button;
        private System.Windows.Forms.ComboBox saveDataList;
        private System.Windows.Forms.Label saveDataListLabel;
        private System.Windows.Forms.Button saveRestore_button;
        private System.Windows.Forms.Label saveOptionsLabel;
    }
}


namespace TarasPlayer
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.durationLable = new System.Windows.Forms.Label();
            this.currentLable = new System.Windows.Forms.Label();
            this.bitrateLable = new System.Windows.Forms.Label();
            this.overCheckBox = new System.Windows.Forms.CheckBox();
            this.repeatCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPlayListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePlayListItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexLable = new System.Windows.Forms.Label();
            this.volumeUp = new System.Windows.Forms.Button();
            this.nextFile = new System.Windows.Forms.Button();
            this.playPause = new System.Windows.Forms.Button();
            this.prevFile = new System.Windows.Forms.Button();
            this.volumeDown = new System.Windows.Forms.Button();
            this.fileGrid = new System.Windows.Forms.DataGridView();
            this.spectrumControl = new TarasPlayer.SpectrumControl();
            this.mPlayBar = new TarasPlayer.PlayBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // durationLable
            // 
            this.durationLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.durationLable.AutoSize = true;
            this.durationLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.durationLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.durationLable.Location = new System.Drawing.Point(6, 274);
            this.durationLable.Name = "durationLable";
            this.durationLable.Size = new System.Drawing.Size(71, 25);
            this.durationLable.TabIndex = 8;
            this.durationLable.Text = "00:00";
            // 
            // currentLable
            // 
            this.currentLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentLable.AutoSize = true;
            this.currentLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.currentLable.Location = new System.Drawing.Point(187, 274);
            this.currentLable.Name = "currentLable";
            this.currentLable.Size = new System.Drawing.Size(71, 25);
            this.currentLable.TabIndex = 7;
            this.currentLable.Text = "00:00";
            // 
            // bitrateLable
            // 
            this.bitrateLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bitrateLable.AutoEllipsis = true;
            this.bitrateLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.bitrateLable.Location = new System.Drawing.Point(166, 256);
            this.bitrateLable.Name = "bitrateLable";
            this.bitrateLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bitrateLable.Size = new System.Drawing.Size(92, 17);
            this.bitrateLable.TabIndex = 9;
            this.bitrateLable.Text = "Битрейт";
            this.bitrateLable.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // overCheckBox
            // 
            this.overCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.overCheckBox.AutoSize = true;
            this.overCheckBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.overCheckBox.Location = new System.Drawing.Point(99, 6);
            this.overCheckBox.Name = "overCheckBox";
            this.overCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.overCheckBox.Size = new System.Drawing.Size(90, 17);
            this.overCheckBox.TabIndex = 11;
            this.overCheckBox.Text = "Поверх окон";
            this.overCheckBox.UseVisualStyleBackColor = true;
            this.overCheckBox.CheckedChanged += new System.EventHandler(this.overCheckBox_CheckedChanged);
            // 
            // repeatCheckBox
            // 
            this.repeatCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.repeatCheckBox.AutoSize = true;
            this.repeatCheckBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.repeatCheckBox.Location = new System.Drawing.Point(195, 6);
            this.repeatCheckBox.Name = "repeatCheckBox";
            this.repeatCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.repeatCheckBox.Size = new System.Drawing.Size(63, 17);
            this.repeatCheckBox.TabIndex = 12;
            this.repeatCheckBox.Text = "Повтор";
            this.repeatCheckBox.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(266, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.exitItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.файлToolStripMenuItem.Text = "Меню";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileItem,
            this.openPlayListItem,
            this.savePlayListItem});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.открытьToolStripMenuItem.Text = "Файл";
            // 
            // openFileItem
            // 
            this.openFileItem.Name = "openFileItem";
            this.openFileItem.Size = new System.Drawing.Size(187, 22);
            this.openFileItem.Text = "Открыть";
            this.openFileItem.Click += new System.EventHandler(this.openFileItem_Click);
            // 
            // openPlayListItem
            // 
            this.openPlayListItem.Name = "openPlayListItem";
            this.openPlayListItem.Size = new System.Drawing.Size(187, 22);
            this.openPlayListItem.Text = "Открыть плейлист";
            // 
            // savePlayListItem
            // 
            this.savePlayListItem.Name = "savePlayListItem";
            this.savePlayListItem.Size = new System.Drawing.Size(187, 22);
            this.savePlayListItem.Text = "Сохранить плейлист";
            // 
            // exitItem
            // 
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(108, 22);
            this.exitItem.Text = "Выход";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // indexLable
            // 
            this.indexLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.indexLable.AutoSize = true;
            this.indexLable.ForeColor = System.Drawing.Color.SteelBlue;
            this.indexLable.Location = new System.Drawing.Point(8, 256);
            this.indexLable.Name = "indexLable";
            this.indexLable.Size = new System.Drawing.Size(24, 13);
            this.indexLable.TabIndex = 14;
            this.indexLable.Text = "1/1";
            // 
            // volumeUp
            // 
            this.volumeUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeUp.FlatAppearance.BorderSize = 0;
            this.volumeUp.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.volumeUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.volumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeUp.Image = global::TarasPlayer.Properties.Resources.plusIcon;
            this.volumeUp.Location = new System.Drawing.Point(201, 299);
            this.volumeUp.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.volumeUp.Name = "volumeUp";
            this.volumeUp.Size = new System.Drawing.Size(46, 46);
            this.volumeUp.TabIndex = 4;
            this.volumeUp.UseVisualStyleBackColor = true;
            this.volumeUp.Click += new System.EventHandler(this.volumeUp_Click);
            // 
            // nextFile
            // 
            this.nextFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.nextFile.FlatAppearance.BorderSize = 0;
            this.nextFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.nextFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextFile.Image = global::TarasPlayer.Properties.Resources.forwardIcon;
            this.nextFile.Location = new System.Drawing.Point(155, 299);
            this.nextFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.nextFile.Name = "nextFile";
            this.nextFile.Size = new System.Drawing.Size(46, 46);
            this.nextFile.TabIndex = 3;
            this.nextFile.UseVisualStyleBackColor = true;
            this.nextFile.Click += new System.EventHandler(this.nextFile_Click);
            // 
            // playPause
            // 
            this.playPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.playPause.FlatAppearance.BorderSize = 0;
            this.playPause.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.playPause.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.playPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playPause.Image = global::TarasPlayer.Properties.Resources.playIcon;
            this.playPause.Location = new System.Drawing.Point(109, 299);
            this.playPause.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(46, 46);
            this.playPause.TabIndex = 2;
            this.playPause.UseVisualStyleBackColor = true;
            this.playPause.Click += new System.EventHandler(this.playPause_Click);
            // 
            // prevFile
            // 
            this.prevFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.prevFile.FlatAppearance.BorderSize = 0;
            this.prevFile.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.prevFile.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.prevFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prevFile.Image = global::TarasPlayer.Properties.Resources.backwardIcon;
            this.prevFile.Location = new System.Drawing.Point(63, 299);
            this.prevFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.prevFile.Name = "prevFile";
            this.prevFile.Size = new System.Drawing.Size(46, 46);
            this.prevFile.TabIndex = 1;
            this.prevFile.UseVisualStyleBackColor = true;
            this.prevFile.Click += new System.EventHandler(this.prevFile_Click);
            // 
            // volumeDown
            // 
            this.volumeDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.volumeDown.FlatAppearance.BorderSize = 0;
            this.volumeDown.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.volumeDown.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.volumeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.volumeDown.Image = global::TarasPlayer.Properties.Resources.minusIcon;
            this.volumeDown.Location = new System.Drawing.Point(17, 299);
            this.volumeDown.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.volumeDown.Name = "volumeDown";
            this.volumeDown.Size = new System.Drawing.Size(46, 46);
            this.volumeDown.TabIndex = 0;
            this.volumeDown.UseVisualStyleBackColor = true;
            this.volumeDown.Click += new System.EventHandler(this.volumeDown_Click);
            // 
            // fileGrid
            // 
            this.fileGrid.AllowUserToAddRows = false;
            this.fileGrid.AllowUserToDeleteRows = false;
            this.fileGrid.AllowUserToResizeColumns = false;
            this.fileGrid.AllowUserToResizeRows = false;
            this.fileGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.fileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fileGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.fileGrid.Location = new System.Drawing.Point(11, 93);
            this.fileGrid.MultiSelect = false;
            this.fileGrid.Name = "fileGrid";
            this.fileGrid.ReadOnly = true;
            this.fileGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fileGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fileGrid.Size = new System.Drawing.Size(242, 160);
            this.fileGrid.TabIndex = 16;
            this.fileGrid.SelectionChanged += new System.EventHandler(this.fileGrid_SelectionChanged);
            // 
            // spectrumControl
            // 
            this.spectrumControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spectrumControl.Location = new System.Drawing.Point(29, 27);
            this.spectrumControl.Name = "spectrumControl";
            this.spectrumControl.Size = new System.Drawing.Size(209, 60);
            this.spectrumControl.TabIndex = 17;
            // 
            // mPlayBar
            // 
            this.mPlayBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPlayBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPlayBar.Location = new System.Drawing.Point(83, 274);
            this.mPlayBar.Name = "mPlayBar";
            this.mPlayBar.Size = new System.Drawing.Size(98, 22);
            this.mPlayBar.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 357);
            this.Controls.Add(this.spectrumControl);
            this.Controls.Add(this.fileGrid);
            this.Controls.Add(this.mPlayBar);
            this.Controls.Add(this.indexLable);
            this.Controls.Add(this.repeatCheckBox);
            this.Controls.Add(this.overCheckBox);
            this.Controls.Add(this.bitrateLable);
            this.Controls.Add(this.durationLable);
            this.Controls.Add(this.currentLable);
            this.Controls.Add(this.volumeUp);
            this.Controls.Add(this.nextFile);
            this.Controls.Add(this.playPause);
            this.Controls.Add(this.prevFile);
            this.Controls.Add(this.volumeDown);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(282, 320);
            this.Name = "MainForm";
            this.Text = "TarasPlayer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button volumeDown;
        private System.Windows.Forms.Button prevFile;
        private System.Windows.Forms.Button playPause;
        private System.Windows.Forms.Button nextFile;
        private System.Windows.Forms.Button volumeUp;
        private System.Windows.Forms.Label durationLable;
        private System.Windows.Forms.Label currentLable;
        private System.Windows.Forms.CheckBox overCheckBox;
        private System.Windows.Forms.CheckBox repeatCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileItem;
        private System.Windows.Forms.ToolStripMenuItem openPlayListItem;
        private System.Windows.Forms.ToolStripMenuItem savePlayListItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        public System.Windows.Forms.Label bitrateLable;
        private System.Windows.Forms.Label indexLable;
        private PlayBar mPlayBar;
        private System.Windows.Forms.DataGridView fileGrid;
        private SpectrumControl spectrumControl;
    }
}


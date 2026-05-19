namespace TVS檔案格式讀取程式
{
    partial class frmTSVFile
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mnsWord = new System.Windows.Forms.MenuStrip();
            this.lvwWord = new System.Windows.Forms.ListView();
            this.tsslMessage = new System.Windows.Forms.ToolStrip();
            this.chWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPhonogram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoundPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chExplain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.mnsWord.SuspendLayout();
            this.tsslMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsWord
            // 
            this.mnsWord.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsWord.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnsWord.Location = new System.Drawing.Point(0, 0);
            this.mnsWord.Name = "mnsWord";
            this.mnsWord.Size = new System.Drawing.Size(800, 31);
            this.mnsWord.TabIndex = 0;
            this.mnsWord.Text = "menuStrip1";
            // 
            // lvwWord
            // 
            this.lvwWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chWord,
            this.chPhonogram,
            this.chSoundPath,
            this.chExplain});
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.FullRowSelect = true;
            this.lvwWord.HideSelection = false;
            this.lvwWord.Location = new System.Drawing.Point(0, 31);
            this.lvwWord.Name = "lvwWord";
            this.lvwWord.Size = new System.Drawing.Size(800, 419);
            this.lvwWord.TabIndex = 1;
            this.lvwWord.UseCompatibleStateImageBehavior = false;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            // 
            // tsslMessage
            // 
            this.tsslMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsslMessage.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tsslMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.tsslMessage.Location = new System.Drawing.Point(0, 422);
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Size = new System.Drawing.Size(800, 28);
            this.tsslMessage.TabIndex = 3;
            this.tsslMessage.Text = "toolStrip1";
            // 
            // chWord
            // 
            this.chWord.Text = "單字";
            this.chWord.Width = 100;
            // 
            // chPhonogram
            // 
            this.chPhonogram.Text = "音標";
            this.chPhonogram.Width = 120;
            // 
            // chSoundPath
            // 
            this.chSoundPath.Text = "音檔路徑";
            this.chSoundPath.Width = 180;
            // 
            // chExplain
            // 
            this.chExplain.Text = "解釋";
            this.chExplain.Width = 300;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 27);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.OpenToolStripMenuItem.Text = "&Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(66, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 33);
            this.toolStripLabel1.Text = "單字";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // frmTSVFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tsslMessage);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.mnsWord);
            this.MainMenuStrip = this.mnsWord;
            this.Name = "frmTSVFile";
            this.Text = "TSV資料檔讀取程式";
            this.mnsWord.ResumeLayout(false);
            this.mnsWord.PerformLayout();
            this.tsslMessage.ResumeLayout(false);
            this.tsslMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsWord;
        private System.Windows.Forms.ListView lvwWord;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader chWord;
        private System.Windows.Forms.ColumnHeader chPhonogram;
        private System.Windows.Forms.ColumnHeader chSoundPath;
        private System.Windows.Forms.ColumnHeader chExplain;
        private System.Windows.Forms.ToolStrip tsslMessage;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}


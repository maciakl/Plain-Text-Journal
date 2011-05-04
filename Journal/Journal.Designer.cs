namespace Journal
{
    partial class Journal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Journal));
            this.cal = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.journalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeJournalFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.label1 = new System.Windows.Forms.Label();
            this.wordcount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filesize = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filetime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.journalentry = new SpellBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cal
            // 
            this.cal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cal.Location = new System.Drawing.Point(671, 33);
            this.cal.Name = "cal";
            this.cal.TabIndex = 1;
            this.cal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_DateChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.journalToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // journalToolStripMenuItem
            // 
            this.journalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentEntryToolStripMenuItem,
            this.changeJournalFolderToolStripMenuItem1});
            this.journalToolStripMenuItem.Name = "journalToolStripMenuItem";
            this.journalToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.journalToolStripMenuItem.Text = "Journal";
            // 
            // saveCurrentEntryToolStripMenuItem
            // 
            this.saveCurrentEntryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveCurrentEntryToolStripMenuItem.Image")));
            this.saveCurrentEntryToolStripMenuItem.Name = "saveCurrentEntryToolStripMenuItem";
            this.saveCurrentEntryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCurrentEntryToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.saveCurrentEntryToolStripMenuItem.Text = "Save Current Entry";
            this.saveCurrentEntryToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentEntryToolStripMenuItem_Click);
            // 
            // changeJournalFolderToolStripMenuItem1
            // 
            this.changeJournalFolderToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("changeJournalFolderToolStripMenuItem1.Image")));
            this.changeJournalFolderToolStripMenuItem1.Name = "changeJournalFolderToolStripMenuItem1";
            this.changeJournalFolderToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.changeJournalFolderToolStripMenuItem1.Text = "Change Journal Folder";
            this.changeJournalFolderToolStripMenuItem1.Click += new System.EventHandler(this.changeJournalFolderToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(671, 531);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(227, 32);
            this.save.TabIndex = 3;
            this.save.Text = "Save (Ctrl+S)";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // clear
            // 
            this.clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear.Location = new System.Drawing.Point(671, 493);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(227, 32);
            this.clear.TabIndex = 4;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Word Count: ";
            // 
            // wordcount
            // 
            this.wordcount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.wordcount.AutoSize = true;
            this.wordcount.Location = new System.Drawing.Point(125, 27);
            this.wordcount.Name = "wordcount";
            this.wordcount.Size = new System.Drawing.Size(13, 13);
            this.wordcount.TabIndex = 7;
            this.wordcount.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Character Count:";
            // 
            // charcount
            // 
            this.charcount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.charcount.AutoSize = true;
            this.charcount.Location = new System.Drawing.Point(125, 50);
            this.charcount.Name = "charcount";
            this.charcount.Size = new System.Drawing.Size(13, 13);
            this.charcount.TabIndex = 9;
            this.charcount.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Size on disk:";
            // 
            // filesize
            // 
            this.filesize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filesize.AutoSize = true;
            this.filesize.Location = new System.Drawing.Point(125, 60);
            this.filesize.Name = "filesize";
            this.filesize.Size = new System.Drawing.Size(13, 13);
            this.filesize.TabIndex = 11;
            this.filesize.Text = "0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Last saved:";
            // 
            // filetime
            // 
            this.filetime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.filetime.AutoSize = true;
            this.filetime.Location = new System.Drawing.Point(125, 25);
            this.filetime.Name = "filetime";
            this.filetime.Size = new System.Drawing.Size(96, 13);
            this.filetime.TabIndex = 13;
            this.filetime.Text = "__/__/__ __:__ xx";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.wordcount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.charcount);
            this.groupBox1.Location = new System.Drawing.Point(671, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 99);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics for Current Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.filetime);
            this.groupBox2.Controls.Add(this.filesize);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(671, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 111);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File Information";
            // 
            // journalentry
            // 
            this.journalentry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.journalentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journalentry.KeyUp1 = null;
            this.journalentry.Location = new System.Drawing.Point(12, 33);
            this.journalentry.Multiline = true;
            this.journalentry.Name = "journalentry";
            this.journalentry.Size = new System.Drawing.Size(647, 530);
            this.journalentry.TabIndex = 5;
            this.journalentry.WordWrap = true;
            this.journalentry.Child = new System.Windows.Controls.TextBox();
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.journalentry);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Journal";
            this.Text = "Plain Text Journal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.ServiceProcess.ServiceController serviceController1;
        private SpellBox journalentry;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem journalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeJournalFolderToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wordcount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label charcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label filesize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label filetime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


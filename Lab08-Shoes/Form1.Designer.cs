namespace Lab08_Shoes
{
    partial class frmLab08Shoes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLab08Shoes));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShoes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShoesBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.sstImage = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sslPicture = new System.Windows.Forms.ToolStripStatusLabel();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.conMnuBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.sstImage.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuShoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(56, 32);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuFileExit.Size = new System.Drawing.Size(192, 32);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuShoes
            // 
            this.mnuShoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuShoesBrowse});
            this.mnuShoes.Name = "mnuShoes";
            this.mnuShoes.Size = new System.Drawing.Size(78, 32);
            this.mnuShoes.Text = "&Shoes";
            // 
            // mnuShoesBrowse
            // 
            this.mnuShoesBrowse.Name = "mnuShoesBrowse";
            this.mnuShoesBrowse.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.mnuShoesBrowse.Size = new System.Drawing.Size(234, 32);
            this.mnuShoesBrowse.Text = "&Browse...";
            this.mnuShoesBrowse.Click += new System.EventHandler(this.mnuShoesBrowse_Click);
            // 
            // picDisplay
            // 
            this.picDisplay.Image = ((System.Drawing.Image)(resources.GetObject("picDisplay.Image")));
            this.picDisplay.ImageLocation = "";
            this.picDisplay.Location = new System.Drawing.Point(172, 91);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(486, 260);
            this.picDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDisplay.TabIndex = 1;
            this.picDisplay.TabStop = false;
            // 
            // sstImage
            // 
            this.sstImage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.sslPicture});
            this.sstImage.Location = new System.Drawing.Point(0, 421);
            this.sstImage.Name = "sstImage";
            this.sstImage.Size = new System.Drawing.Size(800, 29);
            this.sstImage.TabIndex = 2;
            this.sstImage.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 23);
            this.toolStripStatusLabel1.Text = "Image name: ";
            // 
            // sslPicture
            // 
            this.sslPicture.Name = "sslPicture";
            this.sslPicture.Size = new System.Drawing.Size(169, 23);
            this.sslPicture.Text = "toolStripStatusLabel2";
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conMnuBrowser});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(195, 32);
            // 
            // conMnuBrowser
            // 
            this.conMnuBrowser.Name = "conMnuBrowser";
            this.conMnuBrowser.Size = new System.Drawing.Size(194, 28);
            this.conMnuBrowser.Text = "Browse shoes...";
            this.conMnuBrowser.Click += new System.EventHandler(this.conMnuBrowser_Click);
            // 
            // frmLab08Shoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.sstImage);
            this.Controls.Add(this.picDisplay);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLab08Shoes";
            this.Text = "Lab 8 Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.sstImage.ResumeLayout(false);
            this.sstImage.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuShoes;
        private System.Windows.Forms.ToolStripMenuItem mnuShoesBrowse;
        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.StatusStrip sstImage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ToolStripStatusLabel sslPicture;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conMnuBrowser;
    }
}


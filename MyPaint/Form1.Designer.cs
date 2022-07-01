
namespace MyPaint
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.redButton = new System.Windows.Forms.ToolStripButton();
            this.blueButton = new System.Windows.Forms.ToolStripButton();
            this.greenButton = new System.Windows.Forms.ToolStripButton();
            this.purpleButton = new System.Windows.Forms.ToolStripButton();
            this.limeButton = new System.Windows.Forms.ToolStripButton();
            this.blackButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.whiteButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsImageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save As";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsImageToolStripMenuItem
            // 
            this.saveAsImageToolStripMenuItem.Name = "saveAsImageToolStripMenuItem";
            this.saveAsImageToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
            this.saveAsImageToolStripMenuItem.Text = "Save As Image";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redButton,
            this.blueButton,
            this.greenButton,
            this.purpleButton,
            this.limeButton,
            this.blackButton,
            this.whiteButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // redButton
            // 
            this.redButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.redButton.ForeColor = System.Drawing.Color.Red;
            this.redButton.Image = ((System.Drawing.Image)(resources.GetObject("redButton.Image")));
            this.redButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(35, 24);
            this.redButton.Text = "red";
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blueButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.blueButton.Image = ((System.Drawing.Image)(resources.GetObject("blueButton.Image")));
            this.blueButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(42, 24);
            this.blueButton.Text = "blue";
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.greenButton.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.greenButton.Image = ((System.Drawing.Image)(resources.GetObject("greenButton.Image")));
            this.greenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(51, 24);
            this.greenButton.Text = "green";
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // purpleButton
            // 
            this.purpleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.purpleButton.ForeColor = System.Drawing.Color.Purple;
            this.purpleButton.Image = ((System.Drawing.Image)(resources.GetObject("purpleButton.Image")));
            this.purpleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.purpleButton.Name = "purpleButton";
            this.purpleButton.Size = new System.Drawing.Size(56, 24);
            this.purpleButton.Text = "purple";
            this.purpleButton.Click += new System.EventHandler(this.purpleButton_Click);
            // 
            // limeButton
            // 
            this.limeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.limeButton.ForeColor = System.Drawing.Color.Lime;
            this.limeButton.Image = ((System.Drawing.Image)(resources.GetObject("limeButton.Image")));
            this.limeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.limeButton.Name = "limeButton";
            this.limeButton.Size = new System.Drawing.Size(42, 24);
            this.limeButton.Text = "lime";
            this.limeButton.Click += new System.EventHandler(this.limeButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blackButton.ForeColor = System.Drawing.Color.Black;
            this.blackButton.Image = ((System.Drawing.Image)(resources.GetObject("blackButton.Image")));
            this.blackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(48, 24);
            this.blackButton.Text = "black";
            this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 55);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(800, 395);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // whiteButton
            // 
            this.whiteButton.BackColor = System.Drawing.Color.Gray;
            this.whiteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.whiteButton.ForeColor = System.Drawing.Color.White;
            this.whiteButton.Image = ((System.Drawing.Image)(resources.GetObject("whiteButton.Image")));
            this.whiteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.whiteButton.Name = "whiteButton";
            this.whiteButton.Size = new System.Drawing.Size(49, 24);
            this.whiteButton.Text = "white";
            this.whiteButton.Click += new System.EventHandler(this.whiteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsImageToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton redButton;
        private System.Windows.Forms.ToolStripButton blueButton;
        private System.Windows.Forms.ToolStripButton greenButton;
        private System.Windows.Forms.ToolStripButton purpleButton;
        private System.Windows.Forms.ToolStripButton limeButton;
        private System.Windows.Forms.ToolStripButton blackButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton whiteButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


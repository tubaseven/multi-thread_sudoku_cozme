namespace Yazlab_1._2
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sudokuYükleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_stage = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button_animateSolution = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sudokuYükleToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // sudokuYükleToolStripMenuItem
            // 
            this.sudokuYükleToolStripMenuItem.Name = "sudokuYükleToolStripMenuItem";
            this.sudokuYükleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sudokuYükleToolStripMenuItem.Text = "Sudoku Yükle";
            this.sudokuYükleToolStripMenuItem.Click += new System.EventHandler(this.sudokuYükleToolStripMenuItem_Click);
            // 
            // panel_stage
            // 
            this.panel_stage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_stage.Location = new System.Drawing.Point(414, 82);
            this.panel_stage.Name = "panel_stage";
            this.panel_stage.Size = new System.Drawing.Size(368, 330);
            this.panel_stage.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 80);
            this.button1.TabIndex = 0;
            this.button1.Text = "TRY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_animateSolution
            // 
            this.button_animateSolution.Location = new System.Drawing.Point(39, 171);
            this.button_animateSolution.Name = "button_animateSolution";
            this.button_animateSolution.Size = new System.Drawing.Size(265, 90);
            this.button_animateSolution.TabIndex = 2;
            this.button_animateSolution.Text = "Animatre Solution";
            this.button_animateSolution.UseVisualStyleBackColor = true;
            this.button_animateSolution.Click += new System.EventHandler(this.button_animateSolution_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 722);
            this.Controls.Add(this.button_animateSolution);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_stage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MULTITHREAD SUDOKU  ÇÖZÜMÜ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sudokuYükleToolStripMenuItem;
        private System.Windows.Forms.Panel panel_stage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_animateSolution;
        private System.Windows.Forms.Timer timer1;
    }
}


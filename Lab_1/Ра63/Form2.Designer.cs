namespace Ра63
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.приветствиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стихотворениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводИзРазныхСИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.решениеКвуравненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приветствиеToolStripMenuItem,
            this.стихотворениеToolStripMenuItem,
            this.переводИзРазныхСИToolStripMenuItem,
            this.решениеКвуравненияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // приветствиеToolStripMenuItem
            // 
            this.приветствиеToolStripMenuItem.Name = "приветствиеToolStripMenuItem";
            this.приветствиеToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.приветствиеToolStripMenuItem.Text = "Приветствие";
            this.приветствиеToolStripMenuItem.Click += new System.EventHandler(this.приветствиеToolStripMenuItem_Click);
            // 
            // стихотворениеToolStripMenuItem
            // 
            this.стихотворениеToolStripMenuItem.Name = "стихотворениеToolStripMenuItem";
            this.стихотворениеToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.стихотворениеToolStripMenuItem.Text = "Стихотворение";
            this.стихотворениеToolStripMenuItem.Click += new System.EventHandler(this.стихотворениеToolStripMenuItem_Click);
            // 
            // переводИзРазныхСИToolStripMenuItem
            // 
            this.переводИзРазныхСИToolStripMenuItem.Name = "переводИзРазныхСИToolStripMenuItem";
            this.переводИзРазныхСИToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.переводИзРазныхСИToolStripMenuItem.Text = "Перевод из разных СИ";
            this.переводИзРазныхСИToolStripMenuItem.Click += new System.EventHandler(this.переводИзРазныхСИToolStripMenuItem_Click);
            // 
            // решениеКвуравненияToolStripMenuItem
            // 
            this.решениеКвуравненияToolStripMenuItem.Name = "решениеКвуравненияToolStripMenuItem";
            this.решениеКвуравненияToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.решениеКвуравненияToolStripMenuItem.Text = "Решение кв.уравнения";
            this.решениеКвуравненияToolStripMenuItem.Click += new System.EventHandler(this.решениеКвуравненияToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 500);
            this.panel1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Раб3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem приветствиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стихотворениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переводИзРазныхСИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem решениеКвуравненияToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}
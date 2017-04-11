namespace Saaty
{
    partial class FormMain
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
            this.buttonCriteria = new System.Windows.Forms.Button();
            this.buttonAlternative = new System.Windows.Forms.Button();
            this.buttonWeightCriteria = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMatrixWeight = new System.Windows.Forms.Button();
            this.buttonWeightAlternative = new System.Windows.Forms.Button();
            this.buttonMatrixWeightAlternative = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCriteria
            // 
            this.buttonCriteria.Location = new System.Drawing.Point(12, 27);
            this.buttonCriteria.Name = "buttonCriteria";
            this.buttonCriteria.Size = new System.Drawing.Size(145, 23);
            this.buttonCriteria.TabIndex = 1;
            this.buttonCriteria.Text = "Zarządzaj Kryteriami";
            this.buttonCriteria.UseVisualStyleBackColor = true;
            this.buttonCriteria.Click += new System.EventHandler(this.buttonCriteria_Click);
            // 
            // buttonAlternative
            // 
            this.buttonAlternative.Location = new System.Drawing.Point(12, 56);
            this.buttonAlternative.Name = "buttonAlternative";
            this.buttonAlternative.Size = new System.Drawing.Size(145, 23);
            this.buttonAlternative.TabIndex = 2;
            this.buttonAlternative.Text = "Zarządaj Alternatywami";
            this.buttonAlternative.UseVisualStyleBackColor = true;
            this.buttonAlternative.Click += new System.EventHandler(this.buttonAlternative_Click);
            // 
            // buttonWeightCriteria
            // 
            this.buttonWeightCriteria.Location = new System.Drawing.Point(163, 27);
            this.buttonWeightCriteria.Name = "buttonWeightCriteria";
            this.buttonWeightCriteria.Size = new System.Drawing.Size(75, 23);
            this.buttonWeightCriteria.TabIndex = 3;
            this.buttonWeightCriteria.Text = "Wagi";
            this.buttonWeightCriteria.UseVisualStyleBackColor = true;
            this.buttonWeightCriteria.Click += new System.EventHandler(this.buttonWeightCriteria_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(407, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.fileToolStripMenuItem.Text = "Plik";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "Nowy";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // buttonMatrixWeight
            // 
            this.buttonMatrixWeight.Location = new System.Drawing.Point(244, 27);
            this.buttonMatrixWeight.Name = "buttonMatrixWeight";
            this.buttonMatrixWeight.Size = new System.Drawing.Size(75, 23);
            this.buttonMatrixWeight.TabIndex = 5;
            this.buttonMatrixWeight.Text = "Matrix";
            this.buttonMatrixWeight.UseVisualStyleBackColor = true;
            this.buttonMatrixWeight.Click += new System.EventHandler(this.buttonMatrixWeight_Click);
            // 
            // buttonWeightAlternative
            // 
            this.buttonWeightAlternative.Location = new System.Drawing.Point(163, 56);
            this.buttonWeightAlternative.Name = "buttonWeightAlternative";
            this.buttonWeightAlternative.Size = new System.Drawing.Size(75, 23);
            this.buttonWeightAlternative.TabIndex = 6;
            this.buttonWeightAlternative.Text = "Wagi";
            this.buttonWeightAlternative.UseVisualStyleBackColor = true;
            this.buttonWeightAlternative.Click += new System.EventHandler(this.buttonWeightAlternative_Click);
            // 
            // buttonMatrixWeightAlternative
            // 
            this.buttonMatrixWeightAlternative.Location = new System.Drawing.Point(245, 56);
            this.buttonMatrixWeightAlternative.Name = "buttonMatrixWeightAlternative";
            this.buttonMatrixWeightAlternative.Size = new System.Drawing.Size(75, 23);
            this.buttonMatrixWeightAlternative.TabIndex = 7;
            this.buttonMatrixWeightAlternative.Text = "Matrix";
            this.buttonMatrixWeightAlternative.UseVisualStyleBackColor = true;
            this.buttonMatrixWeightAlternative.Click += new System.EventHandler(this.buttonMatrixWeightAlternative_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 288);
            this.Controls.Add(this.buttonMatrixWeightAlternative);
            this.Controls.Add(this.buttonWeightAlternative);
            this.Controls.Add(this.buttonMatrixWeight);
            this.Controls.Add(this.buttonWeightCriteria);
            this.Controls.Add(this.buttonAlternative);
            this.Controls.Add(this.buttonCriteria);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Metoda analizy hierarchii Saaty’ego";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCriteria;
        private System.Windows.Forms.Button buttonAlternative;
        private System.Windows.Forms.Button buttonWeightCriteria;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Button buttonMatrixWeight;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button buttonWeightAlternative;
        private System.Windows.Forms.Button buttonMatrixWeightAlternative;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMatrixWeight = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otwórzToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 288);
            this.Controls.Add(this.buttonMatrixWeight);
            this.Controls.Add(this.buttonWeightCriteria);
            this.Controls.Add(this.buttonAlternative);
            this.Controls.Add(this.buttonCriteria);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Metoda analizy hierarchii Saaty’ego";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCriteria;
        private System.Windows.Forms.Button buttonAlternative;
        private System.Windows.Forms.Button buttonWeightCriteria;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
        private System.Windows.Forms.Button buttonMatrixWeight;
    }
}
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
            this.SuspendLayout();
            // 
            // buttonCriteria
            // 
            this.buttonCriteria.Location = new System.Drawing.Point(250, 12);
            this.buttonCriteria.Name = "buttonCriteria";
            this.buttonCriteria.Size = new System.Drawing.Size(145, 23);
            this.buttonCriteria.TabIndex = 1;
            this.buttonCriteria.Text = "Zarządzaj Kryteriami";
            this.buttonCriteria.UseVisualStyleBackColor = true;
            this.buttonCriteria.Click += new System.EventHandler(this.buttonCriteria_Click);
            // 
            // buttonAlternative
            // 
            this.buttonAlternative.Location = new System.Drawing.Point(250, 42);
            this.buttonAlternative.Name = "buttonAlternative";
            this.buttonAlternative.Size = new System.Drawing.Size(145, 23);
            this.buttonAlternative.TabIndex = 2;
            this.buttonAlternative.Text = "Zarządaj Alternatywami";
            this.buttonAlternative.UseVisualStyleBackColor = true;
            this.buttonAlternative.Click += new System.EventHandler(this.buttonAlternative_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 288);
            this.Controls.Add(this.buttonAlternative);
            this.Controls.Add(this.buttonCriteria);
            this.Name = "FormMain";
            this.Text = "Metoda analizy hierarchii Saaty’ego";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCriteria;
        private System.Windows.Forms.Button buttonAlternative;
    }
}
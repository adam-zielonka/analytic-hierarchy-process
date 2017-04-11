namespace Saaty
{
    partial class FormCriteria
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
            this.dataGridViewCriteria = new System.Windows.Forms.DataGridView();
            this.Criteria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSaveCriteria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriteria)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCriteria
            // 
            this.dataGridViewCriteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCriteria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Criteria});
            this.dataGridViewCriteria.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCriteria.Name = "dataGridViewCriteria";
            this.dataGridViewCriteria.Size = new System.Drawing.Size(292, 236);
            this.dataGridViewCriteria.TabIndex = 0;
            // 
            // Criteria
            // 
            this.Criteria.HeaderText = "Kryteria";
            this.Criteria.Name = "Criteria";
            // 
            // buttonSaveCriteria
            // 
            this.buttonSaveCriteria.Location = new System.Drawing.Point(12, 254);
            this.buttonSaveCriteria.Name = "buttonSaveCriteria";
            this.buttonSaveCriteria.Size = new System.Drawing.Size(292, 23);
            this.buttonSaveCriteria.TabIndex = 1;
            this.buttonSaveCriteria.Text = "Zapisz Kryteria";
            this.buttonSaveCriteria.UseVisualStyleBackColor = true;
            this.buttonSaveCriteria.Click += new System.EventHandler(this.buttonSaveCriteria_Click);
            // 
            // FormCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 289);
            this.Controls.Add(this.buttonSaveCriteria);
            this.Controls.Add(this.dataGridViewCriteria);
            this.Name = "FormCriteria";
            this.Text = "Zarządzaj Kryteriami";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCriteria_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriteria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCriteria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Criteria;
        private System.Windows.Forms.Button buttonSaveCriteria;
    }
}
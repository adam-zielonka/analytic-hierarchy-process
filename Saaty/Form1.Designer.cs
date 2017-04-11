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
            this.buttonAddKryteria = new System.Windows.Forms.Button();
            this.textBoxAddKryteria = new System.Windows.Forms.TextBox();
            this.listBoxKryteria = new System.Windows.Forms.ListBox();
            this.listBoxAlternatywy = new System.Windows.Forms.ListBox();
            this.textBoxAddAlternatywy = new System.Windows.Forms.TextBox();
            this.buttonAddAlternatywy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKA = new System.Windows.Forms.DataGridView();
            this.buttonCreateGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddKryteria
            // 
            this.buttonAddKryteria.Location = new System.Drawing.Point(12, 149);
            this.buttonAddKryteria.Name = "buttonAddKryteria";
            this.buttonAddKryteria.Size = new System.Drawing.Size(120, 24);
            this.buttonAddKryteria.TabIndex = 1;
            this.buttonAddKryteria.Text = "Dodaj";
            this.buttonAddKryteria.UseVisualStyleBackColor = true;
            this.buttonAddKryteria.Click += new System.EventHandler(this.buttonAddKryteria_Click);
            // 
            // textBoxAddKryteria
            // 
            this.textBoxAddKryteria.Location = new System.Drawing.Point(12, 123);
            this.textBoxAddKryteria.Name = "textBoxAddKryteria";
            this.textBoxAddKryteria.Size = new System.Drawing.Size(120, 20);
            this.textBoxAddKryteria.TabIndex = 2;
            // 
            // listBoxKryteria
            // 
            this.listBoxKryteria.FormattingEnabled = true;
            this.listBoxKryteria.Location = new System.Drawing.Point(12, 22);
            this.listBoxKryteria.Name = "listBoxKryteria";
            this.listBoxKryteria.Size = new System.Drawing.Size(120, 95);
            this.listBoxKryteria.TabIndex = 3;
            // 
            // listBoxAlternatywy
            // 
            this.listBoxAlternatywy.FormattingEnabled = true;
            this.listBoxAlternatywy.Location = new System.Drawing.Point(138, 22);
            this.listBoxAlternatywy.Name = "listBoxAlternatywy";
            this.listBoxAlternatywy.Size = new System.Drawing.Size(120, 95);
            this.listBoxAlternatywy.TabIndex = 6;
            // 
            // textBoxAddAlternatywy
            // 
            this.textBoxAddAlternatywy.Location = new System.Drawing.Point(138, 123);
            this.textBoxAddAlternatywy.Name = "textBoxAddAlternatywy";
            this.textBoxAddAlternatywy.Size = new System.Drawing.Size(120, 20);
            this.textBoxAddAlternatywy.TabIndex = 5;
            // 
            // buttonAddAlternatywy
            // 
            this.buttonAddAlternatywy.Location = new System.Drawing.Point(138, 149);
            this.buttonAddAlternatywy.Name = "buttonAddAlternatywy";
            this.buttonAddAlternatywy.Size = new System.Drawing.Size(120, 24);
            this.buttonAddAlternatywy.TabIndex = 4;
            this.buttonAddAlternatywy.Text = "Dodaj";
            this.buttonAddAlternatywy.UseVisualStyleBackColor = true;
            this.buttonAddAlternatywy.Click += new System.EventHandler(this.buttonAddAlternatywy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kryteria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Alternatywy";
            // 
            // dataGridViewKA
            // 
            this.dataGridViewKA.AllowUserToAddRows = false;
            this.dataGridViewKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKA.Location = new System.Drawing.Point(264, 12);
            this.dataGridViewKA.Name = "dataGridViewKA";
            this.dataGridViewKA.Size = new System.Drawing.Size(728, 312);
            this.dataGridViewKA.TabIndex = 9;
            // 
            // buttonCreateGrid
            // 
            this.buttonCreateGrid.Location = new System.Drawing.Point(12, 180);
            this.buttonCreateGrid.Name = "buttonCreateGrid";
            this.buttonCreateGrid.Size = new System.Drawing.Size(246, 23);
            this.buttonCreateGrid.TabIndex = 10;
            this.buttonCreateGrid.Text = "Generuj";
            this.buttonCreateGrid.UseVisualStyleBackColor = true;
            this.buttonCreateGrid.Click += new System.EventHandler(this.buttonCreateGrid_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 429);
            this.Controls.Add(this.buttonCreateGrid);
            this.Controls.Add(this.dataGridViewKA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAlternatywy);
            this.Controls.Add(this.textBoxAddAlternatywy);
            this.Controls.Add(this.buttonAddAlternatywy);
            this.Controls.Add(this.listBoxKryteria);
            this.Controls.Add(this.textBoxAddKryteria);
            this.Controls.Add(this.buttonAddKryteria);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddKryteria;
        private System.Windows.Forms.TextBox textBoxAddKryteria;
        private System.Windows.Forms.ListBox listBoxKryteria;
        private System.Windows.Forms.ListBox listBoxAlternatywy;
        private System.Windows.Forms.TextBox textBoxAddAlternatywy;
        private System.Windows.Forms.Button buttonAddAlternatywy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKA;
        private System.Windows.Forms.Button buttonCreateGrid;
    }
}


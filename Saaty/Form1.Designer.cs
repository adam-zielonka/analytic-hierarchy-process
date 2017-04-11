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
            this.buttonDodajKryteria = new System.Windows.Forms.Button();
            this.textBoxAddKryteria = new System.Windows.Forms.TextBox();
            this.listBoxKryteria = new System.Windows.Forms.ListBox();
            this.listBoxAlternatywy = new System.Windows.Forms.ListBox();
            this.textBoxAddAlternatywy = new System.Windows.Forms.TextBox();
            this.buttonDodajAlternatywy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewKA = new System.Windows.Forms.DataGridView();
            this.buttonCreateGrid = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonUsunKryteria = new System.Windows.Forms.Button();
            this.buttonUsunAlternatywy = new System.Windows.Forms.Button();
            this.buttonPrzykladoweDane = new System.Windows.Forms.Button();
            this.dataGridViewParzystePorownania = new System.Windows.Forms.DataGridView();
            this.buttonPrzeliczenie = new System.Windows.Forms.Button();
            this.dataGridViewWagiKryterium = new System.Windows.Forms.DataGridView();
            this.comboBoxKryteria = new System.Windows.Forms.ComboBox();
            this.buttonWagiKryterium = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParzystePorownania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWagiKryterium)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDodajKryteria
            // 
            this.buttonDodajKryteria.Location = new System.Drawing.Point(12, 149);
            this.buttonDodajKryteria.Name = "buttonDodajKryteria";
            this.buttonDodajKryteria.Size = new System.Drawing.Size(120, 24);
            this.buttonDodajKryteria.TabIndex = 1;
            this.buttonDodajKryteria.Text = "Dodaj";
            this.buttonDodajKryteria.UseVisualStyleBackColor = true;
            this.buttonDodajKryteria.Click += new System.EventHandler(this.buttonAddKryteria_Click);
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
            // buttonDodajAlternatywy
            // 
            this.buttonDodajAlternatywy.Location = new System.Drawing.Point(138, 149);
            this.buttonDodajAlternatywy.Name = "buttonDodajAlternatywy";
            this.buttonDodajAlternatywy.Size = new System.Drawing.Size(120, 24);
            this.buttonDodajAlternatywy.TabIndex = 4;
            this.buttonDodajAlternatywy.Text = "Dodaj";
            this.buttonDodajAlternatywy.UseVisualStyleBackColor = true;
            this.buttonDodajAlternatywy.Click += new System.EventHandler(this.buttonAddAlternatywy_Click);
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
            this.dataGridViewKA.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewKA.Size = new System.Drawing.Size(832, 190);
            this.dataGridViewKA.TabIndex = 9;
            // 
            // buttonCreateGrid
            // 
            this.buttonCreateGrid.Location = new System.Drawing.Point(12, 208);
            this.buttonCreateGrid.Name = "buttonCreateGrid";
            this.buttonCreateGrid.Size = new System.Drawing.Size(246, 23);
            this.buttonCreateGrid.TabIndex = 10;
            this.buttonCreateGrid.Text = "Generuj";
            this.buttonCreateGrid.UseVisualStyleBackColor = true;
            this.buttonCreateGrid.Click += new System.EventHandler(this.buttonCreateGrid_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 237);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(246, 23);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Resetuj";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonUsunKryteria
            // 
            this.buttonUsunKryteria.Location = new System.Drawing.Point(12, 179);
            this.buttonUsunKryteria.Name = "buttonUsunKryteria";
            this.buttonUsunKryteria.Size = new System.Drawing.Size(120, 23);
            this.buttonUsunKryteria.TabIndex = 12;
            this.buttonUsunKryteria.Text = "Usuń";
            this.buttonUsunKryteria.UseVisualStyleBackColor = true;
            this.buttonUsunKryteria.Click += new System.EventHandler(this.buttonUsunKryteria_Click);
            // 
            // buttonUsunAlternatywy
            // 
            this.buttonUsunAlternatywy.Location = new System.Drawing.Point(138, 179);
            this.buttonUsunAlternatywy.Name = "buttonUsunAlternatywy";
            this.buttonUsunAlternatywy.Size = new System.Drawing.Size(120, 23);
            this.buttonUsunAlternatywy.TabIndex = 13;
            this.buttonUsunAlternatywy.Text = "Usuń";
            this.buttonUsunAlternatywy.UseVisualStyleBackColor = true;
            this.buttonUsunAlternatywy.Click += new System.EventHandler(this.buttonUsunAlternatywy_Click);
            // 
            // buttonPrzykladoweDane
            // 
            this.buttonPrzykladoweDane.Location = new System.Drawing.Point(12, 267);
            this.buttonPrzykladoweDane.Name = "buttonPrzykladoweDane";
            this.buttonPrzykladoweDane.Size = new System.Drawing.Size(246, 23);
            this.buttonPrzykladoweDane.TabIndex = 14;
            this.buttonPrzykladoweDane.Text = "Przykladowe dane";
            this.buttonPrzykladoweDane.UseVisualStyleBackColor = true;
            this.buttonPrzykladoweDane.Click += new System.EventHandler(this.buttonPrzykladoweDane_Click);
            // 
            // dataGridViewParzystePorownania
            // 
            this.dataGridViewParzystePorownania.AllowUserToAddRows = false;
            this.dataGridViewParzystePorownania.AllowUserToDeleteRows = false;
            this.dataGridViewParzystePorownania.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParzystePorownania.Location = new System.Drawing.Point(264, 326);
            this.dataGridViewParzystePorownania.Name = "dataGridViewParzystePorownania";
            this.dataGridViewParzystePorownania.ReadOnly = true;
            this.dataGridViewParzystePorownania.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewParzystePorownania.Size = new System.Drawing.Size(832, 217);
            this.dataGridViewParzystePorownania.TabIndex = 15;
            this.dataGridViewParzystePorownania.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewParzystePorownania_CellEndEdit);
            // 
            // buttonPrzeliczenie
            // 
            this.buttonPrzeliczenie.Location = new System.Drawing.Point(12, 297);
            this.buttonPrzeliczenie.Name = "buttonPrzeliczenie";
            this.buttonPrzeliczenie.Size = new System.Drawing.Size(246, 23);
            this.buttonPrzeliczenie.TabIndex = 16;
            this.buttonPrzeliczenie.Text = "Przelicz";
            this.buttonPrzeliczenie.UseVisualStyleBackColor = true;
            this.buttonPrzeliczenie.Click += new System.EventHandler(this.buttonPrzeliczenie_Click);
            // 
            // dataGridViewWagiKryterium
            // 
            this.dataGridViewWagiKryterium.AllowUserToAddRows = false;
            this.dataGridViewWagiKryterium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWagiKryterium.Location = new System.Drawing.Point(264, 237);
            this.dataGridViewWagiKryterium.Name = "dataGridViewWagiKryterium";
            this.dataGridViewWagiKryterium.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewWagiKryterium.Size = new System.Drawing.Size(832, 83);
            this.dataGridViewWagiKryterium.TabIndex = 17;
            // 
            // comboBoxKryteria
            // 
            this.comboBoxKryteria.FormattingEnabled = true;
            this.comboBoxKryteria.Location = new System.Drawing.Point(264, 209);
            this.comboBoxKryteria.Name = "comboBoxKryteria";
            this.comboBoxKryteria.Size = new System.Drawing.Size(141, 21);
            this.comboBoxKryteria.TabIndex = 18;
            this.comboBoxKryteria.SelectedIndexChanged += new System.EventHandler(this.comboBoxKryteria_SelectedIndexChanged);
            // 
            // buttonWagiKryterium
            // 
            this.buttonWagiKryterium.Location = new System.Drawing.Point(12, 326);
            this.buttonWagiKryterium.Name = "buttonWagiKryterium";
            this.buttonWagiKryterium.Size = new System.Drawing.Size(246, 23);
            this.buttonWagiKryterium.TabIndex = 19;
            this.buttonWagiKryterium.Text = "UstalWagi";
            this.buttonWagiKryterium.UseVisualStyleBackColor = true;
            this.buttonWagiKryterium.Click += new System.EventHandler(this.buttonWagiKryterium_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 593);
            this.Controls.Add(this.buttonWagiKryterium);
            this.Controls.Add(this.comboBoxKryteria);
            this.Controls.Add(this.dataGridViewWagiKryterium);
            this.Controls.Add(this.buttonPrzeliczenie);
            this.Controls.Add(this.dataGridViewParzystePorownania);
            this.Controls.Add(this.buttonPrzykladoweDane);
            this.Controls.Add(this.buttonUsunAlternatywy);
            this.Controls.Add(this.buttonUsunKryteria);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonCreateGrid);
            this.Controls.Add(this.dataGridViewKA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAlternatywy);
            this.Controls.Add(this.textBoxAddAlternatywy);
            this.Controls.Add(this.buttonDodajAlternatywy);
            this.Controls.Add(this.listBoxKryteria);
            this.Controls.Add(this.textBoxAddKryteria);
            this.Controls.Add(this.buttonDodajKryteria);
            this.Name = "FormMain";
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParzystePorownania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWagiKryterium)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDodajKryteria;
        private System.Windows.Forms.TextBox textBoxAddKryteria;
        private System.Windows.Forms.ListBox listBoxKryteria;
        private System.Windows.Forms.ListBox listBoxAlternatywy;
        private System.Windows.Forms.TextBox textBoxAddAlternatywy;
        private System.Windows.Forms.Button buttonDodajAlternatywy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewKA;
        private System.Windows.Forms.Button buttonCreateGrid;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonUsunKryteria;
        private System.Windows.Forms.Button buttonUsunAlternatywy;
        private System.Windows.Forms.Button buttonPrzykladoweDane;
        private System.Windows.Forms.DataGridView dataGridViewParzystePorownania;
        private System.Windows.Forms.Button buttonPrzeliczenie;
        private System.Windows.Forms.DataGridView dataGridViewWagiKryterium;
        private System.Windows.Forms.ComboBox comboBoxKryteria;
        private System.Windows.Forms.Button buttonWagiKryterium;
    }
}


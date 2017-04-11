﻿namespace Saaty
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
            this.textBoxNameCriteria = new System.Windows.Forms.TextBox();
            this.comboBoxValueCriteria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPrecisionCriteria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxNameCriteria
            // 
            this.textBoxNameCriteria.Location = new System.Drawing.Point(84, 12);
            this.textBoxNameCriteria.Name = "textBoxNameCriteria";
            this.textBoxNameCriteria.Size = new System.Drawing.Size(188, 20);
            this.textBoxNameCriteria.TabIndex = 0;
            // 
            // comboBoxValueCriteria
            // 
            this.comboBoxValueCriteria.DisplayMember = "1";
            this.comboBoxValueCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxValueCriteria.FormattingEnabled = true;
            this.comboBoxValueCriteria.Items.AddRange(new object[] {
            "Im większa tym lepiej",
            "Im mniejsza tym lepiej"});
            this.comboBoxValueCriteria.Location = new System.Drawing.Point(84, 38);
            this.comboBoxValueCriteria.Name = "comboBoxValueCriteria";
            this.comboBoxValueCriteria.Size = new System.Drawing.Size(188, 21);
            this.comboBoxValueCriteria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Wartość";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(148, 93);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(124, 23);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Zapisz";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 93);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(124, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dokładność";
            // 
            // comboBoxPrecisionCriteria
            // 
            this.comboBoxPrecisionCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrecisionCriteria.FormattingEnabled = true;
            this.comboBoxPrecisionCriteria.Items.AddRange(new object[] {
            "10000",
            "1000",
            "100",
            "10",
            "1",
            "0,1",
            "0,01",
            "0,001",
            "0,0001"});
            this.comboBoxPrecisionCriteria.Location = new System.Drawing.Point(84, 66);
            this.comboBoxPrecisionCriteria.Name = "comboBoxPrecisionCriteria";
            this.comboBoxPrecisionCriteria.Size = new System.Drawing.Size(188, 21);
            this.comboBoxPrecisionCriteria.TabIndex = 2;
            // 
            // FormCriteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxPrecisionCriteria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxValueCriteria);
            this.Controls.Add(this.textBoxNameCriteria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCriteria";
            this.Text = "Dodaj kryterium";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameCriteria;
        private System.Windows.Forms.ComboBox comboBoxValueCriteria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPrecisionCriteria;
    }
}
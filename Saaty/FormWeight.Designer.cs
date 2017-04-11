namespace Saaty
{
    partial class FormWeight
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
            this.buttonSaveWeight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaveWeight
            // 
            this.buttonSaveWeight.Location = new System.Drawing.Point(13, 13);
            this.buttonSaveWeight.Name = "buttonSaveWeight";
            this.buttonSaveWeight.Size = new System.Drawing.Size(573, 23);
            this.buttonSaveWeight.TabIndex = 0;
            this.buttonSaveWeight.Text = "Zapisz";
            this.buttonSaveWeight.UseVisualStyleBackColor = true;
            this.buttonSaveWeight.Click += new System.EventHandler(this.buttonSaveWeight_Click);
            // 
            // FormWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(598, 300);
            this.Controls.Add(this.buttonSaveWeight);
            this.Name = "FormWeight";
            this.Text = "Ustal wagi kryteriów";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveWeight;
    }
}
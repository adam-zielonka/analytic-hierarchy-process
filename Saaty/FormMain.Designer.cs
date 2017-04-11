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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenProject = new System.Windows.Forms.Button();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.richTextBoxStart = new System.Windows.Forms.RichTextBox();
            this.tabPageStep1 = new System.Windows.Forms.TabPage();
            this.tabPageStep2 = new System.Windows.Forms.TabPage();
            this.tabPageStep3 = new System.Windows.Forms.TabPage();
            this.tabPageStep4 = new System.Windows.Forms.TabPage();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBoxFileName = new System.Windows.Forms.RichTextBox();
            this.buttonResults = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageResults.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStart);
            this.tabControlMain.Controls.Add(this.tabPageStep1);
            this.tabControlMain.Controls.Add(this.tabPageStep2);
            this.tabControlMain.Controls.Add(this.tabPageStep3);
            this.tabControlMain.Controls.Add(this.tabPageStep4);
            this.tabControlMain.Controls.Add(this.tabPageResults);
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(494, 342);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.richTextBoxFileName);
            this.tabPageStart.Controls.Add(this.pictureBox1);
            this.tabPageStart.Controls.Add(this.buttonOpenProject);
            this.tabPageStart.Controls.Add(this.buttonNewProject);
            this.tabPageStart.Controls.Add(this.richTextBoxStart);
            this.tabPageStart.Location = new System.Drawing.Point(4, 22);
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStart.Size = new System.Drawing.Size(486, 316);
            this.tabPageStart.TabIndex = 0;
            this.tabPageStart.Text = "Start";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Saaty.Properties.Resources.p1;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenProject
            // 
            this.buttonOpenProject.Location = new System.Drawing.Point(336, 145);
            this.buttonOpenProject.Name = "buttonOpenProject";
            this.buttonOpenProject.Size = new System.Drawing.Size(144, 23);
            this.buttonOpenProject.TabIndex = 5;
            this.buttonOpenProject.Text = "Otwórz istniejący projekt";
            this.buttonOpenProject.UseVisualStyleBackColor = true;
            this.buttonOpenProject.Click += new System.EventHandler(this.buttonOpenProject_Click);
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.Location = new System.Drawing.Point(175, 145);
            this.buttonNewProject.Name = "buttonNewProject";
            this.buttonNewProject.Size = new System.Drawing.Size(144, 23);
            this.buttonNewProject.TabIndex = 4;
            this.buttonNewProject.Text = "Utwórz nowy projekt";
            this.buttonNewProject.UseVisualStyleBackColor = true;
            this.buttonNewProject.Click += new System.EventHandler(this.buttonNewProject_Click);
            // 
            // richTextBoxStart
            // 
            this.richTextBoxStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxStart.Location = new System.Drawing.Point(175, 6);
            this.richTextBoxStart.Name = "richTextBoxStart";
            this.richTextBoxStart.ReadOnly = true;
            this.richTextBoxStart.ShortcutsEnabled = false;
            this.richTextBoxStart.Size = new System.Drawing.Size(305, 133);
            this.richTextBoxStart.TabIndex = 0;
            this.richTextBoxStart.TabStop = false;
            this.richTextBoxStart.Text = resources.GetString("richTextBoxStart.Text");
            // 
            // tabPageStep1
            // 
            this.tabPageStep1.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep1.Name = "tabPageStep1";
            this.tabPageStep1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep1.Size = new System.Drawing.Size(486, 316);
            this.tabPageStep1.TabIndex = 2;
            this.tabPageStep1.Text = "Krok 1.";
            this.tabPageStep1.UseVisualStyleBackColor = true;
            // 
            // tabPageStep2
            // 
            this.tabPageStep2.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep2.Name = "tabPageStep2";
            this.tabPageStep2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep2.Size = new System.Drawing.Size(486, 316);
            this.tabPageStep2.TabIndex = 1;
            this.tabPageStep2.Text = "Krok 2.";
            this.tabPageStep2.UseVisualStyleBackColor = true;
            // 
            // tabPageStep3
            // 
            this.tabPageStep3.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep3.Name = "tabPageStep3";
            this.tabPageStep3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep3.Size = new System.Drawing.Size(486, 316);
            this.tabPageStep3.TabIndex = 3;
            this.tabPageStep3.Text = "Krok 3.";
            this.tabPageStep3.UseVisualStyleBackColor = true;
            // 
            // tabPageStep4
            // 
            this.tabPageStep4.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep4.Name = "tabPageStep4";
            this.tabPageStep4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep4.Size = new System.Drawing.Size(486, 316);
            this.tabPageStep4.TabIndex = 4;
            this.tabPageStep4.Text = "Krok 4.";
            this.tabPageStep4.UseVisualStyleBackColor = true;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.buttonResults);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(486, 316);
            this.tabPageResults.TabIndex = 5;
            this.tabPageResults.Text = "Wyniki";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(346, 375);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Wstecz";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(427, 375);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Dalej";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(518, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
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
            this.newToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.newToolStripMenuItem.Text = "Nowy";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.openToolStripMenuItem.Text = "Otwórz";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveToolStripMenuItem.Text = "Zapisz";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // richTextBoxFileName
            // 
            this.richTextBoxFileName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBoxFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxFileName.Location = new System.Drawing.Point(176, 175);
            this.richTextBoxFileName.Name = "richTextBoxFileName";
            this.richTextBoxFileName.ReadOnly = true;
            this.richTextBoxFileName.Size = new System.Drawing.Size(304, 135);
            this.richTextBoxFileName.TabIndex = 7;
            this.richTextBoxFileName.Text = "";
            // 
            // buttonResults
            // 
            this.buttonResults.Location = new System.Drawing.Point(7, 7);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(75, 23);
            this.buttonResults.TabIndex = 0;
            this.buttonResults.Text = "Wyniki";
            this.buttonResults.UseVisualStyleBackColor = true;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 409);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Metoda analizy hierarchii Saaty’ego";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageResults.ResumeLayout(false);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TabPage tabPageStep2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageStep1;
        private System.Windows.Forms.TabPage tabPageStep3;
        private System.Windows.Forms.TabPage tabPageStep4;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.RichTextBox richTextBoxStart;
        private System.Windows.Forms.Button buttonOpenProject;
        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBoxFileName;
        private System.Windows.Forms.Button buttonResults;
    }
}


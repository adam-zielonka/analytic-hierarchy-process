﻿namespace Saaty
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
            this.buttonCriteria = new System.Windows.Forms.Button();
            this.buttonAlternative = new System.Windows.Forms.Button();
            this.buttonWeightCriteria = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMatrixWeight = new System.Windows.Forms.Button();
            this.buttonWeightAlternative = new System.Windows.Forms.Button();
            this.buttonMatrixWeightAlternative = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.tabPageCriteria = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelAdd = new System.Windows.Forms.Label();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.tabPageAlternative = new System.Windows.Forms.TabPage();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageStart.SuspendLayout();
            this.tabPageCriteria.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCriteria
            // 
            resources.ApplyResources(this.buttonCriteria, "buttonCriteria");
            this.buttonCriteria.Name = "buttonCriteria";
            this.buttonCriteria.UseVisualStyleBackColor = true;
            this.buttonCriteria.Click += new System.EventHandler(this.buttonCriteria_Click);
            // 
            // buttonAlternative
            // 
            resources.ApplyResources(this.buttonAlternative, "buttonAlternative");
            this.buttonAlternative.Name = "buttonAlternative";
            this.buttonAlternative.UseVisualStyleBackColor = true;
            this.buttonAlternative.Click += new System.EventHandler(this.buttonAlternative_Click);
            // 
            // buttonWeightCriteria
            // 
            resources.ApplyResources(this.buttonWeightCriteria, "buttonWeightCriteria");
            this.buttonWeightCriteria.Name = "buttonWeightCriteria";
            this.buttonWeightCriteria.UseVisualStyleBackColor = true;
            this.buttonWeightCriteria.Click += new System.EventHandler(this.buttonWeightCriteria_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.languageToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            resources.ApplyResources(this.polishToolStripMenuItem, "polishToolStripMenuItem");
            this.polishToolStripMenuItem.Click += new System.EventHandler(this.polishToolStripMenuItem_Click);
            // 
            // buttonMatrixWeight
            // 
            resources.ApplyResources(this.buttonMatrixWeight, "buttonMatrixWeight");
            this.buttonMatrixWeight.Name = "buttonMatrixWeight";
            this.buttonMatrixWeight.UseVisualStyleBackColor = true;
            this.buttonMatrixWeight.Click += new System.EventHandler(this.buttonMatrixWeight_Click);
            // 
            // buttonWeightAlternative
            // 
            resources.ApplyResources(this.buttonWeightAlternative, "buttonWeightAlternative");
            this.buttonWeightAlternative.Name = "buttonWeightAlternative";
            this.buttonWeightAlternative.UseVisualStyleBackColor = true;
            this.buttonWeightAlternative.Click += new System.EventHandler(this.buttonWeightAlternative_Click);
            // 
            // buttonMatrixWeightAlternative
            // 
            resources.ApplyResources(this.buttonMatrixWeightAlternative, "buttonMatrixWeightAlternative");
            this.buttonMatrixWeightAlternative.Name = "buttonMatrixWeightAlternative";
            this.buttonMatrixWeightAlternative.UseVisualStyleBackColor = true;
            this.buttonMatrixWeightAlternative.Click += new System.EventHandler(this.buttonMatrixWeightAlternative_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageStart);
            this.tabControl.Controls.Add(this.tabPageCriteria);
            this.tabControl.Controls.Add(this.tabPageAlternative);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.buttonCriteria);
            this.tabPageStart.Controls.Add(this.buttonMatrixWeightAlternative);
            this.tabPageStart.Controls.Add(this.buttonAlternative);
            this.tabPageStart.Controls.Add(this.buttonMatrixWeight);
            this.tabPageStart.Controls.Add(this.buttonWeightAlternative);
            this.tabPageStart.Controls.Add(this.buttonWeightCriteria);
            resources.ApplyResources(this.tabPageStart, "tabPageStart");
            this.tabPageStart.Name = "tabPageStart";
            this.tabPageStart.UseVisualStyleBackColor = true;
            // 
            // tabPageCriteria
            // 
            resources.ApplyResources(this.tabPageCriteria, "tabPageCriteria");
            this.tabPageCriteria.Controls.Add(this.buttonAdd);
            this.tabPageCriteria.Controls.Add(this.labelAdd);
            this.tabPageCriteria.Controls.Add(this.textBoxAdd);
            this.tabPageCriteria.Name = "tabPageCriteria";
            this.tabPageCriteria.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelAdd
            // 
            resources.ApplyResources(this.labelAdd, "labelAdd");
            this.labelAdd.Name = "labelAdd";
            // 
            // textBoxAdd
            // 
            resources.ApplyResources(this.textBoxAdd, "textBoxAdd");
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Enter += new System.EventHandler(this.textBoxAdd_Enter);
            // 
            // tabPageAlternative
            // 
            resources.ApplyResources(this.tabPageAlternative, "tabPageAlternative");
            this.tabPageAlternative.Name = "tabPageAlternative";
            this.tabPageAlternative.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            resources.ApplyResources(this.buttonBack, "buttonBack");
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.AutoEllipsis = true;
            resources.ApplyResources(this.buttonNext, "buttonNext");
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageStart.ResumeLayout(false);
            this.tabPageCriteria.ResumeLayout(false);
            this.tabPageCriteria.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.TabPage tabPageCriteria;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TabPage tabPageAlternative;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.TextBox textBoxAdd;
    }
}
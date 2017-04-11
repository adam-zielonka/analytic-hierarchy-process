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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.labelResults = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.tabPageStep3 = new System.Windows.Forms.TabPage();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonMatrixAlternative = new System.Windows.Forms.Button();
            this.buttonEditAlternative = new System.Windows.Forms.Button();
            this.buttonAddAlternative = new System.Windows.Forms.Button();
            this.dataGridViewAlternative = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageStep2 = new System.Windows.Forms.TabPage();
            this.buttonMatrix = new System.Windows.Forms.Button();
            this.buttonDownCriteria = new System.Windows.Forms.Button();
            this.buttonUpCriteria = new System.Windows.Forms.Button();
            this.dataGridViewCriteriaWeight = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPageStep1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEditCriteria = new System.Windows.Forms.Button();
            this.buttonAddCriteria = new System.Windows.Forms.Button();
            this.dataGridViewCriteria = new System.Windows.Forms.DataGridView();
            this.tabPageStart = new System.Windows.Forms.TabPage();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonOpenProject = new System.Windows.Forms.Button();
            this.buttonNewProject = new System.Windows.Forms.Button();
            this.richTextBoxStart = new System.Windows.Forms.RichTextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.buttonDataAlternative = new System.Windows.Forms.Button();
            this.menuStripMain.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.tabPageStep3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlternative)).BeginInit();
            this.tabPageStep2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriteriaWeight)).BeginInit();
            this.tabPageStep1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriteria)).BeginInit();
            this.tabPageStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonBack.Location = new System.Drawing.Point(346, 375);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Wstecz";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.labelResults);
            this.tabPageResults.Controls.Add(this.dataGridViewResults);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(486, 316);
            this.tabPageResults.TabIndex = 5;
            this.tabPageResults.Text = "Wyniki";
            this.tabPageResults.UseVisualStyleBackColor = true;
            this.tabPageResults.Enter += new System.EventHandler(this.tabPageResults_Enter);
            // 
            // labelResults
            // 
            this.labelResults.Location = new System.Drawing.Point(7, 3);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(473, 35);
            this.labelResults.TabIndex = 2;
            this.labelResults.Text = "Teraz podziwiaj wyniki. Ta alternatywa z największą liczbą jest najlepszym wybore" +
    "m według tego programu. Pamiętaj: Program to tylko program!\r\n";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(7, 41);
            this.dataGridViewResults.MultiSelect = false;
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.RowHeadersVisible = false;
            this.dataGridViewResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResults.Size = new System.Drawing.Size(473, 269);
            this.dataGridViewResults.TabIndex = 1;
            // 
            // tabPageStep3
            // 
            this.tabPageStep3.Controls.Add(this.buttonDataAlternative);
            this.tabPageStep3.Controls.Add(this.buttonDel);
            this.tabPageStep3.Controls.Add(this.buttonMatrixAlternative);
            this.tabPageStep3.Controls.Add(this.buttonEditAlternative);
            this.tabPageStep3.Controls.Add(this.buttonAddAlternative);
            this.tabPageStep3.Controls.Add(this.dataGridViewAlternative);
            this.tabPageStep3.Controls.Add(this.label3);
            this.tabPageStep3.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep3.Name = "tabPageStep3";
            this.tabPageStep3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep3.Size = new System.Drawing.Size(486, 316);
            this.tabPageStep3.TabIndex = 3;
            this.tabPageStep3.Text = "Krok 3.";
            this.tabPageStep3.UseVisualStyleBackColor = true;
            this.tabPageStep3.Enter += new System.EventHandler(this.tabPageStep3_Enter);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(169, 21);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 6;
            this.buttonDel.Text = "Usuń";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonMatrixAlternative
            // 
            this.buttonMatrixAlternative.Location = new System.Drawing.Point(250, 21);
            this.buttonMatrixAlternative.Name = "buttonMatrixAlternative";
            this.buttonMatrixAlternative.Size = new System.Drawing.Size(75, 23);
            this.buttonMatrixAlternative.TabIndex = 5;
            this.buttonMatrixAlternative.Text = "Matrix";
            this.buttonMatrixAlternative.UseVisualStyleBackColor = true;
            this.buttonMatrixAlternative.Click += new System.EventHandler(this.buttonMatrixAlternative_Click);
            // 
            // buttonEditAlternative
            // 
            this.buttonEditAlternative.Location = new System.Drawing.Point(87, 21);
            this.buttonEditAlternative.Name = "buttonEditAlternative";
            this.buttonEditAlternative.Size = new System.Drawing.Size(75, 23);
            this.buttonEditAlternative.TabIndex = 4;
            this.buttonEditAlternative.Text = "Edytuj";
            this.buttonEditAlternative.UseVisualStyleBackColor = true;
            this.buttonEditAlternative.Click += new System.EventHandler(this.buttonEditAlternative_Click);
            // 
            // buttonAddAlternative
            // 
            this.buttonAddAlternative.Location = new System.Drawing.Point(6, 21);
            this.buttonAddAlternative.Name = "buttonAddAlternative";
            this.buttonAddAlternative.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAlternative.TabIndex = 3;
            this.buttonAddAlternative.Text = "Dodaj";
            this.buttonAddAlternative.UseVisualStyleBackColor = true;
            this.buttonAddAlternative.Click += new System.EventHandler(this.buttonAddAlternative_Click);
            // 
            // dataGridViewAlternative
            // 
            this.dataGridViewAlternative.AllowUserToAddRows = false;
            this.dataGridViewAlternative.AllowUserToDeleteRows = false;
            this.dataGridViewAlternative.AllowUserToResizeColumns = false;
            this.dataGridViewAlternative.AllowUserToResizeRows = false;
            this.dataGridViewAlternative.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlternative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlternative.Location = new System.Drawing.Point(6, 50);
            this.dataGridViewAlternative.MultiSelect = false;
            this.dataGridViewAlternative.Name = "dataGridViewAlternative";
            this.dataGridViewAlternative.ReadOnly = true;
            this.dataGridViewAlternative.RowHeadersVisible = false;
            this.dataGridViewAlternative.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAlternative.Size = new System.Drawing.Size(474, 260);
            this.dataGridViewAlternative.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(474, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Teraz musisz dodać alternatywy, które program porówna.";
            // 
            // tabPageStep2
            // 
            this.tabPageStep2.Controls.Add(this.buttonMatrix);
            this.tabPageStep2.Controls.Add(this.buttonDownCriteria);
            this.tabPageStep2.Controls.Add(this.buttonUpCriteria);
            this.tabPageStep2.Controls.Add(this.dataGridViewCriteriaWeight);
            this.tabPageStep2.Controls.Add(this.label2);
            this.tabPageStep2.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep2.Name = "tabPageStep2";
            this.tabPageStep2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep2.Size = new System.Drawing.Size(486, 316);
            this.tabPageStep2.TabIndex = 1;
            this.tabPageStep2.Text = "Krok 2.";
            this.tabPageStep2.UseVisualStyleBackColor = true;
            this.tabPageStep2.Enter += new System.EventHandler(this.tabPageStep2_Enter);
            // 
            // buttonMatrix
            // 
            this.buttonMatrix.Location = new System.Drawing.Point(168, 41);
            this.buttonMatrix.Name = "buttonMatrix";
            this.buttonMatrix.Size = new System.Drawing.Size(75, 23);
            this.buttonMatrix.TabIndex = 4;
            this.buttonMatrix.Text = "Matrix";
            this.buttonMatrix.UseVisualStyleBackColor = true;
            this.buttonMatrix.Click += new System.EventHandler(this.buttonMatrix_Click);
            // 
            // buttonDownCriteria
            // 
            this.buttonDownCriteria.Location = new System.Drawing.Point(87, 41);
            this.buttonDownCriteria.Name = "buttonDownCriteria";
            this.buttonDownCriteria.Size = new System.Drawing.Size(75, 23);
            this.buttonDownCriteria.TabIndex = 3;
            this.buttonDownCriteria.Text = "W doł";
            this.buttonDownCriteria.UseVisualStyleBackColor = true;
            this.buttonDownCriteria.Click += new System.EventHandler(this.buttonDownCriteria_Click);
            // 
            // buttonUpCriteria
            // 
            this.buttonUpCriteria.Location = new System.Drawing.Point(6, 41);
            this.buttonUpCriteria.Name = "buttonUpCriteria";
            this.buttonUpCriteria.Size = new System.Drawing.Size(75, 23);
            this.buttonUpCriteria.TabIndex = 2;
            this.buttonUpCriteria.Text = "W górę";
            this.buttonUpCriteria.UseVisualStyleBackColor = true;
            this.buttonUpCriteria.Click += new System.EventHandler(this.buttonUpCriteria_Click);
            // 
            // dataGridViewCriteriaWeight
            // 
            this.dataGridViewCriteriaWeight.AllowUserToAddRows = false;
            this.dataGridViewCriteriaWeight.AllowUserToDeleteRows = false;
            this.dataGridViewCriteriaWeight.AllowUserToResizeColumns = false;
            this.dataGridViewCriteriaWeight.AllowUserToResizeRows = false;
            this.dataGridViewCriteriaWeight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCriteriaWeight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCriteriaWeight.Location = new System.Drawing.Point(6, 70);
            this.dataGridViewCriteriaWeight.MultiSelect = false;
            this.dataGridViewCriteriaWeight.Name = "dataGridViewCriteriaWeight";
            this.dataGridViewCriteriaWeight.ReadOnly = true;
            this.dataGridViewCriteriaWeight.RowHeadersVisible = false;
            this.dataGridViewCriteriaWeight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCriteriaWeight.Size = new System.Drawing.Size(474, 240);
            this.dataGridViewCriteriaWeight.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teraz musisz ustalić, które kryteria są dla ciebie ważniejsze. Im wyższa waga tym" +
    " kryterium jest ważniejsze, im mniejsza tym mniej ważne. Zakres od 1 (najmniej w" +
    "ażne) do 9 (najważniejsze).\r\n\r\n\r\n\r\n";
            // 
            // tabPageStep1
            // 
            this.tabPageStep1.Controls.Add(this.label1);
            this.tabPageStep1.Controls.Add(this.buttonDelete);
            this.tabPageStep1.Controls.Add(this.buttonEditCriteria);
            this.tabPageStep1.Controls.Add(this.buttonAddCriteria);
            this.tabPageStep1.Controls.Add(this.dataGridViewCriteria);
            this.tabPageStep1.Location = new System.Drawing.Point(4, 22);
            this.tabPageStep1.Name = "tabPageStep1";
            this.tabPageStep1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStep1.Size = new System.Drawing.Size(486, 316);
            this.tabPageStep1.TabIndex = 2;
            this.tabPageStep1.Text = "Krok 1.";
            this.tabPageStep1.UseVisualStyleBackColor = true;
            this.tabPageStep1.Enter += new System.EventHandler(this.tabPageStep1_Enter);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teraz musisz dodać kryteria, dla których będziesz porównywać swoje alternatywy.";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(168, 26);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEditCriteria
            // 
            this.buttonEditCriteria.Location = new System.Drawing.Point(87, 26);
            this.buttonEditCriteria.Name = "buttonEditCriteria";
            this.buttonEditCriteria.Size = new System.Drawing.Size(75, 23);
            this.buttonEditCriteria.TabIndex = 2;
            this.buttonEditCriteria.Text = "Edytuj";
            this.buttonEditCriteria.UseVisualStyleBackColor = true;
            this.buttonEditCriteria.Click += new System.EventHandler(this.buttonEditCriteria_Click);
            // 
            // buttonAddCriteria
            // 
            this.buttonAddCriteria.Location = new System.Drawing.Point(6, 26);
            this.buttonAddCriteria.Name = "buttonAddCriteria";
            this.buttonAddCriteria.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCriteria.TabIndex = 1;
            this.buttonAddCriteria.Text = "Dodaj";
            this.buttonAddCriteria.UseVisualStyleBackColor = true;
            this.buttonAddCriteria.Click += new System.EventHandler(this.buttonAddCriteria_Click);
            // 
            // dataGridViewCriteria
            // 
            this.dataGridViewCriteria.AllowUserToAddRows = false;
            this.dataGridViewCriteria.AllowUserToDeleteRows = false;
            this.dataGridViewCriteria.AllowUserToResizeColumns = false;
            this.dataGridViewCriteria.AllowUserToResizeRows = false;
            this.dataGridViewCriteria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCriteria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCriteria.EnableHeadersVisualStyles = false;
            this.dataGridViewCriteria.Location = new System.Drawing.Point(6, 55);
            this.dataGridViewCriteria.MultiSelect = false;
            this.dataGridViewCriteria.Name = "dataGridViewCriteria";
            this.dataGridViewCriteria.ReadOnly = true;
            this.dataGridViewCriteria.RowHeadersVisible = false;
            this.dataGridViewCriteria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCriteria.Size = new System.Drawing.Size(471, 255);
            this.dataGridViewCriteria.TabIndex = 0;
            // 
            // tabPageStart
            // 
            this.tabPageStart.Controls.Add(this.labelFileName);
            this.tabPageStart.Controls.Add(this.labelStart);
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
            // labelFileName
            // 
            this.labelFileName.Location = new System.Drawing.Point(175, 148);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(305, 162);
            this.labelFileName.TabIndex = 9;
            // 
            // labelStart
            // 
            this.labelStart.Location = new System.Drawing.Point(175, 6);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(305, 113);
            this.labelStart.TabIndex = 8;
            this.labelStart.Text = resources.GetString("labelStart.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Saaty.Properties.Resources.p1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(7, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // buttonOpenProject
            // 
            this.buttonOpenProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonOpenProject.Location = new System.Drawing.Point(336, 122);
            this.buttonOpenProject.Name = "buttonOpenProject";
            this.buttonOpenProject.Size = new System.Drawing.Size(144, 23);
            this.buttonOpenProject.TabIndex = 5;
            this.buttonOpenProject.Text = "Otwórz istniejący projekt";
            this.buttonOpenProject.UseVisualStyleBackColor = true;
            this.buttonOpenProject.Click += new System.EventHandler(this.buttonOpenProject_Click);
            // 
            // buttonNewProject
            // 
            this.buttonNewProject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonNewProject.Location = new System.Drawing.Point(175, 122);
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
            this.richTextBoxStart.Text = "";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageStart);
            this.tabControlMain.Controls.Add(this.tabPageStep1);
            this.tabControlMain.Controls.Add(this.tabPageStep2);
            this.tabControlMain.Controls.Add(this.tabPageStep3);
            this.tabControlMain.Controls.Add(this.tabPageResults);
            this.tabControlMain.Location = new System.Drawing.Point(12, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(494, 342);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.TabStop = false;
            // 
            // buttonDataAlternative
            // 
            this.buttonDataAlternative.Location = new System.Drawing.Point(331, 21);
            this.buttonDataAlternative.Name = "buttonDataAlternative";
            this.buttonDataAlternative.Size = new System.Drawing.Size(146, 23);
            this.buttonDataAlternative.TabIndex = 7;
            this.buttonDataAlternative.Text = "Tabela z danymi";
            this.buttonDataAlternative.UseVisualStyleBackColor = true;
            this.buttonDataAlternative.Click += new System.EventHandler(this.buttonDataAlternative_Click);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripMain;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Metoda analizy hierarchii Saaty’ego";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPageResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.tabPageStep3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlternative)).EndInit();
            this.tabPageStep2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriteriaWeight)).EndInit();
            this.tabPageStep1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCriteria)).EndInit();
            this.tabPageStart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.TabPage tabPageStep3;
        private System.Windows.Forms.Button buttonMatrixAlternative;
        private System.Windows.Forms.Button buttonEditAlternative;
        private System.Windows.Forms.Button buttonAddAlternative;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPageStep2;
        private System.Windows.Forms.Button buttonMatrix;
        private System.Windows.Forms.Button buttonDownCriteria;
        private System.Windows.Forms.Button buttonUpCriteria;
        public System.Windows.Forms.DataGridView dataGridViewCriteriaWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageStep1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEditCriteria;
        private System.Windows.Forms.Button buttonAddCriteria;
        public System.Windows.Forms.DataGridView dataGridViewCriteria;
        private System.Windows.Forms.TabPage tabPageStart;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonOpenProject;
        private System.Windows.Forms.Button buttonNewProject;
        private System.Windows.Forms.RichTextBox richTextBoxStart;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.Label labelResults;
        private System.Windows.Forms.Button buttonDel;
        public System.Windows.Forms.DataGridView dataGridViewAlternative;
        private System.Windows.Forms.Button buttonDataAlternative;
    }
}


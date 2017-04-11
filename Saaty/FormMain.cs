﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saaty
{
    public partial class FormMain : Form
    {
        public List<String> ListCriteria { get; set; }
        public List<String> ListAlternative { get; set; }
        public float [][] Matrix;

        public FormMain()
        {
            InitializeComponent();
            ListCriteria = new List<string>();
            ListAlternative = new List<string>();
        }

        private void buttonCriteria_Click(object sender, EventArgs e)
        {
            buttonCriteria.Enabled = false;
            FormCriteria formCriteria = new FormCriteria(ListCriteria,buttonCriteria);
            formCriteria.Show();
        }

        private void buttonAlternative_Click(object sender, EventArgs e)
        {
            buttonAlternative.Enabled = false;
            FormCriteria formCriteria = new FormCriteria(ListAlternative,buttonAlternative,"Alternatywy");
            formCriteria.Text = "Zarządaj Alternatywami";
            formCriteria.Show();
        }

        private void buttonWeightCriteria_Click(object sender, EventArgs e)
        {
            buttonCriteria.Enabled = false;
            FormWeight formWeight = new FormWeight(ListCriteria,Matrix);
            formWeight.Show();

        }
    }
}

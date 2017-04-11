using System;
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

        public FormMain()
        {
            InitializeComponent();
            ListCriteria = new List<string>();
            ListAlternative = new List<string>();
        }

        private void buttonCriteria_Click(object sender, EventArgs e)
        {
            FormCriteria formCriteria = new FormCriteria(ListCriteria);
            formCriteria.Show();
        }

        private void buttonAlternative_Click(object sender, EventArgs e)
        {
            FormCriteria formCriteria = new FormCriteria(ListAlternative,"Alternatywy");
            formCriteria.Text = "Zarządaj Alternatywami";
            formCriteria.Show();
        }
    }
}

using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Saaty
{
    public partial class FormAlternative : Form
    {
        private FormMain _formMain;
        private SattyClass _satty;

        public FormAlternative(SattyClass satty, FormMain formMain)
        {
            InitializeComponent();
            _satty = satty;
            _formMain = formMain;

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add("criteria", "Kryteria");
            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns.Add("alternative", "Alternatywa");

            for (int j = 0; j < _satty.Criteria.Count; j++)
            {
                dataGridView.Rows.Add(_satty.Criteria.Name[j]);
            }

        }

    }
}

using System.Windows.Forms;

namespace lab_9_db
{
    public partial class StipForm : Form, IUpdatableDGV
    {
        public StipForm()
        {
            InitializeComponent();
        }

        public void UpdateDataGridView()
        {
            StipDGV.DataSource = null;
            StipDGV.Rows.Clear();
            StipDGV.Refresh();
            sTIPTableAdapter.Fill(dataSetLab9.STIP);
            StipDGV.DataSource = sTIPBindingSource;
        }

        private void StipForm_Load(object sender, System.EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetLab9.STIP". При необходимости она может быть перемещена или удалена.
            this.sTIPTableAdapter.Fill(this.dataSetLab9.STIP);

        }
    }
}

using System;
using System.Windows.Forms;

namespace lab_9_db
{
    public partial class SessInfForm : Form, IUpdatableDGV
    {
        public SessInfForm()
        {
            InitializeComponent();
        }

        public void UpdateDataGridView()
        {
            SessInfDGV.DataSource = null;
            SessInfDGV.Rows.Clear();
            SessInfDGV.Refresh();
            sESS_INFTableAdapter.Fill(dataSetLab9.SESS_INF);
            SessInfDGV.DataSource = sESSINFBindingSource;
        }

        private void SessInfForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetLab9.SESS_INF". При необходимости она может быть перемещена или удалена.
            this.sESS_INFTableAdapter.Fill(this.dataSetLab9.SESS_INF);
        }
    }
}

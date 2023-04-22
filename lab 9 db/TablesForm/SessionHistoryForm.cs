using System;
using System.Windows.Forms;

namespace lab_9_db
{
    public partial class SessionHistoryForm : Form, IUpdatableDGV
    {
        public SessionHistoryForm()
        {
            InitializeComponent();
        }

        private void SessionHistoryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetLab9.SESSION_HISTORY". При необходимости она может быть перемещена или удалена.
            this.sESSION_HISTORYTableAdapter.Fill(this.dataSetLab9.SESSION_HISTORY);
        }

        public void UpdateDataGridView()
        {
            SessHistDGV.DataSource = null;
            SessHistDGV.Rows.Clear();
            SessHistDGV.Refresh();
            sESSION_HISTORYTableAdapter.Fill(dataSetLab9.SESSION_HISTORY);
            SessHistDGV.DataSource = sESSIONHISTORYBindingSource;
        }
    }
}

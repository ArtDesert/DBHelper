using System;
using System.Windows.Forms;

namespace lab_9_db
{
    public partial class StudentsForm : Form, IUpdatableDGV
    {
        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSetLab9.STUDENTS". При необходимости она может быть перемещена или удалена.
            this.sTUDENTSTableAdapter.Fill(this.dataSetLab9.STUDENTS);
        }
        public void UpdateDataGridView()
        {
            StudDGV.DataSource = null;
            StudDGV.Rows.Clear();
            StudDGV.Refresh();
            sTUDENTSTableAdapter.Fill(dataSetLab9.STUDENTS);
            StudDGV.DataSource = sTUDENTSBindingSource;
        }
    }
}

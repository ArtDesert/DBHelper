using System;
using System.Windows.Forms;
using lab_9_db.DataSetLab9TableAdapters;

namespace lab_9_db.AddRowForm
{
    public partial class ADD_ROW_STIP_FORM : Form
    {
        STIPTableAdapter sTIPTableAdapter;
        public ADD_ROW_STIP_FORM(STIPTableAdapter sTIPTableAdapter)
        {
            InitializeComponent();
            this.sTIPTableAdapter = sTIPTableAdapter;   
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var num = decimal.Parse(tbNum.Text);
            var salary = decimal.Parse(tbSal.Text);
            sTIPTableAdapter.Insert(num,salary);
            Close();
        }
    }
}

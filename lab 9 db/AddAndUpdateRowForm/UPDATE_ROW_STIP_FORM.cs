using lab_9_db.DataSetLab9TableAdapters;
using System;
using System.Windows.Forms;

namespace lab_9_db.AddRowForm
{
    public partial class UPDATE_ROW_STIP_FORM : Form, IUpdatableQuery
    {
        STIPTableAdapter sTIPTableAdapter;
        DataGridViewRow curRow;
        public UPDATE_ROW_STIP_FORM(STIPTableAdapter sTIPTableAdapter, DataGridViewRow curRow)
        {
            InitializeComponent();
            this.sTIPTableAdapter = sTIPTableAdapter;
            this.curRow = curRow;
            FillFormAndUpdate(curRow);
        }

        public void FillFormAndUpdate(DataGridViewRow curRow)
        {
            decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
            decimal salary = decimal.Parse(curRow.Cells[1].Value.ToString());
            tbNum.Text = num.ToString();
            tbSal.Text = salary.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
            decimal salary = decimal.Parse(curRow.Cells[1].Value.ToString());
            decimal newNum = decimal.Parse(tbNum.Text);
            decimal newSalary = decimal.Parse(tbSal.Text);
            sTIPTableAdapter.UpdateQuery(newNum, newSalary, num, salary);
            Close();
        }
    }
}

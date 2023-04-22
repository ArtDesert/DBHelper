using lab_9_db.DataSetLab9TableAdapters;
using System;
using System.Windows.Forms;

namespace lab_9_db.AddAndUpdateRowForm
{
    public partial class UPDATE_ROW_SESS_INF_FORM : Form, IUpdatableQuery
    {
        SESS_INFTableAdapter sESS_INFTableAdapter;
        DataGridViewRow curRow;
        public UPDATE_ROW_SESS_INF_FORM(SESS_INFTableAdapter sESS_INFTableAdapter, DataGridViewRow curRow)
        {
            InitializeComponent();
            this.sESS_INFTableAdapter = sESS_INFTableAdapter;
            this.curRow = curRow;
            FillFormAndUpdate(curRow);
        }

        public void FillFormAndUpdate(DataGridViewRow curRow)
        {
            decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
            string property = curRow.Cells[1].Value.ToString();
            tbNum.Text = num.ToString();
            tbProp.Text = property;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
            string property = curRow.Cells[1].Value.ToString();
            decimal newNum = decimal.Parse(tbNum.Text);
            string newProperty = tbProp.Text;
            sESS_INFTableAdapter.Update(newNum, newProperty, num, property);
            Close();
        }
    }
}

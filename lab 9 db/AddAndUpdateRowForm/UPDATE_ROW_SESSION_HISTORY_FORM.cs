using lab_9_db.DataSetLab9TableAdapters;
using System;
using System.Windows.Forms;

namespace lab_9_db.AddRowForm
{
    public partial class UPDATE_ROW_SESSION_HISTORY_FORM : Form, IUpdatableQuery
    {
        SESSION_HISTORYTableAdapter sESSION_HISTORYTableAdapter;
        DataGridViewRow curRow;
        public UPDATE_ROW_SESSION_HISTORY_FORM(SESSION_HISTORYTableAdapter sESSION_HISTORYTableAdapter, DataGridViewRow curRow)
        {
            InitializeComponent();
            this.sESSION_HISTORYTableAdapter = sESSION_HISTORYTableAdapter;
            this.curRow = curRow;
            FillFormAndUpdate(curRow);
        }

        public void FillFormAndUpdate(DataGridViewRow curRow)
        {
            decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
            decimal sessnum = decimal.Parse(curRow.Cells[1].Value.ToString());
            decimal sub1 = decimal.Parse(curRow.Cells[2].Value.ToString());
            decimal sub2 = decimal.Parse(curRow.Cells[3].Value.ToString());
            decimal sub3 = decimal.Parse(curRow.Cells[4].Value.ToString());
            tbNum.Text = num.ToString();
            tbSessnum.Text = sessnum.ToString();
            tbSub1.Text = sub1.ToString();
            tbSub2.Text = sub2.ToString();
            tbSub3.Text = sub3.ToString();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
            decimal sessnum = decimal.Parse(curRow.Cells[1].Value.ToString());
            decimal sub1 = decimal.Parse(curRow.Cells[2].Value.ToString());
            decimal sub2 = decimal.Parse(curRow.Cells[3].Value.ToString());
            decimal sub3 = decimal.Parse(curRow.Cells[4].Value.ToString());
            decimal newNum = decimal.Parse(tbNum.Text);
            decimal newSessnum = decimal.Parse(tbSessnum.Text);
            decimal newSub1 = decimal.Parse(tbSub1.Text);
            decimal newSub2 = decimal.Parse(tbSub2.Text);
            decimal newSub3 = decimal.Parse(tbSub3.Text);
            sESSION_HISTORYTableAdapter.UpdateQuery(newNum, newSessnum, newSub1, newSub2, newSub3, num, sessnum, sub1, sub2, sub3);
            Close();
        }
    }
}

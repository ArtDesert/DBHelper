using lab_9_db.DataSetLab9TableAdapters;
using System;
using System.Windows.Forms;

namespace lab_9_db.AddRowForm
{
    public partial class UPDATE_ROW_STUDENTS_FORM : Form, IUpdatableQuery
    {
        STUDENTSTableAdapter sTUDENTSTableAdapter;
        DataGridViewRow curRow;
        public UPDATE_ROW_STUDENTS_FORM(STUDENTSTableAdapter sTUDENTSTableAdapter, DataGridViewRow curRow)
        {
            InitializeComponent();
            this.sTUDENTSTableAdapter = sTUDENTSTableAdapter;
            this.curRow = curRow;
            FillFormAndUpdate(curRow);
        }

        public void FillFormAndUpdate(DataGridViewRow curRow)
        {
            var strings = curRow.Cells[3].Value.ToString().Split(' ');
            var str = string.Empty;
            if (strings.Length != 1)
                str = strings[0];
            decimal? mb = null;
            decimal? money = null;
            if (curRow.Cells[5].Value.ToString() != "")
                mb = decimal.Parse(curRow.Cells[5].Value.ToString());
            if(curRow.Cells[6].Value.ToString() != "")
            money = decimal.Parse(curRow.Cells[6].Value.ToString());
            decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
            decimal year = decimal.Parse(curRow.Cells[2].Value.ToString());
            string fname = curRow.Cells[1].Value.ToString();
            string plata = curRow.Cells[4].Value.ToString();
            string address = curRow.Cells[7].Value.ToString();
            tbNum.Text = num.ToString();
            tbFname.Text = fname.ToString();
            tbYear.Text = year.ToString();
            tbBday.Text = str;
            tbPlata.Text = plata.ToString();
            tbMB.Text = mb.ToString();
            tbMoney.Text = money.ToString();
            tbAddress.Text = address.ToString();

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var strings = curRow.Cells[3].Value.ToString().Split(' ');
            var str = string.Empty;
            var dates = strings[0].Split('.');
            DateTime? dt = null;
            if (strings.Length != 1)
                dt = new DateTime(int.Parse(dates[2]), int.Parse(dates[1]), int.Parse(dates[0]));
            sTUDENTSTableAdapter.Update(
                decimal.Parse(tbNum.Text),
                tbFname.Text,
                decimal.Parse(tbYear.Text),
                DateTime.Parse(tbBday.Text),
                tbPlata.Text,
                decimal.Parse(tbMB.Text),
                decimal.Parse(tbMoney.Text),
                tbAddress.Text,
                ///----
                decimal.Parse(curRow.Cells[0].Value.ToString()),
                curRow.Cells[1].Value.ToString(),
                decimal.Parse(curRow.Cells[2].Value.ToString()),
                DateTime.Parse(curRow.Cells[3].Value.ToString()),
                curRow.Cells[4].Value.ToString(),
                decimal.Parse(curRow.Cells[5].Value.ToString()),
                decimal.Parse(curRow.Cells[6].Value.ToString()),
                curRow.Cells[7].Value.ToString()
                );
            Close();
        }
    }
}

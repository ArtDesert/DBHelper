using lab_9_db.DataSetLab9TableAdapters;
using System;
using System.Windows.Forms;

namespace lab_9_db
{
    public partial class ADD_ROW_STUDENTS_FORM : Form
    {
        STUDENTSTableAdapter sTUDENTSTableAdapter;
        public ADD_ROW_STUDENTS_FORM(STUDENTSTableAdapter sTUDENTSTableAdapter)
        {
            InitializeComponent();
            this.sTUDENTSTableAdapter = sTUDENTSTableAdapter;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime? myBDAY = null;
            string myPLATA = null;
            decimal? myMB = null, myMOMEY = null;
            if (tbBday.Text != string.Empty) myBDAY = DateTime.Parse(tbBday.Text);
            if (tbPlata.Text != string.Empty) myPLATA = tbPlata.Text;
            if (tbMB.Text != string.Empty) myMB = decimal.Parse(tbMB.Text);
            if (tbMoney.Text != string.Empty) myMOMEY = decimal.Parse(tbMoney.Text);
            sTUDENTSTableAdapter.Insert(
                decimal.Parse(tbNum.Text),
                tbFname.Text,
                decimal.Parse(tbYear.Text),
                myBDAY,
                myPLATA,
                myMB,
                myMOMEY,
                tbAddress.Text);
            Close();
        }
    }
}

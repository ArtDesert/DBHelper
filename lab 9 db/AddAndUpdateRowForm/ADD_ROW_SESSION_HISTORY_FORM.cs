using lab_9_db.DataSetLab9TableAdapters;
using System;
using System.Windows.Forms;

namespace lab_9_db.AddRowForm
{
    public partial class ADD_ROW_SESSION_HISTORY_FORM : Form
    {
        SESSION_HISTORYTableAdapter sESSION_HISTORYTableAdapter;
        public ADD_ROW_SESSION_HISTORY_FORM(SESSION_HISTORYTableAdapter sESSION_HISTORYTableAdapter)
        {
            this.sESSION_HISTORYTableAdapter = sESSION_HISTORYTableAdapter;
            InitializeComponent();
        }

        private void ADD_ROW_SESSION_HISTORY_FORM_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            decimal num = decimal.Parse(tbNum.Text);
            decimal sessnum = decimal.Parse(tbSessnum.Text);
            decimal sub1 = decimal.Parse(tbSub1.Text);
            decimal sub2 = decimal.Parse(tbSub2.Text);
            decimal sub3 = decimal.Parse(tbSub3.Text);
            sESSION_HISTORYTableAdapter.Insert(num, sessnum, sub1, sub2, sub3);
            Close();
        }
    }
}

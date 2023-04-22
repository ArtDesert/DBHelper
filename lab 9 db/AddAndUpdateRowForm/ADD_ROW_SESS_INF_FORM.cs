using System;
using System.Windows.Forms;
using lab_9_db.DataSetLab9TableAdapters;

namespace lab_9_db.AddRowForm
{
    public partial class ADD_ROW_SESS_INF_FORM : Form
    {
        SESS_INFTableAdapter sESS_INFTableAdapter;
        public ADD_ROW_SESS_INF_FORM(SESS_INFTableAdapter sESS_INFTableAdapter)
        {
            InitializeComponent();
            this.sESS_INFTableAdapter = sESS_INFTableAdapter;   
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var num = decimal.Parse(tbNum.Text);
            var property = tbProp.Text;
            sESS_INFTableAdapter.Insert(num, property);
        }
    }
}

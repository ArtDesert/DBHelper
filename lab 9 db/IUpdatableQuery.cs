using System.Windows.Forms;

namespace lab_9_db
{
    internal interface IUpdatableQuery
    {
        void FillFormAndUpdate(DataGridViewRow curRow);
    }
}

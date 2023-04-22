using GemBox.Spreadsheet;
using lab_9_db.AddAndUpdateRowForm;
using lab_9_db.AddRowForm;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace lab_9_db
{
    public partial class MainForm : Form
    {
        private Button curButton;
        private Form activeForm;
        readonly Color mainColor = Color.FromArgb(0, 150, 136);
        Tables? curTable;
        Microsoft.Office.Interop.Excel.Application xlApp;
        Microsoft.Office.Interop.Excel.Worksheet xlSheet;
        Microsoft.Office.Interop.Excel.Range xlSheetRange;

        enum Tables
        {
            STUDENTS,
            SESSION_HISTORY,
            SESS_INF,
            STIP
        }

        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }

        private void CustomizeDesign()
        {
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            curButton = null;
            activeForm = null;
            curTable = null;
            logDGV.Visible = false;
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CheckButton(object sender)
        {
            if (curButton == null)
            {
                ActivateButton(sender);
                SelectChildForm(sender);
                DMLPanel.Visible = true;
            }
            else
            {
                if (curButton == sender)
                {
                    DisableButton(sender);
                    DisableChildForm(activeForm);
                    DMLPanel.Visible = false;
                }
                else
                {
                    DisableButton(curButton);
                    DisableChildForm(activeForm);
                    ActivateButton(sender);
                    SelectChildForm(sender);
                }
            }
        }

        private void ActivateButton(object sender)
        {
            curButton = sender as Button;
            curButton.BackColor = mainColor;
            curButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = mainColor;
            lblTitle.Text = curButton.Text;
        }

        private void DisableButton(object sender)
        {
            (sender as Button).BackColor = Color.FromArgb(51, 51, 76);
            (sender as Button).Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            panelTitleBar.BackColor = Color.Teal;
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            lblTitle.Text = "DATABASE EDITOR";
            curButton = null;
        }

        private void SelectChildForm(object sender)
        {
            switch (curButton.TabIndex)
            {
                case (int)Tables.STUDENTS:
                    {
                        OpenChildForm(new StudentsForm(), sender);
                        curTable = Tables.STUDENTS;
                        break;
                    }
                case (int)Tables.SESSION_HISTORY:
                    {
                        OpenChildForm(new SessionHistoryForm(), sender);
                        curTable = Tables.SESSION_HISTORY;
                        break;
                    }
                case (int)Tables.SESS_INF:
                    {
                        OpenChildForm(new SessInfForm(), sender);
                        curTable = Tables.SESS_INF;
                        break;
                    }
                case (int)Tables.STIP:
                    {
                        OpenChildForm(new StipForm(), sender);
                        curTable = Tables.STIP;
                        break;
                    }
            }
        }

        private void OpenChildForm(Form childForm, object sender)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void DisableChildForm(Form childForm)
        {
            childForm.Close();
            activeForm = null;
            curTable = null;
        }

        private void btnMinimaze_Click_1(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        private void btnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) this.WindowState = FormWindowState.Maximized;
            else this.WindowState = this.WindowState = FormWindowState.Normal;
        }

        private void btnCLose_Click(object sender, EventArgs e) => Application.Exit();

        private void btnStud_Click(object sender, EventArgs e) => CheckButton(sender);

        private void btnSessHist_Click(object sender, EventArgs e) => CheckButton(sender);

        private void btnSessInf_Click(object sender, EventArgs e) => CheckButton(sender);

        private void btnStip_Click(object sender, EventArgs e) => CheckButton(sender);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            try
            {
                switch (curTable)
                {
                    case Tables.STUDENTS:
                        {
                            new ADD_ROW_STUDENTS_FORM(sTUDENTSTableAdapter).ShowDialog();
                            (activeForm as StudentsForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.SESSION_HISTORY:
                        {
                            new ADD_ROW_SESSION_HISTORY_FORM(sESSION_HISTORYTableAdapter).ShowDialog();
                            (activeForm as SessionHistoryForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.SESS_INF:
                        {
                            new ADD_ROW_SESS_INF_FORM(sESS_INFTableAdapter).ShowDialog();
                            (activeForm as SessInfForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.STIP:
                        {
                            new ADD_ROW_STIP_FORM(sTIPTableAdapter).ShowDialog();
                            (activeForm as StipForm).UpdateDataGridView();
                            break;
                        }
                }
            }
            catch (ArgumentException) { }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(
                    String.Format("Failed to apply DMl-command\r\n{0}",ex.Message),
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void btnRemoveRow_Click(object sender, EventArgs e)
        {
            try
            {
                switch (curTable)
                {
                    case Tables.STUDENTS:
                        {
                            foreach (DataGridViewRow curRow in (activeForm as StudentsForm).StudDGV.SelectedRows)
                            {
                                var strings = curRow.Cells[3].Value.ToString().Split(' ');
                                var dates = strings[0].Split('.');
                                DateTime? dt = null;
                                decimal? mb = null, money = null;
                                if (strings.Length != 1)
                                    dt = new DateTime(int.Parse(dates[2]), int.Parse(dates[1]), int.Parse(dates[0]), 0, 0, 0);
                                if (curRow.Cells[5].Value.ToString() != "")
                                    mb = decimal.Parse(curRow.Cells[5].Value.ToString());
                                if (curRow.Cells[6].Value.ToString() != "")
                                    money = decimal.Parse(curRow.Cells[6].Value.ToString());
                                decimal num = decimal.Parse(curRow.Cells[0].Value.ToString());
                                decimal year = decimal.Parse(curRow.Cells[2].Value.ToString());
                                string fname = curRow.Cells[1].Value.ToString();
                                string plata = curRow.Cells[4].Value.ToString();
                                string address = curRow.Cells[7].Value.ToString();
                                sTUDENTSTableAdapter.Delete(num, fname, year, dt, plata, mb, money, address);
                            }
                            (activeForm as StudentsForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.SESSION_HISTORY:
                        {
                            var curRow = (activeForm as SessionHistoryForm).SessHistDGV.SelectedRows[0];
                            var num = decimal.Parse(curRow.Cells[0].Value.ToString());
                            var sessnum = decimal.Parse(curRow.Cells[1].Value.ToString());
                            var sub1 = decimal.Parse(curRow.Cells[2].Value.ToString());
                            var sub2 = decimal.Parse(curRow.Cells[3].Value.ToString());
                            var sub3 = decimal.Parse(curRow.Cells[4].Value.ToString());
                            sESSION_HISTORYTableAdapter.DeleteQuery(num, sessnum, sub1, sub2, sub3);
                            (activeForm as SessionHistoryForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.SESS_INF:
                        {
                            var curRow = (activeForm as SessInfForm).SessInfDGV.SelectedRows[0];
                            var num = decimal.Parse(curRow.Cells[0].Value.ToString());
                            var property = curRow.Cells[1].Value.ToString();
                            sESS_INFTableAdapter.Delete(num, property);
                            (activeForm as SessInfForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.STIP:
                        {
                            var curRow = (activeForm as StipForm).StipDGV.SelectedRows[0];
                            var num = decimal.Parse(curRow.Cells[0].Value.ToString());
                            var salary = decimal.Parse(curRow.Cells[1].Value.ToString());
                            sTIPTableAdapter.DeleteQuery(num, salary);
                            (activeForm as StipForm).UpdateDataGridView();
                            break;
                        }
                }
            }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(
                    String.Format("Failed to apply DMl-command\r\n{0}", ex.Message),
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(
                    String.Format("No data\r\n{0}", ex.Message),
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //(activeForm as StudentsForm).StudDGV.Rows.RemoveAt((activeForm as StudentsForm).StudDGV.CurrentCell.RowIndex);

        }

        private void btnUpdateRow_Click(object sender, EventArgs e)
        {
            ///TODO Обновление даты в записи с существующей датой
            try
            {
                switch (curTable)
                {
                    case Tables.STUDENTS:
                        {
                            var form = new UPDATE_ROW_STUDENTS_FORM(sTUDENTSTableAdapter, 
                                (activeForm as StudentsForm).StudDGV.SelectedRows[0]);
                            form.ShowDialog();
                            (activeForm as StudentsForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.SESSION_HISTORY:
                        {
                            var form = new UPDATE_ROW_SESSION_HISTORY_FORM(sESSION_HISTORYTableAdapter,
                                (activeForm as SessionHistoryForm).SessHistDGV.SelectedRows[0]);
                            form.ShowDialog();
                            (activeForm as SessionHistoryForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.SESS_INF:
                        {
                            var form = new UPDATE_ROW_SESS_INF_FORM(sESS_INFTableAdapter,
                                (activeForm as SessInfForm).SessInfDGV.SelectedRows[0]);
                            form.ShowDialog();
                            (activeForm as SessInfForm).UpdateDataGridView();
                            break;
                        }
                    case Tables.STIP:
                        {
                            var form = new UPDATE_ROW_STIP_FORM(sTIPTableAdapter,
                                (activeForm as StipForm).StipDGV.SelectedRows[0]);
                            form.ShowDialog();
                            (activeForm as StipForm).UpdateDataGridView();
                            break;
                        }
                }
            }
            catch (ArgumentException) { }
            catch (System.Data.OracleClient.OracleException ex)
            {
                MessageBox.Show(
                    string.Format("Failed to apply DMl-command\r\n{0}", ex.Message),
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(
                    string.Format("Please, input a correct date\r\n{0}", ex.Message),
                   "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.LOG". При необходимости она может быть перемещена или удалена.
            this.lOGTableAdapter.Fill(this.dataSet1.LOG);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataToExcel(lOGTableAdapter.GetData());
        }

        public void LoadDataToExcel(DataTable dt)
        {
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("DataTable to Sheet");
            worksheet.InsertDataTable(lOGTableAdapter.GetData(), new InsertDataTableOptions()
            {
                ColumnHeaders = true,
                StartRow = 2
            });
            workbook.Save("general_report.xlsx");
            PrintReportInfo();

            xlApp = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные";

                //Выгрузка данных
                //DataTable dt = lOGTableAdapter.GetData();

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    data = dt.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.get_Range("A1:Z1", Type.Missing);

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                //заполняем строки
                for (rowInd = 0; rowInd < dt.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dt.Columns.Count; collInd++)
                    {
                        data = dt.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);
            }
        }

        public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }

        public void PrintReportInfo()
        {
            var str = "The report was created successfully";
            MessageBox.Show(str,
                   "Information",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDMLQuery_Click(object sender, EventArgs e)
        {
            var workbook = new ExcelFile();
            var worksheet = workbook.Worksheets.Add("DataTable to Sheet");
            switch (curTable)
            {
                case Tables.STUDENTS:
                    {
                        LoadDataToExcel(sTUDENTSTableAdapter.GetData());
                        break;
                    }
                case Tables.SESSION_HISTORY:
                    {
                        LoadDataToExcel(sESSION_HISTORYTableAdapter.GetData());
                        break;
                    }
                case Tables.SESS_INF:
                    {
                        LoadDataToExcel(sESS_INFTableAdapter.GetData());
                        break;
                    }
                case Tables.STIP:
                    {
                        LoadDataToExcel(sTIPTableAdapter.GetData());
                        break;
                    }
            }
        }
    }
}

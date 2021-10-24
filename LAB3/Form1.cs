using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using ExcelObj = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void расчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void отчиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void вводДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.DefaultExt = "*.xls;*.xlsx";
            ofd.Filter = "Excel (*.XLS)|*.XLS|Excel (*.XLSX)|*.XLSX";
            ofd.Title = "Выберите документ для загрузки данных";

            ExcelObj.Application app = new ExcelObj.Application();
            ExcelObj.Workbook workbook;
            ExcelObj.Worksheet NwSheet;
            ExcelObj.Range ShtRange;
            DataTable dt = new DataTable();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    workbook = app.Workbooks.Open(ofd.FileName, Missing.Value, Missing.Value,
                                        Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                        Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                        Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                    NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                    ShtRange = NwSheet.UsedRange;

                    dt.Columns.Add("X");
                    dt.Columns.Add("Y");

                    for(int Rnum = 1; Rnum <= ShtRange.Rows.Count; Rnum++)
                    {
                        DataRow dr = dt.NewRow();
                        dataGridView1.Rows.Add();
                        for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                        {
                            if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                            {
                                dr[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                                dataGridView1.Rows[Rnum - 1].Cells[Cnum - 1].Value = dr[Cnum - 1];
                            }
                        }
                        
                    }
                    app.Quit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    app.Quit();
                }
            }
        }

        private void googleTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

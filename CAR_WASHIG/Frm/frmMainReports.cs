using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_PROJECT.Frm
{
    public partial class frmMainReports : MetroForm
    {
        BindingSource binding = new BindingSource();
        string[] state = { "all", "daily", "weekly","invoice" };
        string[] showby = { "All", "Washing", "Oil", "Drink" };
        string current_state = null;
        string last_state = null;

        bool canPrintInvoice = false;
        bool canPrintInvoiceDaily = false;
        bool canPrintInvoiceWeekly = false;
        bool canPrintInvoiceType = false;
        bool canPrintRevenueDaily = false;
        bool canPrintRevenueWeekly = false;
        bool canPrintInvoice2 = false;

        DataGridViewRow current_row = null;


        public frmMainReports()
        {
            InitializeComponent();
            
            gridData.DataSource = binding;

            //loadAll();
            cbShowby.SelectedIndex = 0;
        }

        private void loadRecordsNum()
        {
            lbRec.Text = "Records: " + (gridData.RowCount-1);
            loadTotalAmount(gridData);
        }

        private int lastIndexCell(DataGridView dg)
        {

            return dg.ColumnCount - 1;
        }

        private void loadTotalAmount(DataGridView dg)
        {
            double total = 0;
            int index = lastIndexCell(dg);
            DataGridViewRow row = null;

            for (int i = 0; i < dg.RowCount-1; i++)
            {
                row = dg.Rows[i];
                total += Convert.ToDouble(row.Cells[index].Value + "");
            }

            lbTotalAmount.Text = "Total Amount: $" + total;
        }

        private void loadAll()
        {
            title("All Invoices");
            Helper.BindGridView("SELECT * FROM viewInvoice;", binding, gridData);
            Helper.AutoFitColumns(gridData);
            loadRecordsNum();

            //Get & Set State
            last_state = current_state;
            current_state = state[0];
            canPrintInvoice = true;
            canPrintInvoice2 = false;
            canPrintInvoiceDaily = false;
            canPrintInvoiceWeekly = false;
            canPrintInvoiceType = false;
            canPrintRevenueDaily = false;
            canPrintRevenueWeekly = false;
        }

        private void loadDaily()
        {
            title("Daily's Report");
            Helper.BindGridView("SELECT * FROM reportRevenueDaily;", binding, gridData);
            Helper.AutoFitColumns(gridData);
            loadRecordsNum();

            //Get & Set State
            last_state = current_state;
            current_state = state[1];
            canPrintInvoice = false;
            canPrintInvoice2 = false;
            canPrintInvoiceDaily = true;
            canPrintInvoiceWeekly = false;
            canPrintInvoiceType = false;
            canPrintRevenueDaily = true;
            canPrintRevenueWeekly = false;
        }

        private void loadWeekly()
        {
            title("Weekly's Report");
            Helper.BindGridView("SELECT * FROM reportRevenueWeekly;", binding, gridData);
            Helper.AutoFitColumns(gridData);
            loadRecordsNum();

            //Get & Set State
            last_state = current_state;
            current_state = state[2];
            canPrintInvoice = false;
            canPrintInvoice2 = false;
            canPrintInvoiceDaily = false;
            canPrintInvoiceWeekly = true;
            canPrintInvoiceType = false;
            canPrintRevenueDaily = false;
            canPrintRevenueWeekly = true;
        }

        private void loadBy(string sql)
        {
            Helper.BindGridView("EXECUTE listInvoiceByType @type = '"+sql+"';", binding, gridData);
            Helper.AutoFitColumns(gridData);
            loadRecordsNum();
            canPrintInvoice = true;
            canPrintInvoice2 = false;
            canPrintInvoiceDaily = false;
            canPrintInvoiceWeekly = false;
            canPrintInvoiceType = true;
            canPrintRevenueDaily = false;
            canPrintRevenueWeekly = false;
        }

        private void cbShowby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbShowby.SelectedItem.Equals("All"))
            {
                loadAll();
            }
            else
            {
                loadBy(cbShowby.SelectedItem + "");
                title(cbShowby.SelectedItem + "");
                current_state = "";
            }
        }

        private void title(string text)
        {
            this.Text = "Reports | " + text;
            this.Refresh();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            loadDaily();
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            loadWeekly();
        }

        private void loadByDate(string date)
        {
            title("Report for: " + date);
            Helper.BindGridView("SET DATEFIRST 1 EXECUTE listInvoiceDaily @date = '" + date+"';", binding, gridData);
            Helper.AutoFitColumns(gridData);
            loadRecordsNum();

            //Get & Set State
            last_state = current_state;
            current_state = state[3];
            canPrintInvoice = true;
            canPrintInvoice2 = false;
            canPrintInvoiceDaily = false;
            canPrintInvoiceWeekly = false;
            canPrintInvoiceType = false;
            canPrintRevenueDaily = false;
            canPrintRevenueWeekly = false;
        }

        private void loadByDate(string start_date,string end_date)
        {
            title("Report From: " + start_date + " To: " + end_date);
            Helper.BindGridView("SET DATEFIRST 1 EXECUTE listInvoiceWeekly @start_date = '" + start_date+"', @end_date = '"+end_date+"';", binding, gridData);
            Helper.AutoFitColumns(gridData);
            loadRecordsNum();

            //Get & Set State
            last_state = current_state;
            current_state = state[3];
            canPrintInvoice = true;
            canPrintInvoice2 = false;
            canPrintInvoiceDaily = false;
            canPrintInvoiceWeekly = false;
            canPrintInvoiceType = false;
            canPrintRevenueDaily = false;
            canPrintRevenueWeekly = false;
        }

        private void loadByInvoiceCode(string code)
        {
            title("Report for Invoice Code: " + code);
            Helper.BindGridView("EXECUTE listInvoiceDetail @InvoiceCode = '"+code+"';", binding, gridData);
            Helper.AutoFitColumns(gridData);
            loadRecordsNum();
            canPrintInvoice = false;
            canPrintInvoice2 = true;
            canPrintInvoiceDaily = false;
            canPrintInvoiceWeekly = false;
            canPrintInvoiceType = false;
            canPrintRevenueDaily = false;
            canPrintRevenueWeekly = false;
        }

        private void gridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            current_row = gridData.SelectedRows[0];

            if(1==2)
            {
                
            }
            else if(current_state.Equals(state[1]))
            {
                last_state = current_state;
                loadByDate(current_row.Cells[0].Value + "");
            }
            else if(current_state.Equals(state[2]))
            {
                last_state = current_state;
                loadByDate(current_row.Cells[0].Value + "", current_row.Cells[1].Value + "");
            }
            else if(current_state.Equals(state[3]) || current_state.Equals(state[0]))
            {
                last_state = current_state;
                loadByInvoiceCode(current_row.Cells[0].Value + "");
            }
            else
            {
                MessageBox.Show("Else !");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (last_state!=null)
            {
                if (last_state.Equals(state[0]))
                {
                    loadAll();
                }
                else if (last_state.Equals(state[1]))
                {
                    loadDaily();
                }
                else if (last_state.Equals(state[2]))
                {
                    loadWeekly();
                }
                else if (last_state.Equals(state[3]))
                {
                    loadByInvoiceCode(current_row.Cells[0].Value + "");
                }
                else
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(canPrintInvoiceType)
            {
                printInvoiceType();
            }
            else if(canPrintInvoice)
            {
                printInvoice();
            }
            else if(canPrintInvoiceDaily)
            {
                printInvoiceDaily();
            }
            else if(canPrintInvoiceWeekly)
            {
                printInvoiceWeekly();
            }
            else { MessageBox.Show("Please select one to print!"); }


        }

        private void printInvoiceType()
        {
            if (gridData.SelectedRows.Count > 0 && !(gridData.SelectedRows[0].Cells[0].Value + "").Equals(""))
            {
                List<reportInvoice> list = new List<reportInvoice>();

                DataGridViewRow row = null;

                for (int i = 0; i < gridData.RowCount - 1; i++)
                {
                    row = gridData.Rows[i];
                    reportInvoice inv = new reportInvoice();

                    inv.ServiceType = row.Cells["ServiceType"].Value + "";
                    inv.ServiceQty = int.Parse(row.Cells["ServiceQty"].Value + "");
                    inv.ServicePrice = double.Parse(row.Cells["ServicePrice"].Value + "");
                    inv.ServiceName = row.Cells["ServiceName"].Value + "";
                    inv.InvoiceCode = row.Cells["InvoiceCode"].Value + "";

                    list.Add(inv);
                }

                Reports.RevenueInvoiceDetailType report = new Reports.RevenueInvoiceDetailType();
                report.SetDataSource(list);

                new frmReport(report).ShowDialog();
            } else { MessageBox.Show("No invoice to print!"); }
        }

        private void printInvoiceDaily()
        {
            if (gridData.SelectedRows.Count > 0 && !(gridData.SelectedRows[0].Cells[0].Value + "").Equals(""))
            {
                List<reportInvoiceRevenue> list = new List<reportInvoiceRevenue>();

                string date = gridData.SelectedRows[0].Cells["Date"].Value + "";
                DataTable dt = Data.Datatable("SET DATEFIRST 1 EXECUTE listInvoiceDaily @date = '"+date+"'; ");

                foreach (DataRow row in dt.Rows)
                {
                    reportInvoiceRevenue inv = new reportInvoiceRevenue();
                    inv.Date = row["Date"] + "";
                    inv.InvoiceCode = row["InvoiceCode"] + "";
                    inv.EmpName = row["Name"] + "";
                    inv.TotalPrice = double.Parse(row["Amount"] + "");

                    list.Add(inv);
                }

                Reports.RevenueInvoice report = new Reports.RevenueInvoice();
                report.SetDataSource(list);
                new frmReport(report,"Report for Date: "+date).ShowDialog();

            } else { MessageBox.Show("Please select one to print!"); }
        }

        private void printInvoiceWeekly()
        {
            if (gridData.SelectedRows.Count > 0 && !(gridData.SelectedRows[0].Cells[0].Value + "").Equals(""))
            {
                List<reportInvoiceRevenueWeekly> list = new List<reportInvoiceRevenueWeekly>();

                string start_date = gridData.SelectedRows[0].Cells["Start_Date"].Value + "";
                string end_date = gridData.SelectedRows[0].Cells["End_Date"].Value + "";
                DataTable dt = Data.Datatable("SET DATEFIRST 1 EXECUTE listInvoiceWeekly @start_date = '"+start_date+"', @end_date = '"+end_date+"';");

                foreach (DataRow row in dt.Rows)
                {
                    reportInvoiceRevenueWeekly inv = new reportInvoiceRevenueWeekly();
                    inv.Date = start_date;
                    inv.End_Date = end_date;
                    inv.InvoiceCode = row["InvoiceCode"] + "";
                    inv.EmpName = row["Name"] + "";
                    inv.TotalPrice = double.Parse(row["Amount"] + "");

                    list.Add(inv);
                }

                Reports.RevenueInvoiceWeekly report = new Reports.RevenueInvoiceWeekly();
                report.SetDataSource(list);
                new frmReport(report, "Report From: " + start_date + " To: " + end_date).ShowDialog();

            } else { MessageBox.Show("Please select one to print!"); }
        }

        private void printInvoice()
        {
            if((gridData.SelectedRows.Count>0 && !(gridData.SelectedRows[0].Cells[0].Value+"").Equals("")))
            {
                List<reportInvoice> list = new List<reportInvoice>();

                string invCode = gridData.SelectedRows[0].Cells["InvoiceCode"].Value + "";

                DataTable dt = Data.Datatable("EXECUTE listInvoiceDetail2 @InvoiceCode = '" + invCode + "';");

                foreach (DataRow row in dt.Rows)
                {
                    reportInvoice inv = new reportInvoice();
                    inv.InvoiceCode = row["InvoiceCode"] + "";
                    inv.EmpName = row["Name"] + "";
                    inv.Date = row["Date"] + "";
                    inv.ServiceCode = row["ServiceCode"] + "";
                    inv.ServiceName = row["ServiceName"] + "";
                    inv.ServiceQty = int.Parse(row["ServiceQty"] + "");
                    inv.ServicePrice = double.Parse(row["ServicePrice"] + "");
                    inv.ServiceType = row["ServiceType"] + "";
                    list.Add(inv);
                }

                Reports.RevenueInvoiceDetail report = new Reports.RevenueInvoiceDetail();
                report.SetDataSource(list);

                new frmReport(report).ShowDialog();

            } else { MessageBox.Show("Please select one to print!"); }
        }

        private void btnPreviewAll_Click(object sender, EventArgs e)
        {
            if (canPrintRevenueDaily)
            {
                printRevenueDaily();
            }
            else if (canPrintRevenueWeekly)
            {
                printRevenueWeekly();
            }
            else if(canPrintInvoice2)
            {
                printInvoice();
            }
            else
            {
                MessageBox.Show("No need to print all!");
            }
        }

        private void printRevenueDaily()
        {
            
            if (gridData.SelectedRows.Count > 0)
            {
                
                List<reportRevenue> list = new List<reportRevenue>();
                
                DataTable dt = Data.Datatable("SELECT * FROM reportRevenueDaily;");

                foreach (DataRow row in dt.Rows)
                {
                    reportRevenue inv = new reportRevenue();
                    inv.Date = row["Date"] + "";
                    inv.Amount = double.Parse(row["Amount"] + "");

                    list.Add(inv);
                }

                Reports.RevenueDaily report = new Reports.RevenueDaily();
                report.SetDataSource(list);
                new frmReport(report, "Report | Daily's Report").ShowDialog();

            }
            else { MessageBox.Show("No data to print!"); }
        }

        private void printRevenueWeekly()
        {
            if (gridData.SelectedRows.Count > 0)
            {
                List<reportRevenueWeekly> list = new List<reportRevenueWeekly>();

                DataTable dt = Data.Datatable("SELECT * FROM reportRevenueWeekly;");

                foreach (DataRow row in dt.Rows)
                {
                    reportRevenueWeekly inv = new reportRevenueWeekly();
                    inv.Date = row["START_DATE"] + "";
                    inv.End_Date = row["END_DATE"] + "";
                    inv.Amount = double.Parse(row["Amount"] + "");

                    list.Add(inv);
                }

                Reports.RevenueWeekly report = new Reports.RevenueWeekly();
                report.SetDataSource(list);
                new frmReport(report, "Report | Weekly's Report").ShowDialog();

            }
            else { MessageBox.Show("No data to print!"); }
        }
    }
}

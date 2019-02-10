using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_PROJECT
{
    public partial class frmSellService : MetroFramework.Forms.MetroForm
    {
        public bool ok {get; set;} = false;
        public string GuestCode { get; set; }
        public bool complete { get; set; }
        public frmSellService()
        {
            InitializeComponent();
            Data.TestConnection(this);

            lbLoggedin.Text = "Logged in: " + Helper.Username;

            btnRemove.Enabled = false;
            txtprice.Enabled = false;
            txttotal.Enabled = false;
            btnpay.Enabled = false;

            foreach (ColumnHeader item in listView1.Columns)
                item.Width = listView1.Width / 6;
            Helper.FillCombobox(ref cbServiceType, "ServiceType", "ServiceTypeID", "ServiceType");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            
            try
            {
                cbServiceType.SelectedIndex = cbStatus.SelectedIndex = 1;
                cbServiceType.SelectedIndex = cbStatus.SelectedIndex = 0;

                cbService.SelectedIndex = 1;
                cbService.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Helper.ClearRequirement(this);
            Control[] ctrls=new Control[] {cbService,txtQty};
            if(Helper.CheckRequirement(this, ctrls))
                return;
            bool exist = false;
            foreach (ListViewItem item in listView1.Items)
                if (item.SubItems[1].Text == cbService.Text)
                {
                    item.SubItems[5].Text = (double.Parse(txtprice.Text) * int.Parse(txtQty.Text)+double.Parse(item.SubItems[5].Text)) + "";
                    item.SubItems[3].Text = (int.Parse(txtQty.Text) + int.Parse(item.SubItems[3].Text))+"";
                    exist = true;
                }
            if (!exist)
            {
                string[] st = { Data.ExecuteScale("Select ServiceCode from Service where ServiceID=" + cbService.SelectedValue) + "", cbService.Text + "", cbServiceType.Text + "",txtQty.Text,txtprice.Text, (double.Parse(txtprice.Text) * int.Parse(txtQty.Text) + "") };
                ListViewItem li = new ListViewItem(st);
                listView1.Items.Add(li);
            }
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
                total += double.Parse(item.SubItems[5].Text);
            txttotal.Text = total.ToString("#,##0.00") + " $";

            btnpay.Enabled = listView1.Items.Count > 0 ? true : false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Helper.ClearRequirement(this);
            btnpay.Enabled = false;
            txtprice.Text = txtQty.Text = "0";
            cbServiceType.SelectedIndex = cbStatus.SelectedIndex = 1;
            cbServiceType.SelectedIndex = cbStatus.SelectedIndex = 0;
            try {
                cbService.SelectedIndex = 1;
                cbService.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = listView1.SelectedIndices.Count > 0 ? true : false;
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Width / 6;
        }

        private void cbServiceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbService.DisplayMember = "ServiceName";
            cbService.ValueMember = "ServiceID";
            cbService.DataSource = Data.Datatable("Select * from Service Where ServiceTypeID='" + cbServiceType.SelectedValue + "' and ServiceStatus='Enable'");       
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtprice.Text = ""+double.Parse(Data.ExecuteScale("Select ServicePrice from Service where ServiceID='" + cbService.SelectedValue + "'")+"").ToString("#,##0.00");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
            double total = 0;
            foreach (ListViewItem item in listView1.Items)
                total += double.Parse(item.SubItems["Amount"].Text);
            txttotal.Text = total + " $";
            btnpay.Enabled = listView1.Items.Count > 0 ? true : false;

        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            complete = cbStatus.SelectedIndex == 0 ? false : true;

            if (cbStatus.SelectedIndex.Equals(1))
                btnpay.Enabled = true;
            else
                btnpay.Enabled = false;
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            double total = double.Parse(txttotal.Text.Split(' ')[0]) ;
            double payment = 0;
            if (total <= 0)
                return;
            moneyless:

            frmPayment frm = new frmPayment();
            frm.ShowDialog();

            if (!frm.Clickok)
                return;
           
            try
            {
                payment = double.Parse(frm.txtpay.Trim());
            }
            catch
            {
                MetroMessageBox.Show(this, "Please Input Money Amount Correctly", "Cautious", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto moneyless;
            }

            if (payment > total)
            {
                MetroMessageBox.Show(this, "Please Change Back : " + (payment - total) + " $", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Warning);

               
            }
            else if (payment == total)
            {
                MetroMessageBox.Show(this, "The Amount is Correctly", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MetroMessageBox.Show(this, "Not Enough", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
                goto moneyless;
            }
            string sql = "Insert into Invoice(InvoiceDate,TotalPrice,EmpID) values(@sub1,@sub2,@sub3) Select Scope_identity()";
            string[] param = { DateTime.Now + "", total + "", Data.ExecuteScale("Select EmpID from Employee where Name='"+Helper.Username+"'")+""};
            string InvoiceID=Data.ExecuteScale(sql, Data.GetParam(param))+"";

            foreach(ListViewItem item in listView1.Items)
            {
                string Statement = "Insert into InvoiceDetail values(@sub1,@sub2,@sub3,@sub4)";
                string[] value = { InvoiceID, Data.ExecuteScale("Select ServiceID from Service Where ServiceName='"+item.SubItems[1].Text+"'")+"", item.SubItems[3].Text ,item.SubItems[5].Text};
                Data.ExecuteNonQuery(Statement, Data.GetParam(value));
            }
            paid = true;
            btnpay.Enabled = false;
            btnpay.Text = "PAID";
            // Report Here

            List<reportInvoice> SourceReport = new List<reportInvoice>();

            for (int i =0;i<listView1.Items.Count;i++) {
                reportInvoice cls = new reportInvoice();
                ListViewItem.ListViewSubItemCollection Currentrow = listView1.Items[i].SubItems;
                cls.GeustCode = GuestCode;
                cls.EmpName = Helper.Username;
                cls.Date = DateTime.Now.ToString("dddd dd/MM/yyyy hh:mm:ss tt");
                cls.InvoiceCode = "INV"+("00000"+InvoiceID).Substring(("00000"+InvoiceID).Length - 5);
                cls.ServiceCode = Currentrow[0].Text;
                cls.ServiceName = Currentrow[1].Text;
                cls.ServicePrice = double.Parse(Currentrow[4].Text);
                cls.ServiceQty = int.Parse(Currentrow[3].Text);
                cls.ServiceType = Currentrow[2].Text;
                SourceReport.Add(cls);
            }

            Reports.Invoice rpt = new Reports.Invoice();
            rpt.SetDataSource(SourceReport);

            new frmReport(rpt).ShowDialog();
            listView1.Items.Clear();
            this.Close();

        }
        public bool paid { get; set; } = false;
        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            btnpay.Enabled = double.Parse(txttotal.Text.Split(' ')[0]) == 0 ? false : true;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            ok = true;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            ok = false;
            new frmLogin().Show();
            this.Hide();
        }
        public bool firstTime { get; set; } = true;
        private void frmSellService_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ok)
            {
                if(txttotal.Text=="0" || txttotal.Text == "" || txttotal.Text=="0 $")
                {
                    e.Cancel = true;
                    MetroMessageBox.Show(this, "You Cannot Leave Total Blank", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    return;
                }
            }
            // Status Complete
            if (complete)
            {
                // Click OK
                if (ok)
                {
                    // Pay Money
                    if (paid)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        e.Cancel = true;
                        MetroMessageBox.Show(this, "You Must Pay Before Leave", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                //Click Cancel
                else
                {
                    if (firstTime)
                        this.Dispose();
                    else
                    {
                        e.Cancel = true;
                        this.Hide();
                    }
                }
            }
            else
            {
                if(firstTime)
                {
                    if (!ok)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        e.Cancel = true;
                        this.Hide();
                    }
                }
                else
                {
                    e.Cancel = true;
                    
                    this.Hide();
                }
            }   
            
        }
    }
}

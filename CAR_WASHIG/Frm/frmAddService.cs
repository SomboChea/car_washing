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
    public partial class frmAdd : MetroFramework.Forms.MetroForm
    {
        public frmAdd()
        {
            InitializeComponent();
            Data.TestConnection(this);
            Helper.FillCombobox(ref cbType, "ServiceType", "ServiceTypeID", "ServiceType");

            txtCode.Enabled = false;
           
            
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            button4_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Helper.ClearRequirement(this);
            string id = "0000000" +(1+int.Parse( Data.ExecuteScale("Select ident_current('Service')")+""));
            txtCode.Text = "SV"+id.Substring(id.Length - 5);

            try
            {
                cbType.SelectedIndex = 0;
            }
            catch (Exception) { }

            txtPrice.Text = "";
            txtService.Text = "";

            dgService.DataSource = Data.Datatable("Select * from viewService where ServiceStatus='Enable'");
            btnAdd.Text = "ADD";
            btnRemove.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgService_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "UPDATE";
            btnRemove.Enabled = true;

            DataGridViewCellCollection Cell = dgService.SelectedRows[0].Cells;
            txtCode.Text = Cell["ServiceCode"].Value+"";
            txtPrice.Text = double.Parse(Cell["ServicePrice"].Value + "").ToString("#,##0.00");
            txtService.Text = Cell["ServiceName"].Value + "";
           // MessageBox.Show(cbType.SelectedItem+"");
            cbType.SelectedValue = Data.ExecuteScale("Select ServiceTypeID from ServiceType where ServiceType='" + Cell["ServiceType"].Value + "'");
           
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Data.ExecuteNonQuery("Update Service set ServiceStatus='Disable' where ServiceCode='" + txtCode.Text+"'");
            button4_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Helper.ClearRequirement(this);
            Control[] ctrls = new Control[] { txtPrice,txtService,cbType };
            if (Helper.CheckRequirement(this,ctrls))
                return; 
            if (btnAdd.Text == "ADD") {
                string sql = "Insert into Service(ServiceName,ServicePrice,ServiceTypeID,ServiceStatus) values(@sub1,@sub2,@sub3,'Enable')";
                string[] sub = new string[] { txtService.Text.Trim(), txtPrice.Text, cbType.SelectedValue + "" };
                Data.ExecuteNonQuery(sql, Data.GetParam(sub));
            }
            else
            {
                string sql = "Update Service set ServiceName=@sub1,ServicePrice=@sub2,ServiceTypeID=@sub3 where ServiceCode='"+txtCode.Text+"'";
                string[] sub = new string[] { txtService.Text.Trim(), txtPrice.Text, cbType.SelectedValue + "" };
                Data.ExecuteNonQuery(sql, Data.GetParam(sub));
            }

            button4_Click(null, null);
        }
    }
}

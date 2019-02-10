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
    public partial class frmEmployee : MetroFramework.Forms.MetroForm
    {
        Control[] Ctrls;
        public frmEmployee()
        {
            InitializeComponent();
            Data.TestConnection(this);

            btnremove.Enabled = false;
            Helper.FillCombobox(ref cbRole, "Position", "PosID", "Position");
            //List<Position> Pos = new List<Position>();
            //Pos.Add(new Position("Washer", "1"));
            //Pos.Add(new Position("Cashier", "2"));
            //Pos.Add(new Position("Admin", "3"));
            //cbRole.DataSource = Pos;
            //cbRole.DisplayMember = "Member";
            //cbRole.ValueMember = "Value";


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            button3_Click(null, null);
            try
            {
                dgemp1.DataSource = Data.Datatable("Select * from viewEmployee");
            }
            catch (Exception) { return; }

        }


        private void chkAcc_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.Enabled = chkAcc.Checked;
            txtUserName.Enabled = chkAcc.Checked;
            if (!chkAcc.Checked)
            {
                txtUserName.Text = "";
                txtPass.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in Controls.OfType<TextBox>())
                txt.Text = "";
            rMale.Checked = true;
            chkAcc.Checked = true;
            chkAcc.Checked = false;
            Ctrls = new Control[] { txtName, txtEmail, txtTel, txtSalary, cbRole };
            try
            {
                cbRole.SelectedIndex = 0;
            }
            catch (Exception ex) { }
            string id = "00000" + (1 + int.Parse(Data.ExecuteScale("Select Ident_Current('Employee')") + ""));
            String Code = "EMP" + id.Substring(id.Length - 5, 5);
            txtCode.Text = Code;
            Helper.ClearRequirement(this);
            btnremove.Enabled = false;
            btnOk.Text = "Save";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmEmployee_Click(object sender, EventArgs e)
        {


        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUserName.Enabled = txtPass.Enabled = chkAcc.Enabled = cbRole.SelectedIndex == 0 ? false : true;
            txtPass.Enabled = chkAcc.Checked && cbRole.SelectedIndex != 0 ? true : false;
            txtUserName.Enabled = chkAcc.Checked && cbRole.SelectedIndex != 0 ? true : false;
           // MessageBox.Show(cbRole.SelectedValue + " " + cbRole.SelectedIndex);
        }

        private void dgemp1_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection Cell = dgemp1.SelectedRows[0].Cells;
            txtCode.Text = Cell["EmpCode"].Value + "";
            txtName.Text = Cell["Name"].Value + "";
            txtEmail.Text = Cell["Email"].Value + "";
            txtAddress.Text = Cell["Address"].Value + "";
            txtPass.Text = Cell["Password"].Value + "";
            txtSalary.Text = Cell["Salary"].Value + "";
            txtTel.Text = Cell["Tel"].Value + "";

            cbRole.SelectedValue = Data.ExecuteScale("Select PosID from Position where Position='" + Cell["Position"].Value+"'");
            
            chkAcc.Checked = Cell["Username"].Value + "" == "" ? false : true;
            chkAcc.Checked = !chkAcc.Checked;
            chkAcc.Checked = !chkAcc.Checked;
            chkAcc.Enabled = chkAcc.Checked;
            txtUserName.Text = Cell["Username"].Value + "";
            btnremove.Enabled = true;
            btnOk.Text = "UPDATE";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Helper.ClearRequirement(this);
            if (chkAcc.Checked)
            {
                Ctrls = new Control[] { txtName, txtEmail, txtTel, txtSalary, cbRole, txtPass, txtUserName };
            }
            else
            {
                Ctrls = new Control[] { txtName, txtEmail, txtTel, txtSalary, cbRole };
            }
            if (Helper.CheckRequirement(this, Ctrls))
                return;

            bool insert = true;
            foreach (DataGridViewRow row in dgemp1.Rows)
            {
                if (row.Cells[0].Value.ToString() == txtCode.Text)
                {
                    // Update
                    string sql= "Update Employee set Name=@sub1,Address=@sub2,Tel=@sub3,Salary=@sub4,PosID=@sub5,Username=@sub6,Password=@sub7,Email=@sub8 Where EmpCode='"+txtCode.Text+"'";
                    string[] st = { txtName.Text.Trim(), txtAddress.Text, txtTel.Text, txtSalary.Text, cbRole.SelectedValue + "", txtUserName.Text, txtPass.Text, txtEmail.Text};
                    Data.ExecuteNonQuery(sql, Data.GetParam(st));
                    insert = false;
                }
            }
            if (insert)
            {
                // Insert
                string sql = "insert into Employee(Name,Address,Tel,Salary,PosID,Username,Password,Email,Status) values(@sub1,@sub2,@sub3,@sub4,@sub5,@sub6,@sub7,@sub8,@sub9)";
                string[] st = { txtName.Text.Trim(), txtAddress.Text, txtTel.Text, txtSalary.Text, cbRole.SelectedValue + "", txtUserName.Text, txtPass.Text, txtEmail.Text, "Enable" };
                Data.ExecuteNonQuery(sql, Data.GetParam(st));
            }
            dgemp1.DataSource = Data.Datatable("Select * from viewEmployee");
            button3_Click(null, null);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            Data.ExecuteNonQuery("Update Employee set Status='Disable' Where EmpCode='" + txtCode.Text + "'");
            dgemp1.DataSource = Data.Datatable("Select * from viewEmployee");
            button3_Click(null, null);
        }
     
    }
    public class Position
    {
        public Position(string member, string value)
        {
            this.Member = member;
            this.Value = value;
        }
        public string Member { get; }
        public string Value { get; }
    }

}

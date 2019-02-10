using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIS_PROJECT
{
    public class Helper
    {
        public static string Username { get; set; } = "Chea Sambo";
        public static int Guest_Code { get; set; }
        public static bool CheckRequirement(MetroForm frm, Control[] AllControl)
        {
            bool check = false;
            foreach (Control ctrl in AllControl)
            {
                check = ctrl.Text.Trim() == "" ? SetRedBox(frm, ctrl) : check;
                if (ctrl.Tag == "double")
                {
                    try
                    {
                        if(double.Parse(ctrl.Text.Trim())<=0
                            )
                            check=SetRedBox(frm,ctrl);
                    }
                    catch (Exception)
                    {
                        check = SetRedBox(frm, ctrl);
                    }
                }
            }
            return check;
            
        }

        public static void FillCombobox(ref ComboBox cb,string Member,string value,string TableName)
        {
            
            cb.DisplayMember = Member;
            cb.ValueMember = value;
            cb.DataSource = Data.Datatable("Select * from " + TableName).DefaultView;

        }

        public static bool SetRedBox(MetroForm Context,Control ctrl)
        {
            Label RedLine = new Label();
            RedLine.Size = new System.Drawing.Size(ctrl.Size.Width + 4, ctrl.Size.Height + 4);
            RedLine.BackColor = Color.Red;
            RedLine.Location = new Point(ctrl.Location.X - 2, ctrl.Location.Y - 2);
            RedLine.Tag = "Remove";
            Context.Controls.Add(RedLine);
            return true;       
        }
        public static void ClearRequirement(MetroForm Main)
        {
            foreach (Control ctrl in Main.Controls)
                if (ctrl.Tag == "Remove")
                    ctrl.Hide();
        }

        public static void AutoFitColumns(DataGridView dg)
        {
            try
            {

                dg.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception) { }
        }

        public static void BindGridView(string cmdText, BindingSource bindinSource, DataGridView gridView)
        {
            try
            {

                gridView.Columns.Clear();

                DataTable dt = new DataTable();

                SqlDataAdapter adapter = new SqlDataAdapter(cmdText, Data.Connection);
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adapter);

                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.Fill(dt);
                bindinSource.DataSource = dt;

                // Resize the DataGridView columns to fit the newly loaded content.
                gridView.AutoResizeColumns(
                 DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Can't connect to database!" + Environment.NewLine + ex.Message);
            }

        }

    }
}

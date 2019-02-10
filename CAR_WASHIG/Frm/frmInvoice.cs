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
    public partial class frmInvoice : MetroFramework.Forms.MetroForm
    {
        public frmInvoice()
        {
            InitializeComponent();
            foreach (ColumnHeader col in listStatus.Columns)
                col.Width = listStatus.Width / 3;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listStatus.Width / 3;
        }

        private List<frmSellService> listfrm = new List<frmSellService>();

        public void btncheck_Click(object sender, EventArgs e)
        {
            index++;
            frmSellService frm = new frmSellService();
            frm.GuestCode = "G" + index;
            frm.firstTime = true;
            frm.ShowDialog();

            if (frm.ok)
            {
                if (!frm.complete)
                {
                    listfrm.Add(frm);
                    string[] items = { index + "", frm.txttotal.Text, "Waiting" };
                    listStatus.Items.Add(new ListViewItem(items));
                }
                else
                {
                    listfrm.Add(frm);
                }
            }
        }

        private int index = 0;

        private void listStatus_DoubleClick(object sender, EventArgs e)
        {
            int indexShow = int.Parse(listStatus.SelectedItems[0].SubItems[0].Text) - 1;
            frmSellService frm = listfrm[indexShow];
            frm.firstTime = false;
            try
            {
                listfrm[indexShow].ShowDialog();
            }
            catch (Exception) { }

            if (frm.complete)
            {
                try
                {
                    if (frm.ok)
                    {
                        listStatus.Items.RemoveAt(indexShow);
                        listfrm.RemoveAt(indexShow);
                    }
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    listStatus.SelectedItems[0].SubItems[1].Text = frm.txttotal.Text;
                }
                catch (Exception) { }
            }
        }

        private void frmInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            //if (listStatus.Items.Count > 0)
            //{
            //    MetroMessageBox.Show(this, "Please complete invoice queue!", "STOP", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    e.Cancel = true;
            //}
            //else
            //    this.Close();
        }
    }
}
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

namespace MIS_PROJECT
{
    public partial class frmPayment : MetroForm
    {
        public frmPayment()
        {
            InitializeComponent();
        }
        public bool Clickok { get; set; } = false;
        public string txtpay { get; set; }
        private void frmPayment_Load(object sender, EventArgs e)
        {

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            Clickok = true;
            txtpay = txtPay.Text;
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clickok = false;
            this.Dispose();
        }

        private void frmPayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            //e.Cancel = true;
        }
    }
}

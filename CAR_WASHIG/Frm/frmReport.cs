using CrystalDecisions.CrystalReports.Engine;
using MetroFramework.Forms;

namespace MIS_PROJECT
{
    public partial class frmReport : MetroForm
    {
        public frmReport()
        {
            InitializeComponent();
        }

        public frmReport(ReportDocument report,string title="Report Form")
        {
            InitializeComponent();
            this.Text = title;
            FullMode.Fullscreen(this);
            reportViewer.ReportSource = report;
        }
    }
}

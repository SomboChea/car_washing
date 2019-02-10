using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIS_PROJECT
{
    public class reportInvoice
    {
        public string GeustCode { get; set; }
        public string InvoiceCode { get; set; }
        public string EmpName { get; set; }
        public string Date { get; set; }

        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public string ServiceType { get; set; }
        public double ServicePrice { get; set; }
        public int ServiceQty { get; set; }
        public double Amount { get { return ServiceQty * ServicePrice; } }
    }
}

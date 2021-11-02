using System;
using System.Drawing;
using DevExpress.XtraReports.UI;

namespace TestDevExpress.Core
{
    public partial class XtraReport1
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var size = Convert.ToInt32(GetCurrentColumnValue("NameSize"));
            if (size == 0) size = 9;
            this.label1.Font = new System.Drawing.Font("Calibri", size);
        }
    }
}

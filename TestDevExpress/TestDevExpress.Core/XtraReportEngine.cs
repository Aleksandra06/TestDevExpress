using System.Collections.Generic;
using System.IO;
using DevExpress.XtraPrinting;
using TestDevExpress.Core.Models;

namespace TestDevExpress.Core
{
    public class XtraReportEngine
    {
        public XtraReportEngine()
        {

        }
        public byte[] CreateAnschreibenEmpfehlungReport(Model model, int docFormatId)
        {
            MemoryStream stream = new MemoryStream();
            using (var report = new XtraReport1())
            {
                var masterdata = new List<Model>();
                masterdata.Add(model);
                report.DataSource = masterdata;

                switch (docFormatId)
                {
                    case 1:
                        report.ExportToRtf(stream);

                        break;
                    case 2:
                        report.ExportToPdf(stream);

                        break;
                    case 3:
                        var docxExportOptions = new DocxExportOptions()
                        {
                            ExportMode = DocxExportMode.SingleFile,
                            TableLayout = true,
                            KeepRowHeight = true
                        };

                        report.ExportToDocx(stream, docxExportOptions);
                        break;

                    default:
                        break;
                }


            }

            return stream.ToArray();
        }
    }
}

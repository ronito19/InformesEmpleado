using InformesEmpleado.DataSet;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InformesEmpleado.Reporting
{
    /// <summary>
    /// Lógica de interacción para ReportPreview.xaml
    /// </summary>
    public partial class ReportPreview : Window
    {

        ReportViewer myReport;
        public ReportPreview()
        {
            InitializeComponent();
            myReport = new ReportViewer();
        }

        public void GetByIdDpto(int idDpto)
        { 
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "Informe";
            rds.Value = DataSetHanler.GetByIdDpto(1);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeDpto.rdlc";
            myReport.RefreshReport();
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            pdfWebViewer.Address = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }


        public void GetByIdProyecto(int idProyecto)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "InformeProyecto";
            rds.Value = DataSetHanler.GetByIdProyecto(idProyecto);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeProyecto.rdlc";
            myReport.RefreshReport();
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            pdfWebViewer.Address = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }



        public void GetByIdProyecto(int idProyecto, int idDpto)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "InformeProyecto";
            rds.Value = DataSetHanler.GetByIdProyecto(idProyecto, idDpto);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeProyecto.rdlc";
            myReport.RefreshReport();
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            pdfWebViewer.Address = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }



        public void GetByFecha(string fecha1, string fecha2)
        {
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DatosFecha";
            rds.Value = DataSetHanler.GetByFecha(fecha1, fecha2);
            myReport.LocalReport.DataSources.Add(rds);
            myReport.LocalReport.ReportPath = "../../Reporting/InformeFechas.rdlc";
            myReport.RefreshReport();
            byte[] PDFBytes = myReport.LocalReport.Render(format: "PDF", deviceInfo: "");
            pdfWebViewer.Address = "data:application/pdf;base64," + Convert.ToBase64String(PDFBytes);
        }






    }
}

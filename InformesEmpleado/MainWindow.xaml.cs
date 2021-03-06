using InformesEmpleado.Reporting;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InformesEmpleado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ReportPreview rp = new ReportPreview();
            rp.GetByIdDpto(1);
            rp.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ReportPreview rp = new ReportPreview();
            rp.GetByIdProyecto(1);
            rp.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ReportPreview rp = new ReportPreview();
            rp.GetByIdProyecto(1, 3);
            rp.Show();
       }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ReportPreview rp = new ReportPreview();
            rp.GetByFecha("01/02/2022", "01/04/2022");
            rp.Show();
        }
    }
}

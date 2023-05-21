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
using System.IO;
using System.Collections.Generic;

namespace Kektura
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            //Beolvasás, Listába felvétel
            
            List<string> kezdopont = new List<string>();
            List<string> vegpont = new List<string>();
            List<double> hossz = new List<double>();
            List<int> emelkedo = new List<int>();
            List<int> leejto = new List<int>();

            StreamReader sr = new StreamReader("kektura.txt");

            string line = "";
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[]darabok = line.Split(';');

                kezdopont.Add(darabok[0]);
                vegpont.Add(darabok[1]);
                hossz.Add(Convert.ToDouble(darabok[2]));
                emelkedo.Add(Convert.ToInt32(darabok[3]));
                leejto.Add(Convert.ToInt32(darabok[4]));
            }

            sr.Close();

        }

        //btn
        private void btnSzakaszok_Click(object sender, RoutedEventArgs e)
        {
            foreach (int db in kezdopont)
            {
                db++;
            }

            MessageBox.Show(db);
        }

        //DataGrid
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void txtUesrInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

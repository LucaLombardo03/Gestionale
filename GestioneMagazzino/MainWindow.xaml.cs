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

namespace GestioneMagazzino
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string file = @"oggetti.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter swoggetti = new StreamWriter(file, true))
            {
                swoggetti.WriteLine(TxtOggetto.Text);
            }  
        }

        private void BtnVedi_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader rdfile = new StreamReader(file))
            {
                string sline;
                while ((sline = rdfile.ReadLine()) != null)
                {
                    LstOggetti.Items.Add(sline.ToString());
                }
            }
        }
    }
}
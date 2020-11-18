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

namespace esercitazione
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Libro> Libri;

        public MainWindow()
        {
            InitializeComponent();

            LeggiFile();
        }

        private void LeggiFile()
        {
            Libri = new List<Libro>();

            using (StreamReader sr = new StreamReader("libri.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string[] libro = sr.ReadLine().Split(',');
                    Libro a = new Libro(libro[0], libro[1], int.Parse(libro[2]), libro[3], int.Parse(libro[4]));
                    Libri.Add(a);
                }
            }
            
               
                    
                        
                    
            
        }
    }
}

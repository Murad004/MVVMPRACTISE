using PUBMVVMTASK.Models;
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

namespace PUBMVVMTASK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Pub> Pubs { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Pubs = new List<Pub>
            {
                new Pub
                {
                    Id=0,Name="NZS",Price=1,Volume=0.5
                },
                new Pub
                {
                    Id=1,Name="Xirdalan",Price=1.50,Volume=0.5
                },
                new Pub
                {
                    Id=2,Name="Eddinger",Price=7.50,Volume=0.5
                }
            };
        }

    }
}
using HerbalismRoler.Objects;
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

namespace HerbalismRoler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Modifier;
        public int DC;

        public MainWindow()
        {
            InitializeComponent();
            Modifier = (int)ModifierNum.Value;
            DC = Convert.ToInt32(DifNumber);
        }

        private void GenoratorButton_Click(object sender, RoutedEventArgs e)
        {
            Genorator gen = new Genorator();
            gen.rollTable(new ArcticTable(), Modifier, DC);
        }
    }
}

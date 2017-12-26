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
        public int RollTimes;
        public Table table;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenoratorButton_Click(object sender, RoutedEventArgs e)
        {
            Modifier = (int)ModifierNum.Value;
            DC = Convert.ToInt32(DifNumber.Value);
            RollTimes = Convert.ToInt32(TimesRolledNumber.Value);

            switch (EnviromentComboBox.Text)
            {
                case "Arctic":
                    table = new ArcticTable();
                    break;
                case "Common":
                    table = new CommonTable();
                    break;
                default:
                    throw new NotImplementedException("Chosen Table has not yet been added");
            }

            Genorator gen = new Genorator();



            for (int i = 0; i < RollTimes; i++)
            {
                gen.rollTable(table, Modifier, DC);
            }

            GenoratedIngredients.Text = gen.getTable();
        }
    }
}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rekenspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int getal1;
        int getal2;
        string math;

        void GenerateSom()
        {
            getal1 = random.Next(1, 11);
            getal2 = random.Next(1, 11);
            int total = 0;
            int choice = random.Next(1, 5);
            
             if (choice == 1)
            { math = "+"; }
            else if (choice == 2)
            { math = "-"; }
            else if (choice == 3)
            { math = "*"; }
            else if (choice == 4)
            { math = "/"; }

           


            som.Text = $"{getal1} {math} {getal2}";
                
                
        }

        int calculate()
        {
            if (math == "+")
            {
                return getal1 + getal2;
            }
            else if (math == "-")
            {
                return getal1 - getal2;
            }
            else if (math == "*")
            {
                return getal1 * getal2;
            }
            else
            {
                return getal1 / getal2;
            }

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GenerateSom();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
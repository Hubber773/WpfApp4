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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void B_ginner_Click(object sender, RoutedEventArgs e)
        {
            int ileZnaków = TB_znaki.Text.Length;
            //char hasztag = '#'
            string[] tabliczka = new string[ileZnaków];
            Random rnd = new Random();

            string litery = "qwertyuiopasdfghjklzxcvbnnnmQWERTYUIOPASDFGHJKLZXCVBNM";
            string cyfry = "1234567890";
            string specjalne = "!@#$%^&*-=_+";
            string haslo = "";

            for (int i = 0; i < tabliczka.Length; i++)
            {
                if (CB_litery.IsChecked == true)
                {
                    //MessageBox.Show($"{ileZnaków}");
                    tabliczka[0] = litery[rnd.Next(0, litery.Length)].ToString();
                    haslo += tabliczka[0];
                }
            }
            MessageBox.Show(haslo);
        }
    }
}
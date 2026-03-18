using System.ComponentModel.Design;
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

namespace P20260311
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

        private void belepes_Click(object sender, RoutedEventArgs e)
        {
            menuablak mAblak=new menuablak();
            mAblak.Show();
        }

        private void kilepes_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
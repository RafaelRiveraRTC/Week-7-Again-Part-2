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

namespace Week_7_Again_Part_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            new NewControl();

            new This_Is_My_Stuff();

            MessageBox.Show(canvasMain.Children.Count.ToString());
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {



            userControlNewControl.Visibility =
                Visibility.Hidden;

            MessageBox.Show(userControlNewControl.IsVisible.ToString());
            Thread.Sleep(5000);//This will cause a 5 second delay
            userControlNewControl.Visibility = Visibility.Visible;//This makes it so it will immediately appear right after the button is clicked


        }

        private void TheCoolerButton_Click(object sender, RoutedEventArgs e)
        {
            RichardLikesTrains.Visibility =
               Visibility.Hidden;

            MessageBox.Show(RichardLikesTrains.IsVisible.ToString());
            Thread.Sleep(5000);//This will cause a 5 second delay
            RichardLikesTrains.Visibility = Visibility.Visible;//This makes it so it will immediately appear right after the button is clicked
        }
    }
}
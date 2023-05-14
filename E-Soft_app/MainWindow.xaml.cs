using E_Soft_app.ApplicationData;
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


namespace E_Soft_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameMain.Content = new Autorization();
            /*FrameMain.Navigate(new Autorization());*/
            AppConnect.dataBas_test = new DataBase_for_AppEntities();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.Content = new Autorization();
        }
    }
}

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

namespace E_Soft_app.PageUser
{
    /// <summary>
    /// Interaction logic for PageUser.xaml
    /// </summary>
    public partial class PageMenuUser : Page
    {
        public PageMenuUser()
        {
            InitializeComponent();
            UserList.ItemsSource = tradeEntities.GetContext().Product.ToList();
        }
    }
}

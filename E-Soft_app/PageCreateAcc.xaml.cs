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
    /// Interaction logic for PageCreateAcc.xaml
    /// </summary>
    public partial class PageCreateAcc : Page
    {
        private int role_count = 0;
        public PageCreateAcc()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (add_password_text_box_repeat.Password != add_password_text_box.Text)
            {
                add_button.IsEnabled = false;
                add_password_text_box_repeat.Background = Brushes.Red;
                add_password_text_box.Background = Brushes.Red;
            }
            else
            {
                add_password_text_box_repeat.Background = Brushes.LightGreen;
                add_password_text_box.Background = Brushes.LightGreen;
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Autorization());
        }

        private void add_button_Click(object sender, RoutedEventArgs e)
        {
            if (AppConnect.dataBas_test.user_.Count(x => x.login == add_login_text_box.Text) > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return;
            }
            try
            {
                user_ userObj = new user_()
                {
                    id_role = role_count,
                    login = add_login_text_box.Text,
                    password = add_password_text_box.Text,
                    name = add_name_text_box.Text
                };
                AppConnect.dataBas_test.user_.Add(userObj);
                AppConnect.dataBas_test.SaveChanges();
                MessageBox.Show("Данные успешно добавлены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении новых данных");
            }
        }

        private void RadioButton_Checked_Admin(object sender, RoutedEventArgs e)
        {
            add_button.IsEnabled = true;
            role_count = 1;

        }

        private void RadioButton_Checked_User(object sender, RoutedEventArgs e)
        {
            add_button.IsEnabled = true;
            role_count = 2;
        }

        private void RadioButton_Checked_Manager(object sender, RoutedEventArgs e)
        {
            add_button.IsEnabled = true;
            role_count = 3;
        }
    }
}

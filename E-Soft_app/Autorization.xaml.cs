﻿using E_Soft_app.ApplicationData;
using E_Soft_app.PageAdmin;
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
    /// Interaction logic for Autorization.xaml
    /// </summary>
    public partial class Autorization : Page
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = AppConnect.dataBase_For_App.user_.FirstOrDefault(x => x.login == login_box.Text && x.password == password_box.Password);
                if (userObj == null)
                {
                    MessageBox.Show("Пользователель не найден", "ошибка авторизации 304");
                }
                else
                {
                    switch (userObj.id_role)
                    {
                        case 1: 
                            MessageBox.Show("Вход успешен, Администратор" + userObj.name);
                            NavigationService.Navigate(new PageMenuAdmin());
                            break;
                        case 2:
                            MessageBox.Show("Вход успешен, Пользователь" + userObj.name);
                            break;
                        default:
                            MessageBox.Show("Ошибка");
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка " + Ex.Message.ToString());
            }
        }

        private void Button_Click_Registration(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageCreateAcc());
        }
    }
}
﻿using System;
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

namespace E_Soft_app.PageAdmin
{
    /// <summary>
    /// Interaction logic for PageAccountStudent.xaml
    /// </summary>
    public partial class PageAccountStudent : Page
    {
        public PageAccountStudent()
        {
            InitializeComponent();
            
            //UserList.ItemsSource = Data.MurashkinDB2Entities.GetContext().Users.ToList();
        }
    }
}
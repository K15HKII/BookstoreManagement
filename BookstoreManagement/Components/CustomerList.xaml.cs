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
using BookstoreManagement.Data.Model.Api;

namespace BookstoreManagement.Components
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : UserControl
    {

        public CustomerList()
        {
            InitializeComponent();

            User user = new User()
            {
                FirstName = "a",
                LastName = "b",
<<<<<<< HEAD
                Email = "@gmail.com"
=======
                Email = "@gmail.com",
>>>>>>> a903ef5613d624aea08f683fe505e7ae2bd36909
            };

            itemsControl.ItemsSource = new List<User>() { user, user };
        }
    }
}

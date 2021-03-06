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
using System.Windows.Shapes;

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            
            user.Name = Name.Text;
            user.Surname = Surname.Text;
            user.Age = int.Parse(Age.Text);
            var Radiobutton= Gridpale.Children.OfType<RadioButton>().FirstOrDefault(r => r.IsChecked==true);
            user.Gender = Radiobutton.Name;
            MessageBox.Show(user.Gender);
            Userlist.userList.Add(user);
            
        }
    }
}

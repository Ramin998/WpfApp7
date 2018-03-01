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

namespace WpfApp7
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Register reg = new Register();
            reg.Owner = this;
            reg.Show();
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Owner = this;
            login.Show();
        }
    }
    public class User
    {
        public Guid MyProperty { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
    public class Userlist
    {
        public static List<User> userList = new List<User>();
    }
}

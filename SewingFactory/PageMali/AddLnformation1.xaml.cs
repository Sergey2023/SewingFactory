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
using System.Windows.Shapes;
using SewingFactory.BD;
using SewingFactory.PageMali;

namespace SewingFactory.PageMali
{
    /// <summary>
    /// Логика взаимодействия для AddLnformation1.xaml
    /// </summary>
    public partial class AddLnformation1 : Window
    {
        public AddLnformation1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User userObj = new User()
            {
                Name = tbName.Text,
                Login = tbLogin.Text,
                Password = tbPassword.Text,
                RoleName = tbRole.Text

            };
            DB.eQpBD.User.Add(userObj);
            DB.eQpBD.SaveChanges();
            AddLnformation1 addLnformation1 = new AddLnformation1();
            addLnformation1.Activate();
           
        }
    }
}

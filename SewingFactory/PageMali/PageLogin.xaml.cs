
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
using SewingFactory.BD;

namespace SewingFactory.PageMali
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnReg_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = DB.eQpBD.User.FirstOrDefault(
                x => x.Login == TxbLogin.Text && x.Password ==
                PsbPassword.Password
                );
                if (userObj == null)
                { 
                    MessageBox.Show("Такой пользователь не найден.",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                   FrameApp.frmObj.Navigate(new PageRegistration());
                }
                else
                {

                    switch (userObj.RoleName)
                    {


                        case "admin":
                            MessageBox.Show("Здравствуйте, Админ " + userObj.Login + "  !",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new PageAdmin());
                            break;
                       /* case "Директор  ":
                            MessageBox.Show("Здравствуйте, Директор " + userObj.Login + "  !",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new AccountingMaterials());
                            break;
                        case "User      ":
                            MessageBox.Show("Здравствуйте, пользователь " + userObj.Login + "  !",
                            "Уведомление",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new AccountingMaterials());
                            break;*/


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе приложения: " + ex.Message.ToString(),
                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Register_Click_1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageRegistration());
        }
    }
}

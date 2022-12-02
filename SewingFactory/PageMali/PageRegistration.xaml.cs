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
    /// Логика взаимодействия для PageRegistration.xaml
    /// </summary>
    public partial class PageRegistration : Page
    {
        public PageRegistration()
        {
            InitializeComponent();
        }

        private void EnterTwo_Click(object sender, RoutedEventArgs e)
        {
            string idrole = "User";
            if (DB.eQpBD.User.Count(x => x.Login == TxbLogin.Text) <= 0)
            {

                if (NameYours.Text != "" && TxbLogin.Text != "" && PsbPassword.ToString() != "" && TxbPassword.Text != "")
                {


                    try
                    {
                        User userObj = new User()
                        {
                            Name = NameYours.Text,
                            Login = TxbLogin.Text,
                            Password = PsbPassword.Password,
                            Role = idrole.ToString(),

                        };
                        DB.eQpBD.User.Add(userObj);
                        DB.eQpBD.SaveChanges();
                        MessageBox.Show("Пользователь создан!",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
                        FrameApp.frmObj.Navigate(new PageLogin());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(),
                        "Уведомление Критический сбой работы",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {

                    if (NameYours.Text == "")
                        MessageBox.Show("Заполните поле ФИО",
                       "Уведомление",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);

                    else if (TxbLogin.Text == "")
                    {
                        MessageBox.Show("Заполните поле Логин ",
                       "Уведомление",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);

                    }
                    else if (TxbPassword.Text == "")
                    {
                        MessageBox.Show("Заполните поле пароль ",
                       "Уведомление",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);

                    }
                    else if (PsbPassword.ToString() == "")
                    {
                        MessageBox.Show("Заполните поле подтверждение пароля ",
                       "Уведомление",
                       MessageBoxButton.OK,
                       MessageBoxImage.Information);

                    }
                }
            }
            else
            {
                MessageBox.Show("Такой пользователь уже есть!",

                "Уведомление",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

                return;
            }

        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }
    }
}

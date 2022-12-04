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
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
            /* Materiallist.ItemsSource = DB.eQpBD.User.ToList();*/
            /*Materiallist.ItemsSource = DB.eQpBD.Role.ToList();*/

            Notkol();
        }
        private void UpdateTousrs()
        {
            /*test2.Content = Chon.SelectedIndex;
            if (Chon.SelectedIndex == 0)
            {
                
                Materiallist.ItemsSource = DB.eQpBD.User.Where(x => x.Role == Chon.SelectedIndex).ToList();
                Notkol();
            }

            Materiallist.ItemsSource = DB.eQpBD.User.Where(x => x.Role ==Chon.SelectedIndex).ToList();
            */
            /*Materiallist.ItemsSource = DB.eQpBD.Role.Where(x => x.RoleName ==Convert.ToString( Chon.SelectedIndex)).ToList();*/

            /*Materiallist.ItemsSource = DB.eQpBD.Role.Where(x => x.RoleName == Convert.ToString( Chon.SelectedIndex)).ToList();*/
        }
        public void Notkol()
        {
             dgTodolist.ItemsSource = BD.DB.eQpBD.User.ToList();

        }

        private void Сhoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            
           
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {


            


            Notkol();
        }

      

      

      

      
        private void Chon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateTousrs();
        }

     

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Backspace_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddLnformation1 addLnformation1 = new AddLnformation1();
            addLnformation1.Show();
        }
    }
}

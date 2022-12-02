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
    /// Логика взаимодействия для AccountingMaterials.xaml
    /// </summary>
    public partial class AccountingMaterials : Page
    {
        public AccountingMaterials()
        {
            InitializeComponent();
            Materiallist.ItemsSource = DB.eQpBD.Cloth.ToList();
        }

        private void Сhoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageLogin());
        }

        private void Сhoice_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            Materiallist.ItemsSource = DB.eQpBD.User.Where(x => x.Role == Сhoice.Text).ToList();
        }
    }
}

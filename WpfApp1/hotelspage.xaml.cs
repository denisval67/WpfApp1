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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для hotelspage.xaml
    /// </summary>
    public partial class hotelspage : Page
    {
        public hotelspage()
        {
            InitializeComponent();
            DGridHotels.ItemsSource = praktikEntities.GetContext().Hotel.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager.Mainframe.Navigate(new addeditpage());
        }

        private void BtnEdit_click(object sender, RoutedEventArgs e)
        {
            manager.Mainframe.Navigate(new addeditpage());
        }

        private void BtnAdd_click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Clik(object sender, RoutedEventArgs e)
        {

        }
    }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           
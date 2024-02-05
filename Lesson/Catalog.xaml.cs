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

namespace Lesson
{
    /// <summary>
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog()
        {
            InitializeComponent();
        }

        private void Profile_Click(object sender, RoutedEventArgs e)
        {
            pageChoice.Navigate(new Profile());
        }

        private void ListMaterial_Click(object sender, RoutedEventArgs e)
        {
            pageChoice.Navigate(new PageF());
        }

        private void go_back_click(object sender, RoutedEventArgs e)
        {
            pageChoice.Navigate(new MainWindow());
        }
    }
}

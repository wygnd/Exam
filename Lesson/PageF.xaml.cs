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

namespace Lesson
{
    /// <summary>
    /// Логика взаимодействия для PageF.xaml
    /// </summary>
    public partial class PageF : Page
    {
        public PageF()
        {
            InitializeComponent();
            
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            pageSearch.Navigate(new Catalog());
        }
    }
}

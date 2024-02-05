using Lesson.Properties;
using Microsoft.SqlServer.Server;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Form1 forms = new Form1(login.Text, password.Text);

            string NewLogin = forms.getLogin();
            string NewPassword = forms.getPassword();
            string message = "Добро пожаловать, ";

            if(NewLogin == NewPassword)
            {
                MessageBox.Show(message += NewLogin, "Вход выполнен");
                
                mainFrame.Navigate(new Catalog());
            } else
            {
                MessageBox.Show("Вы ввели неправильный логин или пароль", "Ошибка авторизации");
            }

           
            /* if (login.Text == "user1" && password.Text == "user1")
             {
                 MessageBox.Show("Добро пожаловать user1", "Успешно");
                *//* Form1 form = new Form1();*//*
                 mainFrame.Navigate(new Catalog());
             }
             else if (login.Text == "user2" && password.Text == "user2")
             {
                 MessageBox.Show("Добро пожаловать user2", "Успешно");
                *//* Form1 form = new Form1();*//*
                 mainFrame.Navigate(new Catalog());
             }
             else
             {
                 MessageBox.Show("Вы ввели неправильный логин или пароль", "Ошибка авторизации");
             }*/
        }
             
    }
}     


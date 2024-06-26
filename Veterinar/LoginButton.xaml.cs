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
using System.Windows.Shapes;

namespace Veterinar
{
    /// <summary>
    /// Логика взаимодействия для LoginButton.xaml
    /// </summary>
    public partial class LoginButton : Window
    {
        public LoginButton()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем экземпляр окна MainWindow
            MainWindow mainWindow = new MainWindow();

            // Показываем окно MainWindow
            mainWindow.Show();

            // Закрываем текущее окно (окно авторизации)
            this.Close();
        }

    }
}

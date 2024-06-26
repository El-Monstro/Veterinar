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
    /// Логика взаимодействия для PatientsListWindow.xaml
    /// </summary>
    public partial class PatientsListWindow : Window
    {
        public PatientsListWindow(List<Patient> patients)
        {
            InitializeComponent();
            DataContext = patients;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}

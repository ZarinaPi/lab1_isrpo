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

namespace WpfProject
{
    /// <summary>
    /// Логика взаимодействия для NewWIndow.xaml
    /// </summary>
    public partial class NewWIndow : Window
    {
        public NewWIndow()
        {
            InitializeComponent();
        }

        private void new_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Привет, Мир!");
        }
    }
}

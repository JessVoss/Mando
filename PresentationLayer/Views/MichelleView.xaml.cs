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

namespace MandalorianDB.PresentationLayer
{
    /// <summary>
    /// Interaction logic for MichelleView.xaml
    /// </summary>
    public partial class MichelleView : Window
    {
        public MichelleView()
        {
            InitializeComponent();
        }

        private void ScreenButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

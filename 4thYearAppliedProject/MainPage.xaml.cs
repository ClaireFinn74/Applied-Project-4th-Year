﻿using AppliedProject4thYear.MainPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AppliedProject4thYear
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlay_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnAttention_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AttentionPage));
        }

        private void btnProblemSolving_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

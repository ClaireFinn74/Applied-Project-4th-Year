using AppliedProject4thYear.MemoryLevels;
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

namespace AppliedProject4thYear.MemoryLevels
{
    public sealed partial class MemoryNav : Page
    {
        public MemoryNav()
        {
            this.InitializeComponent();
        }

        private void MainMenuAppBarBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void btnSequential_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Sequential));
        }

        private void btnShoppingList_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(ShoppingList));
        }
        
    }
}

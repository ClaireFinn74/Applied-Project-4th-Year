using _4thYearAppliedProject;
using _4thYearAppliedProject.AttentionLevels;
using AppliedProject4thYear.AttentionLevels;
using System;
using System.Diagnostics;
using System.IO;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppliedProject4thYear.MainPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AttentionPage : Page
    {

        public AttentionPage()
        {
            this.InitializeComponent();
        }

        private void btnAttention_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAttention_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnPorpoise_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void btnPicturePerfect_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnTotalRecall_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TotalRecall));
        }
    }
}

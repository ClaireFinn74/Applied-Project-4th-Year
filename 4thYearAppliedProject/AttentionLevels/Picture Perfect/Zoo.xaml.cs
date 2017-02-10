using AppliedProject4thYear.AttentionLevels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _4thYearAppliedProject.AttentionLevels.Picture_Perect
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Zoo : Page
    {
        public Zoo()
        {
            this.InitializeComponent();
        }

        int btnTappedZebra = 0;
        int btnTappedTwoMonkeys = 0;
        int btnTappedHippo = 0;
        int btnTappedWall = 0;
        int btnTappedElephantEyebrows = 0;
        int btnTappedTiger = 0;

        private async void btnZebra_Click(object sender, RoutedEventArgs e)
        {
            btnTappedZebra++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnZebra.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 53)
            {
                var dialog = new MessageDialog("Well Done, you've completed all 9 levels!" + "\n" + "You've reached your maximum level of attention!!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(PicturePerfect));
            }
        }

        private async void btnTwoMonkeys_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTwoMonkeys++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnTwoMonkeys.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 53)
            {
                var dialog = new MessageDialog("Well Done, you've completed all 9 levels!" + "\n" + "You've reached your maximum level of attention!!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(PicturePerfect));
            }
        }

        private async void btnOrangutang_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Oh no you were so close to the end!" + "\n" + "You've reached your maximum level of attention!!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnThreeTucans_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Oh no you were so close to the end!" + "\n" + "You've reached your maximum level of attention!!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnHippo_Click(object sender, RoutedEventArgs e)
        {
            btnTappedHippo++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnHippo.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 53)
            {
                var dialog = new MessageDialog("Well Done, you've completed all 9 levels!" + "\n" + "You've reached your maximum level of attention!!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(PicturePerfect));
            }
        }

        private async void btnWall_Click(object sender, RoutedEventArgs e)
        {
            btnTappedWall++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnWall.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 53)
            {
                var dialog = new MessageDialog("Well Done, you've completed all 9 levels!" + "\n" + "You've reached your maximum level of attention!!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(PicturePerfect));
            }
        }

        private async void btnElephantEyebrows_Click(object sender, RoutedEventArgs e)
        {
            btnTappedElephantEyebrows++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnElephantEyebrows.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 53)
            {
                var dialog = new MessageDialog("Well Done, you've completed all 9 levels!" + "\n" + "You've reached your maximum level of attention!!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(PicturePerfect));
            }
        }

        private async void btnCheetah_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Oh no you were so close to the end!" + "\n" + "You've reached your maximum level of attention!!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnTiger_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTiger++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnTiger.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 53)
            {
                var dialog = new MessageDialog("Well Done, you've completed all 9 levels!" + "\n" + "You've reached your maximum level of attention!!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
        }

        private async void btnZooKeeper_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Oh no you were so close to the end!" + "\n" + "You've reached your maximum level of attention!!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }
    }
}

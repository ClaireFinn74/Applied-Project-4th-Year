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
    public sealed partial class Tea : Page
    {
        public Tea()
        {
            this.InitializeComponent();
        }

        int btnTappedFiveTeas = 0;
        int btnTappedMilk = 0;
        int btnTappedTeapot = 0;
        int btnTappedBuscuits = 0;
        int btnTappedShirt = 0;
        int btnTappedSugarBowl = 0;
        int btnTappedSun = 0;

        private void btnFiveTeas_Click(object sender, RoutedEventArgs e)
        {
            btnTappedFiveTeas++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnFiveTeas.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 47)
            {
                Frame.Navigate(typeof(PicturePerfect9));
            }
        }

        private async void btnThreeCoffees_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Only two coffees there, they must be tea fans!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnMilk_Click(object sender, RoutedEventArgs e)
        {
            btnTappedMilk++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnMilk.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 47)
            {
                Frame.Navigate(typeof(PicturePerfect9));
            }
        }

        private void btnTeapot_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTeapot++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnTeapot.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 47)
            {
                Frame.Navigate(typeof(PicturePerfect9));
            }
        }

        private async void btnCutlery_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! No cutlery in sight!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnBuscuits_Click(object sender, RoutedEventArgs e)
        {
            btnTappedBuscuits++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnBuscuits.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 47)
            {
                Frame.Navigate(typeof(PicturePerfect9));
            }
        }

        private void btnShirt_Click(object sender, RoutedEventArgs e)
        {
            btnTappedShirt++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnShirt.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 47)
            {
                Frame.Navigate(typeof(PicturePerfect9));
            }
        }

        private async void btnSugar_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! They must have ran out of sugar already!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnSugarBowl_Click(object sender, RoutedEventArgs e)
        {
            btnTappedSugarBowl++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnSugarBowl.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 47)
            {
                Frame.Navigate(typeof(PicturePerfect9));
            }
        }

        private void btnSun_Click(object sender, RoutedEventArgs e)
        {
            btnTappedSun++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnSun.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 47)
            {
                Frame.Navigate(typeof(PicturePerfect9));
            }
        }
    }
}

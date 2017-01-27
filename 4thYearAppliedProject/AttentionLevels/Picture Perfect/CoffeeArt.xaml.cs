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
    public sealed partial class CoffeeArt : Page
    {
        public CoffeeArt()
        {
            this.InitializeComponent();
        }

        int btnTappedSun = 0;
        int btnTappedHeart = 0;
        int btnTappedPlanet = 0;
        int btnTappedFlowers = 0;
        int btnTappedMonkey = 0;
        int btnTappedMoon = 0;

        private void btnLove_Click(object sender, RoutedEventArgs e)
        {
            btnLove.Visibility = Visibility.Collapsed;
        }

        private async void btnCat_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was no Cat in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnTea_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was no Tea in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnStar_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was no Star in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnSun_Click(object sender, RoutedEventArgs e)
        {
            btnTappedSun++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnSun.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnHeart_Click(object sender, RoutedEventArgs e)
        {
            btnTappedHeart++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnHeart.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnPlanet_Click(object sender, RoutedEventArgs e)
        {
            btnTappedPlanet++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnPlanet.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnFlowers_Click(object sender, RoutedEventArgs e)
        {
            btnTappedFlowers++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnFlowers.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnMonkey_Click(object sender, RoutedEventArgs e)
        {
            btnTappedMonkey++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnMonkey.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnMoon_Click(object sender, RoutedEventArgs e)
        {
            btnTappedMoon++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnMoon.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }
}
}

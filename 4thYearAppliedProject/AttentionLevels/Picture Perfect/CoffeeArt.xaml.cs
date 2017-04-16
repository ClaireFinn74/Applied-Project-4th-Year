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
            GlobalClassVariables.gameName = "(Picture Perfect Score) " + "\n";
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
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private async void btnTea_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was no Tea in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private async void btnStar_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was no Star in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnSun_Click(object sender, RoutedEventArgs e)
        {
            btnTappedSun++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnSun.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnHeart_Click(object sender, RoutedEventArgs e)
        {
            btnTappedHeart++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnHeart.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnPlanet_Click(object sender, RoutedEventArgs e)
        {
            btnTappedPlanet++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnPlanet.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnFlowers_Click(object sender, RoutedEventArgs e)
        {
            btnTappedFlowers++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnFlowers.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnMonkey_Click(object sender, RoutedEventArgs e)
        {
            btnTappedMonkey++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnMonkey.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }

        private void btnMoon_Click(object sender, RoutedEventArgs e)
        {
            btnTappedMoon++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnMoon.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 6)
            {
                Frame.Navigate(typeof(PicturePerfect2));
            }
        }
}
}

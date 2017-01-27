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
    public sealed partial class House : Page
    {
        public House()
        {
            this.InitializeComponent();
        }

        int btnTappedChimney = 0;
        int btnTappedFiveHouses = 0;
        int btnTappedFourteenHouseWindows= 0;
        int btnTappedTwoDoors = 0;
        int btnTappedTwoCars = 0;

        private void btnChimney_Click(object sender, RoutedEventArgs e)
        {
            btnTappedChimney++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnChimney.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 17)
            {
                Frame.Navigate(typeof(PicturePerfect4));
            }
        }

        private async void btnCar_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There wasn't just one Car in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnSixHouses_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Guess Again!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnFiveHouses_Click(object sender, RoutedEventArgs e)
        {
            btnTappedFiveHouses++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnFiveHouses.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 17)
            {
                Frame.Navigate(typeof(PicturePerfect4));
            }
        }

        private void btnFourteenHouseWindows_Click(object sender, RoutedEventArgs e)
        {
            btnTappedFourteenHouseWindows++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnFourteenHouseWindows.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 17)
            {
                Frame.Navigate(typeof(PicturePerfect4));
            }
        }

        private async void btnThirteenHouseWindows_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! No, there's actually more!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnTwoDoors_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTwoDoors++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnTwoDoors.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 17)
            {
                Frame.Navigate(typeof(PicturePerfect4));
            }
        }

        private async void btnWoodenFence_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! The fence wasn't wooden!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnFiveBushes_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There were more bushes than that!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnTwoCars_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTwoCars++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnTwoCars.Visibility = Visibility.Collapsed;

            if (GlobalClassAttention.score == 17)
            {
                Frame.Navigate(typeof(PicturePerfect4));
            }
        }
    }
}

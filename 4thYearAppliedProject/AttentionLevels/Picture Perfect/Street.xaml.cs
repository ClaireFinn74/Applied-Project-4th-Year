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
    public sealed partial class Street : Page
    {
        public Street()
        {
            this.InitializeComponent();
        }

        int btnTappedNoThirteenBus = 0;
        int btnTappedLightPost = 0;
        int btnTappedArrow = 0;
        int btnTappedBritishFlag  = 0;
        int btnTappedAustrailianFlag = 0;
        int btnTappedCars = 0;
        int btnTappedWalkers = 0;

        private async void btnSunInSky_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Sadly, no sun!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnNoThirteenBus_Click(object sender, RoutedEventArgs e)
        {
            btnTappedNoThirteenBus++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnNoThirteenBus.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 40)
            {
                Frame.Navigate(typeof(PicturePerfect8));
            }
        }

        private void btnLightPost_Click(object sender, RoutedEventArgs e)
        {
            btnTappedLightPost++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnLightPost.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 40)
            {
                Frame.Navigate(typeof(PicturePerfect8));
            }
        }

        private void btnArrow_Click(object sender, RoutedEventArgs e)
        {
            btnTappedArrow++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnArrow.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 40)
            {
                Frame.Navigate(typeof(PicturePerfect8));
            }
        }

        private async void btnAmericanFlag_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Brush up on that Geography!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnCanadianFlag_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Brush up on that Geography!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            btnTappedCars++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnCars.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 40)
            {
                Frame.Navigate(typeof(PicturePerfect8));
            }
        }

        private void btnWalkers_Click(object sender, RoutedEventArgs e)
        {
            btnTappedWalkers++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnWalkers.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 40)
            {
                Frame.Navigate(typeof(PicturePerfect8));
            }
        }

        private async void btnAeroplane_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Lots of traffic but no Aeroplane in the sky!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnBritishFlag_Click(object sender, RoutedEventArgs e)
        {
            btnTappedBritishFlag++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnBritishFlag.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 40)
            {
                Frame.Navigate(typeof(PicturePerfect8));
            }
        }

        private void btnAustrailianFlag_Click(object sender, RoutedEventArgs e)
        {
            btnTappedAustrailianFlag++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnAustrailianFlag.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 40)
            {
                Frame.Navigate(typeof(PicturePerfect8));
            }
        }
    }
}

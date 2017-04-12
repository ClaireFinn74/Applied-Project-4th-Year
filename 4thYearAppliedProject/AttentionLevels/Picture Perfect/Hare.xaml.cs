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
    public sealed partial class Hare : Page
    {
        public Hare()
        {
            GlobalClassVariables.gameName = "(Picture Perfect Score) " + "\n";
            this.InitializeComponent();
        }

        int btnTappedEye = 0;
        int btnTappedBlackFur = 0;
        int btnTappedGrass = 0;
        int btnTappedClay = 0;
        int btnTappedNose = 0;
        int btnTappedWhiskers = 0;


        private void btnEye_Click(object sender, RoutedEventArgs e)
        {
            btnTappedEye++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnEye.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 12)
            {
                Frame.Navigate(typeof(PicturePerfect3));
            }
        }

        private void btnBlackFur_Click(object sender, RoutedEventArgs e)
        {
            btnTappedBlackFur++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnBlackFur.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 12)
            {
                Frame.Navigate(typeof(PicturePerfect3));
            }
        }

        private async void btnBrownFur_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was no Brown Fur in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnGrass_Click(object sender, RoutedEventArgs e)
        {
            btnTappedGrass++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnGrass.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 12)
            {
                Frame.Navigate(typeof(PicturePerfect3));
            }
        }

        private void btnClay_Click(object sender, RoutedEventArgs e)
        {
            btnTappedClay++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnClay.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 12)
            {
                Frame.Navigate(typeof(PicturePerfect3));
            }
        }

        private async void btnFeet_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There is no feet, only paws, in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private async void btnRabbit_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! That was a HARE in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private async void btnSun_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was no Sun in the picture!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnNose_Click(object sender, RoutedEventArgs e)
        {
            btnTappedNose++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnNose.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 12)
            {
                Frame.Navigate(typeof(PicturePerfect3));
            }
        }

        private void btnWhiskers_Click(object sender, RoutedEventArgs e)
        {
            btnTappedWhiskers++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnWhiskers.Visibility = Visibility.Collapsed;

            if (GlobalClassVariables.score == 12)
            {
                Frame.Navigate(typeof(PicturePerfect3));
            }
        }
    }
}

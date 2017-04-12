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
    public sealed partial class SickBoy : Page
    {
        public SickBoy()
        {
            GlobalClassVariables.gameName = "(Picture Perfect Score) " + "\n";
            this.InitializeComponent();
        }

        int btnTappedStethoscope = 0;
        int btnTappedTwoBears = 0;
        int btnTappedGlasses = 0;
        int btnTappedTwoPaws = 0;
        int btnTappedWhiteSocks = 0;
        int btnTappedBluePjs = 0;

        private async void btnBear_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Look closer at the boy, there's another bear there too!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnStethoscope_Click(object sender, RoutedEventArgs e)
        {
            btnTappedStethoscope++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnStethoscope.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 28)
            {
                Frame.Navigate(typeof(PicturePerfect6));
            }
        }

        private void btnTwoBears_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTwoBears++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnTwoBears.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 28)
            {
                Frame.Navigate(typeof(PicturePerfect6));
            }
        }

        private void btnGlasses_Click(object sender, RoutedEventArgs e)
        {
            btnTappedGlasses++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnGlasses.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 28)
            {
                Frame.Navigate(typeof(PicturePerfect6));
            }
        }

        private async void btnTwoHands_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was only one hand showing!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnTwoPaws_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTwoPaws++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnTwoPaws.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 28)
            {
                Frame.Navigate(typeof(PicturePerfect6));
            }
        }

        private void btnWhiteSocks_Click(object sender, RoutedEventArgs e)
        {
            btnTappedWhiteSocks++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnWhiteSocks.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 28)
            {
                Frame.Navigate(typeof(PicturePerfect6));
            }
        }

        private async void btnFreckles_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There were no freckles, must be winter-time!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private async void btnTwoEars_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was only one ear showing!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnBluePjs_Click(object sender, RoutedEventArgs e)
        {
            btnTappedBluePjs++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnBluePjs.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 28)
            {
                Frame.Navigate(typeof(PicturePerfect6));
            }
        }
    }
}

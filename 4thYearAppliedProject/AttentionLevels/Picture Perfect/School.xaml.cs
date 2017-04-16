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
    public sealed partial class School : Page
    {
        public School()
        {
            GlobalClassVariables.gameName = "(Picture Perfect Score) " + "\n";
            this.InitializeComponent();
        }

        int btnTappedRedBook = 0;
        int btnTappedLeaf = 0;
        int btnTappedApple = 0;
        int btnTappedBlueBook = 0;
        int btnTappedTable = 0;

        private void btnRedBook_Click(object sender, RoutedEventArgs e)
        {
            btnTappedRedBook++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnRedBook.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 22)
            {
                Frame.Navigate(typeof(PicturePerfect5));
            }
        }

        private async void btnBrownBook_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There was a similar-looking red book, but no brown one!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnLeaf_Click(object sender, RoutedEventArgs e)
        {
            btnTappedLeaf++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnLeaf.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 22)
            {
                Frame.Navigate(typeof(PicturePerfect5));
            }
        }

        private async void btnTwoChalks_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There were more chalks than that!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnApple_Click(object sender, RoutedEventArgs e)
        {
            btnTappedApple++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnApple.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 22)
            {
                Frame.Navigate(typeof(PicturePerfect5));
            }
        }

        private async void btnWhiteBoard_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Nope, just a good old-fashioned chalkboard!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnBlueBook_Click(object sender, RoutedEventArgs e)
        {
            btnTappedBlueBook++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnBlueBook.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 22)
            {
                Frame.Navigate(typeof(PicturePerfect5));
            }
        }

        private async void btnWritingOnBoard_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Where did you see writing? Was it in invisible ink?!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTable++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();
            btnTable.Visibility = Visibility.Collapsed;
            if (GlobalClassVariables.score == 22)
            {
                Frame.Navigate(typeof(PicturePerfect5));
            }
        }

        private async void btnFourBooks_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
        }
    }
}

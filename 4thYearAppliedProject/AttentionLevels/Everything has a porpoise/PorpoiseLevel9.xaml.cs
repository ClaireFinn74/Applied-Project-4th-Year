using AppliedProject4thYear;
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

namespace _4thYearAppliedProject.AttentionLevels.Everything_has_a_porpoise
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PorpoiseLevel9 : Page
    {
        public PorpoiseLevel9()
        {
            this.InitializeComponent();
            GlobalClassVariables.gameName = "(Everything Has A Porpoise Score) " + "\n";
            sbPorpoiseLevel1.Begin();
            sbPorpoiseLevel2.Begin();
            sbPorpoiseLevel3.Begin();
            sbPorpoiseLevel4.Begin();
            sbPorpoiseLevel5.Begin();
            sbPorpoiseLevel6.Begin();
            sbPorpoiseLevel7.Begin();
            sbPorpoiseLevel8.Begin();
            sbPorpoiseLevel9.Begin();
        }

        int porpoiseTapped1 = 0;
        int porpoiseTapped2 = 0;
        int porpoiseTapped3 = 0;
        int porpoiseTapped4 = 0;
        int porpoiseTapped5 = 0;
        int porpoiseTapped6 = 0;
        int porpoiseTapped7 = 0;
        int porpoiseTapped8 = 0;
        int porpoiseTapped9 = 0;
        int porpoiseTapped10 = 0;
        int porpoiseTapped11 = 0;

        //Make the event async in order to allow message dialog boxes
        private async void imgporpoise_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Make all variables global to allow them to be used in any page
            porpoiseTapped1++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassVariables.score == 63)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                //To reuse the first 6 images in level 5 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            //Otherwise, If the image is tapped twice the game ends
            else if (porpoiseTapped1 == 2)
            {
                //Message box displays
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped2++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassVariables.score == 63)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                //To reuse the first 6 images in level 5 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped2 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped3++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassVariables.score == 63)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                //To reuse the first 6 images in level 5 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped3 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped4++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();

                //To reuse the first 4 images in level 3 we need to set the values back to 0 so they are unclicked
                //To reuse the first 6 images in level 5 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));

            }
            else if (porpoiseTapped4 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped5++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                //To reuse the first 5 images in level 4 we need to set the values back to 0 so they are unclicked
                //To reuse the first 6 images in level 5 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped5 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped6++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                //To reuse the first 6 images in level 5 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped6 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped7++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                //To reuse the first 7 images in level 6 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped7 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped8++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                //To reuse the first 8 images in level 7 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped8 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped9++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                //To reuse the first 9 images in level 8 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped9 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped10++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                //To reuse the first 10 images in level 9 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped10 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }

        private async void imgporpoise11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped11++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            if (GlobalClassVariables.score == 63)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                //To reuse the first 11 images in level 10 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                Frame.Navigate(typeof(PorpoiseLevel10));
            }
            else if (porpoiseTapped11 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }
    }
}

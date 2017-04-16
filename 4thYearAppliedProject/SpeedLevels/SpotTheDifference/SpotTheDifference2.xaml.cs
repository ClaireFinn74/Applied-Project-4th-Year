using _4thYearAppliedProject;
using _4thYearAppliedProject.SpeedLevels.SpotTheDifference;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppliedProject4thYear.SpeedLevels.SpotTheDifference
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpotTheDifference2 : Page
    {
        public SpotTheDifference2()
        {
            GlobalClassVariables.gameName = "(Spot The Difference Score) ";
            this.InitializeComponent();
            DispatcherTimerSetup();
            Random random = new Random();
            txtHighscore.Text = GlobalClassSpotted.globalHighscore.ToString();
            Image[] ImageArray = { Spot1, Spot2, Spot3, Spot4 };
            Image ImgSpot = ImageArray[random.Next(0, ImageArray.Length)];

            if (ImgSpot == Spot1)
            {
                Spot1.Visibility = Visibility.Collapsed;
                Image[] ImageArrayDifference = { Spot1Difference, Spot1Difference2, Spot1Difference3, Spot1Difference4, Spot1Difference5, Spot1Difference6 };
                Image ImgSpotDifference = ImageArrayDifference[random.Next(0, ImageArray.Length)];
                if (ImgSpotDifference == Spot1Difference)
                {
                    Spot1Difference.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference == Spot1Difference2)
                {
                    Spot1Difference2.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference == Spot1Difference3)
                {
                    Spot1Difference3.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference == Spot1Difference4)
                {
                    Spot1Difference4.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference == Spot1Difference5)
                {
                    Spot1Difference5.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference == Spot1Difference6)
                {
                    Spot1Difference6.Visibility = Visibility.Visible;
                }
            }

            else if (ImgSpot == Spot2)
            {
                Spot2.Visibility = Visibility.Collapsed;
                Image[] ImageArrayDifference2 = { Spot2Difference, Spot2Difference2, Spot2Difference3, Spot2Difference4, Spot2Difference5, Spot2Difference6 };
                Image ImgSpotDifference2 = ImageArrayDifference2[random.Next(0, ImageArray.Length)];
                if (ImgSpotDifference2 == Spot2Difference)
                {
                    Spot2Difference2.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference2 == Spot2Difference2)
                {
                    Spot2Difference2.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference2 == Spot2Difference3)
                {
                    Spot2Difference3.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference2 == Spot2Difference4)
                {
                    Spot2Difference4.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference2 == Spot2Difference5)
                {
                    Spot2Difference5.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference2 == Spot2Difference6)
                {
                    Spot2Difference6.Visibility = Visibility.Visible;
                }
            }
            else if (ImgSpot == Spot3)
            {
                Spot3.Visibility = Visibility.Collapsed;
                Image[] ImageArrayDifference3 = { Spot3Difference, Spot3Difference2, Spot3Difference3, Spot3Difference4, Spot3Difference5, Spot3Difference6 };
                Image ImgSpotDifference3 = ImageArrayDifference3[random.Next(0, ImageArray.Length)];
                if (ImgSpotDifference3 == Spot3Difference)
                {
                    Spot3Difference.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference3 == Spot3Difference2)
                {
                    Spot3Difference2.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference3 == Spot3Difference3)
                {
                    Spot3Difference3.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference3 == Spot3Difference4)
                {
                    Spot3Difference4.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference3 == Spot3Difference5)
                {
                    Spot3Difference5.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference3 == Spot3Difference6)
                {
                    Spot3Difference6.Visibility = Visibility.Visible;
                }

            }

            else if (ImgSpot == Spot4)
            {
                Spot4.Visibility = Visibility.Collapsed;
                Image[] ImageArrayDifference4 = { Spot4Difference, Spot4Difference2, Spot4Difference3, Spot4Difference4, Spot4Difference5, Spot4Difference6 };
                Image ImgSpotDifference4 = ImageArrayDifference4[random.Next(0, ImageArray.Length)];
                if (ImgSpotDifference4 == Spot4Difference)
                {
                    Spot4Difference.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference4 == Spot4Difference2)
                {
                    Spot4Difference2.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference4 == Spot4Difference3)
                {
                    Spot4Difference3.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference4 == Spot4Difference4)
                {
                    Spot4Difference4.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference4 == Spot4Difference5)
                {
                    Spot4Difference5.Visibility = Visibility.Visible;
                }
                else if (ImgSpotDifference4 == Spot4Difference6)
                {
                    Spot4Difference6.Visibility = Visibility.Visible;
                }

            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpeedLevelsMainPage));
        }

        private async void Spot1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassVariables.score = GlobalClassSpotted.globalHighscore;
            var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! That one isn't different but hey you got:" + GlobalClassSpotted.globalHighscore);
            var result = await dialog.ShowAsync();
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SQLiteScores));
        }
        private async void Spot2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassVariables.score = GlobalClassSpotted.globalHighscore;
            var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! That one isn't different but hey you got:" + GlobalClassSpotted.globalHighscore);
            var result = await dialog.ShowAsync();
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SQLiteScores));
        }

        private async void Spot3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassVariables.score = GlobalClassSpotted.globalHighscore;
            var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! That one isn't different but hey you got:" + GlobalClassSpotted.globalHighscore);
            var result = await dialog.ShowAsync();
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SQLiteScores));
        }

        private async void Spot4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassVariables.score = GlobalClassSpotted.globalHighscore;
            var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! That one isn't different but hey you got:" + GlobalClassSpotted.globalHighscore);
            var result = await dialog.ShowAsync();
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SQLiteScores));
        }

        private void Spot1Difference_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot1Difference2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot1Difference3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot1Difference4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot1Difference5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot1Difference6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot2Difference_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot2Difference2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot2Difference3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot2Difference4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot2Difference5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot2Difference6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot3Difference_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot3Difference2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot3Difference3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot3Difference4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot3Difference5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot3Difference6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot4Difference_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot4Difference2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot4Difference3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot4Difference4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot4Difference5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        private void Spot4Difference6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            GlobalClassSpotted.globalHighscore++;
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpotTheDifference2));
        }

        DispatcherTimer dispatcherTimer;
        int timesTicked = 15;
        int timesToTick = 15;
        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        async void dispatcherTimer_Tick(object sender, object e)
        {
            TimerLog.Text = timesTicked.ToString();
            if (timesTicked > timesToTick)
            {
                TimerStatus.Text = "Calling dispatcherTimer.Stop()\n";
                dispatcherTimer.Stop();
                TimerStatus.Text = "dispatcherTimer.IsEnabled = " + dispatcherTimer.IsEnabled + "\n";
            }
            timesTicked--;

            if (timesTicked == -1)
            {
                GlobalClassVariables.score = GlobalClassSpotted.globalHighscore;
                dispatcherTimer.Stop(); // stops timer going below 0
                var dialog = new Windows.UI.Popups.MessageDialog
                ("Out of time! You scored a total of: " + GlobalClassSpotted.globalHighscore);
                var result = await dialog.ShowAsync();
                this.Frame.Navigate(typeof(SQLiteScores), null);
            }
        }

        private async void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "So to play SpotTheDifference all you have to do is study the images provided and then look for the odd one out in the bunch. Try to get as many right as quickly as possible");
            var result = await dialog.ShowAsync();
        }
    }
}

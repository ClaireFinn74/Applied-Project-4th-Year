using AppliedProject4thYear.SpeedLevels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _4thYearAppliedProject.SpeedLevels.GoWithTheBuffLow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GoWithTheBuffLowLvl2 : Page
    {
        public int randomNumGen;
        public int randomNumGen2;

        public GoWithTheBuffLowLvl2()
        {
            GlobalClassVariables.gameName = "(Go With The BuffLow Score) " + "\n";
            this.InitializeComponent();
            DispatcherTimerSetup();
            Random random = new Random();
            txtHighscore.Text = GlobalClassBuffLow.globalHighscore.ToString();
            int[] intArray = { 2, 4, 6, 8, 10, 12 };
            int RandomNumGen = intArray[random.Next(0, intArray.Length)];

            if (RandomNumGen % 2 == 0)
            {
                if (RandomNumGen == 2)
                {
                    Side1Buffalo1.Visibility = Visibility.Visible;
                    Side1Buffalo2.Visibility = Visibility.Visible;
                    randomNumGen = RandomNumGen;
                    txtSide1.Text = RandomNumGen.ToString();
                }

                else if (RandomNumGen == 4)
                {
                    Side1Buffalo1.Visibility = Visibility.Visible;
                    Side1Buffalo2.Visibility = Visibility.Visible;
                    Side1Buffalo3.Visibility = Visibility.Visible;
                    Side1Buffalo4.Visibility = Visibility.Visible;
                    randomNumGen = RandomNumGen;
                    txtSide1.Text = RandomNumGen.ToString();
                }

                else if (RandomNumGen == 6)
                {
                    Side1Buffalo1.Visibility = Visibility.Visible;
                    Side1Buffalo2.Visibility = Visibility.Visible;
                    Side1Buffalo3.Visibility = Visibility.Visible;
                    Side1Buffalo4.Visibility = Visibility.Visible;
                    Side1Buffalo5.Visibility = Visibility.Visible;
                    Side1Buffalo6.Visibility = Visibility.Visible;
                    randomNumGen = RandomNumGen;
                    txtSide1.Text = RandomNumGen.ToString();
                }

                else if (RandomNumGen == 8)
                {
                    Side1Buffalo1.Visibility = Visibility.Visible;
                    Side1Buffalo2.Visibility = Visibility.Visible;
                    Side1Buffalo3.Visibility = Visibility.Visible;
                    Side1Buffalo4.Visibility = Visibility.Visible;
                    Side1Buffalo5.Visibility = Visibility.Visible;
                    Side1Buffalo6.Visibility = Visibility.Visible;
                    Side1Buffalo7.Visibility = Visibility.Visible;
                    Side1Buffalo8.Visibility = Visibility.Visible;
                    randomNumGen = RandomNumGen;
                    txtSide1.Text = RandomNumGen.ToString();
                }

                else if (RandomNumGen == 10)
                {
                    Side1Buffalo1.Visibility = Visibility.Visible;
                    Side1Buffalo2.Visibility = Visibility.Visible;
                    Side1Buffalo3.Visibility = Visibility.Visible;
                    Side1Buffalo4.Visibility = Visibility.Visible;
                    Side1Buffalo5.Visibility = Visibility.Visible;
                    Side1Buffalo6.Visibility = Visibility.Visible;
                    Side1Buffalo7.Visibility = Visibility.Visible;
                    Side1Buffalo8.Visibility = Visibility.Visible;
                    Side1Buffalo9.Visibility = Visibility.Visible;
                    Side1Buffalo10.Visibility = Visibility.Visible;
                    randomNumGen = RandomNumGen;
                    txtSide1.Text = RandomNumGen.ToString();
                }

                else if (RandomNumGen == 12)
                {
                    Side1Buffalo1.Visibility = Visibility.Visible;
                    Side1Buffalo2.Visibility = Visibility.Visible;
                    Side1Buffalo3.Visibility = Visibility.Visible;
                    Side1Buffalo4.Visibility = Visibility.Visible;
                    Side1Buffalo5.Visibility = Visibility.Visible;
                    Side1Buffalo6.Visibility = Visibility.Visible;
                    Side1Buffalo7.Visibility = Visibility.Visible;
                    Side1Buffalo8.Visibility = Visibility.Visible;
                    Side1Buffalo9.Visibility = Visibility.Visible;
                    Side1Buffalo10.Visibility = Visibility.Visible;
                    Side1Buffalo11.Visibility = Visibility.Visible;
                    Side1Buffalo12.Visibility = Visibility.Visible;
                    randomNumGen = RandomNumGen;
                    txtSide1.Text = RandomNumGen.ToString();
                }


                int[] intArray2 = { 2, 4, 6, 8, 10, 12 };
                int RandomNumGen2 = intArray2[random.Next(0, intArray2.Length)];

                if (RandomNumGen2 == 2)
                {
                    Side2Buffalo1.Visibility = Visibility.Visible;
                    Side2Buffalo2.Visibility = Visibility.Visible;
                    randomNumGen2 = RandomNumGen2;
                    txtSide2.Text = RandomNumGen2.ToString();
                }

                else if (RandomNumGen2 == 4)
                {
                    Side2Buffalo1.Visibility = Visibility.Visible;
                    Side2Buffalo2.Visibility = Visibility.Visible;
                    Side2Buffalo3.Visibility = Visibility.Visible;
                    Side2Buffalo4.Visibility = Visibility.Visible;
                    randomNumGen2 = RandomNumGen2;
                    txtSide2.Text = RandomNumGen2.ToString();
                }

                else if (RandomNumGen2 == 6)
                {
                    Side2Buffalo1.Visibility = Visibility.Visible;
                    Side2Buffalo2.Visibility = Visibility.Visible;
                    Side2Buffalo3.Visibility = Visibility.Visible;
                    Side2Buffalo4.Visibility = Visibility.Visible;
                    Side2Buffalo5.Visibility = Visibility.Visible;
                    Side2Buffalo6.Visibility = Visibility.Visible;
                    randomNumGen2 = RandomNumGen2;
                    txtSide2.Text = RandomNumGen2.ToString();
                }

                else if (RandomNumGen2 == 8)
                {
                    Side2Buffalo1.Visibility = Visibility.Visible;
                    Side2Buffalo2.Visibility = Visibility.Visible;
                    Side2Buffalo3.Visibility = Visibility.Visible;
                    Side2Buffalo4.Visibility = Visibility.Visible;
                    Side2Buffalo5.Visibility = Visibility.Visible;
                    Side2Buffalo6.Visibility = Visibility.Visible;
                    Side2Buffalo7.Visibility = Visibility.Visible;
                    Side2Buffalo8.Visibility = Visibility.Visible;
                    randomNumGen2 = RandomNumGen2;
                    txtSide2.Text = RandomNumGen2.ToString();
                }

                else if (RandomNumGen2 == 10)
                {
                    Side2Buffalo1.Visibility = Visibility.Visible;
                    Side2Buffalo2.Visibility = Visibility.Visible;
                    Side2Buffalo3.Visibility = Visibility.Visible;
                    Side2Buffalo4.Visibility = Visibility.Visible;
                    Side2Buffalo5.Visibility = Visibility.Visible;
                    Side2Buffalo6.Visibility = Visibility.Visible;
                    Side2Buffalo7.Visibility = Visibility.Visible;
                    Side2Buffalo8.Visibility = Visibility.Visible;
                    Side2Buffalo9.Visibility = Visibility.Visible;
                    Side2Buffalo10.Visibility = Visibility.Visible;
                    randomNumGen2 = RandomNumGen2;
                    txtSide2.Text = RandomNumGen2.ToString();
                }

                else if (RandomNumGen2 == 12)
                {
                    Side2Buffalo1.Visibility = Visibility.Visible;
                    Side2Buffalo2.Visibility = Visibility.Visible;
                    Side2Buffalo3.Visibility = Visibility.Visible;
                    Side2Buffalo4.Visibility = Visibility.Visible;
                    Side2Buffalo5.Visibility = Visibility.Visible;
                    Side2Buffalo6.Visibility = Visibility.Visible;
                    Side2Buffalo7.Visibility = Visibility.Visible;
                    Side2Buffalo8.Visibility = Visibility.Visible;
                    Side2Buffalo9.Visibility = Visibility.Visible;
                    Side2Buffalo10.Visibility = Visibility.Visible;
                    Side2Buffalo11.Visibility = Visibility.Visible;
                    Side2Buffalo12.Visibility = Visibility.Visible;
                    randomNumGen2 = RandomNumGen2;
                    txtSide2.Text = RandomNumGen2.ToString();
                }
            }
            else
            {
                Frame.Navigate(typeof(GoWithTheBuffLowLvl2));
            }
        }

        DispatcherTimer dispatcherTimer;
        int timesTicked = 10;
        int timesToTick = 10;

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
                GlobalClassVariables.score = GlobalClassBuffLow.globalHighscore;
                dispatcherTimer.Stop(); // stops timer going below 0
                var dialog = new Windows.UI.Popups.MessageDialog
                ("Out of time! You scored a total of: " + GlobalClassBuffLow.globalHighscore);
                var result = await dialog.ShowAsync();
                this.Frame.Navigate(typeof(SQLiteScores), null);
            }
        }

        private async void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "So to play GoWithTheBuffLow all you have to do is match the number of buffalo on one side to the number on the other (E.G) The game starts with 6 buffalo on the left and 4 on the right then move one buffalo from the left to the right so there is 5 on each side). Try to get as many right as quickly as possible as there is limited time to get the buffalo");
            var result = await dialog.ShowAsync();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpeedLevelsMainPage));
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            if (txtSide1.Text == txtSide2.Text)
            {
                GlobalClassBuffLow.globalHighscore += 10;
                dispatcherTimer.Stop();
                this.Frame.Navigate(typeof(GoWithTheBuffLowLvl2), null);
            }
            else
            {
                timesTicked = timesTicked - 3;
                timesToTick = timesToTick - 3;
            }
        }

        private void Side1Buffalo4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 4)
            {
                Side1Buffalo4.Visibility = Visibility.Collapsed;
                Side2Buffalo3.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side1Buffalo6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 6)
            {
                Side1Buffalo6.Visibility = Visibility.Collapsed;
                Side2Buffalo5.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side1Buffalo8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 8)
            {
                Side1Buffalo8.Visibility = Visibility.Collapsed;
                Side2Buffalo7.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side1Buffalo10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 10)
            {
                Side1Buffalo10.Visibility = Visibility.Collapsed;
                Side2Buffalo9.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side1Buffalo12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 12)
            {
                Side1Buffalo12.Visibility = Visibility.Collapsed;
                Side2Buffalo11.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side1Buffalo5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 5)
            {
                Side1Buffalo5.Visibility = Visibility.Collapsed;
                Side2Buffalo4.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side1Buffalo7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 7)
            {
                Side1Buffalo7.Visibility = Visibility.Collapsed;
                Side2Buffalo6.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do not
            }
        }

        private void Side1Buffalo9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 9)
            {
                Side1Buffalo9.Visibility = Visibility.Collapsed;
                Side2Buffalo8.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do not
            }
        }

        private void Side1Buffalo11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen2 < 11)
            {
                Side1Buffalo11.Visibility = Visibility.Collapsed;
                Side2Buffalo10.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen - 1;
                randomNumGen2 = randomNumGen2 + 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do not
            }
        }

        private void Side2Buffalo4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 4)
            {
                Side2Buffalo4.Visibility = Visibility.Collapsed;
                Side1Buffalo3.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 6)
            {
                Side2Buffalo6.Visibility = Visibility.Collapsed;
                Side1Buffalo5.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 8)
            {
                Side2Buffalo8.Visibility = Visibility.Collapsed;
                Side1Buffalo7.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 10)
            {
                Side2Buffalo10.Visibility = Visibility.Collapsed;
                Side1Buffalo9.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 12)
            {
                Side2Buffalo12.Visibility = Visibility.Collapsed;
                Side1Buffalo11.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 5)
            {
                Side2Buffalo5.Visibility = Visibility.Collapsed;
                Side1Buffalo4.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 7)
            {
                Side2Buffalo7.Visibility = Visibility.Collapsed;
                Side1Buffalo6.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 9)
            {
                Side2Buffalo9.Visibility = Visibility.Collapsed;
                Side1Buffalo8.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }

        private void Side2Buffalo11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (randomNumGen < 11)
            {
                Side2Buffalo11.Visibility = Visibility.Collapsed;
                Side1Buffalo10.Visibility = Visibility.Visible;
                randomNumGen = randomNumGen + 1;
                randomNumGen2 = randomNumGen2 - 1;
                txtSide1.Text = randomNumGen.ToString();
                txtSide2.Text = randomNumGen2.ToString();
            }
            else
            {
                //do nothing
            }
        }
    }
}
   
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

namespace _4thYearAppliedProject.SpeedLevels.FoalShadow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated ToString within a Frame.
    /// </summary>
    public sealed partial class FoalShadowLvl7 : Page
    {

             
        public FoalShadowLvl7()
        {
            this.InitializeComponent();
            DispatcherTimerSetup();
            Random random = new Random();
            txtImgResult1.Text = GlobalClass.globalImgResultTxt.ToString();
            txtHighscore.Text = GlobalClass.globalHighscore.ToString();
            Image[] ImageArray = { Bear, Bear2, BearFlipped, Bear3 };
            Image ImgResult2 = ImageArray[random.Next(0, ImageArray.Length)];

            if (ImgResult2 == Bear)
            {
                Bear.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Bear";
            }

            else if (ImgResult2 == Bear2)
            {
                Bear2.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Bear2";
            }

            else if (ImgResult2 == BearFlipped)
            {
                BearFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "BearFlipped";
            }

            else if (ImgResult2 == Bear3)
            {
                Bear3.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Bear3";
            }



            btnYes.Visibility = Visibility.Visible;
            btnNo.Visibility = Visibility.Visible;
            //return ImgResult2.ToString;
            //txtImgResult2.Text = ImgResult2.ToString();
            

        }

        DispatcherTimer dispatcherTimer;
        int timesTicked = 5;
        int timesToTick = 5;
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
                dispatcherTimer.Stop(); // stops timer going below 0
                var dialog = new Windows.UI.Popups.MessageDialog
                ("Out of time! You scored a total of: " + GlobalClass.globalHighscore);
                var result = await dialog.ShowAsync();
                this.Frame.Navigate(typeof(SpeedLevelsMainPage), null);
            }
        }
        /*private void TimerStart_Click_1(object sender, RoutedEventArgs e)
        {
            DispatcherTimerSetup();
        }

        private void TimerStop_Click_1(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
        }
        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {
            TimerStatus.Text = "dispatcherTimer.IsEnabled = False";
        }*/


        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Stop();
            Frame.Navigate(typeof(SpeedLevelsMainPage));
        }

        public async void btnYes_Click(object sender, RoutedEventArgs e)
        {
            if (txtImgResult1.Text == txtImgResult2.Text)
            {
                GlobalClass.globalHighscore++;
                txtHighscore.Text = GlobalClass.globalHighscore.ToString();
                if (txtImgResult2.Text == "Bear")
                {
                    GlobalClass.globalImgResultTxt = "Bear";
                }

                else if (txtImgResult2.Text == "Bear2")
                {
                    GlobalClass.globalImgResultTxt = "Bear2";
                }

                else if (txtImgResult2.Text == "BearFlipped")
                {
                    GlobalClass.globalImgResultTxt = "BearFlipped";
                }

                else if (txtImgResult2.Text == "Bear3")
                {
                    GlobalClass.globalImgResultTxt = "Bear3";
                }
                dispatcherTimer.Stop();
                Frame.Navigate(typeof(FoalShadowLvl6));
            }

            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! Looks like you've lost but hey you got:" + GlobalClass.globalHighscore);
                var result = await dialog.ShowAsync();
                dispatcherTimer.Stop();
                Frame.Navigate(typeof(SpeedLevelsMainPage));
            }

        }

        private async void btnNo_Click(object sender, RoutedEventArgs e)
        {
            if (txtImgResult1.Text != txtImgResult2.Text)
            {
                GlobalClass.globalHighscore++;
                txtHighscore.Text = GlobalClass.globalHighscore.ToString();
                if (txtImgResult2.Text == "Bear")
                {
                    GlobalClass.globalImgResultTxt = "Bear";
                }

                else if (txtImgResult2.Text == "Bear2")
                {
                    GlobalClass.globalImgResultTxt = "Bear2";
                }

                else if (txtImgResult2.Text == "BearFlipped")
                {
                    GlobalClass.globalImgResultTxt = "BearFlipped";
                }

                else if (txtImgResult2.Text == "Bear3")
                {
                    GlobalClass.globalImgResultTxt = "Bear3";
                }
                dispatcherTimer.Stop();
                Frame.Navigate(typeof(FoalShadowLvl6));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! Looks like you've lost but hey you got:" + GlobalClass.globalHighscore);
                var result = await dialog.ShowAsync();
                dispatcherTimer.Stop();
                Frame.Navigate(typeof(SpeedLevelsMainPage));
            }
        }

        private async void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Windows.UI.Popups.MessageDialog(
                "So to play FoalShadow all you have ToString do is study the images provided and then say if the next image is the exact same. Get as many right in the time provided as possible");
            var result = await dialog.ShowAsync();
        }
    }
}

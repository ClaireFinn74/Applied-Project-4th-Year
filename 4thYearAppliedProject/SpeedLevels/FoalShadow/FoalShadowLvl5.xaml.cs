using _4thYearAppliedProject;
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
    public sealed partial class FoalShadowLvl5 : Page
    {
             
        public FoalShadowLvl5()
        {
            GlobalClassVariables.gameName = "(Foal Shadow Score) " + "\n";
            this.InitializeComponent();

            Random random = new Random();
            txtImgResult1.Text = GlobalClass.globalImgResultTxt.ToString();
            txtHighscore.Text = GlobalClass.globalHighscore.ToString();
            Image[] ImageArray = { Bear, Deer, FoalShadowHorse, Wolf };
            Image ImgResult2 = ImageArray[random.Next(0, ImageArray.Length)];

            if (ImgResult2 == Bear)
            {
                Bear.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Bear";
            }

            else if (ImgResult2 == Deer)
            {
                Deer.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Deer";
            }

            else if (ImgResult2 == FoalShadowHorse)
            {
                FoalShadowHorse.Visibility = Visibility.Visible;
                txtImgResult2.Text = "FoalShadowHorse";
            }

            else if (ImgResult2 == Wolf)
            {
                Wolf.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Wolf";
            }



            btnYes.Visibility = Visibility.Visible;
            btnNo.Visibility = Visibility.Visible;
            //return ImgResult2.ToString;
            //txtImgResult2.Text = ImgResult2.ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
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

                else if (txtImgResult2.Text == "Deer")
                {
                    GlobalClass.globalImgResultTxt = "Deer";
                }

                else if (txtImgResult2.Text == "FoalShadowHorse")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowHorse";
                }

                else if (txtImgResult2.Text == "Wolf")
                {
                    GlobalClass.globalImgResultTxt = "Wolf";
                }
                Frame.Navigate(typeof(FoalShadowLvl6));
            }

            else
            {
                GlobalClassVariables.score = GlobalClass.globalHighscore;
                var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! Looks like you've lost but hey you got:" + GlobalClass.globalHighscore);
                var result = await dialog.ShowAsync();
                Frame.Navigate(typeof(SQLiteScores));
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

                else if (txtImgResult2.Text == "Deer")
                {
                    GlobalClass.globalImgResultTxt = "Deer";
                }

                else if (txtImgResult2.Text == "FoalShadowHorse")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowHorse";
                }

                else if (txtImgResult2.Text == "Wolf")
                {
                    GlobalClass.globalImgResultTxt = "Wolf";
                }
                Frame.Navigate(typeof(FoalShadowLvl6));
            }
            else
            {
                GlobalClassVariables.score = GlobalClass.globalHighscore;
                var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! Looks like you've lost but hey you got:" + GlobalClass.globalHighscore);
                var result = await dialog.ShowAsync();
                Frame.Navigate(typeof(SQLiteScores));
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

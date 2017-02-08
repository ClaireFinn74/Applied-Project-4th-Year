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
    public sealed partial class FoalShadowLvl3 : Page
    {
        

        public FoalShadowLvl3()
        {
            this.InitializeComponent();

            Random random = new Random();
            txtImgResult1.Text = GlobalClass.globalImgResultTxt.ToString();
            txtHighscore.Text = GlobalClass.globalHighscore.ToString();
            Image[] ImageArray = { Bear, Deer, Elephant, FoalShadowHorse, Giraffe, Penquin, Rabbit, Rhino, Wolf };
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

            else if (ImgResult2 == Elephant)
            {
                Elephant.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Elephant";
            }

            else if (ImgResult2 == FoalShadowHorse)
            {
                FoalShadowHorse.Visibility = Visibility.Visible;
                txtImgResult2.Text = "FoalShadowHorse";
            }

            else if (ImgResult2 == Giraffe)
            {
                Giraffe.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Giraffe";
            }

            else if (ImgResult2 == Penquin)
            {
                Penquin.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Penquin";
            }

            else if (ImgResult2 == Rabbit)
            {
                Rabbit.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Rabbit";
            }

            else if (ImgResult2 == Rhino)
            {
                Rhino.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Rhino";
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

                else if (txtImgResult2.Text == "Elephant")
                {
                    GlobalClass.globalImgResultTxt = "Elephant";
                }

                else if (txtImgResult2.Text == "FoalShadowHorse")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowHorse";
                }

                else if (txtImgResult2.Text == "Giraffe")
                {
                    GlobalClass.globalImgResultTxt = "Giraffe";
                }
                
                else if (txtImgResult2.Text == "Penquin")
                {
                    GlobalClass.globalImgResultTxt = "Penquin";
                }

                else if (txtImgResult2.Text == "Rabbit")
                {
                    GlobalClass.globalImgResultTxt = "Rabbit";
                }
                
                else if (txtImgResult2.Text == "Rhino")
                {
                    GlobalClass.globalImgResultTxt = "Rhino";
                }
                
                else if (txtImgResult2.Text == "Wolf")
                {
                    GlobalClass.globalImgResultTxt = "Wolf";
                }

                Frame.Navigate(typeof(FoalShadowLvl4));
            }

            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! Looks like you've lost but hey you got:" + GlobalClass.globalHighscore);
                var result = await dialog.ShowAsync();
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

                else if (txtImgResult2.Text == "Deer")
                {
                    GlobalClass.globalImgResultTxt = "Deer";
                }

                else if (txtImgResult2.Text == "Elephant")
                {
                    GlobalClass.globalImgResultTxt = "Elephant";
                }

                else if (txtImgResult2.Text == "FoalShadowHorse")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowHorse";
                }

                else if (txtImgResult2.Text == "Giraffe")
                {
                    GlobalClass.globalImgResultTxt = "Giraffe";
                }

                else if (txtImgResult2.Text == "Penquin")
                {
                    GlobalClass.globalImgResultTxt = "Penquin";
                }

                else if (txtImgResult2.Text == "Rabbit")
                {
                    GlobalClass.globalImgResultTxt = "Rabbit";
                }

                else if (txtImgResult2.Text == "Rhino")
                {
                    GlobalClass.globalImgResultTxt = "Rhino";
                }

                else if (txtImgResult2.Text == "Wolf")
                {
                    GlobalClass.globalImgResultTxt = "Wolf";
                }

                Frame.Navigate(typeof(FoalShadowLvl4));
            }
            else
            {
                var dialog = new Windows.UI.Popups.MessageDialog(
                "Woops! Looks like you've lost but hey you got:" + GlobalClass.globalHighscore);
                var result = await dialog.ShowAsync();
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

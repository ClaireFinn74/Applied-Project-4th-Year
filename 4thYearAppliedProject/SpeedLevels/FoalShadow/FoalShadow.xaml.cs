using _4thYearAppliedProject;
using _4thYearAppliedProject.SpeedLevels.FoalShadow;
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

namespace AppliedProject4thYear.SpeedLevels.FoalShadow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FoalShadow : Page
    {

        public FoalShadow()
        {
            this.InitializeComponent();
            GlobalClass.globalHighscore = 0;
            GlobalClassVariables.gameName = "(Foal Shadow Score) " + "\n";
            txtHighscore.Text = GlobalClass.globalHighscore.ToString();
            Random random = new Random();
            Image[] ImageArray = { Bear, BearFlipped, Deer, DeerFlipped, Elephant, ElephantFlipped, FoalShadowHorse, FoalShadowFlipped, Giraffe, GiraffeFlipped, Penquin, PenquinFlipped, Rabbit, RabbitFlipped, Rhino, RhinoFlipped, Wolf, WolfFlipped };
            Image ImgResult1 = ImageArray[random.Next(0, ImageArray.Length)];

            if (ImgResult1 == Bear)
            {
                Bear.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Bear";
            }

            else if (ImgResult1 == BearFlipped)
            {
                BearFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "BearFlipped";
            }

            else if (ImgResult1 == Deer)
            {
                Deer.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Deer";
            }

            else if (ImgResult1 == DeerFlipped)
            {
                DeerFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "DeerFlipped";
            }

            else if (ImgResult1 == Elephant)
            {
                Elephant.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Elephant";
            }

            else if (ImgResult1 == ElephantFlipped)
            {
                ElephantFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "ElephantFlipped";
            }

            else if (ImgResult1 == FoalShadowHorse)
            {
                FoalShadowHorse.Visibility = Visibility.Visible;
                txtImgResult1.Text = "FoalShadowHorse";
            }

            else if (ImgResult1 == FoalShadowFlipped)
            {
                FoalShadowFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "FoalShadowFlipped";
            }

            else if (ImgResult1 == Giraffe)
            {
                Giraffe.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Giraffe";
            }

            else if (ImgResult1 == GiraffeFlipped)
            {
                GiraffeFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "GiraffeFlipped";
            }

            else if (ImgResult1 == Penquin)
            {
                Penquin.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Penquin";
            }

            else if (ImgResult1 == PenquinFlipped)
            {
                PenquinFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "PenquinFlipped";
            }

            else if (ImgResult1 == Rabbit)
            {
                Rabbit.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Rabbit";
            }

            else if (ImgResult1 == RabbitFlipped)
            {
                RabbitFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "RabbitFlipped";
            }

            else if (ImgResult1 == Rhino)
            {
                Rhino.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Rhino";
            }

            else if (ImgResult1 == RhinoFlipped)
            {
                RhinoFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "RhinoFlipped";
            }
            else if (ImgResult1 == Wolf)
            {
                Wolf.Visibility = Visibility.Visible;
                txtImgResult1.Text = "Wolf";
            }

            else if (ImgResult1 == WolfFlipped)
            {
                WolfFlipped.Visibility = Visibility.Visible;
                txtImgResult1.Text = "WolfFlipped";
            }

            //return ImgResult1.ToString;
            //txtImgResult1.Text = ImgResult1.ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SpeedLevelsMainPage));
        }

        public void btnPlayGame_Click(object sender, RoutedEventArgs e)
        {
            Bear.Visibility = Visibility.Collapsed;
            BearFlipped.Visibility = Visibility.Collapsed;
            Deer.Visibility = Visibility.Collapsed;
            DeerFlipped.Visibility = Visibility.Collapsed;
            Elephant.Visibility = Visibility.Collapsed;
            ElephantFlipped.Visibility = Visibility.Collapsed;
            FoalShadowHorse.Visibility = Visibility.Collapsed;
            FoalShadowFlipped.Visibility = Visibility.Collapsed;
            Giraffe.Visibility = Visibility.Collapsed;
            GiraffeFlipped.Visibility = Visibility.Collapsed;
            Penquin.Visibility = Visibility.Collapsed;
            PenquinFlipped.Visibility = Visibility.Collapsed;
            Rabbit.Visibility = Visibility.Collapsed;
            RabbitFlipped.Visibility = Visibility.Collapsed;
            Rhino.Visibility = Visibility.Collapsed;
            RhinoFlipped.Visibility = Visibility.Collapsed;
            Wolf.Visibility = Visibility.Collapsed;
            WolfFlipped.Visibility = Visibility.Collapsed;

            Random random = new Random();
            Image[] ImageArray = { Bear, BearFlipped, Deer, DeerFlipped, Elephant, ElephantFlipped, FoalShadowHorse, FoalShadowFlipped, Giraffe, GiraffeFlipped, Penquin, PenquinFlipped, Rabbit, RabbitFlipped, Rhino, RhinoFlipped, Wolf, WolfFlipped };
            Image ImgResult2 = ImageArray[random.Next(0, ImageArray.Length)];

            if (ImgResult2 == Bear)
            {
                Bear.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Bear";
            }

            else if (ImgResult2 == BearFlipped)
            {
                BearFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "BearFlipped";
            }

            else if (ImgResult2 == Deer)
            {
                Deer.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Deer";
            }

            else if (ImgResult2 == DeerFlipped)
            {
                DeerFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "DeerFlipped";
            }

            else if (ImgResult2 == Elephant)
            {
                Elephant.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Elephant";
            }

            else if (ImgResult2 == ElephantFlipped)
            {
                ElephantFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "ElephantFlipped";
            }

            else if (ImgResult2 == FoalShadowHorse)
            {
                FoalShadowHorse.Visibility = Visibility.Visible;
                txtImgResult2.Text = "FoalShadowHorse";
            }

            else if (ImgResult2 == FoalShadowFlipped)
            {
                FoalShadowFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "FoalShadowFlipped";
            }

            else if (ImgResult2 == Giraffe)
            {
                Giraffe.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Giraffe";
            }

            else if (ImgResult2 == GiraffeFlipped)
            {
                GiraffeFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "GiraffeFlipped";
            }

            else if (ImgResult2 == Penquin)
            {
                Penquin.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Penquin";
            }

            else if (ImgResult2 == PenquinFlipped)
            {
                PenquinFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "PenquinFlipped";
            }

            else if (ImgResult2 == Rabbit)
            {
                Rabbit.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Rabbit";
            }

            else if (ImgResult2 == RabbitFlipped)
            {
                RabbitFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "RabbitFlipped";
            }

            else if (ImgResult2 == Rhino)
            {
                Rhino.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Rhino";
            }

            else if (ImgResult2 == RhinoFlipped)
            {
                RhinoFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "RhinoFlipped";
            }
            else if (ImgResult2 == Wolf)
            {
                Wolf.Visibility = Visibility.Visible;
                txtImgResult2.Text = "Wolf";
            }

            else if (ImgResult2 == WolfFlipped)
            {
                WolfFlipped.Visibility = Visibility.Visible;
                txtImgResult2.Text = "WolfFlipped";
            }

            btnPlayGame.Visibility = Visibility.Collapsed;
            btnYes.Visibility = Visibility.Visible;
            btnNo.Visibility = Visibility.Visible;
            //return ImgResult2.ToString;
            //txtImgResult2.Text = ImgResult2.ToString();
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

                else if (txtImgResult2.Text == "BearFlipped")
                {
                    GlobalClass.globalImgResultTxt = "BearFlipped";
                }

                else if (txtImgResult2.Text == "Deer")
                {
                    GlobalClass.globalImgResultTxt = "Deer";
                }

                else if (txtImgResult2.Text == "DeerFlipped")
                {
                    GlobalClass.globalImgResultTxt = "DeerFlipped";
                }

                else if (txtImgResult2.Text == "Elephant")
                {
                    GlobalClass.globalImgResultTxt = "Elephant";
                }

                else if (txtImgResult2.Text == "ElephantFlipped")
                {
                    GlobalClass.globalImgResultTxt = "ElephantFlipped";
                }

                else if (txtImgResult2.Text == "FoalShadowHorse")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowHorse";
                }

                else if (txtImgResult2.Text == "FoalShadowFlipped")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowFlipped";
                }

                else if (txtImgResult2.Text == "Giraffe")
                {
                    GlobalClass.globalImgResultTxt = "Giraffe";
                }

                else if (txtImgResult2.Text == "GiraffeFlipped")
                {
                    GlobalClass.globalImgResultTxt = "GiraffeFlipped";
                }

                else if (txtImgResult2.Text == "Penquin")
                {
                    GlobalClass.globalImgResultTxt = "Penquin";
                }

                else if (txtImgResult2.Text == "PenquinFlipped")
                {
                    GlobalClass.globalImgResultTxt = "PenquinFlipped";
                }

                else if (txtImgResult2.Text == "Rabbit")
                {
                    GlobalClass.globalImgResultTxt = "Rabbit";
                }

                else if (txtImgResult2.Text == "RabbitFlipped")
                {
                    GlobalClass.globalImgResultTxt = "RabbitFlipped";
                }

                else if (txtImgResult2.Text == "Rhino")
                {
                    GlobalClass.globalImgResultTxt = "Rhino";
                }

                else if (txtImgResult2.Text == "RhinoFlipped")
                {
                    GlobalClass.globalImgResultTxt = "RhinoFlipped";
                }
                else if (txtImgResult2.Text == "Wolf")
                {
                    GlobalClass.globalImgResultTxt = "Wolf";
                }

                else if (txtImgResult2.Text == "WolfFlipped")
                {
                    GlobalClass.globalImgResultTxt = "WolfFlipped";
                }
                Frame.Navigate(typeof(FoalShadowLvl2));
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
            if (txtImgResult1 != txtImgResult2)
            {
                GlobalClass.globalHighscore++;
                txtHighscore.Text = GlobalClass.globalHighscore.ToString();
                if (txtImgResult2.Text == "Bear")
                {
                    GlobalClass.globalImgResultTxt = "Bear";
                }

                else if (txtImgResult2.Text == "BearFlipped")
                {
                    GlobalClass.globalImgResultTxt = "BearFlipped";
                }

                else if (txtImgResult2.Text == "Deer")
                {
                    GlobalClass.globalImgResultTxt = "Deer";
                }

                else if (txtImgResult2.Text == "DeerFlipped")
                {
                    GlobalClass.globalImgResultTxt = "DeerFlipped";
                }

                else if (txtImgResult2.Text == "Elephant")
                {
                    GlobalClass.globalImgResultTxt = "Elephant";
                }

                else if (txtImgResult2.Text == "ElephantFlipped")
                {
                    GlobalClass.globalImgResultTxt = "ElephantFlipped";
                }

                else if (txtImgResult2.Text == "FoalShadowHorse")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowHorse";
                }

                else if (txtImgResult2.Text == "FoalShadowFlipped")
                {
                    GlobalClass.globalImgResultTxt = "FoalShadowFlipped";
                }

                else if (txtImgResult2.Text == "Giraffe")
                {
                    GlobalClass.globalImgResultTxt = "Giraffe";
                }

                else if (txtImgResult2.Text == "GiraffeFlipped")
                {
                    GlobalClass.globalImgResultTxt = "GiraffeFlipped";
                }

                else if (txtImgResult2.Text == "Penquin")
                {
                    GlobalClass.globalImgResultTxt = "Penquin";
                }

                else if (txtImgResult2.Text == "PenquinFlipped")
                {
                    GlobalClass.globalImgResultTxt = "PenquinFlipped";
                }

                else if (txtImgResult2.Text == "Rabbit")
                {
                    GlobalClass.globalImgResultTxt = "Rabbit";
                }

                else if (txtImgResult2.Text == "RabbitFlipped")
                {
                    GlobalClass.globalImgResultTxt = "RabbitFlipped";
                }

                else if (txtImgResult2.Text == "Rhino")
                {
                    GlobalClass.globalImgResultTxt = "Rhino";
                }

                else if (txtImgResult2.Text == "RhinoFlipped")
                {
                    GlobalClass.globalImgResultTxt = "RhinoFlipped";
                }
                else if (txtImgResult2.Text == "Wolf")
                {
                    GlobalClass.globalImgResultTxt = "Wolf";
                }

                else if (txtImgResult2.Text == "WolfFlipped")
                {
                    GlobalClass.globalImgResultTxt = "WolfFlipped";
                }
                Frame.Navigate(typeof(FoalShadowLvl2));
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
                "So to play FoalShadow all you have to do is study the images provided and then say if the next image is the exact same. Get as many right in the time provided as possible");
            var result = await dialog.ShowAsync();
        }
    }
}

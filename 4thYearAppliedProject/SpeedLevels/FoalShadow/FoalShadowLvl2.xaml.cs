﻿using _4thYearAppliedProject;
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
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FoalShadowLvl2 : Page
    {

        public FoalShadowLvl2()
        {
            GlobalClassVariables.gameName = "(Foal Shadow Score) " + "\n";
            this.InitializeComponent();

            Random random = new Random();
            txtImgResult1.Text = GlobalClass.globalImgResultTxt.ToString();
            txtHighscore.Text = GlobalClass.globalHighscore.ToString();
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

            btnYes.Visibility = Visibility.Visible;
            btnNo.Visibility = Visibility.Visible;
            //return ImgResult2.To;
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
                Frame.Navigate(typeof(FoalShadowLvl3));
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
                Frame.Navigate(typeof(FoalShadowLvl3));
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

using _4thYearAppliedProject;
using _4thYearAppliedProject.AttentionLevels.Everything_has_a_porpoise;
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

namespace AppliedProject4thYear.AttentionLevels
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Everything_Has_A_Purpoise : Page
    {
        public Everything_Has_A_Purpoise()
        {
            //Initialize the game
            this.InitializeComponent();
            //Begin the Porpoise Level 1 Storyboard as soon as the page renders/Initializes
            sbPorpoiseLevel1.Begin();
        }

        int porpoiseTapped1 = 0;
        int porpoiseTapped2 = 0;
        int porpoiseTapped3 = 0;
        /* int porpoiseTapped4 = 0;
        int porpoiseTapped5 = 0;
        int porpoiseTapped6 = 0;
        int porpoiseTapped7 = 0;
        int porpoiseTapped8 = 0;
        int porpoiseTapped9 = 0;
        int porpoiseTapped10 = 0;
        int porpoiseTapped11 = 0;
        int porpoiseTapped12 = 0; */

        //Make the event async in order to allow message dialog boxes
        private async void imgporpoise_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Make all variables global to allow them to be used in any page
            porpoiseTapped1++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassAttention.score == 3)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level2?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0;
                /*Begin the next storyboard (the next level, increasing the number of porpoise
                images to be tapped) */
                //sbPorpoiseLevel2.Begin();
                //4th porpoise image visibility property becomes visible
                //imgporpoise4.Visibility = Visibility.Visible;
                Frame.Navigate(typeof(PorpoiseLevel2));
            }
            //Otherwise, If the image is tapped twice the game ends
            else if (porpoiseTapped1 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                //Message box displays
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped2++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassAttention.score == 3)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level2?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0;
                /*Begin the next storyboard (the next level, increasing the number of porpoise
                images to be tapped) */
                // sbPorpoiseLevel2.Begin();
                //4th porpoise image visibility property becomes visible
                //imgporpoise4.Visibility = Visibility.Visible;
                Frame.Navigate(typeof(PorpoiseLevel2));
            }
            else if (porpoiseTapped2 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped3++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassAttention.score == 3)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level2?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0;
                /*Begin the next storyboard (the next level, increasing the number of porpoise
                images to be tapped) */
                Frame.Navigate(typeof(PorpoiseLevel2));
                //sbPorpoiseLevel2.Begin();
                //4th porpoise image visibility property becomes visible
                //imgporpoise4.Visibility = Visibility.Visible;
            }
            else if (porpoiseTapped3 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

      /*  private async void imgporpoise4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped4++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 7)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level3?");
                await dialog.ShowAsync();
                //To reuse the first 4 images in level 3 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                sbPorpoiseLevel2.Stop();
                //5th porpoise image visibility property becomes visible
                imgporpoise5.Visibility = Visibility.Visible;
                sbPorpoiseLevel3.Begin();
            }
            else if (porpoiseTapped4 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped5++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

             if (GlobalClassAttention.score == 12)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level4?");
                await dialog.ShowAsync();
                //To reuse the first 5 images in level 4 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0;
                sbPorpoiseLevel3.Stop();
                //6th porpoise image visibility property becomes visible
                imgporpoise6.Visibility = Visibility.Visible;
                sbPorpoiseLevel4.Begin();
            }
            else if (porpoiseTapped5 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped6++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 18)
            {
                sbPorpoiseLevel4.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level5?");
                await dialog.ShowAsync();
                sbPorpoiseLevel5.Begin();
                //To reuse the first 6 images in level 5 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0;
                //7th porpoise image visibility property becomes visible
                imgporpoise7.Visibility = Visibility.Visible;
            }
            else if (porpoiseTapped6 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise7_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped7++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 25)
            {
                sbPorpoiseLevel5.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level6?");
                await dialog.ShowAsync();
                sbPorpoiseLevel6.Begin();
                //To reuse the first 7 images in level 6 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0 + porpoiseTapped7;
                //8th porpoise image visibility property becomes visible
                imgporpoise8.Visibility = Visibility.Visible;
            }
            else if (porpoiseTapped7 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise8_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped8++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (porpoiseTapped8 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
            else if (GlobalClassAttention.score == 33)
            {
                sbPorpoiseLevel6.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level7?");
                await dialog.ShowAsync();
                sbPorpoiseLevel7.Begin();
                //To reuse the first 8 images in level 7 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                //9th porpoise image visibility property becomes visible
                imgporpoise9.Visibility = Visibility.Visible;
            }
        }

        private async void imgporpoise9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped9++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (porpoiseTapped9 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
            else if (GlobalClassAttention.score == 42)
            {
                sbPorpoiseLevel7.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level8?");
                await dialog.ShowAsync();
                sbPorpoiseLevel8.Begin();
                //To reuse the first 9 images in level 8 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0;
                //10th porpoise image visibility property becomes visible
                imgporpoise10.Visibility = Visibility.Visible;
            }
        }

        private async void imgporpoise10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped10++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (porpoiseTapped10 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
            else if (GlobalClassAttention.score == 52)
            {
                sbPorpoiseLevel8.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level9?");
                await dialog.ShowAsync();
                sbPorpoiseLevel9.Begin();
                //To reuse the first 10 images in level 9 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0;
                //11th porpoise image visibility property becomes visible
                imgporpoise11.Visibility = Visibility.Visible;
            }
        }

        private async void imgporpoise11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped11++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (porpoiseTapped11 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
            else if (GlobalClassAttention.score == 63)
            {
                sbPorpoiseLevel9.Stop();
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level10?");
                await dialog.ShowAsync();
                sbPorpoiseLevel10.Begin();
                //To reuse the first 11 images in level 10 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                porpoiseTapped5 = 0; porpoiseTapped6 = 0; porpoiseTapped7 = 0; porpoiseTapped8 = 0;
                porpoiseTapped9 = 0; porpoiseTapped10 = 0; porpoiseTapped11 = 0;
                //21th porpoise image visibility property becomes visible
                imgporpoise12.Visibility = Visibility.Visible;
            }
        }

        private async void imgporpoise12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped12++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (porpoiseTapped12 == 2)
            {
                //Reset Score to 0
                GlobalClassAttention.score = 0;
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
            else if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
            }
        } */

      
    }
    }

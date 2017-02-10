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
    }
    }

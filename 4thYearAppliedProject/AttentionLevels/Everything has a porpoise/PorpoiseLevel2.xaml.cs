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
    public sealed partial class PorpoiseLevel2 : Page
    {
        public PorpoiseLevel2()
        {
            this.InitializeComponent();
            GlobalClassVariables.gameName = "(Everything Has A Porpoise Score) " + "\n";
            //Begin the Porpoise Level 1 Storyboard as soon as the page renders/Initializes
            sbPorpoiseLevel1.Begin();
            sbPorpoiseLevel2.Begin();
        }

        int porpoiseTapped1 = 0;
        int porpoiseTapped2 = 0;
        int porpoiseTapped3 = 0;
        int porpoiseTapped4 = 0;

        //Make the event async in order to allow message dialog boxes
        private async void imgporpoise_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Make all variables global to allow them to be used in any page
            porpoiseTapped1++;
            GlobalClassVariables.score++;
            txtbScore.Text = GlobalClassVariables.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassVariables.score == 7)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level3?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0;
                /*Begin the next storyboard (the next level, increasing the number of porpoise
                images to be tapped) */
                //sbPorpoiseLevel2.Begin();
                //4th porpoise image visibility property becomes visible
                //imgporpoise4.Visibility = Visibility.Visible;
                Frame.Navigate(typeof(PorpoiseLevel3));
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
            if (GlobalClassVariables.score == 7)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level3?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0;
                /*Begin the next storyboard (the next level, increasing the number of porpoise
                images to be tapped) */
                // sbPorpoiseLevel2.Begin();
                //4th porpoise image visibility property becomes visible
                //imgporpoise4.Visibility = Visibility.Visible;
                Frame.Navigate(typeof(PorpoiseLevel3));
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
            if (GlobalClassVariables.score == 7)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level3?");
                await dialog.ShowAsync();
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0;
                /*Begin the next storyboard (the next level, increasing the number of porpoise
                images to be tapped) */
                Frame.Navigate(typeof(PorpoiseLevel3));
                //sbPorpoiseLevel2.Begin();
                //4th porpoise image visibility property becomes visible
                //imgporpoise4.Visibility = Visibility.Visible;
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

            if (GlobalClassVariables.score == 7)
            {
                var dialog = new MessageDialog("Well Done! Have what it takes to go to Level3?");
                await dialog.ShowAsync();
                //To reuse the first 4 images in level 3 we need to set the values back to 0 so they are unclicked
                porpoiseTapped1 = 0; porpoiseTapped2 = 0; porpoiseTapped3 = 0; porpoiseTapped4 = 0;
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                Frame.Navigate(typeof(PorpoiseLevel3));

            }
            else if (porpoiseTapped4 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
            }
        }
    }
}

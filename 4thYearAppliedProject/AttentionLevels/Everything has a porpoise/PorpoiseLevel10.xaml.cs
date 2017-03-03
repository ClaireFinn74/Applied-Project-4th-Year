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
    public sealed partial class PorpoiseLevel10 : Page
    {
        public PorpoiseLevel10()
        {
            this.InitializeComponent();
            GlobalClassAttention.gameName = "Everything Has A Porpoise Score:";
            sbPorpoiseLevel1.Begin();
            sbPorpoiseLevel2.Begin();
            sbPorpoiseLevel3.Begin();
            sbPorpoiseLevel4.Begin();
            sbPorpoiseLevel5.Begin();
            sbPorpoiseLevel6.Begin();
            sbPorpoiseLevel7.Begin();
            sbPorpoiseLevel8.Begin();
            sbPorpoiseLevel9.Begin();
            sbPorpoiseLevel10.Begin();
        }

        int porpoiseTapped1 = 0;
        int porpoiseTapped2 = 0;
        int porpoiseTapped3 = 0;
        int porpoiseTapped4 = 0;
        int porpoiseTapped5 = 0;
        int porpoiseTapped6 = 0;
        int porpoiseTapped7 = 0;
        int porpoiseTapped8 = 0;
        int porpoiseTapped9 = 0;
        int porpoiseTapped10 = 0;
        int porpoiseTapped11 = 0;
        int porpoiseTapped12 = 0;
        //Make the event async in order to allow message dialog boxes
        private async void imgporpoise_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Make all variables global to allow them to be used in any page
            porpoiseTapped1++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            //If all images are tapped, increase to next level
            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            //Otherwise, If the image is tapped twice the game ends
            else if (porpoiseTapped1 == 2)
            {
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
            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped2 == 2)
            {
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
            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped3 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped4++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));

            }
            else if (porpoiseTapped4 == 2)
            {
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

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped5 == 2)
            {
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

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped6 == 2)
            {
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

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped7 == 2)
            {
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

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped8 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise9_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped9++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped9 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise10_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped10++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped10 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise11_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped11++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped11 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }

        private async void imgporpoise12_Tapped(object sender, TappedRoutedEventArgs e)
        {
            porpoiseTapped12++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();

            if (GlobalClassAttention.score == 75)
            {
                sbPorpoiseLevel1.Stop();
                sbPorpoiseLevel2.Stop();
                sbPorpoiseLevel3.Stop();
                sbPorpoiseLevel4.Stop();
                sbPorpoiseLevel5.Stop();
                sbPorpoiseLevel6.Stop();
                sbPorpoiseLevel7.Stop();
                sbPorpoiseLevel8.Stop();
                sbPorpoiseLevel9.Stop();
                sbPorpoiseLevel10.Stop();
                var dialog = new MessageDialog("Well Done! You have reached maximum attention for today!");
                await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }
            else if (porpoiseTapped12 == 2)
            {
                var dialog = new MessageDialog("Too Bad, you already clicked that porpoise! Game Over");
                await dialog.ShowAsync();
                //Go back to Mainpage
                Frame.Navigate(typeof(MainPage));
            }
        }
    }
}

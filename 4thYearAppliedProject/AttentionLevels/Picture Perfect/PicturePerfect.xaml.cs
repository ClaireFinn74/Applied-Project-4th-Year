using _4thYearAppliedProject.AttentionLevels.Picture_Perect;
using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppliedProject4thYear.AttentionLevels
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PicturePerfect : Page
    {
        public PicturePerfect()
        {
            this.InitializeComponent();
        }

        private void btnPicturePerfect_Click(object sender, RoutedEventArgs e)
        {
            //the Coffee Art image becomes visible
            imgPicturePerfectCoffeeArt.Visibility = Visibility.Visible;
            btnBeginCoffeeArt.Visibility = Visibility.Visible;
        }

        private void btnBeginCoffeeArt_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(CoffeeArt));
        }

        private async void btnRules_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog
            ("Pick a picture to begin with by pressing the pink button." + "\n"
            + "You should study that image very closely!" + "\n"
            + "Once you feel confidant enough, you can press the brown button to begin!" + "\n"
            + "You should now see a number of items which may or may not be associated with the image you studied!" + "\n"
            + "Choose the correct ones to progress in levels!" + "\n"
            + "Choose the wrong one and you'll be thrown back to the main menu so choose carefully." + "\n"
            + "Best of luck!!");
            await dialog.ShowAsync();
        }
    }
}

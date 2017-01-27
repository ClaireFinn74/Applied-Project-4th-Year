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
// C# , ADO.NET  
using System;
//using System.Data.SqlClient;  // System.Data.dll  
using Windows.UI.Popups;
using AppliedProject4thYear.MainPages;
using _4thYearAppliedProject;
using Microsoft.WindowsAzure.MobileServices;
using Windows.Security.Credentials;

namespace AppliedProject4thYear
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnAttention_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(AttentionPage));
        }

        private void btnProblemSolving_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ProblemSolvingGames), null);
        }

        private void btnSpeed_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SpeedLevels.SpeedLevelsMainPage));
        }

        private void btnMemory_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(MemoryLevels.MemoryMainPage));
        }

        private void btnGoToScores_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HighScores));
        }

        // Define a member variable for storing the signed-in user. 
        private MobileServiceUser user;

        // Define a method that performs the authentication process
        // using a Facebook sign-in. 
        private async System.Threading.Tasks.Task<bool> AuthenticateAsync()
        {
            string message;
            bool success = false;
            try
            {
                // Change 'MobileService' to the name of your MobileServiceClient instance.
                // Sign-in using Facebook authentication.
                user = await App.MobileService
                    .LoginAsync(MobileServiceAuthenticationProvider.Facebook);
                message =
                    string.Format("You are now signed in - {0}", user.UserId);

                success = true;
            }
            catch (InvalidOperationException)
            {
                message = "You must log in. Login Required";
            }

            var dialog = new MessageDialog(message);
            dialog.Commands.Add(new UICommand("OK"));
            await dialog.ShowAsync();
            return success;
        }

        private async void btnFbLogin_Click(object sender, RoutedEventArgs e)
        {
            // Login the user and then load data from the mobile app.
            if (await AuthenticateAsync())
            {
                // Switch the buttons and load items from the mobile app.
                btnFbLogin.Visibility = Visibility.Collapsed;
                //await InitLocalStoreAsync(); //offline sync support.
                // await RefreshTodoItems();
            }
        }
    }
}

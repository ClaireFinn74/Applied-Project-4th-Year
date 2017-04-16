using _4thYearAppliedProject.AttentionLevels.Everything_has_a_porpoise;
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

namespace _4thYearAppliedProject.AttentionLevels.Total_Recall
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TotalRecallLevel7 : Page
    {
        public TotalRecallLevel7()
        {
            GlobalClassVariables.gameName = "(Total Recall Score) " + "\n";
            this.InitializeComponent();
            DispatcherTimerSetup();
        }
    
    DispatcherTimer dispatcherTimer;
    int timesTicked = 180; //3 minutes
    int timesToTick = 180;

    public void DispatcherTimerSetup()
    {
        dispatcherTimer = new DispatcherTimer();
        dispatcherTimer.Tick += dispatcherTimer_Tick;
        dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
        dispatcherTimer.Start();
    }

    async void dispatcherTimer_Tick(object sender, object e)
    {
        txtLog.Text = timesTicked.ToString();
        if (timesTicked > timesToTick)
        {
            txtTimer.Text = "Calling dispatcherTimer.Stop()\n";
            dispatcherTimer.Stop();
            txtTimer.Text = "dispatcherTimer.IsEnabled = " + dispatcherTimer.IsEnabled + "\n";
        }
        timesTicked--;

        if (timesTicked == -1)
        {
            dispatcherTimer.Stop();
            var dialog = new MessageDialog("Out of time! You scored:"
                                   + GlobalClassVariables.score);
            var result = await dialog.ShowAsync();
            //Go back to SQLiteScores
            Frame.Navigate(typeof(SQLiteScores));
            }
    }

    private void TimerStart_Click_1(object sender, RoutedEventArgs e)
    {
        DispatcherTimerSetup();
    }

    private void TimerStop_Click_1(object sender, RoutedEventArgs e)
    {
        dispatcherTimer.Stop();
    }
    private void Page_Loaded_1(object sender, RoutedEventArgs e)
    {
        txtTimer.Text = "dispatcherTimer.IsEnabled = False";
    }


    private async void btnEnter_Click(object sender, RoutedEventArgs e)
    {
            Dictionary<string, int> WordsWithSome = new Dictionary<string, int>();
            WordsWithSome.Add("", 1); WordsWithSome.Add("bodies", 2); WordsWithSome.Add("body", 3); WordsWithSome.Add("day", 4);
            WordsWithSome.Add("deal", 5); WordsWithSome.Add("how", 6); WordsWithSome.Add("one", 7); WordsWithSome.Add("ones", 8);
            WordsWithSome.Add("place", 9); WordsWithSome.Add("rsault", 10); WordsWithSome.Add("rsaulted", 11); WordsWithSome.Add("rsaulting", 12);
            WordsWithSome.Add("rsaults", 13); WordsWithSome.Add("rset", 14); WordsWithSome.Add("rseted", 15); WordsWithSome.Add("rseting", 16);
            WordsWithSome.Add("rsets", 17); WordsWithSome.Add("rsetted", 18); WordsWithSome.Add("rsetting", 19); WordsWithSome.Add("thing", 20);
            WordsWithSome.Add("time", 21); WordsWithSome.Add("times", 22); WordsWithSome.Add("way", 23); WordsWithSome.Add("ways", 24);
            WordsWithSome.Add("what", 25); WordsWithSome.Add("whats", 26); WordsWithSome.Add("when", 27); WordsWithSome.Add("where", 28);
            WordsWithSome.Add("wheres", 29); WordsWithSome.Add("whither", 30); WordsWithSome.Add("wise", 31);

            if (GlobalClassVariables.score == 750)
        {
                var dialog = new MessageDialog("Well done, you have reached the end!"
                                   + GlobalClassVariables.score);
                var result = await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
            }

        if (WordsWithSome.ContainsKey(txtUserInput.Text))
        {
            GlobalClassVariables.score += 10;
            txtScore.Text = GlobalClassVariables.score.ToString();
            imgCorrectSign.Visibility = Visibility.Visible;
            imgX.Visibility = Visibility.Collapsed;
        }
        else
        {
            imgX.Visibility = Visibility.Visible;
            imgCorrectSign.Visibility = Visibility.Collapsed;
        }
    }
    }
}

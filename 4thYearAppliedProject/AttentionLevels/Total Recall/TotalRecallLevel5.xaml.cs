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
    public sealed partial class TotalRecallLevel5 : Page
    {
        public TotalRecallLevel5()
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


    private void btnEnter_Click(object sender, RoutedEventArgs e)
    {
            Dictionary<string, int> WordsWithProg = new Dictionary<string, int>();
            WordsWithProg.Add("", 1); WordsWithProg.Add("enies", 2); WordsWithProg.Add("enitor", 3); WordsWithProg.Add("enitors", 4);
            WordsWithProg.Add("eny", 5); WordsWithProg.Add("eria", 6); WordsWithProg.Add("erias", 7); WordsWithProg.Add("estational", 8);
            WordsWithProg.Add("esterone", 9); WordsWithProg.Add("esterones", 11); WordsWithProg.Add("estin", 12);
            WordsWithProg.Add("estins", 13); WordsWithProg.Add("estogen", 14); WordsWithProg.Add("estogenic", 15); WordsWithProg.Add("estogens", 16);
            WordsWithProg.Add("ged", 17); WordsWithProg.Add("ger", 18); WordsWithProg.Add("gers", 19); WordsWithProg.Add("ging", 20);
            WordsWithProg.Add("lottid", 21); WordsWithProg.Add("lottides", 22); WordsWithProg.Add("lottis", 23); WordsWithProg.Add("nathism", 24);
            WordsWithProg.Add("nathisms", 25); WordsWithProg.Add("nathous", 26); WordsWithProg.Add("nose", 27); WordsWithProg.Add("nosed", 28);
            WordsWithProg.Add("noses", 29); WordsWithProg.Add("nosing", 30); WordsWithProg.Add("nosis", 31); WordsWithProg.Add("nostic", 32);
            WordsWithProg.Add("nosticate", 33); WordsWithProg.Add("nosticated", 34); WordsWithProg.Add("nosticates", 35); WordsWithProg.Add("nosticating", 36);
            WordsWithProg.Add("nostication", 37); WordsWithProg.Add("nostications", 38); WordsWithProg.Add("nosticative", 39); WordsWithProg.Add("nosticator", 40);
            WordsWithProg.Add("nosticators", 41); WordsWithProg.Add("nostics", 42); WordsWithProg.Add("rade", 43);
            WordsWithProg.Add("ramed", 45); WordsWithProg.Add("ramer", 46); WordsWithProg.Add("ramers", 47); WordsWithProg.Add("raming", 48);
            WordsWithProg.Add("ramings", 49); WordsWithProg.Add("rammabilities", 50); WordsWithProg.Add("rammability", 51); WordsWithProg.Add("rammable", 52);
            WordsWithProg.Add("rammables", 53); WordsWithProg.Add("rammatic", 54); WordsWithProg.Add("rammatically", 55); WordsWithProg.Add("ramme", 56);
            WordsWithProg.Add("rammed", 57); WordsWithProg.Add("rammer", 58); WordsWithProg.Add("rammers", 59); WordsWithProg.Add("rammes", 60);
            WordsWithProg.Add("ming", 61); WordsWithProg.Add("ram", 62); WordsWithProg.Add("rammings", 63); WordsWithProg.Add("rams", 64);
            WordsWithProg.Add("ress", 65); WordsWithProg.Add("ressed", 66); WordsWithProg.Add("resses", 67); WordsWithProg.Add("ressing", 68);
            WordsWithProg.Add("ression", 69); WordsWithProg.Add("ressional", 70); WordsWithProg.Add("ressions", 71); WordsWithProg.Add("ressive", 72);
            WordsWithProg.Add("ressively", 73); WordsWithProg.Add("ressiveness", 74); WordsWithProg.Add("ressivenesses", 75); WordsWithProg.Add("ressives", 76);
            WordsWithProg.Add("ressivism", 77); WordsWithProg.Add("ressivisms", 78); WordsWithProg.Add("ressivist", 79); WordsWithProg.Add("ressivistic", 80);
            WordsWithProg.Add("ressivists", 81); WordsWithProg.Add("ressivities", 82); WordsWithProg.Add("ressivity", 83); WordsWithProg.Add("s", 84);

            if (GlobalClassVariables.score == 750)
        {
            btnLevel6.Visibility = Visibility.Visible;
        }

        if (WordsWithProg.ContainsKey(txtUserInput.Text))
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

    private void btnLevel6_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TotalRecallLevel6));
        }
    }
}

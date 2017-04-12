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
    public sealed partial class TotalRecallLevel2 : Page
    {
        public TotalRecallLevel2()
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
    Dictionary<string, int> WordsWithBra = new Dictionary<string, int>();
    WordsWithBra.Add("", 1); WordsWithBra.Add("d", 2); WordsWithBra.Add("e", 3); WordsWithBra.Add("g", 4);
    WordsWithBra.Add("n", 5); WordsWithBra.Add("t", 6); WordsWithBra.Add("w", 7); WordsWithBra.Add("y", 8);
    WordsWithBra.Add("ch", 9); WordsWithBra.Add("ct", 10); WordsWithBra.Add("gi", 11); WordsWithBra.Add("hm", 12);
    WordsWithBra.Add("id", 13); WordsWithBra.Add("il", 14); WordsWithBra.Add("in", 15); WordsWithBra.Add("ke", 16);
    WordsWithBra.Add("nd", 17); WordsWithBra.Add("nt", 18); WordsWithBra.Add("sh", 19); WordsWithBra.Add("ss", 20);
    WordsWithBra.Add("ve", 21); WordsWithBra.Add("vo", 22); WordsWithBra.Add("wl", 23); WordsWithBra.Add("wn", 24);
    WordsWithBra.Add("xy", 25); WordsWithBra.Add("za", 26); WordsWithBra.Add("ze", 27); WordsWithBra.Add("ide", 28);
    WordsWithBra.Add("ins", 29); WordsWithBra.Add("iny", 30); WordsWithBra.Add("ise", 31); WordsWithBra.Add("nch", 32);
    WordsWithBra.Add("ndy", 33); WordsWithBra.Add("nks", 34); WordsWithBra.Add("nle", 35); WordsWithBra.Add("nny", 36);
    WordsWithBra.Add("sen", 37); WordsWithBra.Add("shy", 38); WordsWithBra.Add("ssy", 39); WordsWithBra.Add("wls", 40);
    WordsWithBra.Add("wny", 41); WordsWithBra.Add("yer", 42); WordsWithBra.Add("zen", 43); WordsWithBra.Add("zil", 44);
    WordsWithBra.Add("bble", 45); WordsWithBra.Add("chet", 46); WordsWithBra.Add("cing", 47); WordsWithBra.Add("cked", 48);
    WordsWithBra.Add("cken", 49); WordsWithBra.Add("cket", 50); WordsWithBra.Add("dawl", 51); WordsWithBra.Add("ided", 52);
    WordsWithBra.Add("ined", 53); WordsWithBra.Add("ises", 54); WordsWithBra.Add("mble", 55); WordsWithBra.Add("mbly", 56);
    WordsWithBra.Add("nial", 57); WordsWithBra.Add("sier", 58); WordsWithBra.Add("ssie", 59); WordsWithBra.Add("vado", 60);
    WordsWithBra.Add("very", 61); WordsWithBra.Add("vura", 62); WordsWithBra.Add("yers", 63); WordsWithBra.Add("zens", 64);
    WordsWithBra.Add("zers", 65); WordsWithBra.Add("zier", 66); WordsWithBra.Add("chial", 67); WordsWithBra.Add("chium", 68);
    WordsWithBra.Add("ckish", 69); WordsWithBra.Add("ggart", 70); WordsWithBra.Add("gwort", 71); WordsWithBra.Add("iding", 72);
    WordsWithBra.Add("inily", 73); WordsWithBra.Add("inpan", 74); WordsWithBra.Add("keman", 75); WordsWithBra.Add("nchia", 76);
    WordsWithBra.Add("ndify", 77); WordsWithBra.Add("ndish", 78); WordsWithBra.Add("ngler", 79); WordsWithBra.Add("silin", 80);
    WordsWithBra.Add("ssage", 81); WordsWithBra.Add("ssard", 82); WordsWithBra.Add("ssica", 83); WordsWithBra.Add("tpack", 84);
    WordsWithBra.Add("tstva", 85); WordsWithBra.Add("ttice", 86); WordsWithBra.Add("unite", 87); WordsWithBra.Add("vuras", 88);
    WordsWithBra.Add("wling", 89); WordsWithBra.Add("zilin", 90); WordsWithBra.Add("chiate", 91); WordsWithBra.Add("chytic", 92);
    WordsWithBra.Add("cioles", 93); WordsWithBra.Add("cteate", 94); WordsWithBra.Add("cteole", 95); WordsWithBra.Add("dypode", 96);
    WordsWithBra.Add("hmanis", 97); WordsWithBra.Add("inless", 98); WordsWithBra.Add("insick", 99); WordsWithBra.Add("inwash", 100);
    WordsWithBra.Add("inwork", 101); WordsWithBra.Add("kesman", 102); WordsWithBra.Add("mbling", 103); WordsWithBra.Add("nching", 104);
    WordsWithBra.Add("nchlet", 105); WordsWithBra.Add("ndling", 106); WordsWithBra.Add("silein", 107); WordsWithBra.Add("silete", 108);
    WordsWithBra.Add("sserie", 109); WordsWithBra.Add("sidic", 110); WordsWithBra.Add("ssiere", 111); WordsWithBra.Add("ssware", 112);
    WordsWithBra.Add("twurst", 113); WordsWithBra.Add("vadoed", 114); WordsWithBra.Add("veness", 115); WordsWithBra.Add("zilein", 116);
    WordsWithBra.Add("chiopod", 117); WordsWithBra.Add("chylogy", 118); WordsWithBra.Add("chyuran", 119); WordsWithBra.Add("cketing", 120);
    WordsWithBra.Add("dynosus", 121); WordsWithBra.Add("dytelic", 122); WordsWithBra.Add("ininess", 123); WordsWithBra.Add("instorm", 124);
    WordsWithBra.Add("nchiest", 125); WordsWithBra.Add("nchings", 126); WordsWithBra.Add("shiness", 127); WordsWithBra.Add("ssbound", 128);
    WordsWithBra.Add("vissimo", 129); WordsWithBra.Add("wniness", 130);

            if (GlobalClassVariables.score == 300)
            {
                btnLevel3.Visibility = Visibility.Visible;
            }

            if (WordsWithBra.ContainsKey(txtUserInput.Text))
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

        private void btnLevel3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TotalRecallLevel3));
        }
    }
}

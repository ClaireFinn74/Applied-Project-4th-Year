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

namespace _4thYearAppliedProject.AttentionLevels.Total_Recall
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TotalRecallLevel3 : Page
    {
        public TotalRecallLevel3()
        {
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
                                       + GlobalClassAttention.totalRecallScore);
                var result = await dialog.ShowAsync();
                Frame.Navigate(typeof(MainPage), null);
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
            Dictionary<string, int> WordsWithDar = new Dictionary<string, int>();
            WordsWithDar.Add("b", 1); WordsWithDar.Add("e", 2); WordsWithDar.Add("g", 3); WordsWithDar.Add("i", 4);
            WordsWithDar.Add("k", 5); WordsWithDar.Add("t", 6); WordsWithDar.Add("af", 7); WordsWithDar.Add("bs", 8);
            WordsWithDar.Add("cy", 9); WordsWithDar.Add("ed", 10); WordsWithDar.Add("er", 11); WordsWithDar.Add("es", 12);
            WordsWithDar.Add("ga", 13); WordsWithDar.Add("gs", 14); WordsWithDar.Add("ic", 15); WordsWithDar.Add("ks", 16);
            WordsWithDar.Add("ky", 17); WordsWithDar.Add("ns", 18); WordsWithDar.Add("re", 19); WordsWithDar.Add("ts", 20);
            WordsWithDar.Add("zi", 21); WordsWithDar.Add("afs", 22); WordsWithDar.Add("bar", 23); WordsWithDar.Add("cys", 24);
            WordsWithDar.Add("ers", 25); WordsWithDar.Add("gah", 26); WordsWithDar.Add("gas", 27); WordsWithDar.Add("gle", 28);
            WordsWithDar.Add("ics", 29); WordsWithDar.Add("ing", 30); WordsWithDar.Add("ked", 31); WordsWithDar.Add("ken", 32);
            WordsWithDar.Add("ker", 33); WordsWithDar.Add("key", 34); WordsWithDar.Add("kie", 35); WordsWithDar.Add("kle", 36);
            WordsWithDar.Add("kly", 37); WordsWithDar.Add("ned", 38); WordsWithDar.Add("nel", 39); WordsWithDar.Add("ner", 40);
            WordsWithDar.Add("red", 41); WordsWithDar.Add("res", 42); WordsWithDar.Add("ted", 43); WordsWithDar.Add("ter", 44);
            WordsWithDar.Add("tle", 45); WordsWithDar.Add("tre", 46); WordsWithDar.Add("zis", 47); WordsWithDar.Add("bars", 48);
            WordsWithDar.Add("bies", 49); WordsWithDar.Add("cies", 50); WordsWithDar.Add("eful", 51); WordsWithDar.Add("esay", 52);
            WordsWithDar.Add("gahs", 53); WordsWithDar.Add("gles", 54); WordsWithDar.Add("ings", 55); WordsWithDar.Add("iole", 56);
            WordsWithDar.Add("kens", 57); WordsWithDar.Add("kest", 58); WordsWithDar.Add("keys", 59); WordsWithDar.Add("kies", 60);
            WordsWithDar.Add("king", 61); WordsWithDar.Add("kish", 62); WordsWithDar.Add("kled", 63); WordsWithDar.Add("kles", 64);
            WordsWithDar.Add("knet", 65); WordsWithDar.Add("ling", 66); WordsWithDar.Add("nels", 67); WordsWithDar.Add("ners", 68);
            WordsWithDar.Add("ning", 69); WordsWithDar.Add("ogha", 70); WordsWithDar.Add("rain", 71); WordsWithDar.Add("rayn", 72);
            WordsWithDar.Add("ring", 73); WordsWithDar.Add("shan", 74); WordsWithDar.Add("ters", 75); WordsWithDar.Add("ting", 76);
            WordsWithDar.Add("tled", 77); WordsWithDar.Add("tles", 78); WordsWithDar.Add("tres", 79); WordsWithDar.Add("ingly", 80);
            WordsWithDar.Add("ioles", 81); WordsWithDar.Add("kened", 82); WordsWithDar.Add("kener", 83); WordsWithDar.Add("klier", 84);
            WordsWithDar.Add("kling", 85); WordsWithDar.Add("kmans", 86); WordsWithDar.Add("kness", 87); WordsWithDar.Add("knets", 88);
            WordsWithDar.Add("kroom", 89); WordsWithDar.Add("ksome", 90); WordsWithDar.Add("lings", 91); WordsWithDar.Add("ndest", 92);
            WordsWithDar.Add("neder", 93); WordsWithDar.Add("nings", 94); WordsWithDar.Add("oghas", 95); WordsWithDar.Add("raign", 96);
            WordsWithDar.Add("raine", 97); WordsWithDar.Add("rains", 98); WordsWithDar.Add("rayns", 99); WordsWithDar.Add("shans", 100);
            WordsWithDar.Add("titis", 101); WordsWithDar.Add("tling", 102); WordsWithDar.Add("trous", 103); WordsWithDar.Add("edevil", 104);
            WordsWithDar.Add("keners", 105); WordsWithDar.Add("kening", 106); WordsWithDar.Add("kfield", 107); WordsWithDar.Add("kliest", 108);
            WordsWithDar.Add("klings", 109); WordsWithDar.Add("krooms", 110); WordsWithDar.Add("lingly", 111); WordsWithDar.Add("nation", 112);
            WordsWithDar.Add("ndests", 113); WordsWithDar.Add("nedest", 114); WordsWithDar.Add("raigne", 115); WordsWithDar.Add("rained", 116);
            WordsWithDar.Add("raines", 117); WordsWithDar.Add("rayned", 118); WordsWithDar.Add("tboard", 119); WordsWithDar.Add("tingly", 120);
            WordsWithDar.Add("edevils", 121); WordsWithDar.Add("ingness", 122); WordsWithDar.Add("knesses", 123); WordsWithDar.Add("nations", 124);
            WordsWithDar.Add("nedests", 125); WordsWithDar.Add("raigned", 126); WordsWithDar.Add("raignes", 127); WordsWithDar.Add("raining", 128);
            WordsWithDar.Add("rayning", 129); WordsWithDar.Add("tboards", 130); WordsWithDar.Add("titises", 130);

            if (GlobalClassAttention.totalRecallScore == 450)
            {
                btnLevel4.Visibility = Visibility.Visible;
            }

            if (WordsWithDar.ContainsKey(txtUserInput.Text))
            {
                GlobalClassAttention.totalRecallScore += 10;
                txtScore.Text = GlobalClassAttention.totalRecallScore.ToString();
                imgCorrectSign.Visibility = Visibility.Visible;
                imgX.Visibility = Visibility.Collapsed;
                WordsWithDar.Remove(txtUserInput.Text);
            }
            else
            {
                imgX.Visibility = Visibility.Visible;
                imgCorrectSign.Visibility = Visibility.Collapsed;
            }
        }

        private void btnLevel4_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TotalRecallLevel4));
        }
    }
}

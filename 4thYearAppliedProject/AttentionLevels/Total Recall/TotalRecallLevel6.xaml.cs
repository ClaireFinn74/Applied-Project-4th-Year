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
    public sealed partial class TotalRecallLevel6 : Page
    {
        public TotalRecallLevel6()
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
            Dictionary<string, int> WordsWithFun  = new Dictionary<string, int>();
            WordsWithFun.Add("", 1); WordsWithFun.Add("d", 2); WordsWithFun.Add("k", 3); WordsWithFun.Add("s", 4);
            WordsWithFun.Add("di", 5); WordsWithFun.Add("ds", 6); WordsWithFun.Add("gi", 7); WordsWithFun.Add("go", 8);
            WordsWithFun.Add("ks", 9); WordsWithFun.Add("ky", 10); WordsWithFun.Add("ny", 11); WordsWithFun.Add("ded", 12);
            WordsWithFun.Add("dic", 13); WordsWithFun.Add("dus", 14); WordsWithFun.Add("est", 15); WordsWithFun.Add("gal", 16);
            WordsWithFun.Add("gic", 17); WordsWithFun.Add("gus", 18); WordsWithFun.Add("ked", 19); WordsWithFun.Add("ker", 20);
            WordsWithFun.Add("kia", 22); WordsWithFun.Add("ned", 23); WordsWithFun.Add("nel", 24);
            WordsWithFun.Add("ner", 25); WordsWithFun.Add("ctor", 26); WordsWithFun.Add("ding", 27); WordsWithFun.Add("eral", 28);
            WordsWithFun.Add("fair", 29); WordsWithFun.Add("gals", 30); WordsWithFun.Add("goes", 31); WordsWithFun.Add("goid", 32);
            WordsWithFun.Add("gous", 33); WordsWithFun.Add("icle", 34); WordsWithFun.Add("kers", 35); WordsWithFun.Add("kias", 36);
            WordsWithFun.Add("kier", 39); WordsWithFun.Add("king", 40);
            WordsWithFun.Add("nels", 41); WordsWithFun.Add("nest", 42); WordsWithFun.Add("nier", 43); WordsWithFun.Add("nies", 44);
            WordsWithFun.Add("nily", 45); WordsWithFun.Add("ning", 46); WordsWithFun.Add("ction", 47); WordsWithFun.Add("ctors", 48);
            WordsWithFun.Add("erals", 49); WordsWithFun.Add("erary", 50); WordsWithFun.Add("ereal", 51); WordsWithFun.Add("fairs", 52);
            WordsWithFun.Add("gible", 53); WordsWithFun.Add("goids", 54); WordsWithFun.Add("guses", 55); WordsWithFun.Add("icles", 56);
            WordsWithFun.Add("iculi", 57); WordsWithFun.Add("kiest", 58); WordsWithFun.Add("neled", 59); WordsWithFun.Add("niest", 60);
            WordsWithFun.Add("nyman", 61); WordsWithFun.Add("nymen", 62); WordsWithFun.Add("ctions", 63); WordsWithFun.Add("dament", 64);
            WordsWithFun.Add("gibles", 65); WordsWithFun.Add("gicide", 66); WordsWithFun.Add("giform", 67); WordsWithFun.Add("icular", 68);
            WordsWithFun.Add("iculus", 69); WordsWithFun.Add("kiness", 70); WordsWithFun.Add("neling", 71); WordsWithFun.Add("nelled", 72);
            WordsWithFun.Add("niness", 73); WordsWithFun.Add("ctional", 74); WordsWithFun.Add("ctioned", 75); WordsWithFun.Add("daments", 76);
            WordsWithFun.Add("draiser", 77); WordsWithFun.Add("ereally", 78); WordsWithFun.Add("gicidal", 79); WordsWithFun.Add("dicides", 80);
            WordsWithFun.Add("iculars", 81); WordsWithFun.Add("nelform", 82); WordsWithFun.Add("nelling", 83); WordsWithFun.Add("ambulism", 84);
            WordsWithFun.Add("ambulist", 85); WordsWithFun.Add("ctionary", 86); WordsWithFun.Add("ctioning", 87); WordsWithFun.Add("damental", 88);
            WordsWithFun.Add("draisers", 89); WordsWithFun.Add("draising", 90); WordsWithFun.Add("gibility", 91); WordsWithFun.Add("gistatic", 92);
            WordsWithFun.Add("kinesses", 93); WordsWithFun.Add("ninesses", 94); WordsWithFun.Add("ambulisms", 95); WordsWithFun.Add("ambulists", 96);
            WordsWithFun.Add("ctionally", 97); WordsWithFun.Add("ctionless", 98); WordsWithFun.Add("damentals", 99); WordsWithFun.Add("draisings", 100);
            WordsWithFun.Add("gicidally", 101); WordsWithFun.Add("ctionalism", 102); WordsWithFun.Add("ctionalist", 103); WordsWithFun.Add("ctionality", 104);
            WordsWithFun.Add("ctionaries", 105); WordsWithFun.Add("damentally", 106); WordsWithFun.Add("gibilities", 107); WordsWithFun.Add("ctionalisms", 108);
            WordsWithFun.Add("ctionalists", 109); WordsWithFun.Add("damentalism", 110); WordsWithFun.Add("damentalist", 111); WordsWithFun.Add("ctionalistic", 112);
            WordsWithFun.Add("ctionalities", 113); WordsWithFun.Add("damentalisms", 114); WordsWithFun.Add("damentalists", 114); WordsWithFun.Add("damentalistic", 114);
            if (GlobalClassAttention.totalRecallScore == 750)
            {
                btnLevel7.Visibility = Visibility.Visible;
            }

            if (WordsWithFun .ContainsKey(txtUserInput.Text))
            {
                GlobalClassAttention.totalRecallScore += 10;
                txtScore.Text = GlobalClassAttention.totalRecallScore.ToString();
                imgCorrectSign.Visibility = Visibility.Visible;
                imgX.Visibility = Visibility.Collapsed;
            }
            else
            {
                imgX.Visibility = Visibility.Visible;
                imgCorrectSign.Visibility = Visibility.Collapsed;
            }
        }

        private void btnLevel7_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TotalRecallLevel7));
        }
    }
}

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
            Dictionary<string, int> WordsWith  = new Dictionary<string, int>();
            WordsWith .Add("", 1); WordsWith .Add("d", 2); WordsWith .Add("k", 3); WordsWith .Add("s", 4);
            WordsWith .Add("di", 5); WordsWith .Add("ds", 6); WordsWith .Add("gi", 7); WordsWith .Add("go", 8);
            WordsWith .Add("ks", 9); WordsWith .Add("ky", 10); WordsWith .Add("ny", 11); WordsWith .Add("ded", 12);
            WordsWith .Add("dic", 13); WordsWith .Add("dus", 14); WordsWith .Add("est", 15); WordsWith .Add("gal", 16);
            WordsWith .Add("gic", 17); WordsWith .Add("gus", 18); WordsWith .Add("ked", 19); WordsWith .Add("ker", 20);
            WordsWith .Add("kia", 22); WordsWith .Add("ned", 23); WordsWith .Add("nel", 24);
            WordsWith .Add("ner", 25); WordsWith .Add("ctor", 26); WordsWith .Add("ding", 27); WordsWith .Add("eral", 28);
            WordsWith .Add("fair", 29); WordsWith .Add("gals", 30); WordsWith .Add("goes", 31); WordsWith .Add("goid", 32);
            WordsWith .Add("gous", 33); WordsWith .Add("icle", 34); WordsWith .Add("kers", 35); WordsWith .Add("kias", 36);
            WordsWith .Add("kier", 39); WordsWith .Add("king", 40);
            WordsWith .Add("nels", 41); WordsWith .Add("nest", 42); WordsWith .Add("nier", 43); WordsWith .Add("nies", 44);
            WordsWith .Add("nily", 45); WordsWith .Add("ning", 46); WordsWith .Add("ction", 47); WordsWith .Add("ctors", 48);
            WordsWith .Add("erals", 49); WordsWith .Add("erary", 50); WordsWith .Add("ereal", 51); WordsWith .Add("fairs", 52);
            WordsWith .Add("gible", 53); WordsWith .Add("goids", 54); WordsWith .Add("guses", 55); WordsWith .Add("icles", 56);
            WordsWith .Add("iculi", 57); WordsWith .Add("kiest", 58); WordsWith .Add("neled", 59); WordsWith .Add("niest", 60);
            WordsWith .Add("nyman", 61); WordsWith .Add("nymen", 62); WordsWith .Add("ctions", 63); WordsWith .Add("dament", 64);
            WordsWith .Add("gibles", 65); WordsWith .Add("gicide", 66); WordsWith .Add("giform", 67); WordsWith .Add("icular", 68);
            WordsWith .Add("iculus", 69); WordsWith .Add("kiness", 70); WordsWith .Add("neling", 71); WordsWith .Add("nelled", 72);
            WordsWith .Add("niness", 73); WordsWith .Add("ctional", 74); WordsWith .Add("ctioned", 75); WordsWith .Add("daments", 76);
            WordsWith .Add("draiser", 77); WordsWith .Add("ereally", 78); WordsWith .Add("gicidal", 79); WordsWith .Add("dicides", 80);
            WordsWith .Add("iculars", 81); WordsWith .Add("nelform", 82); WordsWith .Add("nelling", 83); WordsWith .Add("ambulism", 84);
            WordsWith .Add("ambulist", 85); WordsWith .Add("ctionary", 86); WordsWith .Add("ctioning", 87); WordsWith .Add("damental", 88);
            WordsWith .Add("draisers", 89); WordsWith .Add("draising", 90); WordsWith .Add("gibility", 91); WordsWith .Add("gistatic", 92);
            WordsWith .Add("kinesses", 93); WordsWith .Add("ninesses", 94); WordsWith .Add("ambulisms", 95); WordsWith .Add("ambulists", 96);
            WordsWith .Add("ctionally", 97); WordsWith .Add("ctionless", 98); WordsWith .Add("damentals", 99); WordsWith .Add("draisings", 100);
            WordsWith .Add("gicidally", 101); WordsWith .Add("ctionalism", 102); WordsWith .Add("ctionalist", 103); WordsWith .Add("ctionality", 104);
            WordsWith .Add("ctionaries", 105); WordsWith .Add("damentally", 106); WordsWith .Add("gibilities", 107); WordsWith .Add("ctionalisms", 108);
            WordsWith .Add("ctionalists", 109); WordsWith .Add("damentalism", 110); WordsWith .Add("damentalist", 111); WordsWith .Add("ctionalistic", 112);
            WordsWith .Add("ctionalities", 113); WordsWith .Add("damentalisms", 114); WordsWith.Add("damentalists", 114); WordsWith.Add("damentalistic", 114);

            if (GlobalClassAttention.totalRecallScore == 750)
            {
                btnLevel7.Visibility = Visibility.Visible;
            }

            if (WordsWith .ContainsKey(txtUserInput.Text))
            {
                GlobalClassAttention.totalRecallScore += 10;
                txtScore.Text = GlobalClassAttention.totalRecallScore.ToString();
                imgCorrectSign.Visibility = Visibility.Visible;
                imgX.Visibility = Visibility.Collapsed;
                WordsWith .Remove(txtUserInput.Text);
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

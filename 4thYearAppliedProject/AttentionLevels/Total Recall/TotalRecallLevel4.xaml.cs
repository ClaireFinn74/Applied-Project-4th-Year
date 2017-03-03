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
    public sealed partial class TotalRecallLevel4 : Page
    {
        public TotalRecallLevel4()
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
        Dictionary<string, int> WordsWithBrea = new Dictionary<string, int>();
        WordsWithBrea.Add("ch", 1); WordsWithBrea.Add("ched", 2); WordsWithBrea.Add("chers", 3); WordsWithBrea.Add("ches", 4);
        WordsWithBrea.Add("ching", 5); WordsWithBrea.Add("d", 6); WordsWithBrea.Add("dbasket", 7); WordsWithBrea.Add("dbaskets", 8);
        WordsWithBrea.Add("dboard", 9); WordsWithBrea.Add("dboarded", 10); WordsWithBrea.Add("dboarding", 11); WordsWithBrea.Add("dboards", 12);
        WordsWithBrea.Add("dbox", 13); WordsWithBrea.Add("dboxes", 14); WordsWithBrea.Add("dcrumb", 15); WordsWithBrea.Add("dcrumbs", 16);
        WordsWithBrea.Add("ded", 17); WordsWithBrea.Add("dfruit", 18); WordsWithBrea.Add("dfruits", 19); WordsWithBrea.Add("ding", 20);
        WordsWithBrea.Add("dline", 21); WordsWithBrea.Add("dlines", 22); WordsWithBrea.Add("dnut", 23); WordsWithBrea.Add("dnuts", 24);
        WordsWithBrea.Add("ds", 25); WordsWithBrea.Add("dstick", 26); WordsWithBrea.Add("dsticks", 27); WordsWithBrea.Add("dstuff", 28);
        WordsWithBrea.Add("dstuffs", 29); WordsWithBrea.Add("dth", 30); WordsWithBrea.Add("dths", 31); WordsWithBrea.Add("dthwise", 32);
        WordsWithBrea.Add("dwinner", 33); WordsWithBrea.Add("dwinners", 34); WordsWithBrea.Add("dwinning", 35); WordsWithBrea.Add("dwinnings", 36);
        WordsWithBrea.Add("dy", 37); WordsWithBrea.Add("k", 38); WordsWithBrea.Add("kable", 39); WordsWithBrea.Add("kables", 40);
        WordsWithBrea.Add("kage", 41); WordsWithBrea.Add("kages", 42); WordsWithBrea.Add("kaway", 43); WordsWithBrea.Add("kaways", 44);
        WordsWithBrea.Add("kdown", 45); WordsWithBrea.Add("kdowns", 46); WordsWithBrea.Add("ker", 47); WordsWithBrea.Add("kers", 48);
        WordsWithBrea.Add("keven", 49); WordsWithBrea.Add("kevens", 50); WordsWithBrea.Add("kfast", 51); WordsWithBrea.Add("kfasted", 52);
        WordsWithBrea.Add("thy", 53); WordsWithBrea.Add("thtakingly", 54); WordsWithBrea.Add("kfaster", 55); WordsWithBrea.Add("kfasters", 56);
        WordsWithBrea.Add("kfasting", 57); WordsWithBrea.Add("kfasts", 58); WordsWithBrea.Add("kfront", 59); WordsWithBrea.Add("kfronts", 60);
        WordsWithBrea.Add("king", 61); WordsWithBrea.Add("kings", 62); WordsWithBrea.Add("kneck", 63); WordsWithBrea.Add("kout", 64);
        WordsWithBrea.Add("kouts", 65); WordsWithBrea.Add("ks", 66); WordsWithBrea.Add("ksaway", 67); WordsWithBrea.Add("kthrough", 68);
        WordsWithBrea.Add("kthroughs", 69); WordsWithBrea.Add("kup", 70); WordsWithBrea.Add("kups", 71); WordsWithBrea.Add("kwater", 72);
        WordsWithBrea.Add("kwaters", 73); WordsWithBrea.Add("m", 74); WordsWithBrea.Add("med", 75); WordsWithBrea.Add("ming", 76);
        WordsWithBrea.Add("ms", 77); WordsWithBrea.Add("st", 78); WordsWithBrea.Add("stbone", 79); WordsWithBrea.Add("thtaking", 80);
        WordsWithBrea.Add("stbones", 81); WordsWithBrea.Add("sted", 82); WordsWithBrea.Add("sting", 83); WordsWithBrea.Add("splate", 84);
        WordsWithBrea.Add("splates", 85); WordsWithBrea.Add("sts", 86); WordsWithBrea.Add("ststroke", 87); WordsWithBrea.Add("ststroker", 88);
        WordsWithBrea.Add("ststrokers", 89); WordsWithBrea.Add("ststrokes", 90); WordsWithBrea.Add("stwork", 91); WordsWithBrea.Add("stworks", 92);
        WordsWithBrea.Add("th", 93); WordsWithBrea.Add(" thabilities", 94); WordsWithBrea.Add(" thability", 95); WordsWithBrea.Add(" thable", 96);
        WordsWithBrea.Add("the", 97); WordsWithBrea.Add("thed", 98); WordsWithBrea.Add("ther", 99); WordsWithBrea.Add("thers", 100);
        WordsWithBrea.Add("thes", 101); WordsWithBrea.Add("their", 102); WordsWithBrea.Add("thiest", 103); WordsWithBrea.Add("thily", 104);
        WordsWithBrea.Add("thiness", 105); WordsWithBrea.Add("thinesses", 106); WordsWithBrea.Add("thing", 107); WordsWithBrea.Add("things", 108);
        WordsWithBrea.Add("thless", 109); WordsWithBrea.Add("thlessly", 110); WordsWithBrea.Add("thlessness", 111); WordsWithBrea.Add("thlessnesses", 112);
        WordsWithBrea.Add("ths", 113);

            if (GlobalClassAttention.totalRecallScore == 600)
        {
            btnLevel5.Visibility = Visibility.Visible;
        }

        if (WordsWithBrea.ContainsKey(txtUserInput.Text))
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

    private void btnLevel5_Click(object sender, RoutedEventArgs e)
    {
        Frame.Navigate(typeof(TotalRecallLevel5));
    }
    }
}

using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace _4thYearAppliedProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HighScores : Page
    {
        public HighScores()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
   
            //ProgressBarRequest.Visibility = Visibility.Visible; 
           // System.Net.WebRequest request = WebRequest.Create(@"http://104.214.108.15/query/selectHighscores.json?limit=10");
           // request.Headers.Add("user_key", "61527b29:5a031433fff9ff3edbcbc9f13f7b7026");
        }
    }
}

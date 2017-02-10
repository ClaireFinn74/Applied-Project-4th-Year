using AppliedProject4thYear;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using System.Windows.Input;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using _4thYearAppliedProject;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AppliedProject4thYear
{
    public sealed partial class ManicMath : Page
    {
        IPropertySet propertySet = ApplicationData.Current.RoamingSettings.Values;


        public ManicMath()
        {
            this.InitializeComponent();
        }

        DispatcherTimer dispatcherTimer;
        int timesTicked = 60;
        public void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        async void dispatcherTimer_Tick(object sender, object e)
        {
            TimerLog.Text = timesTicked.ToString();
            
            timesTicked--;

            if (timesTicked == -1)
            {
                dispatcherTimer.Stop(); // stops timer going below 0
                var dialog = new Windows.UI.Popups.MessageDialog
                ("Out of time! You scored a total of: " + score);
                var result = await dialog.ShowAsync();
                Frame.Navigate(typeof(CreditsPage));
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
            TimerStatus.Text = "dispatcherTimer.IsEnabled = False";
        }

        // Variables
        string[] Names = new string[] { "Thomas", "Declan", "Claire", "Padraic", "Alanna" };
        string[] Names2 = new string[] { " Yvonne "," Scott "," Robert "," Oliver ", " Pauric ", };
        string[] fruits = new string[] {" Apples "," Bananas "," Grapes "," Mangos "," Oranges " };
        string[] fruits2 = new string[] { " Kiwis", " Plums", " Peaches", " Passionfruits", " Cherries" };

        int indexName;
        int indexName2;
        int indexNumberOf;
        int indexFruit;
        int indexFruit2;
        int indexNumberOf2;
        int score;


        Random rand = new Random();
        Random rand2 = new Random();
        Random rnd = new Random();
        Random rnd2 = new Random();
        Random rndFruit = new Random();
        Random rndFruit2 = new Random();



        private void PSGBackBtn_Click(object sender, RoutedEventArgs e)
        {
            timesTicked = -2;
            this.Frame.Navigate(typeof(ProblemSolvingGames), null); // sends player back to the Problem Solving Games
        }

        public void btn_MMStart_Click(object sender, RoutedEventArgs e)
        {
            txtAnswer.Focus(FocusState.Programmatic);

            DispatcherTimerSetup();

            Random rnd2 = new Random();
            btn_MMStart.Visibility = Visibility.Collapsed;
            btnAnswer.Visibility = Visibility.Visible;
            lblAnswer.Visibility = Visibility.Visible;
            txtAnswer.Visibility = Visibility.Visible;

            // gives the player a question to answer
            indexName = rand.Next(Names.Length);
            indexName2 = rand2.Next(Names2.Length);
            indexNumberOf = rnd.Next(1, 50);
            indexFruit = rndFruit.Next(fruits.Length);
            indexFruit2 = rndFruit2.Next(fruits2.Length);
            indexNumberOf2 = rnd2.Next(1, 50);


            txtMathQuestion.Text = "If " + Names[indexName] + " has " + indexNumberOf + fruits[indexFruit]
                +"and" + Names2[indexName2] + " has " + indexNumberOf2 + fruits2[indexFruit2] + ", how many fruits do they have altogether?"; 
            indexName = rand.Next(Names.Length);
            indexName2 = rand2.Next(Names2.Length);
            if(score <= 6 )
            {
                indexNumberOf = rnd.Next(1, 10);
            }
            else if(score > 6)
            {
                indexNumberOf = rnd.Next(10, 20);
            }
            indexFruit = rndFruit.Next(fruits.Length);
            indexFruit2 = rndFruit2.Next(fruits2.Length);
            if (score <= 6)
            {
                indexNumberOf2 = rnd2.Next(1, 10);
            }
            else if(score > 6)
            {
                indexNumberOf2 = rnd2.Next(10, 20);
            }
            
            txtMathQuestion.Text = "If " + Names[indexName] + " has " + indexNumberOf + fruits[indexFruit]
                +"and" + Names2[indexName2] + " has " + indexNumberOf2 + fruits2[indexFruit2] + ", how many fruits do they have altogether?"; 
        }

       
        
        private async void btnAnswer_Click(object sender, RoutedEventArgs e)
        {

            int myAnswer = indexNumberOf + indexNumberOf2;
            int anInteger;
        
            anInteger = Convert.ToInt32(txtAnswer.Text);
            anInteger = int.Parse(txtAnswer.Text);

            if (myAnswer == anInteger)
            {
                var dialog = new Windows.UI.Popups.MessageDialog("YOU ARE CORRECT, WELL DONE!");
                var result = await dialog.ShowAsync();
                timesTicked += 2; // adds time for clicking out of the message dialog
                score++;
                txtAnswer.Text = "";

                // gives the player a new question after getting a correct answer
                indexName = rand.Next(Names.Length);
                indexName2 = rand2.Next(Names2.Length);
                if (score % 5 == 0)
                {
                    timesTicked += 10;
                }
                if (score < 6)
                {
                    indexNumberOf = rnd.Next(1, 10);
                }
                else if (score >= 6 && score < 11)
                {
                    indexNumberOf = rnd.Next(10, 20);
                }
                else if (score >= 11 && score < 16)
                {
                    indexNumberOf = rnd.Next(30, 50);
                }
                else if (score >= 16 && score < 21)
                {
                    indexNumberOf = rnd.Next(60, 80);
                }
                else if (score >= 21 && score < 26)
                {
                    indexNumberOf = rnd.Next(100, 150);
                }
                else if (score >= 31 && score < 36)
                {
                    indexNumberOf = rnd.Next(180, 300);
                }
                else if (score >= 36 && score < 41)
                {
                    indexNumberOf = rnd.Next(500, 1000);
                }
                else if (score >= 41 && score < 46)
                {
                    indexNumberOf = rnd.Next(1500, 3000);
                }
                else if (score >= 46)
                {
                    indexNumberOf = rnd.Next(5000, 10000);
                }

                indexFruit = rndFruit.Next(fruits.Length);
                indexFruit2 = rndFruit2.Next(fruits2.Length);
                if (score < 6)
                {
                    indexNumberOf2 = rnd.Next(1, 10);
                }
                else if (score >= 6 && score < 11) 
                {
                    indexNumberOf2 = rnd.Next(10, 20);
                }
                else if (score >= 11 && score < 16)
                {
                    indexNumberOf2 = rnd.Next(30, 50);
                }
                else if (score >= 16 && score < 21)
                {
                    indexNumberOf2 = rnd.Next(60, 80);
                }
                else if (score >= 21 && score < 26)
                {
                    indexNumberOf2 = rnd.Next(100, 150);
                }
                else if (score >= 31 && score < 36)
                {
                    indexNumberOf2 = rnd.Next(180, 300);
                }
                else if (score >= 36 && score < 41)
                {
                    indexNumberOf2 = rnd.Next(500, 1000);
                }
                else if (score >= 41 && score < 46)
                {
                    indexNumberOf2= rnd.Next(1500, 3000);
                }
                else if (score >= 46)
                {
                    indexNumberOf2 = rnd.Next(5000, 10000);
                }


                txtMathQuestion.Text = "If " + Names[indexName] + " has " + indexNumberOf + fruits[indexFruit]
                    + "and" + Names2[indexName2] + " has " + indexNumberOf2 + fruits2[indexFruit2] + ", how many fruits do they have altogether?";

                txtScore.Text = score.ToString();
               


            }
            else if(myAnswer != anInteger)
            {
                var dialog = new Windows.UI.Popups.MessageDialog("YOU ARE WRONG, TRY AGAIN!");
                var result = await dialog.ShowAsync();

                // gives the player a new question after getting the previous question wrong
                indexName = rand.Next(Names.Length);
                indexName2 = rand2.Next(Names2.Length);
                if (score % 5 == 0)
                {
                    timesTicked += 10;
                }
                if (score < 6)
                {
                    indexNumberOf = rnd.Next(1, 10);
                }
                else if (score >= 6 && score < 11)
                {
                    indexNumberOf = rnd.Next(10, 20);
                }
                else if (score >= 11 && score < 16)
                {
                    indexNumberOf = rnd.Next(30, 50);
                }
                else if (score >= 16 && score < 21)
                {
                    indexNumberOf = rnd.Next(60, 80);
                }
                else if (score >= 21 && score < 26)
                {
                    indexNumberOf = rnd.Next(100, 150);
                }
                else if (score >= 31 && score < 36)
                {
                    indexNumberOf = rnd.Next(180, 300);
                }
                else if (score >= 36 && score < 41)
                {
                    indexNumberOf = rnd.Next(500, 1000);
                }
                else if (score >= 41 && score < 46)
                {
                    indexNumberOf = rnd.Next(1500, 3000);
                }
                else if (score >= 46)
                {
                    indexNumberOf = rnd.Next(5000, 10000);
                }
                indexFruit = rndFruit.Next(fruits.Length);
                indexFruit2 = rndFruit2.Next(fruits2.Length);
                if (score < 6)
                {
                    indexNumberOf2 = rnd.Next(1, 10);
                }
                else if (score >= 6 && score < 11)
                {
                    indexNumberOf2 = rnd.Next(10, 20);
                }
                else if (score >= 11 && score < 16)
                {
                    indexNumberOf2 = rnd.Next(30, 50);
                }
                else if (score >= 16 && score < 21)
                {
                    indexNumberOf2 = rnd.Next(60, 80);
                }
                else if (score >= 21 && score < 26)
                {
                    indexNumberOf2 = rnd.Next(100, 150);
                }
                else if (score >= 31 && score < 36)
                {
                    indexNumberOf2 = rnd.Next(180, 300);
                }
                else if (score >= 36 && score < 41)
                {
                    indexNumberOf2 = rnd.Next(500, 1000);
                }
                else if (score >= 41 && score < 46)
                {
                    indexNumberOf2 = rnd.Next(1500, 3000);
                }
                else if (score >= 46)
                {
                    indexNumberOf2 = rnd.Next(5000, 10000);
                }



                txtMathQuestion.Text = "If " + Names[indexName] + " has " + indexNumberOf + fruits[indexFruit]
                    + "and" + Names2[indexName2] + " has " + indexNumberOf2 + fruits2[indexFruit2] + ", how many fruits do they have altogether?";
                return;
            }
            txtAnswer.Focus(FocusState.Programmatic);
           
        }

      
    }
}

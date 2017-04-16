using _4thYearAppliedProject;
using AppliedProject4thYear.MemoryLevels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AppliedProject4thYear.MemoryLevels
{
    public sealed partial class ShoppingList : Page
    {

        //- Setting up the constant variables for the 10 shopping item options, the game length and the info strings.
        const int NUM_OF_ITEMS = 10;
        const int CARROTS = 1;
        const int STEAK = 2;
        const int MILK = 3;
        const int BREAD = 4;
        const int COOKIES = 5;
        const int JUICE = 6;
        const int CEREAL = 7;
        const int ORANGE = 8;
        const int PASTA = 9;
        const int CHOCOLATE = 10;

        const int MAX_ITEM_COUNT = 50;
        const String START_STRING = "Click to start!";
        const String WIN_STRING = "YOU WIN!";

        //- Keeps track of the current number of items in the shopping list.
        int shoppingListItemCount = 0;

        //- Variables for setting up the arrays for the shopping list.
        Random randNum;
        int[] rightItemSequence;
        int[] userItemSequence;
        int rightItemSequenceIndex = 0;
        int userItemSequenceIndex = 0;

        int onInList = 0;
        List<int> shoppingList = new List<int>();
        Random rand = new Random();

        //- Variables to keep track of the game state.
        bool playingBack = false;
        Boolean isUserTurn = true;
        Boolean isListRight = false;
        Boolean isGameStarted = false;
        Boolean isDoingAnimation = false;
        //private object Colors;

        public ShoppingList()
        {
            this.InitializeComponent();

            btnStart.Visibility = Visibility.Visible;
            randNum = new Random();
            shoppingList.Add(rand.Next(1, 11));

            rightItemSequence = new int[MAX_ITEM_COUNT];
            userItemSequence = new int[MAX_ITEM_COUNT];
            initItemSequence();

            txtbScore.Opacity = 0;
            //Correct.Opacity = 0;
            //Incorrect.Opacity = 0;

            GlobalClassVariables.score = 0;
            GlobalClassVariables.gameName = "(Shopping List Score) " + "\n";
        }//- End of ShoppingList()

        private void initItemSequence()
        {
            //- Alter this to start with 3 Items and add the users choices to the list and then check against it.
            for (int i = 0; i < 4; i++)
            {
                rightItemSequence[i] = randNum.Next(1, NUM_OF_ITEMS);
                userItemSequence[i] = 0;
            }//- End of for
        }//- End of initItemSequence()
/*
        private void gameStart()
        {
            shoppingListItemCount = 0;
            txtbScore.Text = shoppingListItemCount.ToString();
            //txtBlkRoundNum.Foreground = new SolidColorBrush(Colors.Black);
            txtbScore.Opacity = 100;
            txtbScore.Opacity = 0;
            Correct.Opacity = 0;
            Incorrect.Opacity = 0;
            isGameStarted = true;
            userItemSequenceIndex = 0;
            initItemSequence();
            isUserTurn = false;
            gameContinue();
        }//- End of gameStart()

        private void gameContinue()
        {
            isListRight = true;
            for (int i = 0; i < (userItemSequenceIndex - 1); i++)
            {
                if (rightItemSequence[i] == userItemSequence[i])
                {
                    //- If sequence is right, add the new item to the rightItemSequence and leave isListRight as true.
                    rightItemSequence = userItemSequence;
                    Correct.Opacity = 100;
                }
                else
                {
                    //- If sequence is wrong, set isListRight to false and break the loop.
                    isListRight = false;
                    Incorrect.Opacity = 100;
                    break;
                }//- End of if/else
            }
            if (isListRight)
            {
                if (userItemSequenceIndex >= shoppingListItemCount)
                {
                    shoppingListItemCount++;
                    if (shoppingListItemCount < MAX_ITEM_COUNT)
                    {
                        //- If the current sequenceCount is less than the max then display the count.
                        txtbScore.Text = shoppingListItemCount.ToString();
                    }
                    else
                    {
                        //- If the current sequenceCount is greater than or equal to the max then end the game.
                        gameOver(WIN_STRING);
                    }//- End of inner inner if/else
                }
                else
                {
                    //- If the userColourSequenceIndex is less than the sequenceCount then set isUserTurn to true. 
                    //playerColorSequenceIndex++; 
                    Correct.Opacity = 0;
                    Incorrect.Opacity = 0;
                    isUserTurn = true;
                }//- End of inner if/else
            }
            else
            {
                //- If isSequenceRight is false, then end the game.
                gameOver(START_STRING);
            }//- End of outer if/else
        }//- End of gameContinue()

        private void gameOver(String gameOverMessage)
        {
            isGameStarted = false;
            btnStart.Visibility = Visibility.Visible;
            //txtBlkStart.Text = gameOverMessage;
            //txtBlkStart.Opacity = 100;
            //txtBlkRoundNum.Foreground = new SolidColorBrush(Colors.Grey);
            txtbScore.Opacity = 40;
            isUserTurn = true;
        }//- End of gameOver()
*/

         private async void testCorrect(int Item)
        {
            txtbScore.Text = onInList.ToString();
            if (playingBack)
                return;

            if (shoppingList[onInList] == Item)
            onInList++;

            else
            {
                GlobalClassVariables.score = shoppingList.Count;
                var dialog = new MessageDialog("Wrong Item! Game Over. Final Score: " + shoppingList.Count.ToString());
                await dialog.ShowAsync();
                //Go back to SQLiteScores
                Frame.Navigate(typeof(SQLiteScores));
                
            }//- End of if/else

            if (onInList >= shoppingList.Count)
            {
                shoppingList.Add(rand.Next(1, 11));
                onInList = 0;
                playback();
            }//- End of if

            txtBlkRoundNum.Text = (shoppingList.Count.ToString());
        }//- End of testCorrect()

        private async void playback()
        {
            playingBack = true;
            foreach (int item in shoppingList)
            {
                switch (item)
                {
                    case 1:
                        storyboardCarrot.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                    case 2:
                        storyboardSteak.Begin();
                        //yellowRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //yellowRectangle.Opacity = 100;
                        break;
                    case 3:
                        storyboardMilk.Begin();
                        //greenRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //greenRectangle.Opacity = 100;
                        break;
                    case 4:
                        storyboardBread.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                    case 5:
                        storyboardCookies.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                    case 6:
                        storyboardJuice.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                    case 7:
                        storyboardCereal.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                    case 8:
                        storyboardOrange.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                    case 9:
                        storyboardPasta.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                    case 10:
                        storyboardChocolate.Begin();
                        //blueRectangle.Opacity = 0;
                        await Task.Delay(200);
                        //blueRectangle.Opacity = 100;
                        break;
                }//- End of switch
                await Task.Delay(200);
            }//- end of foreach

            playingBack = false;
        }//- End of playback()

        private void MainMenuAppBarBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }//- End of MainMenuAppBarBtn_Click

        private void BackAppBarBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MemoryNav));
        }//- End of BackAppBarBtn_Click

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            btnStart.Visibility = Visibility.Collapsed;
            txtBlkRoundNum.Text = ("0");
            playback();
        }

        private void CarrotImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardCarrotPlayer.Begin();
            testCorrect(1);
        }

        private void SteakImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardSteakPlayer.Begin();
            testCorrect(2);
        }

        private void MilkImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardMilkPlayer.Begin();
            testCorrect(3);
        }

        private void BreadImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardBreadPlayer.Begin();
            testCorrect(4);
        }

        private void CookiesImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardCookiesPlayer.Begin();
            testCorrect(5);
        }

        private void JuiceImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardJuicePlayer.Begin();
            testCorrect(6);
        }

        private void CerealImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardCerealPlayer.Begin();
            testCorrect(7);
        }

        private void OrangeImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardOrangePlayer.Begin();
            testCorrect(8);
        }

        private void PastaImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardPastaPlayer.Begin();
            testCorrect(9);
        }

        private void ChocolateImage_Tapped(object sender, TappedRoutedEventArgs e)
        {
            storyboardChocolatePlayer.Begin();
            testCorrect(10);
        }
    }//- End of ShoppingList
}//- End of AppliedProject4thYear.Memory

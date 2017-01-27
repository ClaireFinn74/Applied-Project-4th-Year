﻿using _4thYearAppliedProject.AttentionLevels.Picture_Perect;
using AppliedProject4thYear.AttentionLevels;
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

namespace _4thYearAppliedProject.AttentionLevels.Picture_Perect
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SmartPhone : Page
    {
        public SmartPhone()
        {
            this.InitializeComponent();
        }

        int btnTappedElevenPhones = 0;
        int btnTappedBlackberry = 0;
        int btnTappedTimeTwelve = 0;
        int btnTappedButtons = 0;
        int btnTappedAndroidLogo = 0;
        int btnTappedS = 0;

        private void btnElevenPhones_Click(object sender, RoutedEventArgs e)
        {
            btnTappedElevenPhones++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnElevenPhones.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 34)
            {
                Frame.Navigate(typeof(PicturePerfect7));
            }
        }

        private async void btnTenPhones_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Count again!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnBlackberry_Click(object sender, RoutedEventArgs e)
        {
            btnTappedBlackberry++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnBlackberry.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 34)
            {
                Frame.Navigate(typeof(PicturePerfect7));
            }
        }

        private void btnTimeTwelve_Click(object sender, RoutedEventArgs e)
        {
            btnTappedTimeTwelve++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnTimeTwelve.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 34)
            {
                Frame.Navigate(typeof(PicturePerfect7));
            }
        }

        private void btnButtons_Click(object sender, RoutedEventArgs e)
        {
            btnTappedButtons++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnButtons.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 34)
            {
                Frame.Navigate(typeof(PicturePerfect7));
            }
        }

        private void btnAndroidLogo_Click(object sender, RoutedEventArgs e)
        {
            btnTappedAndroidLogo++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnAndroidLogo.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 34)
            {
                Frame.Navigate(typeof(PicturePerfect7));
            }
        }

        private async void btnTimeNine_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! There were lots of different times but none were 9:00!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private void btnS_Click(object sender, RoutedEventArgs e)
        {
            btnTappedS++;
            GlobalClassAttention.score++;
            txtbScore.Text = GlobalClassAttention.score.ToString();
            btnS.Visibility = Visibility.Collapsed;
            if (GlobalClassAttention.score == 34)
            {
                Frame.Navigate(typeof(PicturePerfect7));
            }
        }

        private async void btnHeadPhones_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Nope, all Mobile phones, no Headphones!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }

        private async void btnTelephone_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("OOPS! Nope, all Mobile Phones, no Telephones!" + "\n" + "Too Bad, Try again another time!");
            await dialog.ShowAsync();
            Frame.Navigate(typeof(PicturePerfect));
        }
    }
}

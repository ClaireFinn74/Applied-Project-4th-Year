using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class PicturePerfect3 : Page
    {
        public PicturePerfect3()
        {
            this.InitializeComponent();
        }

        private void btnBeginHouse_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(House));
        }

        private void btnPicturePerfect_Click(object sender, RoutedEventArgs e)
        {
            //the House image becomes visible
            imgPicturePerfectHouse.Visibility = Visibility.Visible;
            btnBeginHouse.Visibility = Visibility.Visible;
        }
    }
}

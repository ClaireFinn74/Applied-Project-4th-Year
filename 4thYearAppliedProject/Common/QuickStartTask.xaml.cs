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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace _4thYearAppliedProject.Common
{
    public sealed partial class QuickStartTask : UserControl
    {
        public QuickStartTask()
        {
            this.InitializeComponent();
            #region ref - MSDN - DataContext:  
            /* 
            The DataContext is the source of all entities mapped over
            a database connection.
            It tracks changes that you made to all retrieved entities
            and maintains an "identity cache" that guarantees that
            entities retrieved more than once are represented by using
            the same object instance.
            A DataContext is lightweight and is not expensive to create.
            */
            #endregion
            DataContext = this;
        }

        /*Getting and setting a variable Number so that we can associate a number
        to the task */
        public int Number
        {
            get { return (int)GetValue(NumberProperty); }
            set { SetValue(NumberProperty, value); }
        }

        #region ref - MSDN - Dependency Property
        /* Using a DependencyProperty as the backing store for Number.
        This enables binding, etc.
        We can now use our Number variable as a DependancyProperty.
        The naming convention of the property field is important. 
        The name of the field is always the name of the property,
        with the suffix Property appended.*/
        #endregion
        #region ref - MSDN - Dependancy Property Metadata
        /* Dependency property metadata exists as an object that can be queried to
           examine the characteristics of a dependency property.
           This metadata is also accessed frequently by the property system as it
           processes any given dependency property.
           The metadata object for a dependency property can contain info
           such as Default value for the dependency property,
           Refs to callback implementations */
        #endregion
        public static readonly DependencyProperty NumberProperty =
        DependencyProperty.Register("Number", typeof(int),
        typeof(QuickStartTask), new PropertyMetadata(0));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty TitleProperty =
        DependencyProperty.Register("Title", typeof(string),
        typeof(QuickStartTask), new PropertyMetadata(default(string)));

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public static readonly DependencyProperty DescriptionProperty =
        DependencyProperty.Register("Description", typeof(string),
        typeof(QuickStartTask), new PropertyMetadata(default(string)));

        public Visibility LayoutFormatVisibility = Visibility.Visible;

        public bool ShowMinimal
        {
            get { return (bool)GetValue(ShowMinimalProperty); }
            set { SetValue(ShowMinimalProperty, value); }
        }

        public static readonly DependencyProperty ShowMinimalProperty =
        DependencyProperty.Register("ShowMinimal", typeof(bool),
        typeof(QuickStartTask),
        new PropertyMetadata(false, new PropertyChangedCallback(ChangeShowMinimal)));

        private static void ChangeShowMinimal(DependencyObject source, DependencyPropertyChangedEventArgs e)
        { 
            (source as QuickStartTask).LayoutFormatVisibility = ((bool)e.NewValue == true) ? Visibility.Collapsed : Visibility.Visible;
            (source as QuickStartTask).Bindings.Update();
        }
    }
}

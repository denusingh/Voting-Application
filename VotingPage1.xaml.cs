using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWPLoginPage.Model;
using UWPLoginPage.ViewModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPLoginPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class VotingPage1 : Page
    {
        public VotingPage1()
        {
            this.InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            SelectedParty.Text = "Labour Party";
              Frame.Navigate(typeof(VotingPage2));    
            

        }

        private void Button_Click0(object sender, RoutedEventArgs e)
        {
            SelectedParty.Text = "National Party";
            Frame.Navigate(typeof(VotingPage2));
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SelectedParty.Text = "Green Party";
            Frame.Navigate(typeof(VotingPage2));
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            SelectedParty.Text = "New Zealand First";
            Frame.Navigate(typeof(VotingPage2));
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            SelectedParty.Text = "Maori Party";
            Frame.Navigate(typeof(VotingPage2));
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            SelectedParty.Text = "ACT";
            Frame.Navigate(typeof(VotingPage2));
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            SelectedParty.Text = "United Future";
            Frame.Navigate(typeof(VotingPage2));
        }
    }
}

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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPLoginPage
{
    
    public class MyItem
    {
        public string ImagePath { get; set; }

        public string ImageName { get; set; }
    }

    public sealed partial class WelcomePage : Page
    {
        List<MyItem> listImages = new List<MyItem>();

        public WelcomePage()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            InitIamge();
            flipView.ItemsSource = listImages;

        }

        private void InitIamge()
        {
            listImages.Add(new MyItem() { ImageName = "Welcome", ImagePath = "ms-appx:///Assets/voteelection_og.png" });
            listImages.Add(new MyItem() { ImageName = "Check Update", ImagePath = "ms-appx:///Assets/1.jpg" });
            listImages.Add(new MyItem() { ImageName = "Language", ImagePath = "ms-appx:///Assets/2nd.jpg" });
            listImages.Add(new MyItem() { ImageName = "Find Your Boundaries", ImagePath = "ms-appx:///Assets/Last.png" });
            

        }


    }
    
}

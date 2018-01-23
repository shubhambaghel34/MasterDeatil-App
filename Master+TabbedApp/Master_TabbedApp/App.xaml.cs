using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Master_TabbedApp
{
    public partial class App : Application
    {
        MainPage masterPage;
        private readonly MainPage Master;
        private readonly NavigationPage Detail;

        public App()
        {
            InitializeComponent();
            Master = masterPage;
            Detail = new NavigationPage(new Page1());
            // MainPage = new Master_TabbedApp.MainPage();





            var tabbedPage = new TabbedPage();
            tabbedPage.Children.Add(new Page1() { Title = " Page 1" });
            tabbedPage.Children.Add(new Page2() {Title="Page 2" });
            tabbedPage.Children.Add(new Page3() { Title = "Page 3" });

            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());
  
          














            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = " Page Detail",
                IconSource = "Androidimage",
                TargetType = typeof(TabbedPage)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = " Page Detail",
                IconSource = "Icon-76",
                TargetType = typeof(TabbedPage)

            });







            var masterListView = new ListView
            {
                ItemsSource = masterPageItems,
                ItemTemplate = new DataTemplate(() =>
                {
                    var imageCell = new ImageCell();
                    imageCell.SetBinding(TextCell.TextProperty, "Title");
                    imageCell.SetBinding(ImageCell.ImageSourceProperty, "IconSource");
                    return imageCell;
                }),
                VerticalOptions = LayoutOptions.FillAndExpand,
                SeparatorVisibility = SeparatorVisibility.Default,
              SeparatorColor = Color.Transparent
        };

            var masterDetailPage = new MasterDetailPage
            {
                Detail = new NavigationPage(tabbedPage),
                Master = new ContentPage
                {

                    Content = masterListView,
                    Icon = "Ic.png",
                    Title = " ", 
                    Padding = new Thickness(0, 20, 0, 0)
                }
            };

            MainPage = masterDetailPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

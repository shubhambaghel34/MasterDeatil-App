using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace Master_TabbedApp
{
    public partial class MainPage :  MasterDetailPage
    {
        MainPage masterPage;

        public List<MasterPageItem> menuList { get; set; }

        public MainPage()
        {
            masterPage = new MainPage();
            



           // InitializeComponent();
            menuList = new List<MasterPageItem>();
            var page1 = new MasterPageItem() { Title = "Item 1", IconSource = "icon.png", TargetType = typeof(Page1) };
            var page2 = new MasterPageItem() { Title = "Item 2", IconSource = "icon.png", TargetType = typeof(Page2) };
            var page3 = new MasterPageItem() { Title = "Item 3", IconSource = "icon.png", TargetType = typeof(Page3) };

            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
         
            
           
           

        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Master_TabbedApp
{
  public  class Page1: ContentPage
    {
        Button btn;
        public Page1()
        {
            Title = "Page1 tab";
            btn = new Button
            {
                Text = "Click to navigate",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromHex("#FF5733")

            };
            btn.Clicked += Btn_Clicked;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new Label
                    {
                        Text = "page1 here"
                    },
                    btn
                }
            };

        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
            //throw new NotImplementedException();
        }
    }
}

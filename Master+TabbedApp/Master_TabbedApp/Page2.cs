using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Master_TabbedApp
{
  public   class Page2: ContentPage
    {
        Button btn2;
        public Page2()
        {
            Title = "Page2 tab";
            btn2 = new Button
            {
                Text = "Click to navigate",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromHex("#f6546a")

            };
            btn2.Clicked += Btn_Clicked;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new Label
                    {
                        Text = "page2 here"
                    },
                    btn2
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


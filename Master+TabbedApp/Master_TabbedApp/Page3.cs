using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Master_TabbedApp
{
   public class Page3:ContentPage
    {
        Button btn3;
        public Page3()
        {

            Title = "Page3 tab";
            btn3 = new Button
            {
                Text = "Click to navigate",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                BackgroundColor = Color.FromHex("#116163")

            };
            btn3.Clicked += Btn_Clicked;
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                Children = {
                    new Label
                    {
                        Text = "page3 here"
                    },
                    btn3
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


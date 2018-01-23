using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Master_TabbedApp
{
   public  class Page4: ContentPage
    {
        Label lbl;
        // ToolbarItem tlbr;
        Button btn1;
        public Page4()
        {
            btn1 = new Button
            {
                Text = "Move to Page2",
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Center,
                BackgroundColor=Color.AliceBlue
            };
            btn1.Clicked += Btn1_Clicked;
            lbl = new Label
            {
                Text = "Go back to page",
                HorizontalOptions=LayoutOptions.Center,
                VerticalOptions=LayoutOptions.Center
            };
            Content = new StackLayout
            {
                Children =
                {
                    lbl,
                    btn1
                   
                }
            };
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
           
        }
    }
}

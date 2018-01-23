using Xamarin.Forms;

namespace Master_TabbedApp
{
    public class SamplePage : ContentPage
    {
        Button btn;
        public SamplePage(string title)
        {
            Title = title;
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
                HorizontalOptions=LayoutOptions.Center,
                Children = {
                    new Label
                    {
                        Text = title
                    },
                    btn
                }
            };
        }

        private void Btn_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }
    }
}
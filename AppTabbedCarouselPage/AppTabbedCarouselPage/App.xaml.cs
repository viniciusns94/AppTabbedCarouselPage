using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTabbedCarouselPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CarouselPage cs = new CarouselPage();
            cs.Children.Add(new MainPage());
            cs.Children.Add(new Page1());
            cs.Children.Add(new Page2());

            TabbedPage tb = new TabbedPage();            
            tb.Children.Add(new MainPage());
            tb.Children.Add(new Page1());
            tb.Children.Add(cs);
            
            MainPage = tb;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

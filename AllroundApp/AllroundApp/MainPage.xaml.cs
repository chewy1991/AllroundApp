using System;
using AllroundApp.Shopping.View;
using Xamarin.Forms;

namespace AllroundApp
{
    public partial class MainPage : ContentPage
    {
        public ShoppingMainView Content = new ShoppingMainView();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ShoppingMainView());
        }
    }
}
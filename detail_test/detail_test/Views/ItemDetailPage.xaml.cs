using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using detail_test.Models;
using detail_test.ViewModels;
namespace detail_test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        //private const string videoLink = "https://vimeo.com/299692054";
        private const string videoLink = "https://archive.org/download/BigBuckBunny_328/BigBuckBunny_512kb.mp4";
        private void Handle_Clicked(object sender, System.EventArgs e)
        {
            switch (ControlButton.Text)
            {
                case "Play":
                    ControlButton.Text = "Pause";
                    ControlButton.BackgroundColor = Color.Gray;
                    break;
                case "Pause":
                    ControlButton.Text = "Play";
                    ControlButton.BackgroundColor = Color.LimeGreen;
                    break;
            }
        }

        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}
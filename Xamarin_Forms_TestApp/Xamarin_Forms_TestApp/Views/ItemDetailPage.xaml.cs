using System.ComponentModel;
using Xamarin.Forms;
using Xamarin_Forms_TestApp.ViewModels;

namespace Xamarin_Forms_TestApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
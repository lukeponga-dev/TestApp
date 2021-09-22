using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin_Forms_TestApp.ViewModels;
using Xamarin_Forms_TestApp.Views;

namespace Xamarin_Forms_TestApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}

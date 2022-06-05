using Benefit.Me.ViewModels;
using Benefit.Me.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Benefit.Me
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

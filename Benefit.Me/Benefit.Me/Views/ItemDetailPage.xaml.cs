using Benefit.Me.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Benefit.Me.Views
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
using DocShifting.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DocShifting.Views
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
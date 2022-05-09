using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moda_Cruz.ViewModels;
using Moda_Cruz.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityTab : ContentPage
    {
        public ActivityTab()
        {
            InitializeComponent();
            
        }
        async void DolaplrLV(object sender,EventArgs args)
        {
            await Navigation.PushModalAsync(new DolapAra());
        }
        private async void ActivitySelection(object sender, SelectionChangedEventArgs e)
        {
            var itemSelected = e.CurrentSelection[0] as Urunler;
            await Navigation.PushModalAsync(new ProducDetailPage(itemSelected));
        }

    }
}
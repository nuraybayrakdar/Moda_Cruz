using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }
        async void UyeClicked(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new TabControl1());
        }
        async void GirisClicked(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new TabControl1());
        }
    }
}
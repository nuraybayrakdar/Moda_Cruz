using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Moda_Cruz.Models;

namespace Moda_Cruz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchTab : ContentPage
    {
       
        public SearchTab()
        {
            InitializeComponent();    
        }
      /*  private void searchbar2TextChanged(object sender, TextChangedEventArgs e)
        {

            var filteredlist = urunler2.Where(a => a.Name.StartsWith(e.NewTextValue));
            Urunlerim2.ItemsSource = filteredlist;

        } */
    }
}
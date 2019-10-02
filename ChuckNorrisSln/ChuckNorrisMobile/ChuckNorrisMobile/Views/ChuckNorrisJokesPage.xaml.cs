using ChuckNorrisMobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ChuckNorrisMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChuckNorrisJokesPage : ContentPage
    {
        public ChuckNorrisJokesPage()
        {
            InitializeComponent();

            BindingContext = new ChuckNorrisViewModel(); ;
        }
    }
}
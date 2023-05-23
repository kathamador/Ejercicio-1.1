using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimerParcial
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void BtEjercicio11_Clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ejercicio11());
        }
    }
}


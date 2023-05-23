using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PrimerParcial
{	
	public partial class Ejercicio11 : ContentPage
    {

        public float Numero1 { get; set; } = 0;
		public float Numero2 { get; set; } = 0;

        public Ejercicio11()
		{
			BindingContext = this;
            InitializeComponent();
		}

        async void BtSumar_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(
                new Ejercicio11Resultado(
                    $"La suma de {Numero1} + {Numero2} es: ",
                    Numero1 + Numero2)
            );
        }

        async void BtRestar_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(
                new Ejercicio11Resultado(
                    $"La Resta de {Numero1} - {Numero2} es: ",
                    Numero1 - Numero2)
            );
        }

        async void BtDividir_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(
                new Ejercicio11Resultado(
                    $"La División de {Numero1} / {Numero2} es: ",
                    Numero1 / Numero2)
            );
        }

        async void BtMultiplicar_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(
                new Ejercicio11Resultado(
                    $"La multiplicación de {Numero1} * {Numero2} es: ",
                    Numero1 * Numero2)
            );
        }
    }
}


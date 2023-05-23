using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PrimerParcial
{

	public partial class Ejercicio11Resultado : ContentPage
	{

		public string Descripcion { get; set; }
		public float Resultado { get; set; }

		public Ejercicio11Resultado(string descripcion, float resultado)
		{
			Descripcion = descripcion;
			Resultado = resultado;
			BindingContext = this;
            InitializeComponent();
		}

	}

}

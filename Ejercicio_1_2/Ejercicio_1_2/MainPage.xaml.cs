using Ejercicio_1_2.modulos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio_1_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnenviar_Clicked(object sender, EventArgs e)
        {
 

            var persona = new Persona
            {
                Nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                edad = Convert.ToInt32(txtedad.Text),
                correo= txtcorreo.Text
            };
 
            var datos = new  Views.BindingContextM();
            datos.BindingContext = persona;
            await Navigation.PushAsync( datos );

        }
    }
}

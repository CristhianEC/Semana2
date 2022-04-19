  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S29AClaseMA
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaDos : ContentPage
    {
        public VistaDos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

            try
            {
                double numero1 = Convert.ToDouble(txtNumero1.Text);

                double numero2 = Convert.ToDouble(txtNumero2.Text);

                double numero3 = Convert.ToDouble(txtNumero3.Text);

                double respuesta = numero1 + numero2 + numero3;

                txtResultado.Text = respuesta.ToString();

                lblResultado.Text = respuesta.ToString();

            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR", ex.Message, "Cerrar");
            }

        }
    }
}
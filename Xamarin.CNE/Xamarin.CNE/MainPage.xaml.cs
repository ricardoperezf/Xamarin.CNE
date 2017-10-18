using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.CNE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TipoDeAccesoZona();
            ObtengaFechaDelSistema();
        }

        private void ObtengaFechaDelSistema()
        {
            fechaDelSistema.Text = DateTime.Now.ToString();
        }

        private void TipoDeAccesoZona()
        {
            AccesoZona.Items.Add("Dificil");
            AccesoZona.Items.Add("Medio");
            AccesoZona.Items.Add("Fácil");
        }

        private void AccesoZona_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = AccesoZona.Items[AccesoZona.SelectedIndex];
            DisplayAlert(name, "Selected value", "OK");
        }
    }
}
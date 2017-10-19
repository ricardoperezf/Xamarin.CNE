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
            TiposDeProvincias();
        }

        private void TiposDeProvincias()
        {
            Provincia.Items.Add("Alajuela");
            Provincia.Items.Add("Cartago");
            Provincia.Items.Add("Heredia");
            Provincia.Items.Add("Guanacaste");
            Provincia.Items.Add("Limón");
            Provincia.Items.Add("Puntarenas");
            Provincia.Items.Add("San José");
        }

        private void ObtengaFechaDelSistema()
        {
            fechaDelSistema.Text = DateTime.Now.ToString();
        }

        private void TipoDeAccesoZona()
        {
            AccesoZona.Items.Add("Sin daño");
            AccesoZona.Items.Add("Daño parcial");
            AccesoZona.Items.Add("Sin acceso");
        }

        private void AccesoZona_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = AccesoZona.Items[AccesoZona.SelectedIndex];
            DisplayAlert(name, "Selected value", "OK");
        }
    }
}
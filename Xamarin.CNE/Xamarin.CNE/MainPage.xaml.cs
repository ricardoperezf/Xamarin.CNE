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
            AccesoZona();
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

        private void AccesoZona()
        {
            TerrestreAccesoZona.Items.Add("Sin daño");
            TerrestreAccesoZona.Items.Add("Daño parcial");
            TerrestreAccesoZona.Items.Add("Sin acceso");

            AreaAccesoZona.Items.Add("Sin daño");
            AreaAccesoZona.Items.Add("Daño parcial");
            AreaAccesoZona.Items.Add("Sin acceso");

            PluvialAccesoZona.Items.Add("Sin daño");
            PluvialAccesoZona.Items.Add("Sin acceso");
            PluvialAccesoZona.Items.Add("Daño parcial");

            MaritimaAccesoZona.Items.Add("Sin daño");
            MaritimaAccesoZona.Items.Add("Sin acceso");
            MaritimaAccesoZona.Items.Add("Daño parcial");
        }

        private void AccesoZona_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = TerrestreAccesoZona.Items[TerrestreAccesoZona.SelectedIndex];
            DisplayAlert(name, "Selected value", "OK");
        }
    }
}
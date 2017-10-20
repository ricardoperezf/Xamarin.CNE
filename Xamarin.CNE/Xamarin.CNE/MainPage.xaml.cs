using System;
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
            TiposDeEventos();
            TiposDeCondicionesClimaticas();
            TiposDeInstitucionesPresentes();
            TiposDeAfectacion();
            TipoDeViviendasAfectadas();
        }

        private void TipoDeViviendasAfectadas()
        {
            ValoracionOInspeccion.Items.Add("Si");
            ValoracionOInspeccion.Items.Add("No");

            AislarZonaAfectada.Items.Add("Si");
            AislarZonaAfectada.Items.Add("No");
        }

        private void TiposDeAfectacion()
        {
            TipoDeAfectacion.Items.Add("Parciales");
            TipoDeAfectacion.Items.Add("Importantes");
            TipoDeAfectacion.Items.Add("Total");
        }

        private void TiposDeInstitucionesPresentes()
        {
            InstitucionesPresentes.Items.Add("CME");
            InstitucionesPresentes.Items.Add("Fuerza Pública");
            InstitucionesPresentes.Items.Add("Transito");
            InstitucionesPresentes.Items.Add("Bomberos");
            InstitucionesPresentes.Items.Add("Cruz Roja");
            InstitucionesPresentes.Items.Add("Otra");
            InstitucionesPresentes.Items.Add("Nignunas");

        }

        private void TiposDeCondicionesClimaticas()
        {
            CondicionesClimaticas.Items.Add("Despejado");
            CondicionesClimaticas.Items.Add("Nublado");
            CondicionesClimaticas.Items.Add("Temperatura");
            CondicionesClimaticas.Items.Add("Lluvioso");
            CondicionesClimaticas.Items.Add("Lluvia torrencial");
            CondicionesClimaticas.Items.Add("Vientos");
        }

        private void ObtengaFechaDelSistema()
        {
            fechaDelSistema.Text = DateTime.Now.ToString();
        }
        private void TiposDeEventos()
        {
            TipoDeEvento.Items.Add("Terremoto");
            TipoDeEvento.Items.Add("Inundación");
            TipoDeEvento.Items.Add("Incendio");
            TipoDeEvento.Items.Add("Erupción volcánica");
            TipoDeEvento.Items.Add("Deslizamiento");
            TipoDeEvento.Items.Add("Avalancha");
            TipoDeEvento.Items.Add("Accidentes");
            TipoDeEvento.Items.Add("Tormenta");
            TipoDeEvento.Items.Add("Rescate");
            TipoDeEvento.Items.Add("Contaminación");
            TipoDeEvento.Items.Add("Otro");
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
﻿using System;
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
            TiposDeAccesoZonaYLineasVitales();
            ObtengaFechaDelSistema();
            TiposDeProvincias();
            TiposDeEventos();
            TiposDeCondicionesClimaticas();
            TiposDeInstitucionesPresentes();
            TiposDeAfectacion();
            TipoDeViviendasAfectadas();
            TiposDeAlbergues();
            TiposDeAnalisisDeNecesidadesHumanos();
            TiposDeAnalisisDeNecesidadesMateriales();
            TiposDeAnalisisDeNecesidadesEconomico();
            TiposDeNecesidades();
            TipoDeSituacionActualDelEvento();
        }

        private void TipoDeSituacionActualDelEvento()
        {
            SituacionActualDelEvento.Items.Add("Controlado");
            SituacionActualDelEvento.Items.Add("En progreso");
            SituacionActualDelEvento.Items.Add("Descartado");
        }

        private void TiposDeNecesidades()
        {
            NecesidadesHumanos.Items.Add("Normal");
            NecesidadesHumanos.Items.Add("Medio");
            NecesidadesHumanos.Items.Add("Urgente");

            NecesidadesMateriales.Items.Add("Normal");
            NecesidadesMateriales.Items.Add("Medio");
            NecesidadesMateriales.Items.Add("Urgente");

            NecesidadesEconomico.Items.Add("Normal");
            NecesidadesEconomico.Items.Add("Medio");
            NecesidadesEconomico.Items.Add("Urgente");
        }

        private void TiposDeAnalisisDeNecesidadesEconomico()
        {
            AnalisisDeNecesidadesEconomico.Items.Add("Crédito");
            AnalisisDeNecesidadesEconomico.Items.Add("Alquiler equipo");
            AnalisisDeNecesidadesEconomico.Items.Add("Apoyo IMAS");
            AnalisisDeNecesidadesEconomico.Items.Add("Otro");
        }

        private void TiposDeAnalisisDeNecesidadesMateriales()
        {
            AnalisisDeNecesidadesMateriales.Items.Add("Valoración - inspección");
            AnalisisDeNecesidadesMateriales.Items.Add("Equipo pesado");
            AnalisisDeNecesidadesMateriales.Items.Add("Equipo especial");
            AnalisisDeNecesidadesMateriales.Items.Add("Aislar zona afectada");
            AnalisisDeNecesidadesMateriales.Items.Add("Evacuación");
            AnalisisDeNecesidadesMateriales.Items.Add("Coordinación institucional");
            AnalisisDeNecesidadesMateriales.Items.Add("Evacuación");
            AnalisisDeNecesidadesMateriales.Items.Add("Otro");
        }

        private void TiposDeAnalisisDeNecesidadesHumanos()
        {
            AnalisisDeNecesidadesHumanos.Items.Add("Valoración - inspección");
            AnalisisDeNecesidadesHumanos.Items.Add("Colchones - cobijas");
            AnalisisDeNecesidadesHumanos.Items.Add("Alimentos");
            AnalisisDeNecesidadesHumanos.Items.Add("Aislar zona afectada");
            AnalisisDeNecesidadesHumanos.Items.Add("Evacuación");
            AnalisisDeNecesidadesHumanos.Items.Add("Coordinación institucional");
            AnalisisDeNecesidadesHumanos.Items.Add("Evacuación");
            AnalisisDeNecesidadesHumanos.Items.Add("Otro");
        }

        private void TiposDeAlbergues()
        {
            CaracteristicasAlbergues.Items.Add("Excelentes");
            CaracteristicasAlbergues.Items.Add("Regulares");
            CaracteristicasAlbergues.Items.Add("Inadecuadas");
        }

        private void TipoDeViviendasAfectadas()
        {
            ValoracionOInspeccion.Items.Add("Si");
            ValoracionOInspeccion.Items.Add("No");

            AislarZonaAfectada.Items.Add("Si");
            AislarZonaAfectada.Items.Add("No");

            Evacuacion.Items.Add("Si");
            Evacuacion.Items.Add("No");

            CoordinacionInstitucional.Items.Add("Si");
            CoordinacionInstitucional.Items.Add("No");

            Remocion.Items.Add("Si");
            Remocion.Items.Add("No");

            OtroTipoDeAfectación.Items.Add("Si");
            OtroTipoDeAfectación.Items.Add("No");
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


        private void TiposDeAccesoZonaYLineasVitales()
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

            Acueductos.Items.Add("Sin daño");
            Acueductos.Items.Add("Sin acceso");
            Acueductos.Items.Add("Daño parcial");

            Alcantarrillados.Items.Add("Sin daño");
            Alcantarrillados.Items.Add("Sin acceso");
            Alcantarrillados.Items.Add("Daño parcial");

            Electricidad.Items.Add("Sin daño");
            Electricidad.Items.Add("Sin acceso");
            Electricidad.Items.Add("Daño parcial");

            Telecomunicaciones.Items.Add("Sin daño");
            Telecomunicaciones.Items.Add("Sin acceso");
            Telecomunicaciones.Items.Add("Daño parcial");

            Salud.Items.Add("Sin daño");
            Salud.Items.Add("Sin acceso");
            Salud.Items.Add("Daño parcial");
        }

        private void AccesoZona_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            var name = TerrestreAccesoZona.Items[TerrestreAccesoZona.SelectedIndex];
            DisplayAlert(name, "Selected value", "OK");
        }
    }
}
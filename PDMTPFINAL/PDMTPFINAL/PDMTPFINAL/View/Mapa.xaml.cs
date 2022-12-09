using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;


namespace PDMTPFINAL.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {
        public Mapa()
        {
            InitializeComponent();
            LocalizacaoAsync();
        }

        async void LocalizacaoAsync()
        {

            var localizacao = await Geolocation.GetLastKnownLocationAsync();
            Maps.MoveToRegion(MapSpan.FromCenterAndRadius(
            new Position(localizacao.Latitude, localizacao.Longitude),
            Distance.FromMiles(0.5)));

        }
    }
}
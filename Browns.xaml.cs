using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Device.Location;
using Microsoft.Phone.Maps.Controls;
using Microsoft.Phone.Tasks;

namespace SportsTourGuide
{
    public partial class Browns : PhoneApplicationPage
    {
        public Browns()
        {
            InitializeComponent();
            TeamMap();
        }
        private void TeamMap()
        {
            MyMap.Center = new GeoCoordinate(41.5061, -81.6994);
            MyMap.ZoomLevel = 17;
            MyMap.LandmarksEnabled = true;
            MyMap.ColorMode = MapColorMode.Dark;
           // MyMap.CartographicMode = MapCartographicMode.Aerial;
        }

        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            MapsDirectionsTask mapsDirectionsTask = new MapsDirectionsTask();

            // You can specify a label and a geocoordinate for the end point.
            // GeoCoordinate spaceNeedleLocation = new GeoCoordinate(47.6204,-122.3493);
            // LabeledMapLocation spaceNeedleLML = new LabeledMapLocation("Space Needle", spaceNeedleLocation);

            // If you set the geocoordinate parameter to null, the label parameter is used as a search term.
            LabeledMapLocation spaceNeedleLML = new LabeledMapLocation("FirstEnergy Stadium", null);

            mapsDirectionsTask.End = spaceNeedleLML;

            // If mapsDirectionsTask.Start is not set, the user's current location is used as the start point.

            mapsDirectionsTask.Show();

        }
    }
}
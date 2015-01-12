using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using SportsTourGuide.Resources;
using Microsoft.Phone.Tasks;
using System.Windows.Media;

namespace SportsTourGuide
{
    public partial class MainPage : PhoneApplicationPage
    {
        MarketplaceDetailTask _marketPlaceDetailTask = new MarketplaceDetailTask();

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Microsoft.Phone.Maps.MapsSettings.ApplicationContext.ApplicationId = "c707a4af-14f6-4cb7-96bd-abc5c47e8caf";
            Microsoft.Phone.Maps.MapsSettings.ApplicationContext.AuthenticationToken = "7z0YnCFgm-lqGOZ0-avXBA";
            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;

            if ((Visibility)Resources["PhoneLightThemeVisibility"] == Visibility.Visible)
            {
                DarkTheme();
            }
            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        private void DarkTheme()
        {
            ((SolidColorBrush)Resources["PhoneRadioCheckBoxCheckBrush"]).Color = ((SolidColorBrush)Resources["PhoneRadioCheckBoxBorderBrush"]).Color = ((SolidColorBrush)Resources["PhoneForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneContrastForegroundBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneContrastBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneDisabledBrush"]).Color = Color.FromArgb(0x66, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneProgressBarBackgroundBrush"]).Color = Color.FromArgb(0x19, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextCaretBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneTextBoxBrush"]).Color = Color.FromArgb(0xBF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxForegroundBrush"]).Color = Color.FromArgb(0xFF, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneTextBoxEditBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxReadOnlyBrush"]).Color = Color.FromArgb(0x77, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneSubtleBrush"]).Color = Color.FromArgb(0x99, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextBoxSelectionForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneButtonBasePressedForegroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextHighContrastBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextMidContrastBrush"]).Color = Color.FromArgb(0x99, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneTextLowContrastBrush"]).Color = Color.FromArgb(0x73, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneSemitransparentBrush"]).Color = Color.FromArgb(0xAA, 0x00, 0x00, 0x00);
            ((SolidColorBrush)Resources["PhoneChromeBrush"]).Color = Color.FromArgb(0xFF, 0x1F, 0x1F, 0x1F);

            ((SolidColorBrush)Resources["PhoneInactiveBrush"]).Color = Color.FromArgb(0x33, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneInverseInactiveBrush"]).Color = Color.FromArgb(0xFF, 0xCC, 0xCC, 0xCC);
            ((SolidColorBrush)Resources["PhoneInverseBackgroundBrush"]).Color = Color.FromArgb(0xFF, 0xFF, 0xFF, 0xFF);
            ((SolidColorBrush)Resources["PhoneBorderBrush"]).Color = Color.FromArgb(0xBF, 0xFF, 0xFF, 0xFF);
        }

        // Load data for the ViewModel Items
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();

            }
            base.OnNavigatedTo(e);

            
        }
        private void Nba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NBA.SelectedIndex == -1)
                return;
            switch (NBA.SelectedIndex)
            {
                case 0:
                    NavigationService.Navigate(new Uri("/Celtics.xaml", UriKind.Relative));
                    break;
                case 1:
                    NavigationService.Navigate(new Uri("/Nets.xaml", UriKind.Relative));
                    break;
                case 2:
                    NavigationService.Navigate(new Uri("/knicks.xaml", UriKind.Relative));
                    break;
                case 3:
                    NavigationService.Navigate(new Uri("/Sixers.xaml", UriKind.Relative));
                    break;
                case 4:
                    NavigationService.Navigate(new Uri("/Raptors.xaml", UriKind.Relative));
                    break;
                case 5:
                    NavigationService.Navigate(new Uri("/Bulls.xaml", UriKind.Relative));
                    break;
                case 6:
                    NavigationService.Navigate(new Uri("/Cavaliers.xaml", UriKind.Relative));
                    break;
                case 7:
                    NavigationService.Navigate(new Uri("/Pistons.xaml", UriKind.Relative));
                    break;
                case 8:
                    NavigationService.Navigate(new Uri("/Pacers.xaml", UriKind.Relative));
                    break;
                case 9:
                    NavigationService.Navigate(new Uri("/Bucks.xaml", UriKind.Relative));
                    break;
                case 10:
                    NavigationService.Navigate(new Uri("/Hawks.xaml", UriKind.Relative));
                    break;
                case 11:
                    NavigationService.Navigate(new Uri("/Hornets.xaml", UriKind.Relative));
                    break;
                case 12:
                    NavigationService.Navigate(new Uri("/Heat.xaml", UriKind.Relative));
                    break;
                case 13:
                    NavigationService.Navigate(new Uri("/Magic.xaml", UriKind.Relative));
                    break;
                case 14:
                    NavigationService.Navigate(new Uri("/Wizards.xaml", UriKind.Relative));
                    break;
                case 15:
                    NavigationService.Navigate(new Uri("/Nuggets.xaml", UriKind.Relative));
                    break;
                case 16:
                    NavigationService.Navigate(new Uri("/Timberwolves.xaml", UriKind.Relative));
                    break;
                case 17:
                    NavigationService.Navigate(new Uri("/Thunder.xaml", UriKind.Relative));
                    break;
                case 18:
                    NavigationService.Navigate(new Uri("/Blazers.xaml", UriKind.Relative));
                    break;
                case 19:
                    NavigationService.Navigate(new Uri("/Jazz.xaml", UriKind.Relative));
                    break;
                case 20:
                    NavigationService.Navigate(new Uri("/Warriors.xaml", UriKind.Relative));
                    break;
                case 21:
                    NavigationService.Navigate(new Uri("/Clippers.xaml", UriKind.Relative));
                    break;
                case 22:
                    NavigationService.Navigate(new Uri("/Lakers.xaml", UriKind.Relative));
                    break;
                case 23:
                    NavigationService.Navigate(new Uri("/Suns.xaml", UriKind.Relative));
                    break;
                case 24:
                    NavigationService.Navigate(new Uri("/Kings.xaml", UriKind.Relative));
                    break;
                case 25:
                    NavigationService.Navigate(new Uri("/Mavs.xaml", UriKind.Relative));
                    break;
                case 26:
                    NavigationService.Navigate(new Uri("/Rockets.xaml", UriKind.Relative));
                    break;
                case 27:
                    NavigationService.Navigate(new Uri("/Grizzlies.xaml", UriKind.Relative));
                    break;
                case 28:
                    NavigationService.Navigate(new Uri("/Pelicans.xaml", UriKind.Relative));
                    break;
                case 29:
                    NavigationService.Navigate(new Uri("/Spurs.xaml", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }
        private void Nfl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (NFL.SelectedIndex == -1)
                return;
            switch (NFL.SelectedIndex)
            {
                case 0:
                    NavigationService.Navigate(new Uri("/Bears.xaml", UriKind.Relative));
                    break;
                case 1:
                    NavigationService.Navigate(new Uri("/Cardinals.xaml", UriKind.Relative));
                    break;
                case 2:
                    NavigationService.Navigate(new Uri("/Packers.xaml", UriKind.Relative));
                    break;
                case 3:
                    NavigationService.Navigate(new Uri("/Giants.xaml", UriKind.Relative));
                    break;
                case 4:
                    NavigationService.Navigate(new Uri("/Lions.xaml", UriKind.Relative));
                    break;
                case 5:
                    NavigationService.Navigate(new Uri("/Redskins.xaml", UriKind.Relative));
                    break;
                case 6:
                    NavigationService.Navigate(new Uri("/Steelers.xaml", UriKind.Relative));
                    break;
                case 7:
                    NavigationService.Navigate(new Uri("/Eagels.xaml", UriKind.Relative));
                    break;
                case 8:
                    NavigationService.Navigate(new Uri("/Rams.xaml", UriKind.Relative));
                    break;
                case 9:
                    NavigationService.Navigate(new Uri("/Niners.xaml", UriKind.Relative));
                    break;
                case 10:
                    NavigationService.Navigate(new Uri("/Browns.xaml", UriKind.Relative));
                    break;
                case 11:
                    NavigationService.Navigate(new Uri("/Colts.xaml", UriKind.Relative));
                    break;
                case 12:
                    NavigationService.Navigate(new Uri("/Cowboys.xaml", UriKind.Relative));
                    break;
                case 13:
                    NavigationService.Navigate(new Uri("/Raiders.xaml", UriKind.Relative));
                    break;
                case 14:
                    NavigationService.Navigate(new Uri("/Patriots.xaml", UriKind.Relative));
                    break;
                case 15:
                    NavigationService.Navigate(new Uri("/Titans.xaml", UriKind.Relative));
                    break;
                case 16:
                    NavigationService.Navigate(new Uri("/Broncos.xaml", UriKind.Relative));
                    break;
                case 17:
                    NavigationService.Navigate(new Uri("/Chargers.xaml", UriKind.Relative));
                    break;
                case 18:
                    NavigationService.Navigate(new Uri("/Jets.xaml", UriKind.Relative));
                    break;
                case 19:
                    NavigationService.Navigate(new Uri("/Chiefs.xaml", UriKind.Relative));
                    break;
                case 20:
                    NavigationService.Navigate(new Uri("/Bills.xaml", UriKind.Relative));
                    break;
                case 21:
                    NavigationService.Navigate(new Uri("/Vikings.xaml", UriKind.Relative));
                    break;
                case 22:
                    NavigationService.Navigate(new Uri("/Dolphins.xaml", UriKind.Relative));
                    break;
                case 23:
                    NavigationService.Navigate(new Uri("/Falcons.xaml", UriKind.Relative));
                    break;
                case 24:
                    NavigationService.Navigate(new Uri("/Saints.xaml", UriKind.Relative));
                    break;
                case 25:
                    NavigationService.Navigate(new Uri("/Bengals.xaml", UriKind.Relative));
                    break;
                case 26:
                    NavigationService.Navigate(new Uri("/Seahawks.xaml", UriKind.Relative));
                    break;
                case 27:
                    NavigationService.Navigate(new Uri("/Buccs.xaml", UriKind.Relative));
                    break;
                case 28:
                    NavigationService.Navigate(new Uri("/Jaguars.xaml", UriKind.Relative));
                    break;
                case 29:
                    NavigationService.Navigate(new Uri("/Panthers.xaml", UriKind.Relative));
                    break;
                case 30:
                    NavigationService.Navigate(new Uri("/Ravens.xaml", UriKind.Relative));
                    break;
                case 31:
                    NavigationService.Navigate(new Uri("/Texans.xaml", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }

        private void BuyApp_Click(object sender, RoutedEventArgs e)
        {
            _marketPlaceDetailTask.Show();
        }

        private void findBar_Click(object sender, RoutedEventArgs e)
        {
            MapsDirectionsTask mapsDirectionsTask = new MapsDirectionsTask();

            // You can specify a label and a geocoordinate for the end point.
            // GeoCoordinate spaceNeedleLocation = new GeoCoordinate(47.6204,-122.3493);
            // LabeledMapLocation spaceNeedleLML = new LabeledMapLocation("Space Needle", spaceNeedleLocation);

            // If you set the geocoordinate parameter to null, the label parameter is used as a search term.
            LabeledMapLocation spaceNeedleLML = new LabeledMapLocation("Sports Bars", null);

            mapsDirectionsTask.End = spaceNeedleLML;

            // If mapsDirectionsTask.Start is not set, the user's current location is used as the start point.

            mapsDirectionsTask.Show();
        }
        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();
         
        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}
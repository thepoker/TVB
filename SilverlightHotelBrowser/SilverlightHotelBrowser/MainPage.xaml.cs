using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightHotelBrowser
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
            HotelService.HotelServiceClient proxy = new SilverlightHotelBrowser.HotelService.HotelServiceClient();
            proxy.GetHotelsCompleted += new EventHandler<SilverlightHotelBrowser.HotelService.GetHotelsCompletedEventArgs>(proxy_GetHotelsCompleted);
            proxy.GetHotelsAsync();
        }
        void proxy_GetHotelsCompleted(object sender, SilverlightHotelBrowser.HotelService.GetHotelsCompletedEventArgs e)
        {
            HotelComboBox.ItemsSource = e.Result;
        }
        private void HotelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            HotelDetailGrid.DataContext = (sender as ComboBox).SelectedItem as HotelService.Hotel;
        }
    }
}

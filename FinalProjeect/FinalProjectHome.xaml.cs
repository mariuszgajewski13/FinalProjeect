﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Logika interakcji dla klasy FinalrojeectHome.xaml
    /// </summary>
    public partial class FinalProjectHome : Page
    {
        Menu menu = new Menu();
        public FinalProjectHome()
        {
            InitializeComponent();
        }

        private void All(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AllShows.xaml", UriKind.Relative));
            // menu.All();
        }

        private void Watchlist(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Watchlist.xaml", UriKind.Relative));
        }
        private void Current(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/CurrentlyWatching.xaml", UriKind.Relative));
        }

        private void Ended(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/End.xaml", UriKind.Relative));
        }
        private void Genre(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Genres.xaml", UriKind.Relative));
        }
        private void OnBreak(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Break.xaml", UriKind.Relative));
        }
        private void Stations(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/TV_Stations.xaml", UriKind.Relative));
        }
    }
}

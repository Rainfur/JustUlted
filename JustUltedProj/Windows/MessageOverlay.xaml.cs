﻿using JustUltedProj.Logic;
using System.Windows;
using System.Windows.Controls;

namespace JustUltedProj.Windows
{
    /// <summary>
    /// Interaction logic for MessageOverlay.xaml
    /// </summary>
    public partial class MessageOverlay : Page
    {
        public MessageOverlay()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, RoutedEventArgs e)
        {
            Client.OverlayContainer.Visibility = Visibility.Hidden;
        }
    }
}
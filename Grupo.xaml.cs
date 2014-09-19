using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Pico
{
    public partial class Grupo : PhoneApplicationPage
    {
        System.Windows.Threading.DispatcherTimer obj = new System.Windows.Threading.DispatcherTimer();
        public Grupo()
        {
            InitializeComponent();
            obj.Interval = TimeSpan.FromSeconds(3);
            
            obj.Tick += obj_Tick;
        }

        void obj_Tick(object sender, EventArgs e)
        {
            txtRes.Text = "Hernán: yo te ayudo";
            obj.Stop();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtYo.Text = "Jordano: " + txtChat.Text;
            obj.Start();
        }

        private void txtRes_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Individual.xaml", UriKind.Relative));
        }
    }
}
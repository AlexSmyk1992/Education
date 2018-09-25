using System;
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
using System.Windows.Threading;
using Microsoft.Win32;

namespace VideoPlayerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuExit_OnClick(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0); 
        }
        private void MenuOpen_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                AddExtension = true,
                DefaultExt = ".",
                Filter = "Media Files (*.*)|*.*"
            };
            ofd.ShowDialog();
            try
            {
                mediaElement.Source = new Uri(ofd.FileName);
            }
            catch
            {
                new NullReferenceException("Error");
            }
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            slider_Time.Value = mediaElement.Position.TotalSeconds;
        }

        private void ButtonPlayClick(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void ButtonPauseClick(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void ButtonStopClick(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
        }

        private void slider_Time_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TimeSpan ts = TimeSpan.FromSeconds(slider_Time.Value);
            mediaElement.Position = ts;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = slider.Value;
        }

        private void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (mediaElement.NaturalDuration.HasTimeSpan)
            {
                TimeSpan ts = mediaElement.NaturalDuration.TimeSpan;
                slider_Time.Maximum = ts.TotalSeconds;
            }
        }
    }
}

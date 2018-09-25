using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace StopWatch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DispatcherTimer stopWatch = new DispatcherTimer();
        private const int step=1;
        private DateTime startTime;
        private int circleNumber = 0;
        private bool resetOn = false;
        
        public MainWindow()
        {
            InitializeComponent();
            stopWatch.Interval = TimeSpan.FromMilliseconds(step);//new TimeSpan(0, 0, 0, 0, 1);
            stopWatch.Tick += StopWatchTick;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            stopWatch.Start();
            startTime = DateTime.Now;
            resetOn = false;

        }
        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            circleNumber = 0;
            btnStop.Content = "Сброс";
            stopWatch.Stop();
            if (resetOn)
            {
                lblTime.Content = "00:00:00:000";
                Tb.Text = "";
                btnStop.Content = "Стоп";
            }
            resetOn = true;
        }

        private void StopWatchTick(object sender, EventArgs e)
        {
            var currTime = DateTime.Now;
            var diff = currTime - startTime;
            lblTime.Content = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", diff.Hours, diff.Minutes, diff.Seconds,diff.Milliseconds);
        }

        private void btnCircle_Click(object sender, RoutedEventArgs e)
        {
            circleNumber++;
            Tb.AppendText(string.Format("{0}-й круг! Время: {1}\n", circleNumber, (string)lblTime.Content));
            Sw.ScrollToEnd();
        }
       
    }
}

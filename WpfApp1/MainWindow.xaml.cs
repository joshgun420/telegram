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
using System.Windows.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public MainWindow()
        {

            InitializeComponent();
            dispatcherTimer.Interval = TimeSpan.FromMilliseconds(500);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
            //stackpanel
            //wrappanel
            //Dockpanel
            //Canvas
            //Uniformgrid
            //Grid

        }
        public int MyAngle { get; set; } = 10;

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            //var tr = new RotateTransform();
            //MyAngle += 1;
            //tr.Angle = MyAngle;
        
            var tr=new SkewTransform();
            MyAngle += 1;

        }

        private void clikc(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace animationBallClass
{
    public partial class MainWindow : Window
    {    
        Ball ball;

        DispatcherTimer dispatcherTimer;

        const int diameter = 40;
        int positionX = 100;
        int positionY = 100;
        int speedX = 10;
        int speedY = 10;
        Color ballColor = Colors.Blue;
        int frameRate = 10;

        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ball = new Ball(diameter, positionY, positionX, speedX, speedY, frameRate, ballColor);
            DispatcherTimerSetup();
        }

        private void DispatcherTimerSetup()
        {
            dispatcherTimer = new DispatcherTimer(DispatcherPriority.Render);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0,0,0,0, frameRate);
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            myCanvas.Children.Clear();
            ball.MoveBall();
            ball.BounceBall(myCanvas.ActualWidth, myCanvas.ActualHeight);
            Canvas.SetTop(ball.circle, ball.positionY);
            Canvas.SetLeft(ball.circle, ball.positionX);
        }
    }
}

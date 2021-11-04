using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace animationBallClass
{
    class Ball
    {
        public int diameter { get; set; }

        public int positionY { get; set; }

        public int positionX { get; set; }

        public int speedX { get; set; }

        public int speedY { get; set; }

        public int frameRate { get; }

        public Color ballColor { get; }

        public Ellipse circle;


        //public Ellipse circle;  //Need something to replace this

        public Ball(int diameter,
                    int positionY,
                    int positionX,
                    int speedX,
                    int speedY,
                    int frameRate,
                    Color ballColor,
                    Ellipse circle)
        {
            this.diameter = diameter;
            this.positionY = positionY;
            this.positionX = positionX;
            this.speedX = speedX;
            this.speedY = speedY;
            this.frameRate = frameRate;
            this.ballColor = ballColor;
            this.circle = circle;

            CreateBall();
        }
        private void CreateBall()
        {
            circle = new Ellipse();
            circle.Width = diameter;
            circle.Height = diameter;
            SolidColorBrush soloidcolorbrush = new SolidColorBrush();
            soloidcolorbrush.Color = ballColor;
            circle.Fill = soloidcolorbrush;
        }
        public void MoveBall()
        {
            positionX += speedX;
            positionY += speedY;
        }
        public void BounceBall(double actualWidth, double actualHeight)
        {
            if (positionX + diameter>actualWidth) 
            {
                speedX *= -1; //Reverse direction of the ball
            }
        }
    }
}


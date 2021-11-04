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
            if (positionX + diameter>actualWidth) //If the positionX + diameter is greater than the width the change direction
            {
                speedX *= -1; //Reverse direction of the ball in X axis
            }
            
            if (positionY + diameter>actualHeight) //If the positionY + diameter is greater than the height the change direction
            {
                speedY *= -1; //Reverse direction of the ball in Y axis
            }

            if (positionX < 0) //If the ball hits the left side 
            {
                speedX *= -1; //Reverse direction of the ball in X axis
            }

            if (positionY < 0) //Reverse direction of the ball in the Y axis
            {
                speedY *= -1; //Reverse direction of the ball in Y axis
            }
        }
    }
}


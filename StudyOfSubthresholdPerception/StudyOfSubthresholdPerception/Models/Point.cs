using System;
using System.Drawing;

namespace StudyOfSubthresholdPerception.Models
{
    public class Point : Figure
    {
        private readonly Brush _brush;
        public float Angle { get; set; }
        public float DefaultAngle { get; set; }
        private readonly float _velocity;

        public Point(float radius, float angle, float velocity, Brush brush)
            : base(0, 0, radius)
        {
            DefaultAngle = angle;
            _velocity = velocity;
            _brush = brush;
        }

        public void Reset(Circle circle)
        {
            Angle = DefaultAngle;
            X = (float)Math.Cos(Angle) * circle.Radius + circle.X;
            Y = (float)Math.Sin(Angle) * circle.Radius + circle.Y;
        }
        public void Step(Circle circle)
        {
            Angle += _velocity;
            if (Angle > 2f * Math.PI)
                Angle -= 2f * (float)Math.PI;
            X = (float)Math.Cos(Angle) * circle.Radius + circle.X;
            Y = (float)Math.Sin(Angle) * circle.Radius + circle.Y;
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillEllipse(_brush, X - Radius, Y - Radius, 2f * Radius, 2f * Radius);
        }
    }
}

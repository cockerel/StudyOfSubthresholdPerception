using System;

namespace StudyOfSubthresholdPerception.Models
{
    public class Figure
    {
        protected float _radius;
        public Figure(float x, float y, float radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    throw new Exception("Радиус не может быть отрицательным или равным нулю.");
                _radius = value;
            }
        }
    }
}

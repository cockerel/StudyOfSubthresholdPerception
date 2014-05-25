using System.Drawing;

namespace StudyOfSubthresholdPerception.Models
{
    public class Circle : Figure
    {
        private readonly Pen _pen;

        public Circle(float x, float y, float radius, Pen pen)
            : base(x, y, radius)
        {
            _pen = pen;
        }

        public void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(_pen, X - Radius, Y - Radius, 2f * Radius, 2f * Radius);
        }
    }
}

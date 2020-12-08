namespace CSharpDay2.Models
{
    public class Rectangle : Shape
    {
        public int Length { get; private set; }
        public int Width { get; private set; }

        public override int GetArea()
        {
            return Length * Width;
        }

        public override int GetPerimeter()
        {
            return Length * 2 + Width * 2;
        }

        public Rectangle(int length, int width, int sides) : base(sides)
        {
            Length = length;
            Width = width;
        }

    }
}
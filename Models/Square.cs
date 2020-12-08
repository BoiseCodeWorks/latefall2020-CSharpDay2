namespace CSharpDay2.Models
{
    public class Square : Rectangle
    {
        public override int GetArea()
        {
            return Length * Length;
        }

        public override int GetPerimeter()
        {
            return Length * Sides;
        }

        public Square(int lengthOrWidth, int sides) : base(lengthOrWidth, lengthOrWidth, sides)
        {

        }

        // public Square(int lengthOrWidth, int sides)
        // {
        // NOTE we privatized the setter in shape for Sides, so only Shape may set the value of sides
        //     SetSides(sides);
        // NOTE we would need to do the same here in Rectangle.
        //     Length = lengthOrWidth;
        //     Width = lengthOrWidth;
        // }
    }
}
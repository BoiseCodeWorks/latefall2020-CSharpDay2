namespace CSharpDay2.Models
{
    public abstract class Shape
    {
        public int Sides { get; private set; }
        public virtual int GetArea()
        {
            return 0;
        }

        public virtual int GetPerimeter()
        {
            return 0;
        }

        public Shape(int sides)
        {
            Sides = sides;
        }

        public void SetSides(int sides)
        {
            Sides = sides;
        }
    }
}
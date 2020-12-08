using CSharpDay2.Interfaces;

namespace CSharpDay2.Models
{
    public class Darryl : Person, ICarpenter, IDeveloper
    {

        public void WriteCodez(Coffee coffeeee)
        {
            System.Console.WriteLine("Writes some Rust.");
        }

        bool ICarpenter.House()
        {
            throw new System.NotImplementedException();
        }

        bool ICarpenter.MakeBirdHouse()
        {
            throw new System.NotImplementedException();
        }

        public Darryl(string name) : base(name)
        {

        }
    }
}
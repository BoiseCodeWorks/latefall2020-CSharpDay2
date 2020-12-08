using CSharpDay2.Interfaces;

namespace CSharpDay2.Models
{
    public class Miles : Person, IBarista, IDeveloper
    {
        public Coffee MakeCoffee()
        {
            System.Console.WriteLine($"{Name}Brews Some Coffee!");
            return new Coffee();
        }
        public void WriteCodez(Coffee coffeeee)
        {
            System.Console.WriteLine("Writes some JavaScriptz.");
        }

        public Miles(string name) : base(name)
        {

        }
    }
}
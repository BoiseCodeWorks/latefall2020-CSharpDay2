using System;
using System.Collections.Generic;
using CSharpDay2.Interfaces;
using CSharpDay2.Models;

namespace CSharpDay2
{
    class Program
    {
        static void Main(string[] args)
        {
            Miles miles = new Miles("Miles");
            Darryl DMoney = new Darryl("D$");
            List<IDeveloper> developers = new List<IDeveloper>();
            Coffee coffee = miles.MakeCoffee();

            developers.Add(miles);
            developers.Add(DMoney);
            developers.ForEach(developer =>
            {
                if (developer is Person)
                {
                    // NOTE Two different ways of casting to a type
                    Person p = developer as Person;
                    Person person = (Person)developer;
                    System.Console.WriteLine($"Hi my name is {p.Name}");
                }
                if (developer is IBarista)
                {
                    IBarista selfServingBarista = (IBarista)developer;
                    Coffee selfMadeCoffee = selfServingBarista.MakeCoffee();
                    developer.WriteCodez(selfMadeCoffee);
                }
                developer.WriteCodez(coffee);
            });
        }
    }
}

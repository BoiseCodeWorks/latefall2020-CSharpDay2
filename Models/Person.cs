namespace CSharpDay2.Models
{
    public abstract class Person
    {
        public string Name { get; private set; }
        public Person(string name)
        {
            Name = name;
        }
    }
}
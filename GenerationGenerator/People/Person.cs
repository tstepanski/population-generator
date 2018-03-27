using System.Collections.Generic;

namespace GenerationGenerator.People
{
    public sealed class Person
    {
        private readonly ICollection<Person> _children = new List<Person>();
        
        public Person(Person father, Person mother, Biology biology)
        {
            Father = father;
            Mother = mother;
            Biology = biology;
        }
        
        public Person Father { get; }
        public Person Mother { get; }
        public Biology Biology { get; }

        public void AddChild(Person child) => _children.Add(child);
        public IEnumerable<Person> GetChildren() => _children;
    }
}
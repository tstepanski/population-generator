using GenerationGenerator.People;

namespace GenerationGenerator
{
    public sealed class ChildFactory : IChildFactory
    {
        private readonly IBiologyFactory _biologyFactory;

        public ChildFactory(IBiologyFactory biologyFactory)
        {
            _biologyFactory = biologyFactory;
        }

        public Person CreateChild(Person father, Person mother)
        {
            var childBiology = _biologyFactory.CreateChildBiology(father, mother);
            
            return new Person(father, mother, childBiology);
        }
    }
}
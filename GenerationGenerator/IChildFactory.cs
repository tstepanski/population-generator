using GenerationGenerator.People;

namespace GenerationGenerator
{
    public interface IChildFactory
    {
        Person CreateChild(Person father, Person mother);
    }
}
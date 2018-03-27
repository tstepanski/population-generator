using GenerationGenerator.People;

namespace GenerationGenerator
{
    public interface IBiologyFactory
    {
        Biology CreateChildBiology(Person father, Person mother);
    }
}
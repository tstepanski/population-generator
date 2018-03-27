using GenerationGenerator;
using GenerationGenerator.People;
using Xunit;

namespace GenerationGeneratorTests
{
    public sealed class ChildFactoryIntegrationTests
    {
        [Fact]
        public void CreateChild_Given2DifferentParents_ReturnsAChild()
        {
            var random = new BetterRandom(1);
            var childFactory = new ChildFactory(new BiologyFactory(new Blender(random, 1, 2, 1), random));

            var fathersBiology = new Biology(Sex.Male, 81.0m, 182.88m, new Color(42, 42, 9), new Color(42, 42, 0),
                new Color(210, 210, 155), 180, 90, 80);
            
            var father = new Person(null, null, fathersBiology);
            
            var mothersBiology = new Biology(Sex.Female, 54m, 165m, new Color(230, 230, 90), new Color(5, 135, 60),
                new Color(210, 185, 120), 130, 150, 130);
            
            var mother = new Person(null, null, mothersBiology);

            var child = childFactory.CreateChild(father, mother);

            Assert.IsType<Person>(child);
            Assert.NotNull(child);
        }
    }
}
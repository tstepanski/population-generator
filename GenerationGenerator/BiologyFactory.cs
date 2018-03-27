using System;
using GenerationGenerator.People;

namespace GenerationGenerator
{
    public sealed class BiologyFactory : IBiologyFactory
    {
        private readonly IBlender _blender;
        private readonly IBetterRandom _betterRandom;

        public BiologyFactory(IBlender blender, IBetterRandom betterRandom)
        {
            _blender = blender;
            _betterRandom = betterRandom;
        }
        
        public Biology CreateChildBiology(Person father, Person mother)
        {
            var fathersBiology = father.Biology;
            var mothersBiology = mother.Biology;

            var attractiveness = _blender.Blend(fathersBiology.Attractiveness, mothersBiology.Attractiveness);
            var fertility = _blender.Blend(fathersBiology.Fertility, mothersBiology.Fertility);
            var healthiness = _blender.Blend(fathersBiology.Healthiness, mothersBiology.Healthiness);
            var heightInCentimeters = _blender.Blend(fathersBiology.HeightInCentimeters, mothersBiology.HeightInCentimeters);
            var massInKilograms = _blender.Blend(fathersBiology.MassInKilograms, mothersBiology.MassInKilograms);
            var eyeColor = _blender.Blend(fathersBiology.EyeColor, mothersBiology.EyeColor);
            var hairColor = _blender.Blend(fathersBiology.HairColor, mothersBiology.HairColor);
            var skinColor = _blender.Blend(fathersBiology.SkinColor, mothersBiology.SkinColor);
            var sex = _betterRandom.NextBool() ? Sex.Male : Sex.Female;

            return new Biology(sex, massInKilograms, heightInCentimeters, hairColor, eyeColor, skinColor, fertility,
                attractiveness, healthiness);
        }
    }
}
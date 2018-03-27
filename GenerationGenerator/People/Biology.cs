namespace GenerationGenerator.People
{
    public sealed class Biology
    {
        public Biology(Sex sex, decimal massInKilograms, decimal heightInCentimeters, Color hairColor, Color eyeColor,
            Color skinColor, byte fertility, byte attractiveness, byte healthiness)
        {
            Sex = sex;
            MassInKilograms = massInKilograms;
            HeightInCentimeters = heightInCentimeters;
            HairColor = hairColor;
            EyeColor = eyeColor;
            SkinColor = skinColor;
            Fertility = fertility;
            Attractiveness = attractiveness;
            Healthiness = healthiness;
        }

        public Sex Sex { get; }
        public decimal MassInKilograms { get; }
        public decimal HeightInCentimeters { get; }
        public Color HairColor { get; }
        public Color EyeColor { get; }
        public Color SkinColor { get; }
        public byte Fertility { get; }
        public byte Attractiveness { get; }
        public byte Healthiness { get; }
    }
}
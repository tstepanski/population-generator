using GenerationGenerator.People;

namespace GenerationGenerator
{
    public interface IBlender
    {
        byte Blend(byte first, byte second);
        decimal Blend(decimal first, decimal second);
        Color Blend(Color first, Color second);
    }
}
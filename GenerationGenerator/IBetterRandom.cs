namespace GenerationGenerator
{
    public interface IBetterRandom
    {
        bool NextBool();
        byte NextByte();
        byte NextByte(byte maxValue);
        byte NextByte(byte minValue, byte maxValue);
        int Next();
        int Next(int maxValue);
        int Next(int minValue, int maxValue);
        void NextBytes(byte[] buffer);
        double NextDouble();
        decimal NextDecimal();
        decimal NextDecimal(decimal maxValue);
        decimal NextDecimal(decimal minValue, decimal maxValue);
    }
}
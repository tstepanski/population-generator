using System;

namespace GenerationGenerator
{
    public sealed class BetterRandom : Random, IBetterRandom
    {
        public BetterRandom(int seed) : base(seed)
        {
        }

        public bool NextBool() => Next(0, 1) == 1;
        public byte NextByte() => (byte) Next(0, 255);
        public byte NextByte(byte maxValue) => (byte) Next(0, maxValue);
        public byte NextByte(byte minValue, byte maxValue) => (byte) Next(minValue, maxValue);
        public decimal NextDecimal() => NextDecimal(decimal.MaxValue);
        public decimal NextDecimal(decimal maxValue) => NextDecimal(decimal.MinValue, maxValue);

        public decimal NextDecimal(decimal minValue, decimal maxValue)
        {
            var floatingPoint = (decimal) NextDouble();
            var difference = maxValue - minValue;
            var scaled = difference * floatingPoint;

            return scaled + minValue;
        }
    }
}
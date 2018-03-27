using System;
using GenerationGenerator.People;

namespace GenerationGenerator
{
    public sealed class Blender : IBlender
    {
        private readonly int _lowThreshold;
        private readonly int _inBoundsThreshold;
        private readonly int _highThreshold;
        private readonly IBetterRandom _random;

        public Blender(IBetterRandom random, int lowThreshold, int inBoundsThreshold, int highThreshold)
        {
            _random = random;
            _lowThreshold = lowThreshold;
            _inBoundsThreshold = inBoundsThreshold;
            _highThreshold = highThreshold;
        }

        public byte Blend(byte first, byte second)
        {
            var minAndMax = GetMinAndMax(first, second);

            var difference = (byte) (minAndMax.Max - minAndMax.Min);

            if (NextSelection() == BlenderSelection.InBounds)
            {
                return _random.NextByte(minAndMax.Min, minAndMax.Max);
            }

            if (NextSelection() == BlenderSelection.Low)
            {
                var min = (byte) (byte.MinValue + difference > minAndMax.Min
                    ? byte.MinValue
                    : minAndMax.Min - difference);

                return _random.NextByte(min, minAndMax.Min);
            }

            var max = (byte) (byte.MaxValue - difference < minAndMax.Max
                ? byte.MaxValue
                : minAndMax.Max + difference);

            return _random.NextByte(minAndMax.Max, max);
        }
        
        public decimal Blend(decimal first, decimal second)
        {
            var minAndMax = GetMinAndMax(first, second);

            var difference = minAndMax.Max - minAndMax.Min;

            if (NextSelection() == BlenderSelection.InBounds)
            {
                return _random.NextDecimal(minAndMax.Min, minAndMax.Max);
            }

            if (NextSelection() == BlenderSelection.Low)
            {
                var min = decimal.MinValue + difference > minAndMax.Min
                    ? decimal.MinValue
                    : minAndMax.Min - difference;

                return _random.NextDecimal(min, minAndMax.Min);
            }

            var max = decimal.MaxValue - difference < minAndMax.Max
                ? decimal.MaxValue
                : minAndMax.Max + difference;

            return _random.NextDecimal(minAndMax.Max, max);
        }

        public Color Blend(Color first, Color second)
        {
            var red = Blend(first.Red, second.Red);
            var green = Blend(first.Green, second.Green);
            var blue = Blend(first.Blue, second.Blue);
            
            return new Color(red, green, blue);
        }

        private BlenderSelection NextSelection()
        {
            var next = _random.Next(1, _highThreshold);

            if (next.CompareTo(_lowThreshold) < 1)
            {
                return BlenderSelection.Low;
            }

            return next.CompareTo(_inBoundsThreshold) < 1 ? BlenderSelection.InBounds : BlenderSelection.High;
        }

        private static MinAndMax<T> GetMinAndMax<T>(T first, T second) where T : IComparable<T>
            => first.CompareTo(second) < 1 ? new MinAndMax<T>(first, second) : new MinAndMax<T>(second, first);

        private sealed class MinAndMax<T>
        {
            public MinAndMax(T min, T max)
            {
                Min = min;
                Max = max;
            }
            
            public T Min { get; }
            public T Max { get; }
        }
    }
}
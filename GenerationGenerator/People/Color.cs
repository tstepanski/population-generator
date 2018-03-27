using System;

namespace GenerationGenerator.People
{
    public struct Color : IEquatable<Color>
    {
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public byte Red { get; }
        public byte Green { get; }
        public byte Blue { get; }

        public override bool Equals(object other)
            => other != null && (other is Color color && Equals(color));

        public bool Equals(Color other)
            => Red == other.Red
               && Green == other.Green
               && Blue == other.Blue;

        public override int GetHashCode() => (Red << 16) + (Green << 8) + Blue;
    }
}
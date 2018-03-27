using System;
using GenerationGenerator.People;
using Xunit;

namespace GenerationGeneratorTests.People
{
    public sealed class ColorTests
    {
        [Fact]
        public void GetHashCode_GivenWhite_Returns24BitsSetToTrueAsBinary()
        {
            var white = new Color(255, 255, 255);
            var binaryString = Convert.ToString(white.GetHashCode(), 2);

            Assert.Equal("111111111111111111111111", binaryString);
        }
        
        [Fact]
        public void GetHashCode_GivenBlack_Returns0()
        {
            var black = new Color(0, 0, 0);

            Assert.Equal(0, black.GetHashCode());
        }
        
        [Fact]
        public void GetHashCode_GivenBlue_Returns255()
        {
            var black = new Color(0, 0, 255);

            Assert.Equal(255, black.GetHashCode());
        }
        
        [Fact]
        public void GetHashCode_GivenGreen_Returns65280()
        {
            var black = new Color(0, 255, 0);

            Assert.Equal(65280, black.GetHashCode());
        }
        
        [Fact]
        public void GetHashCode_GivenRed_Returns16711680()
        {
            var black = new Color(255, 0, 0);

            Assert.Equal(16711680, black.GetHashCode());
        }
    }
}
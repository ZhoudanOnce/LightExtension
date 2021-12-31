using FluentAssertions;
using Xunit;

namespace LightExtension.Test
{
    public class LightStringTest
    {
        [Fact]
        public void LightStringConst()
        {
            LightString.Space.Should().Be(' ');
        }

        [Fact]
        public void BreakTestSpaceNormal()
        {
            // Given
            var str = "This is a sentence";

            // When
            var result = str.Break();

            // Then
            result.Should().HaveCount(4);
        }

        [Fact]
        public void BreakTestMoreSpace()
        {
            // Given
            var str = "  This   is   a  sentence      ";

            // When
            var result = str.Break();

            // Then
            result.Should().HaveCount(4);
        }

        [Fact]
        public void BreakTestOtherMark()
        {
            // Given
            var str = "**This*******is***a*sentence****";

            // When
            var result = str.Break('*');

            // Then
            result.Should().HaveCount(4);
        }

        [Fact]
        public void BreakTestOtherWord()
        {
            // Given
            var str = "fuckThisfuckfuckisfuckafuckfuckfuckfucksentencefuckfuck";

            // When
            var result = str.Break("fuck");

            // Then
            result.Should().HaveCount(4);
        }
    }
}
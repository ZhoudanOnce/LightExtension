using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace LightExtension.Test
{
    public class LightLinqTest
    {
        [Fact]
        public void TouchTest()
        {
            var list1 = LightLinq.Touch(1, 5);
            var list2 = LightLinq.Touch(1, -5);
            var list3 = LightLinq.Touch(-1, 5);
            var list4 = LightLinq.Touch(-1, -5);

            list1.Should().BeEquivalentTo(new List<int> { 1, 2, 3, 4, 5 });
            list2.Should().BeEquivalentTo(new List<int> { 1, 0, -1, -2, -3, -4, -5 });
            list3.Should().BeEquivalentTo(new List<int> { -1, 0, 1, 2, 3, 4, 5 });
            list4.Should().BeEquivalentTo(new List<int> { -1, -2, -3, -4, -5 });
        }
    }
}
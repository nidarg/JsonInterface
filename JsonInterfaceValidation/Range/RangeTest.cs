using JsonInterface.Range;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JsonInterfaceValidation.Range
{
    public class RangeTest
    {
        [Theory]
        [InlineData('c', 'r', "fgh", true)]
        public void TestMatchRange(char start, char end, string text, bool expected)
        {
            Ranges range = new Ranges(start, end);
            bool actual = range.MatchRange(text);
            Assert.Equal(expected, actual);
        }
    }
}

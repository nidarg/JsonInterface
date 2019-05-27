using JsonInterface.Character;
using JsonInterface.Sequance;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JsonInterfaceValidation.SequanceTest
{
    public class SequanceTest
    {
        [Theory]
        [InlineData('a', 'b', 'c', true)]
        public void TestSequanceSuccess(char c1, char c2, char c3, bool expected)
        {
            var ab = new Sequances(
                new Charact(c1),
                new Charact(c2)
                );

            var abc = new Sequances(
                    ab,
                    new Charact(c3)
                    );


            bool actual = abc.Match("abcd").Success();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('a', 'b', 'c', "d")]
        public void TestSequanceRemainingText(char c1, char c2, char c3, string expected)
        {
            var ab = new Sequances(
                new Charact(c1),
                new Charact(c2)
                );

            var abc = new Sequances(
                    ab,
                    new Charact(c3)
                    );


            string actual = abc.Match("abcd").RemainingText();
            Assert.Equal(expected, actual);
        }


    }
}

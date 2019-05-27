using JsonInterface.Character;
using JsonInterface.Choice;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JsonInterfaceValidation.ChoiceTest
{
    public class ChoiceTest
    {
        [Theory]
        [InlineData('1', '1', '9', true)]
        public void TestChoiceSuccess(char c1, char c2, char c3, bool expected)
        {
            var digit = new Choices(
                new Charact(c1),
                new Charact(c2),
               new Charact(c3)

                );
            bool actual = digit.Match("11945").Success();
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('1', '2', '9', "45")]
        public void TestChoiceRemainingText(char c1, char c2, char c3, string expected)
        {
            var digit = new Choices(
               new Charact(c1),
               new Charact(c2),
               new Charact(c3)

                );

            string actual = digit.Match("12945").RemainingText();
            Assert.Equal(expected, actual);
        }
    }
}

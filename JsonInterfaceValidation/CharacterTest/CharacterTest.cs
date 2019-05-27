using JsonInterface.Character;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace JsonInterfaceValidation.CharacterTest
{
    public class CharacterTest
    {
        [Theory]
        [InlineData('c', "fgh", false)]
        public void TestMatchCharacter(char c, string text, bool expected)
        {
            Charact character = new Charact(c);
            bool actual = character.MatchChar(text);
            Assert.Equal(expected, actual);
        }

    }
}

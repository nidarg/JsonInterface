using JsonInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInterface.Match
{
    public class MatchTrue : IMatch
    {

        string remainingText;

        public MatchTrue(string remainingText)
        {
            this.remainingText = remainingText;
        }

        public bool Success()
        {
            return true;
        }
        public string RemainingText()
        {
            return remainingText.Substring(1);
        }
    }
}

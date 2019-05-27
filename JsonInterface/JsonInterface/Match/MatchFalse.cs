using JsonInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInterface.Match
{
    public class MatchFalse : IMatch
    {

        string remainingText;

        public MatchFalse(string remainingText)
        {
            this.remainingText = remainingText;
        }

        public bool Success()
        {
            return false;
        }
        public string RemainingText()
        {
            return remainingText;
        }
    }
}

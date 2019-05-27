using JsonInterface.Interfaces;
using JsonInterface.Match;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInterface.Range
{
    public class Ranges : IPattern
    {
        private readonly char start;
        private readonly char end;


        public Ranges(char start, char end)
        {
            this.start = start;
            this.end = end;

        }


        //public bool Match(string text)
        //{
        //    if (string.IsNullOrEmpty(text))
        //        return false;

        //    return start <= text[0] && text[0] <= end;
        //}



        public bool MatchRange(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            return start <= text[0] && text[0] <= end;
        }

        public IMatch Match(string text)
        {
            if (this.MatchRange(text))
                return new MatchTrue(text);
            else return new MatchFalse(text);
        }
    }
}

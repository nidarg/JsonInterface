using JsonInterface.Interfaces;
using JsonInterface.Match;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInterface.Character
{
    public class Charact : IPattern
        {
            readonly char pattern;


            public Charact(char pattern)
            {
                this.pattern = pattern;

            }



            public bool MatchChar(string text)
            {
                if (string.IsNullOrEmpty(text))
                    return false;

                return text[0] == pattern;
            }

            public IMatch Match(string text)
            {
                if (this.MatchChar(text))
                    return new MatchTrue(text);
                else return new MatchFalse(text);
            }


        }
    }


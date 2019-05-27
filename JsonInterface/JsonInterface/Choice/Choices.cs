using JsonInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInterface.Choice
{
    public class Choices : IPattern
    {
        IPattern[] patterns;

        public Choices(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            string lastMatch = text;
            int i = 0;
            foreach (var pattern in patterns)
            {

                if (pattern.Match(text).Success() == true)
                {
                    //text = pattern.Match(text).RemainingText();
                    text = text.Substring(1);

                    //pattern.Match(text);
                    i++;
                }
                else return pattern.Match(text);
            }

            return patterns[i - 1].Match(lastMatch.Substring(i - 1));
        }
    }
}

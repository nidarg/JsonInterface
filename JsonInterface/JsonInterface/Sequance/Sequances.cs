using JsonInterface.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace JsonInterface.Sequance
{
    public class Sequances : IPattern
    {
        IPattern[] patterns;


        public Sequances(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            string lastMatch = text;
            int i = 0; int j = 0;
            foreach (var pattern in patterns)
            {
               
                if (pattern.Match(text).Success() == true)
                {
                    if (pattern is Sequances)
                    {
                        text = text.Substring(1);
                        //i=1;
                        j++;
                    }
                    text = text.Substring(1);

                    Console.WriteLine("text after success " + text);
                    i++;
                    j++;
                }
                else return pattern.Match(text);
            }
            
            return patterns[i - 1].Match(lastMatch.Substring(j - 1));
        }


    }
}

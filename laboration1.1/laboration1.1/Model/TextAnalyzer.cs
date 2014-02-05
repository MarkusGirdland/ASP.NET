using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laboration1._1
{
    public static class TextAnalyzer
    {
        public static int GetNumberOfCapitals(string text)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
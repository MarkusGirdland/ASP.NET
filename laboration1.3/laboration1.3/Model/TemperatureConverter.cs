using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace laboration1._3
{
    public static class TemperatureConverter
    {
        public static int CelsiusToFahrenheit(int degreesC)
        {
            double fahrenheit = (degreesC * 1.8) + 32;

            Math.Round(fahrenheit);

            int returnValue = Convert.ToInt32(fahrenheit);

            return returnValue;
        }

        public static int FahrenheitToCelsius(int degreesF)
        {
            double celsius = (degreesF - 32) * ((double)5 / (double)9);

            Math.Round(celsius);

            int returnValue = Convert.ToInt32(celsius);

            return returnValue;
        }
    }
}
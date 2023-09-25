using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StaticExercise
{


    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            // Conversion formula: (Fahrenheit - 32) * 5/9
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            // Conversion formula: (Celsius * 9/5) + 32
            return (celsius * 9 / 5) + 32;
        }
    }
}
   




    

    


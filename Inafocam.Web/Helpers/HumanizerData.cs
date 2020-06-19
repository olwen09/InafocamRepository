using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;

namespace Andamios.Web.Helpers
{
    public static class HumanizerData
    {
        public static string NumberToText(int number, CultureInfo culture)
        {
            return number.ToWords(culture).ToUpper();
        }
    }
}
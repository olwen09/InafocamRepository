using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inafocam.Web.Helpers
{
    public static class Currency
    {
		/// <summary>
		/// Convert a decimal number to currency words
		/// </summary>
		/// <param name="value">The value</param>
		/// <returns></returns>
		public static string ToCurrencyWords(this decimal value)
		{
			string decimals = "";
			string input = Math.Round(value, 2).ToString();

			if (input.Contains("."))
			{
				var pointIndex = input.IndexOf(".");
				decimals = input.Substring(pointIndex + 1);
				// remove the decimal part from input
				input = input.Remove(pointIndex);
			}

			var words = new StringBuilder();
			words.Append(GetWords(input));

			if (decimals.Length > 0)
				words.Append($" and {decimals} / 100 dollars");
			else
				words.Append(" and 00 / 100 dollars");

			return words.ToString();
		}

		private static string GetWords(string input)
		{
			// These are seperators for each 3 digit in numbers.
			string[] seperators = { "", " thousand ", " million ", " billion " };

			// Counter is indexer for seperators. Each 3 digit will increase this.
			int i = 0;

			var strWords = "";

			while (input.Length > 0)
			{
				// Get the 3 last numbers from input and store it. If there is no 3 numbers just use it.
				string _3digits = input.Length < 3 ? input : input.Substring(input.Length - 3);
				// Remove the 3 last digits from input.
				input = input.Length < 3 ? "" : input.Remove(input.Length - 3);

				int number = int.Parse(_3digits);

				_3digits = Get3DigitsWords(number);

				// apply the seperator.
				_3digits += seperators[i];
				// since we are getting numbers from right to left then we must append resault to strWords like this.
				strWords = _3digits + strWords;

				// 3 digits converted. count and go for next 3 digits
				i++;
			}
			return strWords;
		}

		private static string Get3DigitsWords(int number)
		{
			string[] ones =
			{
			"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
			"twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen"
		};

			string[] tens = { "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

			string word = "";

			if (number > 99 && number < 1000)
			{
				int i = number / 100;
				word = word + ones[i - 1] + " hundred ";
				number = number % 100;
			}

			if (number > 19 && number < 100)
			{
				int i = number / 10;
				word = word + tens[i - 1] + " ";
				number = number % 10;
			}

			if (number > 0 && number < 20)
			{
				word = word + ones[number - 1];
			}

			return word;
		}
	}
}

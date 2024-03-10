using System.Text.RegularExpressions;
using System;

namespace Sales_System_2._0.Application.Validations
{
    public static class ValidationUtility
    {
        public static bool IsValidDateFormat(DateTime date)
        {
            string expectedFormat = "yyyy-MM-dd HH:mm:ss.fffffff";
            string formattedDate = date.ToString(expectedFormat);

            return formattedDate == date.ToString(expectedFormat);
        }
        public static bool ContainsOnlyLetters(string text)
        {
            return Regex.IsMatch(text, "^[a-zA-Z ]+$");
        }
        public static bool ContainsOnlyNumbers(string text)
        {
            return Regex.IsMatch(text, @"^\d+$");
        }
        public static bool IsInt(int intValue)
        {
            string inttAsString = intValue.ToString();
            int parsedValue;

            return int.TryParse(inttAsString, out parsedValue);
        }
        public static bool IsShort(short? shortValue)
        {
            string shortAsString = shortValue.ToString();
            short parsedValue;

            return short.TryParse(shortAsString, out parsedValue);
        }
        public static bool IsDecimal(decimal decimalValue)
        {
            string decimalAsString = decimalValue.ToString();
            decimal parsedValue;

            return decimal.TryParse(decimalAsString, out parsedValue);
        }
        public static bool IsDecimalFormatValid(decimal discountAmount)
        {
            string formattedDecimal = discountAmount.ToString();
            string pattern = @"^\d+\.\d{2}$";

            return Regex.IsMatch(formattedDecimal, pattern);
        }

    }
}


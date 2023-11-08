using System;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if (stringValue == null)
            {
                throw new ArgumentNullException("Argument is null");
            }

            var trimmedValue = stringValue.Trim();
            if (string.IsNullOrEmpty(trimmedValue))
            {
                throw new FormatException("Invalid format");
            }

            if (trimmedValue == "-2147483648")
            {
                return int.MinValue;
            }


            bool isNegative = false;
            int startIndex = 0;
            if (trimmedValue[0] == '-')
            {
                isNegative = true;
                startIndex = 1;
            }

            if (trimmedValue[0] == '+')
            {
                isNegative = false;
                startIndex = 1;
            }

            int result = 0;
            for (int i = startIndex; i < trimmedValue.Length; i++)
            {
                if (!char.IsDigit(trimmedValue[i]))
                {
                    throw new FormatException($"Invalid character at position {i}");

                }

                int digitValue = trimmedValue[i] - '0';
                checked
                {
                    result = result * 10 + digitValue;
                }
            }

            if (isNegative)
            {
                return -result;
            }

            return result;
        }
    }
}
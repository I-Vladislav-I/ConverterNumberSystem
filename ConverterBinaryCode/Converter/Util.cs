using System;
using System.Collections.Generic;

namespace ConverterBinaryCode.Converter
{
    public class Util
    {
        public static string Reverse(List<string> norm)
        {
            string result = String.Empty;
            long[] s = new long[norm.Count];
            for (int i = norm.Count - 1; i >= 0; i--)
            {
                result += norm[i];
            }

            return result;
        }

        public static string ToDecimal(string inputText, NumberSystem numberSystem)
        {
            char[] numbers = inputText.ToCharArray();
            long decimalVar = 0;
            int counterRemainder = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                byte baseNumber = ((byte)numberSystem);

                if (numbers.Length - counterRemainder == 0)
                {
                    baseNumber = 1;
                }

                double v = Math.Pow(baseNumber, numbers.Length - counterRemainder);
                double v1 = fromHex(numbers[i]);
                long tempResult = Convert.ToInt64(v1 * v);
                decimalVar += tempResult;
                counterRemainder++;
            }

            return Convert.ToString(decimalVar);
        }

        private static byte fromHex(char input) 
        {
            switch (input) 
            {
                case 'A':
                    return 10;
                case 'B':
                    return 11;
                case 'C':
                    return 12;
                case 'D':
                    return 13;
                case 'E':
                    return 14;
                case 'F':
                    return 15;
            }

            return (byte)Char.GetNumericValue(input);
        }
    }
}

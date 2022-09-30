using System;
using System.Collections.Generic;

namespace ConverterBinaryCode.Converter
{
    public static class DecimalConverter
    {
        public static string ToBinary(string inputText)
        {
            return ConvertToNumberSystem(Int64.Parse(inputText), NumberSystem.BINARY);
        }

        public static string ToOctal(string inputText)
        {
            return ConvertToNumberSystem(Int64.Parse(inputText), NumberSystem.OCTAL);
        }

        public static string ToHex(string inputText)
        {
            return ConvertToNumberSystem(Int64.Parse(inputText), NumberSystem.HEX);
        }

        private static string ConvertToNumberSystem(long input, NumberSystem numberSystem)
        {
            if (input == 0)
            {
                return "0";
            }

            string temp1 = String.Empty;
            List<string> s = new List<string>();
            while (input > 0)
            {
                temp1 = Convert.ToString(input % (byte)numberSystem);

                if (numberSystem == NumberSystem.HEX)
                {
                    temp1 = toHex(Convert.ToByte(temp1));
                }

                input = input / (byte)numberSystem;
                s.Add(temp1.ToString());
            }
            return Util.Reverse(s);
        }

        private static string toHex(byte number)
        {
            return ((HexSystem)number).ToString();
        }
    }
}
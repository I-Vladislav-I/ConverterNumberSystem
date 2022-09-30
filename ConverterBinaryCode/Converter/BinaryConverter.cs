using System;

namespace ConverterBinaryCode.Converter
{
    public class BinaryConverter
    {
        public static string ToOctal(string inputText)
        {
            return DecimalConverter.ToOctal(ToDecimal(inputText));
        }

        public static string ToDecimal(string inputText)
        {
            return Util.ToDecimal(inputText, NumberSystem.BINARY);
        }

        public static string ToHex(string inputText)
        {
            return DecimalConverter.ToHex(ToDecimal(inputText));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterBinaryCode.Converter
{
    public class OctalConverter
    {
        public static string ToBinary(string inputText)
        {
            return DecimalConverter.ToBinary(ToDecimal(inputText));
        }

        public static string ToDecimal(string inputText)
        {
            return Util.ToDecimal(inputText, NumberSystem.OCTAL);
        }

        public static string ToHex(string inputText)
        {
            return DecimalConverter.ToHex(ToDecimal(inputText));
        }
    }
}

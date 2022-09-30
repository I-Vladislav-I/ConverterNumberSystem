namespace ConverterBinaryCode.Converter
{
    public class HexConverter
    {
        public static string ToBinary(string inputText)
        {
            return DecimalConverter.ToBinary(ToDecimal(inputText));
        }

        public static string ToOctal(string inputText)
        {
            return DecimalConverter.ToOctal(ToDecimal(inputText));
        }
        public static string ToDecimal(string inputText)
        {
            inputText = inputText.ToUpper();
            return Util.ToDecimal(inputText, NumberSystem.HEX);
        }
    }
}
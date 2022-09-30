using ConverterBinaryCode.Converter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DecimalConverter = ConverterBinaryCode.Converter.DecimalConverter;

namespace ConverterBinaryCode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init() 
        {
            numberSystemSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            numberSystemSelector.SelectedIndex = 0;
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (numberSystemSelector.SelectedIndex) 
            {
                case 0:
                    inputBinary(e);
                    break;
                case 1:
                    inputOctal(e);
                    break;
                case 2:
                    inputDecimal(e);
                    break;
                case 3:
                    inputHex(e);
                    break;
            }
        }


        private void inputBox_TextChanged(object sender, EventArgs e)
        {
            string inputText = inputBox.Text;

            if (inputText.Length == 0)
            {
                cleanBoxs();
                return;
            }

            switch (numberSystemSelector.SelectedIndex)
            {
                case 0:
                    output1.Text = BinaryConverter.ToOctal(inputText);
                    output2.Text = BinaryConverter.ToDecimal(inputText);
                    output3.Text = BinaryConverter.ToHex(inputText);
                    break;
                case 1:
                    output1.Text = OctalConverter.ToBinary(inputText);
                    output2.Text = OctalConverter.ToDecimal(inputText);
                    output3.Text = OctalConverter.ToHex(inputText);
                    break;
                case 2:
                    output1.Text = DecimalConverter.ToBinary(inputText);
                    output2.Text = DecimalConverter.ToOctal(inputText);
                    output3.Text = DecimalConverter.ToHex(inputText);
                    break;
                case 3:
                    output1.Text = HexConverter.ToBinary(inputText);
                    output2.Text = HexConverter.ToOctal(inputText);
                    output3.Text = HexConverter.ToDecimal(inputText);
                    break;
            }
        }

        private void inputBinary(KeyPressEventArgs e) 
        {
            char temp = e.KeyChar;
            if (!(e.KeyChar == 48 || e.KeyChar == 49) && !Char.IsControl(temp))
            {
                e.Handled = true;
            }
        }

        private void inputDecimal(KeyPressEventArgs e)
        {
            char temp = e.KeyChar;
            if (!Char.IsDigit(temp) && !Char.IsControl(temp))
            {
                e.Handled = true;
            }
        }

        private void inputOctal(KeyPressEventArgs e) 
        {
            char temp = e.KeyChar;
            if (!(e.KeyChar >= 48 && e.KeyChar <= 55) && !Char.IsControl(temp))
            {
                e.Handled = true;
            }
        }

        private void inputHex(KeyPressEventArgs e)
        {
            char temp = e.KeyChar;
            if (!Char.IsDigit(temp) && !(e.KeyChar >= 65 && e.KeyChar <= 70) && !(e.KeyChar >= 97 && e.KeyChar <= 102) && !Char.IsControl(temp))
            {
                e.Handled = true;
            }
        }

        private void numberSystemSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (numberSystemSelector.SelectedIndex)
            {
                case 0:
                    label1.Text = "Octal";
                    label2.Text = "Decimal";
                    label3.Text = "Hex";
                    break;
                case 1:
                    label1.Text = "Binary";
                    label2.Text = "Decimal";
                    label3.Text = "Hex";
                    break;
                case 2:
                    label1.Text = "Binary";
                    label2.Text = "Octal";
                    label3.Text = "Hex";
                    break;
                case 3:
                    label1.Text = "Binary";
                    label2.Text = "Octal";
                    label3.Text = "Decimal";
                    break;
            }
            cleanBoxs();
        }

        private void cleanBoxs()
        {
            inputBox.Clear();
            output1.Clear();
            output2.Clear();
            output3.Clear();
        }
    }
}

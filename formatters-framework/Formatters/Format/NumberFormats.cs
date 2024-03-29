﻿//
//  NumberFormats.cs
//
//  Code Construct System 2021-2024
//
using System;
using System.Text;

namespace Formatters
{
    public class NumberFormats : INumberFormats
    {
        private static readonly string[] ordinalsTable =
        {
            "th", "st", "nd", "rd"
        };

        private static readonly string[] unitsTable =
        {
            "Zero", "One",    "Two",    "Three",    "Four",     "Five",    "Six",     "Seven",     "Eight",    "Nine",
            "Ten",  "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
        };

        private static readonly string[] tensTable =
        {
            "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
        };

        public string GetOrdinal(int number)
        {
            if (((number %= 100) > 9 && number < 20) || (number %= 10) > 3)
            {
                number = 0;
            }
            return (ordinalsTable[number]);
        }

        public string GetLiteralAmount(double amount)
        {
            var buffer = new StringBuilder { Length = 0 };

            if (amount < -999999999999999.00)
            {
                return "(under minimum amount limit -999,999,999,999,999.00)";
            }
            if (amount > 999999999999999.99)
            {
                return "(over maximum amount limit 999,999,999,999,999.99)";
            }
            if (amount < 0)
            {
                buffer.Append("Minus ");
                amount *= -1;
            }

            var temporary = (int)(amount / 1E12);
            if (temporary > 0)
            {
                buffer.Append(FormatGroup(temporary, "Trillion"));
                amount %= 1E12;
            }
            temporary = (int)(amount / 1E9);
            if (temporary > 0)
            {
                buffer.Append(FormatGroup(temporary, "Billion"));
                amount %= 1E9;
            }
            temporary = (int)(amount / 1E6);
            if (temporary > 0)
            {
                buffer.Append(FormatGroup(temporary, "Million"));
                amount %= 1E6;
            }
            temporary = (int)(amount / 1E3);
            if (temporary > 0)
            {
                buffer.Append(FormatGroup(temporary, "Thousand"));
                amount = amount % 1E3;
            }

            buffer.Append(FormatGroup((int)amount, string.Empty));
            if (buffer.Length < 1)
            {
                buffer.Append(unitsTable[0] + " ");
            }

            var fractional = GetDecimalPart(amount);

            buffer.Append("and " + fractional + "/100");

            return buffer.ToString();
        }

        private static string FormatGroup(int number, string scale)
        {
            var buffer = new StringBuilder { Length = 0 };

            if (number >= 100)
            {
                buffer.Append(unitsTable[number / 100] + " Hundred ");
                number %= 100;
            }
            if (number >= 20)
            {
                buffer.Append(tensTable[(number - 20) / 10]);
                if (0 != (number %= 10))
                {
                    buffer.Append("-" + unitsTable[number] + " ");
                }
                else
                {
                    buffer.Append(' ');
                }
            }
            else if (number > 0)
            {
                buffer.Append(unitsTable[number] + " ");
            }
            if (scale.Length > 0)
            {
                buffer.Append(scale + " ");
            }
            return buffer.ToString();
        }

        private static String GetDecimalPart(double amount)
        {
            var decimalPart = (decimal)(amount - Math.Truncate(amount));
            var decimalPartRounded = Decimal.Round(decimalPart, 2);
            var decimalPartIntger = (int)(decimalPartRounded * 100);

            return decimalPartIntger.ToString();
        }
    }
}
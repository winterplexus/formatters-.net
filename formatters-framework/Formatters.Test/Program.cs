//
//  Program.cs
//
//  Wiregrass Code Technology 2021-2022
//
using System;

[assembly: CLSCompliant(true)]
namespace Formatters.Test
{
    internal class Program
    {
        internal static void Main()
        {
            TestDateTimeFormats();
            TestNumberFormats();
        }

        private static void TestDateTimeFormats()
        {
            var dateTime = DateTime.Now;

            /*
            *  specification :  %a - abbreviated weekday name
            *                   %A - full weekday name
            *                   %b - abbreviated month name
            *                   %B - full month name
            *                   %c - locale-specific date and time
            *                   %d - day of the month as integer (01-31)
            *                   %H - hour (24-hour clock)
            *                   %I - hour (12-hour clock)
            *                   %j - day of the year as integer (001-366)
            *                   %m - month as integer (01-12)
            *                   %M - minute as integer (00-59)
            *                   %p - locale AM/PM designation
            *                   %S - second as integer (00-59)
            *                   %w - weekday as integer (0-6)
            *                   %W - week number of the year (00-52)
            *                   %x - locale specific date
            *                   %X - locale specific time
            *                   %y - year without century (00-99)
            *                   %Y - year with century
            *                   %Z - time zone name
            *                   %% - a single %             
            */

            Console.WriteLine("{0}test: date/time formats using specification, current date/time", Environment.NewLine);

            IDateTimeFormats dateTimeFormats = new DateTimeFormats();

            Console.WriteLine("  %a - abbreviated weekday name             : {0}", dateTimeFormats.Format("%a", dateTime));
            Console.WriteLine("  %A - full weekday name                    : {0}", dateTimeFormats.Format("%A", dateTime));
            Console.WriteLine("  %b - abbreviated month name               : {0}", dateTimeFormats.Format("%b", dateTime));
            Console.WriteLine("  %B - full month name                      : {0}", dateTimeFormats.Format("%B", dateTime));
            Console.WriteLine("  %c - locale-specific date and time        : {0}", dateTimeFormats.Format("%c", dateTime));
            Console.WriteLine("  %d - day of the month as integer (01-31)  : {0}", dateTimeFormats.Format("%d", dateTime));
            Console.WriteLine("  %H - hour (24-hour clock)                 : {0}", dateTimeFormats.Format("%H", dateTime));
            Console.WriteLine("  %I - hour (12-hour clock)                 : {0}", dateTimeFormats.Format("%I", dateTime));
            Console.WriteLine("  %j - day of the year as integer (001-366) : {0}", dateTimeFormats.Format("%j", dateTime));
            Console.WriteLine("  %m - month as integer (01-12)             : {0}", dateTimeFormats.Format("%m", dateTime));
            Console.WriteLine("  %M - minute as integer (00-59)            : {0}", dateTimeFormats.Format("%M", dateTime));
            Console.WriteLine("  %p - locale AM/PM designation             : {0}", dateTimeFormats.Format("%p", dateTime));
            Console.WriteLine("  %S - second as integer (00-59)            : {0}", dateTimeFormats.Format("%S", dateTime));
            Console.WriteLine("  %w - weekday as integer (0-6)             : {0}", dateTimeFormats.Format("%w", dateTime));
            Console.WriteLine("  %W - week number of the year (00-52)      : {0}", dateTimeFormats.Format("%W", dateTime));
            Console.WriteLine("  %x - locale specific date                 : {0}", dateTimeFormats.Format("%x", dateTime));
            Console.WriteLine("  %X - locale specific time                 : {0}", dateTimeFormats.Format("%X", dateTime));
            Console.WriteLine("  %y - year without century (00-99)         : {0}", dateTimeFormats.Format("%y", dateTime));
            Console.WriteLine("  %Y - year with century                    : {0}", dateTimeFormats.Format("%Y", dateTime));
            Console.WriteLine("  %Z - time zone name                       : {0}", dateTimeFormats.Format("%Z", dateTime));
            Console.WriteLine("  %% - a single %                           : {0}", dateTimeFormats.Format("%%", dateTime));

            Console.WriteLine("{0}test: date/time formats using specification only", Environment.NewLine);

            Console.WriteLine("  %a - abbreviated weekday name             : {0}", dateTimeFormats.Format("%a"));
            Console.WriteLine("  %A - full weekday name                    : {0}", dateTimeFormats.Format("%A"));
            Console.WriteLine("  %b - abbreviated month name               : {0}", dateTimeFormats.Format("%b"));
            Console.WriteLine("  %B - full month name                      : {0}", dateTimeFormats.Format("%B"));
            Console.WriteLine("  %c - locale-specific date and time        : {0}", dateTimeFormats.Format("%c"));
            Console.WriteLine("  %d - day of the month as integer (01-31)  : {0}", dateTimeFormats.Format("%d"));
            Console.WriteLine("  %H - hour (24-hour clock)                 : {0}", dateTimeFormats.Format("%H"));
            Console.WriteLine("  %I - hour (12-hour clock)                 : {0}", dateTimeFormats.Format("%I"));
            Console.WriteLine("  %j - day of the year as integer (001-366) : {0}", dateTimeFormats.Format("%j"));
            Console.WriteLine("  %m - month as integer (01-12)             : {0}", dateTimeFormats.Format("%m"));
            Console.WriteLine("  %M - minute as integer (00-59)            : {0}", dateTimeFormats.Format("%M"));
            Console.WriteLine("  %p - locale AM/PM designation             : {0}", dateTimeFormats.Format("%p"));
            Console.WriteLine("  %S - second as integer (00-59)            : {0}", dateTimeFormats.Format("%S"));
            Console.WriteLine("  %w - weekday as integer (0-6)             : {0}", dateTimeFormats.Format("%w"));
            Console.WriteLine("  %W - week number of the year (00-52)      : {0}", dateTimeFormats.Format("%W"));
            Console.WriteLine("  %x - locale specific date                 : {0}", dateTimeFormats.Format("%x"));
            Console.WriteLine("  %X - locale specific time                 : {0}", dateTimeFormats.Format("%X"));
            Console.WriteLine("  %y - year without century (00-99)         : {0}", dateTimeFormats.Format("%y"));
            Console.WriteLine("  %Y - year with century                    : {0}", dateTimeFormats.Format("%Y"));
            Console.WriteLine("  %Z - time zone name                       : {0}", dateTimeFormats.Format("%Z"));
            Console.WriteLine("  %% - a single %                           : {0}", dateTimeFormats.Format("%%"));
        }

        private static void TestNumberFormats()
        {
            Console.WriteLine("{0}test: numbers formats ordinal amount", Environment.NewLine);

            INumberFormats numberFormats = new NumberFormats();

            Console.WriteLine("  1{0}",  numberFormats.GetOrdinal(1));
            Console.WriteLine("  2{0}",  numberFormats.GetOrdinal(2));
            Console.WriteLine("  3{0}",  numberFormats.GetOrdinal(3));
            Console.WriteLine("  4{0}",  numberFormats.GetOrdinal(4));
            Console.WriteLine("  5{0}",  numberFormats.GetOrdinal(5));
            Console.WriteLine("  6{0}",  numberFormats.GetOrdinal(6));
            Console.WriteLine("  7{0}",  numberFormats.GetOrdinal(7));
            Console.WriteLine("  8{0}",  numberFormats.GetOrdinal(8));
            Console.WriteLine("  9{0}", numberFormats.GetOrdinal(9));
            Console.WriteLine("  10{0}", numberFormats.GetOrdinal(10));
            Console.WriteLine("  11{0}", numberFormats.GetOrdinal(11));
            Console.WriteLine("  12{0}", numberFormats.GetOrdinal(12));
            Console.WriteLine("  13{0}", numberFormats.GetOrdinal(13));
            Console.WriteLine("  14{0}", numberFormats.GetOrdinal(14));
            Console.WriteLine("  15{0}", numberFormats.GetOrdinal(15));
            Console.WriteLine("  16{0}", numberFormats.GetOrdinal(16));
            Console.WriteLine("  17{0}", numberFormats.GetOrdinal(17));
            Console.WriteLine("  18{0}", numberFormats.GetOrdinal(18));
            Console.WriteLine("  19{0}", numberFormats.GetOrdinal(19));
            Console.WriteLine("  20{0}", numberFormats.GetOrdinal(20));

            Console.WriteLine("{0}test: numbers formats literal amount", Environment.NewLine);

            Console.WriteLine("                       .5 = {0}", numberFormats.GetLiteralAmount(0.5));
            Console.WriteLine("                      1.5 = {0}", numberFormats.GetLiteralAmount(1.5));
            Console.WriteLine("                     11.5 = {0}", numberFormats.GetLiteralAmount(11.5));
            Console.WriteLine("                    101.5 = {0}", numberFormats.GetLiteralAmount(101.5));
            Console.WriteLine("                   1001.5 = {0}", numberFormats.GetLiteralAmount(1001.5));
            Console.WriteLine("                 10,001.5 = {0}", numberFormats.GetLiteralAmount(10001.5));
            Console.WriteLine("                100,001.5 = {0}", numberFormats.GetLiteralAmount(100001.5));
            Console.WriteLine("              1,000,001.5 = {0}", numberFormats.GetLiteralAmount(1000001.5));
            Console.WriteLine("             10,000,001.5 = {0}", numberFormats.GetLiteralAmount(10000001.5));
            Console.WriteLine("            100,000,001.5 = {0}", numberFormats.GetLiteralAmount(100000001.5));
            Console.WriteLine("          1,000,000,001.5 = {0}", numberFormats.GetLiteralAmount(1000000001.5));
            Console.WriteLine("         10,000,000,001.5 = {0}", numberFormats.GetLiteralAmount(10000000001.5));
            Console.WriteLine("        100,000,000,001.5 = {0}", numberFormats.GetLiteralAmount(100000000001.5));
            Console.WriteLine("      1,000,000,000,001.5 = {0}", numberFormats.GetLiteralAmount(1000000000001.5));
            Console.WriteLine("     10,000,000,000,001.5 = {0}", numberFormats.GetLiteralAmount(10000000000001.5));
            Console.WriteLine("    100,000,000,000,001.5 = {0}", numberFormats.GetLiteralAmount(100000000000001.5));
            Console.WriteLine("  1,000,000,000,000,001.5 = {0}", numberFormats.GetLiteralAmount(1000000000000001.5));

            Console.WriteLine("                       .5 = {0}", numberFormats.GetLiteralAmount(0.5));
            Console.WriteLine("                      1.5 = {0}", numberFormats.GetLiteralAmount(1.5));
            Console.WriteLine("                     11.5 = {0}", numberFormats.GetLiteralAmount(11.5));
            Console.WriteLine("                    101.5 = {0}", numberFormats.GetLiteralAmount(101.5));
            Console.WriteLine("                  1,011.5 = {0}", numberFormats.GetLiteralAmount(1011.5));
            Console.WriteLine("                 10,111.5 = {0}", numberFormats.GetLiteralAmount(10111.5));
            Console.WriteLine("                101,011.5 = {0}", numberFormats.GetLiteralAmount(101011.5));
            Console.WriteLine("              1,010,101.5 = {0}", numberFormats.GetLiteralAmount(1010101.5));
            Console.WriteLine("             10,101,011.5 = {0}", numberFormats.GetLiteralAmount(10101011.5));
            Console.WriteLine("            101,010,101.5 = {0}", numberFormats.GetLiteralAmount(101010101.5));
            Console.WriteLine("          1,010,101,011.5 = {0}", numberFormats.GetLiteralAmount(1010101011.5));
            Console.WriteLine("         10,101,010,101.5 = {0}", numberFormats.GetLiteralAmount(10101010101.5));
            Console.WriteLine("        101,010,101,011.5 = {0}", numberFormats.GetLiteralAmount(101010101011.5));
            Console.WriteLine("      1,010,101,010,101.5 = {0}", numberFormats.GetLiteralAmount(1010101010101.5));
            Console.WriteLine("     10,101,010,101,011.5 = {0}", numberFormats.GetLiteralAmount(10101010101011.5));
            Console.WriteLine("    101,010,101,010,101.5 = {0}", numberFormats.GetLiteralAmount(101010101010101.5));
            Console.WriteLine("  1,010,101,010,101,011.5 = {0}", numberFormats.GetLiteralAmount(1010101010101011.5));
        }
    }
}
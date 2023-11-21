//
//  DateTimeFormatsTest.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters.Test
{
    [TestClass]
    public class DateTimeFormatsTest
    {
        /**
         *  Format output using specification and given date and time.
         *
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
        [TestMethod]
        public void DateformatsTest()
        {
            var ldt = new DateTime(2023, 01, 05, 20, 05, 55);
            var tzone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

            var dt = TimeZoneInfo.ConvertTimeFromUtc(ldt, tzone);

            var df = new DateTimeFormats();

            var format1  = df.Format("%a", dt);
            var format2  = df.Format("%A", dt);
            var format3  = df.Format("%b", dt);
            var format4  = df.Format("%B", dt);
            var format5  = df.Format("%a %A %b %B", dt);
            var format6  = df.Format("%d", dt);
            var format7  = df.Format("%m", dt);
            var format8  = df.Format("%y", dt);
            var format9  = df.Format("%Y", dt);
            var format10 = df.Format("%m/%d/%y", dt);
            var format11 = df.Format("%S", dt);
            var format12 = df.Format("%M", dt);
            var format13 = df.Format("%I", dt);
            var format14 = df.Format("%H", dt);
            var format15 = df.Format("%p", dt);
            var format16 = df.Format("%I:%M:%S %p", dt);
            var format17 = df.Format("%x", dt);
            var format18 = df.Format("%X", dt);
            var format19 = df.Format("%c", dt);
            var format20 = df.Format("%w", dt);
            var format21 = df.Format("%Z", dt);
            var format22 = df.Format("%j", dt);
            var format23 = df.Format("%W", dt);

            Console.WriteLine("");
            Console.WriteLine("class method DateTimeFormats.format() test");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("%a               : {0}", format1);
            Console.WriteLine("%A               : {0}", format2);
            Console.WriteLine("%b               : {0}", format3);
            Console.WriteLine("%B               : {0}", format4);
            Console.WriteLine("%a %A %b %b      : {0}", format5);
            Console.WriteLine("%d               : {0}", format6);
            Console.WriteLine("%m               : {0}", format7);
            Console.WriteLine("%y               : {0}", format8);
            Console.WriteLine("%Y               : {0}", format9);
            Console.WriteLine("%m/%d/%y         : {0}", format10);
            Console.WriteLine("%S               : {0}", format11);
            Console.WriteLine("%M               : {0}", format12);
            Console.WriteLine("%I               : {0}", format13);
            Console.WriteLine("%H               : {0}", format14);
            Console.WriteLine("%p               : {0}", format15);
            Console.WriteLine("%H:%M:%S %p      : {0}", format16);
            Console.WriteLine("%x               : {0}", format17);
            Console.WriteLine("%X               : {0}", format18);
            Console.WriteLine("%c               : {0}", format19);
            Console.WriteLine("%w               : {0}", format20);
            Console.WriteLine("%Z               : {0}", format21);
            Console.WriteLine("%j               : {0}", format22);
            Console.WriteLine("%W               : {0}", format23);
            Console.WriteLine("");

            Assert.AreEqual("Thr",                      format1);
            Assert.AreEqual("Thursday",                 format2);
            Assert.AreEqual("Jan",                      format3);
            Assert.AreEqual("January",                  format4);
            Assert.AreEqual("Thr Thursday Jan January", format5);
            Assert.AreEqual("05",                       format6);
            Assert.AreEqual("01",                       format7);
            Assert.AreEqual("23",                       format8);
            Assert.AreEqual("2023",                     format9);
            Assert.AreEqual("01/05/23",                 format10);
            Assert.AreEqual("55",                       format11);
            Assert.AreEqual("05",                       format12);
            Assert.AreEqual("03",                       format13);
            Assert.AreEqual("15",                       format14);
            Assert.AreEqual("PM",                       format15);
            Assert.AreEqual("03:05:55 PM",              format16);
            Assert.AreEqual("01/05/23",                 format17);
            Assert.AreEqual("15:05:55",                 format18);
            Assert.AreEqual("Thr Jan 05 15:05:55 2023", format19);
            Assert.AreEqual("4",                        format20);
            Assert.AreEqual("Eastern Standard Time",    format21);
            Assert.AreEqual("5",                        format22);
            Assert.AreEqual("1",                        format23);
        }
    }
}
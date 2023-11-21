//
//  NumberFormatsTest.cs
//
//  Code Construct System 2021-2024
//
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Formatters.Test
{
    [TestClass]
    public class NumberFormatsTest
    {
        [TestMethod]
        public void OrdinalTest()
        {
            INumberFormats numberFormats = new NumberFormats();

            Console.WriteLine("");
            Console.WriteLine("class method NumberFormats.GetOrdinal() test");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1{0}", numberFormats.GetOrdinal(1));
            Console.WriteLine("2{0}", numberFormats.GetOrdinal(2));
            Console.WriteLine("3{0}", numberFormats.GetOrdinal(3));
            Console.WriteLine("4{0}", numberFormats.GetOrdinal(4));

            Assert.AreEqual(numberFormats.GetOrdinal(1), "st");
            Assert.AreEqual(numberFormats.GetOrdinal(2), "nd");
            Assert.AreEqual(numberFormats.GetOrdinal(3), "rd");
            Assert.AreEqual(numberFormats.GetOrdinal(4), "th");
        }

        [TestMethod]
        public void LiteralAmountTest()
        {
            INumberFormats numberFormats = new NumberFormats();

            Console.WriteLine("");
            Console.WriteLine("class method numberFormats.GetLiteralAmount() test");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("amount: 0");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(0));
            Console.WriteLine("amount: 1");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(1));
            Console.WriteLine("amount: 1.01");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(1.01));
            Console.WriteLine("amount: 12.02");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(12.02));
            Console.WriteLine("amount: 123.03");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(123.03));
            Console.WriteLine("amount: 1234.04");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(1234.04));
            Console.WriteLine("amount: 12345.05");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(12345.05));
            Console.WriteLine("amount: 123456.06");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(123456.06));
            Console.WriteLine("amount: 1234567.07");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(1234567.07));
            Console.WriteLine("amount: 12345678.08");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(12345678.08));
            Console.WriteLine("amount: 123456789.09");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(123456789.09));
            Console.WriteLine("amount: 1234567890.10");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(1234567890.10));
            Console.WriteLine("amount: 12345678901.11");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(12345678901.11));
            Console.WriteLine("amount: 123456789012.491");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(123456789012.491));
            Console.WriteLine("amount: 1234567890123.501");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(1234567890123.501));
            Console.WriteLine("amount: 12345678901234.5123");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(12345678901234.5123));
            Console.WriteLine("amount: 0");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(0));
            Console.WriteLine("amount: -1");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-1));
            Console.WriteLine("amount: -1.01");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-1.01));
            Console.WriteLine("amount: -12.02");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-12.02));
            Console.WriteLine("amount: -123.03");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-123.03));
            Console.WriteLine("amount: -1234.04");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-1234.04));
            Console.WriteLine("amount: -12345.05");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-12345.05));
            Console.WriteLine("amount: -123456.06");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-123456.06));
            Console.WriteLine("amount: -1234567.07");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-1234567.07));
            Console.WriteLine("amount: -12345678.08");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-12345678.08));
            Console.WriteLine("amount: -123456789.09");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-123456789.09));
            Console.WriteLine("amount: -1234567890.10");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-1234567890.10));
            Console.WriteLine("amount: -12345678901.11");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-12345678901.11));
            Console.WriteLine("amount: -123456789012.491");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-123456789012.491));
            Console.WriteLine("amount: -1234567890123.501");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-1234567890123.501));
            Console.WriteLine("amount: -12345678901234.5123");
            Console.WriteLine("{0}", numberFormats.GetLiteralAmount(-12345678901234.5123));
            Console.WriteLine("");
            
            Assert.AreEqual("Zero and 0/100",                                                                                                                                  numberFormats.GetLiteralAmount(0));
            Assert.AreEqual("One and 0/100",                                                                                                                                   numberFormats.GetLiteralAmount(1));
            Assert.AreEqual("One and 1/100",                                                                                                                                   numberFormats.GetLiteralAmount(1.01));
            Assert.AreEqual("Twelve and 2/100",                                                                                                                                numberFormats.GetLiteralAmount(12.02));
            Assert.AreEqual("One Hundred Twenty-Three and 3/100",                                                                                                              numberFormats.GetLiteralAmount(123.03));
            Assert.AreEqual("One Thousand Two Hundred Thirty-Four and 4/100",                                                                                                  numberFormats.GetLiteralAmount(1234.04));
            Assert.AreEqual("Twelve Thousand Three Hundred Forty-Five and 5/100",                                                                                              numberFormats.GetLiteralAmount(12345.05));
            Assert.AreEqual("One Hundred Twenty-Three Thousand Four Hundred Fifty-Six and 6/100",                                                                              numberFormats.GetLiteralAmount(123456.06));
            Assert.AreEqual("One Million Two Hundred Thirty-Four Thousand Five Hundred Sixty-Seven and 7/100",                                                                 numberFormats.GetLiteralAmount(1234567.07));
            Assert.AreEqual("Twelve Million Three Hundred Forty-Five Thousand Six Hundred Seventy-Eight and 8/100",                                                            numberFormats.GetLiteralAmount(12345678.08));
            Assert.AreEqual("One Hundred Twenty-Three Million Four Hundred Fifty-Six Thousand Seven Hundred Eighty-Nine and 9/100",                                            numberFormats.GetLiteralAmount(123456789.09));
            Assert.AreEqual("One Billion Two Hundred Thirty-Four Million Five Hundred Sixty-Seven Thousand Eight Hundred Ninety and 10/100",                                   numberFormats.GetLiteralAmount(1234567890.10));
            Assert.AreEqual("Twelve Billion Three Hundred Forty-Five Million Six Hundred Seventy-Eight Thousand Nine Hundred One and 11/100",                                  numberFormats.GetLiteralAmount(12345678901.11));
            Assert.AreEqual("One Hundred Twenty-Three Billion Four Hundred Fifty-Six Million Seven Hundred Eighty-Nine Thousand Twelve and 49/100",                            numberFormats.GetLiteralAmount(123456789012.491));
            Assert.AreEqual("One Trillion Two Hundred Thirty-Four Billion Five Hundred Sixty-Seven Million Eight Hundred Ninety Thousand One Hundred Twenty-Three and 50/100", numberFormats.GetLiteralAmount(1234567890123.501));
            Assert.AreEqual("Twelve Trillion Three Hundred Forty-Five Billion Six Hundred Seventy-Eight Million Nine Hundred One Thousand Two Hundred Thirty-Four and 51/100", numberFormats.GetLiteralAmount(12345678901234.5123));
                        
            Assert.AreEqual("Zero and 0/100",                                                                                                                                        numberFormats.GetLiteralAmount(0));
            Assert.AreEqual("Minus One and 0/100",                                                                                                                                   numberFormats.GetLiteralAmount(-1));
            Assert.AreEqual("Minus One and 1/100",                                                                                                                                   numberFormats.GetLiteralAmount(-1.01));
            Assert.AreEqual("Minus Twelve and 2/100",                                                                                                                                numberFormats.GetLiteralAmount(-12.02));
            Assert.AreEqual("Minus One Hundred Twenty-Three and 3/100",                                                                                                              numberFormats.GetLiteralAmount(-123.03));
            Assert.AreEqual("Minus One Thousand Two Hundred Thirty-Four and 4/100",                                                                                                  numberFormats.GetLiteralAmount(-1234.04));
            Assert.AreEqual("Minus Twelve Thousand Three Hundred Forty-Five and 5/100",                                                                                              numberFormats.GetLiteralAmount(-12345.05));
            Assert.AreEqual("Minus One Hundred Twenty-Three Thousand Four Hundred Fifty-Six and 6/100",                                                                              numberFormats.GetLiteralAmount(-123456.06));
            Assert.AreEqual("Minus One Million Two Hundred Thirty-Four Thousand Five Hundred Sixty-Seven and 7/100",                                                                 numberFormats.GetLiteralAmount(-1234567.07));
            Assert.AreEqual("Minus Twelve Million Three Hundred Forty-Five Thousand Six Hundred Seventy-Eight and 8/100",                                                            numberFormats.GetLiteralAmount(-12345678.08));
            Assert.AreEqual("Minus One Hundred Twenty-Three Million Four Hundred Fifty-Six Thousand Seven Hundred Eighty-Nine and 9/100",                                            numberFormats.GetLiteralAmount(-123456789.09));
            Assert.AreEqual("Minus One Billion Two Hundred Thirty-Four Million Five Hundred Sixty-Seven Thousand Eight Hundred Ninety and 10/100",                                   numberFormats.GetLiteralAmount(-1234567890.10));
            Assert.AreEqual("Minus Twelve Billion Three Hundred Forty-Five Million Six Hundred Seventy-Eight Thousand Nine Hundred One and 11/100",                                  numberFormats.GetLiteralAmount(-12345678901.11));
            Assert.AreEqual("Minus One Hundred Twenty-Three Billion Four Hundred Fifty-Six Million Seven Hundred Eighty-Nine Thousand Twelve and 49/100",                            numberFormats.GetLiteralAmount(-123456789012.491));
            Assert.AreEqual("Minus One Trillion Two Hundred Thirty-Four Billion Five Hundred Sixty-Seven Million Eight Hundred Ninety Thousand One Hundred Twenty-Three and 50/100", numberFormats.GetLiteralAmount(-1234567890123.501));
            Assert.AreEqual("Minus Twelve Trillion Three Hundred Forty-Five Billion Six Hundred Seventy-Eight Million Nine Hundred One Thousand Two Hundred Thirty-Four and 51/100", numberFormats.GetLiteralAmount(-12345678901234.5123));           
        }
    }
}
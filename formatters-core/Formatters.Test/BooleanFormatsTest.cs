//
//  BooleanFormatsTest.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters.Test
{
    [TestClass]
    public class BooleanFormatsTest
    {
        [TestMethod]
        public void LiteralTest()
        {
            IBooleanFormats booleanFormats = new BooleanFormats();

            Console.WriteLine("");
            Console.WriteLine("class method BooleanFormats.LiteralTest() test");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("boolean literal for true         : {0}", booleanFormats.GetLiteral(true));
            Console.WriteLine("boolean literal for false        : {0}", booleanFormats.GetLiteral(false));
            Console.WriteLine("");

            Assert.AreEqual("true", booleanFormats.GetLiteral(true));
            Assert.AreEqual("false", booleanFormats.GetLiteral(false));
        }

        [TestMethod]
        public void LiteralLetterTest()
        {
            IBooleanFormats booleanFormats = new BooleanFormats();

            Console.WriteLine("");
            Console.WriteLine("class method BooleanFormats.GetLiteralLetter() test");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("boolean literal letter for true  : " + booleanFormats.GetLiteralLetter(true));
            Console.WriteLine("boolean literal letter for false : " + booleanFormats.GetLiteralLetter(false));
            Console.WriteLine("");

            Assert.AreEqual('T', booleanFormats.GetLiteralLetter(true));
            Assert.AreEqual('F', booleanFormats.GetLiteralLetter(false));
        }
    }
}
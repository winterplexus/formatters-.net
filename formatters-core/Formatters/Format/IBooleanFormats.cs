//
//  IBooleanFormats.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    public interface IBooleanFormats
    {
        public string GetLiteral(bool condition);
        public char GetLiteralLetter(bool condition);
    }
}
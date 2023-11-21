//
//  IBooleanFormats.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    public interface IBooleanFormats
    {
        string GetLiteral(bool condition);
        char   GetLiteralLetter(bool condition);
    }
}
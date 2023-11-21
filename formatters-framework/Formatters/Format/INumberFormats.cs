//
//  INumberFormats.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    public interface INumberFormats
    {
        string GetOrdinal(int number);
        string GetLiteralAmount(double amount);
    }
}
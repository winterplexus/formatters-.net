//
//  INumberFormats.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    public interface INumberFormats
    {
        public string GetOrdinal(int number);
        public string GetLiteralAmount(double amount);
    }
}
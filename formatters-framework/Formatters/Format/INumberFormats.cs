//
//  INumberFormats.cs
//
//  Wiregrass Code Technology 2021
//
namespace Formatters
{
    public interface INumberFormats
    {
        string GetOrdinal(int number);
        string GetLiteralAmount(double amount);
    }
}
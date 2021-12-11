//
//  INumberFormats.cs
//
//  Wiregrass Code Technology 2021-2022
//
namespace Formatters
{
    public interface INumberFormats
    {
        string GetOrdinal(int number);
        string GetLiteralAmount(double amount);
    }
}
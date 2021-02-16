//
//  INumberFormats.cs
//
//  Wiregrass Code Technology 2021
//
namespace Formatters
{
    public interface INumberFormats
    {
        public string GetOrdinal(int number);
        public string GetLiteralAmount(double amount);
    }
}
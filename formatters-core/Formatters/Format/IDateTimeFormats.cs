//
//  IDateTimeFormats.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    public interface IDateTimeFormats
    {
        public string Format(string dateTimeSpecification);
        public string Format(string dateTimeSpecification, DateTime dateTime);
    }
}
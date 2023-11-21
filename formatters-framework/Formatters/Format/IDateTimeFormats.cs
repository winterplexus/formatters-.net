//
//  IDateTimeFormats.cs
//
//  Code Construct System 2021-2024
//
using System;

namespace Formatters
{
    public interface IDateTimeFormats
    {
        string Format(string dateTimeSpecification);
        string Format(string dateTimeSpecification, DateTime dateTime);
    }
}
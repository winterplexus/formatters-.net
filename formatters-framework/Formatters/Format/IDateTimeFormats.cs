//
//  IDateTimeFormats.cs
//
//  Wiregrass Code Technology 2021-2022
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
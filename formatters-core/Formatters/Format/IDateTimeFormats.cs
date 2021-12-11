﻿//
//  IDateTimeFormats.cs
//
//  Wiregrass Code Technology 2021-2022
//
using System;

namespace Formatters
{
    public interface IDateTimeFormats
    {
        public string Format(string dateTimeSpecification);
        public string Format(string dateTimeSpecification, DateTime dateTime);
    }
}
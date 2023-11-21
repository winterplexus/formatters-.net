Formatters Library for .NET
===========================

Formatters library based on .NET 8 LTS and .NET Framework 4.8 platform and contains interfaces, classes for formatting objects into use case strings.

* IBooleanFormats interface:

```
    public interface IBooleanFormats
    {
        public string GetLiteral(bool condition);
        public char GetLiteralLetter(bool condition);
    }
```

* IDateTimeFormats interface:

```
    public interface IDateTimeFormats
    {
        public string Format(string dateTimeSpecification);
        public string Format(string dateTimeSpecification, DateTime dateTime);
    }
```

The date/time specifications are:

Specification | Description
------------- | -----------
%a | abbreviated weekday name
%A | full weekday name
%b | abbreviated month name
%B | full month name
%c | locale-specific date and time
%d | day of the month as integer (01-31)
%H | hour (24-hour clock)
%I | hour (12-hour clock)
%j | day of the year as integer (001-366)
%m | month as integer (01-12)
%M | minute as integer (00-59)
%p | locale AM/PM designation
%S | second as integer (00-59)
%w | weekday as integer (0-6)
%W | week number of the year (00-52)
%x | locale specific date
%X | locale specific time
%y | year without century (00-99)
%Y | year with century
%Z | time zone name
%% | a single %

* INumberFormats interface:

```
    public interface INumberFormats
    {
        public string GetOrdinal(int number);
        public string GetLiteralAmount(double amount);
    }
```

The library is separated into two VisualStudio solutions: one for .NET 8 LTS platform and one for .NET Framework 4.8 platform.


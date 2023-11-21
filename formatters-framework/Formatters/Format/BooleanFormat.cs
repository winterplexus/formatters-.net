//
//  BooleanFormats.cs
//
//  Code Construct System 2021-2024
//
using System;

[assembly: CLSCompliant(true)]
namespace Formatters
{
    public class BooleanFormats : IBooleanFormats
    {
        public string GetLiteral(bool condition)
        {
            return condition ? "true" : "false";
        }

        public char GetLiteralLetter(bool condition)
        {
            return condition ? 'T' : 'F';
        }
    }
}
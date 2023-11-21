//
//  ICharacterIterator.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    internal interface ICharacterIterator
    {
        public char First();
        public char Last();
        public char Current();
        public char Forward();
        public char Back();
        public char AtEnd();
        public int  GetIndex();
        public int  GetBeginIndex();
        public int  GetEndIndex();
    }
}
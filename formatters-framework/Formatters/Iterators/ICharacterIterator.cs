//
//  ICharacterIterator.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    internal interface ICharacterIterator
    {
        char First();
        char Last();
        char Current();
        char Forward();
        char Back();
        char AtEnd();
        int  GetBeginIndex();
        int  GetEndIndex();
        int  GetIndex();
    }
}
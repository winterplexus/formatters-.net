//
//  ICharacterIterator.cs
//
//  Wiregrass Code Technology 2021-2022
//
namespace Formatters
{
    public interface ICharacterIterator
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

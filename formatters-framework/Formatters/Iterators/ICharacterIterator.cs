//
//  ICharacterIterator.cs
//
//  Wiregrass Code Technology 2021
//
namespace Formatters
{
    public interface ICharacterIterator
    {
        char First();
        char Last();
        char Current();
        char Next();
        char Previous();
        char AtEnd();
        int GetBeginIndex();
        int GetEndIndex();
        int GetIndex();
    }
}

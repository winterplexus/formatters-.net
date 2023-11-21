//
//  CharacterIterator.cs
//
//  Code Construct System 2021-2024
//
namespace Formatters
{
    internal sealed class CharacterIterator : ICharacterIterator
    {
        private const char endOfLine = '\uffff';
        private readonly string text;
        private readonly int beginIndex;
        private readonly int endIndex;
        private int index;

        public CharacterIterator(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            text = value;
            beginIndex = 0;
            endIndex = text.Length;
            index = 0;
        }

        public char First()
        {
            index = beginIndex;
            return Current();
        }

        public char Last()
        {
            if (endIndex != beginIndex)
            {
                index = endIndex - 1;
            }
            else
            {
                index = endIndex;
            }
            return Current();
        }

        public char Current()
        {
            if (index >= beginIndex && (index < endIndex))
            {
                return text[index];
            }
            return endOfLine;
        }

        public char Forward()
        {
            if (index < endIndex - 1)
            {
                index++;
                return text[index];
            }
            index = endIndex;
            return endOfLine;
        }

        public char Back()
        {
            if (index > beginIndex)
            {
                index--;
                return text[index];
            }
            return endOfLine;
        }

        public char AtEnd()
        {
            return endOfLine;
        }

        public int GetIndex()
        {
            return index;
        }

        public int GetBeginIndex()
        {
            return beginIndex;
        }

        public int GetEndIndex()
        {
            return endIndex;
        }
    }
}
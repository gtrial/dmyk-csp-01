using System.Collections;
using System.Linq;

namespace task2
{
    public class UserCollection : IEnumerable, IEnumerator
    {
        private readonly Element[] _elements = new Element[12];
        private int _position = -1;

        public Element this[int index]
        {
            get => _elements[index];
            set => _elements[index] = value;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (_position >= _elements.Length - 1) return false;
            _position++;
            return true;
        }

        public void Reset()
        {
            _position = -1;
        }

        public object? Current => _elements[_position];
    }
}
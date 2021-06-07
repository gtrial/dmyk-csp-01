namespace task3
{
    public class UserCollection
    {
        private Citizen[] _elements;
        private int _count;

        public UserCollection()
        {
            _elements = new Citizen[] { };
            _count = 0;
        }

        public Citizen this[int index]
        {
            get => _elements[index];
            set => _elements[index] = value;
        }

        public int Add(Citizen value)
        {
            if (value.GetType() == typeof(Pensioner))
            {
                _elements.CopyTo(_elements, 1);
                _elements[0] = value;
                return 0;
            }
            else
            {
                if (_count >= _elements.Length) return -1;
                _elements[_count] = value;
                _count++;

                return (_count - 1);
            }
        }

        public void Clear()
        {
            _elements = new Citizen[] { };
            _count = 0;
        }

        public bool Contains(object value)
        {
            for (var i = 0; i < _count; i++)
            {
                if (_elements[i] == value)
                    return true;
            }

            return false;
        }

        public int IndexOf(object value)
        {
            for (var i = 0; i < _count; i++)
                if (_elements[i] == value)
                    return i;
            return -1;
        }

        public void Insert(int index, Citizen value)
        {
            if ((_count + 1 <= _elements.Length) && (index < _count) && (index >= 0))
            {
                _count++;

                for (var i = _count - 1; i > index; i--)
                {
                    _elements[i] = _elements[i - 1];
                }

                _elements[index] = value;
            }
        }

        public void Remove(Citizen value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < _count))
            {
                for (var i = index; i < _count - 1; i++)
                    _elements[i] = _elements[i + 1];

                _count--;
            }
        }
    }
}
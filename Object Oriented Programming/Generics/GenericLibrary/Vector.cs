using System;

namespace GenericLibrary
{
    public class Vector <T>
    {
        public int Capacity { get; private set; } = 2;
        private int size = 0;
        private T[] _array = new T[2];

        public void Add(T item)
        {
            if (size == Capacity)
            {
                Resize();
            }
            _array[size] = item;
            ++size;
        }

        public T At(int index)
        {
            return _array[index];
        }

        private void Resize()
        {
            Capacity *= 2;
            T[] newArray = new T[Capacity];
            for (int i = 0; i < _array.Length; ++i)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}

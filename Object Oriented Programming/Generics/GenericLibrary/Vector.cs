using System;

namespace GenericLibrary
{
    public class Vector <T>
    {
        private int maxSize = 2;
        private int size = 0;
        private T[] _array = new T[2];

        public void Add(T item)
        {
            if (size == maxSize)
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

        public int Capacity()
        {
            return maxSize;
        }

        private void Resize()
        {
            maxSize *= 2;
            T[] newArray = new T[maxSize];
            for (int i = 0; i < _array.Length; ++i)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }
    }
}

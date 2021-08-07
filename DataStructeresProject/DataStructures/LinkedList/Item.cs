using System;

namespace DataStructures.LinkedList
{
    public class Item<T>
    {
        private T _data = default(T);

        public T Data
        {
            get => _data;
            set => _data = value ?? throw new ArgumentNullException(nameof(value));
        }

        public Item<T> Next { get; set; } = null;

        public Item(T data)
        {
            _data = data;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}

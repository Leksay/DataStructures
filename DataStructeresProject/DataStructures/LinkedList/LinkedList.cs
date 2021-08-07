using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.LinkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public Item<T> Head { get; private set; }

        public Item<T> Tail { get; private set; }

        public int Count { get; private set; }

        public LinkedList()
        {
            Clear();
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)
        {
            if(Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = Tail.Next;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public Item<T> GetItem(T insertAfterValue)
        {
            var current = Head;

            while (current != null)
            {
                if (current.Data.Equals(insertAfterValue))
                {
                    return current;
                }
                current = current.Next;
            }

            return default;
        }

        public void Remove(T data)
        {
            if(Head != null)
            {
                if(Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head;

                while(current.Next != null)
                {
                    if(current.Next.Data.Equals(data))
                    {
                        current.Next = current.Next.Next;
                        Count--;
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        public void AppendHead(T data)
        {
            var item = new Item<T>(data)
            {
                Next = Head
            };

            Head = item;
            Count++;
        }

        public void Insert(T data, Item<T> previousItem)
        {
            var item = new Item<T>(data)
            {
                Next = previousItem.Next
            };

            previousItem.Next = item;
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
             
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        private void SetHeadAndTail(T data)
        {
            Head = Tail = new Item<T>(data);
            Count = 1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return GetEnumerator();
        }

        public override string ToString()
        {
            var elements = new StringBuilder();

            elements.Append($"Count: {Count} ");
            elements.Append("{ ");

            foreach(var items in this)
            {
                elements.Append(items + " ");
            }
            elements.Append("}");

            return elements.ToString();
        }
    }
}

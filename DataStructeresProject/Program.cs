using System;
using DataStructures.LinkedList;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test linked list \n");
            LinkedList();
        }

        private static void LinkedList()
        {
            var llist = new LinkedList<int>();
            llist.Add(1);
            llist.Add(2);
            llist.Add(3);
            llist.Add(4);
            llist.Add(5);

            Console.WriteLine("Remove");
            Console.WriteLine(llist);

            llist.Remove(3);
            Console.WriteLine(llist);

            int addToHeadValue = 123;
            Console.WriteLine($"Append To Head: [{addToHeadValue}]");

            llist.AppendHead(addToHeadValue);
            Console.WriteLine(llist);

            int insertAfterValue = 4;
            var insertAfterItem = llist.GetItem(insertAfterValue);

            if (insertAfterItem != default)
            {
                int insertValue = 512;
                Console.WriteLine($"Insert after [{insertAfterValue}] value: [{insertValue}]");

                llist.Insert(insertValue, insertAfterItem);
                Console.WriteLine(llist);
            }
        }
    }
}

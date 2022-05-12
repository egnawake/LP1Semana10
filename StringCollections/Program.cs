using System;
using System.Collections.Generic;

namespace StringCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("dog");
            list.Add("parrot");
            list.Add("pig");
            list.Add("dog");
            list.Add("bat");

            PrintCollection(list, "List");


            Stack<string> stack = new Stack<string>();
            stack.Push("dog");
            stack.Push("parrot");
            stack.Push("pig");
            stack.Push("dog");
            stack.Push("bat");

            PrintCollection(stack, "Stack");


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("dog");
            queue.Enqueue("parrot");
            queue.Enqueue("pig");
            queue.Enqueue("dog");
            queue.Enqueue("bat");

            PrintCollection(queue, "Queue");


            HashSet<string> set = new HashSet<string>();
            set.Add("dog");
            set.Add("parrot");
            set.Add("pig");
            set.Add("dog");
            set.Add("bat");

            PrintCollection(set, "HashSet");
        }

        private static void PrintCollection(IEnumerable<string> coll, string title)
        {
            Console.WriteLine(title);
            foreach (string s in coll)
            {
                Console.WriteLine($"- {s}");
            }
            Console.WriteLine("");
        }
    }
}

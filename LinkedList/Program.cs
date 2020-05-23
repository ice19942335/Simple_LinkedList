using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            //Adding elements
            Console.WriteLine("Adding elements in to the list...\n");
            linkedList.Add("Element_1");
            linkedList.Add("Element_2");
            linkedList.Add("Element_3");

            //Displaying all items in list
            Console.WriteLine("Displaying all items in list");
            foreach (var item in linkedList)
                Console.WriteLine(item);

            //Removing element
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nRemoving element 'Element_1'\n");
            Console.ForegroundColor = ConsoleColor.White;
            linkedList.Remove("Element_1");

            //Displaying all items in list
            Console.WriteLine("Displaying all items in list");
            foreach (var item in linkedList)
                Console.WriteLine(item);

            //Checking element existence in list
            Console.WriteLine("\nChecking 'Element_1' element existence in list");
            bool isPresent = linkedList.Contains("Element_1");
            Console.WriteLine(isPresent == true ? "'Element_1' is in list." : "Element_1 not in list.");
        }
    }
}

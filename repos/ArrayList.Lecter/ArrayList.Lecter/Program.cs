﻿namespace ArrayList.Lecter
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ArrayList myList = new ArrayList();
            string input = "";
            do
            {
                Console.WriteLine("tell me something");
                input = Console.ReadLine();
                myList.Add(input);
            }
            while (input != "exit");

            for(int i = 0; i > myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine("end!");
        }
    }
}
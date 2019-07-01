using System;
using System.Collections.Generic;

namespace firstProject
{
    class Program
    {
        public static void SayGreeting(string name)
        {
            System.Console.WriteLine($"Good morning, {name}!");
        }

        static void Main(string[] args )
        {
            // Console.WriteLine("Hello Universe!");

            string name = "Nina";
            int num = 5;
            float num2 = 1.2f;
            double num3 = 1.2;
            bool state = false;

            long bigNum = 5;
            short smallNum = 5;

            string result = num + name;

            int[] integerArray = {11,22,33,44,55};
            string[] anotherArray = new string[5];
            // System.Console.WriteLine(integerArray);

            // for (int i = 0; i < integerArray.Length; i++)
            // {
            //     System.Console.WriteLine(integerArray[i]);
            // }

            SayGreeting("Aaron");


            // System.Console.WriteLine(anotherArray);
            Console.WriteLine("[{0}]", string.Join(", ", integerArray));
            Console.WriteLine("[{0}]", string.Join(", ", anotherArray));


            List<int> newList = new List<int>();
            newList.Add(73);
            // System.Console.WriteLine(newList);

            foreach (var val in newList)
            {
                System.Console.WriteLine(val);
            }

            Dictionary<string, string> newDict = new Dictionary<string, string>();
            newDict.Add("name", "Abby");
            newDict.Add("email", "abby@gmail.com");

            Console.WriteLine("[{0}]", string.Join(", ", newDict));

            // foreach(KeyValuePair<string,string> pair in newDict)
            // {
            //     System.Console.WriteLine($" {pair.Key} : {pair.Value}");
            // }

        }
    }
}

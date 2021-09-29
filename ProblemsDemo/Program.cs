using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ProblemsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = RemoveDuplicate("abbca");
            Console.WriteLine(str);
            Console.ReadKey();
        }

        public static string RemoveDuplicate(string str)
        {
            var dict = new Dictionary<char, bool>();
            for (int i = 0; i < str.Length; i++)
            {
                if (dict.TryGetValue(str[i],out bool a))
                {
                    dict[str[i]] = false;
                }
                else
                {
                    dict[str[i]] = true;
                }
            }

            return new string (dict.Where(x=>x.Value).Select(x=>x.Key).ToArray());
        }
        public static void NEW()
        {

        }

        public static void New2()
        {    }

 
}

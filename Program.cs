using System;
using System.Collections.Generic;
using System.Linq;

namespace Finagotech_Interview2
{
    class Program
    {
        public static int uniqueWolfs(List<int> arr) {
            int res = arr.GroupBy(x => x).OrderByDescending(g => g.Count()).Select(g => g.Key).First();

            return res;
        }
        static void Main(string[] args)
        {
            string[] numArr ={"1","2","3","4","5","6","7","8","9","0"};
            string arrLength = Console.ReadLine();
            string arr = Console.ReadLine();
            string[] myCharArr = arr.Split(' ');
            List<int> myArr = new List<int>();
            foreach (var id in myCharArr)
            { 
                if(Array.Exists(numArr, num => num == id))
                    myArr.Add(int.Parse(id));
                else{
                    Console.WriteLine("Please enter numbers only");
                }
            }
            int res = uniqueWolfs(myArr);
            Console.WriteLine(res);
        }
    }
}

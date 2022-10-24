using System;
using System.Collections.Generic;
using System.Linq;

namespace Finagotech_Interview2
{
    class Program
    {
        public static int uniqueWolfs(List<int> arr) {
            int res = arr.GroupBy(x => x) //Ids are grouped among themselves
                    .OrderBy(g => g.Key) //Sorts groups based on the values of the id
                    .OrderByDescending(g => g.Count()) //Sorts ids from most common to least
                    .Select(g => g.Key).First(); //Selects the value of the most common id

            return res;
        }
        static void Main(string[] args)
        {
            string[] numArr ={"1","2","3","4","5","6","7","8","9","0"}; //Definition of numbers
            string arrLength = Console.ReadLine(); //Input of the array length
            string arr = Console.ReadLine(); //Array's input
            string[] myCharArr = arr.Split(' '); // Splitting array by spaces
            List<int> myArr = new List<int>();
            foreach (var id in myCharArr) //Transferring array elements to myArr list according to whether they are digits or not
            { 
                if(Array.Exists(numArr, num => num == id))
                    myArr.Add(int.Parse(id)); //If the id is a number, it is converted to an int and transferred to the list
                else{
                    Console.WriteLine("Please enter numbers only"); //If not, an error message is given
                }
            }
            int res = uniqueWolfs(myArr); //The corresponding function is called
            Console.WriteLine(res);
        }
    }
}

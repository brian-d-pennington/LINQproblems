using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQproblems
{
    class Problems
    {
        List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };

        List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Zack", "Mike" };


        //first problem
        public IEnumerable<string> ReturnsTH()
        {
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (string word in words)
            {
                Console.Write(word + " ");

            }
            Console.WriteLine(" ");
            return words;
            
        }
        //second
        public IEnumerable<string> WithoutDuplicates()
        {
            var listWithoutDuplicates = names.Distinct();
            foreach (string name in names)
            {
                Console.Write(name + " ");
            }
            return listWithoutDuplicates;
        }
        //third
       List<string> classGrades = new List<string>()
                {
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };

        public void GetClassAverage()
        {
            var classAverage = classGrades.SelectMany(n => n.Split(',')).ToArray().Select(int.Parse).ToList().OrderByDescending(x => x).ToList().Take(16).Average();
            Console.WriteLine("\r\n" + classAverage);
        }


        // fourth

        string stringToPass = "pennington";
        public void AlphabetizeAndCount()
        {
            var stringArray = stringToPass.ToUpper().ToArray();
            Array.Sort(stringArray);
            string arrayToString = new string(stringArray);
           
            var charFrequencies = from c in arrayToString.ToArray()
                                  group c by c into groupFrequencies
                                  select groupFrequencies;
            foreach (var c in charFrequencies)
                Console.Write($"{c.Key}{c.Count()}");

            Console.ReadLine();

        }
    }

}

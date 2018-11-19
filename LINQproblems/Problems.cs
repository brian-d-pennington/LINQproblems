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

        List<string> classGrades = new List<string>()
{
                "80,100,92,89,65",
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
                };

        public IEnumerable<string> ReturnsTH()
        {
            var wordsWithTH = words.Where(w => w.Contains("th"));
            foreach (string word in words)
            {
                Console.WriteLine(word);
                
            }
            return words;
        }   

        public IEnumerable<string> WithoutDuplicates()
        {
            var listWithoutDuplicates = names.Distinct();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            return listWithoutDuplicates;
        }

        public void GetClassAverage()
        {
            var 
        }
    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1._12.Classes
{
    internal class Words : IEnumerable<string>
    {
        private static IEnumerable<string> WordsPlus5(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ToCharArray().Length > 5)
                {
                    yield return list[i];
                }
            }
        }

        public void GetWordsList(List<string> list)
        {
            foreach (string word in WordsPlus5(list))
            {
                Console.WriteLine(word);
            }
        }

        public List<string> GetList(string words)
        {
            string[] splittedlist = words.Split(" ");
            return splittedlist.ToList();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }
}

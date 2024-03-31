using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombHomework1
{
    internal class CombinationGenerator
    {
       
        public int K
        {
            get;
            set;
        }
        
        List<string> elements = new List<string>();
       
        public void AddElemets(string element)
        {
            elements.Add(element);
        }

        public void Combinations(TextBox textBox)
        {
         
            List<List<string>> combinations = GenerateCombinations(elements, K);

            
            
            foreach (var combination in combinations)
            {

                textBox.AppendText(string.Join(", ",combination));
                textBox.AppendText(Environment.NewLine);
            }

        }
        static List<List<string>> GenerateCombinations(List<string> set, int k)
        { 
            
            List<List<string>> result = new List<List<string>>();
            
            List<string> currentCombination = new List<string>();

           
            GenerateCombinationsHelper(set, k, 0, currentCombination, result);

            return result;
        }

        static void GenerateCombinationsHelper(List<string> set, int k, int startIndex, List<string> currentCombination, List<List<string>> result)
        {
          
            if (k == 0)
            {
                
                result.Add(new List<string>(currentCombination));
                return;
            }
            for (int i = startIndex; i < set.Count; i++)
            {   
                
                currentCombination.Add(set[i]);
                GenerateCombinationsHelper(set, k - 1, i + 1, currentCombination, result);
                currentCombination.RemoveAt(currentCombination.Count - 1);
            }
        }
    }
   }

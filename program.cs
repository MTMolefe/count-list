using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace listOfAnyDataType
{
    internal class Program
    {
        static void Main(string[] args)
        {
        

            object[] Items = { 1, "Tlotlo", 6.3, true, "Tlotlo", 1, true, 6.3, false, "Tlotlo", 11.11 , false };

                Dictionary<object, int> itemNum = new Dictionary<object, int>();

                foreach (var item in Items)
                {
                    if (itemNum.ContainsKey(item))
                    {
                        itemNum[item]++;
                    }
                    else
                    {
                        itemNum[item] = 1;
                    }
                }

                
                foreach (var kvp in itemNum)
                {
                    Console.WriteLine($"{kvp.Key} appears {kvp.Value} times");
                }
            }
        }



    }

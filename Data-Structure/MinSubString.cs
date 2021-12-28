using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.LeetCodeProblems
{
    public class MinSubstring
    {
        //str - geeksforgeeks //target ork
        public string MinLenghtSr(string str, string target)
        {
            string result = "";
            Dictionary<char, int> targetMap = new Dictionary<char, int>();
            for(int i =0; i< target.Length; i++)
            {
                if (targetMap.ContainsKey(target[i]))
                {
                    targetMap[target[i]]++;
                }
                else
                {
                    targetMap.Add(target[i], 1);
                }

            }
            int count = 0;
            int start = 0;
            int minLenght = int.MaxValue;
            int min_left = 0;
            for(int j =0; j< str.Length; j++)
            {
                if (targetMap.ContainsKey(str[j]))
                {
                    targetMap[str[j]]--;
                    if (targetMap[str[j]] >= 0)
                    {
                        count++;
                    }
                }
                while(count == target.Length) //eligible window
                {
                    if (minLenght > j - (start + 1))
                    {
                        minLenght = j - (start + 1);
                        min_left = start;
                    }
                    if (targetMap.ContainsKey(str[start]))
                    {
                        targetMap[str[start]]++;

                        if (targetMap[str[start]]>0)
                        {
                            count--;
                        }

                    }
                    start++;
                }
            }


            return str.Substring(min_left, min_left+minLenght);
        }


        static void Main(string[] args)
        {
            MinSubstring p = new MinSubstring();
            string str = "ADOBECODEBANC";
            string target = "ABC";
            string s = p.MinLenghtSr(str,target);
            Console.Write(s);
        }
    }
}

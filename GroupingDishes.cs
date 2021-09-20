using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class GroupingDishes
    {
        static string[][] groupingDishes(string[][] dishes)
        {
            SortedDictionary<string, int> dishDict = new SortedDictionary<string, int>();
            HashSet<string> temp = new HashSet<string>();
            foreach(var item in dishes)
            {
                for(int i=1; i<item.Length; i++)
                {

                    if (!dishDict.ContainsKey(item[i]))
                    {
                        dishDict.Add(item[i], 1);
                    }
                    else
                    {
                        dishDict[item[i]]++;
                    }
                }
            }
            var newDish = dishDict.Where(s => s.Value > 1).ToDictionary(s=>s.Key, s=>s.Value);
            List<string> keyList = new List<string>(newDish.Keys);

            List<List<string>> returnList = new List<List<string>>();
            for(int i=0; i<keyList.Count; i++)
            {
                List<string> tempStore = new List<string>();
                foreach(var item in dishes)
                {
                    if (item.Contains(keyList[i]))
                    {
                        tempStore.Add(item[0]);
                    }
                }
                tempStore.Sort();
                returnList.Add(tempStore);
            }
            string[][] returnList2 = new string[keyList.Count][];

            for(int i =0; i<keyList.Count; i++)
            {
                returnList2[i] = new string[returnList[i].Count + 1];
                returnList2[i][0] = keyList[i];
                for(int j=0; j<returnList[i].Count; j++)
                {
                    returnList2[i][j + 1] = returnList[i][j];
                }
            }
            return returnList2;
        }

        static void Main(string[] args)
        {
            string[][] dishes = new string[4][];
            dishes[0] = new string[] { "Salad", "Tomato", "Cucumber", "Salad", "Sauce" };
            dishes[1] = new string[] { "Pizza", "Tomato", "Sausage", "Sauce", "Dough" };
            dishes[2] = new string[] { "Quesadilla", "Chicken", "Cheese", "Sauce" };
            dishes[3] = new string[] { "Sandwich", "Salad", "Bread", "Tomato", "Cheese" };

            groupingDishes(dishes);
        }
    }
}

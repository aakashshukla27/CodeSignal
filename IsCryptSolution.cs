using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class IsCryptSolution
    {
        static bool isCryptSolution(string[] crypt, char[][] solution)
        {

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var item in solution)
            {
                dict.Add(item[0], Convert.ToInt32(item[1]) - 48);
            }

            List<double> numList = new List<double>();

            for (int i = 0; i < 3; i++)
            {
                StringBuilder sb = new StringBuilder();
                foreach (char ch in crypt[i])
                {
                    if (dict.ContainsKey(ch))
                    {
                        sb.Append(dict[ch]);
                    }
                }
                string tempString = sb.ToString();
                char[] tempCharArray = tempString.ToCharArray();

                if (checkLeadingZeroes(tempCharArray)) return false;


                numList.Add(Convert.ToDouble(tempString));
            }

            if (numList[0] + numList[1] == numList[2])
            {
                return true;
            }
            return false;

        }

        static bool checkLeadingZeroes(char[] ch)
        {
            if (ch.Length == 1)
            {
                return false;
            }

            if (ch[0] != '0')
            {
                return false;
            }
            for (int i = 0; i < ch.Length - 1; i++)
            {
                if (ch[i] != ch[i + 1])
                {
                    return true;
                }
            }
            return false;
        }


        static void Main(string[] args)
        {
            //char[][] solution = new char[8][];
            //solution[0] = new char[] { 'O', '0' };
            //solution[1] = new char[] { 'M', '1' };
            //solution[2] = new char[] { 'Y', '2' };
            //solution[3] = new char[] { 'E', '5' };
            //solution[4] = new char[] { 'N', '6' };
            //solution[5] = new char[] { 'D', '7' };
            //solution[6] = new char[] { 'R', '8' };
            //solution[7] = new char[] { 'S', '9' };


            char[][] solution = new char[3][];
            solution[0] = new char[] { 'A', '1' };
            solution[1] = new char[] { 'B', '2' };
            solution[2] = new char[] { 'C', '3' };
            //solution[3] = new char[] { 'E', '5' };
            //solution[4] = new char[] { 'N', '4' };



            string[] crypt = { "AAAAAAAAAAAAAA",
                               "BBBBBBBBBBBBBB",
                               "CCCCCCCCCCCCCC" };

            isCryptSolution(crypt, solution);
        }
    }
}

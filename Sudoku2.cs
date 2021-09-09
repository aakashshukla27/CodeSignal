using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal
{
    class Sudoku2
    {
        bool sudoku2(char[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] != '.')
                    {
                        char tmp = grid[i][j];
                        for (int k = j + 1; k < grid[0].Length; k++)
                        {
                            if (tmp == grid[i][k])
                            {
                                return false;
                            }
                        }
                        for (int l = i + 1; l < grid.Length; l++)
                        {
                            if (tmp == grid[l][j])
                            {
                                return false;
                            }
                        }
                        int x = 0;
                        int y = 0;
                        if (i < 3)
                        {
                            x = 0;
                        }
                        if (j < 3)
                        {
                            y = 0;
                        }
                        if (i > 3 && i < 6)
                        {
                            x = 3;
                        }
                        if (j > 3 && j < 6)
                        {
                            y = 3;
                        }
                        if (i > 6)
                        {
                            x = 6;
                        }
                        if (j > 6)
                        {
                            y = 6;
                        }
                        int tmp2 = 0;
                        for (int p = x; p < x + 3; p++)
                        {
                            for (int g = y; g < y + 3; g++)
                            {
                                if (grid[p][g] == tmp)
                                {
                                    tmp2++;
                                }
                            }
                        }
                        if (tmp2 >= 2)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}

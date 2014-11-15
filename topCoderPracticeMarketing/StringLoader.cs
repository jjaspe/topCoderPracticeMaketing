using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topCoderPracticeMarketing
{
    public class StringLoader
    {
        public bool[,] loadDataAsBooleans(String[] data)
        {

            bool[,] grid = getGrid(data.Length);

            String[] current;

            //Read off data and put true in the conflicts 
            for(int i=0;i<data.Length;i++)
            {
                current = data[i].Split(' ');
                for (int j = 0; j < current.Length; j++)
                {
                    grid[i, Int32.Parse(current[j])] = true;
                }
            }
            return grid;
        }

        /// <summary>
        /// Creates a 2-dim array of booleans of size lengthXlength filled with false
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public bool[,] getGrid(int length)
        {
            bool[,] grid = new bool[length, length];

            //Fill with false;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                    grid[i, j] = false;
            }
            return grid;
        }

    }
}

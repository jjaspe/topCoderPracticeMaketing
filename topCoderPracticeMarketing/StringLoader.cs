using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace topCoderPracticeMarketing
{
    public class Solver
    {
        public bool[,] loadDataAsBooleans(String[] data)
        {

            bool[,] grid = getGrid(data.Length);

            String[] current;

            //Read off data and put true in the conflicts 
            for(int i=0;i<data.Length;i++)
            {
                current = getSplitArray(data[i]);
                for (int j = 0; j < current.Length; j++)
                {
                    if (!String.IsNullOrEmpty(current[j]))
                    {
                        grid[i, Int32.Parse(current[j])] = true;
                        grid[Int32.Parse(current[j]), i] = true;//symmetry
                    }
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

        /// <summary>
        /// Splits data across spaces
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public String[] getSplitArray(String data)
        {
            return data.Split(' ');
        }


        /// <summary>
        /// Creates an array of length:length filled with trues
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public bool[] getProductArray(int length)
        {
            bool[] array = new bool[length];
            for (int i = 0; i < length; i++)
                array[i] = true;
            return array;
        }

        /// <summary>
        /// Returns how many strings are empty in data, i.e., number of strings without conflicts
        /// Done by counting how many rows dont have any trues
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int countNonConflicts(bool[,] data)
        {
            int count = 0, length = (int)Math.Sqrt(data.Length);
            bool conflict = false;
            for (int i = 0; i < length; i++)
            {
                conflict = false;
                //Go through row, if something is true, there is conflict so dont count
                for (int j = 0; j < length; j++)
                {
                    if (data[i, j])
                    {
                        conflict = true;
                        break;
                    }
                }

                if (!conflict)
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Determines whether the incoming data can be broken into 
        /// two subsets of non-conflicting elements. 
        /// </summary>
        /// <param name="data"></param>
        /// <returns>-1 if it is not possible, or the number of ways in which it is possible</returns>
        public double solve(String[] data)
        {
            if (data.Length == 0)
                return -1;

            bool[,] grid = loadDataAsBooleans(data);
            bool[] v1=getProductArray(data.Length),v2=getProductArray(data.Length);
            int truthCounter1 = data.Length, truthCounter2 = 0,nonConflicts=countNonConflicts(grid);


            //Lets go through all the rows of v1, 
            for (int i = 0; i < data.Length; i++)
            {                
                if (v1[i])
                {
                    v2[i] = false;//Set as opposite (i.e., all elements in v1 are not in v2)

                    //Search through all the elements of grid[i,*] and set v1[j] to false if grid[i,j]=true
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (grid[i, j])
                        {
                            if (v1[j])//Only set to false and decrement if it was true so we dont recount a false twice
                            {
                                v1[j] = false;
                                truthCounter1--;
                            }
                        }
                    }
                }
            }

            //Now that we are done with v1, recalculate truthCounter2
            truthCounter2=data.Length-truthCounter1;

            //follow same procedure with v2 to remove conflicts
            for (int i = 0; i < data.Length; i++)
            {
                if (v2[i])
                {
                    //Search through all the elements of grid[i,*] and set v1[j] to false if grid[i,j]=true
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (grid[i, j])
                        {
                            if (v2[j])
                            {
                                v2[j] = false;
                                truthCounter2--;
                            }
                        }
                    }
                }
            }

            //Is it possible
            if (truthCounter1 + truthCounter2 == data.Length)
            {
                //The expression multiplying with the one takes care of the case where all the elements are 
                //non-conflicts
                return Math.Pow(2, nonConflicts + 1*(data.Length>nonConflicts?1:0) );
            }

            return -1;

        }

    }
}

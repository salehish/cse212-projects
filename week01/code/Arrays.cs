using System;
using System.Collections.Generic;
public static class Arrays
{

    /*
       * The plan for MultiplesOf:
       * 1. Creating  array of size "length"
       * 2. Loop from 0 to length - 1
       *3. For each position i, compute the multiple:
       * number * (i + 1)
       * 4. Store it in the array
       * 5. Return the completed array
    */

    public static double[] MultiplesOf(double number, int length)
    {
        double[] result = new double[length];

        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }

        return result;
    }
    /*
         * The plan for RotateListRight:
         * 1. Determining split point: data.Count - amount
         * 2. Take the last "amount" elements (right side of list)
         * 3. Removing those elements from the original list
         * 4. Insert them at the beginning of the list
         * 5. This shifts everything to the right
    */

    public static void RotateListRight(List<int> data, int amount)
    {
        int splitIndex = data.Count - amount;

        List<int> endSection = data.GetRange(splitIndex, amount);

        data.RemoveRange(splitIndex, amount);

        data.InsertRange(0, endSection);
    }
}
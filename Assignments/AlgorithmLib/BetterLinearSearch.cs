/* CSE 381 - BetterLinearSerach
*  (c) BYU-Idaho - It is an honor code violation to post this
*  file completed in a public file sharing site.  F6.
*
*  Instructions: Refer to W01 Prove: Assignment in Canvas for detailed instructions.
*/

using Microsoft.VisualBasic;

namespace AlgorithmLib;
public static class BetterLinearSearch
{
    public static int Search<T>(List<T> data, T target) where T : IComparable<T>
    {
        if (data.Count == 0) // check if the list is empty 
        {
            return -1;
        }        

        if (data.Count == 1) // check  to see if the list is exactly one item 
    
        {
            if (data[0].CompareTo(target) == 0) // check to see if the solo item is the target 
            {
                return 0;
            } else
            {
                return -1; 
            }
        }

        var last = data[^1]; // save the last value of the data in the variable last 

        data[^1] = target; // set the value of the last index of the list to the target 

        int i = 0; // set index start 

        while (data[i].CompareTo(target) != 0) // iterate through list 
        {
            i++; // increment
        }

        data[^1] = last; //restores final index to og value 

        if(i < (data.Count-1)) // check to see if target was found before the final index 
        {
            return i;
        } 
        else if(last.CompareTo(target) == 0)
        {
            return data.Count-1;
        } 
        else 
        {
            return -1;
        }

    }
}

// turn in screenshot of code and of passing tests 
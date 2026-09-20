/* CSE 381 - BetterLinearSerach
*  (c) BYU-Idaho - It is an honor code violation to post this
*  file completed in a public file sharing site.  F6.
*
*  Instructions: Refer to W01 Prove: Assignment in Canvas for detailed instructions.
*/

using Microsoft.VisualBasic;

namespace AlgorithmLib;
List<int> dataSet = new();
public static class BetterLinearSearch
{

// add checks for empty list and 1 item lists
    if(dataSet.Count == 0) 
    {
        return -1;
    }

// loop to find value 
    /* Search for an item in a list.  Ignore duplicates by exiting
    *  as soon as the first match is found.
    *
    *  Inputs:
    *     data - list to search
    *     target - value to search for
    *  Outputs:
    *     Index where target was found
    *
    *  Note: Return -1 if target not found
    */
    public static int Search<T>(List<T> data, T target) where T : IComparable<T>
    {
        return 0;
    }
}

// turn in screenshot of code and of passing tests 
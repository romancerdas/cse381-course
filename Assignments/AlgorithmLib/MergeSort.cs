/* CSE 381 - Merge Sort
*  (c) BYU-Idaho - It is an honor code violation to post this
*  file completed in a public file sharing site.  F6.
*
*  Instructions: Refer to W03 Prove: Assignment in Canvas for detailed instructions.
*/

namespace AlgorithmLib;

public static class MergeSort
{
    /* Use Merge Sort to sort a list of values in place
     *
     *  Inputs:
     *     data - list of values
     *  Outputs:
     *     none
     */
    public static void Sort<T>(List<T> data) where T : IComparable<T> 
    {
        // Start the recursive process with the whole list
        _Sort(data, 0, data.Count-1);
    }

    /* Recursively use merge sort to sort a sublist
     * defined by first and last.
     * 
     *  Inputs:
     *     data - list of values
     *     first - the starting index of the sublist
     *     last - the ending index of the sublist
     *  Outputs:
     *     None
     */
    public static void _Sort<T>(List<T> data, int first, int last) where T : IComparable<T>
    {
        if (first >= last)
        {
            return;
        }

        int mid = (first + last)/ 2;

        _Sort(data, first, mid); // sort first half 
        _Sort(data, mid + 1, last); // sort second half 

        Merge(data, first, mid, last);
    }
    
    /* Merge two sorted list which are adjacent to each other back into
     * the same list.
     *
     *  Inputs:
     *     data - list of values
     *     first - the starting index of the first sorted sublist
     *     mid - the ending index of the first sorted sublist (second sublist starts after)
     *     last - the ending index of the second sorted sublist
     *  Outputs:
     *     None
     */
    public static void Merge<T>(List<T> data, int first, int mid, int last) where T : IComparable<T>
    {
        int sa1 = first; // create pointer for sorted array 1 for comparisons
        int sa2 = mid + 1; // create pointer for sorted array 2 for comparisons  

        List<T> merged = new List<T>();

        while (sa1 <= mid && sa2 <= last) // starts comparison loop 
        {
            if (data[sa1].CompareTo(data[sa2]) <= 0) // checks if value at pointer sa1 is less than or equal to that of sa2 
            {
                merged.Add(data[sa1]); // add value to merged array 
                sa1++; // increment sa1 pointer for next comparison 
            }
            else
            {
                merged.Add(data[sa2]);
                sa2++;
            }
        }
        while (sa1 <= mid) // loop to append left over elements if right half is exhausted 
        {
            merged.Add(data[sa1]);
            sa1++;
        }

        while (sa2 <= last)
        {
            merged.Add(data[sa2]);
            sa2++;
        }
        
        for (int i=0; i < merged.Count; i++)
        {
            data[first + i] = merged[i];
        }
    }
}


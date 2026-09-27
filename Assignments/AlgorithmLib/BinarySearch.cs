/* CSE 381 - Binary Search
*  (c) BYU-Idaho - It is an honor code violation to post this
*  file completed in a public file sharing site.  F6.
*
*  Instructions: Refer to W02 Prove: Assignment in Canvas for detailed instructions.
*/

namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search<T>(List<T> data, T target) where T : IComparable<T>
    {
        return _Search(data, target, 0, data.Count - 1); 
    }

    public static int _Search<T>(List<T> data, T target, int first, int last) where T : IComparable<T>
{
    if (first > last)// base case
    {
        return -1;
    }


    int middle = first + (last - first) / 2;    // find middle index

    int comparison = target.CompareTo(data[middle]);


    if (comparison == 0)    // target found
    {
        return middle;
    }


    if (comparison < 0)    // target in the left half
    {
        return _Search(data, target, first, middle - 1);
    }


    return _Search(data, target, middle + 1, last);    // target in the right half
}

}
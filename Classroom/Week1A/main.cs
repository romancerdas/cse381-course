// CSE 381 REPL 1A
// C# Primer

using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

public static class Program 
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        /***************************************************
         * Variables
         ***************************************************/
        int a = 10;
        double b = 12.234;
        float dd = 3.34f; // includes f at the end 
        string c = "Bob";
        bool d = true;
        char e = 'v'; //var uses single quotes only 

        var name = "Roman";

        // Console.WriteLine($"a = {a} b = {b} c = {c} d = {d} e = {e}");
        // Console.WriteLine("===========================");



        /***************************************************
         * Division
         ***************************************************/
        var aa = 34;
        var bb = 3;
        var cc = 3.0;

        var f = aa / bb;
        var g = aa / cc;



        Console.WriteLine($"f = {f} g = {g}");
        Console.WriteLine("===========================");



        /***************************************************
         * Loops
         ***************************************************/
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i);
        }

        // for (int i=0;i<10;i++)
        // {
        //     Console.WriteLine(___);
        // }

        // Console.WriteLine("===========================");


        // Console.WriteLine("===========================");



        /***************************************************
         * List Creation
         ***************************************************/
        List<int> list1 = new List<int>();
        // List<int> list3 = new();
        // var list2 = new List<int>();

        list1.Add(10);
        list1.Add(20);
        list1.Add(30);

        foreach (var i in list1)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("===========================");

        Console.WriteLine(string.Join(", ", list1));

        var list2 = Enumerable.Range(5, 10).ToList();

        Console.WriteLine(string.Join("\n", list2));

        var list3 = Enumerable.Repeat(10, 5).ToList();
        Console.WriteLine(string.Join(", ", list3));





        /***************************************************
         * Accessing by Index
         ***************************************************/
        Console.WriteLine(list1[0]);
        Console.WriteLine(list2[0]);
        Console.WriteLine(list3[^1]);



        // Console.WriteLine($"First: {list2[]}");
        // Console.WriteLine($"Last: {list2[]}");
        // Console.WriteLine("===========================");



        /***************************************************
         * Slices
         ***************************************************/
        var list5 = Enumerable.Range(1, 11).ToList();

        Console.WriteLine(string.Join("\n", list5));

        var list5a = list5[..6];
        Console.WriteLine(string.Join(", ", list5a));

        list5a = list5[2..];
        Console.WriteLine(string.Join(", ", list5a));

        list5a = list5[..]; // copy of the list 
        Console.WriteLine(string.Join(", ", list5a));


        // foreach (var i in list5) {
        //     Console.WriteLine(i);
        // }
        // Console.WriteLine("===========================");



        /***************************************************
         * Apply to each Element
         ***************************************************/
        Console.WriteLine("===========================");
        Console.WriteLine(string.Join(", ", list5a));

        var list6 = list5.Select(x => x * 2).ToList();
        Console.WriteLine(string.Join(", ", list6));



        // foreach (var i in list8) {
        //     Console.WriteLine(i);
        // }
        // Console.WriteLine("===========================");



        /***************************************************
         * Sorting
         ***************************************************/



        List<(int, int)> list12 = [(-5, 9), (-3, 100), (-3, -100), (4, 7), (3, 1), (-4, 8)];

        var list7 = list12.OrderBy(x => x.Item1).ToList();
        Console.WriteLine(string.Join(", ", list7));

        var list7b = list12.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();
        Console.WriteLine(string.Join(", ", list7b));

        // foreach (var i in list10) {
        //     Console.WriteLine(i);
        // }
        // Console.WriteLine("===========================");



        /***************************************************
         * Dictionary Creation
         ***************************************************/


        var accounts = new Dictionary<string, int>() {
            {"bob",332},
            {"tim",153},
            {"sue",400}
        };

        foreach ((var key, var value) in accounts)
        {
            Console.WriteLine($"{key} - {value}");
        }
        // Console.WriteLine(accounts[]);
        // Console.WriteLine("===========================");



        /***************************************************
         * Access and Modify
         ***************************************************/


        // Console.WriteLine(accounts["bob"]);
        // Console.WriteLine("===========================");



        /***************************************************
         * Contains Key
         ***************************************************/


        var accName = "george";
        if (accounts.ContainsKey(accName))  // return bool 
        {
            Console.WriteLine("Account Exists");
        }
        else
        {
            Console.WriteLine("Account does not Exist");
        }
        Console.WriteLine("===========================");



        /***************************************************
         * Loop Key/Value Pairs
         ***************************************************/



        // Console.WriteLine($"Key = {key} Value = {value}");

        // Console.WriteLine("===========================");



        /***************************************************
        * Functions with Generics
        ***************************************************/

        var max1 = Max(list2);
        var max2 = Max(["dog", "cat", "pig", "cow", "hamster", "bird"]);

        Console.WriteLine(max1);
        Console.WriteLine(max2);
        Console.WriteLine("===========================");


        /***************************************************
        * Nullable Types
        ***************************************************/

        Console.WriteLine(AddOne(5));
        Console.WriteLine(AddOne(null));

        } // <-- MAIN ENDS HERE


        public static T Max<T>(List<T> values) where T : IComparable
        {
            var answer = values[0];

            for (int i = 0; i < values.Count; i++)
            {
                if (values[i].CompareTo(answer) > 0)
                {
                    answer = values[i];
                }
            }

            return answer;
        }


        public static int? AddOne(int? value)
        {
            return value + 1;
        }

        } // <-- PROGRAM ENDS HERE
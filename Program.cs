/*******************************************************************
* Name: Steven McGraw
* Date: 2026-03-22
* Assignment: SDC220 Performance Assessment - Calculations & Unique Numbers
*
* Main application (program) class.
* In this application we will retrieve 10 integer values from the
* user, store them in an array, and store only unique values in a
* List. We will then calculate and display the count, sum, and
* average for both the array and the unique List.
*/
using System.Collections.Generic;

public class App
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("Steven McGraw - Week 3 PA Calculations & Unique Numbers");

        // Create an array to hold 10 integers
        int[] values = new int[10];

        // Create a List to hold unique integers
        List<int> uniqueValues = new List<int>();

        // Get 10 integer values from the user
        for (int i = 0; i < values.Length; i++)
        {
            Console.Write("\nPlease enter an integer value: ");
            string? val = Console.ReadLine();
            int input = Convert.ToInt32(val);
            values[i] = input;

            // Only add to the List if it's not already there
            if (!uniqueValues.Contains(input))
            {
                uniqueValues.Add(input);
            }
        }

        // Display stats for the full array
        int arraySum = SumCollection(values);
        Console.WriteLine("\nThe count of integers entered is: {0}", values.Length);
        Console.WriteLine("The sum of integers entered is: {0}", arraySum);
        Console.WriteLine("The average of integers entered is: {0}", arraySum / values.Length);

        // Display stats for the unique List
        int listSum = SumCollection(uniqueValues);
        Console.WriteLine("\nThe count of unique integers entered is: {0}", uniqueValues.Count);
        Console.WriteLine("The sum of unique integers entered is: {0}", listSum);
        Console.WriteLine("The average of unique integers entered is: {0}", listSum / uniqueValues.Count);
    }

    // Method to calculate the sum of integers in an array
    public static int SumCollection(int[] arr)
    {
        int total = 0;
        foreach (int val in arr)
        {
            total += val;
        }
        return total;
    }

    // Overloaded method to calculate the sum of integers in a List
    public static int SumCollection(List<int> list)
    {
        int total = 0;
        foreach (int val in list)
        {
            total += val;
        }
        return total;
    }
}

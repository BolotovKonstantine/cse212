public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        double[] result = new double[length];
        for (int i = 0; i < length; i++)
        {
            result[i] = number*(i+1);
        }
        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static List<int> RotateListRight(List<int> data, int amount)
    { 
        
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
      // Step 1: Calculate the effective rotation
              int n = data.Count;
              // No need for modulus operation here since amount is guanteed to be in the valid range
      
              // Step 2: Split the list
              List<int> firstPart = data.GetRange(n - amount, amount);
              List<int> secondPart = data.GetRange(0, n - amount);
      
              // Step 3: Combine the lists
              List<int> rotatedList = new List<int>(firstPart);
              rotatedList.AddRange(secondPart);
      
              // Step 4: Return the result
              return rotatedList;
    }

    public static void Run()
    {
        List<int> list1 = RotateListRight(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1);
        List<int> list2 = RotateListRight(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 5);
        List<int> list3 = RotateListRight(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3);
        Console.WriteLine("<List>{" + string.Join(", ", list1) + "}");
        Console.WriteLine("<List>{" + string.Join(", ", list2) + "}");
        Console.WriteLine("<List>{" + string.Join(", ", list3) + "}");
    }
}

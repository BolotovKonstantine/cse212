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
        
        //initialize result make sure to define lenght of array
        double[] result = new double[length];
        // Cycle number make sure that first index of array is 0 and first multiple is 1
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        // return result

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        int n = data.Count;

        // Calculate the effective rotation (handle cases where amount > data.Count)
        amount = amount % n;

        if (amount == 0)
            return;

        // Split the list
        List<int> firstPart = data.GetRange(n - amount, amount);
        List<int> secondPart = data.GetRange(0, n - amount);

        // Combine the lists
        List<int> rotatedList = new List<int>(firstPart);
        rotatedList.AddRange(secondPart);

        // Copy the rotated elements back to the original list
        for (int i = 0; i < n; i++)
        {
            data[i] = rotatedList[i];
        }
    }
}
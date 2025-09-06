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

        // STEPS
        // 1. Create a list to hold multiples.
        // 2. create a loop(i) and iterate from 1 to length.
        // 3. Compute number * i and save it to a local multiple variable.
        // 4. Add the multiple results to the multipleList list
        // 4. Convert multipleList to array and return it.

        List<double> multipleList = new List<double>();

        for (int i = 1; i <= length; ++i)
        {
            double multiple = number * i;

            multipleList.Add(multiple);

        }

        return multipleList.ToArray();// replace this return statement with your own
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
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // STEPS
        //1. Save the data array size in a variable 'n'
        //2. Find the actual positon to rotate (k = amount % n) 
        //3. Create a new list (rotate) to hold the rotated items
        //4. Loop through the array and assign new index for the original items (the index they will have after rotation)
        //5. Save the original array element in the new rotate array with their respective indexes  
        //6. Loop through the array and copy the items in the rotate array back to the data array 

        int n = data.Count;
        int k = amount % n;

        int[] rotate = new int[n];

        for (int i = 0; i < n; i++)
        {
            int newIndex = (i + k) % n;
            rotate[newIndex] = data[i];
        }

        for (int i = 0; i < n; i++)
        {
            data[i] = rotate[i];
        }

    }
}

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
        // Step 1: Create a new array of type double with the specified length.
        double[] result = new double[length];

        // Step 2: Loop from 0 to length - 1.
        // For each index i, calculate the multiple: number * (i + 1).
        // Store the result in the array at position i.
        for (int i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        // Step 3: Return the filled array.

        return result;
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
        // Step 1: Normalize the rotation amount.
        
       
        amount %= data.Count;

    // Step 2: Identify the split point.
    // We want to take the last 'amount' elements and move them to the front.
    // So we split the list into two parts:
    // - tail: the last 'amount' elements
    // - head: the first 'data.Count - amount' elements

    // Step 3: Use GetRange to extract the two parts.
    // GetRange(startIndex, count) helps us slice the list cleanly.

    // Step 4: Clear the original list.
    // Since we are modifying the list in-place, we remove all elements first.
    // Step 5: Add the tail followed by the head back into the list.
    
    

    // Implementation:
    List<int> tail = data.GetRange(data.Count - amount, amount);
    List<int> head = data.GetRange(0, data.Count - amount);
    data.Clear();
    data.AddRange(tail);
    data.AddRange(head);
    }
}

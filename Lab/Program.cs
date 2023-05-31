/*
 Question 1
We have a list of integers where elements appear either once or twice. Find the elements that appeared twice in O(n) time.
example: { 1, 2, 3, 4, 7, 9, 2, 4}
returns '{2, 4}
*/


        int[] nums = { 1, 2, 3, 4, 7, 9, 2, 4 };
        List<int> AppearedTwice(int[] nums)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        List<int> duplicates = new List<int>();

        foreach (int num in nums)
        {
            if (numbers.ContainsKey(num))
            {
                duplicates.Add(num);
            }
            else
            {
                numbers[num] = 1;
            }
        }

        return duplicates;
    }
       
        List<int> duplicates = AppearedTwice(nums);
        Console.WriteLine(string.Join(", ", duplicates));
        Console.WriteLine();


/*Question 2
 We have two sorted int arrays which could be with different sizes. We need to merge them in a third array while keeping this result array sorted. Can you do that in O(n) time? Don't use any extra structures like Sets or Dictionaries
example: {{1, 2, 3, 4, 5}, {2, 5, 7, 9, 13}}
returns {1, 2, 2, 3, 4, 5, 5, 7, 9, 13}
 */

        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 2, 5, 7, 9, 13 };
        int[] merged = ArraysMerge(array1, array2);
        int[] ArraysMerge(int[] array1, int[] array2)
    {
        int len1 = array1.Length;
        int len2 = array2.Length;
        int[] merged = new int[len1 + len2];

        int i = 0, j = 0, k = 0;

        while (i < len1 || j < len2)
        {
            if (i < len1 && (j >= len2 || array1[i] <= array2[j]))
            {
                merged[k++] = array1[i++];
            }
            else
            {
                merged[k++] = array2[j++];
            }
        }

        return merged;
    }
              
       Console.WriteLine(string.Join(", ", merged));
       Console.WriteLine();


/*
 Question 3
Given an integer, reverse the digits of that integer, e. g. input is 3415, output is 5143. What is the time complexity of your solution?

 */

    int num = 3415;
    int reversed = ReverseInt(num);
    int ReverseInt(int num)
    {
        int reversed = 0;

        while (num != 0)
        {
            int digit = num % 10;
            reversed = reversed * 10 + digit;
            num /= 10;
        }

        return reversed;
    }  
    Console.WriteLine(reversed);

Console.WriteLine("Time Complexity is On");
    
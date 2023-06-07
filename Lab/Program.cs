/*








List<int> OrderByLooping (List<int>) orders a list of integers, from least to greatest, using only basic control statements (ie. if/else, for/while).

For example, argument {6, -2, 5, 3} returns {-2, 3, 5, 6}.



Bonus:
Once you finish these methods, do some research into bubble sorting. refactor OrderByLooping method to use it
 */

/*
 Question 1
List<int> MaxNumbersInLists(List<List<int>>) accepts as a parameter a List of Lists of Integers.
It returns a new list with each element representing the maximum number found in the corresponding
original list. 
For example, { {1, 5, 3}, {9, 7, 3, -2}, {2, 1, 2} } returns {5, 9, 2}.
Output the results with a message like: “List 1 has a maximum of 5.
List 2 has a maximum of 9. List 3 has a maximum of 2.”

 */

List<List<int>> lists = new List<List<int>>()
        {
            new List<int> { 1, 5, 3 },
            new List<int> { 9, 7, 3, -2 },
            new List<int> { 2, 1, 2 }
        };
    List<int> MaxNumbersInLists(List<List<int>> lists)
    {
        List<int> maxNumbers = new List<int>();

        for (int i = 0; i < lists.Count; i++)
        {
            List<int> currentList = lists[i];
            int max = int.MinValue;

            foreach (int num in currentList)
            {
                if (num > max)
                {
                    max = num;
                }
            }

            maxNumbers.Add(max);
        }

        return maxNumbers;
    }
            
     List<int> maxNumbers = MaxNumbersInLists(lists);

     for (int i = 0; i < maxNumbers.Count; i++)
        
     Console.WriteLine($"List {i + 1} has a maximum of {maxNumbers[i]}.");
   Console.WriteLine();
// Time Complexity is On^2

/*
 Question 2

String HighestGrade(List<List<int>>) accepts a list of number grades among students in different courses
(where each list represents a single course), between 0 and 100. It returns the highest grade among all
students in all courses.
For example: { {85,92, 67, 94, 94}, {50, 60, 57, 95}, {95} } returns "The highest grade is 95.
This grade was found in class(es) {index}".

 */

    List<List<int>> courses = new List<List<int>>()
        {
            new List<int> { 85, 92, 67, 94, 94 },
            new List<int> { 50, 60, 57, 95 },
            new List<int> { 95 }
        };

    string HighestGrade(List<List<int>> courses)
    {
        int highestGrade = int.MinValue;
        List<int> courseIndices = new List<int>();

        for (int i = 0; i < courses.Count; i++)
        {
            foreach (int grade in courses[i])
            {
                highestGrade = Math.Max(highestGrade, grade);
            }
        }

        for (int i = 0; i < courses.Count; i++)
        {
            if (courses[i].Contains(highestGrade))
            {
                courseIndices.Add(i);
            }
        }

        string indexString = string.Join(", ", courseIndices);
        return $"The highest grade is {highestGrade}. This grade was found in class(es) {indexString}.";
    }
       string result = HighestGrade(courses);
        Console.WriteLine(result);
        Console.ReadLine();
    

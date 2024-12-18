using System;

namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            /*    Example 
             * Input: 5 
             * Output: 1, 2, 3, 4, 5
             */

            //Console.Write("Enter a number: ");
            //bool isparsed=int.TryParse(Console.ReadLine(), out int number);
            //if (isparsed && number>=1) {
            //    for(int i = 1; i <= number; i++)
            //    {
            //        Console.Write(i+(i < number ? ", " : ""));

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid or less than 1");
            //}


            #endregion

            #region 2- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            /*
             * Example
             *Input: 5
             *  Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
             */

            //Console.Write("Enter a number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isparsed)
            //{
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        Console.Write(i*number +" ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}


            #endregion

            #region 3- Write a program that allows to user to insert number then print all even numbers between 1 to this number
            /*
             *  Example:
             *   Input: 15
             *    Output: 2 4 6 8 10 12 14
             */

            //Console.Write("Enter a number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isparsed)
            //{
            //    for (int i = 1; i <= number; i++)
            //    {
            //        if (i % 2 == 0)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}
            //// Another solution 
            //Console.Write("Enter a number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isparsed)
            //{
            //    for (int i = 2; i <= number; i+=2)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}
            #endregion

            #region 4- Write a program that takes two integers then prints the power.
            /*
             * Example:
             * Input: 4 3
             * Output: 64
             * Hint: how to calculate 4^3 = 4 * 4 * 4 =64
             */

            //Console.Write("Enter a base number: ");
            //bool isparsedBase = int.TryParse(Console.ReadLine(), out int baseNumber);
            //Console.Write("Enter a exponent/power number: ");
            //bool isparsedPower = int.TryParse(Console.ReadLine(), out int powerNumber);
            //int result = baseNumber;
            //if (isparsedBase&&isparsedPower)
            //{
            //    if (powerNumber == 0)
            //    {
            //        Console.WriteLine($"{baseNumber}^{powerNumber}=1");
            //    }
            //    else { 
            //    for(int i = 1; i < powerNumber; i++)
            //    {
            //        result *= baseNumber;
            //    }
            //    Console.WriteLine(result); 
            //}}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}
            #endregion

            #region 5- Write a program to enter marks of five subjects and calculate total, average and percentage.
            /*
             * Example
             * Input: - Enter Marks of five subjects: 95 76 58 90 89
             * Output: Total marks = 408
             * Average Marks = 81
             * Percentage = 81
             */

            //int[] grades = new int[5];
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write($"Enter {i+1} Mark: ");
            //    bool isparsed = int.TryParse(Console.ReadLine(), out grades[i]);
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("Number is not valid");
            //    }

            //}
            //int total = 0;
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    total += grades[i];
            //}

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average marks = {total / grades.Length}");
            //Console.WriteLine($"Percentage = {(total / 500.0) * 100}%");
            #endregion

            #region 6- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a Message: ");
            //string message = Console.ReadLine();
            //char[] reversedMessage = new char[message.Length]; 
            //for (int i = 0; i < message.Length; i++)
            //{
            //    reversedMessage[message.Length - 1 - i] = message[i];
            //}
            //for (int i = 0; i < message.Length; i++)
            //{
            //    Console.Write(reversedMessage[i]);
            //}
            #endregion

            #region 7- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter a number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);
            //int reversednumber = 0;
            //if (isparsed )
            //{
            //    while (number != 0)
            //    {
            //        int ones = number % 10;
            //        reversednumber = reversednumber * 10 + ones;
            //        number /= 10;
            //    }
            //    Console.WriteLine(reversednumber);
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            #endregion

            #region 8- Write a program in C# Sharp to find prime numbers within a range of numbers.
            /*
             * Test Data :
             * Input starting number of ranges: 1
             * Input ending number of range : 50
             * 
             * Expected Output :
             * The prime number between 1 and 50 are :
             * 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
             */

            //Console.Write("Enter start range: ");
            //bool isparsedStartRange = int.TryParse(Console.ReadLine(), out int startRange);
            //Console.Write("Enter end range: ");
            //bool isparsedEndRange = int.TryParse(Console.ReadLine(), out int endRange);
            //if (isparsedStartRange && isparsedEndRange)
            //{
            //    for (int i = startRange; i <= endRange; i++)
            //    {
            //        if (i > 1)
            //        {
            //            bool checkPrime = true;
            //            for (int j = 2; j * j <= i; j++)
            //            {
            //                if (i % j == 0)
            //                {
            //                    checkPrime = false;
            //                    break;
            //                }
            //            }
            //            if (checkPrime)
            //            {
            //                Console.Write(i + " ");
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            #endregion

            #region 9- . Write a program in C# Sharp to convert a decimal number into binary without using an array.
            /*
             * Test Data :
             * Enter a number to convert :25
             * Expected Output :
             * The Binary of 25 is 11001.
             */

            //Console.Write("Enter a decimal number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);
            //int decemialNumber = number;
            //int result = 0;
            //int baseNumber = 1;
            //if (isparsed)
            //{
            //    while (number > 0) {
            //        int remainder = number % 2;
            //        result += remainder * baseNumber; 
            //        baseNumber *= 10; 
            //        number /= 2;
            //    }
            //    Console.Write($"The binary of {decemialNumber} is {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}
            #endregion

            #region 10- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("Enter x1 : ");
            //bool isparsedX1 = int.TryParse(Console.ReadLine(), out int x1);
            //Console.Write("Enter y1 : ");
            //bool isparsedY1 = int.TryParse(Console.ReadLine(), out int y1);
            //Console.Write("Enter x2 : ");
            //bool isparsedX2 = int.TryParse(Console.ReadLine(), out int x2);
            //Console.Write("Enter y2 : ");
            //bool isparsedY2 = int.TryParse(Console.ReadLine(), out int y2);
            //Console.Write("Enter x3 : ");
            //bool isparsedX3 = int.TryParse(Console.ReadLine(), out int x3);
            //Console.Write("Enter y3 : ");
            //bool isparsedY3 = int.TryParse(Console.ReadLine(), out int y3);
            //if (isparsedX1&&isparsedY1&&isparsedX2&&isparsedY2&&isparsedX3&&isparsedY3)
            //{
            //    //check slopes
            //    int slope1 = (y2 - y1) / (x2 - x1);
            //    int slope2 = (y3 - y2) / (x3 - x2);
            //    if (slope1 == slope2)
            //    {
            //        Console.WriteLine("these points lie on a single straight line");
            //    }
            //    else {
            //        Console.WriteLine("these points don't lie on a single straight line");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}
            #endregion

            #region 11- . Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.Write("Enter a number: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int number);
            //if (isparsed && number >= 1)
            //{
            //    for (int i = 0; i < number; i++)
            //    {
            //        for(int j = 0; j < number; j++)
            //        {
            //            if (i == j)
            //            {
            //                Console.Write("1");
            //            }
            //            else
            //            {
            //                Console.Write("0");
            //            }
            //        }
            //        Console.WriteLine("");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Number is not valid");
            //}
            #endregion

            #region 12- Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.Write("Enter length of array: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int lengthArray);
            //if (!isparsed)
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            //int[] numbers = new int[lengthArray];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"Enter {i + 1} number: ");
            //   isparsed = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("Number is not valid");
            //    }

            //}
            //int total = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    total += numbers[i];
            //}
            //Console.WriteLine(total);
            #endregion

            #region 13- Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.Write("Enter length of array: ");
            //bool isparsedfirst = int.TryParse(Console.ReadLine(), out int lengthArray);
            //if (!isparsedfirst)
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            //int[] numbers1 = new int[lengthArray];
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    Console.Write($"Enter {i + 1} number: ");
            //    isparsedfirst = int.TryParse(Console.ReadLine(), out numbers1[i]);
            //    if (!isparsedfirst)
            //    {
            //        Console.WriteLine("Number is not valid");
            //    }

            //}

            //int[] numbers2 = new int[lengthArray];
            //for (int i = 0; i < numbers2.Length; i++)
            //{
            //    Console.Write($"Enter {i + 1} number: ");
            //    isparsedfirst = int.TryParse(Console.ReadLine(), out numbers2[i]);
            //    if (!isparsedfirst)
            //    {
            //        Console.WriteLine("Number is not valid");
            //    }

            //}

            //int[] mergedArray= new int[2*lengthArray];
            //for (int i = 0; i < lengthArray; i++) {
            //    mergedArray[i]=numbers1[i];
            //    mergedArray[lengthArray+i]=numbers2[i];
            //}

            ////bubble sort
            //for (int i = 0; i < mergedArray.Length-1; i++) {
            //    for (int j = i+1; j < mergedArray.Length; j++) { 
            //        if (mergedArray[i] > mergedArray[j])
            //        {
            //            int swap=mergedArray[i];
            //            mergedArray[i]=mergedArray[j];
            //            mergedArray[j] = swap;
            //        }
            //    }
            //}

            ////print merged array
            //Console.WriteLine("Merged Sorted Array: ");
            //for (int i = 0; i < mergedArray.Length; i++) { 
            //    Console.Write(mergedArray[i]+" ");

            //}
            #endregion

            #region 14- Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.Write("Enter length of array: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int lengthArray);
            //if (!isparsed)
            //{
            //    Console.WriteLine("Number is not valid");
            //}

            //int[] numbers = new int[lengthArray];
            //int[] numbersChecked = new int[lengthArray];
            //for (int i = 0; i < numbers.Length;)
            //{
            //    Console.Write($"Enter {i + 1} number: ");
            //    isparsed = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    numbersChecked[i] = 0;
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("Number is not valid");
            //    }
            //    else
            //    {
            //        i++;
            //    }

            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if( numbersChecked[i] == 1)
            //    {
            //        continue;
            //    }
            //    int count = 1;
            //    for (int j = i+1; j < numbersChecked.Length; j++)
            //    {
            //        if( numbers[i] == numbers[j])
            //        {
            //            count++;
            //            numbersChecked [j]= 1;
            //        }
            //    }
            //    Console.WriteLine($" {numbers[i]} is {count} times.");

            //}
            #endregion

            #region 15- Write a program in C# Sharp to find maximum and minimum element in an array
            //int[] numbers = { 15, 25, 53, 54, 45, 56, 7650, 851, 540, 5130, 4420 };
            //int max, min;
            //min = max= numbers[0]; 
            //for (int i = 1; i < numbers.Length; i++) {
            //    if (numbers[i] < min) { 
            //        min = numbers[i];
            //    }
            //    if (numbers[i] > max)
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine($"max = {max}");
            //Console.WriteLine($"min = {min}");
            #endregion

            #region 16- Write a program in C# Sharp to find the second largest element in an array.
            //int[] numbers = { 15, 25, 53, 54, 45, 56, 7650, 851, 540, 5130, 4420 };
            //int max = numbers[0];
            //int secondMax = numbers[0];
            //for (int i = 1; i < numbers.Length; i++) {
            //    if (numbers[i] > max)
            //    {
            //        secondMax = max;
            //        max = numbers[i];
            //    }
            //    else if (numbers[i] > secondMax) { 
            //        secondMax=numbers[i];
            //    }
            //}
            //System.Console.WriteLine(secondMax);

            // Another solution
            //int[] numbers = { 15, 25, 53, 54, 45, 56, 7650, 851, 540, 5130, 4420 };
            //int max = numbers[0];
            //int secondMax = numbers[0];
            ////foreach (int i in numbers)
            //{
            //    if (i > max)
            //    {
            //        secondMax = max;
            //        max = i;
            //    }
            //    else if (i > secondMax)
            //        secondMax = i;
            //}
            //System.Console.WriteLine(secondMax);



            #endregion

            #region 17-. Consider an Array of Integer values with size N, having values as in this Example
            //7	   0	0	0	5	6	7	5	0	7	5	3
            /*
             * write a program find the longest distance between Two equal cells.
             * In this example. The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2 (cell 2 and cell 3).
             * In the example above, the longest distance is between the first 7 and the 10th 7, with a distance of 8 cells,
             * , i.e. the number of cells between the 1st And the 10th 7s.
             * Note:
             * - Array values will be taken from the user
             * - If you have input like 1111111 then the distance is the number of Cells between the first and the last cell.
             */

            //Console.Write("Enter length of array: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int arrayLength);
            //if (!isparsed)
            //{
            //    Console.WriteLine("Number is not valid or less than 1");
            //}


            //int[] numbers = new int[arrayLength];
            //for (int i = 0; i < numbers.Length; )
            //{
            //    Console.Write($"Enter {i + 1} number: ");
            //    isparsed = int.TryParse(Console.ReadLine(), out numbers[i]);
            //    if (!isparsed)
            //    {
            //        Console.WriteLine("Number is not valid");
            //    }
            //    else {
            //        i++;
            //    }
            //}
            //int distance = 0;
            //int longestDistance = 0;
            //for (int i = 0; i < numbers.Length; i++) {
            //    for (int j = i + 1; j < numbers.Length; j++) {
            //        if (numbers[i] == numbers[j]) {
            //            distance = j - i;
            //            if (longestDistance < distance) {
            //                longestDistance = distance;
            //            }

            //        }
            //    }
            //}
            //Console.WriteLine(longestDistance-1);
            #endregion

            #region 18- Given a list of space separated words, reverse the order of the words.
            /*
             * Input: this is a test		Output: test a is this
             * Input: all your base		Output: base your all
             * Input: Word			Output: Word
             * Note : 
             * Check the Split Function (Member in String Class) 
             * Output will be a Single Console.WriteLine Statement
             */
            //Console.WriteLine("Enter a message");
            //string message = Console.ReadLine();
            //string[] wordsInMessage = message.Split(' ');
            //for (int i = wordsInMessage.Length - 1; i >= 0; i--) {
            //    Console.Write(wordsInMessage[i]+" ");
            //}
            #endregion

            #region 19- Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.Write("Enter number of rows of array: ");
            //bool isparsed = int.TryParse(Console.ReadLine(), out int rows);
            //if (!isparsed)
            //{
            //    Console.WriteLine("Number is not valid or less than 1");
            //}

            //Console.Write("Enter number of columns of array: ");
            //isparsed = int.TryParse(Console.ReadLine(), out int columns);
            //if (!isparsed)
            //{
            //    Console.WriteLine("Number is not valid or less than 1");
            //}

            //int[,] a = new int[rows, columns];
            //int[,] b = new int[rows, columns];
            //for (int i = 0; i < a.GetLength(0); i++) {
            //    for (int j = 0; j < a.GetLength(1); j++) {
            //        Console.Write($"[{i},{j}] = ");
            //        isparsed = int.TryParse(Console.ReadLine(), out a[i,j]);
            //        if (!isparsed)
            //        {
            //            Console.WriteLine("Number is not valid ");
            //        }
            //    }

            //}

            //for (int i = 0;i < a.GetLength(0); i++) { 
            //    for(int j = 0;  j < a.GetLength(1); j++)
            //    {
            //        b[i,j]=a[i,j];
            //    }
            //}

            //for (int i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        Console.Write(b[i,j]+" ");
            //    }
            //    Console.WriteLine(" ");
            //}

            #endregion

            #region 20- Write a Program to Print One Dimensional Array in Reverse Order
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //for (int i = numbers.Length - 1; i >= 0; i--) { 
            //    Console.Write(numbers[i]+" ");
            //}
           
            #endregion

        }
    }
}

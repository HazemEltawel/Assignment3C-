static class Program
{
    static void Main(string[] args)
    {
        #region
        //1.Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
        //Example(1)
        //Input: 12
        //Output: Yes
        //Example(2)
        //Input: 9
        //Output: No

        //Console.Write("Enter number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //if (number % 2 == 0) { Console.WriteLine("yes"); }
        //else
        //{
        //    Console.WriteLine("No");
        //    #endregion
        //}

        #endregion

        #region
        //2.Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
        //Example(1)
        //Input: -5
        //Output: negative
        //Example(2)
        //Input: 10
        //Output: positive

        //Console.Write("Enter number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //if (number < 0) { Console.WriteLine("negative"); }
        //else { Console.WriteLine("positive"); }

        #endregion

        #region
        //3.Write a program that takes 3 integers from the user then prints the max element and the min element.
        //Example(1)
        //Input: 7,8,5
        //Output:
        //max element = 8
        //min element = 5
        //Example(2)
        //Input: 3 6 9
        //Outputs:
        //Max element = 9
        //Min element = 3

        //Console.Write("Enter First Number");
        //int number1 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter Seucnd Number");
        //int number2 = Convert.ToInt32(Console.ReadLine());

        //Console.Write("Enter Third Number");
        //int number3 = Convert.ToInt32(Console.ReadLine());

        //int max = number1;
        //if (number2 > max) { max = number2; }
        //if (number3 > max) { max = number3; }

        //int min = number1;
        //if (number2 < min) { min = number2; }
        //if (number3 < min) { min = number3; }

        //Console.WriteLine("max: " + max);
        //Console.WriteLine("min: " + min);
        #endregion

        #region 
        //4.Write a program that allows the user to insert an integer number then check If a number is even or odd.

        //Console.Write("Enter number");
        //int number = Convert.ToInt32(Console.ReadLine());
        //if (number % 2 == 0) { Console.WriteLine("even "); }
        //else { Console.WriteLine("odd"); }
        #endregion

        #region 
        //5. Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
        //Example(1)
        //Input: O
        //Output: vowel
        //Example(2)
        //Input: b
        //Output: Consonant

        //Console.WriteLine("Enter character");

        //char character = Convert.ToChar(Console.ReadLine());
        //character = char.ToLower(character);
        //if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
        //{ Console.WriteLine("vowel"); }
        //else { Console.WriteLine("consonant"); }

        #endregion

        #region 

        //6.Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
        //Example
        //Input: 5
        //Output: 1, 2, 3, 4, 5

        //Console.Write("Enter Number");

        //int number = Convert.ToInt32(Console.ReadLine());

        //for (int i = 1; i <= number; i++)
        //{
        //    if (i == number)
        //        Console.Write(i);
        //    else
        //        Console.Write(i + ", ");
        //}

        #endregion

        #region 
        //7- Write a program that allows the user to insert an integer then 
        //print a multiplication table up to 12.
        //Example
        //Input: 5
        //Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

        //Console.Write("Enter Number: ");

        //int number = Convert.ToInt32(Console.ReadLine());
        //for (int i = 1; i <= 12; i++)
        //{
        //    Console.Write(number * i);
        //    if (i < 12)
        //        Console.Write(", ");
        //}
        #endregion

        #region 
        //8.Write a program that allows to user to insert number then print all even numbers between 1 to this number
        //Example:
        //Input: 15
        //Output: 2 4 6 8 10 12 14

        //Console.Write("Enter Numer: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //for (int i = 2; i <= number; i += 2)
        //{
        //    Console.Write(i);
        //    if (i < number)
        //        Console.Write(", ");
        //}
        #endregion

        #region

        //9.Write a program that takes two integers then prints the power.
        //Example:
        //Input: 4 3
        //Output: 64
        //Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

        //Console.Write("Enter num: ");
        //int number = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter exponent: ");
        //int exponent = Convert.ToInt32(Console.ReadLine());

        //int res = 1;
        //for (int i = 1; i <= exponent; i++) { res *= number; }
        //Console.WriteLine(res);


        #endregion

        #region

        //10.Write a program to enter marks of five subjects and calculate total, average and percentage.
        //Example
        //Input: -Enter Marks of five subjects: 95 76 58 90 89
        //Output: Total marks = 408
        //Average Marks = 81
        //Percentage = 81

        Console.WriteLine("Enter marks of five subjects:");
        Console.Write("Subject 1: ");
        int su1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 2: ");
        int su2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 3: ");
        int su3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 4: ");
        int su4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 5: ");
        int su5 = Convert.ToInt32(Console.ReadLine());

        int total = su1 + su2 + su3 + su4 + su5;
        double avg = total / 5.0;
        double precentage = (total / 500.0) * 100;

        Console.WriteLine("Total marks = " + total);
        Console.WriteLine("Average Marks = " + avg);
        Console.WriteLine("Percentage = " + precentage + "%");

        #endregion

        #region

        //11.Write a program to input the month number and print the number of days in that month.
        //Example
        //Input: Month Number: 1
        //Output: Days in Month: 31

        //Console.Write("Enter month number (1 - 12): ");
        //int month = Convert.ToInt32(Console.ReadLine());
        //int day;
        //if (month == 1 || month == 3 || month == 5 || month == 7 ||
        //    month == 8 || month == 10 || month == 12) { day = 31; }
        //else if (month == 4 || month == 6 || month == 9 || month == 11) { day = 30; }
        //else if (month == 2) { day = 28; }
        //else
        //{
        //    Console.WriteLine("Invalid month number.");
        //    return;
        //}

        //Console.WriteLine("Days in Month: " + day);


        #endregion

        #region
        //12.Write a program to create a Simple Calculator.

        double num1, num2, res;
        char ope;
        Console.Write("Enter First Number");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Operator (+, -, *, /): ");
        ope = Convert.ToChar(Console.ReadLine());

        switch (ope)
        {
            case '+':
                res = num1 + num2;
                Console.WriteLine("Result: " + res);
                break;
            case '-':
                res = num1 - num2;
                Console.WriteLine("Result: " + res);
                break;
            case '*':
                res = num1 * num2;
                Console.WriteLine("Result: " + res);
                break;
            case '/':
                if (num2 != 0)
                {
                    res = num1 / num2;
                    Console.WriteLine("Result: " + res);
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                }
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }


        #endregion

        #region
        //13.Write a program to allow the user to enter a string and print the REVERSE of it.
        //Console.Write("Enter String: ");
        //String str = Console.ReadLine();
        //char[] ch = str.ToCharArray();
        //Array.Reverse(ch);
        //string reve = new string(ch);
        //Console.WriteLine(reve);

        #endregion

        #region
        //14.Write a program to allow the user to enter int and print the REVERSED of it.

        //Console.Write("Enter Number: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //int reve = 0;
        //while (num > 0)
        //{   
        //    int digit = num % 10;
        //    reve = reve * 10 + digit;
        //    num /= 10;
        //}
        //Console.WriteLine(reve);
        #endregion

        #region
        //15.Write a program in C# Sharp to find prime numbers within a range of numbers.
        //Test Data :
        //Input starting number of range: 1
        //Input ending number of range: 50
        //Expected Output :
        //The prime number between 1 and 50 are:
        //2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

        //----------------

        //Console.Write("Input starting number of range: ");
        //int start = Convert.ToInt32(Console.ReadLine());
        //Console.Write("Input ending number of range: ");
        //int end = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("\nThe prime numbers between " + start + " and " + end + " are:");

        //for (int i = start; i <= end; i++)
        //{
        //if (IsPrime(i))
        //  { Console.Write(i + ", "); }
        //} 
        //    Console.WriteLine(); 
        //  }

        //static bool IsPrime(int number)
        //{
        //  if (number <= 1)
        //      return false;
        //  for (int i = 2; i <= Math.Sqrt(number); i++)
        //{
        //    if (number % i == 0)
        //        return false;
        //}
        //return true;

        #endregion

        #region
        //16. Write a program in C# Sharp to convert a decimal number into binary without using an array.
        //Test Data :
        //Enter a number to convert: 25
        //Expected Output :
        //The Binary of 25 is 11001.

        //Console.Write("Enter Number ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int Returning = num;
        //String binary = " ";
        //while (num > 0)
        //{
        //    int remainder = num % 2;
        //    binary += remainder;
        //    num /= 2;
        //}
        //Console.WriteLine($"The Binary of "+ Returning +" is "+ binary);


        #endregion

        #region
        //17.Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

        //Console.Write("Enter x1: ");
        //double x1 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter x2: ");
        //double x2 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter x3: ");
        //double x3 = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter y1: ");
        //double y1 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter y2: ");
        //double y2 = Convert.ToDouble(Console.ReadLine());
        //Console.Write("Enter y3: ");
        //double y3 = Convert.ToDouble(Console.ReadLine());

        //double l1 = (y2 - y1) * (x3 - x2);
        //double R2 = (y3 - y2) * (x2 - x1);

        //if (l1 == R2)
        //{
        //    Console.WriteLine("these points lie on a single straight line.");
        //}
        //else
        //{
        //    Console.WriteLine("The points do not lie on a single straight line.");
        //}

        #endregion

        #region
        //18.Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
        //-If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
        //- If the worker takes 3 to 4 hours, they are instructed to increase their speed.
        //- If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
        //- If the worker takes more than 5 hours, they are required to leave the company.
        //To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

        //Console.Write("Enter The time: ");
        //int time = Convert.ToInt32(Console.ReadLine());
        //if (time >= 2 && time <= 3) { Console.WriteLine("Highly efficient"); }
        //else if (time > 3 && time <= 4) { Console.WriteLine("Increase Your Speed"); }
        //else if (time > 4 && time <= 5) { Console.WriteLine("Training to enhance their speed"); }
        //else if (time > 5) { Console.WriteLine("Required to leave the company"); }
        //else { Console.WriteLine("Invalid time "); } 


        #endregion

        #region
        //19. Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

        //Console.Write("Enter Size an identity matrix: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //  for (int j = 0; j < n; j++) 
        //    {
        //        if (i == j) { Console.Write("1"); }
        //        else { Console.Write("0"); }
        //    }
        //    Console.WriteLine();
        //}
        #endregion

        #region
        //20.  Write a program in C# Sharp to find the sum of all elements of the array.

        //Console.Write("Enter the Number ele: ");
        //int num = Convert.ToInt32(Console.ReadLine());

        //int[] arr = new int[num];
        //int sum = 0;
        //for (int i = 0; i < num; i++)
        //{
        //    Console.Write($"Enter Ele{i + 1} ");
        //    arr[i] = Convert.ToInt32((string)Console.ReadLine());
        //    sum += arr[i];
        //}
        //Console.WriteLine(sum);
        #endregion

        #region
        //21.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

        //Console.Write("Enter size of arrays: ");
        //int size = Convert.ToInt32(Console.ReadLine());

        //int[] arr1 = new int[size];
        //int[] arr2 = new int[size];

        //Console.WriteLine("Enter elements of first array:");
        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write($"arr1[{i}]: ");
        //    arr1[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Console.WriteLine("Enter elements of second array:");
        //for (int i = 0; i < size; i++)
        //{
        //    Console.Write($"arr2[{i}]: ");
        //    arr2[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //int[] arr1arr2 = arr1.Concat(arr2).OrderBy(x => x).ToArray();

        //Console.WriteLine("\nMerged and sorted array:");
        //foreach (int num in arr1arr2)
        //{
        //    Console.Write(num + " ");
        //}
        //Console.WriteLine();
        #endregion

        #region
        //22.Write a program in C# Sharp to count the frequency of each element of an array.

        //Console.Write("Enter number of elements: ");
        //int n = Convert.ToInt32(Console.ReadLine());
        //int[] arr = new int[n];
        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write($"Element [{i}]: ");
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //bool[] counted = new bool[n];

        //Console.WriteLine("\nFrequency of each element:");
        //for (int i = 0; i < n; i++)
        //{
        //    if (counted[i])
        //        continue;

        //    int count = 1;
        //    for (int j = i + 1; j < n; j++)
        //    {
        //        if (arr[i] == arr[j])
        //        {
        //            count++;
        //            counted[j] = true;
        //        }
        //    }

        //    Console.WriteLine($"{arr[i]} occurs {count} time(s)");
        //}
        #endregion

        #region
        //23. Write a program in C# Sharp to find maximum and minimum element in an array
        //Console.Write("Enter number of elements: ");
        //int num = Convert.ToInt32(Console.ReadLine());
        //int[] arr = new int[num];
        //for (int i = 0; i < num; i++)
        //{
        //    Console.Write($"Element [{i}]: ");
        //    arr[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int min = arr[0];
        //int max = arr[0];
        //for (int i = 1; i < num; i++)
        //{
        //    if (arr[i] < min)
        //        min = arr[i];

        //    if (arr[i] > max)
        //        max = arr[i];
        //}
        //Console.WriteLine($"\nMaximum element = {max}");
        //Console.WriteLine($"Minimum element = {min}");
        #endregion




    }
}

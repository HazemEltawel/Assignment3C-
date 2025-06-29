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

        Console.Write("Enter First Number");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Seucnd Number");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Third Number");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int max = number1;
        if (number2 > max) { max = number2; }
        if (number3 > max) { max = number3; }

        int min = number1;
        if (number2 < min) { min = number2; }
        if (number3 < min) { min = number3; }

        Console.WriteLine("max: " + max);
        Console.WriteLine("min: " + min);
        #endregion




    }
}

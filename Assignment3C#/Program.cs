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

        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number < 0) { Console.WriteLine("negative"); }
        else { Console.WriteLine("positive"); }

        #endregion
    }
}

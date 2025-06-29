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

        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0) { Console.WriteLine("yes"); }
        else
        {
            Console.WriteLine("No");
            #endregion
        }
}

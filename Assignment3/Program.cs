namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            //Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("please enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else {

            //    Console.WriteLine("No");

            //}



            #endregion

            #region question 2
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("please enter number: ");
            //int number01 = Convert.ToInt32(Console.ReadLine());
            //if (number01 > 0)
            //{

            //    Console.WriteLine("Positive");
            //}
            //else {

            //    Console.WriteLine("Negative");

            //}
            #endregion

            #region question 3
            //Write a program that takes 3 integers from the user then prints the max element and the min element.
            //Console.WriteLine("please enter the first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("please enter the third number: ");
            //int num3 = Convert.ToInt32(Console.ReadLine());
            //int max = Math.Max(num1, Math.Max(num2, num3));
            //int min = Math.Min(num1, Math.Min(num2, num3));
            //Console.WriteLine("the maximum number is: " + max);
            //Console.WriteLine("the minimum number is: " + min);

            #endregion

            #region question 4
            //Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("please enter number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{

            //    Console.WriteLine("Odd");

            //}
            #endregion

            #region question 5
            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            Console.Write("Please enter Character:");
            string character = Console.ReadLine()!;
            if (character == "a" || character == "e" || character == "i" || character == "o" || character == "u")
            {

                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("consonant");
            }
            #endregion
        }
    }
}

using System.ComponentModel;

namespace Task_1___Week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a program that allows the user to enter a number then print it.
            #region Q1
            Console.Write("Enter the Number you want to print: ");
            string print = Console.ReadLine();
            Console.WriteLine(print);
            #endregion

            //Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no.
            #region Q2
            Console.Write("Enter a number to check if the number divisible by 3 and 4: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 3 == 0 && num % 4 == 0) ? "Yes" : "No");
            #endregion

            /*
            * Write a program that allows the user to insert 2 integers then print the max.
            */
            #region Q3
            Console.Write("Write to number to check the bigger space between them: ");
            List<int> nums = new List<int>();
            nums = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            if (nums[0] > nums[1])
            {
                Console.WriteLine($"{nums[0]} is bigger");
            }
            else if (nums[0] < nums[1])
            {
                Console.WriteLine($"{nums[1]} is bigger");
            }
            else
            {
                Console.WriteLine($"The Two numbers are equal");
            }
            #endregion

            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            #region Q4
            Console.Write("Enter a number to Know if its a negative or positive: ");
            int x = int.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("The number is zero");
            }
            else
            {
                Console.WriteLine((x < 0) ? "Negative" : "Positive");
            }
            #endregion

            //Write a program that takes 3 integers from the user then prints the max element and the min element
            #region Q5
            Console.Write("Enter a list of 3 Numbers seperated by space: ");
            List<int> numpers = new List<int>();
            numpers = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            Console.WriteLine($"The max: {numpers.Max()}");
            Console.WriteLine($"The min: {numpers.Min()}");
            #endregion

            //Write a program that allows the user to insert an integer number then check If a number is even or odd
            #region Q6
            Console.Write("Enter an integer number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine((y % 2 == 0) ? "Even" : "Odd");
            #endregion

            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)
            #region Q7
            List<char> chars = new List<char> { 'a', 'o', 'i', 'y', 'u' };
            Console.WriteLine("Enter a character to check if its vowel or consonent: ");
            Console.WriteLine((chars.Contains(char.Parse(Console.ReadLine()))) ? "vowel" : "Consonent");
            #endregion

            //Write a program that allows the user to insert an integer then print all numbers between 1 to that number
            #region Q8
            Console.Write("Enter number: ");
            int flag = int.Parse(Console.ReadLine());
            for (int i = 0; i < flag + 1; i++)
            {
                Console.Write(i);
                Console.Write(',');
            }
            #endregion

            /*
            * Write a program that allows the user to insert an integer then print 
            * a multiplication table up to 12.
            */
            #region Q9
            Console.Write("Enter number: ");
            int numberQ9 = int.Parse(Console.ReadLine());
            for (int i = 0; i < 13; i++)
            {
                Console.Write(numberQ9 * i);
                Console.Write(' ');
            }
            #endregion

            /*
            * Write a program that allows to user to insert number then print all even 
            * numbers between 1 to this number
            */
            #region Q10
            Console.Write("Enter number: ");
            int numberQ10 = int.Parse(Console.ReadLine());
            for (int i = 1; i < numberQ10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion







        }
    }
}




       
   

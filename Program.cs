using System;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;

            Console.WriteLine("Enter First Number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            b = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{a}, {b}, {a/b}");
            divideInts(a,b);
            getSafeInt();

            int[] numbers = new int[5] { 1, 2, 3, 4, 5};
            int length = numbers.Length; 

            var sum = sumOfNumbers(numbers, length);
            Console.WriteLine(sum);
        }
        public static int divideInts(int a, int b)
        {
            
                try
                {
                    return a / b;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero 0.");
                   // throw;
                   return 0;
                }

            

        }
        public static int getSafeInt()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("you did not enter a number"); 
                return getSafeInt();
            }
            catch(ArgumentException)
            {
                Console.WriteLine("You entered in null?!?!? how?!");
                return getSafeInt();
            }
            catch(OverflowException){
                Console.WriteLine($"that is toooo big a of number, try again with a number between {int.MinValue} and {int.MaxValue}");
                return getSafeInt();
            }

        }
        public static int sumOfNumbers(int[] numbers, int length)
        {
            try
            {
                if (length == numbers.Length)
                {
                    int total = 0;
                    foreach (var num in numbers)
                    {
                        total += num;
                    }
                    return total;
                } 
                else 
                {
                    throw new IndexOutOfRangeException();
                } 
            }
            catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The lengths did not match");
                    return 0; 
                }    
        }
    }
}

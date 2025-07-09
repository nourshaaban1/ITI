using System.Transactions;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region first Task
            Console.WriteLine("Please enter ur data");
            String name;
            while (true)
            {
                Console.Write("Name: ");
                name = Console.ReadLine();

                bool isNum = false;

                for (int i = 0; i < name.Length; i++)
                {
                    if (name[i] >= 48 && name[i] <= 57)
                    {
                        isNum = true;
                        break;
                    }
                }

                if (isNum)
                {
                    Console.WriteLine("Name can't contain any numbers. Please try again.");
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Welcome, {name}!");

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            while (id <= 0)
            {
                Console.WriteLine("ID cannot be 0 or negative. Please try again.");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Your ID is {id}");

            Console.Write("Age: ");
            int age = int.Parse(Console.ReadLine());
            while (age <= 0)
            {
                Console.WriteLine("Age cannot be 0 or negative. Please try again.");
                Console.Write("Age: ");
                age = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Your Age is {age}");
            #endregion

            #region second Task
            for (int i = 0; i < 13; i++)
            {
                Console.Write($"{i,3} |");
                for (int j = 0; j < 13; j++)
                {
                    Console.Write($"{i * j,4}");
                }
                Console.WriteLine();
            }

            #endregion

            #region Third Task
            Console.WriteLine("Please enter ur the number of ur subjects");
            int num = int.Parse(Console.ReadLine());
            int max = 0;
            for (int i = 0; i < num; i++)
            {
                int degree;
                Console.WriteLine($"Enter the degree of #{i+1} subject: ");
                degree = int.Parse(Console.ReadLine());
                if (degree > max)
                {
                    max = degree;
                }
            }
            Console.WriteLine($"Your Maximum degree is {max}");
            #endregion
        }
    }
}

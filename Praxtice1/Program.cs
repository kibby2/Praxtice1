using System;

namespace Practice1
{
    class Program
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        /*public int subtract(int a, int b)
        {
            return a - b;
        }*/

        static void Main(string[] args)
        {
            Program programInstance = new Program();
            string operation = "";

            while (operation.ToUpper() != "N")
            {
                Console.Write("Type first number: ");
                string input1 = Console.ReadLine();
                Console.Write("Type second number: ");
                string input2 = Console.ReadLine();

                int firstNum;
                int secondNum;

                int.TryParse(input1, out firstNum);
                int.TryParse(input2, out secondNum);

                Console.Write("Type A for add, S for subtract, and N to exit: ");
                operation = Console.ReadLine();

                if (operation.ToUpper() == "A")
                {
                    int sum = programInstance.add(firstNum, secondNum);
                    Console.WriteLine($"The sum is: {sum}");
                }
                else if (operation.ToUpper() == "S")
                {
                   // int difference = programInstance.subtract(firstNum, secondNum);
                    //Console.WriteLine($"The difference is: {difference}");
                }
                else if (operation.ToUpper() == "N")
                {
                    Console.WriteLine("Exiting program.");
                }
                else
                {
                    Console.WriteLine("Invalid operation. Please type 'A' for add, 'S' for subtract, or 'N' to exit.");
                }

                Console.WriteLine();  
            }
        }
    }
}

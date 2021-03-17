using System;

namespace CounterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counter App");
            Console.Write("Enter in a number: ");
            int.TryParse(Console.ReadLine(), out int number);

            if(number>0) {
                Console.Write("Do you want to count Up or Down from that number? (Options: Up or Down): ");
                string response = Console.ReadLine();

                int counter = 0;

                if (response == "Down") {
                    counter = number;
                }

                for (int i=0;i<=number;i++) {
                    if (response == "Up") {
                        Console.WriteLine("Counting Up: " + counter);
                        } else {
                        Console.WriteLine("Counting Down: " + counter);
                    }
                    counter += (response == "Up") ? 1 : -1;
                }

            }
        }
    }
}

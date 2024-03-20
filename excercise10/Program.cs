namespace excercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;

            while(choice != 4)
            {
            // Prints a Menu
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine();

            // ask user for a choice

            Console.WriteLine("Please enter a number from the menu");
            choice = int.Parse(Console.ReadLine());

            // Prints the responses for the menu buttons

                if (choice == 1)
                {
                    Console.WriteLine("Creating new save");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Loading a save");
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Opening options menu");
                }
                else if (choice > 4 || choice < 1)
                {
                    Console.WriteLine("Please enter a number 1 - 4");
                }

            }

        }
    }
}
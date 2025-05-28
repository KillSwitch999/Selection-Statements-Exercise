namespace SelectionStatementExercise
{
    public class Program
    {
        static void PauseAndClear()
        {
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            var random = new Random();
            var favNumber= random.Next(1, 10);
            int response = 0;
            
            Console.WriteLine("Hello, user, and welcome! We are going to play a game.\nYou are going to guess my favorite number. It will be between 1-10\nGood luck!");
            
            PauseAndClear();

            while (response != favNumber)
            {


                Console.WriteLine("What is your guess between 1-10?");
                response = int.Parse(Console.ReadLine());

                if (response < favNumber)
                {
                    Console.WriteLine($"Your guess is too low! Your guess was {response}");
                }

                else if (response > favNumber)
                {
                    Console.WriteLine($"Your guess is too high! Your guess was {response}");
                }

                else

                {
                    Console.WriteLine($"You guessed my favorite number! Good job! It was {response}!");
                }
            }
        }
    }
}

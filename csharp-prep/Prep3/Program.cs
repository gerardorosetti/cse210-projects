using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string ans = "";
        do{
            int number = randomGenerator.Next(1, 100);
            int guess, times = 0;
            bool flag = true;

            while(flag){

                Console.WriteLine("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                if(guess > number) Console.WriteLine("Lower");
                else if(guess < number) Console.WriteLine("Higher");
                else flag = false;
                times++;
            }

            Console.WriteLine("You guessed it in {0} times!\n\nDo you want to play again? (yes/no)",times);
            ans = Console.ReadLine();
        }while(ans.Equals("yes") || ans.Equals("y"));

    }
}
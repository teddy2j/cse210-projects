using System;

class Program
{
    static void Main(string[] args)
    {
        //for part 1 
        //Console.WriteLine("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine())
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -10;

        while ( guess != magicNumber)
        {
          Console.Write("What is your guess? ");
          guess = int.Parse(Console.ReadLine());

          if  (magicNumber > guess) 
          {
            Console.WriteLine("Higuer");
          } 
          else if (magicNumber< guess)
          {
            Console.WriteLine("Lower");
          }
          else
          {
            Console.WriteLine("You guessed it!");
          }
        }
    }
}
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";


        _prompts = new List<string>();
        _prompts.Add("Think of a time when you stood up for someone else");
        _prompts.Add("Think of a time when you did something really difficult");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:\n");
        List<string> promptsSoFar = new List<string>();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        base.ShowCountDown(5);
        Console.Clear();

        // making sure questions are not repeated//
        // (exceeding requirements) //
        List<string> questionsSoFar = new List<string>();
        bool isRepeated;
        string question;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            question = GetRandomQuestion();

            // checking if it's repeated //
            isRepeated = false;
            for (int i = 0; i < questionsSoFar.Count; i++ )
            {
                if (question == questionsSoFar[i])
                {
                    isRepeated = true;
                }
            }
            // if the question is not repeated// 
            //this will display the question and// 
            //also record the question to keep//
            //cheking repeated questions//
            if (isRepeated == false)
            {
                //displays question//
                Console.Write(question);
                base.ShowSpinner(5);
                Console.WriteLine();

                //record question//
                questionsSoFar.Add(question);

            }

            // this clears the list of questionsSoFar//
            //once all questions have been displayed//

            if (questionsSoFar.Count == _questions.Count)
            {
                questionsSoFar = new List<string>();
            }

        }








    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _prompts.Count());
        return _prompts[randomNumber];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, _questions.Count());
        return _questions[randomNumber];

    }

    private void DisplayPrompt()
    {
        string s = GetRandomPrompt();
        Console.WriteLine($"--- {s} ---");

    }






}
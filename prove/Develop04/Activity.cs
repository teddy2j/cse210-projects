using System.Runtime.CompilerServices;

public class Activity
{
protected string _name;
protected string _description;
protected int _duration;
public Activity()
{
    _name="";
    _description="";
    _duration=0;
}

public void DisplayStartingMessage()
{
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name} Activity \n");
    Console.WriteLine($"{_description} \n");
    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());
    Console.Clear();
    Console.WriteLine("Get ready... \n");
    ShowSpinner(3);
}

public void DisplayEndingMessage()
{
    Console.WriteLine("Well done!\n");
    ShowSpinner(3);
    Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity");
    ShowSpinner(3);
}

protected void ShowSpinner(int seconds)
{
    List<string> animationStrings = new List<string>();
    animationStrings.Add("^");
    animationStrings.Add("<");
    animationStrings.Add("v");
    animationStrings.Add(">");
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int i = 0;
    while (DateTime.Now < endTime)
    {
        string s = animationStrings[i];
        Console.Write(s);
        Thread.Sleep(500);
        Console.Write("\b \b");
        i++;
        if (i >= animationStrings.Count)
        {
            i=0;
        }

    }
}

protected void ShowCountDown(int seconds)
{
    for (int i=seconds; i>0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

}


}

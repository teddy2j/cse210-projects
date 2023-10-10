public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in... ");
            base.ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Breath out... ");
            base.ShowCountDown(5);
            Console.WriteLine("\n");

        }

    }
}
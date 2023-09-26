public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    Random rnd = new Random();
    public string GetRandomPrompt()
    {
        string question = _prompts[rnd.Next(0,5)];
        return question;
    }

}
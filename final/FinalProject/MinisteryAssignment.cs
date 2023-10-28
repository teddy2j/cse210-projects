public class MinisteryAssignment
{
    private List<Elder> _ministrant;
    private List<Elder> _ministrated;
    public MinisteryAssignment()
    {
        _ministrant = new List<Elder>();
        _ministrated = new List<Elder>();
    }

    public MinisteryAssignment(List<Elder> ministrantElders, List<Elder> ministratedElders)
    {
        _ministrant = ministrantElders;
        _ministrated = ministratedElders;
    }

    public List<Elder> GetMinistrant()
    {
        return _ministrant;
    }

    public List<Elder> GetMinistrated()
    {
        return _ministrated;
    }

    public void DisplayAssignment()
    {
        Console.WriteLine("Ministrant: ");
        for (int i = 0; i < _ministrant.Count; i++)
        {
            Console.WriteLine($"{i+1} - {_ministrant[i].GetDetailsString()}");
        }

        Console.WriteLine("Ministrated: ");
        for (int i = 0; i < _ministrated.Count; i++)
        {
            Console.WriteLine($"{i+1} - {_ministrated[i].GetDetailsString()}");
        }
        Console.WriteLine("\n");

    }

    public void DisplayMinistrantElders()
    {
        for (int x = 0; x < _ministrant.Count; x++)
            {
                Console.WriteLine($"{x+1} - {_ministrant[x].GetName()}");
            }
    }

        public void DisplayMinistratedElders()
    {
        for (int x = 0; x < _ministrant.Count; x++)
            {
                Console.WriteLine($"{x+1} - {_ministrated[x].GetName()}");
            }
    }

    public void SetMinistrant(List<Elder> elders)
    {
        _ministrant = elders;
    }

    
    public void SetMinistrated(List<Elder> elders)
    {
        _ministrated = elders;
    }



}

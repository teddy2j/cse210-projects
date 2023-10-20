public class GoalManager
{

    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }
    public void Start()
    {
        string choice = " ";
        while (choice !="6")
        {
            DisplayPlayerInfo();
            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
                 
            if (choice == "1")
            {
                CreateGoal();
            }

            else if (choice == "2")
            {
                ListGoalDetails();

            }
            else if (choice == "3")
            {
                SaveGoals();
            }

            else if (choice == "4")
            {
                LoadGoals();
            }

            else if (choice == "5")
            {
                RecordEvent();
            }
        }

            

    
    }
    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\n You have {_score} points \n");
        Console.WriteLine("Menu Options:");
        Thread.Sleep(1000);
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");

    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        string choicee = Console.ReadLine();

        if (choicee == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);

        }

        if (choicee == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);                    
        }

        if (choicee == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus? ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);                  
        }

    }
    private void ListGoalNames()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetName()}");
            i+=1;
        }        

    }

    private void ListGoalDetails()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i+=1;
        }       
    }

    private void SaveGoals()
    {
        Console.Write("Please, type the name of the save file: ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);
            
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }       
        }
    }

    private void LoadGoals()
    {

        _goals = new List<Goal>();
        Console.Write("What's the file name? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        // getting rid of the first line which only contains the score//
        List<string> fixedList = new List<string>();
        int i = 1;
        while (i < lines.Length)
        {
            fixedList.Add(lines[i]);
            i+=1;
        }

        foreach (string line in fixedList)
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string[] parameters = parts[1].Split(",");
            if (type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(parameters[0], parameters[1], int.Parse(parameters[2]));
                if (parameters[3] == "True")
                {
                    goal.SetCompleted();
                }
                _goals.Add(goal);
            }

            if (type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(parameters[0], parameters[1], int.Parse(parameters[2]));
                _goals.Add(goal);
            }

            if (type == "ChecklistGoal" )
            {
                ChecklistGoal goal = new ChecklistGoal(parameters[0], parameters[1], int.Parse(parameters[2]), int.Parse(parameters[4]), int.Parse(parameters[5]));
                int amount = int.Parse(parameters[3]);
                goal.SetAmount(amount);
                _goals.Add(goal);
            }


        }

    }

    private void RecordEvent()
    {
                Console.WriteLine("The goals are: ");
                ListGoalNames();
                Console.Write("What goal did you accomplish? ");
                int choiceee = int.Parse(Console.ReadLine());
                _goals[choiceee - 1].RecordEvent();
                _score += _goals[choiceee - 1].GetNumberToAdd();
    }







}
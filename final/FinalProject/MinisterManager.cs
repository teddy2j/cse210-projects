using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class MinisterManager
{
    List<Elder> _elders;
    List<MinisteryAssignment> _ministeryAssigments;

    public MinisterManager(List<Elder> elders)
    {
        _elders = elders;
        _ministeryAssigments = new List<MinisteryAssignment>();
    }

    public void Start()
    {

        string choice = " ";
        while (choice !="6")
        {
            Console.WriteLine("The current assignments are: \n");
            DisplayAssignments();
            Console.WriteLine("Choose one option:");
            Thread.Sleep(1000);
            Console.WriteLine("  1. Create new Assignment");
            Console.WriteLine("  2. Remove Ministrant Elder from an assignment");
            Console.WriteLine("  3. Add Ministrant Elder to an assignment");
            Console.WriteLine("  4. Remove Ministrated Elder from assignment");
            Console.WriteLine("  5. Add Ministrated Elder to assignment");
            Console.WriteLine("  6. Quit");

            Console.Write("Choose an option: ");
            choice = Console.ReadLine();
                 
            if (choice == "1")
            {
                CreateAssignment();
            }

            else if (choice == "2")
            {
                RemoveMinistrantElder();

            }
            else if (choice == "3")
            {
                AddMinistrantElder();
            }

            else if (choice == "4")
            {
                RemoveMinistratedElder();
            }

            else if (choice == "5")
            {
                AddMinistratedElder();
            }
        }
    }

        private void DisplayAssignments()
        {
            for (int i=0; i < _ministeryAssigments.Count; i++)
            {
                Console.WriteLine($"Ministrant assignment #{i+1}:");
                _ministeryAssigments[i].DisplayAssignment();
            }
        }




        private void CreateAssignment()
        {
            Console.WriteLine("The list of available elders are: \n");

            int j =1;
            List<int> indexes = new List<int>();

            for (int i=0; i < _elders.Count; i++)
            {
                if (_elders[i].HasGroup() == false)
                {
                    Console.WriteLine($"{j}. {_elders[i].GetDetailsString()}");
                    indexes.Add(i);
                    j++;
                }
            }

            List<Elder> ministrantElders = new List<Elder>();
            int index = 0;

            Console.WriteLine("Which elder would you like to add? (type continue to assign households)");
            string choice = Console.ReadLine();

            while (choice != "continue")
            {
                index = indexes[int.Parse(choice) - 1];
                _elders[index].AddToGroup();
                ministrantElders.Add(_elders[index]);
                Console.WriteLine($"{_elders[index].GetName()} has been added");

                Console.WriteLine("Current group: ");
                for (int x = 0; x<ministrantElders.Count; x++)
                {
                    Console.WriteLine($"-{ministrantElders[x].GetName()}");
                }
                Console.WriteLine("Which elder would you like to add? (type continue to assign households)");
                choice = Console.ReadLine();      
            }



            Console.WriteLine("The list of not-ministered elders is: ");
            j =1;
            indexes = new List<int>();

            for (int i=0; i < _elders.Count; i++)
            {
                if (_elders[i].IsMinistered() == false)
                {
                    Console.WriteLine($"{j}. {_elders[i].GetDetailsString()}");
                    indexes.Add(i);
                    j++;
                }
            }

            List<Elder> ministratedElders = new List<Elder>();
            index = 0;

            Console.WriteLine("Which elder would you like to give ministering brothers to? (or type finish)");
            choice = Console.ReadLine();

            while (choice != "finish")
            {
                index = indexes[int.Parse(choice) - 1];
                _elders[index].GiveMinisterBrothers();
                ministratedElders.Add(_elders[index]);
                Console.WriteLine($"{_elders[index].GetName()} has been added");

                Console.WriteLine("Current ministrant group: ");
                for (int x = 0; x<ministrantElders.Count; x++)
                {
                    Console.WriteLine($"-{ministrantElders[x].GetName()}");
                }

                Console.WriteLine("\n Current ministrated group: ");
                for (int x =0; x < ministratedElders.Count; x++)
                {
                    Console.WriteLine($"-{ministratedElders[x].GetName()}");

                }
                Console.WriteLine("Which elder would you like to add? (or type finish)");
                choice = Console.ReadLine();      
            }

            MinisteryAssignment Assignment = new MinisteryAssignment(ministrantElders, ministratedElders);
            _ministeryAssigments.Add(Assignment);
            Console.WriteLine("Assignment created \n");

        }

    private void RemoveMinistrantElder()
    {
        Console.WriteLine("Which assignment do you want to edit? ");
        int choice = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The ministrant elders are: ");
        _ministeryAssigments[choice -1].DisplayMinistrantElders();

        List<Elder> ministrants = _ministeryAssigments[choice -1].GetMinistrant();

        Console.WriteLine("Which elder do you want to remove? ");
        int choicee = int.Parse(Console.ReadLine());

        //accessing _elders//        
        string name = ministrants[choicee-1].GetName();
        for (int i = 0; i < _elders.Count; i++)
        {
            if (_elders[i].GetName() == name)
            {
                _elders[i].RemoveFromGroup();
            }
        }       
        ministrants.RemoveAt(choicee-1);
        _ministeryAssigments[choice-1].SetMinistrant(ministrants);

 
    }

    private void AddMinistrantElder()
    {

        Console.WriteLine("Which assignment do you want to edit? ");
        int choice = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The ministrant elders are: ");
        _ministeryAssigments[choice -1].DisplayMinistrantElders();

        

        Console.WriteLine("Which elder do you want to add to this group? \n");
        Console.WriteLine("These are the available elders: ");

        int j =1;
        List<int> indexes = new List<int>();

        for (int i=0; i < _elders.Count; i++)
        {
            if (_elders[i].HasGroup() == false)
            {
                Console.WriteLine($"{j}. {_elders[i].GetDetailsString()}");
                indexes.Add(i);
                j++;
            }
        }
        Console.WriteLine("What's your option? ");
        int choicee = int.Parse(Console.ReadLine());
        int index = indexes[choicee-1];
        _elders[index].AddToGroup();
        List<Elder> ministrants = _ministeryAssigments[choice -1].GetMinistrant();
        ministrants.Add(_elders[index]);
        _ministeryAssigments[choice-1].SetMinistrant(ministrants);



    }


    private void RemoveMinistratedElder()
    {
        Console.WriteLine("Which assignment do you want to edit? ");
        int choice = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The ministrated elders are: ");
        _ministeryAssigments[choice -1].DisplayMinistratedElders();

        List<Elder> ministrated = _ministeryAssigments[choice -1].GetMinistrated();



        Console.WriteLine("Which elder do you want to remove? ");
        int choicee = int.Parse(Console.ReadLine());

        //accessing _elders//        
        string name = ministrated[choicee-1].GetName();
        for (int i = 0; i < _elders.Count; i++)
        {
            if (_elders[i].GetName() == name)
            {
                _elders[i].RemoveMinisterBrothers();
            }
        }     
        ministrated.RemoveAt(choicee-1);
        _ministeryAssigments[choice-1].SetMinistrated(ministrated);

   
    }

    private void AddMinistratedElder()
    {

        Console.WriteLine("Which assignment do you want to edit? ");
        int choice = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The ministrated elders are: ");
        _ministeryAssigments[choice -1].DisplayMinistratedElders();

        List<Elder> ministrated = _ministeryAssigments[choice -1].GetMinistrant();

        Console.WriteLine("Which elder do you want to give ministering brothers? \n");
        Console.WriteLine("These are the available elders: ");

        int j =1;
        List<int> indexes = new List<int>();

        for (int i=0; i < _elders.Count; i++)
        {
            if (_elders[i].IsMinistered() == false)
            {
                Console.WriteLine($"{j}. {_elders[i].GetDetailsString()}");
                indexes.Add(i);
                j++;
            }
        }
        Console.WriteLine("What's your option? ");
        int choicee = int.Parse(Console.ReadLine());
        int index = indexes[choicee-1];
        _elders[index].GiveMinisterBrothers();
        ministrated.Add(_elders[index]);
        _ministeryAssigments[choice-1].SetMinistrant(ministrated);



    }




}
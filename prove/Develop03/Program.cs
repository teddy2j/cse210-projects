using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("juan",3,16,17);
        Scripture scripture = new Scripture(reference,"Porque de tal manera amó Dios al mundo que ha dado a su Hijo cUnigénito, para que todo aquel que en él cree no se pierda, mas tenga vida eterna. 17 Porque no aenvió Dios a su Hijo al mundo para bcondenar al mundo, sino para que el mundo sea csalvo por él.");
        Console.WriteLine(scripture.GetDisplayText());



        bool value = scripture.IsCompletelyHidden();
        while (value == false)
        {
            Console.WriteLine("");
            Console.Write("Please, press enter, or type quit ");
            string response = Console.ReadLine();
            if (response != "quit")
            {
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            value = scripture.IsCompletelyHidden();
            }
            else 
            {
                value = true;
            }
        }
    }
}


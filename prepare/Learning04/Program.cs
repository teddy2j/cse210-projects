using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Teddy Espino", "Matematicas");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Cesar Riva","Physichs","5", "13-17");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Xavier constante", "Art","Free Alberto");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());


    }
}
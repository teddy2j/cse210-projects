using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Google";
        job1._startYear = 2017;
        job1._endYear= 2022;


        Job job2 = new Job();
        job2._jobTitle = "CEO";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;



        Resume resume = new Resume();
        resume._name = "Allison Rosa";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();









        




    }
}
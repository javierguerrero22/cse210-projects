using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._company = "javier's";
        job1._jobTitle = "software developer";
        job1._startYear = 2007;
        job1._endYear = 2025;

        Job job2 = new Job();

        job2._company = "somewhere's";
        job2._jobTitle = "software engineer";
        job2._startYear = 2000;
        job2._endYear = 2025;

        // job1.Display();
        // job2.Display();
        Resume myresume = new Resume();
        myresume._name = "Javier Guerrero";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);

        myresume.Display();
    }
}
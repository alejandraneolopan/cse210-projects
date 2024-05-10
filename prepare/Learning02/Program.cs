using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company="Microsoft";
        job1._startYear= 2016;
        job1._endYear=2020;
        job1.Display();
        Job job2 = new Job();
        job2._jobTitle = "Senior developer";
        job2._company="Apple";
        job2._startYear= 2020;
        job2._endYear= 2024;
        job2.Display();

        Resume resume = new Resume();
        resume._name = "Allison Rose";
        resume.jobs.Add(job1);
        resume.jobs.Add(job2);
        resume.Display();
    }
}
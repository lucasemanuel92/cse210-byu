using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Maths and Physics Private Tutor";
        job1._company = "Êxito Acompanhamento Escolar";
        job1._startYear = 2014;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Full Stack Intern";
        job2._company = "Keep It Simple Solutions";
        job2._startYear = 2024;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Lucas Carvalho";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}
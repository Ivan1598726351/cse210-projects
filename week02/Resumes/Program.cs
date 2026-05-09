using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        
        Job job1 = new Job();
        job1._jobTitle= "Software engineer";
        job1._company= "Some company";
        job1._startYear=1990;
        job1._endYear=2000;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle="Salesman";
        job2._company="Some market";
        job2._startYear=1980;
        job2._endYear=1985;
        job2.Display();

        Resume Resume1 = new Resume();
        Resume1._name = "Allison Rose";

        Resume1._jobs.Add(job1);
        Resume1._jobs.Add(job2);

        Resume1.Display();



    }
}
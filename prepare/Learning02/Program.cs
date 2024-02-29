using System;

class Program
{
    static void Main(string[] args)
    {
        Resume myresume = new Resume();
        myresume.InitializeJob();
        myresume.InitializeJob();
        myresume._jobs[0]._company = "Microsoft";
        myresume._jobs[0]._jobTitle = "Software Engineer";
        myresume._jobs[0]._startYear = 2019;
        myresume._jobs[0]._endYear = 2022;
        myresume._jobs[1]._company = "Apple";
        myresume._jobs[1]._jobTitle = "Manager";
        myresume._jobs[1]._startYear = 2022;
        myresume._jobs[1]._endYear = 2023;
        myresume._name = "Allison Rose";
        myresume.DisplayResume();
    }
}